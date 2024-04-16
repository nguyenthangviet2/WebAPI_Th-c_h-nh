using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApiThucHanh.Models;
using WebApiThucHanh.Services;
using System;
using System.Threading.Tasks;

namespace WebApiThucHanh.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public Guid ID { get; private set; }

        public PublisherController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPublishers()
        {
            var publishers = await _libraryService.GetPublishersAsync();

            if (publishers == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No publishers in database");
            }

            return StatusCode(StatusCodes.Status200OK, publishers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPublisher(int id)
        {
            Publishers publisher = await _libraryService.GetPublishersAsync(ID);

            if (publisher == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, $"No Publisher found for id: {id}");
            }

            return StatusCode(StatusCodes.Status200OK, publisher);
        }

        [HttpPost]
        public async Task<ActionResult<Publishers>> AddPublisher(Publishers publisher)  
        {
            Publishers dbPublisher = await _libraryService.GetPublishersAsync(publisher);

            if (dbPublisher == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{publisher.Name} could not be added.");
            }

            return CreatedAtAction("GetPublisher", new { id = publisher.ID }, publisher);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePublisher(int id, Publishers publisher)
        {
            if (id != publisher.ID)
            {
                return BadRequest();
            }

            Publishers dbPublisher = await _libraryService.UpdatePublishersAsync(publisher);

            if (dbPublisher == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"{publisher.Name} could not be updated");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            var publisher = await _libraryService.GetPublishersAsync(id);
            (bool status, string message) = await _libraryService.DeletePublishersAsync(publisher);

            if (status == false)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, message);
            }

            return StatusCode(StatusCodes.Status200OK, publisher);
        }
    }
}

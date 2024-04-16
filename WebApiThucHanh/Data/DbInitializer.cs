using System;
using Microsoft.EntityFrameworkCore;
using WebApiThucHanh.Models;

namespace WebApiThucHanh.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            _builder.Entity<Author>().HasData(
                new Author
                {
                    ID = 1,
                    FullName = "J.K. Rowling",
                    
                },
                new Author
                {
                    ID = 2,
                    FullName = "Walter Isaacson",
                    
                });

            _builder.Entity<Book>().HasData(
                new Book
                {
                    ID = 1,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs.",
                   
                    PublisherID = 1,
                    
                },
                new Book
                {
                    ID = 2,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. ",
                   
                    PublisherID = 2,
                   
                },
                new Book
                {
                    ID = 3,
                    Title = "Steve Jobs",
                    Description = "Walter Isaacson’s “enthralling” (The New Yorker) worldwide bestselling biography of Apple cofounder Steve Jobs.",
                    
                    PublisherID = 3,
                   
                });
        }
    }
}

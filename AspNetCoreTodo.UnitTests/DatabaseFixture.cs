using System;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTodo.UnitTests
{
    public class DatabaseFixture
    {
        public DbContextOptions<ApplicationDbContext> options ;
        public DatabaseFixture()
        {
            options = new DbContextOptionsBuilder<ApplicationDbContext>()
                 .UseInMemoryDatabase("Test_AddNewItem").Options;
        }

    }
}
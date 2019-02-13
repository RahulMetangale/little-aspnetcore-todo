using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Data;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;


namespace AspNetCoreTodo.UnitTests
{
    public class TodoItemServiceShould : IClassFixture<DatabaseFixture>
    {
        private DbContextOptions<ApplicationDbContext> options;
        public TodoItemServiceShould(DatabaseFixture fixture)
        {
            options = fixture.options;
        }
        [Fact]
        public async Task AddNewItemAsIncompleteWithDueDate()
        {
            using (var context = new ApplicationDbContext(options))
            {
                var service = new TodoItemService(context);
                var fakeUser = new ApplicationUser
                {
                    Id = "fake-000",
                    UserName = "fake@example.com"
                };
                await service.AddItemAsync(new TodoItem
                {
                    Title = "Automated test"
                }, fakeUser);
            }
            using (var context = new ApplicationDbContext(options))
            {
                var itemsInDB = await context.Items.CountAsync();
                Assert.Equal(1, itemsInDB);
                var item = await context.Items.FirstAsync();
                Assert.Equal("Automated test", item.Title);
                Assert.Equal(false, item.IsDone);
                var difference = DateTimeOffset.Now.AddDays(3) - item.DueAt;
                Assert.True(difference < TimeSpan.FromSeconds(1));
            }
        }

        [Fact]
        public async Task MarkDoneShouldReturnFalseIfWrongUserIdPassed()
        {

        }
    }
}
using Microsoft.AspNetCore.Mvc;
using RQG.Controllers;
using RQG.Models;
using Xunit;
using Moq;
using Microsoft.EntityFrameworkCore;
using System;

namespace RQG.Tests.Controllers
{
    public class QuestionsControllerTest
    {
        [Fact]
        public void Random_ReturnsViewResult_WithQuestionModel_WhenSucceeded()
        {
            var options = new DbContextOptionsBuilder<RQGContext>()
                        .UseInMemoryDatabase(Guid.NewGuid().ToString())
                        .Options;
            var dbContext = new RQGContext(options);

            dbContext.AddRange(new Question[]{
                new Question{ ID = 1, Description = "Description 1", Answer = "Answer 1"},
                new Question{ ID = 3, Description = "Description 3", Answer = "Answer 3"},
            });
            dbContext.SaveChanges();

            var controller = new QuestionsController(dbContext);
            var result = controller.Random(null);
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Question>(viewResult.Model);
        }
    }
}

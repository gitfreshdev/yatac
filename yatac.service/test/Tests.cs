using System;
using Xunit;
using yatac.service.Controllers;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void GetSystemById_EmptyGuidArgumentException() 
        {
            GameSystemController gameSystemController = new GameSystemController();
            Assert.Throws<ArgumentOutOfRangeException>(() => gameSystemController.GetSystemById(Guid.Empty));
        }
    }
}

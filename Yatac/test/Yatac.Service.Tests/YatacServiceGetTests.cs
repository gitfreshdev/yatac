using System;
using Xunit;
using Yatac.Service.Controllers;

namespace Yatac.Service.Tests
{
    public class YatacServiceGetTests
    {
        [Fact]
        public void GetSystemById_EmptyGuidArgumentException()
        {
            var gameSystemController = new GameSystemController();
            Assert.Throws<ArgumentOutOfRangeException>(() => gameSystemController.GetSystemById(Guid.Empty));
        }
    }
}

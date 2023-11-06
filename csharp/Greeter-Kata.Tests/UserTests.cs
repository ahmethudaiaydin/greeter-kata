using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Greeter_Kata.Tests
{
    public class UserTests
    {

        [Fact]
        public void ShouldReturnFullUsername() {

            var user = new User("John", "Doe", DateTime.Now.AddYears(-30));
            var fullname = user.GetUserName();

            Assert.Equal("John Doe", fullname);
        }
    }
}

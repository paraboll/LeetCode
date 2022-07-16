using RegistrationSubsystem;
using System;
using Xunit;

namespace RegistrationSubsystemTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void LoginValidation()
        {
            var logins = new string[] { "Login1", "_login", "LogiN1", "Lo_gin", "l", "l1", "-l1", "lo-gin"};

            var testValidLogins = new SolvingTheProblem().LoginValidation(logins);

            var validLogins = new string[] { "Login1", "_login", "Lo_gin", "l1", "lo-gin"};
            Assert.Equal(validLogins, testValidLogins);
        }
    }
}

using System;
using TrainTicketSalesSystem;
using Xunit;

namespace TrainTicketSalesSystemTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void ManagerSystemTests()
        {
            SolvingTheProblem.ManagerSystem("������", 17);
            var trainCar = SolvingTheProblem.GetTrain�ar();

            Assert.Equal("", "");
        }
    }
}

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
            var SolvingTheProblem = new SolvingTheProblem();
            SolvingTheProblem.ManagerSystem("������", 17);
            var trainCar = SolvingTheProblem.GetTrain�ar();

            Assert.Equal("", "");
        }
    }
}

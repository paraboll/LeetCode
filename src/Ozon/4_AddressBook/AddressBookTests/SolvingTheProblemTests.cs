using AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AddressBookTests
{
    public class SolvingTheProblemTests
    {
        [Fact]
        public void CallNumbers()
        {
            var numbers = new string[,]
            {
                { "test1", "12341" }, //свежая
                { "test2", "35672" },
                { "test3", "25673" },
                { "test1", "12344" },
                { "test2", "35675" },
                { "test3", "25676" },
                { "test1", "12347" },
                { "test2", "35678" },
                { "test3", "25679" },
                { "test1", "12344" },
                { "test2", "35672" },
                { "test3", "25673" },
                { "test1", "12348" },
                { "test2", "35675" },
                { "test3", "25676" },
                { "test1", "12343" },
                { "test2", "35678" },
                { "test3", "25679" }, //старая
            };

            var callNumbers = new SolvingTheProblem().CallNumbers(numbers);

            var numbersTest1 = new string[] { "12341", "12344", "12347", "12344", "12348" };
            var numbersQueueTest1 = new Queue<string>(numbersTest1);

            var result = callNumbers.First(x => x.Key == "test1").Value;
            Assert.Equal(numbersQueueTest1, result);
        }
    }
}

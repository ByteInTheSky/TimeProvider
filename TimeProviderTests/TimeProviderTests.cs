using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace TimeProvider.Tests
{
    [TestClass()]
    public class TimeProviderTests
    {
        [TestMethod()]
        public void Get_Next_Minute_From_Current_Time()
        {
            // Arrange
            var dateTimeNowProvider = new Mock<IDateTimeNowProvider>();
            dateTimeNowProvider.Setup(x => x.DateTimeNow).Returns(new DateTime(2022, 6, 12, 11, 15, 0));
            TimeProvider timeProvider = new TimeProvider(dateTimeNowProvider.Object);

            // Act
            DateTime actual = timeProvider.GetNextOneMinuteFromNow();

            // Assert
            DateTime exptected = new DateTime(2022, 6, 12, 11, 16, 0);
            Assert.AreEqual(exptected, actual);
        }
    }
}
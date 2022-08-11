using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.QualityTools.Testing.Fakes;

namespace TimeProvider.Tests
{
    [TestClass()]
    public class TimeProviderTests
    {
        [TestMethod()]
        public void Get_Next_Minute_From_Current_Time()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                System.Fakes.ShimDateTime.NowGet =
                                () =>
                                { return new DateTime(2022, 6, 12, 11, 15, 0); };

                // Act
                TimeProvider timeProvider = new TimeProvider();
                DateTime actual = timeProvider.GetNextOneMinuteFromNow();

                // Assert
                DateTime expected = new DateTime(2022, 6, 12, 11, 16, 0);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
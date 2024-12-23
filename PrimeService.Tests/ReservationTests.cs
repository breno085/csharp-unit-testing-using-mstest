using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prime;

namespace PrimeService.Tests;

[TestClass]
public class ReservationTests
{
    [TestMethod]
    public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
    {
        // Arrange
        var reservation = new Reservation();

        // Act
        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        // Assert
        Assert.IsTrue(result);
    }
}
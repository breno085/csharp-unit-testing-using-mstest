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

    [TestMethod]
    public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
    {
        // Arrange
        var user = new User();

        var reservation = new Reservation { MadeBy = user };

        // Act
        var result = reservation.CanBeCancelledBy(user);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnFalse()
    {
        var reservation = new Reservation { MadeBy = new User() };

        var result = reservation.CanBeCancelledBy(new User());

        Assert.IsFalse(result);
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
using System;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // 3A Pattern
            // Arrange 安排 - 初始化物件
            var reservation = new Reservation();

            // Act 行動 - 執行要測試的方法
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert 斷言 - 驗證結果是否正確
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}

using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController controller;

        [SetUp]
        public void Setup()
        {
            controller = new CustomerController();
        }   

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = controller.GetCustomer(0);

            //NotFound object
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound or one of its derivatives1
            //Assert.That(result, Is.InstanceOf<Ok>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

using P040_InterfacesPolymorphism;
using P040_InterfacesPolymorphism.Domain.Interfaces;
using P040_InterfacesPolymorphism.Domain.Models;

namespace Polymorphism_tests
{
    [TestClass]
    public class Emplyee_tests
    {

        [TestMethod]
        public void EmployeeEmptyConstruktorTest()
        {
            // Arrange
            Employee employee = new Employee();
            
            var expectedID = 1;
            var expectedName = "Vardenis";
            var expectedSalary = employee.GetSalary();
            var expectedAddress = "";

            //Act
            var actualID = employee.Id;
            var actualName = employee.Name;
            var actualSalary = employee.GetSalary();
            var actualAddress = employee.GetAddress();

            //Assert
            Assert.AreEqual(expectedID, actualID);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedSalary, actualSalary);
            Assert.AreEqual(expectedAddress, actualAddress);
        }

        [TestMethod]
        public void EmployeeGetAdressTest()
        {
            // Arrange
            IPayable employee = new Employee(salary:1000, mailingAddress:"Adresas 1");
            var expectedAdress = "Adresas 1";

            // Act
            var actual = employee.GetAddress();

            // Assert
            Assert.AreEqual(expectedAdress, actual);
        }

        [TestMethod]
        public void EmployeeGetSalaryTest()
        {
            IPayable employee = new Employee(salary: 1000, mailingAddress: "Adresas 1");

            var expectedSalary = 1000;
            var actual = employee.GetSalary();
           Assert.AreEqual(expectedSalary, actual);
        }

        [TestMethod]
        public void EmployeeIncreaseSalaryTest()
        {
            IPayable employee = new Employee(salary: 1000, mailingAddress: "Adresas 1");

            employee.IncreaseSalary(100);
            var expectedSalary = 1100;
            var actual = employee.GetSalary();
            Assert.AreEqual(expectedSalary, actual);
        }

    }
}

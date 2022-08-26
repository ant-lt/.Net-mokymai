using P040_InterfacesPolymorphism;
using P040_InterfacesPolymorphism.Domain.Interfaces;
using P040_InterfacesPolymorphism.Domain.Models;

namespace Polymorphism_tests
{
    [TestClass]
    public class Emplyee_tests
    {

        [TestMethod]
        public void EmployeeGetAdressTest()
        {
            IPayable employee = new Employee(1000, "Adresas 1");
            var expectedAdress = "Adresas 1";
            var actual = employee.GetAddress();

            Assert.AreEqual(expectedAdress, actual);
        }

        [TestMethod]
        public void EmployeeGetSalaryTest()
        {
            IPayable employee = new Employee(1000, "Adresas 1");
 
            var expectedSalary = 1000;
            var actual = employee.GetSalary();
           Assert.AreEqual(expectedSalary, actual);
        }

        [TestMethod]
        public void EmployeeIncreaseSalaryTest()
        {
            IPayable employee = new Employee(1000, "Adresas 1");

            employee.IncreaseSalary(100);
            var expectedSalary = 1100;
            var actual = employee.GetSalary();
            Assert.AreEqual(expectedSalary, actual);
        }

    }
}

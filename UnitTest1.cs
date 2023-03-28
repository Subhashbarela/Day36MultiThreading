using System.Collections.Generic;
using Day36EmployeePayRollUsingThread;
namespace EmployeePayRollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Givent10Employee_AddedToList()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "bruce",phoneNumber: "8765456787",address: "xyz", department: "engg",gender: 'M',basicPay: 100, deduction: 2,taxablePay:20,tax: 100,netPay:400,city: "chopda",country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 2, employeeName: "yarn", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 3, employeeName: "bruce", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 4, employeeName: "messi", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 5, employeeName: "bravo", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 6, employeeName: "bang", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 7, employeeName: "bruce", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 8, employeeName: "bruce", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 9, employeeName: "bruce", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 10, employeeName: "bruce", phoneNumber: "8765456787", address: "xyz", department: "engg", gender: 'M', basicPay: 100, deduction: 2, taxablePay: 20, tax: 100, netPay: 400, city: "chopda", country: "india"));

            EmployeePayRollOperation EmpPayRollOp1 = new EmployeePayRollOperation();
            DateTime startDateTime1 = DateTime.Now;
            EmpPayRollOp1.addEmpToPayRoll(employeeDetails);
            DateTime stopDateTime1 = DateTime.Now;
            Console.WriteLine("Duration without thread " + (stopDateTime1 - startDateTime1));

            EmployeePayRollOperation EmpPayRollOp2 = new EmployeePayRollOperation();
            DateTime startDateTime2 = DateTime.Now;
            EmpPayRollOp2.addEmpToPayRollWithThread(employeeDetails);
            DateTime stopDateTime2 = DateTime.Now;
            Console.WriteLine("Duration with thread " + (stopDateTime2 - startDateTime2));
        }
    }
}
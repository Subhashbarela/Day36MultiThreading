using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36EmployeePayRollUsingThread
{
    public class EmployeePayRollOperation
    {
        public List<EmployeeDetails> empDataList = new List<EmployeeDetails>();
       
        // Uc1 - non thread
        public void addEmpToPayRoll(List<EmployeeDetails> empDataList)
        {
            empDataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added " + employeeData.EmployeeName);
                this.addEmpToPayRoll(employeeData);
                Console.WriteLine("Employee added "+ employeeData.EmployeeName);
            });
            Console.WriteLine(this.empDataList.ToString());
        }
        
        // UC2 using thread concept
        public void addEmpToPayRollWithThread(List<EmployeeDetails> empDataList)
        {
            empDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added " + employeeData.EmployeeName);
                    this.addEmpToPayRoll(employeeData);
                    Console.WriteLine("Employee added " + employeeData.EmployeeName);
                });
                thread.Start();
              
            });
            Console.WriteLine(this.empDataList.ToString());
        }

        private void addEmpToPayRoll(EmployeeDetails emp)
        {
           empDataList.Add(emp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36EmployeePayRollUsingThread
{
    public class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department  { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public EmployeeDetails(int employeeID, string employeeName, string phoneNumber, string address, string department, char gender, double basicPay, double deduction, double taxablePay, double tax, double netPay, string city, string country)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            PhoneNumber = phoneNumber;
            Address = address;
            Department = department;
            Gender = gender;
            BasicPay = basicPay;
            Deduction = deduction;
            TaxablePay = taxablePay;
            Tax = tax;
            NetPay = netPay;
            City = city;
            Country = country;
        }
    }
}

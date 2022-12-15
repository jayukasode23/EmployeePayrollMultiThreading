using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollOperation
{
    public class EmployeeDetails
    {
        public int Employeeid { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double Basicpay { get; set; }
        public double Deduction { get; set; }
        public double Taxablepay { get; set; }
        public double Tax { get; set; }
        public double Netpay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public EmployeeDetails(int employeeID, string employeeName, string phoneNumber, string address, string department, string gender, double basicpay, double deduction, double taxablepay, double tax, double netpay, string city, string country)
        {
            Employeeid = employeeID;
            EmployeeName = employeeName;
            PhoneNumber = phoneNumber;
            Address = address;
            Department = department;
            Gender = gender;
            Basicpay = basicpay;
            Deduction = deduction;
            Taxablepay = taxablepay;
            Tax = tax;
            Netpay = netpay;

            City = city;
            Country = country;


        }




    }
}

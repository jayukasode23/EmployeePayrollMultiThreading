using EmployeePayrollOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;


namespace EmployeepayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmployeeWhenAddedToListShouldMatchEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Bruce1", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 2, employeeName: "Rita", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 3, employeeName: "Vijay", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 4, employeeName: "Ramesh", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 5, employeeName: "Suresh", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 6, employeeName: "Sam", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 7, employeeName: "Jhon", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 8, employeeName: "geeta", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 9, employeeName: "Joe", phoneNumber: "23564885", address: "xyz", department: "Hr", gender: "M", basicpay: 3433, deduction: 1000, taxablepay: 200, tax: 300, netpay: 2000, city: "Banglore", country: "India"));

            EmployeePayroll employeepayRoll = new EmployeePayroll();
            DateTime startDateTime = DateTime.Now;
            employeepayRoll.addEmployeeToPayRoll(employeeDetails);

            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread:" + (stopDateTime = startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeepayRoll.addEmployeeToPayRollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread:" + (stopDateTimeThread = startDateTimeThread));
        }
    }
}
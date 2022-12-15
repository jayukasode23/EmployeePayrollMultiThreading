using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollOperation
{
    /// <summary>
    /// Here We Check Ability to add multiple employee to payroll database.
    /// Use addEmployeeTopayroll ,Record the start and stop time to essentially determine the time taken for the execution.
    public class EmployeePayroll
    {
        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
        public void addEmployeeToPayRoll(List<EmployeeDetails> listemployeedetails)
        {
            listemployeedetails.ForEach(employeedata =>

            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added:" + employeedata.EmployeeName);
                    this.addEmployeeToPayRoll(employeedata);
                    Console.WriteLine("Employee  added:" + employeedata.EmployeeName);

                });
                thread.Start();
            });
            Console.WriteLine(this.employeeDetails.ToString());
        }


        private void addEmployeeToPayRoll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }
        public void addEmployeeToPayRollWithThread(List<EmployeeDetails> listemployeedetails)
        {
            listemployeedetails.ForEach(employeedata =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added:" + employeedata.EmployeeName);
                    this.addEmployeeToPayRoll(employeedata);
                    Console.WriteLine("Employee  added:" + employeedata.EmployeeName);

                });
                thread.Start();
            });
            Console.WriteLine(this.employeeDetails.ToString());
        }
    }
}
    
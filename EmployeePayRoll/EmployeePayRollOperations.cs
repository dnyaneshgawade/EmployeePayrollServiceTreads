using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    public class EmployeePayRollOperations
    {
        public List<EmployeeDetails> EmployeeDetails = new List<EmployeeDetails>();
        public void AddEmployeePayroll(List<EmployeeDetails> EmployeeDetails)
        {
            EmployeeDetails.ForEach(EmployeeDeta =>
            {
                Console.WriteLine("Emp bieng Added: " + EmployeeDeta.EmployeeName);
                this.AddEmployeePayroll(EmployeeDeta);
                Console.WriteLine("Emp added:" + EmployeeDeta.EmployeeName);
            });
            Console.WriteLine(this.EmployeeDetails.ToString());
        }

        public void AddEmployeeToPayrollWithTread(List<EmployeeDetails> list)
        {
            list.ForEach(EmployeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Emp bieng Added: " + EmployeeData.EmployeeName);
                    this.AddEmployeePayroll(EmployeeData);
                    Console.WriteLine("Emp added:" + EmployeeData.EmployeeName);

                });
                thread.Start();
                Console.WriteLine(this.EmployeeDetails.Count);
            }
            );
        }

        public void AddEmployeePayroll(EmployeeDetails emp)
       {
            EmployeeDetails.Add(emp);
       }

        
    }
}

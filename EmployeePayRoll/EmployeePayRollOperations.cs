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
    
       public void AddEmployeePayroll(EmployeeDetails emp)
       {
            EmployeeDetails.Add(emp);
       }

        
    }
}

using EmployeePayRoll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeePayRollTest
{
    [TestClass]
    public class UnitTest1
    {
        EmployeePayRollOperations employeePayRollOperations = new EmployeePayRollOperations();
        public List<EmployeeDetails> list = new List<EmployeeDetails>
        {
            new EmployeeDetails { EmployeeId = 1, EmployeeName = "Dnyanesh", PhoneNumber = "9898989898", Address = "Pune", Department = "Developer", Gender = 'M', BasicPay = 40000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 36000, City = "Pune", Country = "India" },
            new EmployeeDetails { EmployeeId = 2, EmployeeName = "Saumya", PhoneNumber = "9898900000", Address = "Mahim", Department = "Salse", Gender = 'F', BasicPay = 45000, Deductions = 5000, TaxablePay = 3000, Tax = 1000, NetPay = 40000, City = "Mumbai", Country = "India" },
            new EmployeeDetails { EmployeeId = 3, EmployeeName = "Akshay", PhoneNumber = "9878787878", Address = "Chennai", Department = "Management", Gender = 'M', BasicPay = 50000, Deductions = 6000, TaxablePay = 3000, Tax = 1000, NetPay = 44000, City = "Chennai", Country = "India" },
            new EmployeeDetails { EmployeeId = 4, EmployeeName = "Rohit", PhoneNumber = "7898898989", Address = "Wosco", Department = "Tester", Gender = 'M', BasicPay = 30000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 26000, City = "Goa", Country = "India" },
            new EmployeeDetails { EmployeeId = 5, EmployeeName = "Mayuresh", PhoneNumber = "7777777777", Address = "Delhi", Department = "Marketing", Gender = 'M', BasicPay = 41000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 37000, City = "Delhi", Country = "India" },
            new EmployeeDetails { EmployeeId = 6, EmployeeName = "Rutuja", PhoneNumber = "9999999999", Address = "Kolhapur", Department = "Developer", Gender = 'F', BasicPay = 42000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 38000, City = "Kolhapur", Country = "India" },
            new EmployeeDetails { EmployeeId = 7, EmployeeName = "Aish", PhoneNumber = "8989898989", Address = "Aagra", Department = "Salse", Gender = 'F', BasicPay = 44000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 40000, City = "Aagra", Country = "India" },
            new EmployeeDetails { EmployeeId = 8, EmployeeName = "Ayush", PhoneNumber = "8888888888", Address = "Mulund", Department = "Marketing", Gender = 'M', BasicPay = 52000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 48000, City = "Mumbai", Country = "India" },
            new EmployeeDetails { EmployeeId = 9, EmployeeName = "Sanket", PhoneNumber = "9000000000", Address = "Pune", Department = "Management", Gender = 'M', BasicPay = 44000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 50000, City = "Pune", Country = "India" },
            new EmployeeDetails { EmployeeId = 10, EmployeeName = "Maria", PhoneNumber = "9999900000", Address = "Panjim", Department = "Tester", Gender = 'F', BasicPay = 56000, Deductions = 4000, TaxablePay = 3000, Tax = 1000, NetPay = 32000, City = "Goa", Country = "India" }
        };
        [TestMethod]
        public void Given10Employee_AddedToList_ShouldMatchEmployeeEntries()
        {
            DateTime startDateTime = DateTime.Now;
            employeePayRollOperations.AddEmployeePayroll(list);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread" + (stopDateTime - startDateTime));

        }

        [TestMethod]
        public void Given10Employee_AddedToListUsingThread_ShouldMatchEmployeeEntries()
        {
            DateTime startDateTimeThread = DateTime.Now;
            employeePayRollOperations.AddEmployeeToPayrollWithTread(list);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread" + (stopDateTimeThread - startDateTimeThread));

        }
    }
}

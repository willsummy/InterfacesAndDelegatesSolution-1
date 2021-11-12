using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndDelegates
{
    public abstract class Person: IProvideCompensationInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract decimal GetHourlyPay();


        public abstract decimal GetMonthlyPay();

        public abstract decimal GetWeeklyPay();


        public abstract decimal GetYearlyPay();
        
    }

    public class Employee : Person
    {
        public override decimal GetHourlyPay()
        {
            return 99; // (salary divided by number hours in a year
        }

        public override decimal GetMonthlyPay()
        {
            return 32; // salary divided by 12
        }

        public decimal GetSalary()
        {
            // do something real
            return 0;
        }

        public override decimal GetWeeklyPay()
        {
            return 52;
        }

        public override decimal GetYearlyPay()
        {
            return GetSalary();
        }
    }

    public class Contractor : Person
    {
        public override decimal GetHourlyPay()
        {
            return GetHourlyPay();
        }

        public decimal GetHourlyRate()
        {
            return 42;
        }

        public override decimal GetMonthlyPay()
        {
            return GetHourlyPay() * 40 * 4;
        }

        public override decimal GetWeeklyPay()
        {
            return GetHourlyPay() * 40;
        }

        public override decimal GetYearlyPay()
        {
            return GetHourlyPay() * 40 * 365;
        }

        public void SendI9()
        {

        }
    }

    public class Retiree : Person
    {
        public void SendGoldWatch()
        {

        }
        public decimal GetPension()
        {
            return 120000;
        }

        public override decimal GetHourlyPay()
        {
            return 42;
        }

        public override decimal GetMonthlyPay()
        {
            return 300;
        }

        public override decimal GetWeeklyPay()
        {
            return 89;
        }

        public override decimal GetYearlyPay()
        {
            return GetPension();
        }
    }

    public class MainFrame : IProvideCompensationInformation
    {
        public decimal GetHourlyPay()
        {
            throw new NotImplementedException();
        }

        public decimal GetMonthlyPay()
        {
            throw new NotImplementedException();
        }

        public decimal GetWeeklyPay()
        {
            throw new NotImplementedException();
        }

        public decimal GetYearlyPay()
        {
            throw new NotImplementedException();
        }

        public decimal WeeklyContract()
        {
            return 8000;
        }
    }


    // Interfaces are groups of related behaviors
    // that form a contract that says that the class that 
    // implements them "Can do those behaviors"
    // -- or --
    // "Interfaces describe abstract behaviors.
    // Classes provide concrete code that implement interfaces
    // That's it, the rest is details" - Don Box, 1999

    public interface IProvideCompensationInformation
    {
        decimal GetMonthlyPay();
        decimal GetWeeklyPay();
        decimal GetHourlyPay();
        decimal GetYearlyPay();
    }
}

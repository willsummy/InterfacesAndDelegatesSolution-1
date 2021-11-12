using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndDelegates
{
    public class HrUtils
    {
        public decimal GetTotalCompensationFor(Employee emp)
        {
           
            return emp.GetSalary();
        }
        public PayReport GetTotalCompensationFor(List<IProvideCompensationInformation> comp)
        {

            var response = new PayReport
            {
                TotalHourlyCompensation = comp.Sum(c => c.GetHourlyPay()),
                TotalMonthlyCompensation = comp.Sum(c => c.GetMonthlyPay()),
                TotalYearlyCompensation = comp.Sum(c => c.GetYearlyPay()),
                TotalWeeklyCompensation = comp.Sum(c => c.GetWeeklyPay())
            };
            return response;

        }

        public string GetInfo(Person emp)
        {
            return "";
        }


    }
    public class PayReport
    {
        public decimal TotalYearlyCompensation { get; set; }
        public decimal TotalMonthlyCompensation { get; set; }
        public decimal TotalWeeklyCompensation { get; set; }
        public decimal TotalHourlyCompensation { get; set; }

    }
}

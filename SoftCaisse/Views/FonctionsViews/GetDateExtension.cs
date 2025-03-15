using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Caisse.Views.FonctionsViews
{
    internal static class GetDateExtensions
    {

        public static DateTime GetFirstDayOfMonth()
        {
            DateTime dateTimeNow = DateTime.Now;
            return new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
        }

        public static DateTime GetLastDayOfMonth()
        {
            DateTime dateTimeNow = DateTime.Now;
            return new DateTime(dateTimeNow.Year, dateTimeNow.Month, DateTime.DaysInMonth(dateTimeNow.Year, dateTimeNow.Month));
        }

    }
}

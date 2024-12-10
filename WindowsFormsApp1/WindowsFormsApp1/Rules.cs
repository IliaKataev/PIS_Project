using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Rules
    {
        DateTime userData;

        public Rules()
        {
            //if( obj.CheckDate() == true && purpose.Is = Трудоустройство){

        }

        public bool CheckDate(DateTime date)
        {
            double daysLeft = (((DateTime.Now.Year) / 365.5) - (date.Year / 365.5));

            if ((((DateTime.Now.Year)/365.5) - (date.Year/365.5)) < 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckCitizenship(string citizenship)
        {
            // Пример проверки гражданства
            return !string.IsNullOrEmpty(citizenship);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyPIS
{
    public enum Country // енам для хранения стран
    {
        Азербайджан,
        Таджикистан,
        Узбекистан,
        Молдова,
        Украина,
        Киргизия,
        Казахстан,
        Армения,
        Другая,
    }
    public class UserModel
    {
        public DateTime EntryDate { get; set; } // дата въезда
        public string ArrivalPurpose { get; set; } // цель прибытия
        public bool HasInsurance { get; set; } // наличие полиса
        public Country OriginCountry { get; set; } // страна гражданина

        public int DaysSinceEntry => (DateTime.Now - EntryDate).Days; // дней со въезда
    }
}

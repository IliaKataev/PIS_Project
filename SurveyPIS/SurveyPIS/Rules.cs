using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyPIS
{
    public class Rules
    {
        public string CheckMedical(UserModel user)
        {
            if(user.DaysSinceEntry < 90)
            {
                if(user.ArrivalPurpose == "Трудоустройство")
                {
                    return user.DaysSinceEntry < 30
                        ? $"Для получения мед. освидетельствования обратитесь в организацию. " +
                        $"Вам нужно пройти освидетельствование до {user.EntryDate.AddDays(30):dd.MM.yy}."
                        : $"К сожалению, вы просрочили срок получения на {user.DaysSinceEntry - 30} дней. " +
                        $"Обратитесь в миграционную службу.";
                }
                else if(user.ArrivalPurpose == "Длительное пребывание(более 90 дней)")
                {
                    return $"Для получения мед. освидетельствования обратитесь " +
                        $"в организацию до {user.EntryDate.AddDays(90):dd.MM.yy} .";
                }
                else return "Вам не нужно получать результаты мед. освидетельствования.";
            }
            else
            {
                if (user.ArrivalPurpose == "Трудоустройство" || user.ArrivalPurpose == "Длительное пребывание(более 90 дней)")
                {
                    return user.ArrivalPurpose == "Трудоустройство"
                        ? $"К сожалению, вы просрочили срок получения на {user.DaysSinceEntry - 30} дней. " +
                          $"Обратитесь в миграционную службу."
                        : $"К сожалению, вы просрочили срок получения на {user.DaysSinceEntry - 90} дней. " +
                          $"Обратитесь в миграционную службу.";
                }
                else return "Обратитесь в миграционную службу";
            }
        }

        public string CheckInsurance(UserModel user)
        {
            if (user.HasInsurance)
                return "Вам не нужно оформлять полис.";

            if (IsFromListedCountry(user.OriginCountry) && user.ArrivalPurpose == "Трудоустройство")
                return "Для получения полиса обратитесь в страховую компанию по месту пребывания.";

            return "Вам не нужно оформлять полис.";
        }

        public static bool IsFromListedCountry(Country country) =>
            Enum.IsDefined(typeof(Country), country) && country != Country.Другая;
    }
}

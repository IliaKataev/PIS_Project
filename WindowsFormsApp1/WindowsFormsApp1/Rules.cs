using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Rules
    {
        private UserData userData;
        private MainController controller;

        public Rules(UserData userData, MainController cntr)
        {
            this.userData = userData;
            this.controller = cntr;
        }

        public int DaysLeft
        {
            get
            {
                return (int)((DateTime.Now - userData.SelectedDate).TotalDays);
            }
        }

        public void CheckDate()
        {
            if (DaysLeft > 90)
            {
                MessageBox.Show("Вы просрочили срок получения результатов мед.освидетельствования. Вам необходимо обратиться в ммиграционную службу.");
                controller.Reset();
            }
            else
                controller.ShowPurposeControl();
        }

        public void CheckPurpose()
        {
            if (DaysLeft > 30)
            {
                if (userData.Purpose == "Трудоустройство")
                {
                    MessageBox.Show($"К сожалению, вы просрочили срок получения на {DaysLeft - 30} дней. Обратитесь в миграционную службу.");
                    controller.Reset();
                }
                else if (userData.Purpose == "Длительное пребывание(более 90 дней)")
                    controller.ShowOrganizationControl();
                else
                {
                    MessageBox.Show("Вам не нужно получать результаты мед.освидетельствования.");
                    controller.Reset();
                }
            }
            else
                controller.ShowOrganizationControl();
        }



        public bool CheckCitizenship(string citizenship)
        {
            // Пример проверки гражданства
            return !string.IsNullOrEmpty(citizenship);
        }

        //Enum.GetNames(typeof(Country)).Contains(userData.Purpose)
    }
}

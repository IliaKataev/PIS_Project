using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyPIS
{
    internal class Controller
    {
        private readonly Rules rules;

        public Controller()
        {
            rules = new Rules();
        }

        public void StartMedical(DateTime entryDate, string arrivalPurpose)
        {
            var user = new UserModel
            {
                EntryDate = entryDate,
                ArrivalPurpose = arrivalPurpose
            };

            string result = rules.CheckMedical(user);
            if (result != null)
            {
                MessageBox.Show(result);
            }
        }

        public void StartInsurance(DateTime entryDate, string arrivalPurpose, bool hasInsurance, Country country)
        {
            var user = new UserModel
            {
                EntryDate = entryDate,
                ArrivalPurpose = arrivalPurpose,
                HasInsurance = hasInsurance,
                OriginCountry = country
            };

            string result = rules.CheckInsurance(user);
            if (result != null) 
            {
                MessageBox.Show(result);
            }
        }

    }
}

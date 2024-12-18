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
        private readonly UserModel user;

        public Controller()
        {
            rules = new Rules();
            user = new UserModel();
        }

        public void StartMedical(DateTime entryDate, string arrivalPurpose)
        {
            user.EntryDate = entryDate;
            user.ArrivalPurpose = arrivalPurpose;

            string result = rules.CheckMedical(user);
            if (result != null)
            {
                MessageBox.Show(result);
            }
        }

        public void StartInsurance(string arrivalPurpose, bool hasInsurance, Country country)
        {
            user.ArrivalPurpose = arrivalPurpose;
            user.HasInsurance = hasInsurance;
            user.OriginCountry = country;

            string result = rules.CheckInsurance(user);
            if (result != null) 
            {
                MessageBox.Show(result);
            }
        }

    }
}

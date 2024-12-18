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

        public void StartMedical(UserModel user)
        {
            string result = rules.CheckMedical(user);
            if (result != null)
            {
                MessageBox.Show(result);
            }
        }

        public void StartInsurance(UserModel user)
        {
            string result = rules.CheckInsurance(user);
            if (result != null) 
            {
                MessageBox.Show(result);
            }
        }

    }
}

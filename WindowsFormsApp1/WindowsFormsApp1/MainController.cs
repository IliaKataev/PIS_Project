using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1
{
    public class MainController
    {
        private Form mainForm;
        private UserData userData;
        private Rules rules;

        public MainController(Form form)
        {
            mainForm = form;
            userData = new UserData();
            rules = new Rules(userData, this);
        }

        public void StartMedicalScenario()
        {
            ShowDateControl();
        }

        public void StartInsuranceScenario()
        {
            ShowCitizenshipControl();
        }

        public void ShowDateControl()
        {
            var dateControl = new DateControl(userData, this);
            SwitchToControl(dateControl);
        }

        public void ShowPurposeControl()
        {
            var purposeControl = new PurposeControl(userData, this);
            SwitchToControl(purposeControl);
        }

        public void ShowOrganizationControl()
        {
            var organizationControl = new OrganizationControl(userData, this, "медицинское освидетельствование");
            SwitchToControl(organizationControl);
        }

        public void ShowCitizenshipControl()
        {
            var citizenshipControl = new CitizenshipControl(userData, this);
            SwitchToControl(citizenshipControl);
        }

        //public void ShowInsuranceOrganizationControl()
        //{
        //    var organizationControl = new OrganizationControl(userData, this, "страховая компания");
        //    SwitchToControl(organizationControl);
        //}

        public void SwitchToControl(UserControl control)
        {
            mainForm.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainForm.Controls.Add(control);
        }

        public void Reset()
        {
            this.mainForm.Controls.Clear();
        }
    }
}

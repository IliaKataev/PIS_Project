using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyPIS
{
    public partial class Form1 : Form
    {
        private Controller controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void buttonMed_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value == null || comboBoxPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните дату въезда и цель прибытия.");
                return;
            }

            var user = new UserModel
            {
                EntryDate = dateTimePicker1.Value,
                ArrivalPurpose = comboBoxPurpose.SelectedItem.ToString(),

            };

            controller.StartMedical(user);
        }

        private void buttonPolis_Click(object sender, EventArgs e)
        {
            if (comboBoxPolis.SelectedIndex == -1 || comboBoxPurpose.SelectedIndex == -1 || comboBoxCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните цель прибытия, страну, а также поле наличия полиса для оформления документа.");
                return;
            }

            var user = new UserModel
            {
                EntryDate = dateTimePicker1.Value,
                ArrivalPurpose = comboBoxPurpose.SelectedItem.ToString(),
                HasInsurance = comboBoxPolis.SelectedItem.ToString() == "Да",
                OriginCountry = (Country)Enum.Parse(typeof(Country), comboBoxCountry.SelectedItem.ToString())
            };

            controller.StartInsurance(user);
        }
    }
}

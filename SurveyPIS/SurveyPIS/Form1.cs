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

            controller.StartMedical(
            dateTimePicker1.Value,
            comboBoxPurpose.SelectedItem.ToString()
            );
        }

        private void buttonPolis_Click(object sender, EventArgs e)
        {
            if (comboBoxPolis.SelectedIndex == -1 || comboBoxPurpose.SelectedIndex == -1 || comboBoxCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните цель прибытия, страну, а также поле наличия полиса для оформления документа.");
                return;
            }

            controller.StartInsurance(
            comboBoxPurpose.SelectedItem.ToString(),
            comboBoxPolis.SelectedItem.ToString() == "Да",
            (Country)Enum.Parse(typeof(Country), comboBoxCountry.SelectedItem.ToString())
            );
        }
    }
}

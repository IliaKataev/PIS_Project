using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private UserControl currentControl; // Текущий отображаемый UserControl

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            // Показать интерфейс Option1Control
            var option1Control = new MedControl();
            SwitchControl(option1Control);
            
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            // Показать интерфейс Option2Control
            var option2Control = new PolisControl();
            SwitchControl(option2Control);
        }

        private void SwitchControl(UserControl newControl)
        {
            // Удаляем предыдущий UserControl
            if (currentControl != null)
            {
                Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            // Устанавливаем новый UserControl
            currentControl = newControl;
            currentControl.Dock = DockStyle.Fill;

            // Добавляем UserControl к форме
            Controls.Add(currentControl);
        }

    }
}

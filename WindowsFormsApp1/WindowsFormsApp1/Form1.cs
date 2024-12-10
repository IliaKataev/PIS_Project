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
            MyUserControl medControl = new MedControl();
            MyUserControl.SwitchToControl(this, medControl);

        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            // Показать интерфейс Option2Control
            MyUserControl.SwitchToControl(this.Parent, new PolisControl());
        }
    }
}

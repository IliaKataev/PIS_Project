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
    public partial class MedControl : UserControl
    {
        public MedControl()
        {
            InitializeComponent();

            Label lblMessage = new Label
            {
                Text = "Это интерфейс для первого выбора.",
                AutoSize = true,
                Location = new Point(10, 10)
            };

            TextBox answer1 = new TextBox
            {
                Size = new Size(100, 20),
                Location = new Point(150, 250)
            };

            Button buttonAnswer1 = new Button
            {
                Text = "Далее",
                Location = new Point(150, 270)
            };


            this.Controls.Add(lblMessage);
            this.Controls.Add(answer1);
            this.Controls.Add(buttonAnswer1);
        }
    }
}

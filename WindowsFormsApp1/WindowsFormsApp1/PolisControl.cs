﻿using System;
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
    public partial class PolisControl : UserControl
    {
        public PolisControl()
        {
            InitializeComponent();

            Label lblMessage = new Label
            {
                Text = "Это интерфейс для второго выбора.",
                AutoSize = true,
                Location = new Point(10, 10)
            };
            this.Controls.Add(lblMessage);
        }
    }
}

﻿using System;
using System.Windows.Forms;

namespace Buscaminas
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {

            InitializeComponent();

        }
       

        private void buttonprueba_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

    }
}

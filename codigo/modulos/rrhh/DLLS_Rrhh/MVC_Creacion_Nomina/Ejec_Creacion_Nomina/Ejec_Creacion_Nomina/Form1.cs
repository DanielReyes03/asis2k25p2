﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Creacion_Nomina;

namespace Ejec_Creacion_Nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Principal_Nomina frm_Principal_Nomina = new Frm_Principal_Nomina();
            frm_Principal_Nomina.ShowDialog();
        }
    }
}

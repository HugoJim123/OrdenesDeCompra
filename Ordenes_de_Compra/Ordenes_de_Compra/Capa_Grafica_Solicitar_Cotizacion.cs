﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenes_de_Compra
{
    public partial class Capa_Grafica_Solicitar_Cotizacion : Form
    {
        public Capa_Grafica_Solicitar_Cotizacion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capa_Grafica_Mostrar_Cotizaciones cgmoc = new Capa_Grafica_Mostrar_Cotizaciones();
            cgmoc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

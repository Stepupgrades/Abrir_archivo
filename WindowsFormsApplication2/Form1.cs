﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            if (abrir.ShowDialog()==DialogResult.OK) {

                srting direccion = abrir.FileName;

                Process proceso = new Process();
                proceso.StartInfo.FileName = direccion;
                proceso.Start();

            }

        }
    }
}

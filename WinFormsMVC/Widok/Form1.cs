using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsMVC.Controller;

namespace WinFormsMVC
{
    public partial class Form1 : Form
    {
        // FORM 1 POSIADA DELEGATA ORAZ MODEL
        public DelegatDS Delegat { get; set; }
        public DragonModel DragonModel { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateControls()
        {
            textBox1.Text = DragonModel.HP.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delegat.Invoke("Atak mieczem");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delegat.Invoke("Pokaz Form2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_ClassificarTriangulo_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Classificar_Click(object sender, EventArgs e)
        {
            Triangulo t = new Triangulo();
            t.SetLadoA(double.Parse(A.Text));
            t.SetLadoB(double.Parse(B.Text));
            t.SetLadoC(double.Parse(C.Text));
            t.EhTriangulo();
            label4.Text = t.Classificar().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CalculadoraMain : Form
    {
        public CalculadoraMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void fnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void fnByX_Click(object sender, EventArgs e)
        {

        }

        private void fnPower2_Click(object sender, EventArgs e)
        {

        }

        private void gboxFunctions_Enter(object sender, EventArgs e)
        {

        }

        private void e_AddCharacter(object sender, EventArgs e)
        {
            var button = sender as Button;
            txtResult.Text = txtResult.Text + button.Text;
        }
    }
}

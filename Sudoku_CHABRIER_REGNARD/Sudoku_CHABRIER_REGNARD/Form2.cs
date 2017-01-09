using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_CHABRIER_REGNARD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            Form1 basicSudoku = new Form1();
            basicSudoku.setLevel(10);
            this.Hide();
            basicSudoku.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 InterSudoku = new Form1();
            InterSudoku.setLevel(30);
            this.Hide();
            InterSudoku.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 InterSudoku = new Form1();
            InterSudoku.setLevel(60);
            this.Hide();
            InterSudoku.Show();
        }
    }
}

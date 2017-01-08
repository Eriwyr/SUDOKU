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
    public partial class Form1 : Form
    {
        private static int COLUMN_WIDTH = 70;
        private static int ROW_HEIGHT = 70;
        private Sudoku sudokuGrid;
        public Form1()
        {
            InitializeComponent();
            sudoku.RowCount = 9;
            sudoku.ColumnCount = 9;
            sudoku.AllowUserToResizeColumns = false;
            sudoku.AllowUserToResizeRows = false;
            for (int i = 0; i < 9; i++)
            {
                sudoku.Columns[i].Width = COLUMN_WIDTH;
                for (int j = 0; j < 9; j++)
                {
                    sudoku.Rows[j].Height = ROW_HEIGHT;
                    sudoku.Rows[j].Cells[i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }

            sudokuGrid = new Sudoku();

        }

        private void gen_Click_1(object sender, EventArgs e)
        {   
            int ligne = 0, col = 0;
            //MessageBox.Show("1");
            sudokuGrid = new Sudoku();
            sudokuGrid.generation();
            sudokuGrid.hideCells(50);
            //MessageBox.Show("algo finit");
           for (int position = 0; position < 81; ++position)
            {
                ligne = position / 9;
                col = position % 9;
                sudoku.Rows[ligne].Cells[col].Style.BackColor = Color.LightGray;
                sudoku.Rows[ligne].Cells[col].ReadOnly = true;
                sudoku.Rows[ligne].Cells[col].Value = sudokuGrid.getValueIJ(ligne, col);
                if((int)sudoku.Rows[ligne].Cells[col].Value == 0)
                {
                    sudoku.Rows[ligne].Cells[col].Value = null;
                    sudoku.Rows[ligne].Cells[col].Style.BackColor = Color.White;
                    sudoku.Rows[ligne].Cells[col].ReadOnly = false;
                }
            }
        }

    }
}


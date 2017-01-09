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
        private int level;
        private bool isGenarated;
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
            
            sudokuGrid = new Sudoku();

            sudokuGrid.setLevel(level);
            sudokuGrid.launchGame();

            isGenarated = true;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku.Rows[i].Cells[j].Selected = false;
                    sudoku.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
                    sudoku.Rows[i].Cells[j].ReadOnly = true;
                    sudoku.Rows[i].Cells[j].Value = sudokuGrid.getValueIJ(i, j);
                    if ((int)sudoku.Rows[i].Cells[j].Value == 0)
                    {
                        sudoku.Rows[i].Cells[j].Value = null;
                        sudoku.Rows[i].Cells[j].Style.BackColor = Color.White;
                        sudoku.Rows[i].Cells[j].ReadOnly = false;

                    }

                }
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            message.Text = "";
            if (isGenarated)
            {


                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {

                        try
                        {
                            int value;
                            if (sudoku.Rows[i].Cells[j].Value == null)
                            {
                                value = 0;
                                throw new ArgumentNullException();
                            }
                            else
                                value = int.Parse(sudoku.Rows[i].Cells[j].Value.ToString());
                            sudokuGrid.setIJ(i, j, value);
                        }


                        catch (InvalidCastException exp)
                        {

                            message.ForeColor = Color.Red;
                            message.Text += "Enter only numbers !\r\n";
                        }
                        catch (ArgumentNullException exp)
                        {
                            message.ForeColor = Color.Red;
                            message.Text += "Fill all boxes !\r\n";
                        }
                        catch (FormatException exp)
                        {
                            message.ForeColor = Color.Red;
                            message.Text += "Enter only numbers !\r\n";
                        }
                    }
                }

                if (sudokuGrid.checkAnswer())
                {
                    message.ForeColor = Color.Green;
                    message.Text = "You win !\r\n";
                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text += "Try again !\r\n";
                }
            }
            else
            {
                message.ForeColor = Color.Red;
                message.Text = "Generate grid first!\r\n";
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            this.Hide();
            menu.Show();
            
            
        }

        public void setLevel(int level)
        {
            this.level = level;
        }
    }
}


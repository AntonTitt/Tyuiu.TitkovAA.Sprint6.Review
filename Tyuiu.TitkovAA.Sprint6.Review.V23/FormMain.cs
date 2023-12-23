using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TitkovAA.Sprint6.Review.V23.Lib;

namespace Tyuiu.TitkovAA.Sprint6.Review.V23
{
    public partial class FormMain : Form
    {
        DataService dt = new DataService();

        public FormMain()
        {
            InitializeComponent();
            /*
            {
                textBox_M_TAA.Text = "10";
                textBox_N_TAA.Text = "10";
                textBox_n1_TAA.Text = "1";
                textBox_n2_TAA.Text = "7";
                textBox_c_TAA.Text = "1";
                textBox_k_TAA.Text = "4";
                textBox_l_TAA.Text = "6";
            }
            */
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        private void buttonDO_TAA_Click(object sender, EventArgs e)
        {
            try
            {

                int[,] array = new int[Convert.ToInt32(textBox_N_TAA.Text), Convert.ToInt32(textBox_M_TAA.Text)];

                Random rn = new Random();


                int N = array.GetLength(0);
                int M = array.Length / N;





                int rows = Convert.ToInt32(textBox_N_TAA.Text);
                int columns = Convert.ToInt32(textBox_M_TAA.Text);
                int[,] matrix = new int[rows, columns];
                int n1 = Convert.ToInt32(textBox_n1_TAA.Text);
                int n2 = Convert.ToInt32(textBox_n2_TAA.Text);
                

                int c = Convert.ToInt32(textBox_c_TAA.Text);
                int k = Convert.ToInt32(textBox_k_TAA.Text);
                int l = Convert.ToInt32(textBox_l_TAA.Text);


                dataGridView_YAMETE_TAA.ColumnCount = columns;
                dataGridView_YAMETE_TAA.RowCount = rows;

                int cf = 0;

                

                for (int i = 0; i < columns; i++)
                {
                    dataGridView_YAMETE_TAA.Columns[i].Width = 30;
                }

                for (int i = 0; i < rows; i++) //stroki
                {
                    for (int j = 0; j < columns; j++) //stolbci
                    {


                        if (j % 2 == 0)
                        {


                            matrix[i, j] = Convert.ToInt32(rn.Next(Convert.ToInt32(textBox_n1_TAA.Text), Convert.ToInt32(textBox_n2_TAA.Text)));
                            matrix[i, j + 1] = Convert.ToInt32(Math.Pow(matrix[i, j + 1], 2));

                            dataGridView_YAMETE_TAA.Rows[i].Cells[j].Value = matrix[i, j];
                            dataGridView_YAMETE_TAA.Rows[i].Cells[j + 1].Value = Math.Pow(matrix[i, j], 2);


                        }






                    }
                }


                cf = dt.GetMatrix(matrix, n1, n2, c, k, l);
                textBox_re_TAA.Text = Convert.ToString(cf);


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonMatrGen_TAA_Click(object sender, EventArgs e)
        {
            /*
            try
            {

                int rows = Convert.ToInt32(textBox_N_TAA.Text);
                int columns = Convert.ToInt32(textBox_M_TAA.Text);
                int[,] matrix = new int[rows, columns];
                int n1 = Convert.ToInt32(textBox_n1_TAA.Text);
                int n2 = Convert.ToInt32(textBox_n2_TAA.Text);

                Random rn = new Random();

                dataGridView_YAMETE_TAA.ColumnCount = columns;
                dataGridView_YAMETE_TAA.RowCount = rows;



                for (int i = 0; i < columns; i++)
                {
                    dataGridView_YAMETE_TAA.Columns[i].Width = 30;
                }

                for (int i = 0; i < rows; i++) //stroki
                {
                    for (int j = 0; j < columns; j++) //stolbci
                    {


                        if (j % 2 == 0)
                        {


                            matrix[i, j] = Convert.ToInt32(rn.Next(Convert.ToInt32(textBox_n1_TAA.Text), Convert.ToInt32(textBox_n2_TAA.Text)));
                            matrix[i, j + 1] = Convert.ToInt32(Math.Pow(matrix[i, j + 1], 2));

                            dataGridView_YAMETE_TAA.Rows[i].Cells[j].Value = matrix[i, j];
                            dataGridView_YAMETE_TAA.Rows[i].Cells[j + 1].Value = Math.Pow(matrix[i, j], 2);


                        }
                    }
                }



            }
            catch
            {
                MessageBox.Show("sdfghyjuikol;");
            }*/
        }

        private void buttonAbout_TAA_Click(object sender, EventArgs e)
        {
            FormAbout ab = new FormAbout();
            ab.Show();

        }
    }
}

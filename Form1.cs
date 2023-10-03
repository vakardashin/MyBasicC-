using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // ***********************************************
            // Программируем в этих границах

            // Создаём два массива

            txtOutput.Text += Environment.NewLine;
            int[] mass = { 2, 3, 15, 7, 11 };
            int m = 7;
            printMass(mass, m);

            txtOutput.Text += Environment.NewLine;
            int[] mass2 = { 2, 3, 15, 7, 11 };
            int m2 = 5;
            printMass2(mass2, m2);

            // ***********************************************
        }
        // ******************************************************   
        // Место для функций

        // Функция обращения к массиву

        void printMass(int[] arr, int m)
        {
            try
            {
            string s = "";
            for (int i = 0; i < m; i++)
                {
                s += arr[i] + " ";
                }
             txtOutput.Text += (s);
            }
            catch (Exception e)
            {
                txtOutput.Text += e.Message + Environment.NewLine;
            }
        }

        void printMass2(int[] arr, int m)
        {
            try
            {
                string s = "";
                for (int i = 0; i < m; i++)
                {
                    s += arr[i] + " ";
                }
                txtOutput.Text += (s) + Environment.NewLine;
            }
            catch (Exception e)
            {
                txtOutput.Text += e.Message + Environment.NewLine;
            }
            finally
            {
               txtOutput.Text += "Выполнение завершено!" + Environment.NewLine;
            }

        }



        // ****************************************

    }


}

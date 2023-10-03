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

            /*
            // Инкапсуляция

            Person p1 = new Person("Иван", "Петров");
            Person p2 = new Person("Ольга", "Ивановна", "Сергеева");

            txtOutput.Text += p1.FirstName + Environment.NewLine;
            txtOutput.Text += p2.FirstName + Environment.NewLine;

            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += p1.GetFullName() + Environment.NewLine;
            txtOutput.Text += p2.GetFullName() + Environment.NewLine;

            /*

            // Домашняя работа 1_8 

            Person p3 = new Person("Владимир", "Алексеевич", "Кардашин");
            txtOutput.Text += Environment.NewLine;
            txtOutput.Text += p3.GetShortName() + Environment.NewLine;

            */
            /*

            // Наследование

            txtOutput.Text += Environment.NewLine;
            Driver p3 = new Driver("Пётр", "Иванович", "Кузнецов", "12345");
            txtOutput.Text += p3.GetFullName() + Environment.NewLine;
            txtOutput.Text += p3.GetInfo() + Environment.NewLine;

            // Полиморфизм

            txtOutput.Text += Environment.NewLine;
            Person[] persons = { p1, p2, p3 };
            foreach (Person person in persons)
            {
                txtOutput.Text += person.GetInfo() + Environment.NewLine;
            }

            */
            /*

            Divide1(8, 2);

            txtOutput.Text += Environment.NewLine;
            Divide2(8, 2);
            Divide2(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide3(8, 2);
            Divide3(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide4(8, 2);
            Divide4(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide5(8, 2);
            Divide5(8, 0);

            txtOutput.Text += Environment.NewLine;
            Divide6(8, 2);
            Divide6(8, 0);

            txtOutput.Text += Environment.NewLine;
            try
            {
                Divide7(8, 0);
            }
            catch (Exception exc)
            {
                txtOutput.Text += exc.Message + Environment.NewLine;
            }
            txtOutput.Text += Environment.NewLine;
            try
            {
                TestFunction();
            }
            catch (Exception exc)
            {
                txtOutput.Text += exc.Message + Environment.NewLine;
            }

            */

            // Домашняя работа 1_10

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

        /*

        // Простейшая проверка входных данных
        void Divide1( int a, int b )
        {
            txtOutput.Text += (a / b).ToString() + Environment.NewLine;
        }

        // Используется проверка входных данных

        void Divide2( int a, int b )
        {
            if ( b != 0 )
            {
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            else
            {
                txtOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
        }

        // Используется обработка исключений

        void Divide3( int a, int b )
        {
            try
            {
                // Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                // Блок кода для обработки исключения
                txtOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
        }

        // Используется обработка исключений

        void Divide4(int a, int b)
        {
            try
            {
                // Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                // Блок кода для обработки исключения
                txtOutput.Text += e.Message + Environment.NewLine;
            }
        }

        // Используется обработка различных исключений

        void Divide5(int a, int b)
        {
            try
            {
                // Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (DivideByZeroException e)
            {
                // Блок кода для обработки конкретного исключения
                txtOutput.Text += "Деление на 0!" + Environment.NewLine;
            }
            catch (Exception e)
            {
                // Блок кода для обработки остальных исключений
                txtOutput.Text += e.Message + Environment.NewLine;
            }
        }

        // Используется обработка исключений с finally

        void Divide6(int a, int b)
        {
            try
            {
                // Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                // Блок кода для обработки исключений
                txtOutput.Text += e.Message + Environment.NewLine;
            }
            finally
            {
                // Блок кода, который всегда выполняется по завершении
                txtOutput.Text += "Выполнение завершено!" + Environment.NewLine;
            }

        }

        // Используется обработка исключений с повторной генерацией кода
        void Divide7(int a, int b)
        {
            try
            {
                // Блок кода, в котором возможны исключения
                txtOutput.Text += (a / b).ToString() + Environment.NewLine;
            }
            catch (Exception e)
            {
                // Блок кода для обработки исключений
                txtOutput.Text += e.Message + Environment.NewLine;
                // Повторная генерация исключения
                throw;
            }
        }
        // Создание исключения
        void TestFunction()
        {
            throw new ApplicationException("Тестовое исключение");
        }

        */

        // Домашняя работа 1_10.

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

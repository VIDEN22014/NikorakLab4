using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikorakLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double quickSortCompareCount = 0;
        double quickSortIsertsCount = 0;
        double[] x;
        void sortInsert(double[] array)
        {
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            double compareCount = 0, swapCount = 0;
            double temp;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    compareCount++;
                    if (arr[j - 1] > arr[j])
                    {
                        swapCount++;
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            stopwatch.Stop();
            dataGridView1.Rows.Add("Сортування Вставкою", array.Length, compareCount, swapCount, stopwatch.ElapsedMilliseconds);
        }
        void sortBubble(double[] array)
        {
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            double compareCount = 0, insertsCount = 0;
            double temp;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    compareCount++;
                    if (arr[j] > arr[j + 1])
                    {
                        insertsCount++;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            stopwatch.Stop();
            dataGridView1.Rows.Add("Сортування Обімном", array.Length, compareCount, insertsCount, stopwatch.ElapsedMilliseconds);
        }
        void sortChoise(double[] array)
        {
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            double compareCount = 0, insertsCount = 0, temp;
            int minPos = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                minPos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    compareCount++;
                    if (arr[minPos] > arr[j])
                    {
                        minPos = j;
                    }
                }
                insertsCount++;
                temp = arr[minPos];
                arr[minPos] = arr[i];
                arr[i] = temp;
            }
            stopwatch.Stop();
            dataGridView1.Rows.Add("Сортування Вибором", array.Length, compareCount, insertsCount, stopwatch.ElapsedMilliseconds);
        }


        void sortShell(double[] array)
        {
            double compareCount = 0, insertsCount = 0;
            double temp;
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //
            int d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    compareCount++;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        insertsCount++;
                        temp = arr[j];
                        arr[j] = arr[j - d];
                        arr[j - d] = temp;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            stopwatch.Stop();
            dataGridView1.Rows.Add("Сортування Шелла", array.Length, compareCount, insertsCount, stopwatch.ElapsedMilliseconds);
        }

        void QuickSort(double[] array)
        {
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            quickSortIsertsCount = 0;
            quickSortCompareCount = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quickSort(arr, 0, arr.Length - 1);
            stopwatch.Stop();
            dataGridView1.Rows.Add("Швидке сортування", arr.Length, quickSortCompareCount, quickSortIsertsCount, stopwatch.ElapsedMilliseconds);
        }


        void quickSort(double[] arr, int first, int last)
        {
            int i = first;
            int j = last;
            double temp;

            double middle = arr[last - 1 / 2];
            while (i <= j)
            {
                while (arr[i] < middle)
                {
                    ++i;
                }

                while (arr[j] > middle)
                {
                    --j;
                }
                quickSortCompareCount++;
                if (i <= j)
                {
                    quickSortIsertsCount++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (i < last)
            {
                quickSort(arr, i, last);
            }
            if (j > first)
            {
                quickSort(arr, first, j);
            }
        }
        void QuickSortRef(double[] array)
        {
            quickSort(array, 0, array.Length - 1);
            dataGridView3.Rows.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView3.Rows.Add(array[i]);
            }
        }
        void InverseQuickSortRef(double[] array)
        {
            quickSort(array, 0, array.Length - 1);
            dataGridView4.Rows.Clear();
            for (int i = array.Length-1; i >= 0; i--)
            {
                dataGridView4.Rows.Add(array[i]);
            }
        }
        int TextBoxToInt(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(textBox.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int arrayLenght = TextBoxToInt(textBox1);
           x = new double[arrayLenght];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(0, 100);
            }
            dataGridView1.Rows.Clear();
            if (checkBox1.Checked)
            {
                sortInsert(x);
            }
            if (checkBox2.Checked)
            {
                sortBubble(x);
            }
            if (checkBox3.Checked)
            {
                sortChoise(x);
            }
            if (checkBox4.Checked)
            {
                sortShell(x);
            }
            if (checkBox5.Checked)
            {
                QuickSort(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < x.Length; i++)
            {
                dataGridView2.Rows.Add(x[i]);
            }
            QuickSortRef(x);
            InverseQuickSortRef(x);
        }
    }
}

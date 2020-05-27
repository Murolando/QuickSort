using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        #region сортировка
        double h = 1, x = 0, y, h1=1 , x1=0, y1;
        //swap
        public void Swap(long[]mas,long ind1,long ind2)
        {
            long temp = mas[ind1];
            mas[ind1] = mas[ind2];
            mas[ind2] = temp;
        }
        public void Quick_Sort(long[] mas,long low, long high)
        {
            y = time.ElapsedTicks ;
            mainChart.Series[1].Points.AddXY(x, y);
            x += h;

            y1 = x1 * x1;
            mainChart.Series[0].Points.AddXY(x1, y1);
            x1 += h1;





            if (low < high)
            {
                long q = Partition(mas, low, high);

                Quick_Sort(mas, low, q - 1);
                Quick_Sort(mas, q + 1, high);
            }
        }
        public long Partition(long[]mas, long low, long high)
        {
            long pivot = mas[high];
            long i = (low-1) ;
            long d;
            for (long j = low; j <= high-1; j++)
            {
                if (mas[j] <= pivot)
                {
                    i ++;
                    //swap
                    Swap(mas, i, j);
                }
            }
            //swap
            Swap(mas,i+1,high);
            return (i+1);     
        }
        #endregion


        Stopwatch time = new Stopwatch();
        private void Form1_Load(object sender, EventArgs e)
        {
            //рисуем асимптоту n^2
           
        }

        //кнопка сортировки
        private void sortBut_Click(object sender, EventArgs e)
        {
            mainChart.Series[0].Points.Clear();
            mainChart.Series[1].Points.Clear();
            char[] revmove = { ' ', '\n' };
            string[] str = insertText.Text.Split(revmove);
            long[] rez = new long[str.Length];
            try
            {
                for (int i = 0; i < str.Length; i++)
                    rez[i] = long.Parse(str[i]);
                time.Start();
            }
            catch
            {
                MessageBox.Show("Неправильный формат ввода");
            }
          
            Quick_Sort(rez,0,rez.Length-1);
            time.Stop();
            timeText.Text ="Ticks " + time.ElapsedTicks.ToString();

            // TimeSpan ts = time.Elapsed;
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            //timeText.Text += "\n RunTime "+ elapsedTime ;
            time.Reset();
            h = 1;
            x = 0;
            x1 = 0;
            h1 = 1;
         
            // mainChart.Series[1].Dispose();
            insertBack(rez);

        }
        //записывание массива в outputText
        public void insertBack(long[] mas)
        {
            string s="";
            for (int i = 0; i < mas.Length; i++)
            {
                s += mas[i]+" ";
            }
            outputText.Text = s;

        }
        //открытие и считывание с файла
        private void openBut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               insertText.Text = File.ReadAllText(dlg.SelectedPath);
            }

        }

        //случайное заполнение
        private void RandButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 1000);
            string line = null;
            for (int i = 0; i < n - 1; i++)
            {
                line += rnd.Next(-1000, 1000);
                if (i % 10 == 0 && i != 0)
                    line += '\n';
                else
                    line += " ";
            }
            line += rnd.Next(-10000, 10000);
           insertText.Text = line;
        }
    }
}

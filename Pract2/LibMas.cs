using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pract2
{
    internal class LibMas
    {
        public void Save(in int[] mas)
        {
            SaveFileDialog Save = new SaveFileDialog();
            Save.DefaultExt = ".txt";
            Save.Filter = "Все файлы (*.*)|*.*|Текстовые файлы|*.txt";
            Save.FilterIndex = 2;
            Save.Title = "Сохранение";
            if (Save.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(Save.FileName);
                file.WriteLine(mas.Length);

                for (int i = 0; i < mas.Length; i++)
                {
                    file.WriteLine(mas[i]);
                }
                file.Close();
            }
        }
        public int[] Create(in int x, in int n)
        {
            
            int[] mas = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0, x);
            }
            return mas;

        }
        public void Open(out int[] mas)
        {

            OpenFileDialog Open = new OpenFileDialog();
            Open.DefaultExt = ".txt";
            Open.Filter = "Все файлы (*.*)|*.*|Текстовые файлы|*.txt";
            Open.FilterIndex = 2;
            Open.Title = "Открытие";
            if (Open.ShowDialog() == true)
            {
                StreamReader Reader = new StreamReader(Open.FileName);
                int m = Convert.ToInt32(Reader.ReadLine());

                mas = new Int32[m];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Convert.ToInt32(Reader.ReadLine());
                }
                Reader.Close();


            }
            else mas = null;
        }
    }
}

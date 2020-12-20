using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        int[] m_massive;
        int[,] m_massive2D;
        List<int> sizes = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            sizes.Clear();
            string txt = inputSizeBox.Text;

            txt = txt.TrimEnd();

            string[] splited = txt.Split(' ');


            bool result = true;
            foreach (string sizeStr in splited)
            {
                int size;

                if (int.TryParse(sizeStr, out size))
                    sizes.Add(size);
                else
                {
                    infoLabel.Text = "Не удалось создать массив";
                    result = false;
                }
            }

            for (int i = 0; i < sizes.Count; i++)
                if (sizes[i] == 0)
                {
                    infoLabel.Text = "Вы дейстивтельно хотите создать массив с размером 0 ?";
                    return;
                }

            if (!result)
                return;

            if (sizes.Count == 1)
                m_massive = new int[sizes[0]];
            else if (sizes.Count == 2)
                m_massive2D = new int[sizes[0], sizes[1]];

            if (sizes.Count > 2)
                infoLabel.Text = "Невозможно создать " + sizes.Count + " мерный массив\n";
            else
                infoLabel.Text = "Создан " + sizes.Count + " мерный массив\n";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string info = "";
            if (sizes.Count == 0)
            {
                infoLabel.Text = "Сперва необходимо создать массив";
                return;
            }
            else if (sizes.Count == 1)
            {
                for (int i = 0; i < sizes[0]; i++)
                    info += m_massive[i].ToString() + " ";
            }
            else if (sizes.Count == 2)
            {
                for (int i = 0; i < sizes[0]; i++)
                {
                    for (int j = 0; j < sizes[1]; j++)
                        info += m_massive2D[i, j].ToString() + " ";

                    info += '\n';
                }
            }

            infoLabel.Text = info;
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            if(sizes.Count == 0)
            {
                infoLabel.Text = "Сперва необходимо создать массив";
                return;
            }
            else if (sizes.Count == 1)
            {
                for (int i = 0; i < sizes[0]; i++)
                    m_massive[i] = rnd.Next(500);
            }
            else if (sizes.Count == 2)
            {
                for (int i = 0; i < sizes[0]; i++)
                    for (int j = 0; j < sizes[1]; j++)
                       m_massive2D[i, j] = rnd.Next(500); 

            }

            infoLabel.Text = "Массив рандомизирован";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string info = "";
            if(sizes.Count == 0)
            {
                infoLabel.Text = "Сперва необходимо создать массив";
                return;
            }
            else if (sizes.Count == 1)
            {
                for (int i = 0; i < sizes[0]; i++)
                    info += m_massive[i].ToString() + " ";
            }
            else if (sizes.Count == 2)
            {
                for (int i = 0; i < sizes[0]; i++)
                {
                    for (int j = 0; j < sizes[1]; j++)
                        info += m_massive2D[i, j].ToString() + " ";

                    info += '\n';
                }
            }

            infoLabel.Text = info;

            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"output.txt"),info);
            infoLabel.Text = "Сохранено в " + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "output.txt");
            Process.Start("notepad.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "output.txt"));
        }
    }
}

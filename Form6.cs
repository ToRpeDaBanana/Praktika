using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Praktika
{

    public partial class Form6 : Form
    {
        string conStr = @"Data Source=25.74.126.109;Initial Catalog=Praktika;User ID = sa; Password = sa";//Строка подключения к базе данных.
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //Данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet27.MP3".
            this.mP3TableAdapter2.Fill(this.praktikaDataSet27.MP3);


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            base.Text ="Отчёт";
            button1.Text = "Назад";
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)//Отчёт.
        {
            int sum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)//Проверка всех строк.
                {

                    sum =  (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value))*Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);//Подсчёт на какую сумму каждого товара находиться на складе.
                    Form6 form6 = new Form6();
                if (dataGridView1.Rows[i].Cells[i].Value!=null)
                {
                    dataGridView1.Rows[i].Cells[5].Value = sum;//Передача данных в колонку.
                }
                    
                
                }
            
            

            
        }

        private void button1_Click(object sender, EventArgs e)//Закрытие формы 6 и открытие формы 3.
        {
            Owner.Show();
            Hide();
        }
    }
}

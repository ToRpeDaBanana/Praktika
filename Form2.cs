using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Praktika
{
    public partial class Form2 : Form
    {
        string conStr = @"Data Source=26.116.96.59;Initial Catalog=Praktika;User ID = sa; Password = sa";//Строка подключения к базе данных.
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            Form1 = form1;
        }

        public Form1 Form1 { get; }//Получение данных из формы 1.

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.ticketsTableAdapter2.Fill(this.praktikaDataSet28.Tickets);//Данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet28.Tickets".
            base.Text = "Тикеты";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            button1.Text = "Выйти";
        }

        private void button1_Click(object sender, EventArgs e)//Скрытие формы.
        {
            Owner.Show();
            Hide();
        }
    }
}
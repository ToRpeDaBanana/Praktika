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
        Form1 parent;
        string conStr = @"Data Source=25.74.126.109;Initial Catalog=Praktika;User ID = sa; Password = sa";
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            Form1 = form1;
        }

        public Form1 Form1 { get; }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet18.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter1.Fill(this.praktikaDataSet18.Tickets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketsGG.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.ticketsGG.Tickets);
            base.Text = "Тикеты";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            button1.Text = "Выйти";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }
    }
}
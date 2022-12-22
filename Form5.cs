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
using static Praktika.Form4;

namespace Praktika
{
    
    public partial class Form5 : Form
    {
        //Переменные для создания таблицы, SQL команд и вывода данных в ComboBox. 
        DataTable bd = new DataTable();
        BindingSource bds;
        SqlDataAdapter adapter = null;
        //
        string conStr = @"Data Source=26.116.96.59;Initial Catalog=Praktika;User ID = sa; Password = sa";//Строка подключения к базе данных.
        public Form5()
        {
            InitializeComponent();
        }
        
        public Form5(Form3 form3)
        {
            Form3 = form3;
        }
        public void selectКлиент()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);//Удаление пустых строк.
            using (SqlConnection connection = new SqlConnection(conStr))//Подключение и заполнение
            {

                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT * FROM Staff;";
                command.ExecuteNonQuery();
                bd.Clear();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(bd);
                SqlCommandBuilder bulder = new SqlCommandBuilder(adapter);
                bds = new BindingSource();
                bds.DataSource = bd;
                dataGridView1.DataSource = bds;
                // connection.Close();
            }
        }
        private SqlConnection cn = new SqlConnection(Properties.Settings.Default.PraktikaConnectionStringGG);//Получение строки подключения к базе данных.
        private DataSet myDS = new DataSet();//Создание таблицы DataS.

        
    public Form3 Form3 { get; }
        private void Form5_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dAdapt = new SqlDataAdapter("SELECT * FROM Staff", cn);//Запрос в базу данных.
            dAdapt.Fill(myDS, "Staff");
            comboBox1.Items.Clear();
            int i = 0;
            for (i = 0; i < myDS.Tables["Staff"].Rows.Count; i++)//Вывод ФИО в 1 строку для ComboBox.
            {
                comboBox1.Items.Add(myDS.Tables["Staff"].Rows[i][1].ToString()+ " " + myDS.Tables["Staff"].Rows[i][2].ToString()+ " " + myDS.Tables["Staff"].Rows[i][3].ToString());
            }
            Random r = new Random();
            string val = r.Next(1, 90000).ToString("00000");//Генерация номера чека.
            base.Text = "Счёт-фактуры";
            label1.Text = "Счёт-фактуры";
            label3.Text = $"№{val}";
            label4.Text = "от";
            comboBox1.Text = "ФИО";
            label6.Text = "Продавец:";
           
            label8.Text = "Адрес:";
            
            label10.Text = "Покупатель:";
           
            label12.Text = "Адрес доставки:";
            
            label14.Text = "Всего к оплате:";
            label15.Text = "руб";
            label5.Text = "0000";
            button1.Text = "Назад";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void Enter(object sender, KeyPressEventArgs e)//Подсчёт суммы чека по двойному нажатию на Enter.
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);


            }
            label5.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//Скрытие формы и вызов главной формы.
        {
            Owner.Show();
            Hide();
        }
    }
}

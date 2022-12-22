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
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=26.116.96.59;Initial Catalog=Praktika;User ID = sa; Password = sa"; //Строка подключения к базе данных.
        //Задача переменных для открытия форм.
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;
        //
        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = Convert.ToChar("*");//Скрытия пароля при вводе.
            textBox1.MaxLength = 50;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.logPassTableAdapter3.Fill(this.praktikaDataSet26.LogPass);//Данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet26.LogPass".

            this.button1.Text = "Вход";
            this.button2.Text = "Выход";
            base.Text = "Авторизация";
            this.label1.Text = "Имя пользователя";
            label1.Font = new Font("Arial", 8, FontStyle.Regular);
            this.label2.Text = "Пароль";
            label2.Font = new Font("Arial", 8, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            comboBox1.Text = string.Empty;//пустой combobox.
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//Закрытие программы.
        }

       
            private void button1_Click(object sender, EventArgs e)
            {
                //Создание и открытие подключения к базе данных.
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                //

                //Создание SQL команды на запрос чтения из базы данных.
                SqlCommand command3 = new SqlCommand("SELECT Login, Password, Role FROM LogPass", connection);
                SqlDataReader reader = command3.ExecuteReader();
                //


                while (reader.Read())//Проверка логина, роли и пароля пользователя.
                {


                if (comboBox1.Text == reader["Login"].ToString() && textBox1.Text == reader["Password"].ToString() && reader["Role"].ToString() == "Admin")
                {

                    frm2 = new Form2();
                    frm3 = new Form3();
                    frm4 = new Form4();



                    frm2.Show(this);
                    frm3.Show(this);
                    frm4.Show(this);
                    Hide();
                }

                else if (comboBox1.Text == reader["Login"].ToString() && textBox1.Text == reader["Password"].ToString() && reader["Role"].ToString() == "ManagerP")
                {

                    if (frm3 == null)
                    {
                        frm3 = new Form3();
                        frm3.FormClosed += frm3_FormClosed;
                    }

                    frm3.Show(this);
                    Hide();
                }
                else if (comboBox1.Text == reader["Login"].ToString() && textBox1.Text == reader["Password"].ToString() && reader["Role"].ToString() == "ManagerZ")
                {
                    if (frm3 == null)
                    {
                        frm3 = new Form3();
                        frm3.FormClosed += frm3_FormClosed;
                    }

                    frm3.Show(this);
                    Hide();
                }
                else if ((comboBox1.Text != reader["Login"].ToString()) && (textBox1.Text != reader["Password"].ToString()))
                {
                    MessageBox.Show("Логин или пароль неверны! Повторите попытку.");
                    break;
                }


                }
                StaticData.Login = comboBox1.Text;
                reader.Close();
                connection.Close();
            }
        //Методы закрытия форм.
        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;
            Show();
        }
        void frm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm3 = null;
            Show();
        }
        //
    }
}
﻿using System;
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
        string conStr = @"Data Source=25.74.126.109;Initial Catalog=Praktika;User ID = sa; Password = sa";
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;
        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = Convert.ToChar("*");
            textBox1.MaxLength = 50;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet23.LogPass". При необходимости она может быть перемещена или удалена.
            this.logPassTableAdapter2.Fill(this.praktikaDataSet23.LogPass);
            this.button1.Text = "Вход";
            this.button2.Text = "Выход";
            base.Text = "Авторизация";
            this.label1.Text = "Имя пользователя";
            label1.Font = new Font("Arial", 8, FontStyle.Regular);
            this.label2.Text = "Пароль";
            label2.Font = new Font("Arial", 8, FontStyle.Regular);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            comboBox1.Text = string.Empty;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
            private void button1_Click(object sender, EventArgs e)
            {
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();

                SqlCommand command3 = new SqlCommand("SELECT Login, Password, Role FROM LogPass", connection);
                SqlDataReader reader = command3.ExecuteReader();



                while (reader.Read())
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
                    MessageBox.Show("Логин или параль неверны! Повторите попытку.");
                    break;
                }


                }
                reader.Close();
                connection.Close();
            }
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
    }
}
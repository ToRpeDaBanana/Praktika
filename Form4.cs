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
using System.Drawing.Printing;
using System.Activities.Expressions;

namespace Praktika
{
    public partial class Form4 : Form
    {


        private PrintDocument printDocument1 = new PrintDocument();//Задача переменной для метода печати.
        string conStr = @"Data Source=26.116.96.59;Initial Catalog=Praktika;User ID = sa; Password = sa";//Строка подключения к базе данных.
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form3 form3)
        {
            Form3 = form3;
            //Событие печати на кнопку.
            printButton.Click += new EventHandler(button1_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
            //
        }

        public Form3 Form3 { get; }
        private void Form4_Load(object sender, EventArgs e)
        {
            base.Text = "Форма заказа для МП";
            label1.Text = "Заказчик";
            label2.Text = "Общая сумма";
            label3.Text = "00000";
            label4.Text = "руб";
            printButton.Text = "Печать";
            button2.Text = "Назад";
            button1.Text = "Высчитать сумму";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text)) //если не указано имя заказчика - переходим в блок catch, иначе - else.
                {
                    throw new Exception();
                }
                else
                {
                    CaptureScreen();//Захват окна.
                    printDocument1.Print();//Печать документа.
                }
            }
            catch (Exception ex) //обработка исключения.
            {
                MessageBox.Show("Не указано имя заказчика", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        Bitmap memoryImage;

        private void CaptureScreen()//Метод захвата окна для печати.
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;//Текущий размер окна.
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)//Метод печати.
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        
        private void button2_Click(object sender, EventArgs e)//Закрытие формы.
        {
            Owner.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Запись и обновление данных в таблице dataGridView1.
        {
            Validate();
            dataGridView1.Update();
            dataGridView1.EndEdit();


        }

        private void button1_Click_1(object sender, EventArgs e)//Мусор.
        {

        }

        private void Enter(object sender, KeyPressEventArgs e)//Подсчёт общей суммы заказа.
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                Form5 form5 = new Form5();

            }
            label3.Text = sum.ToString();
        }


    }
}

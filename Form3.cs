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
    public partial class Form3 : Form
    {
        Form3 frm3;
        Form6 frm6;
        Form4 frm4;
        Form5 frm5;
        SqlDataAdapter adapter = null;
        DataTable bd = new DataTable();
        BindingSource bds;
        Form1 parent;
        string conStr = @"Data Source=26.116.96.59;Initial Catalog=Praktika;User ID = sa; Password = sa";
        public void selectКлиент()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = "select * from MP3;";
                command.ExecuteNonQuery();
                bd.Clear();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(bd);
                SqlCommandBuilder bulder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = bulder.GetUpdateCommand();
                bds = new BindingSource();
                bds.DataSource = bd;
                dataGridView1.DataSource = bds;
                // connection.Close();
            }

        }
        public Form3()
        {
            InitializeComponent();

        }
        public Form3(Form1 form1)
        {
            Form1 = form1;
        }

        public Form1 Form1 { get; }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "addcombobox.Add_Combobox". При необходимости она может быть перемещена или удалена.
            this.add_ComboboxTableAdapter1.Fill(this.addcombobox.Add_Combobox);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet25.MP3". При необходимости она может быть перемещена или удалена.
            this.mP3TableAdapter5.Fill(this.praktikaDataSet25.MP3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praktikaDataSet24.MP3". При необходимости она может быть перемещена или удалена.
            this.mP3TableAdapter4.Fill(this.praktikaDataSet24.MP3);



            base.Text = "Форма МП";
            comboBox1.Text = null;
            button1.Text = "Сортировка";
            button2.Text = "Заказать";
            button3.Text = "Отчёт";
            button4.Text = "Счёт фактуры";
            textBox1.Text = "Цена";
            textBox2.Text = "Цена";
            label1.Text = "до";
            label2.Text = "от";
            button5.Text = "Выйти";
            button6.Text = "Сброс сортировки";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;




            selectКлиент();
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                connection.Open();
                SqlCommand cmd = new SqlCommand("Add_ComboBox", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                command.CommandText = "SELECT * FROM MP3";
                command.ExecuteNonQuery();
                connection.Close();
            }

            StaticData.frm7Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items != null)
            {
                bds.Filter = "[Категория] LIKE '%" + comboBox1.Text + "%'" + " AND [Цена] >= " + textBox2.Text + " AND [Цена] <= " + textBox1.Text;
            }
            else if (comboBox1.Items ==null)
            {
                bds.Filter = "[Цена] >= " + textBox2.Text + " AND [Цена] <= " + textBox1.Text;
            }
        }


        void frm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm4 = null;
            Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (frm4 == null)
            {
                frm4 = new Form4();
                frm4.FormClosed += frm3_FormClosed;
            }

            frm4.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (frm6 == null)
            {
                frm6 = new Form6();
            }

            frm6.Show(this);

        }

        private void button4_Click(object sender, EventArgs e)
        {
                frm5 = new Form5();

            frm5.Show(this);
        }


    private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "даНетDataGridViewCheckBoxColumn")
                    {
                        DataGridViewCheckBoxCell checkCell =
                            (DataGridViewCheckBoxCell)dataGridView1.
                            Rows[e.RowIndex].Cells["даНетDataGridViewCheckBoxColumn"];
                        if ((bool)dataGridView1.Rows[e.RowIndex].Cells[4].Value == true)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[3].Value = "Да";
                        }
                        else if ((bool)dataGridView1.Rows[e.RowIndex].Cells[4].Value == false)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[3].Value = "Нет";
                        }

                        dataGridView1.Invalidate();
                    }

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            StaticData.frm7Hide();

            Owner.Show();
            Hide();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            bds.Filter = string.Empty;
        }
    }
}

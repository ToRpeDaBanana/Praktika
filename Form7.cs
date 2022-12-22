using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class Form7 : Form
    {

        Thread thread = Thread.CurrentThread;
        //объявление переменных для подключения по сети
        UdpClient client;
        const int LOCALPORT = 8001;
        const int REMOTEPORT = 8001;
        const int TTL = 20;
        const string HOST = "235.5.5.1";
        IPAddress groupAddress;

        string userName;
        public Form7()
        {
            InitializeComponent();

            //определяем активные && неактивные элементы до входа в чат
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            chatTextBox.ReadOnly = true;

            groupAddress = IPAddress.Parse(HOST);
        }

        private void Form7_Load(object sender, EventArgs e) //указываем настройки формы чата
        {
            this.Text = "Внутренний чат";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void label1_Click(object sender, EventArgs e) //мусор
        {

        }

        private void chatTextBox_TextChanged(object sender, EventArgs e)
        {
            //настройка работы диалогового окна
            chatTextBox.ScrollBars = ScrollBars.Vertical;
            chatTextBox.AcceptsReturn = true;
            chatTextBox.WordWrap = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //автоматический перенос данных из логина для входа в аккаунт в имя участника чата
            userName = Praktika.StaticData.Login;
            userNameTextBox.ReadOnly = true;

            try
            {
                //запуск чата
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                //автоматическая отправка сообщения о подключении нового участника
                string message = userName + " присоединяется к нам!";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);

                //определяем активные && неактивные элементы после входа в чат
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                //настройка получения сообщений от других участников чата
                while (thread.IsAlive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    this.Invoke((MethodInvoker)delegate
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        chatTextBox.Text = time + " " + message + "\r\n" + chatTextBox.Text;
                    });
                }
            }
            catch (ObjectDisposedException)
            {
                if (!thread.IsAlive)
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //настройка отправки сообщений другим участникам чата
                string message = String.Format("{0}: {1}", userName, messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e) //выход из чата
        {
            ExitChat();
        }

        private void ExitChat()
        {
            //настройка выхода участника из чата
            string message = userName + " покидает нас!";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);

            client.Close();

            //определяем активные && неактивные элементы после выхода из чата
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            userNameTextBox.ReadOnly = false;
        }

        private void Form7_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (thread.IsAlive)
                ExitChat();
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                sendButton_Click(sendButton, null);
            }
        }
    }
}

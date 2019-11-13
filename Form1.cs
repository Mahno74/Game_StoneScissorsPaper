using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace StoneScissorsPaper
{
    public partial class Form1 : Form
    {
        readonly int port = 12345; //порт который будет испоьзоваться при сетевом подключении
        StreamReader reader; StreamWriter writer;
        bool send_hand = false; bool read_hand = false; //
        string my_hand = ""; string op_hand = "";
        int win = 0; int loose = 0;
        public Form1()
        {
            InitializeComponent();
            SetButtons(false); //выключаем кнопки
        }
        private void SetButtons(bool enable) //выключение кнопок
        {
            button_stone.Enabled = enable;
            button_scissors.Enabled = enable;
            button_paper.Enabled = enable;
            text_debug.Focus();
        }
        private void Button_start_Click(object sender, EventArgs e)
        {
            if (radio_server.Checked) StartServer();
            if (radio_client.Checked && !StartClient()) return;
            SetButtons(true);
            timer1.Enabled = true;
            button_start.Enabled = false;
            textBox_ip.Enabled = false;
            radio_client.Enabled = false;
            radio_server.Enabled = false;
        }
        private void StartServer()
        {
            TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Parse(textBox_ip.Text), port)); //слушатель по адресу и порту
            listener.Start(); //запуск слушателя
            TcpClient server = listener.AcceptTcpClient(); //снимаем трубку если слушатель получил сигнал
            server.ReceiveTimeout = 50; //время ожидание, чтобы не зациклить программу в режиме ожидания сигнала
            reader = new StreamReader(server.GetStream());
            writer = new StreamWriter(server.GetStream());
            writer.AutoFlush = true;
        }
        private bool StartClient()
        {

            TcpClient client = new TcpClient();
            try
            {
                client.Connect(textBox_ip.Text, port);
                client.ReceiveTimeout = 50;
            }
            catch
            {
                MessageBox.Show("Серевер еще не запущен, можеты вам выбрать его роль?"); return false;
            }
            reader = new StreamReader(client.GetStream());
            writer = new StreamWriter(client.GetStream());
            writer.AutoFlush = true;
            return true;
        }

        private void Button_stone_Click(object sender, EventArgs e) => Send("K");
        private void Button_scissors_Click(object sender, EventArgs e) => Send("N");
        private void Button_paper_Click(object sender, EventArgs e) => Send("B");

        private void Send(string text)
        {
            if (send_hand) return;
            send_hand = true;
            writer.WriteLine(text);
            my_hand = text;
            SetButtons(false);
        }

        private string Read()
        {
            if (read_hand) return "";
            try
            {
                string text = reader.ReadLine();
                read_hand = true;
                op_hand = text;
                //text_debug.Text +="read" + text + Environment.NewLine;

                return text;
            }
            catch
            { return ""; }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (read_hand) text_debug.Text = "ваш ход";
            else text_debug.Text = "ход оппонента";
            _ = Read();
            if (send_hand && read_hand)
                FinishGame();
        }
        private void FinishGame()
        {
            int ch = CompareHand(my_hand, op_hand);
            if (ch == 0) label_stat.Text = "НИЧЬЯ";
            if (ch == 1)
            {
                label_stat.Text = "ВЫ ВЫИГРАЛИ"; win++;
            }
            if (ch == 2)
            {
                label_stat.Text = "ВЫ ПРОИГРАЛИ"; loose++;
            }

            StripStatusLabel.Text = $"Выигрышей - {win} Проигрышей - {loose}";
            send_hand = read_hand = false;
            SetButtons(true);
            my_hand = ""; op_hand = "";
        }
        private int CompareHand(string hand1, string hand2)
        {
            if (hand1 == hand2) return 0;
            if (hand1 == "K")
                if (hand2 == "N")
                    return 1;
                else return 2;
            if (hand1 == "N")
                if (hand2 == "B")
                    return 1;
                else return 2;
            if (hand1 == "B")
                if (hand2 == "K")
                    return 1;
                else return 2;
            return 0;
        }

    }
}

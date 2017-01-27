using CadnunsDev.NetIPFinder.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadnunsDev.NetIPFinder
{
    public partial class Form1 : Form
    {
        string ipBase = "192.168.0.{0}";
        string comandBase = "/C ping -n 1 {0}";
        private List<Computer> _lista;
        private readonly List<Thread> _threads;
        private List<Computer> _arpList;

        public Form1()
        {
            InitializeComponent();
            //InitIpFind();
            _lista = new List<Computer>();
            _threads = new List<Thread>();
            var ip = ipBase.Split('.');
            ipPt1tbbox.Text = ip[0];
            ipPt2tbox.Text = ip[1];
            ipPt3tbox.Text = ip[2];
        }

        private string GetIpfromTboxes()
        {
            return string.Format("{0}.{1}.{2}.", ipPt1tbbox.Text, ipPt2tbox.Text, ipPt3tbox.Text)+"{0}";
        }

        private void InitIpFind()
        {
            ClearList();
            var dados = new StringBuilder();
            var ipsAchados = new List<string>();
            for (int i = 1; i < 255; i++)
            {
                var ip = string.Format(ipBase, i);
                var comand = string.Format(comandBase, ip);

                var process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = comand;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                var output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                if (!output.Contains("Host de destino inacess¡vel."))
                {
                    //ipsAchados.Add(ip);
                    AddItemToListView(new Computer { IPAdress = ip });
                }
                //dados.AppendLine(output);
                Notify(output);
                
            }

            
            //dataGridView1.DataSource = ipsAchados.Select(x=> new Computer { IPAdress = x }).ToList();
        }

        void FindComputersOnMyNetwork()
        {
            ClearList();
            ClearOutput();
            var limit = 255;
            var IpFromBoxes = GetIpfromTboxes();
            for (int i = 1; i < limit; i++)
            {
                
                var ip = string.Format(IpFromBoxes, i);
                var th = new Thread(() =>
                {
                    var ping = new Ping();
                    PingingAdress(ping, ip);
                });
                _threads.Add(th);
                th.Start();
            }


        }

        private void ClearOutput()
        {
            
            SecureAction(() =>
            {
                textBox1.Clear();
            });
        }

        void PingingAdress(Ping ping, string ip)
        {
            var resquestPing = ping.Send(ip);
            var output = "Ip pingado: {0}, Status {1}";
            output = string.Format(output, ip, resquestPing.Status);
            if (resquestPing.Status == IPStatus.Success)
            {
                var computer = _arpList.FirstOrDefault(pc => pc.IPAdress == ip) ?? new Computer { IPAdress = ip };
                try
                {
                    var host = Dns.GetHostEntry(computer.IPAdress);
                    computer.HostName = host.HostName;

                }
                catch (Exception ex)
                {

                    Notify("Erro ao buscar hostname do ip [" + computer.IPAdress + "]: " + ex.Message);
                }
                AddItemToListView(computer);
            }
            Notify(output);
        }
        private void ClearList()
        {
            _lista.Clear();
            SecureAction(() =>
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _lista;
            });
        }

        private void AddItemToListView(Computer computer)
        {
            //try
            //{
            //    var ip = IPAddress.Parse(computer.IPAdress);
            //    var mac = NetWorkUtils.GetMacAddress(ip);
            //    var macString = NetWorkUtils.GetMacAddress(computer.IPAdress);
            //    computer.MacAdress = mac.ToString();
            //}
            //catch (Exception ex)
            //{
            //    Notify(string.Format("Problema ao Buscar Mac Address de IP[{0}]. MOtivo : {1}",computer.IPAdress, ex.Message));               
            //}
            _lista.Add(computer);
            
            SecureAction(() =>
            {
                dataGridView1.DataSource = null;                
                dataGridView1.DataSource = _lista.OrderBy(x => int.Parse(x.IPAdress.Split('.').LastOrDefault())).ToList();
                tboxQuant.Text = _lista.Count.ToString();
            });
        }

        private void Notify(string output)
        {            
            SecureAction(() =>
            {
                textBox1.Text += Environment.NewLine + output;
            });
        }

        private void SecureAction(Action action, Control formControl = null)
        {
            formControl = formControl ?? this;
            try
            {
                if (formControl.Visible)
                    formControl.BeginInvoke((Action)action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Thread(InitIpFind).Start(); 

            _arpList = NetWorkUtils.ListComputerByArp();

            var thread = new Thread(FindComputersOnMyNetwork);
            _threads.Add(thread);
            thread.Start();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAllThreads();
            
        }

        private void StopAllThreads()
        {
            _threads.ForEach(th =>
            {
                if (th.IsAlive)
                {
                    th.Abort();
                }
            });
        }

        private void btnPingForm_Click(object sender, EventArgs e)
        {
            new PingForm().ShowDialog();
        }
    }
}

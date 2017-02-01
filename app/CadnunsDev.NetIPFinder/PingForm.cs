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
    public partial class PingForm : Form
    {
        private Stopwatch _timeOffLine;
        private Stopwatch _timeOnline;
        private bool _pinging = false;
        private string _host;
        private Thread _threadPing;

        private List<long> pingTimes = new List<long>();

        public PingForm()
        {
            InitializeComponent();            
        }

        
        private void PingingAdress(Ping ping, string host)
        {
            var template = "[{0}] Resposta de {1}: tempo {2} ms";
            try
            {
                var resquestPing = ping.Send(host);
                ShowHostAndIp(host, resquestPing.Address);
                if (resquestPing.Status == IPStatus.Success)
                {
                    SetTimerIsOnline();
                    pingTimes.Add(resquestPing.RoundtripTime);
                    showPingInfo();
                }
                    
                else
                    SetTimerIsOffline();
                ShowLog(template.ToFormat(resquestPing.Status, resquestPing.Address, resquestPing.RoundtripTime));
            }
            catch (Exception ex)
            {
                SetTimerIsOffline();
                ShowLog("[{0}] host {1} : {2}".ToFormat(ex.GetType().Name, host,ex.Message));
            }
        }

        private void showPingInfo()
        {
            lbPingMax.Text = "{0} ms".ToFormat(pingTimes.Max());
            lbAveragePing.Text = "{0:n2} ms".ToFormat(pingTimes.Average());
        }

        private void ShowHostAndIp(string host, IPAddress address)
        {
            SecureAction(() =>
            {
                lbHost.Text = host;
                lbIp.Text = address.ToString();
            });
        }

        private void SecureAction(Action action, Control formControl = null)
        {
            formControl = formControl ?? this;
            try
            {
                if(formControl.Visible)
                    formControl.BeginInvoke((Action)action);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowLog(string log)
        {
            SecureAction(() =>
            {
                tboxLog.AppendText(log + Environment.NewLine);
            });
        }

        private void ShowTimesOnScreen()
        {
            Set(lbTempoOffLine, _timeOffLine);
            Set(lbTempoOnline, _timeOnline);            
        }
        private void Set(Label lb, Stopwatch stw)
        {
            var template = "{0:00}:{1:00}:{2:00}";
            SecureAction(() =>
            {
                lb.Text = template.ToFormat(stw.Elapsed.Hours, stw.Elapsed.Minutes, stw.Elapsed.Seconds);
            });
        }

        public void SetTimerIsOnline()
        {
            _timeOnline.Start();
            _timeOffLine.Stop();
            ShowTimesOnScreen();
        }

        public void SetTimerIsOffline()
        {
            _timeOffLine.Start();
            _timeOnline.Stop();
            ShowTimesOnScreen();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetHoraInicio();
            ResetTimers();
            _host = tboxUrl.Text;
            _pinging = true;
            tboxLog.Clear();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void ResetTimers()
        {
            _timeOffLine.Reset();
            _timeOnline.Reset();
            ShowTimesOnScreen();
        }

        private void SetHoraInicio()
        {
            var template = "{0:dd/MM/yy hh:mm:ss}";
            lbHoraInicio.Text = template.ToFormat(DateTime.Now);
        }

        private void PingForm_Load(object sender, EventArgs e)
        {
            _timeOffLine = new Stopwatch();
            _timeOnline = new Stopwatch();
            ShowTimesOnScreen();
            _threadPing = new Thread(() =>
            {
                var ping = new Ping();

                while (true)
                {
                    if(_pinging && _host != null)
                        PingingAdress(ping, _host);
                    else if(_pinging && _host == null)
                    {
                        StopTimers();
                    }
                    Thread.Sleep(1000);
                }

            });
            _threadPing.Start();
            btnStop.Enabled = false;
        }

        private void StopTimers()
        {

            _pinging = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            _timeOnline.Stop();
            _timeOffLine.Stop();
            ShowTimesOnScreen();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimers();
        }

        private void PingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_threadPing.IsAlive)
            {
                _threadPing.Abort();
            }
        }
    }
}

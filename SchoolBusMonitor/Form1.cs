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
using System.Threading;
using System.Net;
using System.IO;


namespace SchoolBusMonitor
{
    public partial class Form1 : Form
    {
        BackgroundWorker sensor;
        BackgroundWorker beacon;
        int interval = 1000;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Firebase_Connection();
            BeaconList();
        }


        /****************************************************************************/
        /*                                                                          */
        /****************************************************************************/
        private void Btn_BeaconStart_Click(object sender, EventArgs e)
        {
            /*
            Thread thread = new Thread(new ThreadStart(ThreadStartingPoint));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();
            */

            
            beacon = new BackgroundWorker
            {
                WorkerReportsProgress = false,
                WorkerSupportsCancellation = true

            };
            beacon.DoWork += new DoWorkEventHandler(Worker_DoWork_Beacon);

            beacon.RunWorkerAsync();
            Btn_BeaconStart.Enabled = false;
            
        }
        private void ThreadStartingPoint()
        {

            BeaconData();
            System.Windows.Threading.Dispatcher.Run();

        }


        private void Btn_BeaconStop_Click(object sender, EventArgs e)
        {
            
                beacon.CancelAsync();
                Btn_BeaconStart.Enabled = true;
                textBox2.Text += "Beacon 작업 취소 됨";
            

        }

        void Worker_DoWork_Beacon(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (beacon.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        BeaconData();
                        //textBox1.Text += i + " ";
                        //textBox1.SelectionStart = textBox1.Text.Length;
                        //textBox1.ScrollToCaret();
                    }));

                }
                else
                {
                    BeaconData();
                    //textBox1.AppendText(i + " ");
                }
                Thread.Sleep(interval);
            }
        }



        /****************************************************************************/
        /*                                                                          */
        /****************************************************************************/

        private void Btn_SensorStart_Click(object sender, EventArgs e)
        {
            sensor = new BackgroundWorker
            {
                WorkerReportsProgress = false,
                WorkerSupportsCancellation = true
            };
            sensor.DoWork += new DoWorkEventHandler(Worker_DoWork_Sensor);

            sensor.RunWorkerAsync();
            Btn_SensorStart.Enabled = false;
        }

        private void Btn_SensorStop_Click(object sender, EventArgs e)
        {
           
                sensor.CancelAsync();
                Btn_SensorStart.Enabled = true;
                textBox1.Text += "Sensor 작업 취소 됨";
            

        }


        void Worker_DoWork_Sensor(object sender, DoWorkEventArgs e)
        {
            //for (int i = 0; i < 1000; i++)
            while (true)
            {
                if (sensor.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        SensorData();
                        //textBox1.Text += i + " ";
                        //textBox1.SelectionStart = textBox1.Text.Length;
                        //textBox1.ScrollToCaret();
                    }));

                }
                else
                {
                    SensorData();
                    //textBox1.AppendText(i + " ");
                }
                Thread.Sleep(interval);
            }
        }

        private void Btn_IntervalButton_Click(object sender, EventArgs e)
        {

        }
    }
}

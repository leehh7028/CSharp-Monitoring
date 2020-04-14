using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient.Memcached;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace SchoolBusMonitor
{
    public partial class Form1
    {
        // [0] macAddress, [1]	UUID,	[2] major,	[3] minor 	
        public void BeaconList()
        {
            string connStr = "server=210.115.227.108;user=cic;database=kindergartenbus;password=20180903in";
            string sql = "SELECT * FROM device_unique_info_tb;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(sql)
                {
                    Connection = conn
                };
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    textBox2.AppendText(reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + ", " + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                textBox2.AppendText(ex.ToString());
            }
        }


        // [0]time, [1] macaddress,	[2]rssi, [3] txpower, [4] accuracy 	
        public void BeaconData()
        {
            string connStr = "server=210.115.227.108;user=cic;database=kindergartenbus;password=20180903in";
            string sql = "Select * from device_variable_info_tb ORDER BY time DESC limit 1;";

            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(sql)
                {
                    Connection = conn
                };
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            //textBox2.Text = reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + ", " + reader[4] + Environment.NewLine;
                            textBox2.AppendText(reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + ", " + reader[4] + Environment.NewLine);
                        }));
                    }
                    else
                    {
                        textBox2.AppendText(reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + ", " + reader[4] + Environment.NewLine);
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                textBox2.AppendText(ex.ToString());
                //MessageBox.Show(ex.ToString());
            }

            
        }
    }
}

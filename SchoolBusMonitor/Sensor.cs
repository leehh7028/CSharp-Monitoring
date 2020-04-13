using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient.Memcached;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SchoolBusMonitor
{
    public partial class Form1
    {
        /*
         * Sensor data
         * [0] temperature, [1] humidity, [2] illumination, [3] time
         * 
         */
        public void SensorData()
        {
            string connStr = "server=210.115.227.108;user=cic;database=kindergartenbus;password=20180903in";
            string sql = "Select * from sensor_data ORDER BY time DESC limit 1;";
            
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(sql)
            {
                Connection = conn
            };
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            //textBox1.Text = reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + Environment.NewLine;
                            textBox1.AppendText(reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + Environment.NewLine);
                            //lbl_temperature.Text = Convert.ToString(reader[0]); lbl_humidity.Text = Convert.ToString(reader[1]); lbl_illumination.Text = Convert.ToString(reader[2]);
                        }));
                    }
                    else
                    {
                        textBox1.AppendText(reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3]  + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                //textBox1.Text = ex.ToString();
                textBox1.AppendText(ex.ToString());
            }

            conn.Close();

            //return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;


namespace IP_Finder_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            Ping ping;
            IPAddress addr;
            PingReply pingReply;
            IPHostEntry host;
            string name;

            Parallel.For(0, 254, (i, loopstate) =>
             {

                 ping=new Ping();
                 pingReply=ping.Send(textBox1.Text + i.ToString());

                 this.BeginInvoke((Action)delegate ()
                 {
                     if(pingReply.Status==IPStatus.Success)
                     {
                         try
                         {
                             addr = IPAddress.Parse(textBox1.Text + i.ToString());
                             host = Dns.GetHostEntry(addr);
                             name = host.HostName;

                             dataGridView1.Rows.Add();
                             int nRowIndex = dataGridView1.Rows.Count-1;
                             dataGridView1.Rows[nRowIndex].Cells[0].Value=textBox1.Text + i.ToString();
                             dataGridView1.Rows[nRowIndex].Cells[1].Value=name;
                             dataGridView1.Rows[nRowIndex].Cells[2].Value="Active";

                         }
                         catch(SocketException ex)
                         {
                             name = "?";

                         }
                     }
                 });

             });



            MessageBox.Show("Scan Completed");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void websiteIPGrabberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void whatsMyIPAdressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lANIPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
    }

        private void myLANIPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void publicIPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void myIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            String localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    MessageBox.Show("Your IP Address is " + localIP);
                }
            }
        }

        private void websiteIPGrabberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void myIPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void toolsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iPPingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
    }





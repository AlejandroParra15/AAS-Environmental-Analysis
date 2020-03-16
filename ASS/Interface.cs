using AAS;
using Newtonsoft.Json;
using SODA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Interface : Form
    {

        Boolean active = false;
        int limit = 1000;
        int offset = 0;

        public Interface()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            cbCategory.Visible = false;
            cbValue.Visible = false;
            tbNumberOfRecords.Visible = false;
            btApply.Visible = false;
            split1.Visible = false;
            split2.Visible = false;
            split3.Visible = false;
            panelLateral.Location = new Point(-260, 0);
            btBack.SendToBack();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLink.Text != "" && tbCode.Text != "")
            {
                timer1.Enabled = true;
                Thread t = new Thread(getData);
                t.Start();

            }
        }

        public void getData()
        {
            List<Data> data = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tbLink.Text + "/resource/" + tbCode.Text + ".json?$limit=5000");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Data>>(json);
                dataGridView1.DataSource = data;
            }
            progressBar1.Value = 100;
            timer1.Enabled = false;
            Thread.Sleep(2000);
            progressBar1.Value = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (active == false)
            {
                active = true;
                panelLateral.Location = new Point(9, 0);
                cbCategory.Visible = true;
                btApply.Visible = true;
                cbValue.Visible = true;
                tbNumberOfRecords.Visible = true;
                split1.Visible = true;
                split2.Visible = true;
                split3.Visible = true;
            }
            else
            {
                active = false;
                panelLateral.Location = new Point(-260, 0);
                cbCategory.Visible = false;
                cbValue.Visible = false;
                btApply.Visible = false;
                tbNumberOfRecords.Visible = false;
                split1.Visible = false;
                split2.Visible = false;
                split3.Visible = false;
            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            limit = Convert.ToInt32(tbNumberOfRecords.Text);
            progressBar1.Value = 0;
            timer1.Enabled = true;
            Thread t = new Thread(next);
            t.Start();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = true;
            Thread t = new Thread(next);
            t.Start();
        }

        public void next()
        {
            offset = offset + limit;
            List<Data> data = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tbLink.Text + "/resource/" + tbCode.Text + ".json?$limit=" + limit + "&$offset=" + offset);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<Data>>(json);
                dataGridView1.DataSource = data;
            }
            progressBar1.Value = 100;
            timer1.Enabled = false;
            Thread.Sleep(2000);
            progressBar1.Value = 0;
        }

        public void back()
        {
            offset = offset - limit;
            if (offset >= 0)
            {
                List<Data> data = null;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tbLink.Text + "/resource/" + tbCode.Text + ".json?$limit=" + limit + "&$offset=" + offset);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    data = JsonConvert.DeserializeObject<List<Data>>(json);
                    dataGridView1.DataSource = data;
                }
                progressBar1.Value = 100;
                timer1.Enabled = false;
                Thread.Sleep(2000);
                progressBar1.Value = 0;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = true;
            Thread t = new Thread(back);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value+=1;

            if (progressBar1.Value == 100)
                progressBar1.Enabled = false;

        }
    }
}

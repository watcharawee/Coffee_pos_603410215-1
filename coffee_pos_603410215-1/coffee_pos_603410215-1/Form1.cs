using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410215_1
{
    public partial class Form1 : Form
    {
        string ws = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu.Controls.Remove(Payment);
        }
        public void coflist(string menu, string baht)
        {
            string[] tae = { menu, baht };
            var listview = new ListViewItem(tae);
            listView1.Items.Add(listview);
            ListPrice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coflist("Esspresso(Hot)", "35");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coflist("Esspresso(Ice)", "45");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coflist("Esspresso(Freppe)", "50");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            coflist("Americano(Hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            coflist("Americano(Ice)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            coflist("Latte(Hot)", "35");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            coflist("Latte(Ice)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            coflist("Latte(Frappe)", "50");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            coflist("Mocha(Hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            coflist("Mocha(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            coflist("Mocha(Frappe)", "50");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            coflist("Cappuccino(Hot)", "35");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            coflist("Cappuccino(Ice)", "45");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            coflist("Cappuccino(Frappe)", "50");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            coflist("Greantea(Hot)", "20");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            coflist("Greantea(Ice)", "25");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            coflist("Greantea(Frappe)", "30");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            coflist("Thaitea(Hot)", "20");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            coflist("Thaitea(Ice)", "25");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            coflist("Thaitea(Frappe)", "30");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            coflist("Cocoa(Hot)", "20");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            coflist("Cocoa(Ice)", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            coflist("Cocoa(Frappe)", "30");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            coflist("Milk(Hot)", "20");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            coflist("Milk(Ice)", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            coflist("Milk(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            coflist("Milk Tea(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            coflist("Milk Tea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            coflist("Lemon Tea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            coflist("Lemon Tea(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            coflist("Milo(Hot)", "20");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            coflist("Milo(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            coflist("Milo(Frappe)", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            coflist("Nescafe(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            coflist("Nescafe(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            coflist("Nescafe(Frappe)", "30");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            coflist("Nestea Tea(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            coflist("Nestea Tea(Ice)", "25");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            coflist("Nestea Tea(Frappe)", "30");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            coflist("Italian Soda(Ice)", "25");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            coflist("Red lime Soda(Ice)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            coflist("Honey lime Soda(Ice)", "25");
        }


        double xx;
        public string[] ListPrice()
        {
            xx = 0;
            string[] a = new string[listView1.Items.Count];
            int li = listView1.Items.Count;
            for (int i = 0; i < li; i++)
            {
                xx += double.Parse(listView1.Items[i].SubItems[1].Text);
                a[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            labelPrice.Text = xx.ToString();
            return a;
        }

        public string[] inListPrice()
        {
            string[] a = new string[listView1.Items.Count];
            int li = listView1.Items.Count;
            for (int i =0;i<li;i++)
            {
                a[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return a;
        }

        public void sef()
        {
            string[] siri = ListPrice();
            string[] umt = inListPrice();
            string file = "coffee555" + DateTime.Now.ToString("hhmmss_dd_mm_yyy");
            string filebill = "coffee555";
            filebill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm//yyyy") + "\r\n" + "\r\n";
            filebill += "menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                filebill += siri[i] + new string(' ', 20) + umt[i] + "baht" + "\r\n";
            }
            filebill += "\r\n";
            filebill += "Total Price : " + labelPrice.Text;
            System.IO.File.WriteAllText(ws + @"\" + file + ".txt", filebill);
            textBox1.Text += filebill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + ws + @"\" + file + ".txt";
        }


        bool oo = false;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= "";
            if (oo == false)
            {
                menu.TabPages.Insert(1, Payment);
                oo = true;
                menu.SelectedTab = Payment;
            }
            else menu.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                sef();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            oo = false;
            menu.Controls.Remove(Payment);
            textBox1.Text = "";
        }
    }   
}

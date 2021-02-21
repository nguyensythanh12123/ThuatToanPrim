using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace DoAnSongSong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tạo struct cạnh
        public struct Canh
        {
            public string s;
            public string e;
            public float w;
            public Canh(int _s, int _e, float _w)
            {
                s = _s.ToString();
                e = _e.ToString();
                w = _w;
            }
            public Canh(string _s, string _e, string _w)
            {
                s = _s;
                e = _e;
                w = float.Parse(_w);
            }
        }
        public List<Canh> Graph;
        int Sodinh;
        public List<Canh> Prim()
        { 
            List<Canh> tree = new List<Canh>();
            List<string> DanhDau = new List<string>();
            DanhDau.Add(comboBox1.Text);
            List<Canh> gr = new List<Canh>();
            gr.AddRange(Graph);           
            while (DanhDau.Count < Sodinh)
            {
                var canh = gr.Where(p => (DanhDau.Contains(p.s) && !DanhDau.Contains(p.e)) || 
                    (DanhDau.Contains(p.e) && !DanhDau.Contains(p.s)));
                var minw = canh.Min(p => p.w);
                var mincanh = canh.Where(p => p.w == minw).First();
                tree.Add(mincanh);
                gr.Remove(mincanh);
                if (!DanhDau.Contains(mincanh.s))
                    DanhDau.Add(mincanh.s);
                if (!DanhDau.Contains(mincanh.e))
                    DanhDau.Add(mincanh.e);
            }
            return tree;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void DocFileDT(string filename)
        {
            var lines = System.IO.File.ReadAllLines(filename);
            Graph = new List<Canh>();
            foreach (var line in lines)
            {
                var p = line.Split('-');
                Graph.Add(new Canh(p[0], p[1], p[2]));
            }
            comboBox1.Items.Clear();
            List<string> dsDinh = new List<string>();
            foreach (Canh c in Graph)
            {
                if (!dsDinh.Contains(c.s))
                    dsDinh.Add(c.s);
                if (!dsDinh.Contains(c.e))
                    dsDinh.Add(c.e);
            }
            Sodinh = dsDinh.Count;
            comboBox1.Items.AddRange(dsDinh.ToArray());
            comboBox1.SelectedIndex = 0;

        }
        public void inDoThi()
        {
            richTextBox1.Text += "Đồ Thị Ban Đầu là: \n ";
            foreach (Canh c in Graph)
            {
                richTextBox1.Text += "( " + c.s + " - " + c.e + " ) = " + c.w + "\n";
            }
            richTextBox1.Text += "-----------------------------------------------\n";
        }
        
        private void docdothi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Test Files |*txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                DocFileDT(dlg.FileName);
                label1.Text="Trạng Thái:Đã Đọc Xong Đồ Thị !";
                inDoThi();
            }
        }
       
        private void Timcaykhung_Click(object sender, EventArgs e)
        {
            if (Graph.Count > 0)
            {
                Stopwatch st = new Stopwatch();
                st.Start();
                List<Canh> tree = Prim();
                richTextBox1.Text += "\nCây Khung có khoảng cách nhỏ nhất là: \n ";
                richTextBox1.Text += "\nĐỉnh Bắt đầu là " + comboBox1.Text+"\n\n";
                foreach(Canh c in tree)
                {
                    richTextBox1.Text += "( " + c.s + " - " + c.e + " ) = " + c.w + "\n";
                }
                richTextBox1.Text += "\nKhoảng cách ngắn nhất giữa cây là " + tree.Sum(p => p.w)+"\n" ;
                richTextBox1.Text += "-----------------------------------------------\n";
                label1.Text = "Trạng Thái: Prim đã chạy xong !";
                st.Stop();
                richTextBox1.Text += "\nThời Gian Thực Thi Là " + st.Elapsed.Milliseconds.ToString();
                
            }
        }

        private void taodothi_Click(object sender, EventArgs e)
        {
            TaoDothiMoi frm = new TaoDothiMoi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DocFileDT("DoThiMoi.txt");
                inDoThi();
            }
            
        }

        private void Luudothi_Click(object sender, EventArgs e)
        {
            var line = richTextBox1.Lines;
            if (line.Length > 0)
            {
                SaveFileDialog sfdg = new SaveFileDialog();
                sfdg.Filter="Text Files|*.txt";
                if (sfdg.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllLines(sfdg.FileName, line);
                    label1.Text = "Trạng Thái: Đã Lưu Xong";
                    System.Diagnostics.Process.Start(sfdg.FileName);
                }
            }
        }
        public List<Canh> PrimSongSong()
        {
            List<Canh> tree = new List<Canh>();
            List<string> DanhDau = new List<string>();
            DanhDau.Add(comboBox1.Text);
            List<Canh> gr = new List<Canh>();
            gr.AddRange(Graph);
            for(int i=1;i<Sodinh;i++)
            {
                var canh = gr.Where(p => (DanhDau.Contains(p.s) && !DanhDau.Contains(p.e)) ||
                    (DanhDau.Contains(p.e) && !DanhDau.Contains(p.s)));
                var minw = canh.Min(p => p.w);
                var mincanh = canh.Where(p => p.w == minw).First();
                tree.Add(mincanh);
                gr.Remove(mincanh);
                if (!DanhDau.Contains(mincanh.s))
                    DanhDau.Add(mincanh.s);
                if (!DanhDau.Contains(mincanh.e))
                    DanhDau.Add(mincanh.e);
            }
                    
            return tree;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Graph.Count > 0)
            {
                Stopwatch st = new Stopwatch();
                st.Reset();
                st.Start();
                List<Canh> tree = PrimSongSong();
                richTextBox1.Text += "\nCây Khung có khoảng cách nhỏ nhất là: \n ";
                richTextBox1.Text += "\nĐỉnh Bắt đầu là " + comboBox1.Text + "\n\n";
                foreach (Canh c in tree)
                {
                    richTextBox1.Text += "( " + c.s + " - " + c.e + " ) = " + c.w + "\n";
                }
                richTextBox1.Text += "\nKhoảng cách ngắn nhất giữa cây là " + tree.Sum(p => p.w) + "\n";
                label1.Text = "Trạng Thái: Prim đã chạy xong !";
                st.Stop();
            
                richTextBox1.Text += "\nThời Gian Thực Thi Là " + st.Elapsed.Milliseconds.ToString();

                richTextBox1.Text += "-----------------------------------------------\n";
            }
        }
        public List<Canh> PrimSS()
        {
            List<Canh> tree = new List<Canh>();
            List<string> DanhDau = new List<string>();
            DanhDau.Add(comboBox1.Text);
            List<Canh> gr = new List<Canh>();
            gr.AddRange(Graph);
            Parallel.For(1, Sodinh, i =>
            {
                var canh = gr.Where(p => (DanhDau.Contains(p.s) && !DanhDau.Contains(p.e)) ||
                    (DanhDau.Contains(p.e) && !DanhDau.Contains(p.s)));
                var minw = canh.Min(p => p.w);
                var mincanh = canh.Where(p => p.w == minw).First();
                tree.Add(mincanh);
                gr.Remove(mincanh);
                if (!DanhDau.Contains(mincanh.s))
                    DanhDau.Add(mincanh.s);
                if (!DanhDau.Contains(mincanh.e))
                    DanhDau.Add(mincanh.e);
            });

            return tree;
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            pictureBox1.ImageLocation = null;
            comboBox1.Items.Clear();
            comboBox1.ResetText();
            label1.Text="Trạng Thái:";
            Form1_Load(sender, e);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn Muốn Thoát Chương Trình Không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Image File (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename=openFileDialog1.FileName;
                pictureBox1.ImageLocation = filename;
            }
        }


    }
}

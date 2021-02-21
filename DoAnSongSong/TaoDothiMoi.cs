using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnSongSong
{
    public partial class TaoDothiMoi : Form
    {
        public TaoDothiMoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var line = richTextBox1.Lines;
            if (line.Length > 0)
            {
                SaveFileDialog sfdg = new SaveFileDialog();
                sfdg.Filter = "Text Files|*.txt";
                if (sfdg.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllLines(sfdg.FileName, line);
                    System.Diagnostics.Process.Start(sfdg.FileName);
                }
            }
            System.IO.File.WriteAllLines("DoThiMoi.txt", line);
            DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MsgBox : Form
    {
        private List<string> Discs = new();
        private List<string> Avab = new();
        private List<string> Freeb = new();
        private List<string> Totalb = new();
        public MsgBox()
        {
            InitializeComponent();
            foreach (var drive in DriveInfo.GetDrives())
            {
                double freeSpace = drive.TotalFreeSpace;
                double totalSpace = drive.TotalSize;
                double percentFree = (freeSpace / totalSpace) * 100;
                float num = (float)percentFree;
                var neew = new ListViewItem($"{drive.Name}");
                neew.SubItems.Add($"{drive.AvailableFreeSpace}");
                neew.SubItems.Add($"{drive.TotalSize}");
                neew.SubItems.Add($"{percentFree}");
                
                
                listView1.Items.Add(neew);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public static void ShowMessage(string content, string description)
        {
            MsgBox messageBox = new MsgBox();
            messageBox.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                folderBrowserDialog1 = null;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtEditor
{
    public partial class txtEditor : Form
    {
        public txtEditor()
        {
            InitializeComponent();
        }

        private void otvori_Click(object sender, EventArgs e)
        {
            
        }

        private void novi_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                    Process.Start(@"C:\Users\ucenik\source\repos\txtEditor\txtEditor\bin\Debug\test" );
                }
            }
        }

        private void spremi_Click(object sender, EventArgs e)
        {

        }
    }
}
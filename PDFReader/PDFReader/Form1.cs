using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dlg = new OpenFileDialog();
                // set file filter of dialog 
                dlg.Filter = "pdf files (*.pdf) |*.pdf;";
                dlg.ShowDialog();
                if (dlg.FileName != null)
                {
                    // use the LoadFile(ByVal fileName As String) function for open the pdf in control
                    axAcroPDF1.LoadFile(dlg.FileName);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdobeReaderControlDemoWpf
{
    public partial class PDFControl : UserControl
    {
        public PDFControl()
        {
            InitializeComponent();
        }

        public void LoadFile(string filename)
        {
            this.axAcroPDF1.LoadFile(filename);
        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }
    }
}

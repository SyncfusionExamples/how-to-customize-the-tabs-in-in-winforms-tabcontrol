using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlAdv
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.buttonAdv1.Click += buttonAdv1_Click;
        }
        
        void buttonAdv1_Click(object sender, EventArgs e)
        {
            // To change the MDI Tab Size
            this.tabControlAdv1.ItemSize = new Size(50, 50);
            
        }

        

      

    }
}

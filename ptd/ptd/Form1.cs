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

namespace ptd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt = this.textBox1.Text;
            if (txt == null || txt.Length == 0)
            {
                this.label2.Text = "No path";
            
                return;
            }
            txt = txt.Trim();
            if (txt == null || txt.Length == 0)
            {
                this.label2.Text = "No path";
                return;
            }


            if (Directory.Exists(txt)) {

                this.label2.Text = "Direcotry exists";
                return;
            }
            String path = "";
            try {
              

                path = System.IO.Path.GetFullPath(txt);
            }
            catch (ArgumentException ex) {


                this.label2.Text = (path+"\n\n"+ex.ToString());
                return;
            }
            try
            {
                Directory.CreateDirectory(txt);
                this.label2.Text = ("Ok!");
                
            }
            catch (Exception ex0)
            {
                this.label2.Text = (ex0.ToString()) ;

            }
        }    
    }
}

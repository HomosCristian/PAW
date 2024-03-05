using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult rezultat = MessageBox.Show("Text afisat", "Fereastra mesaj", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            
            if (rezultat == DialogResult.Cancel)
            {
                MessageBox.Show("Raspuns gresit!");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form1 : Form
    {
        Medic m1, m2;


        public Form1()
        {
            InitializeComponent();

            m1 = new Medic("58392171982", "Marian", 2020, "Chirurgie Plastica", new DateTime(1980, 05, 25));
            m2 = new Medic("65858393958", "Ana", 2015, "Neurologie", new DateTime(1978, 08, 15));

            lbMedici.Items.Add(m1.Nume);
            lbMedici.Items.Add(m2.Nume);

            ListViewItem lv1 = new ListViewItem(m1.Nume);
            lv1.SubItems.Add(m1.Cnp);
            lv1.SubItems.Add(m1.AnAbsolvire.ToString());
            lv1.SubItems.Add(m1.Specializare);
            lv1.SubItems.Add(m1.DataNastere.ToString());
            
            lv1.Tag = m1;   //asociem linia cu medicul 1
            lvMedici.Items.Add(lv1);

            ListViewItem lv2 = new ListViewItem(m2.Nume);
            lv2.SubItems.Add(m2.Cnp);
            lv2.SubItems.Add(m2.AnAbsolvire.ToString());
            lv2.SubItems.Add(m2.Specializare);
            lv2.SubItems.Add(m2.DataNastere.ToString());
            lv2.Tag = m2;
            lvMedici.Items.Add(lv2);


        }

        private void lvMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMedici.SelectedItems.Count > 0)
            {
                tbMedic.Text = "";
                //foreach(ListViewItem lv in lvMedici.SelectedItems)
                ListViewItem lv = lvMedici.SelectedItems[0];
                tbMedic.Text += lv.Text + ", " + lv.SubItems[1].Text + ", " + lv.SubItems[2].Text + ", " + lv.SubItems[3].Text + ", "
                                + lv.SubItems[4].Text;
                //Medic ml = (Medic) lv.Tag;
                //tbMedic.Text = ml.Nume + " " + ml.Cnp;
            }
        }

        private void lbMedici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbMedici.SelectedItems!=null)
            tbMedic.Text = lbMedici.SelectedItem.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;   //pt forms
using System.Windows.Forms;  //pt forms

namespace Seminar3
{
    internal class Program
    {
        [STAThread]  // trebuie sa l punem ca sa fie single-threded
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();   //Adaugam forms in references
            Application.SetCompatibleTextRenderingDefault(false);

            Form formular = new Form();
            formular.SuspendLayout();
            formular.StartPosition = FormStartPosition.Manual;
            formular.FormBorderStyle = FormBorderStyle.Sizable;
            formular.Text = "Formular aplicatie windows";

            formular.SetBounds(10, 10, 500, 500);

            Label lbl1 = new Label();
            lbl1.Text = "Eticheta detalii";
            lbl1.Location = new Point(50, 50);
            lbl1.Size = new Size(120, 30);

            TextBox tb1 = new TextBox();
            tb1.Location = new Point(180, 50);
            tb1.Size = new Size(150, 30);

            Button btn1 = new Button()
            {
                Size = new Size(70, 40),
                Location = new Point(50, 150),
                Text = "Afiseaza"
            };
            formular.Controls.Add(lbl1);  //adauga la formular
            formular.Controls.Add(tb1);
            formular.Controls.Add(btn1);
            formular.ResumeLayout();

            btn1.Click += (obj, s) =>
            {
                DialogResult raspuns = MessageBox.Show("Text afisat", "fereastra mesaj", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (raspuns == DialogResult.Cancel)
                {
                    MessageBox.Show("Raspuns gresit!");
                }
            };

            //formular.Show();   //pt formulare secundare
            Application.Run(formular);  //pt formularul principal
        }
    }
}

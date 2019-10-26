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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileOk += (sender, e) =>
            {

                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        list.Items.Clear();

                        txtNev.Text = sr.ReadLine();
                        txtSzul.Text = sr.ReadLine();
                        string nem = sr.ReadLine();
                        if (nem.Equals("F"))
                        {
                            radF.Checked = true;
                        }
                        else if (nem.Equals("N"))
                        {
                            radN.Checked = true;
                        }


                        while (!sr.EndOfStream)
                        {
                            list.Items.Add(sr.ReadLine());
                        }
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! Nem sikerült a betöltés!");

                }

            };
        }

        private void txtNewHobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !txtNewHobbi.Text.Trim().Equals(""))
            {
                list.Items.Add(txtNewHobbi.Text);
                txtNewHobbi.Text = "";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtNewHobbi.Text.Trim().Equals(""))
            {
                list.Items.Add(txtNewHobbi.Text);
                txtNewHobbi.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((radF.Checked || radN.Checked) && !txtNev.Text.Trim().Equals("") && !txtSzul.Text.Trim().Equals("") && list.Items.Count != 0)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                string hibaUzenet = "";

                if (txtNev.Text.Trim().Equals(""))
                {
                    hibaUzenet += "\n-Nevét";
                }
                if (txtSzul.Text.Trim().Equals(""))
                {
                    hibaUzenet += "\n-Születési Dátumát";
                }
                if (!(radF.Checked || radN.Checked))
                {
                    hibaUzenet += "\n-Nemét";
                }
                if (list.Items.Count == 0)
                {
                    hibaUzenet += "\n-Legalább egy hobbiját";
                }

                MessageBox.Show("Kérem adja meg az alábbiakat:" + hibaUzenet);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {

                using (var sw = new StreamWriter(saveFileDialog1.FileName))
                {

                    sw.WriteLine(txtNev.Text + "\n" + txtSzul.Text);
                    if (radF.Checked)
                    {
                        sw.WriteLine("F");
                    }
                    else if (radN.Checked)
                    {
                        sw.WriteLine("N");
                    }
                    


                    foreach (var item in list.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba. Sikertelen mentés!");

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}

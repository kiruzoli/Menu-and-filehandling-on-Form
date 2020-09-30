using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formelement
{
    public partial class Form1 : Form
    {
        int szamlalo = 0;
        string szoveg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            SaveFileDialog SaveWindow = new SaveFileDialog();
            try
            {
                SaveWindow.ShowDialog();
                Fajlok.Save(SaveWindow.FileName, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            OpenFileDialog OpenWindow = new OpenFileDialog();
            if (OpenWindow.ShowDialog() == DialogResult.OK)
            {
                text = Fajlok.Open(OpenWindow.FileName);
                richTextBox1.Text = text;
            }
            else 
            {
                MessageBox.Show("Not good file");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search formSearch = new Search();
            if (formSearch.ShowDialog() == DialogResult.OK)
            {
               label1.Text = formSearch.szoveg;
                szoveg= richTextBox1.Text;
                //szamlalo = szoveg.IndexOf(formSearch.szoveg, 0);
                szamlalo = richTextBox1.Find(formSearch.szoveg, 0); //megkeresi a szöveget oda is áll
                label1.Text = szamlalo.ToString();
               
                //richTextBox1.SelectionBackColor=Color.Red; //nem kell mert a Find be is színezi
                richTextBox1.SelectedText = "anyuci";
            }
            else 
            {
                MessageBox.Show("Hiba");
            }
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm formChange = new ChangeForm();
            if (formChange.ShowDialog() == DialogResult.OK)
            {
                
                szoveg = richTextBox1.Text;
                //szamlalo = szoveg.IndexOf(formSearch.szoveg, 0);
                szamlalo = richTextBox1.Find(formChange.szoveg, 0); //megkeresi a szöveget oda is áll
                label1.Text = szamlalo.ToString();

                //richTextBox1.SelectionBackColor=Color.Red; //nem kell mert a Find be is színezi
                richTextBox1.SelectedText = "anyuci";
            }
            else
            {
                MessageBox.Show("Hiba");
            }
        }
    }
}

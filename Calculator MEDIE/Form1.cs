using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_MEDIE
{
    public partial class Form1 : Form
    {
        double suma = 0; 
        double total=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(txtNote.Text.Trim()=="")
            {
                return;
            }
            lstNote.Items.Add(txtNote.Text);
            txtNote.Clear();
            txtNote.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNote.Clear();
            lstNote.Items.Clear();
            txtTeza.Clear();
            if(radCuTeza.Checked)
            {
                radCuTeza.Checked = false;
            }
            if(radFaraTeza.Checked)
            {
                radFaraTeza.Checked = false;
            }
            pnlTeza.Visible = false;
            lblMedie.Text = " ";    
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            
            for(int i=0;i<lstNote.Items.Count;i++)
            {
                suma = suma + Convert.ToDouble(lstNote.Items[i]);
            }
            suma = suma / lstNote.Items.Count;
            if(radFaraTeza.Checked==true)
            {
                lblMedie.Text = suma.ToString();
            }
             else
            {
                total = ((suma * 3) + Convert.ToDouble(txtTeza.Text)) / 4;
                lblMedie.Text = total.ToString();
            }

        }
        private void radFaraTeza_CheckedChanged(object sender, EventArgs e)
        {
            if(radFaraTeza.Checked==true)
            {
                pnlTeza.Visible = false;
            }
            else
            {
                pnlTeza.Visible = true;
                pnlTeza.Size = new Size(200, 136);
                pnlTeza.Location = new Point(465, 365);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTeza.Visible = false;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            lstNote.Items.Remove(lstNote.SelectedItem);
        }
    }
}

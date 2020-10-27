using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTH43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool co = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            { 
            

            }
                if (co)
                {
                txtSo.Text = null;
                    listBox1.Items.Add(txtSo.Text);
                    txtSo.Text = "";
                    txtSo.Focus();
                    //txtSo.Clear();
                }
            
           
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            int tam;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tam = int.Parse(listBox1.Items[i].ToString());
                tam += 2;
                listBox1.Items[i] = tam;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int tam = 0;
            tam = listBox1.SelectedItems.Count;
            for (int i =tam -1; i >=0; i--)
            {
                //listBox1.Items.Remove(listBox1.SelectedItems[i]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void btChandau_Click(object sender, EventArgs e)
        {
            int tam = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                tam = int.Parse(listBox1.Items[i].ToString());
                if (tam % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("xác nhận đóng form", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = listBox1.Items.Count;
            for (int i = n-1 ; i>=0; i--)
            {   
                int tam;
                tam = int.Parse(listBox1.Items[i].ToString());
                if (tam % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BtnXoaDau_Click(object sender, EventArgs e)
        {
            int tam = 0;
            //tam = listBox1.SelectedItems.Count;
            //for (int i = 0; i < tam ; i++)
            //{
                listBox1.Items.Remove(listBox1.Items[tam]);
            //}
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            listBox1.Items.Remove(listBox1.Items[n-1]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lig_siste4mi
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void giris_btn_Click(object sender, EventArgs e)
        {
            if (Form3.limit == 0)
            {
                MessageBox.Show("Lütfen önce ayarlardan takım ekleyiniz!");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void ayar_btn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void hak_btn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void cks_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
       

    }
}

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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            foreach (Tuple<string, int> tuple in database.takım)
            {
                var temp = new Label();












                temp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
                temp.BackColor = System.Drawing.SystemColors.ActiveCaption;
                temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                temp.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
                temp.Location = new System.Drawing.Point(0, 0);
                temp.Margin = new System.Windows.Forms.Padding(0);
                temp.MinimumSize = new System.Drawing.Size(108, 22);
                temp.Name = "txt_" + tuple.Item1;
                temp.Size = new System.Drawing.Size(110, 22);
                temp.TabIndex = 0;
                temp.Text = tuple.Item1;
                temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;



                flowLayoutPanel1.Controls.Add(temp);

            }
            foreach (Tuple<string, int> tuple in database.takım)
            {

                var temp2 = new Label();

                temp2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                temp2.BackColor = System.Drawing.SystemColors.ActiveCaption;
                temp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                temp2.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
                temp2.Location = new System.Drawing.Point(0, 0);
                temp2.Margin = new System.Windows.Forms.Padding(0);
                temp2.MinimumSize = new System.Drawing.Size(108, 22);
                temp2.Name = "point" + tuple.Item2;
                temp2.Size = new System.Drawing.Size(110, 22);
                temp2.TabIndex = 1;
                temp2.Text = tuple.Item2.ToString();
                temp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                flowLayoutPanel2.Controls.Add(temp2);
            }
        }
        public static int limit = 0;
        public static int count = 0;
        public static int say = 2;
        private void button4_Click(object sender, EventArgs e)
        {
            lbl1.Text = "1.Takım İsmi";
            lbl2.Text = "1.Takım Puanı";

            if (txt_sayi == null)
            {

            }
            else
            {
                limit = int.Parse(txt_sayi.Text);
            }
            txt_sayi.ReadOnly = true;
        }










        private void ekle_btn_Click(object sender, EventArgs e)
        {
            Label lbl_dyn = new Label();
            Label lbl_dyn2 = new Label();

            txt_sayi = new TextBox();
            
            
            
            lbl1.Text = say + ".Takım İsmi";
            lbl2.Text = say + ".Takım Puan";
            say++;
            



            if (count < limit)
            {

                lbl_dyn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
                lbl_dyn.BackColor = System.Drawing.SystemColors.ActiveCaption;
                lbl_dyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lbl_dyn.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
                lbl_dyn.Location = new System.Drawing.Point(0, 0);
                lbl_dyn.Margin = new System.Windows.Forms.Padding(0);
                lbl_dyn.MinimumSize = new System.Drawing.Size(108, 22);
                lbl_dyn.Name = txt_isim.Text;
                lbl_dyn.Size = new System.Drawing.Size(110, 22);
                lbl_dyn.TabIndex = 0;
                lbl_dyn.Text = txt_isim.Text;
                lbl_dyn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                lbl_dyn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                lbl_dyn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
                lbl_dyn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lbl_dyn2.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
                lbl_dyn2.Location = new System.Drawing.Point(0, 0);
                lbl_dyn2.Margin = new System.Windows.Forms.Padding(0);
                lbl_dyn2.MinimumSize = new System.Drawing.Size(108, 22);
                lbl_dyn2.Name = "point" + txt_isim.Text;
                lbl_dyn2.Size = new System.Drawing.Size(110, 22);
                lbl_dyn2.TabIndex = 1;
                lbl_dyn2.Text = txt_puan.Text;
                lbl_dyn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                flowLayoutPanel1.Controls.Add(lbl_dyn);
                flowLayoutPanel2.Controls.Add(lbl_dyn2);

                string name1 = txt_isim.Text;
                int point1 = int.Parse(txt_puan.Text);

                database.takım.Add(new Tuple<string, int>(name1, point1));
                count++;





                txt_isim.Clear();
                txt_puan.Clear();

            }
            else
            {
                MessageBox.Show("Yanlızca " + limit + " takımlı lig oluşturabilirsiniz");
            }

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            database.takım.Sort((a, b) => b.Item2.CompareTo(a.Item2));
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


    }
}

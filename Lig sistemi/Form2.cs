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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            for (int i = 1; i <= Form3.limit; i++)
            {
                var temp0 = new Label();
                temp0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
                temp0.BackColor = System.Drawing.SystemColors.ActiveCaption;
                temp0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                temp0.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
                temp0.Location = new System.Drawing.Point(0, 0);
                temp0.Margin = new System.Windows.Forms.Padding(0);
                temp0.MinimumSize = new System.Drawing.Size(33, 22);
                temp0.Size = new System.Drawing.Size(35, 22);
                temp0.TabIndex = 2;
                temp0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                temp0.Name = "lblsayı" + i;
                temp0.Text = i.ToString();
                flowLayoutPanel3.Controls.Add(temp0);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

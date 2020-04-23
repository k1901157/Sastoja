using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Säästöjä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefault.Checked)
            {
                groupBox2.Enabled = false;

                cbPicking.Checked = true;
                cbJumping.Checked = false;
                cbChecking.Checked = false;
                cbCrying.Checked = false;
                cbDontDo.Checked = true;
                cbYesSir.Checked = false;

                comboBox1.Text = "Group 1";
                comboBox2.Text = "Team 1";

                rbVariable.Checked = true;
                rbObject.Checked = false;
            }
            else
            {
                groupBox2.Enabled = true;
            }

            if (rbCustom.Checked)
            {
                listBox1.Items.Clear();
            }
            if (rbDefault.Checked)
            {
                listBox1.Items.Clear();
            }
        }

        private void BtnMitkäSäädot_Click(object sender, EventArgs e)
        {
            String säädot = "säädot \n";

            if (rbDefault.Checked)
            {
                säädot += rbDefault.Text + ": \n ";
            }
            else
            {
                säädot += rbCustom.Text + ": \n ";
            }

            if (!listBox1.Items.Contains(säädot))
            {
                listBox1.Items.Add(säädot);
            }

            foreach (CheckBox cb in groupBox5.Controls)
            {
                if (cb.Checked)
                {
                    if (!listBox1.Items.Contains(cb.Text))
                    {
                        listBox1.Items.Add(cb.Text);
                    }
                }
            }

            if (!listBox1.Items.Contains(comboBox1.Text))
            {
                listBox1.Items.Add(comboBox1.Text);
            }

            if (!listBox1.Items.Contains(comboBox2.Text))
            {
                listBox1.Items.Add(comboBox2.Text);
            }

            foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Checked)
                {
                    if (!listBox1.Items.Contains(rb.Text))
                    {
                        listBox1.Items.Add(rb.Text);
                    }
                }
            }

        }
    }
}

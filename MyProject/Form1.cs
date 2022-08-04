namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Attributes idAttr = new Attributes("0000", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty");

        private void btnID_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                lblID.Text = "ID can't be empty!";
            }else
            {
                lblID.Text = txtID.Text;
                idAttr.id = lblID.Text;
                txtID.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lblID.Text != "0000")
            {
                tableData.Rows.Add(idAttr.id, idAttr.attribute_1, idAttr.attribute_2, idAttr.attribute_3, idAttr.attribute_4, idAttr.attribute_5, idAttr.attribute_6, idAttr.attribute_7, idAttr.attribute_8);
                idAttr = new Attributes("0000", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty", "Empty");
                btn1.BackColor = SystemColors.ControlLight;
                btn2.BackColor = SystemColors.ControlLight;
                btn3.BackColor = SystemColors.ControlLight;
                btn4.BackColor = SystemColors.ControlLight;
                btn5.BackColor = SystemColors.ControlLight;
                btn6.BackColor = SystemColors.ControlLight;
                btn7.BackColor = SystemColors.ControlLight;
                btn8.BackColor = SystemColors.ControlLight;
                lblID.Text = "0000";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "|*.csv" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    List<string> list = File.ReadAllLines(ofd.FileName).ToList();
                    if (list.Count < 1)
                    {
                        btn1.Text = "Empty";
                    }else {
                        btn1.Text = list[0];
                    }
                    if(list.Count < 2)
                    {
                        btn2.Text = "Empty";
                    }else
                    {
                        btn2.Text = list[1];
                    }
                    if (list.Count < 3)
                    {
                        btn3.Text = "Empty";
                    }else
                    {
                        btn3.Text = list[2];
                    }
                    if (list.Count < 4)
                    {
                        btn4.Text = "Empty";
                    }
                    else
                    {
                        btn4.Text = list[3];
                    }
                    if (list.Count < 5)
                    {
                        btn5.Text = "Empty";
                    }
                    else
                    {
                        btn5.Text = list[4];
                    }
                    if (list.Count < 6)
                    {
                        btn6.Text = "Empty";
                    }
                    else
                    {
                        btn6.Text = list[5];
                    }
                    if (list.Count < 7)
                    {
                        btn7.Text = "Empty";
                    }
                    else
                    {
                        btn7.Text = list[6];
                    }
                    if (list.Count < 8)
                    {
                        btn8.Text = "Empty";
                    }
                    else
                    {
                        btn8.Text = list[7];
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == SystemColors.ControlLight && btn1.Text != "Empty")
            {
                idAttr.attribute_1 = btn1.Text;
                btn1.BackColor = SystemColors.Highlight;
            }
            else
            {
                btn1.BackColor = SystemColors.ControlLight;
                idAttr.attribute_1= "Empty";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == SystemColors.ControlLight && btn2.Text != "Empty")
            {
                idAttr.attribute_2 = btn2.Text;
                btn2.BackColor = SystemColors.Highlight;
            }else
            {
                btn2.BackColor = SystemColors.ControlLight;
                idAttr.attribute_2 = "Empty";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == SystemColors.ControlLight && btn3.Text != "Empty")
            {
                idAttr.attribute_3 = btn3.Text;
                btn3.BackColor = SystemColors.Highlight;
            }else
            {
                btn3.BackColor = SystemColors.ControlLight;
                idAttr.attribute_3 = "Empty";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == SystemColors.ControlLight && btn4.Text != "Empty")
            {
                idAttr.attribute_4 = btn4.Text;
                btn4.BackColor = SystemColors.Highlight;
            }
            else
            {
                btn4.BackColor = SystemColors.ControlLight;
                idAttr.attribute_4 = "Empty";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == SystemColors.ControlLight && btn5.Text != "Empty")
            {
                idAttr.attribute_5 = btn5.Text;
                btn5.BackColor = SystemColors.Highlight;
            }
            else
            {
                btn5.BackColor = SystemColors.ControlLight;
                idAttr.attribute_5 = "Empty";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == SystemColors.ControlLight && btn6.Text != "Empty")
            {
                idAttr.attribute_6 = btn6.Text;
                btn6.BackColor = SystemColors.Highlight;
            }
            else
            {
                btn6.BackColor = SystemColors.ControlLight;
                idAttr.attribute_6 = "Empty";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == SystemColors.ControlLight && btn7.Text != "Empty")
            {
                idAttr.attribute_7 = btn7.Text;
                btn7.BackColor = SystemColors.Highlight;
            }
            else
            {
                btn7.BackColor = SystemColors.ControlLight;
                idAttr.attribute_7 = "Empty";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == SystemColors.ControlLight && btn8.Text != "Empty")
            {
                idAttr.attribute_8 = btn8.Text;
                btn8.BackColor = SystemColors.Highlight;
            }
            else
            {
                btn8.BackColor = SystemColors.ControlLight;
                idAttr.attribute_8 = "Empty";
            }
        }

        public bool btnToggle = true;
        private void btnTable_Click(object sender, EventArgs e)
        {
            if(btnToggle == true)
            {
                tableData.Visible = false;
                btnToggle = false;
            }else
            {
                tableData.Visible = true;
                btnToggle = true;
            }
        }
    }
}
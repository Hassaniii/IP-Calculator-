using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Calculator_DCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            IP_txt.Enabled = false;
            Req_txt.Enabled = false;
            Calc_btn.Enabled = false;
            FLSM_Mass.Enabled = false;
            VLSM_Mass.Enabled = false;
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
           
            
            if (FLSM_chck.Checked)
            {
                FLSM_Mass.Show();
                FLSM_Mass.Enabled = true;
                VLSM_Mass.Hide();
            }

            else if (VLSM_chck.Checked)
            {
                VLSM_Mass.Show();
                VLSM_Mass.Enabled = true;
                FLSM_Mass.Hide();
            }

            else
            {
                return;
            }

            IP_txt.Enabled = true;
            Calc_btn.Enabled = true;
            Req_txt.Enabled = true;

        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {

            FLSM_Addressing FLSM = new FLSM_Addressing();
            VLSM_Addressing VLSM = new VLSM_Addressing();

            string IP_Class = Classes(IP_txt.Text);

            Class_Label.Text = IP_Class;


            if (FLSM_chck.Checked)
            {

                Other_Networks.Items.Clear();

                FLSM.Address(IP_txt.Text, IP_Class, Req_txt.Text);

                Subnet_Label.Text = FLSM.subnet;
                Network_Label.Text = FLSM.network;
                First_Label.Text = FLSM.first;
                Last_Label.Text = FLSM.last;
                Broadcast_Label.Text = FLSM.broadcast;


                try
                {
                    for (int i = 0; i < Convert.ToInt32(Req_txt.Text); i++)
                    {

                        if (FLSM.aaa[i] == null)
                        {
                            break;
                        }


                        if (Class_Label.Text == "A")
                        {
                            Other_Networks.Items.Add(FLSM.split[0] + "." + FLSM.aaa[i] + ".0.0");
                        }

                        else if (Class_Label.Text == "B")
                        {
                            Other_Networks.Items.Add(FLSM.split[0] + "." + FLSM.split[1] + "." + FLSM.aaa[i] + ".0");
                        }

                        else if (Class_Label.Text == "C" || Class_Label.Text == "D" || Class_Label.Text == "E")
                        {
                            Other_Networks.Items.Add(FLSM.split[0] + "." + FLSM.split[1] + "." + FLSM.split[2] + "." + FLSM.aaa[i]);
                        }


                    }
                }
                catch (Exception)
                {

                  
                }


            }


            else if (VLSM_chck.Checked)
            {

                VLSM.Address(IP_txt.Text, IP_Class, Convert.ToInt32(VLSM_Mass.Text));


                Subnet_Label.Text = VLSM.subnet;
                Network_Label.Text = VLSM.network;
                First_Label.Text = VLSM.first;
                Last_Label.Text = VLSM.last;
                Broadcast_Label.Text = VLSM.broadcast;

                Class_Label.Text = "Class Less";

            }



        }


        public string Classes(string IP)
        {



            string Ans = "";


            try
            {

                string[] Octet = IP.Split('.');


                if (Octet.Length < 4 || Octet.Length > 4)
                {
                    MessageBox.Show("Invalid IP Address");
                    goto end;
                }


                if (Octet[0].Length > 3 || Octet[0].Length < 1)
                {
                    MessageBox.Show("Invalid IP Address");

                    goto end;

                }

                int IP_Class = Convert.ToInt32(Octet[0]);

                if (IP_Class > 0 && IP_Class <= 127)
                {
                    Ans = "A";
                }


                else if (IP_Class >= 128 && IP_Class <= 191)
                {
                    Ans = "B";
                }


                else if (IP_Class >= 192 && IP_Class <= 223)
                {
                    Ans = "C";
                }


                else if (IP_Class >= 224 && IP_Class <= 239)
                {
                    Ans = "D";
                }


                else if (IP_Class >= 240 && IP_Class <= 254)
                {
                    Ans = "E";
                }

                else
                {
                    MessageBox.Show("Invalid IP Address");
                }

            }


            catch
            {

                MessageBox.Show("Invalid IP Address");

            }

            end:


            if (Ans != "A" && Ans != "B" && Ans != "C" && Ans != "D" && Ans != "E")
            {
                this.Close();
            }

            return Ans;




        }

        private void IP_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IP_txt.Text) == true)
            {
                IP_txt.Focus();
                
                errorProvider1.SetError(this.IP_txt, "Please enter IP address!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void VLSM_Mass_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(VLSM_Mass.Text) == true)
            {
                VLSM_Mass.Focus();

                errorProvider2.SetError(this.VLSM_Mass, "Please enter Subnet mask!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void Req_txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Req_txt.Text) == true)
            {
                Req_txt.Focus();

                errorProvider3.SetError(this.Req_txt, "Please enter network!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
    }
}

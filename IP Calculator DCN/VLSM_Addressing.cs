using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Calculator_DCN
{
    class VLSM_Addressing
    {


        public string network;
        public string last;
        public string first;
        public string broadcast;
        public string subnet;
        string[] binary;
        double[] b;
        int power;
        int count;
        double add;
        double mask;
        int line;

        public void Address(string IP, string Class, int sub)
        {

            string[] split = IP.Split('.');


            if (Class == "A")
            {

                binary = new string[3];
                b = new double[24];
                power = 7;
                count = 0;
                add = 0;
                mask = 0;
                line = sub - 8;


                for (int i = 0; i < 3; i++)
                {
                    binary[i] = Convert.ToString(Convert.ToInt32(split[i + 1]), 2);

                    while (binary[i].Length < 8)
                    {
                        binary[i] = "0" + binary[i];
                    }


                    for (int j = 0; j < 8; j++)
                    {

                        b[count] = Convert.ToInt32(binary[i][j].ToString());
                        count++;

                    }

                }

                count = 1;

                for (int i = line; i < 24; i++)
                {
                    b[i] = 0;
                }


                for (int i = 0; i < 24; i++)
                {

                    if (b[i] == 1)
                    {
                        add = add + Math.Pow(2, power);
                    }

                    power--;

                    if (i == 7 || i == 15 || i == 23)
                    {
                        power = 7;
                        split[count] = add.ToString();
                        count++;
                        add = 0;

                    }

                }

                network = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                split[3] = (Convert.ToInt32(split[3]) + 1).ToString();

                first = split[0] + "." + split[1] + "." + split[2] + "." + split[3];


                count = 1;

                for (int i = line; i < 23; i++)
                {
                    b[i] = 1;
                }

                for (int i = 0; i < 24; i++)
                {

                    if (b[i] == 1)
                    {
                        add = add + Math.Pow(2, power);
                    }

                    power--;
                                                                                                                                                   

                    if (i == 7 || i == 15 || i == 23)
                    {
                        power = 7;
                        split[count] = add.ToString();
                        count++;
                        add = 0;

                    }


                }

                last = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                split[3] = (Convert.ToInt32(split[3]) + 1).ToString();

                broadcast = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                power = 7;

                for (int i = 0; i < line; i++)
                {
                    mask = mask + Math.Pow(2, power);
                    power--;
                }

                subnet = "255." + mask.ToString() + ".0" + ".0";

            }




            else if (Class == "B")
            {

                binary = new string[3];
                b = new double[16];
                power = 7;
                count = 0;
                add = 0;
                mask = 0;
                line = sub - 16;


                for (int i = 1; i < 3; i++)
                {
                    binary[i] = Convert.ToString(Convert.ToInt32(split[i + 1]), 2);

                    while (binary[i].Length < 8)
                    {
                        binary[i] = "0" + binary[i];
                    }


                    for (int j = 0; j < 8; j++)
                    {

                        b[count] = Convert.ToInt32(binary[i][j].ToString());
                        count++;

                    }

                }

                count = 2;

                for (int i = line; i < 16; i++)
                {
                    b[i] = 0;
                }


                for (int i = 0; i < 16; i++)
                {

                    if (b[i] == 1)
                    {
                        add = add + Math.Pow(2, power);
                    }

                    power--;

                    if (i == 7 || i == 15 || i == 23)
                    {
                        power = 7;
                        split[count] = add.ToString();
                        count++;
                        add = 0;

                    }

                }

                network = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                split[3] = (Convert.ToInt32(split[3]) + 1).ToString();

                first = split[0] + "." + split[1] + "." + split[2] + "." + split[3];



                count = 2;

                for (int i = line; i < 15; i++)
                {
                    b[i] = 1;
                }

                for (int i = 0; i < 15; i++)
                {

                    if (b[i] == 1)
                    {
                        add = add + Math.Pow(2, power);
                    }

                    power--;


                    if (i == 7 || i == 14)
                    {
                        power = 7;
                        split[count] = add.ToString();
                        count++;
                        add = 0;

                    }


                }

                last = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                split[3] = (Convert.ToInt32(split[3]) + 1).ToString();

                broadcast = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                power = 7;

                for (int i = 0; i < line; i++)
                {
                    mask = mask + Math.Pow(2, power);
                    power--;
                }

                subnet = "255." + "255." + mask.ToString() + ".0";


            }






            else if (Class == "C" || Class == "D" || Class == "E")
            {


                binary = new string[3];
                b = new double[8];
                power = 7;
                count = 0;
                add = 0;
                mask = 0;
                line = sub - 24;


                for (int i = 2; i < 3; i++)
                {
                    binary[i] = Convert.ToString(Convert.ToInt32(split[i + 1]), 2);

                    while (binary[i].Length < 8)
                    {
                        binary[i] = "0" + binary[i];
                    }


                    for (int j = 0; j < 8; j++)
                    {

                        b[count] = Convert.ToInt32(binary[i][j].ToString());
                        count++;

                    }

                }

                count = 3;

                for (int i = line; i < 8; i++)
                {
                    b[i] = 0;
                }


                for (int i = 0; i < 8; i++)
                {

                    if (b[i] == 1)
                    {
                        add = add + Math.Pow(2, power);
                    }

                    power--;

                    if (i == 7)
                    {
                        power = 7;
                        split[count] = add.ToString();
                        count++;
                        add = 0;

                    }

                }

                network = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                split[3] = (Convert.ToInt32(split[3]) + 1).ToString();

                first = split[0] + "." + split[1] + "." + split[2] + "." + split[3];


                count = 3;

                for (int i = line; i < 7; i++)
                {
                    b[i] = 1;
                }

                for (int i = 0; i < 8; i++)
                {

                    if (b[i] == 1)
                    {
                        add = add + Math.Pow(2, power);
                    }

                    power--;


                    if (i == 7)
                    {
                        power = 7;
                        split[count] = add.ToString();
                        count++;
                        add = 0;

                    }


                }

                last = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                split[3] = (Convert.ToInt32(split[3]) + 1).ToString();

                broadcast = split[0] + "." + split[1] + "." + split[2] + "." + split[3];

                power = 7;

                for (int i = 0; i < line; i++)
                {
                    mask = mask + Math.Pow(2, power);
                    power--;
                }

                subnet = "255." + "255." + "255." + mask.ToString();


            }








        }








    }
}

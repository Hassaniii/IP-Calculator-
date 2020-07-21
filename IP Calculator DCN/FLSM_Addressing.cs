using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Calculator_DCN
{
    class FLSM_Addressing
    {

        public string network;
        public string last;
        public string first;
        public string broadcast;
        public string subnet;
        string[] binary;
        double[] calc;
        int power;
        int count;
        double add;
        double mask;
        public string[] aaa;
        public string[] split;

        public void Address(string IP, string class_, string req)
        {
            try
            {
                split = IP.Split('.');

            int req_ = Convert.ToInt32(req);


            if (class_ == "A")
            {

                binary = new string[3];
                calc = new double[24];
                power = 0;
                count = 0;
                add = 0;
                mask = 0;


                for (int i = 0; i < 3; i++)
                {
                    binary[i] = Convert.ToString(Convert.ToInt32(split[i + 1]), 2);

                    while (binary[i].Length < 8)
                    {
                        binary[i] = "0" + binary[i];
                    }


                    for (int j = 0; j < 8; j++)
                    {

                        calc[count] = Convert.ToInt32(binary[i][j].ToString());
                        count++;

                    }

                }


                for (int i = 0; i < 8; i++)
                {
                    if (Math.Pow(2, power) > req_)
                    {
                        break;
                    }

                    power++;

                }

                int line = power;

                count = 1;

                for (int i = 0; i < 24; i++)
                {
                    calc[i] = 0;
                }

                power = 7;

                for (int i = 0; i < 24; i++)
                {

                    if (calc[i] == 1)
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
                    calc[i] = 1;
                }


                power = 7;

                for (int i = 0; i < 24; i++)
                {

                    if (calc[i] == 1)
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


                aaa = new string[255];

                power = 7 - line;
                count = 0;


                int oct = Convert.ToInt32(split[1]) + 1;


                for (double i = 0; i <= 254; i++)
                {

                    aaa[count] = (oct * (i + 1)).ToString();

                    if (Convert.ToInt32(aaa[count]) >= 254)
                    {
                        break;
                    }

                    count++;
                }


                power = 7;

                for (int i = 0; i < line; i++)
                {
                    mask = mask + Math.Pow(2, power);
                    power--;
                }

                    // subnet = "255." + mask.ToString() + ".0" + ".0";
                    subnet = "255." + "0" + ".0" + ".0";



                }



            else if (class_ == "B")
            {

                binary = new string[3];
                calc = new double[16];
                power = 7;
                count = 0;
                add = 0;
                mask = 0;


                for (int i = 1; i < 3; i++)
                {
                    binary[i] = Convert.ToString(Convert.ToInt32(split[i + 1]), 2);

                    while (binary[i].Length < 8)
                    {
                        binary[i] = "0" + binary[i];
                    }


                    for (int j = 0; j < 8; j++)
                    {

                        calc[count] = Convert.ToInt32(binary[i][j].ToString());
                        count++;

                    }

                }

                power = 0;

                for (int i = 0; i < 8; i++)
                {
                    if (Math.Pow(2, power) > req_)
                    {
                        break;
                    }

                    power++;

                }

                int line = power;



                count = 2;

                for (int i = 0; i < 16; i++)
                {
                    calc[i] = 0;
                }


                power = 7;

                for (int i = 0; i < 16; i++)
                {

                    if (calc[i] == 1)
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
                    calc[i] = 1;
                }

                power = 7;

                for (int i = 0; i < 15; i++)
                {

                    if (calc[i] == 1)
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


                aaa = new string[255];

                power = 7 - line;
                count = 0;


                int oct = Convert.ToInt32(split[2]) + 1;

                for (double i = 0; i <= 254; i++)
                {

                    aaa[count] = (oct * (i + 1)).ToString();

                    if (Convert.ToInt32(aaa[count]) >= 254)
                    {
                        break;
                    }

                    count++;
                }


                power = 7;

                for (int i = 0; i < line; i++)
                {
                    mask = mask + Math.Pow(2, power);
                    power--;
                }

                    // subnet = "255." + "255." + mask.ToString() + ".0";
                    subnet = "255." + "255." + "0" + ".0";

                }






            else if (class_ == "C" || class_ == "D" || class_ == "E")
            {


                binary = new string[3];
                calc = new double[8];
                power = 7;
                count = 0;
                add = 0;
                mask = 0;


                for (int i = 2; i < 3; i++)
                {
                    binary[i] = Convert.ToString(Convert.ToInt32(split[i + 1]), 2);

                    while (binary[i].Length < 8)
                    {
                        binary[i] = "0" + binary[i];
                    }


                    for (int j = 0; j < 8; j++)
                    {

                        calc[count] = Convert.ToInt32(binary[i][j].ToString());
                        count++;

                    }

                }




                power = 0;

                for (int i = 0; i < 8; i++)
                {
                    if (Math.Pow(2, power) > req_)
                    {
                        break;
                    }

                    power++;

                }

                int line = power;




                count = 3;

                for (int i = 0; i < 8; i++)
                {
                    calc[i] = 0;
                }

                power = 7;

                for (int i = 0; i < 8; i++)
                {

                    if (calc[i] == 1)
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
                    calc[i] = 1;
                }

                for (int i = 0; i < 8; i++)
                {

                    if (calc[i] == 1)
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




                aaa = new string[255];

                power = 7 - line;
                count = 0;


                int oct = Convert.ToInt32(split[3]) + 1;

                for (double i = 0; i <= 254; i++)
                {

                    aaa[count] = (oct * (i + 1)).ToString();

                    if (Convert.ToInt32(aaa[count]) >= 254)
                    {
                        break;
                    }

                    count++;
                }






                power = 7;

                for (int i = 0; i < line; i++)
                {
                    mask = mask + Math.Pow(2, power);
                    power--;
                }

                    //subnet = "255." + "255." + "255." + mask.ToString();
                    subnet = "255." + "255." + "255." + "0";


                }


            }
            catch (Exception)
            {

                
            }
            
        }

    }
}

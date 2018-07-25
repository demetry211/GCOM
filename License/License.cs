using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace License
{
    public class License
    {
        public string license_type = "N";
        public int nb=1000;
        public string key = "";
        public bool verifier_license(string licenceKey, string l)
        {
            bool ok = false;
            if (licenceKey.Split('-').Length==3)
            {
                string c1 = licenceKey.Split('-')[0];
                string c2 = licenceKey.Split('-')[1];
                string c3 = licenceKey.Split('-')[2];

                string s1 = "";
                for (int i = 0; i < c1.Length; i++)
                {
                    s1 += (char)((int)c1[i] - 3);
                }

                string s2 = "";
                for (int i = 0; i < c2.Length; i++)
                {
                    s2 += (char)((int)c2[i] - 2);
                }

                string s3 = "";
                for (int i = 0; i < c3.Length; i++)
                {
                    s3 += (char)((int)c3[i] - 4);
                }

                string s = string.Format("{0}{1}{2}", s1.Substring(0, 1), s2.Substring(0, s2.Length - 1), s3);

                string clé = "";
                for (int i = 0; i < s.Length; i++)
                {
                    if (i < 20)
                    {
                        if (i % 2 == 0)
                        {
                            clé += s[i].ToString().ToUpper();
                        }
                    }
                    else
                    {
                        clé += s[i].ToString().ToUpper();
                        i = i + 2;

                    }
                }

                if (clé.ToUpper() == l)
                    ok = true;
            }
            

            return ok;
        }

    }
}

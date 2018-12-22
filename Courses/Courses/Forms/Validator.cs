using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    static class Validator
    {
        public static bool Group(string group)
        {
            if (group.Length == 1 && group[0] > '0' && group[0] <= '9')
                return true;
            if (group.Length == 2 && group[0] == '1' && group[1] >= '0' && group[1] <= '2')
                return true;
            return false;
        }

        public static bool SertificateNumber(string sertificateNumber)
        {
            bool res = false;
            if (sertificateNumber.Length == 9)
            {
                res = true;
                int i = 0;
                while (i < 9 && res)
                    if (sertificateNumber[i] < '0' || sertificateNumber[i] > '9')
                        res = false;
            }
            return res;
        }

        public static bool Duration(string duration)
        {
            bool res = false;
            //TODO
            if (duration.Length >=0 && duration.Length <=3 && duration[0]<='4')
            {
                res = true;
                int i = 0;
                while (res && i < duration.Length)
                    if (duration[i] < '0' && duration[i] > '9')
                        res = false;

            }
            return res;
        }

        public static bool Cost(string cost)
        {
            if (cost.Contains("."))
            {
                if (cost.Length <= 9)
                {
                    //TODO
                }
                return false;
            }
            else
            {
                if (cost.Length<=6 && cost.Length>0)
                {

                    foreach (char c in cost)
                        if (c < '0' && c > '9')
                            //TODO
                            return false;
                    //TODO
                }
                return false;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Boolean<T> : Stapel<T>
    {
        List<T> booleanStapel = new List<T>();


        public override string ToString()
        {
            string legeString2 = "";

            foreach (T item in booleanStapel)
            {
                legeString2 += item.ToString() + "; ";
            }
            return legeString2;
        }

        public List<T> Copy(List<T> booleanStapel)
        {
            List<T> backupList2 = new List<T>();
            foreach (T item in booleanStapel)
            {
                backupList2.Add(item);
            }
            return backupList2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Stapel<T>
    {
        List<T> stapel = new List<T>();

        public void Toevoegen(T item)
        {
            stapel.Add(item);
        }

        public T Verwijderen()
        {
            if(stapel.Count <= 0)
            {
                throw new Exception();
            }
            else
            {
                T item = stapel[stapel.Count - 1];
                stapel.RemoveAt(stapel.Count - 1);
                return item;
            }
        }

        public void Leegmaken()
        {
            stapel.Clear();
        }

        public override string ToString()
        {
            string legeString = "";

            foreach(T item in stapel)
            {
                legeString += item.ToString() + "; ";
            }
            return legeString;
        }

        public bool IsAanwezig(T item)
        {
            if(stapel.Count > 0 && stapel.Contains(item))
            {
                return true;
            }
            return false;
        }

     

        public string Copy()
        {
            List<T> backupList = new List<T>();
            backupList = stapel;
           
            string legeString = "";

            foreach (T item in backupList)
            {
                legeString += item.ToString() + "; ";
            }
            return legeString;
        }

        
        

    }
}

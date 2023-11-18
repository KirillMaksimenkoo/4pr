using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4pr
{
    public class Arrays
    {

        public int[] a;
        int length = 0;

        public int Length { get { return length; } set { length = value; } }

        public Arrays(int n) { 
        
            a = new int[n];

        }
        public int CalculateAverageB()
        {
            if (length == 0)
            {
                throw new InvalidOperationException("Array is empty");
            }

            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += a[i];
            }

            int average = sum / length;

            return average;
        }

    }


    interface IRead
    {
        void read(string patch, Arrays a);
    }

    interface IWrite
    {
        void write(string patch, Arrays a);
    }

    class FileRead : IRead
    {
        public void read(string patch, Arrays a)
        {

            using (StreamReader sr = new StreamReader(patch, System.Text.Encoding.Default))
            {

                string line = "";
                try
                {
                    int i = 0;
                    while((line = sr.ReadLine()) != null)
                    {
                        a.a[i] = Convert.ToInt32(line);
                        i++;
                    }

                    a.Length = i;
                    sr.Close();
                }

                catch
                {
                    throw new AccessViolationException("Error in file");
                }

            }

        }
    }

    class FileWrite : IWrite
    {
        public void write(string patch, Arrays a)
        {
            using (StreamWriter sw = new StreamWriter(patch, true, System.Text.Encoding.Default))
            {
                foreach(var item in a.a)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }

        }

        public void write2(string patch, int x)
        {
            using (StreamWriter sw = new StreamWriter(patch, true, System.Text.Encoding.Default))
            {
                
                sw.WriteLine(x.ToString());
                
                sw.Close();
            }

        }


    }

    class ShowArray
    {
        public string writeArray(int[] array)
        {
            string s = "";
            foreach(int i in array){
                s += i.ToString() + " ";
            }
            return s;
        }
    }
}

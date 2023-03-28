using System.Collections;

namespace ListvsArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();

            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add("three");

            int sum = 0;
               
            foreach(int i in arraylist)
            {
                sum += i;
            }

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            //list.Add("three");
        }
    }
}
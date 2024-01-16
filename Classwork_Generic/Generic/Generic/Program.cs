using System.Collections;

namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            List<int> ints = new List<int>();
            myList = new MyList();
            myList.Value = ints; // Its bad. For this we have Generic
            */


            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add("Hello");

            FileName.method(5, 6.25);
        }
    }
}
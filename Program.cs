namespace Metoder
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //    //Program.Print()¨;

            //    //    JamnaSiffror();

            //    //    void JamnaSiffror()
            //    //    {
            //    //        int i = 0;
            //    //        while ( i <= 20)
            //    //        {
            //    //            Console.WriteLine(i);
            //    //            i += 2;
            //    //        }
            //    //    }


            //    //Program program = new Program();
            //    //program.JamnaSiffror();

            //    Program.UddaSiffror();
            JamnaSiffror();
            Console.WriteLine(JamnaSiffror());

        }

        public static string JamnaSiffror()
        {
            int Start = 0;
            string Answer = "";

            while (Start <= 20)
            {
                Answer = Answer + Start + "";
                Start += 2;
            }
;
            return Answer;

        }

        //public static void UddaSiffror()
        //{
        //    int start = 0;
        //        while ( start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start += 3;
        //    }
        //}

        //public void JamnaSiffror()
        //{
        //    int i = 0;
        //    while (i <= 20)
        //    {
        //        Console.WriteLine(i);
        //        i += 2;
        //    }
        //}
        ////    public static void Print ()
        ////    {
        ////        Console.WriteLine("hello");
        ////    }
    }
}
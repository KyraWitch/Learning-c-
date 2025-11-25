namespace Learning_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Array 1

            int[] ages = new int[5];
            ages[0] = 25;
            ages[1] = 28;
            ages[2] = 15;
            ages[3] = 35;
            ages[4] = 14;

            Console.WriteLine(ages[0]);

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }


            //Name array / Array 2
            string[] names = new string[] {"Hans", "Anton", "Betinna", "Daniel"};

            //Output
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //
            names[3] = "Kong Daniel";

            for (int i = 0;i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }



            //Array 3

            int[] numbers = new int[] {7,79,95,73,78,18,76,80,60,21};

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }



            //Array 4 

            int[] nums = {1,2,3,4,5};

            for (int i = 0; i < nums.Length; i++) { nums[i] += 5; }

            Console.WriteLine("Updated array:" + string.Join(",",nums));

            // List area



            //List 1 ages

            List<int> ages2 = new List<int>();

            ages2.Add(5);
            ages2.Add(17);
            ages2.Add(20);
            ages2.Add(40);
            ages2.Add(51);

            //list 2 names

            List<string> names2 = new List<string>();

            names2.Add("Jens");
            names2.Add("Karl");
            names2.Add("Johannes");
            names2.Add("Anton");
            names2.Add( "Nicklas" );

            //List 3 Percents

            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17};

            //list 4 areMarried

            List<bool> areMarried = new List<bool>() {true,false,false,true,true};

            //list 5 Names3
            List<string> names3 = new List<string>() {"Hans","Kristian", "Jens", "Karsten", "Ib"};

            //list 5 control
            names3.Insert(3, "Anders");

            names3.Insert(2, "Lars");


            //List 6 ages4
            List<int> ages4 = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };



            //control list 6
            ages4.Remove(13);
            ages4.Remove(15);



            //Output of lists

            //list 1 output
            for (int i = 0; i < ages2.Count; i++)
            {
                Console.WriteLine(ages2[i]);
            }

            //list 2 output
            for (int i = 0; i < names2.Count; i++) 
            {
                Console.WriteLine(names2[i]);
            }

            //list 3 output
            foreach (double percentage in percentages) 
            {
            Console.WriteLine( percentage);
            }


            //List 4 output 
            foreach (bool isMarried in areMarried)
            {
                Console.WriteLine(isMarried);
            }

            //List 5 output

            foreach (string name in names3) 
            {
                Console.WriteLine(name);
            }

            //list 6 output
            foreach (int age in ages4)
            {
                Console.WriteLine(age);
            }







        }
    }
}

namespace assigment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            
            Console.Write("enter the number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"the nmuber={number}");
            
            #endregion
            
            #region question2
            
            String s = "tarek";
            Console.WriteLine(string.GetHashCode(s));
            
            #endregion
            
            #region question3
            
            float x = 24f;
            float y = x / 5.0f;
            Console.WriteLine(y);
            
            #endregion
           
            #region question4
            
            string str = "my name is tarek yasser";
            Console.WriteLine(str.Substring(7, 9));
            
            #endregion
           
            #region question5
            
            int number1 = 5;
            int number2 = number1;
            number1++;
            Console.WriteLine($"number1={number1},number2={number2}");
            
            #endregion
           
            #region question6
            
            Tarek ob1;
            ob1= new Tarek();
            Tarek ob2 = new Tarek();
            ob1.x = 5;
            ob2 = ob1;
            ob2.x = 10;
            Console.WriteLine(ob1.x+","+ob2.x);
            
            #endregion
            
            #region question7
            
            Console.Write("enter tne string1:");
            string s1 = Console.ReadLine()!;
            Console.Write("enter tne string2:");
            string s2 = Console.ReadLine()!;
            string s3 = s1 +" " +s2;
            Console.WriteLine(s3);
            
            #endregion
            
            #region question8
            int d = Convert.ToInt32(!(30 < 20));
            //solution
            //b) A value 1 will be assigned to d
            #endregion

            #region question9
            //solution
            // the output is--> d) 6,1
            #endregion

            #region question10
            // solution
            //the output is --> d)7,7
            #endregion

        }


    }
    class Tarek
    {

      public int x;
     


    }
}

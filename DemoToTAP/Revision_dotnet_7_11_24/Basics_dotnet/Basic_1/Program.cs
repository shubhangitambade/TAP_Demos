using Basic_indexer;

namespace Basic_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Books myColletion = new Books();

            string title = myColletion[3];
            Console.WriteLine("Title= " + title);
            myColletion[3] = "Who moved my Cheese";
            title = myColletion[3];
            Console.WriteLine("Title= " + title);


            myColletion[0] = "Wings of Fire";
            myColletion[1] = "Wise and OtherWise";
            string title1 = myColletion[0];
            string title2 = myColletion[1];
            Console.WriteLine("1st book : " + title1);
            Console.WriteLine("2nd book : " + title2);

            Console.WriteLine();
            // Person prn = new Person(); //Error Person.Person() inaccessible due to protection level.
            //prn.FirstName = "Sachin";
            //prn.LastName = "Nene";
            //prn.Id=765;
            //Console.WriteLine(prn.Id + " "+ prn.FirstName + " "+ prn.LastName);*/

            /*Person p1 =  Person.CreateInstance();
            Person p2 = Person.CreateInstance();
            Person p3 = Person.CreateInstance();
            p1.display();
            p2.display();
            p3.display();

            Console.WriteLine();*/

            /* VoteMachine vm1 = VoteMachine.Instance();
             VoteMachine vm2 = VoteMachine.Instance();
             VoteMachine vm3 = VoteMachine.Instance();

             vm1.RegisterVote();
             vm2.RegisterVote();
             vm3.RegisterVote();

             Console.WriteLine(vm1.TotalVotes);*/

            Console.WriteLine("----Params--------");

            Param_ref_out paramsdemo = new Param_ref_out();
            paramsdemo.Display("India");
            paramsdemo.Display("Maharashtra", "Karnataka", "Orisa");


            Console.WriteLine("----ref keyword --------");
            int num1 = 11;
            int num2 = 10;
            Console.WriteLine("Before swapping :  num1 =  {0} , num2 =  {1}", num1, num2);
            paramsdemo.Swap(ref num1, ref num2);
            Console.WriteLine("After swapping :  num1 =  {0} , num2 =  {1}", num1, num2);

            Console.WriteLine("------------ out -----------------");
            double area, parameter;
            paramsdemo.Calculate(2, out area, out parameter);

            Console.WriteLine("-----------------IDisposable Demo---------------------------");
            Product[] products =
            {
                new Product { Title = "Rose", UnitPrice = 10 },
                new Product { Title = "Marigold", UnitPrice = 20 },
                new Product { Title = "Lotus", UnitPrice = 30 }

            };
            foreach (Product product in products)
            {
                Console.WriteLine("Title = {0}  UnitPrice = {1} " , product.Title, product.UnitPrice);
            }



            Product pp = new Product();

            pp.Dispose();

            //when object is defined using using block
            //objects dispose is automatically called by Primary Thread
            //
            using (Product p1 = new Product())
            {
                p1.Title = "Gerbera";
                p1.UnitPrice = 12;
                //Do other stuff

            }

            using (Product p2 = new Product())
            {



            }

            Product p3 = new Product();

           /* Console.WriteLine("------------------- Arrays ------------------------");
            var evenNums = new int[] { 2, 4, 6, 8, 10 };

            var cities = new string[] { "Mumbai", "London", "New York" };

            Console.WriteLine("------------ Cloning ---------------------");
            //Stack planes=flightsLanded;
            //to Achieve deep copy

            //Stack flights = (Stack)flightsLanded.Clone();
            //flights.sArr[3]=453;
            //flightsLanded.sArr[3]=675;
            //flights[3]=564
           */

            Console.WriteLine("-------- Student Partial Class ------------------");

            Student stu = new Student();    
            stu.PRN = 1;
            stu.FullName = "Shubhangi Tamabde";
            stu.Email = "stambade@gmail.com";
            stu.Location = "Pune";

            Console.WriteLine("PRn ={0}, Name = {1} , Email = {2} , Location = {3} ",stu.PRN,stu.FullName,stu.Email,stu.Location);


            Console.WriteLine("------------------------ Implicit Interface And Explicit interface ----------------------");
            Class1 objClass1 = new Class1();
            objClass1.Display();
            //Call Implicit interface method
            objClass1.interface1_method();
            //Call Explicit interface method
            Iinterface_1 obj_1 = new Class1();
            obj_1.interface1_method();
            Console.WriteLine("-----");

            Class1 objClass2 = new Class1();
            objClass2.Display();

            Console.WriteLine("------------------- Interface Inheritace ---------------------------");
            Class3 objClass3 = new Class3();
            objClass3.Display();

            // Call Implicit interface method
            objClass3.interface2_method();
            objClass3.interface3_method();

            Console.WriteLine("----");
            Iinterface_2 obj_2 = new Class3();
            obj_2.interface2_method();
            Iinterface_3 obj_3 = new Class3();
            obj_3.interface3_method();
            Console.ReadLine();


            Console.WriteLine("------------------ Concept of Indexer ---------------------------");
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);



        }
    }
}

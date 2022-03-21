using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // first reference to singleton
            SingletonClass singleton = SingletonClass.Instance;
            singleton.Count = 1;
            singleton.Name = "Gabriela";
             
            Console.WriteLine("First reference : \n Variable named count is : " + singleton.Count + "\n Variable named name is : " + singleton.Name);

            // second reference to singleton
            SingletonClass singleton2 = SingletonClass.Instance;
            Console.WriteLine("\n Second reference : \n Variable named count is : " + singleton2.Count + "\n Variable named name is : " + singleton2.Name);

            // making changes inside the second references
            singleton2.Name = "Caroline";

            // checking the first referenace 
            Console.WriteLine("\n First reference : \n Variable named count is : " + singleton.Count + "\n Variable named name is : " + singleton.Name);

            // checking the second referenace 
            Console.WriteLine("\nSecond reference : \n Variable named count is : " + singleton2.Count + "\n Variable named name is : " + singleton2.Name);

            // wait until the user pushes any button
            Console.ReadKey();



            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            // wait until the user pushes any button
            Console.ReadKey();

            Thread process1 = new Thread( () =>
            {
                ThreadSafeSingletonM("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                ThreadSafeSingletonM("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            // wait until the user pushes any button
            Console.ReadKey();
        }

        public static void ThreadSafeSingletonM(string value)
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}

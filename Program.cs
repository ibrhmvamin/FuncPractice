using System;

namespace FuncPractice
{
    public delegate void Func(string str);   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");

            var str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
                // params sadece sizin ora vereceyiniz parametrlerdi	

                //burda funcDell-e functionlari verirsiniz

            Run run = new Run();
            run.runFunc(funcDell, str); 
            //cagiranda Space() ve Reverse() functionlari ise dusmelidir

        }
    }
}
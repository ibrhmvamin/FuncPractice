namespace FuncPractice
{
    class MyClass
    {
        private string str;

        public MyClass(string str)
        {
            this.str = str;
        }
        public void Space(string str)
        {
            string str_2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                str_2 += str[i];
                if (str.Length - 1 == i) break;
                str_2 += "_";
            }
            str = str_2;
            Console.WriteLine(str);
        }

        public void Reverse(string str)
        {
            string str_2 = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str_2 += str[i];
            }
            str = str_2;
            Console.WriteLine(str);
        }
    }
}

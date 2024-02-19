using System;

namespace Tiger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Tiger World!");
            //Console.WriteLine("Hello Tiger World!");
            //Console.WriteLine("Hello Tiger World!");
            //Console.WriteLine("Hello Tiger World!");
            //Console.WriteLine("Hello Tiger World!");
            //Console.WriteLine("Hello Tiger World!");

            //Console.Write(true);
            //Console.ReadLine();
            //Console.Write(true);

            //variable example
            //Console.WriteLine("Once there was a man named George");
            //Console.WriteLine("He was 70 years old");
            //Console.WriteLine("He liked his name George");
            //Console.WriteLine("But he don't like being 70");

            //string characterName = "John";
            //int age = 30;

            //Console.WriteLine("Once there was a man named "+ characterName);
            //Console.WriteLine("He was "+age+" years old");
            //Console.WriteLine("He liked his name "+ characterName);
            //Console.WriteLine("But he don't like being "+age);

            string characterName = "Baklolininihndssda";
            int age = 20;
            char grade = 'A';
            float a = 0.5f;
            double  val = 3.21;
            bool isMale = true;

            Console.WriteLine(age +" "+grade + " " + a + " " + val + " " +isMale);


            Console.WriteLine(characterName.Length);
            Console.WriteLine(characterName.ToUpper());

            Console.WriteLine(characterName.ToLower());

            Console.WriteLine(characterName.Contains("ohi"));

            Console.WriteLine(characterName.IndexOf("n"));

            Console.WriteLine(characterName[0]);

            Console.WriteLine(characterName.Substring(2,6));

            Console.WriteLine("Once there was a man named " + characterName);
            Console.WriteLine("He was " + age + " years old");
            Console.WriteLine("He liked his name " + characterName);
            Console.WriteLine("But he don't like being " + age);
            Console.Write("But he don't like being " + age);
            Console.Write("But he don't like being " + age);

            Console.WriteLine("\r\n");



            Console.WriteLine(5 / 2); //check the output.. will get integer


            Console.WriteLine(5 / 2.0); // decimal


            int num = 6;
            num++;
            Console.WriteLine(num);

        }
    }
}

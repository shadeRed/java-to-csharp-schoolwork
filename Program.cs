using System;
using System.Collections;

namespace Java_to_CSharp_Exercise
{
    class Program
    {
        private static FileOutput outFile;
        private static FileInput inFile;
        static void Main(string[] args)
        {
            outFile = new FileOutput("animals.txt");

            /*ArrayList zoo = new ArrayList();

            zoo.Add(new Dog(true, "bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            foreach (ITalkable thing in zoo) { PrintOut(thing); }*/

            bool running = true;
            while (running) {
                ITalkable animal = ZooManager.PromptAnimal();
                if (animal != null) {
                    ZooManager.Add(animal);
                    PrintOut(animal);
                }

                Console.Write("\nAdd another animal? (y/n) > ");
                if (Console.ReadLine() != "y") { running = false; }
            }

            outFile.FileClose();

            inFile = new FileInput("animals.txt");
            inFile.FileRead();
            inFile.FileClose();

            FileInput indata = new FileInput("animals.txt");
            indata.FileRead();
            indata.FileClose();
        }

        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine($"{p.GetName()} says={p.Talk()}");
            outFile.FileWrite($"{p.GetName()} | {p.Talk()}");
        }
    }
}

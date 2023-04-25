using System;
using System.Collections.Generic;
using System.Reflection;

namespace Java_to_CSharp_Exercise
{
    class ZooManager
    {
        private static List<ITalkable> _zoo = new List<ITalkable>();

        public static ITalkable Add(ITalkable animal) {
            _zoo.Add(animal);
            return animal;
        }
        public static bool Remove(ITalkable animal) { return _zoo.Remove(animal); }
        public static bool Remove(int index) {
            try {
                _zoo.RemoveAt(index);
                return true;
            }
            catch { return false; }
        }

        // super "sophisticated" mechanism to add animals using string values and reflection
        public static ITalkable PromptAnimal() {
            Console.Write("Enter the name of the animal you want to add to the zoo > ");
            string animalName = Console.ReadLine();
            Type type = Type.GetType($"Java_to_CSharp_Exercise.{animalName}", false, true);

            if (type != null && type.GetInterface("ITalkable") != null) {
                ConstructorInfo constructor = type.GetConstructors()[0];
                ParameterInfo[] parameters = constructor.GetParameters();

                object[] paramArray = new object[parameters.Length];

                for (int p = 0; p < parameters.Length; p++) {
                    ParameterInfo param = parameters[p];

                    Console.Write($"Provide the value for '{param.Name}' > ");
                    string input = Console.ReadLine();

                    if (param.ParameterType.Name == "Int32") { paramArray[p] = int.Parse(input); }
                    else { paramArray[p] = input; }
                }

                return (ITalkable)constructor.Invoke(paramArray);
            }

            else {
                Console.WriteLine($"'{animalName}' is not an animal type!");
                return null;
            }
        }

        public static void PromptAddAnimal() {
            ITalkable animal = PromptAnimal();
            if (animal != null) { Add(animal); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;
            
            

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
                
            }

            public string Name
            {
                get { return name; }

            }

            public string Gift
            {
                get { return gift; }
            }

            
        }

        static void Main(string[] args)
        {
            //Anna wants new earrings
            //Elsa wants a box of chocolates
            //Anakin Skywalker wants to join the Dark Side 
            //Kristoff wants a new sleigh 
            //Sven wants carrots 
            // Olaf wants a sunscreen 

            List<SecretSanta> mySecretSanta = new List<SecretSanta>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newFrozen = new SecretSanta(tempArray[0], tempArray[1]);
                mySecretSanta.Add(newFrozen);
            }

            foreach (SecretSanta giftFromList in mySecretSanta)
            {
                Console.WriteLine($"{giftFromList.Name} wants {giftFromList.Gift}.");

            }


        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\37253\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

    }
}

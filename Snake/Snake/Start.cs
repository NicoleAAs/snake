using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Snake
{
    class Start
    {
        string name;
        public void PrintRecords() {
            try
            {
                string path = @"C:\Users\user\source\repos\snake\Snake\Snake\resources\records.txt";
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    //List<string> recordsList = new List<string>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        //recordsList.Add(line);
                    }
                    /*for (int x = 0; x < recordsList.Count; i++) {

                    }*/
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public void TypeName() {
            while (true)
            {
                try
                {
                    Console.WriteLine("Type your Name");
                    string name = Console.ReadLine();
                    if (Regex.IsMatch(name, @"^[a-zA-Z]+$") && name.Length >= 3) break;
                    else throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Type at least 3 characters!!!");
                }
            }
        }
    }
}

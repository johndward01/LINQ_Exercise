using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            //****Collab with classmates***** 

            //TODO: Look up new data structure  (each person in your group should try to use a different type) 
            //TODO: Instantiate an object of that type
            //TODO: Insert at least 10 entries into data structure (object)          
            //TODO: Put yourselves in the shoes of a teacher, create a LINQ situation/question and use one of the LINQ methods below to solve your own question
            //Example: Using the dictionary below, filter out all of the entries with vowels
            //Hint: Try creating queries (questions) that pertain to the data structure of your choosing
            //BONUS: Try using a LINQ method not in the list below for extra practice! 


            //Example data structure: 
            var dictionary = new Dictionary<int, string>
            {
                { 1, "abc" },
                { 2, "def" },
                { 3, "ghi" },
                { 4, "jkl" },
                { 5, "mno" },
                { 6, "pqr" },
                { 7, "stu" },
                { 8, "vwx" },
                { 9, "yz_" },
                { 10, "111" }
            };
            // TODO: Using the dictionary above remove the entries that contains numbers or an underscore and print the contents to the console
            dictionary.Where(kvp => !kvp.Value.Contains("1")
                                 && !kvp.Value.Contains("2") 
                                 && !kvp.Value.Contains("3") 
                                 && !kvp.Value.Contains("4") 
                                 && !kvp.Value.Contains("5") 
                                 && !kvp.Value.Contains("6") 
                                 && !kvp.Value.Contains("7") 
                                 && !kvp.Value.Contains("8") 
                                 && !kvp.Value.Contains("9") 
                                 && !kvp.Value.Contains("0") 
                                 && !kvp.Value.Contains("_"))
                .ToList()
                .ForEach(x => Console.WriteLine($"Key: {x.Key}\tValue: {x.Value}"));
            

            




            #region Linq Methods to choose from           

            //*BONUS*: Use any of the LINQ methods not in list for an extra challenge. Do your own research!          

            //Where() - Filters a sequence of values based on a predicate.
            //Select() - Projects each element of a sequence into a new form.
            //OrderBy() - Sorts the elements of a sequence in ascending order.
            //OrderByDescending() - Sorts the elements of a sequence in descending order.
            //Sum() - Sums all elements
            //Average() - Calculates average of all elements
            //Count() - Returns the number of elements in a sequence.
            //Min() - Finds min value in list / sequence
            //Max() - Finds max value in list / sequence
            //Take() - Returns a specified number of contiguous elements from the start of a sequence.
            //Append() - Appends a value to the end of the sequence.
            //ThenBy() - Performs a subsequent ordering of the elements in a sequence in ascending order.

            #endregion
        }
    }
}

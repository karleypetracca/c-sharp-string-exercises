// // Uncomment exercises below to run! // //

using System;
using System.Text;
using System.Collections.Generic;

namespace StringExercises
{
  class Program
  {
    /*
    Write a program and ask the user to enter a few numbers separated by a
    hyphen. Work out if the numbers are consecutive. For example, if the input
    is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
    otherwise, display "Not Consecutive".
    */
    static void Main(string[] args)
    {
      Console.Write("Please enter a few numbers separated by a hyphen: ");
      var input = Console.ReadLine();

      var splitInput = Array.ConvertAll(input.Split("-"), int.Parse);
      Array.Sort(splitInput);

      var isConsecutiveStr = isConsecutive(splitInput);
      Console.WriteLine(isConsecutiveStr);
    }

    public static string isConsecutive(int[] splitInput)
    {
      var consecutiveFlag = true;
      for (var i = 0; i < splitInput.Length - 1; i++)
      {
        if (splitInput[i] + 1 != splitInput[i + 1])
        {
          consecutiveFlag = false;
        }
      }
      return consecutiveFlag ? "Consecutive" : "Not Consecutive";
    }



    // /*
    // Write a program and ask the user to enter a few numbers separated by a
    // hyphen. If the user simply presses Enter, without supplying an input, exit
    // immediately; otherwise, check to see if there are duplicates. If so, display
    // "Duplicate" on the console.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter a few numbers separated by a hyphen: ");
    //   var input = Console.ReadLine();

    //   if (!String.IsNullOrWhiteSpace(input))
    //   {
    //     Console.WriteLine(checkDuplicates(input));
    //   }
    // }

    // public static string checkDuplicates(string input)
    // {
    //   Console.WriteLine("Checking to see if any duplicates...");
    //   var unique = new List<string>();
    //   foreach (string number in input.Split("-"))
    //   {
    //     if (unique.Contains(number))
    //     {
    //       return "Duplicate Found";
    //     }
    //     else
    //     {
    //       unique.Add(number);
    //     }
    //   }
    //   return "None Found";
    // }



    // /*
    // Write a program and ask the user to enter a time value in the 24-hour time
    // format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the
    // time is valid, display "Ok"; otherwise, display "Invalid Time". If the user
    // doesn't provide any values, consider it as invalid time.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter a time value using 24 hr format (e.g. 19:00): ");
    //   var input = Console.ReadLine();
    //   if (!String.IsNullOrWhiteSpace(input))
    //   {
    //     Console.WriteLine(isValidTime(input));
    //   }
    // }

    // public static string isValidTime(string input)
    // {
    //   try
    //   {
    //     var dateTime = DateTime.Parse(input);
    //     return "Ok";
    //   }
    //   catch
    //   {
    //     return "Invalid";
    //   }
    // }



    // /*
    // Write a program and ask the user to enter a few words separated by a space.
    // Use the words to create a variable name with PascalCase. For example, if the
    // user types: "number of students", display "NumberOfStudents". Make sure that
    // the program is not dependent on the input. So, if the user types "NUMBER OF
    // STUDENTS", the program should still display "NumberOfStudents".
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter a few words separated by a space: ");
    //   var input = Console.ReadLine();
    //   if (!String.IsNullOrWhiteSpace(input))
    //   {
    //     Console.WriteLine(createVariableName(input));
    //   }
    // }

    // public static string createVariableName(string input)
    // {
    //   var TitleCase = new StringBuilder();
    //   foreach (var word in input.Split(" "))
    //   {
    //     TitleCase.Append(Char.ToUpper(word[0]) + word.ToLower().Substring(1));
    //   }
    //   return $"Variable name is: {TitleCase}";
    // }



    // /*
    // Write a program and ask the user to enter an English word. Count the number
    // of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate",
    // the program should display 6 on the console.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter an English word: ");
    //   var input = Console.ReadLine();
    //   Console.WriteLine(countVowels(input));
    // }

    // public static string countVowels(string input)
    // {
    //   var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
    //   var count = 0;
    //   foreach (var character in input.ToLower())
    //   {
    //     if (vowels.Contains(character))
    //     {
    //       count++;
    //     }
    //   }
    //   return $"There are {count} vowels in that word.";
    // }
  }
}

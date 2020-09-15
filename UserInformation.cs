using System;

public static class UserInformation {

  public static string UserOperatorChoice() {
    string output = "";
    bool validNumber = false;

    Console.WriteLine();
    Console.WriteLine("What would you like to do: ");
    Console.WriteLine();
    Console.WriteLine(@"    1. Add
    2. Subtract
    3. Multiply
    4. Divide
    ");

    Console.Write("Please select an option by entering a number: ");
    string userChoiceString = Console.ReadLine();

    while (validNumber == false) {

      if (userChoiceString == "1") {
        validNumber = true;
        output = "add";
      }
      else if (userChoiceString == "2") {
        validNumber = true;
        output = "subtract";
      }
      else if (userChoiceString == "3") {
        validNumber = true;
        output = "multiply";
      }
      else if (userChoiceString == "4") {
        validNumber = true;
        output = "divide";
      }
      else {
        Console.Clear();
        
        Console.WriteLine("You have entered an invalid number. Try again...");
        
        Console.WriteLine();
        Console.WriteLine("What would you like to do: ");
        Console.WriteLine();
        Console.WriteLine(@"    1. Add
    2. Subtract
    3. Multiply
    4. Divide
        ");

        Console.Write("Please select an option by entering a number: ");
        userChoiceString = Console.ReadLine();
      }
    }

    return output;

  }

  public static double GetUserNumber(string message) {
    Console.Clear();

    Console.Write(message);
    string firstNumberString = Console.ReadLine();

    bool isValidNumber = double.TryParse(firstNumberString, out double output);

    while (isValidNumber != true) {
      Console.Clear();
      
      Console.WriteLine("You have entered and invalid number. Try Again...");

      Console.Write(message);
      firstNumberString = Console.ReadLine();

      isValidNumber = double.TryParse(firstNumberString, out output);
    }

    return output;
  }

  
}
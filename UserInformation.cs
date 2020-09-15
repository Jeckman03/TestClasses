using System;

public static class UserInformation {

  public static int UserOperatorChoice() {
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

    bool isValidNumber = int.TryParse(userChoiceString, out int output);

    while (isValidNumber != true) {
      Console.Clear();
      Console.WriteLine("You have entered and invalid number. Try Again...");

      Console.WriteLine();
      Console.WriteLine("What would you like to do: ");
      Console.WriteLine();
      Console.WriteLine(@"      1. Add
      2. Subtract
      3. Multiply
      4. Divide
      ");
      Console.Write("Please select an option by entering a number: ");
      userChoiceString = Console.ReadLine();
  
      isValidNumber = int.TryParse(userChoiceString, out output);
    }

    return output;

  }

  public static double GetFirstNumber() {
    Console.Clear();

    Console.Write("Please enter your first number: ");
    string firstNumberString = Console.ReadLine();

    bool isValidNumber = double.TryParse(firstNumberString, out double output);

    while (isValidNumber != true) {
      Console.Clear();
      
      Console.WriteLine("You have entered and invalid number. Try Again...");

      Console.Write("Please enter your first number: ");
      firstNumberString = Console.ReadLine();

      isValidNumber = double.TryParse(firstNumberString, out output);
    }

    return output;
  }
}
using System;

public class GetInformation {

  public static string GetUserFirstName() {
    Console.Write("What is your first name: ");
    string output = Console.ReadLine();

    return output;
  }

  public static int GetUserAge() {
    Console.Write("What is your age: ");
    string userAgeString = Console.ReadLine();

    bool isValidInt = int.TryParse(userAgeString, out int output);

    while (isValidInt != true) {
      Console.WriteLine("Sorry, that is not a number.");

      Console.Write("What is your age: ");
      userAgeString = Console.ReadLine();

      isValidInt = int.TryParse(userAgeString, out output);
    }

    return output;
  }
	
}
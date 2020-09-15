using System;

class MainClass {
  public static void Main (string[] args) {
    
    UserMessages.Welcome("Welcome to my test page!");

    string firstName = GetInformation.GetUserFirstName();

    UserMessages.UserMessage($"I hope you are doing well today { firstName }");

    int userAge = GetInformation.GetUserAge();

    Console.ReadLine();
  }
}
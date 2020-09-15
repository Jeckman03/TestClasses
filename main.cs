using System;

class MainClass {
  public static void Main (string[] args) {
    
    //------create an application that handles calculations------

    //welcome the user to the application
    UserMessages.MessageToUser("Welcome to the Simple Console Calculator!");

    //ask the user if they would like to add, subtract, multiply, or divide
    UserInformation.UserOperatorChoice();

    //have the user enter the first number
    double firstNumber = UserInformation.GetFirstNumber();

    //have the user enter the second number

    //return the result of the calculations

    //ask the user if they want to calculate something else



    Console.ReadLine();
  }
}
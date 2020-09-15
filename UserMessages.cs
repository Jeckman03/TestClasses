using System;

public static class UserMessages {

  public static void MessageToUser(string message) {
    Console.Clear();
    Console.WriteLine(message.ToUpper());
  }
}
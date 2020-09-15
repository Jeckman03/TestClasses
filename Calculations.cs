using System;

public static class Calculations {

  public static double CalculateTwoNumbers(double num1, double num2, string userOperator) {
    double output = 0;
    if (userOperator == "add") {
      output = num1 + num2;
    }
    else if (userOperator == "subtract") {
      output = num1 - num2;
    }
    else if (userOperator == "multiply") {
      output = num1 * num2;
    }
    else if (userOperator == "divide") {
      output = num1 / num2;
    }

    return output;
  }
  
}
using System;

class Program {
  public static void Main (string[] args) {
    string firstName = "Harvie";
    string lastName = "Bernardo";
    int age = 19;
    string address = "Blk. 4 Lt. 28-29 Grandtown Village Sumapang Matanda";
    Console.WriteLine ($"Hello World {firstName} {lastName} Age: {age} years old. Address: {address}");
    Console.WriteLine ("Hello World" + firstName + " " + lastName + " " + age + " " + address);
  }
}
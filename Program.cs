using System;

/*
 * COMP2084 - Server Side Scripting ASP.NET
 * Assignment 1
 * Group Members: Yuvraj Jindal (200555466)
 *                Ashish (200531084)
 *                Kartik (200555473)
 */
class Program
{
    //Main Method
    static void Main(string[] args)
    {
        // Asking the user to enter their age
        Console.Write("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Ask the user to insert the patient's First Name
        Console.Write("Please enter your First Name: ");
        string firstName = Console.ReadLine();

        // Ask the user to insert the patient's Last Name
        Console.Write("Please enter your Last Name: ");
        string lastName = Console.ReadLine();

        // Ask the user to insert the patient's Weight (in Kgs)
        Console.Write("Please enter your Weight (in KGs): ");
        double weight = double.Parse(Console.ReadLine());

        // Ask the user to insert the patient's Height (in CMs)
        Console.Write("Please enter your Height (in CMs): ");
        double height = double.Parse(Console.ReadLine());

        // Creating an instance of the Patient class
        Patient patient = new Patient(firstName, lastName, weight, height);


        // Asking the user to enter the blood pressure values
        Console.WriteLine("Please Enter patient's Blood Pressure values:");

        // Ask the user to insert the patient's Systolic Blood Pressure
        Console.Write("Systolic (mm Hg): ");
        int systolic = int.Parse(Console.ReadLine());

        // Ask the user to insert the patient's Diastolic Blood Pressure
        Console.Write("Diastolic (mm Hg): ");
        int diastolic = int.Parse(Console.ReadLine());

        // Calling the method for printing the patient information
        patient.OutputPatientInformation(systolic, diastolic);
    }
}

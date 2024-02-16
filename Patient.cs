using System;

public class Patient
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; } // in KGs
    public double Height { get; set; } // in Centimetres

    // Constructors
    public Patient(string firstName, string lastName, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    // Method to calculate blood pressure
    public string CalculateBloodPressure(int systolic, int diastolic)
    {

        //Given below are the if elseif statements that outputs the BP status normal, elevated according to
        //Systolic and Diastolic Blood Pressure Values
        if (systolic < 90 || systolic > 250 || diastolic < 60 || diastolic > 140)
        {
            return "Warning: Blood pressure values out of range. Please consult your doctor.";
        }
        else if (systolic < 120 && diastolic < 80)
        {
            return "Normal";
        }
        else if (systolic < 130 && diastolic < 80)
        {
            return "Elevated";
        }
        else if (systolic < 140 || diastolic < 90)
        {
            return "High Blood Pressure (Hypertension) Stage 1";
        }
        else if (systolic >= 140 && systolic <= 180 || diastolic >= 90 && diastolic <= 120)
        {
            return "High Blood Pressure (Hypertension) Stage 2";
        }
        else
        {
            return "Hypertensive Crisis: Consult your doctor immediately";
        }
    }

    // Method to calculate BMI
    public double CalculateBodyMassIndex()
    {
        //BMI is calculated by dividing the weight in kilograms by the square of height in metres
        double heightInMeters = Height / 100.0; // Convert height from centimeters to meters
        return Weight / (heightInMeters * heightInMeters);
    }

    // Method to output patient information
    public void OutputPatientInformation(int systolic, int diastolic)
    {
        Console.WriteLine("\n!!!Hello!!!");
        Console.WriteLine("Here is the Patient's Information:");
        Console.WriteLine($"Full Name: {FirstName} {LastName}"); //outputs the Full name i.e., firts name and last name separated by a space
        Console.WriteLine($"Weight: {Weight} KGs"); //outputs the weight
        Console.WriteLine($"Height: {Height} CMs");  //outputs the height
        Console.WriteLine($"Blood Pressure: {CalculateBloodPressure(systolic, diastolic)}");  //outputs the BP status like normal, hypertension
        double bmi = CalculateBodyMassIndex(); //calls the method for calculating body mass index
        Console.WriteLine($"Body Mass Index: {bmi}"); //outputs the BMI value
        Console.WriteLine($"BMI Status: {GetBodyMassIndexStatus(bmi)}"); //outputs the BMI status like Normal, Underweight, Overweight
    }

    // method to get BMI status depending on the calculated value
    //this method also return the rislk of developing health problems according to bmi value calculated
    private string GetBodyMassIndexStatus(double bmi)
    {
        //If body mass index is greater than or equal to 40 then the person is in obese class III
        if (bmi >= 40.0)
        {
            return "Obese Class III \nRisk of Developing Health Problems: Extremely High";
        }

        //If body mass index is greater than or equal to 35.0 but less than or equal to 39.9 then the person is in obese class II
        else if (bmi >= 35.0 && bmi <= 39.9)
        {
            return "Obese Class II \nRisk of Developing Health Problems: Very High";
        }

        //If body mass index is greater than or equal to 30.0 but less than or equal to 34.9 then the person is in obese class I
        else if (bmi >= 30.0 && bmi <= 34.9)
        {
            return "Obese Class I \nRisk of Developing Health Problems: High";
        }

        //If body mass index is greater than or equal to 25.0 but less than or equal to 29.9 then the person is Overweight
        else if (bmi >= 25.0 && bmi <= 29.9)
        {
            return "Overweight \nRisk of Developing Health Problems: Increased";
        }

        //If body mass index is greater than or equal to 18.5 but less than or equal to 24.9 then the person is in Normal Weight
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            return "Normal Weight \nRisk of Developing Health Problems: Least";
        }

        //If body mass index is less than 18.5 then the person is underweight
        else
        {
            return "Underweight \nRisk of Developing Health Problems: Increased";
        }
    }
}

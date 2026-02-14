/*
Question 44
Factory Robot Hazard Analyzer

Description
Develop a Factory Robot Hazard Analyzer system that evaluates the hazard risk score of a factory robot based on arm precision, worker density, and machinery state. The system must validate all inputs, calculate the hazard risk score, and handle invalid scenarios using a custom exception.


Functionalities:
In the class RobotHazardAuditor, implement the specified method:

Method
public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)

Functionality
This method calculates and returns the hazard risk score.
The armPrecision must be in the range of 0.0 to 1.0, if it is not in the range then throw a user-defined exception called RobotSafetyException with the message: "Error:  Arm precision must be 0.0-1.0". 
The workerDensity must be in the range of 1 to 20, if it is not in the range then throw a user-defined exception called RobotSafetyException with the message: "Error: Worker density must be 1-20". 
The machineryState must be "Worn", "Faulty", or "Critical", if not then throw a user-defined exception called RobotSafetyExceptionwith the message: "Error: Unsupported machinery state". 


If armPrecision, workerDensity and machineryState are valid then calculate hazard risk using the formula given below.
The machineryState is case-sensitive.

Machine Risk Factor for machinery state are,

Worn→ 1.3
Faulty→ 2.0
Critical→ 3.0
Hazard Risk Calculation Formula:

Hazard Risk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor)




Note:

The Exception object itself should display the message.
To do this, A class RobotSafetyException that inherits from the Exception class.
In the Program class, write the Main method and call the CalculateHazardRisk method and print "Robot Hazard Risk Score: <risk>".
If there is any exception thrown, use a catch block to handle the exception that is returned by the CalculateHazardRisk method. In the catch block, display the exception message.
Refer to the sample input and output.

Cautions:

Keep the method public.
Please read the method rules clearly.
Do not use Environment.Exit() to terminate the program.
Do not change the given code template.

Sample Input 1:
Enter Arm Precision (0.0 - 1.0):
0.5
Enter Worker Density (1 - 20):
10
Enter Machinery State (Worn/Faulty/Critical):
Critical
Sample output 1:
Robot Hazard Risk Score: 37.5

Sample Input 2:
Enter Arm Precision (0.0 - 1.0):
1.3
Enter Worker Density (1 - 20):
4
Enter Machinery State (Worn/Faulty/Critical):
Worn
Sample output 2:
Error: Arm precision must be 0.0-1.0

Sample Input 3:
Enter Arm Precision (0.0 - 1.0):
0.7
Enter Worker Density (1 - 20):
26
Enter Machinery State (Worn/Faulty/Critical):
Critical
Sample output 3:
Error: Worker density must be 1-20

Sample Input 4:
Enter Arm Precision (0.0 - 1.0):
0.3
Enter Worker Density (1 - 20):
14
Enter Machinery State (Worn/Faulty/Critical):
Optimal


Sample output 4:
Error: Unsupported machinery state
*/
public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {
    }
}

// Auditor Class
public class RobotHazardAuditor
{
    // Method to calculate hazard risk
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        // Validate arm precision
        if (armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
        }

        // Validate worker density
        if (workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        // Determine machine risk factor
        double machineRiskFactor;

        if (machineryState == "Worn")
            machineRiskFactor = 1.3;
        else if (machineryState == "Faulty")
            machineRiskFactor = 2.0;
        else if (machineryState == "Critical")
            machineRiskFactor = 3.0;
        else
            throw new RobotSafetyException("Error: Unsupported machinery state");

        // Hazard risk calculation
        double hazardRisk =
            ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);

        return hazardRisk;
    }
}

// Program Class
public class Question_Number_44
{
    public static void main()
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState = Console.ReadLine();

            RobotHazardAuditor auditor = new RobotHazardAuditor();
            double risk = auditor.CalculateHazardRisk(
                armPrecision, workerDensity, machineryState);

            Console.WriteLine("Robot Hazard Risk Score: " + risk);
        }
        catch (RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

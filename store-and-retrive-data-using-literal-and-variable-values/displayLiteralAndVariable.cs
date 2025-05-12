public class DisplayLiteralAndVariable{
    public void challengeDisplayLiteral()
    {
        // Store the following values in variables:
        // - Bob
        // - 3
        // - 34.4
        // These variables should be given names that reflect their purpose.
        // Make sure you select the correct data type for each of the variables based on the type of data it will hold.
        // Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.

        // Answer
        string firstName = "Bob";
        int number = 3;
        decimal decimalNumber = 34.4m;

        Console.WriteLine(firstName);
        Console.WriteLine(number);
        Console.WriteLine(decimalNumber);

        // Write code in the .NET Editor to display the following message:
        // "Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius."

        // Answer
        Console.WriteLine("Hello, " + firstName + "! You have " + number + " messages in your inbox. The temperature is " + decimalNumber + " celcius");
    }
}
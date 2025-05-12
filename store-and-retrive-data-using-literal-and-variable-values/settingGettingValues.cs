public class SettingGettingValues{
    public void mySettingGettingValues()
    {
        // Create your  first variable
        // string firstName;
        // firstName = "Bob";
        // To declare a variable, you enter the data type you want to use followed by a name for the variable. To assign a value to a variable, you use the assignment operator, which is a single equals character =.

        // Improperly assign a value to a variable
        // It's important to notice that assignment happens from right to left. In other words, the C# compiler must first understand the value on the right side of the assignment operator, then it can perform the assignment to the variable on the left side of the assignment operator. If you reverse the order, you'll confuse the C# compiler.
        // "Bob" = firstName;
        // output -> error CS0131: The left-hand side of an assignment must be a variable, property or indexer
        // The error message hints at what the C# compiler tries to do behind the scenes. It tried to "implicitly convert" the string "Bob" to be an int value; however, that is impossible. Even so, C# tried to do the conversion but fails since there's no numeric equivalent for the word "Bob".
        // You'll learn more about implicit and explicit type conversion later. For now, just remember that a variable can only hold values matching its specified data type.

        // Retrieve a value you stored in the variable
        // To retrieve a value from a variable, you just use the name of the variable. This example will set a variable's value, then retrieve that value and display it in the console.
        string firstName2;
        firstName2 = "Bob";
        Console.WriteLine(firstName2);
        // Retrieving a value from a variable is also referred to as "getting the variable", or simply, a "get" operation.

        // Reassign the value of a variable
        string firstName3;
        firstName3 = "Bob";
        Console.WriteLine(firstName3);
        firstName3 = "Udin";
        Console.WriteLine(firstName3);
        firstName3 = "Ucup";
        Console.WriteLine(firstName3);
        firstName3 = "Liem";
        Console.WriteLine(firstName3);

        // Initialize the variable
        // You must set a variable to a value before you can get the value from the variable. Otherwise, you'll see an error.
        // string firstName4;
        // Console.WriteLine(firstName4);
        // Output ->  error CS0165: Use of unassigned local variable 'firstName4'
        // To avoid the possibility of an unassigned local variable, it is recommended that you set the value as soon as possible after you declare it.
        // In fact, you can perform both the declaration and setting the value of the variable in one line of code. This technique is called initializing the variable.
        string firstName5 = "Bob";
        Console.WriteLine(firstName5);
    }
}
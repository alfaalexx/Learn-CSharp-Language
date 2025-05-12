public class ImplicitlyVariables{
    public void implicitlyVariables()
    {
        // What are implicitly typed local variables?
        // An implicitly typed local variable is created by using the var keyword followed by a variable initialization. For example:
        // var message = "Hello, World!";
        // In this example, a string variable was created using the var keyword instead of the string keyword.
        // The var keyword tells the C# compiler that the data type is implied by the assigned value. After the type is implied, the variable acts the same as if the actual data type had been used to declare it. The var keyword is used to save on keystrokes when types are lengthy or when the type is obvious from the context.
        // Because the variable message is immediately set to the string value "Hello World!", the C# compiler understands the intent and treats every instance of message as an instance of type string.
        // In fact, the message variable is typed to be a string and can never be changed. For example, consider the following code:
        // message = 10.703m;
        // Output -> error CS0029: Cannot implicitly convert type 'decimal' to 'string'

        // Variables using the var keyword must be initialized
        // It's important to understand that the var keyword is dependent on the value you use to initialize the variable. If you try to use the var keyword without initializing the variable, you'll receive an error when you attempt to compile your code.
        // var message;
        // Output -> error CS0818: Implicitly-typed variables must be initialized

        // Why use the var keyword?
        //The var keyword has been widely adopted in the C# community. It's likely that if you look at a code example in a book or online, you'll see the var keyword used instead of the actual data type name, so it's important to understand its usage.
        // The var keyword has an important use in C#. Many times, the type of a variable is obvious from its initialization. In those cases, it's simpler to use the var keyword. The var keyword can also be useful when planning the code for an application. When you begin developing code for a task, you may not immediately know what data type to use. Using var can help you develop your solution more dynamically.
        // As you get started, it is recommended that you continue to use the actual data type name when you declare variables until you become more comfortable working with code. Using the data type when you declare variables will help you be purposeful as you write your code.
    }
}
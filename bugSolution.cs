public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod() {
        // Accessing the property after initialization 
        int value = MyProperty * 2;
        Console.WriteLine(value); // Add this line to see the output after the fix
    }

    public static void Main(string[] args) {
        MyClass obj = new MyClass();
        obj.MyMethod();
    }
}
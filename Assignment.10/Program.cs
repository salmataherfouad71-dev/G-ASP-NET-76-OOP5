namespace Assignment._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            /*
             a)If it a value type is copies the value,but if it reference type it copies 
               the reference (address).
             b)No,If it a value type it just change the value of the object.If it is a
               reference type it just starts pointing to the assigned object.
             c)Object Copying:It creates a new independent object(shallow-deap) .
               Reference Copying:It just copies the address (assignment)*/
            #endregion
            #region Question02
            /*
             a)Shallow Copy:It creates a new object that copies the values of value types
               and the address of the reference types.
             b)Deap Copy:It creates a completely new object that copies all the values of the data.
             c)It just copy the address so the changes in the new object will affect the original 
               variable except for the string (because it is immutable).
             d)It copy its value so the changes in the new object will never affect the original variable.
             e)Deap copy is safer when you want to edit the data and you don't want those
               changes to accidentally break or alter the original object.*/
            #endregion
            #region Question03
            /*
             a)-A static field belongs to the class not to the object,so no need to create
               an object in order to access it,and we access it using the class name.
               -A instance field belongs to the object.Its value differ from one object to 
               another, and we access it using the object name.
             b)A static method is a method that belongs to the class and its behavior does not 
               change from one object to another.We call it using the class name.
               No.
             c)A static constructor is a parameterless constructor.We use it to initialize
               fields.It starts executing automatically with the first use of the class.
             d)A static class is a class that every member in it is static.No you cannot 
               create an object from a static class.*/
            #endregion
            #region Question04
            /*
             a)Extension Method:It is a method that allow you to add new methods to an existing data type
                without modifying the original source code.
             b)this.
             c)In a static class.
             d)No.*/
            #endregion
            #region Question05
            /*
             a)It a class that can be split across two or more files.
             b)This makes the code easy to read and maintain.Also Partial Class is used
              when there is more than one developer are working with the same project. 
             c)Partial Methods are methods that can be declared in one partial class and 
               implemented in the other part.
             d)The c# compiler remove it so there is no error.*/
            #endregion
            #endregion
        }
    }
}

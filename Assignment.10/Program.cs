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
            #endregion
        }
    }
}

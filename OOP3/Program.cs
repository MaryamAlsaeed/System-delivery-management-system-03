namespace OOP3
{
    internal class Program
    {
        #region Theoretical Questions
        //-----------------Q1:-----------------
        //
        // a) What is the difference between Method Overloading and Method Overriding?
        // Method oveloading:
        // means same method with: Different number of parameters - Different datatypes - Arrangement of params differ.
        // called by static binding >> refers to refernce >> early binding
        //
        // Method overriding:
        // Method overriding is related to inheritance while child can implement its own function inherited from the parent.
        // it has the same name method and number of params.
        // called by dynamic binding >> refers to object it self >> late binding
        //
        // b) What is the difference between Static Binding and Dynamic Binding? 
        // Static binding:
        // The method is executed at compile time.
        // It refers to the reference (variable)
        // Also called by (Early binding)
        //
        // Dynamic binding:
        // THe method is executed at runtime
        // It refers to the object it self
        // Also called by (Late binding)
        //
        //-----------------Q2:-----------------
        //
        // a) What is the purpose of the sealed keyword when applied to a class?
        // Sealed keyword prevents any other class to inherit from any other class.
        //
        // b) What is the difference between a sealed class and a sealed method? 
        // Sealed class: 
        // It is applied to the entire class.
        // No class can inherit from it.
        //
        // Sealed method: 
        // It is applied to a single method.
        // Derrived classes cannot override this method.
        //
        // c) Can a sealed method be overridden? Why? 
        // no, because sealed method doesn't allow to be overriden.
        // => the keyword (sealed) acts as locked method.
        //
        #endregion

        static void Main(string[] args)
        {
            
        }
    }
}

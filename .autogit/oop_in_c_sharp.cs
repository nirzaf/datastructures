using System;

namespace oop_in_c_sharp
{
    class program
    {
        public void main()
        {

        }
    }

    public class ParentClass {  
    public ParentClass() {  
        Console.WriteLine("Parent Constructor.");  
    }  
    public void print() {  
        Console.WriteLine("I'm a Parent Class.");  
    }  
}  
public class ChildClass: ParentClass {  
    public ChildClass() {  
        Console.WriteLine("Child Constructor.");  
    }  
    public static void Main() {  
        ChildClass child = new ChildClass();  
        child.print();  
    }  
}  
}
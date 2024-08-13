namespace PatikaInheritance;

//Base class with 2 ctors. Name and Surname properties.
public class BasePerson
{
    public BasePerson()
    {
        Console.WriteLine("BasePerson created.\n");
    }
    
    public BasePerson(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Console.WriteLine("BasePerson created.\n");
    }
    
    public string Name { get; set; }
    public string Surname { get; set; }

    public string PrintName()
    {
        return "Name: " + Name + "\nSurname: " + Surname;
    }
}

//This class takes Name, Surname properties and PrintName Method from the Base Class.
public class Student : BasePerson
{
    public string StudentNumber { get; set; }

    public string PrintNameNumber()
    {
        //Used base classes method in this method.
        return PrintName() + "\nStudent Number: " + StudentNumber;
    }
}
    

//This class takes Name, Surname properties and PrintName Method from the Base Class.
public class Teacher : BasePerson
{ 
    public string Salary { get; set; }

    public string PrintNameSalary()
    {
        //Used base classes method in this method.
        return PrintName() + "\nTeacher Salary: " + Salary;
    }
    
}
using PatikaInheritance;
// Created a new student and defined properties.
Student student1 = new Student();

student1.Name = "Selahattin";
student1.Surname = "Tilki";
student1.StudentNumber = "12345678";

// Created a new teacher and defined properties.
Teacher teacher1 = new Teacher();

teacher1.Name = "Samiddha";
teacher1.Surname = "Chouddhuri";
teacher1.Salary = "2300";


//Printing them out with the methods that i've created in the classes.
Console.WriteLine(student1.PrintNameNumber() + "\n");
Console.WriteLine(teacher1.PrintNameSalary());
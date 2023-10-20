// See https://aka.ms/new-console-template for more information
using ExempleUmlTOObject;

Console.WriteLine("Hello, World!");



Professor zeProf = new Professor();
zeProf.Name = "Bernard";

Professor Prof2 = new Professor();
Prof2.Name = "Elisa";

Student Pierre = new Student();
Pierre.Name = "Pierre";


Console.WriteLine(  $"Salaire de {zeProf.Name} : {zeProf.Salary}");
Console.WriteLine($"Salaire de {Prof2.Name} : {Prof2.Salary}");
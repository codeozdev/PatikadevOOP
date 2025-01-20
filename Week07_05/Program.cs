using Week07_05;

List<Student> studentsList =
[
    new() { StudentId = 1, StudentName = "Ali", ClassId = 1 },
    new() { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
    new() { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
    new() { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
    new() { StudentId = 5, StudentName = "Ahmet", ClassId = 2 },
];

List<Class> classesList =
[
    new() { ClassId = 1, ClassName = "Matematik" },
    new() { ClassId = 2, ClassName = "Türkçe" },
    new() { ClassId = 3, ClassName = "Kimya" },
];

// LINQ siniflara gore ogrencileri gruplandirir
var result = classesList
    .GroupJoin(
        studentsList,
        classInfo => classInfo.ClassId,
        student => student.ClassId,
        (classInfo, studentGroup) => new
        {
            ClassName = classInfo.ClassName,
            Students = studentGroup
        });

foreach (var item in result)
{
    Console.WriteLine($"Sınıf: {item.ClassName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"  -- {student.StudentName}");
    }

    Console.WriteLine();
}
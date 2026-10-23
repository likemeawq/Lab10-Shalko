string subject = "Программирование";
foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine(subject.Length);

int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
foreach (int grade in grades)
{}
    Console.WriteLine(grade);
    sum += grade;
}
double avg = (double)sum / grades.Length;
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Средний балл: {avg}");

string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;
foreach (string student in students)
{
    Console.WriteLine(student);
    count++;
}
Console.WriteLine($"Всего учеников: {count}");

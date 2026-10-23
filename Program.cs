// string subject = "Программирование";
// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
// }
// double avg = (double)sum / grades.Length;
// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Средний балл: {avg}");

// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;
// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     count++;
// }
// Console.WriteLine($"Всего учеников: {count}");

// int[] points = { 10, 20, 15 };
// for (int i = 0; i < points.Length; i++) 
// {
//     points[i] = points[i] + 5;
//     Console.WriteLine(points[i]);
// }

// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;
// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

int[] numbers = { 1, 2, 3, 4, 6 };
int sum = 0;
foreach (int num in numbers) 
{
    Console.WriteLine(num);
    sum += num;
}
Console.WriteLine($"Сумма: {sum}");

string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
foreach (string day in days)
{
    Console.WriteLine($"{day}!");
}

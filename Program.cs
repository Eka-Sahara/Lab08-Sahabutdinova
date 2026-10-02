// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber <= totalLessons) {
//     System.Console.WriteLine($"Пара {totalLessons}");
//     totalLessons--;
// }

// System.Console.WriteLine("Пары закончились");

int count = 0;

System.Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());

while (grade != -1) {
    System.Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    count++;
}

System.Console.WriteLine("Ввод завершён");
System.Console.WriteLine(count);










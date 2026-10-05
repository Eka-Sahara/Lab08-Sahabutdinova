// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber <= totalLessons) {
//     System.Console.WriteLine($"Пара {totalLessons}");
//     totalLessons--;
// }

// System.Console.WriteLine("Пары закончились");

// int count = 0;

// System.Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     System.Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     count++;
// }

// System.Console.WriteLine("Ввод завершён");
// System.Console.WriteLine(count);

// int sum = 0;
// int count = 0;
// int maxGrade = 1;

// System.Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     sum += grade;
//     count++;
//     if (grade > maxGrade) {
//         maxGrade = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0) {
//     System.Console.WriteLine($"Средний балл: {(double)sum / count}");
// } else {
//     System.Console.WriteLine("Оценок не было введено");
// }
// System.Console.WriteLine($"Наибольшая из введённых оценок: {maxGrade}");

string correctPassword = "qwerty123";
int count = 0;
while (true)
{
    System.Console.WriteLine("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword) {
        System.Console.WriteLine("Доступ разрешён");
        break;
    }
        count += 1;
        System.Console.WriteLine("Неверный пароль, попробуйте снова");
}
System.Console.WriteLine($"Количество неудачных попыток: {count}");











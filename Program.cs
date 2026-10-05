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

// string correctPassword = "qwerty123";
// int count = 0;
// while (true) {
//     System.Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword) {
//         System.Console.WriteLine("Доступ разрешён");
//         break;
//     }
//         count += 1;
//         System.Console.WriteLine("Неверный пароль, попробуйте снова");
// }
// System.Console.WriteLine($"Количество неудачных попыток: {count}");

// string answer;

// do {
//     System.Console.WriteLine("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     System.Console.WriteLine($"Запись добавлена: {date}");

//     System.Console.WriteLine("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// System.Console.WriteLine("Дневник сохранён");

// System.Console.WriteLine("Задача Б");
// int count = 0;

// System.Console.WriteLine("Вводите имена по одному, для завершения введите конец:");
// string name = Console.ReadLine();

// while (name != "конец") {
//     System.Console.WriteLine($"Имя принято: {name}");
//     name = Console.ReadLine();
//     count++;
// }

// System.Console.WriteLine("Ввод завершён");
// System.Console.WriteLine($"Всего имён: {count}");

// System.Console.WriteLine("Задача Г");

// while (true) {
//     System.Console.WriteLine("Введите число: ");
//     int number = int.Parse(Console.ReadLine());

//     if (number % 7 == 0) {
//         System.Console.WriteLine("Найдено!");
//         break;
//     }
//         System.Console.WriteLine("Ввод чисел продолжается");
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

// System.Console.WriteLine("Вариант 2");

// int sum = 0;

// System.Console.WriteLine("Вводите числа по одному, для завершения введите конец:");
// int number = int.Parse(Console.ReadLine());

// while (number != 0) {
//     System.Console.WriteLine($"Число принято: {number}");
//     if (number > 0) {
//         sum += number;
//     }
//     number = int.Parse(Console.ReadLine());
// }

// System.Console.WriteLine("Ввод завершён");
// System.Console.WriteLine($"Сумма введённых положительных чисел: {sum}");

// System.Console.WriteLine("Вариант 3");

// int number = 1;
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// while(number <= num) {
//     System.Console.WriteLine($"{number} => {number * number}");
//     number++;
// }








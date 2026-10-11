// Самостоятельная работа №6. Задачи на условия

// Вариант 5
// int weather = 16;

// switch (weather) {
//     case < 0:
//         Console.WriteLine("Мороз");
//         break;
//     case >= 0 and <= 9:
//         Console.WriteLine("Прохладно");
//         break;
//     case >= 10 and <= 19:
//         Console.WriteLine("Комфортно");
//         break;
//     case >= 20 and <= 29:
//         Console.WriteLine("Тепло");
//         break;
//     case >= 30:
//         Console.WriteLine("Жарко");
//         break;
// }

// Вариант 2
// int score = 80;

// switch (score) {
//      case >= 0 and <=39:
//          Console.WriteLine("Неудовлетворительно");
//          break;
//      case >= 40 and <= 59:
//          Console.WriteLine("Удовлетворительно");
//          break;
//      case >= 60 and <= 79:
//          Console.WriteLine("Хорошо");
//          break;
//      case >= 80 and <= 100:
//          Console.WriteLine("Отлично");
//          break;
//  }

// Задача Б
// int age = 16;

//  switch (age) {
//      case < 0:
//          Console.WriteLine("Ошибка");
//          break;
//      case >= 0 and <= 6:
//          Console.WriteLine("Ребёнок");
//          break;
//      case >= 7 and <= 17:
//          Console.WriteLine("Подросток");
//          break;
//      case >= 18 and <= 64:
//          Console.WriteLine("Взрослый");
//          break;
//      case >= 65:
//          Console.WriteLine("Пенсионер");
//          break;
//  }

// Задача В
// int dayNumber = 4;

// switch (dayNumber) {
//     case >= 1 and <= 5:
//         Console.WriteLine("Будний");
//         break;
//     case 6 or 7:
//         Console.WriteLine("Выходной");
//         break;
// }



// Практическая работа №5

// int dayNumber = 6;
// switch (dayNumber) {
//     case 5 or 6 or 7: 
//         Console.WriteLine("Выходной"); 
//         break;
//     default: 
//         Console.WriteLine("Будний"); 
//         break;
// }


// int score = 78;
// switch (score) {
//     case >= 0 and <= 39:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and <= 59:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and <= 79:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }


// int temperature = 22;
// string result = temperature switch {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => "Очень жарко",
// };
// Console.WriteLine(result);


// // Задача с ролями
// string role = "teacher";
// string result = role switch {
//     "admin" => "Полный доступ",
//     "teacher" => "Доступ преподавателя",
//     _ => "Ограниченный доступ"
// };

// // Задача с возрастом и билетом
// int age = 20;
// bool hasTicket = true;
// switch (age) {
//     case >= 18 when hasTicket:
//         Console.WriteLine("Вход разрешён");
//         break;
//     case >= 18:
//         Console.WriteLine("Нет билета");
//         break;
//     default:
//         Console.WriteLine("Возраст не подходит");
//         break;
// }


// // Задача А

// Console.Write("Введите номер месяца: ");
// int month = int.Parse(Console.ReadLine()!);

// string season = month switch {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };

// Console.WriteLine($"Время года: {season}");


// Задача Б

// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine()!);

// string category = age switch {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребёнок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     >= 65 => "Пенсионер",
// };

// Console.WriteLine($"Категория: {category}");

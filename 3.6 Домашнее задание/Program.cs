string fullName;
int age;
string email;
double pointsProgramming;
double pointsMaths;
double pointsPhisics;

// Задание 1. Создание переменных и вывод
fullName = "Иван Иванов";
age = 13;
email = "ivan@mail.ru";
pointsProgramming = 94.5;
pointsMaths = 66.6;
pointsPhisics = 30;

Console.WriteLine(" Full name: {0} \n Age: {1} \n Email: {2} \n Programming: {3} \n Maths: {4} \n Phisics:{5} \n", 
    fullName,
    age,
    email,
    pointsProgramming,
    pointsMaths,
    pointsPhisics
    );
Console.ReadKey();

//Задание 2. Реализация подсчёта количества баллов по всем предметам
double sumPoints = pointsProgramming + pointsMaths + pointsPhisics;
double avgPoints = sumPoints / 3;

Console.WriteLine(" Average points: {0}", Math.Round(avgPoints, 2));
// Данная прогрмма преднзначена для планирования пользователем задач
using System;

struct Task
{
    public string taskname;
    public int priority;
    public string date;
    public string description;

    public void output()
    {
        ;
        Console.WriteLine($"Задание: {taskname} Приоритет: {priorty} Дедлайн: {date} Описание задания: {description}");
    }

}

class Person
{
    public string name;
    public string surname;
    public string contact;

    public void outputperson()
    {
        ;
        Console.WriteLine($"Имя: {name} Фамилия: {surname} Контакты: {contact}");
    }
}

public class Testing
{
    public static void Main(string[] args)
    {
        //Инициализация структур и классов
        Task by_Lisa = new Task("Лабораторная", 1, "12.02.2024", "Создание структуры для лабораторной работы.");
        Task by_other_student = new Task("Курсовая", 5, "15.03.2024", "Создание структуры для курсовой работы.");

        Person Lisa = new Person();
        Lisa.name = "Veta";
        Lisa.surname = "Egorova";
        Lisa.contact = "@japanesepotatos";

        Lisa.outputperson(); //Вывод информации до изменения
        by_Lisa.output();

        Person Somebody = new Person();
        Somebody.name = "Other";
        Somebody.surname = "Student";
        Somebody.contact = "@tgchanel";

        //Изменение информации
        by_Lisa.priority = 2;
        by_Lisa.date = "01.04.2024";
        by_Lisa.description = "Написание кода для лабораторной работы";

        Lisa.outputperson(); //Вывод информации после изменения
        by_Lisa.output();

        //Конец третьего задания

        //Задание 4

    }
}
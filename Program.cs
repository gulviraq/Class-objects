using System;
using System.Collections.Generic;

// 1. Класс Student
class Student
{
    public string name;
    public int age;
    public string group;

    public Student(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}");
    }
}

// 2. Класс Car
class Car
{
    public string brand;
    public string model;
    public int year;

    public Car(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }
}

// 3. Класс Book
class Book
{
    public string title;
    public string author;
    public int pages;

    public Book(string title, string author, int pages)
    {
        this.title = title;
        this.author = author;
        this.pages = pages;
    }
}

// 4. Класс Phone
class Phone
{
    public string brand;
    public string model;
    public double price;

    public Phone(string brand, string model, double price)
    {
        this.brand = brand;
        this.model = model;
        this.price = price;
    }
}

// 5. Класс Cat
class Cat
{
    public string name;
    public int age;

    public Cat(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Meow()
    {
        Console.WriteLine($"{name} мяукает: Мяу!");
    }
}

// 6. Класс Dog
class Dog
{
    public string name;
    public string breed;

    public Dog(string name, string breed)
    {
        this.name = name;
        this.breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{name} лает: Гав!");
    }
}

// 7. Класс Rectangle
class Rectangle
{
    public double width;
    public double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area()
    {
        return width * height;
    }

    public double Perimeter()
    {
        return 2 * (width + height);
    }
}

// 8. Класс Circle
class Circle
{
    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

// 9. Класс Employee
class Employee
{
    public string name;
    public string position;
    public double salary;

    public Employee(string name, string position, double salary)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
    }
}

// 10. Класс Laptop
class Laptop
{
    public string brand;
    public int ram;
    public double price;

    public Laptop(string brand, int ram, double price)
    {
        this.brand = brand;
        this.ram = ram;
        this.price = price;
    }
}

// 11 и 22. Класс BankAccount
class BankAccount
{
    public string owner;
    public double balance;

    public BankAccount(string owner, double balance)
    {
        this.owner = owner;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Недостаточно средств или неверная сумма");
    }
}

// 12. Класс Product
class Product
{
    public string name;
    public double price;
    public int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public double TotalCost()
    {
        return price * quantity;
    }
}

// 13. Класс Student с оценками
class StudentGrade
{
    public string name;
    public int grade;

    public StudentGrade(string name, int grade)
    {
        this.name = name;
        this.grade = grade;
    }

    public void Passed()
    {
        if (grade >= 50)
            Console.WriteLine($"{name} сдал экзамен");
        else
            Console.WriteLine($"{name} не сдал экзамен");
    }
}

// 14. Класс Counter
class Counter
{
    public int count;

    public Counter(int count)
    {
        this.count = count;
    }

    public void Increase()
    {
        count++;
    }

    public void Decrease()
    {
        count--;
    }

    public void Reset()
    {
        count = 0;
    }
}

// 15. Класс Movie
class Movie
{
    public string title;
    public string genre;
    public int duration;

    public Movie(string title, string genre, int duration)
    {
        this.title = title;
        this.genre = genre;
        this.duration = duration;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{title} - {genre} - {duration} минут");
    }
}

// 16. Класс Temperature
class Temperature
{
    public double celsius;

    public Temperature(double celsius)
    {
        this.celsius = celsius;
    }

    public double ToFahrenheit()
    {
        return celsius * 9 / 5 + 32;
    }

    public double ToKelvin()
    {
        return celsius + 273.15;
    }
}

// 17. Класс Point
class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double Distance()
    {
        return Math.Sqrt(x * x + y * y);
    }
}

// 18. Класс ShoppingCart
class ShoppingCart
{
    public string productName;
    public double price;
    public int quantity;

    public ShoppingCart(string productName, double price, int quantity)
    {
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }

    public double Total()
    {
        return price * quantity;
    }

    public void ChangeQuantity(int quantity)
    {
        if (quantity >= 0)
            this.quantity = quantity;
    }
}

// 19. Класс Clock
class Clock
{
    public int hours;
    public int minutes;
    public int seconds;

    public Clock(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public void ShowTime()
    {
        Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}

// 20. Класс Flight
class Flight
{
    public string flightNumber;
    public string destination;
    public int availableSeats;

    public Flight(string flightNumber, string destination, int availableSeats)
    {
        this.flightNumber = flightNumber;
        this.destination = destination;
        this.availableSeats = availableSeats;
    }

    public void BookSeat()
    {
        if (availableSeats > 0)
        {
            availableSeats--;
            Console.WriteLine("Место забронировано");
        }
        else
        {
            Console.WriteLine("Свободных мест нет");
        }
    }
}

// 21. Класс Computer
class Computer
{
    public string brand;
    public string processor;
    public int ram;
    public double price;

    public Computer(string brand, string processor, int ram, double price)
    {
        this.brand = brand;
        this.processor = processor;
        this.ram = ram;
        this.price = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Бренд: {brand}, Процессор: {processor}, ОЗУ: {ram} ГБ, Цена: {price}");
    }
}

// 23. Класс LibraryBook
class LibraryBook
{
    public string title;
    public string author;
    public bool isAvailable;

    public LibraryBook(string title, string author, bool isAvailable)
    {
        this.title = title;
        this.author = author;
        this.isAvailable = isAvailable;
    }

    public void Borrow()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine("Книга выдана");
        }
        else
        {
            Console.WriteLine("Книга уже выдана");
        }
    }

    public void ReturnBook()
    {
        if (!isAvailable)
        {
            isAvailable = true;
            Console.WriteLine("Книга возвращена");
        }
        else
        {
            Console.WriteLine("Книга уже находится в библиотеке");
        }
    }
}

// 24. Класс StudentGroup
class StudentGroup
{
    public string name;
    public double averageGrade;

    public StudentGroup(string name, double averageGrade)
    {
        this.name = name;
        this.averageGrade = averageGrade;
    }
}

// 25. Класс MobilePhone
class MobilePhone
{
    public string brand;
    public int batteryLevel;
    public bool isOn;

    public MobilePhone(string brand, int batteryLevel, bool isOn)
    {
        this.brand = brand;
        this.batteryLevel = batteryLevel;
        this.isOn = isOn;
    }

    public void TurnOn()
    {
        if (batteryLevel > 0)
        {
            isOn = true;
            Console.WriteLine("Телефон включён");
        }
        else
        {
            Console.WriteLine("Телефон разряжен");
        }
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Телефон выключен");
    }

    public void UseBattery(int amount)
    {
        if (isOn && amount > 0)
        {
            batteryLevel = Math.Max(0, batteryLevel - amount);

            if (batteryLevel == 0)
            {
                isOn = false;
                Console.WriteLine("Телефон разрядился");
            }
        }
    }
}

// 26. Класс Car с пробегом
class CarMileage
{
    public string brand;
    public double mileage;
    public double fuel;

    public CarMileage(string brand, double mileage, double fuel)
    {
        this.brand = brand;
        this.mileage = mileage;
        this.fuel = fuel;
    }

    public void Drive(double distance)
    {
        if (distance <= 0)
        {
            Console.WriteLine("Неверное расстояние");
            return;
        }

        double fuelNeeded = distance * 8 / 100;

        if (fuelNeeded <= fuel)
        {
            mileage += distance;
            fuel -= fuelNeeded;
            Console.WriteLine("Поездка завершена");
        }
        else
        {
            Console.WriteLine("Недостаточно топлива");
        }
    }
}

// 27. Класс Order
class Order
{
    public int orderNumber;
    public string productName;
    public double price;
    public int quantity;

    public Order(int orderNumber, string productName, double price, int quantity)
    {
        this.orderNumber = orderNumber;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }

    public double TotalPrice()
    {
        return price * quantity;
    }

    public void ChangeQuantity(int quantity)
    {
        if (quantity >= 0)
            this.quantity = quantity;
    }
}

// 28. Класс Player
class Player
{
    public string name;
    public int health;
    public int damage;

    public Player(string name, int health, int damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
    }

    public void Attack(Player other)
    {
        other.TakeDamage(damage);
        Console.WriteLine($"{name} атакует {other.name}");
    }

    public void TakeDamage(int damage)
    {
        health = Math.Max(0, health - damage);
        Console.WriteLine($"{name}: здоровье = {health}");
    }
}

// 29. Класс Warehouse
class Warehouse
{
    public string productName;
    public int quantity;
    public int capacity;

    public Warehouse(string productName, int quantity, int capacity)
    {
        this.productName = productName;
        this.quantity = quantity;
        this.capacity = capacity;
    }

    public void AddProduct(int amount)
    {
        if (amount > 0 && quantity + amount <= capacity)
        {
            quantity += amount;
            Console.WriteLine("Товар добавлен");
        }
        else
        {
            Console.WriteLine("Нельзя добавить такое количество товаров");
        }
    }

    public void RemoveProduct(int amount)
    {
        if (amount > 0 && amount <= quantity)
        {
            quantity -= amount;
            Console.WriteLine("Товар удалён");
        }
        else
        {
            Console.WriteLine("Недостаточно товаров на складе");
        }
    }
}

// 30. Мини-проект «Система управления университетом»
class UniversityStudent
{
    public string name;
    public int age;
    public string group;

    public UniversityStudent(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Студент: {name}, Возраст: {age}, Группа: {group}");
    }
}

class Teacher
{
    public string name;
    public string subject;

    public Teacher(string name, string subject)
    {
        this.name = name;
        this.subject = subject;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Преподаватель: {name}, Предмет: {subject}");
    }
}

class Course
{
    public string title;
    public Teacher teacher;
    public List<UniversityStudent> students = new List<UniversityStudent>();

    public Course(string title, Teacher teacher)
    {
        this.title = title;
        this.teacher = teacher;
    }

    public void AddStudent(UniversityStudent student)
    {
        students.Add(student);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Курс: {title}");
        Console.WriteLine($"Преподаватель: {teacher.name}");
        Console.WriteLine("Студенты:");

        foreach (UniversityStudent student in students)
        {
            Console.WriteLine(student.name);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Задание 1 ===");
        Student student1 = new Student("Алия", 18, "ИС-23");
        student1.ShowInfo();

        Console.WriteLine("\n=== Задание 2 ===");
        Car car1 = new Car("Toyota", "Camry", 2022);
        Car car2 = new Car("BMW", "X5", 2024);
        Console.WriteLine($"{car1.brand} {car1.model} {car1.year}");
        Console.WriteLine($"{car2.brand} {car2.model} {car2.year}");

        Console.WriteLine("\n=== Задание 3 ===");
        Book book1 = new Book("Преступление и наказание", "Достоевский", 672);
        Console.WriteLine($"{book1.title}, {book1.author}, {book1.pages} страниц");

        Console.WriteLine("\n=== Задание 4 ===");
        Phone phone1 = new Phone("Apple", "iPhone 15", 350000);
        Phone phone2 = new Phone("Samsung", "Galaxy S24", 300000);
        Phone phone3 = new Phone("Xiaomi", "Redmi Note 13", 120000);
        Console.WriteLine($"{phone1.brand} {phone1.model}: {phone1.price}");
        Console.WriteLine($"{phone2.brand} {phone2.model}: {phone2.price}");
        Console.WriteLine($"{phone3.brand} {phone3.model}: {phone3.price}");

        Console.WriteLine("\n=== Задание 5 ===");
        Cat cat1 = new Cat("Мурка", 3);
        cat1.Meow();

        Console.WriteLine("\n=== Задание 6 ===");
        Dog dog1 = new Dog("Бобик", "Овчарка");
        dog1.Bark();

        Console.WriteLine("\n=== Задание 7 ===");
        Rectangle rectangle1 = new Rectangle(5, 3);
        Console.WriteLine($"Площадь: {rectangle1.Area()}");
        Console.WriteLine($"Периметр: {rectangle1.Perimeter()}");

        Console.WriteLine("\n=== Задание 8 ===");
        Circle circle1 = new Circle(5);
        Console.WriteLine($"Площадь круга: {circle1.Area():F2}");

        Console.WriteLine("\n=== Задание 9 ===");
        Employee employee1 = new Employee("Иван", "Программист", 350000);
        Console.WriteLine($"{employee1.name}, {employee1.position}, зарплата: {employee1.salary}");

        Console.WriteLine("\n=== Задание 10 ===");
        Laptop laptop1 = new Laptop("Lenovo", 16, 400000);
        Laptop laptop2 = new Laptop("ASUS", 32, 550000);
        Console.WriteLine($"{laptop1.brand}: {laptop1.price}");
        Console.WriteLine($"{laptop2.brand}: {laptop2.price}");
        Console.WriteLine(laptop1.price > laptop2.price ? "Первый ноутбук дороже" :
            laptop1.price < laptop2.price ? "Второй ноутбук дороже" : "Цены одинаковые");

        Console.WriteLine("\n=== Задание 11 ===");
        BankAccount account1 = new BankAccount("Алия", 50000);
        account1.Deposit(10000);
        account1.Withdraw(20000);
        Console.WriteLine($"{account1.owner}: {account1.balance}");

        Console.WriteLine("\n=== Задание 12 ===");
        Product product1 = new Product("Ноутбук", 400000, 5);
        Console.WriteLine($"Общая стоимость: {product1.TotalCost()}");

        Console.WriteLine("\n=== Задание 13 ===");
        StudentGrade grade1 = new StudentGrade("Алия", 85);
        StudentGrade grade2 = new StudentGrade("Данияр", 40);
        grade1.Passed();
        grade2.Passed();

        Console.WriteLine("\n=== Задание 14 ===");
        Counter counter1 = new Counter(5);
        counter1.Increase();
        Console.WriteLine(counter1.count);
        counter1.Decrease();
        Console.WriteLine(counter1.count);
        counter1.Reset();
        Console.WriteLine(counter1.count);

        Console.WriteLine("\n=== Задание 15 ===");
        Movie movie1 = new Movie("Интерстеллар", "Фантастика", 169);
        movie1.ShowInfo();

        Console.WriteLine("\n=== Задание 16 ===");
        Temperature temp1 = new Temperature(25);
        Console.WriteLine($"Фаренгейты: {temp1.ToFahrenheit()}");
        Console.WriteLine($"Кельвины: {temp1.ToKelvin()}");

        Console.WriteLine("\n=== Задание 17 ===");
        Point point1 = new Point(3, 4);
        Console.WriteLine($"Расстояние: {point1.Distance()}");

        Console.WriteLine("\n=== Задание 18 ===");
        ShoppingCart cart1 = new ShoppingCart("Наушники", 10000, 2);
        Console.WriteLine($"Сумма: {cart1.Total()}");
        cart1.ChangeQuantity(3);
        Console.WriteLine($"Новая сумма: {cart1.Total()}");

        Console.WriteLine("\n=== Задание 19 ===");
        Clock clock1 = new Clock(9, 5, 7);
        clock1.ShowTime();

        Console.WriteLine("\n=== Задание 20 ===");
        Flight flight1 = new Flight("KC101", "Алматы", 3);
        flight1.BookSeat();
        Console.WriteLine($"Свободных мест: {flight1.availableSeats}");

        Console.WriteLine("\n=== Задание 21 ===");
        Computer computer1 = new Computer("Lenovo", "Intel i5", 16, 350000);
        Computer computer2 = new Computer("ASUS", "Intel i7", 32, 500000);
        Computer computer3 = new Computer("HP", "AMD Ryzen 5", 8, 280000);
        computer1.ShowInfo();
        computer2.ShowInfo();
        computer3.ShowInfo();

        Console.WriteLine("\n=== Задание 22 ===");
        BankAccount account2 = new BankAccount("Данияр", 30000);
        account1.Deposit(10000);
        account2.Withdraw(5000);
        Console.WriteLine($"{account1.owner}: {account1.balance}");
        Console.WriteLine($"{account2.owner}: {account2.balance}");

        Console.WriteLine("\n=== Задание 23 ===");
        LibraryBook libraryBook1 = new LibraryBook("Гарри Поттер", "Дж. Роулинг", true);
        libraryBook1.Borrow();
        libraryBook1.Borrow();
        libraryBook1.ReturnBook();

        Console.WriteLine("\n=== Задание 24 ===");
        List<StudentGroup> students = new List<StudentGroup>
        {
            new StudentGroup("Алия", 85),
            new StudentGroup("Данияр", 92),
            new StudentGroup("Марат", 78),
            new StudentGroup("Анна", 95),
            new StudentGroup("Иван", 88)
        };

        StudentGroup bestStudent = students[0];

        foreach (StudentGroup student in students)
        {
            if (student.averageGrade > bestStudent.averageGrade)
                bestStudent = student;
        }

        Console.WriteLine($"Лучший студент: {bestStudent.name}, балл: {bestStudent.averageGrade}");

        Console.WriteLine("\n=== Задание 25 ===");
        MobilePhone mobile1 = new MobilePhone("Samsung", 100, false);
        mobile1.TurnOn();
        mobile1.UseBattery(30);
        Console.WriteLine($"Заряд: {mobile1.batteryLevel}%");

        Console.WriteLine("\n=== Задание 26 ===");
        CarMileage car3 = new CarMileage("Toyota", 10000, 50);
        car3.Drive(200);
        Console.WriteLine($"Пробег: {car3.mileage} км, Топливо: {car3.fuel} л");

        Console.WriteLine("\n=== Задание 27 ===");
        Order order1 = new Order(101, "Клавиатура", 15000, 2);
        Console.WriteLine($"Стоимость: {order1.TotalPrice()}");
        order1.ChangeQuantity(4);
        Console.WriteLine($"Новая стоимость: {order1.TotalPrice()}");

        Console.WriteLine("\n=== Задание 28 ===");
        Player player1 = new Player("Воин", 100, 30);
        Player player2 = new Player("Маг", 80, 20);
        player1.Attack(player2);
        player2.Attack(player1);

        Console.WriteLine("\n=== Задание 29 ===");
        Warehouse warehouse1 = new Warehouse("Ноутбук", 10, 20);
        warehouse1.AddProduct(5);
        warehouse1.RemoveProduct(3);
        Console.WriteLine($"Количество товаров: {warehouse1.quantity}");

        Console.WriteLine("\n=== Задание 30 ===");
        UniversityStudent universityStudent1 = new UniversityStudent("Алия", 18, "ИС-23");
        UniversityStudent universityStudent2 = new UniversityStudent("Данияр", 19, "ИС-23");
        UniversityStudent universityStudent3 = new UniversityStudent("Анна", 18, "ИС-24");

        Teacher teacher1 = new Teacher("Иван Петров", "Программирование");
        Teacher teacher2 = new Teacher("Мария Иванова", "Базы данных");

        Course course1 = new Course("Python", teacher1);
        Course course2 = new Course("SQL", teacher2);

        course1.AddStudent(universityStudent1);
        course1.AddStudent(universityStudent2);
        course2.AddStudent(universityStudent2);
        course2.AddStudent(universityStudent3);

        universityStudent1.ShowInfo();
        universityStudent2.ShowInfo();
        universityStudent3.ShowInfo();

        teacher1.ShowInfo();
        teacher2.ShowInfo();

        course1.ShowInfo();
        course2.ShowInfo();
    }
}
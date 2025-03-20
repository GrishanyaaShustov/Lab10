using System;
using Car;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[20];
            Random random = new Random();

            // Инициализация массива случайными объектами разных классов
            for (int i = 0; i < cars.Length; i++)
            {
                // Случайный выбор типа класса
                int classType = random.Next(0, 3); // 0 - LightCar, 1 - BigCar, 2 - DeliveryCar

                switch (classType)
                {
                    case 0:
                        cars[i] = new LightCar();
                        break;
                    case 1:
                        cars[i] = new BigCar();
                        break;
                    case 2:
                        cars[i] = new DeliveryCar();
                        break;
                }

                // Инициализация каждого объекта случайными значениями
                cars[i].RandomInit();
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Просмотр через обычные функции");
                Console.WriteLine("2. Просмотр через виртуальные функции");
                Console.WriteLine("3. Самый дорогой внедорожник");
                Console.WriteLine("4. Средняя скорость легковых автомобилей");
                Console.WriteLine("5. Грузовики с грузоподъемностью превышающей 17 тон");
                Console.WriteLine("6. Работа с DialClock и машинками");
                Console.WriteLine("7. Сортировка машин по стоимости");
                Console.WriteLine("8. Сортировка машин по годам");
                Console.WriteLine("9. Бинарный поиск");
                Console.WriteLine("10. Разница между поверхностным и глубоким копированием");
                Console.WriteLine("11. Бинарный поиск(2 критерий)");
                Console.Write("Выберите: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("=== Просмотр через обычные функции ===");
                        foreach (var car in cars)
                        {
                            if (car is LightCar lightCar)
                            {
                                Console.Write("Легковой автомобиль: ");
                                lightCar.Show();
                            }
                            else if (car is BigCar bigCar)
                            {
                                Console.Write("Внедорожник: ");
                                bigCar.Show();
                            }
                            else if (car is DeliveryCar deliveryCar)
                            {
                                Console.Write("Грузовик: ");
                                deliveryCar.Show();
                            }
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;
                    case "2":
                        Console.WriteLine("\n=== Просмотр через виртуальные функции ===");
                        foreach (Car car in cars)
                        {
                            car.Show(); // Вызов виртуального метода Show()
                            Console.WriteLine();
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;
                    case "3":
                        Console.WriteLine("\n=== Самый дорогой внедорожник ===");
                        BigCar mostExpensiveBigCar = Car.GetMostExpensiveBigCar(cars);
                        if (mostExpensiveBigCar != null)
                        {
                            mostExpensiveBigCar.Show();
                        }
                        else
                        {
                            Console.WriteLine("Внедорожники отсутствуют.");
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;
                    case "4":
                        Console.WriteLine("\n=== Средняя скорость легковых автомобилей ===");
                        double averageSpeed = Car.GetAverageSpeedOfLightCars(cars);
                        Console.WriteLine($"Средняя скорость: {averageSpeed:F2} км/ч");
                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("\n=== Грузовики с грузоподъемностью превышающей 17 тон ===");
                        var heavyTrucks = Car.GetTrucksWithLoadCapacityAbove(cars, 17);
                        foreach (var truck in heavyTrucks)
                        {
                            truck.Show();
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;
                    case "6":

                        int lightCarCount = 0;
                        int bigCarCount = 0;
                        int deliveryCarCount = 0;
                        int dialClockCount = 0;

                        // Создание массива объектов
                        object[] items = new object[25];
                        Random random1 = new Random();

                        // Инициализация массива случайными объектами
                        for (int i = 0; i < items.Length; i++)
                        {
                            int itemType = random1.Next(0, 5); // 0-3: автомобили, 4: DialClock

                            switch (itemType)
                            {
                                case 0:
                                    items[i] = new LightCar();
                                    break;
                                case 1:
                                    items[i] = new BigCar();
                                    break;
                                case 2:
                                    items[i] = new DeliveryCar();
                                    break;
                                case 3:
                                    items[i] = new Car();
                                    break;
                                case 4:
                                    items[i] = new DialClock();
                                    break;
                            }

                            // Инициализация каждого объекта случайными значениями
                            if (items[i] is IInit initItem)
                            {
                                initItem.IRandomInit();
                            }
                        }

                        Console.WriteLine("\n=== Просмотр всех объектов ===");
                        foreach (var item in items)
                        {
                            if (item is Car car)
                            {
                                car.Show();
                            }
                            else if (item is DialClock clock)
                            {
                                Console.WriteLine(clock.ToString());
                            }

                            if (item is LightCar)
                            {
                                lightCarCount++;
                            }
                            else if (item is BigCar)
                            {
                                bigCarCount++;
                            }
                            else if (item is DeliveryCar)
                            {
                                deliveryCarCount++;
                            }
                            else if (item is DialClock)
                            {
                                dialClockCount++;
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("\n=== Подсчёт объектов по типам ===");
                        Console.WriteLine($"Легковых - {lightCarCount}");
                        Console.WriteLine($"Внедорожников - {bigCarCount}");
                        Console.WriteLine($"Грузовых - {deliveryCarCount}");
                        Console.WriteLine($"Часов - {dialClockCount}");

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;

                    case "7":
                        // Сортировка массива
                        Array.Sort(cars);

                        // Отсортированный массив
                        Console.WriteLine("\n=== Отсортированный массив (по стоимости) ===");
                        foreach (var car in cars)
                        {
                            car.Show();
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;

                    case "8":
                        // Сортировка массива по году выпуска
                        Array.Sort(cars, new CarYearComparer());

                        // Отсортированный массив
                        Console.WriteLine("\n=== Отсортированный массив (по году выпуска) ===");
                        foreach (var car in cars)
                        {
                            car.Show();
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();

                        break;

                    case "9":

                        Array.Sort(cars);

                        Console.WriteLine("\nВведите стоимость автомобиля для поиска:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal searchPrice))
                        {
                            Car searchCar = new Car { Price = searchPrice };

                            int index = Array.BinarySearch(cars, searchCar);

                            if (index >= 0)
                            {
                                Console.WriteLine($"\nАвтомобиль найден на позиции {index}:");
                                cars[index].Show();
                                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nАвтомобиль не найден.");
                                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод стоимости.");
                            Console.WriteLine("\nАвтомобиль не найден.");
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        }

                        break;

                    case "10":
                        Car originalCar = new Car
                        {
                            Brand = "Toyota",
                            Year = 2020,
                            Color = "Red",
                            Price = 30000,
                            Clearance = 150,
                            CarId = new IdNumber(12345)
                        };

                        Console.WriteLine("=== Исходный объект ===");
                        originalCar.Show();

                        // Поверхностное копирование
                        Car shallowCopy = originalCar.ShallowCopy();
                        shallowCopy.Brand = "Honda";
                        shallowCopy.CarId.Number = 67890;


                        Console.WriteLine("\n=== После изменения поверхностной копии ===");
                        Console.WriteLine("Исходный объект:");
                        originalCar.Show();
                        Console.WriteLine("Поверхностная копия:");
                        shallowCopy.Show();

                        // Глубокое копирование
                        Car deepCopy = (Car)originalCar.Clone();
                        deepCopy.Brand = "BMW"; // Изменяем бренд в глубокой копии
                        if (deepCopy.CarId != null)
                        {
                            deepCopy.CarId.Number = 99999; // Изменяем ID в глубокой копии
                        }

                        Console.WriteLine("\n=== После изменения глубокой копии ===");
                        Console.WriteLine("Исходный объект:");
                        originalCar.Show();
                        Console.WriteLine("Глубокая копия:");
                        deepCopy.Show();

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;

                    case "11":
                        Array.Sort(cars, new CarYearComparer()); // Сортируем по году выпуска

                        Console.WriteLine("\nВведите год автомобиля для поиска:");
                        if (int.TryParse(Console.ReadLine(), out int searchYear))
                        {
                            Car searchCar = new Car { Year = searchYear };

                            int index = Array.BinarySearch(cars, searchCar, new CarYearComparer());

                            if (index >= 0)
                            {
                                Console.WriteLine($"\nАвтомобиль найден на позиции {index}:");
                                cars[index].Show();
                            }
                            else
                            {
                                Console.WriteLine("\nАвтомобиль не найден.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод года.");
                        }

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
using Car;

[TestFixture]
public class CarTests

{
    // Тесты для класса Car
    [Test]
    public void Car_Clone_ShouldCreateDeepCopy()
    {
        var originalCar = new Car.Car
        {
            Brand = "Toyota",
            Year = 2020,
            Color = "Red",
            Price = 30000,
            Clearance = 150,
            CarId = new IdNumber(12345)
        };

        var clonedCar = (Car.Car)originalCar.Clone();

        Assert.AreEqual(originalCar.Brand, clonedCar.Brand);
        Assert.AreEqual(originalCar.Year, clonedCar.Year);
        Assert.AreEqual(originalCar.Color, clonedCar.Color);
        Assert.AreEqual(originalCar.Price, clonedCar.Price);
        Assert.AreEqual(originalCar.Clearance, clonedCar.Clearance);
        Assert.AreEqual(originalCar.CarId.Number, clonedCar.CarId.Number);

        clonedCar.Brand = "Honda";
        clonedCar.CarId.Number = 67890;

        Assert.AreNotEqual(originalCar.Brand, clonedCar.Brand);
        Assert.AreNotEqual(originalCar.CarId.Number, clonedCar.CarId.Number);
    }

    [Test]
    public void Car_ShallowCopy_ShouldShareReferenceForCarId()
    {
        var originalCar = new Car.Car
        {
            Brand = "Toyota",
            Year = 2020,
            Color = "Red",
            Price = 30000,
            Clearance = 150,
            CarId = new IdNumber(12345)
        };

        var shallowCopy = originalCar.ShallowCopy();

        Assert.AreEqual(originalCar.Brand, shallowCopy.Brand);
        Assert.AreEqual(originalCar.Year, shallowCopy.Year);
        Assert.AreEqual(originalCar.Color, shallowCopy.Color);
        Assert.AreEqual(originalCar.Price, shallowCopy.Price);
        Assert.AreEqual(originalCar.Clearance, shallowCopy.Clearance);
        Assert.AreEqual(originalCar.CarId.Number, shallowCopy.CarId.Number);

        shallowCopy.CarId.Number = 67890;

        Assert.AreEqual(originalCar.CarId.Number, shallowCopy.CarId.Number);
    }

    [Test]
    public void Car_RandomInit_ShouldSetValidValues()
    {
        var car = new Car.Car();
        car.RandomInit();

        Assert.IsNotNull(car.Brand);
        Assert.IsTrue(car.Year >= 1990 && car.Year <= DateTime.Now.Year);
        Assert.IsNotNull(car.Color);
        Assert.IsTrue(car.Price > 0);
        Assert.IsTrue(car.Clearance >= 100 && car.Clearance <= 300);
    }

    // Тесты для класса BigCar
    [Test]
    public void BigCar_Clone_ShouldCreateDeepCopy()
    {
        var originalCar = new BigCar
        {
            Brand = "Jeep",
            Year = 2021,
            Color = "Black",
            Price = 50000,
            Clearance = 200,
            AllWheelDrive = true,
            OffRoadType = "Лес"
        };

        var clonedCar = (BigCar)originalCar.Clone();

        Assert.AreEqual(originalCar.Brand, clonedCar.Brand);
        Assert.AreEqual(originalCar.Year, clonedCar.Year);
        Assert.AreEqual(originalCar.Color, clonedCar.Color);
        Assert.AreEqual(originalCar.Price, clonedCar.Price);
        Assert.AreEqual(originalCar.Clearance, clonedCar.Clearance);
        Assert.AreEqual(originalCar.AllWheelDrive, clonedCar.AllWheelDrive);
        Assert.AreEqual(originalCar.OffRoadType, clonedCar.OffRoadType);

        clonedCar.Brand = "BMW";
        clonedCar.OffRoadType = "Песок";

        Assert.AreNotEqual(originalCar.Brand, clonedCar.Brand);
        Assert.AreNotEqual(originalCar.OffRoadType, clonedCar.OffRoadType);
    }

    [Test]
    public void BigCar_RandomInit_ShouldSetValidValues()
    {
        var bigCar = new BigCar();
        bigCar.RandomInit();

        Assert.IsNotNull(bigCar.Brand);
        Assert.IsTrue(bigCar.Year >= 1990 && bigCar.Year <= DateTime.Now.Year);
        Assert.IsNotNull(bigCar.Color);
        Assert.IsTrue(bigCar.Price > 0);
        Assert.IsTrue(bigCar.Clearance >= 100 && bigCar.Clearance <= 300);
        Assert.IsTrue(new[] { "Лес", "Песок", "Грязь", "Снег" }.Contains(bigCar.OffRoadType));
    }

    // Тесты для класса DeliveryCar
    [Test]
    public void DeliveryCar_Clone_ShouldCreateDeepCopy()
    {
        var originalCar = new DeliveryCar
        {
            Brand = "Volvo",
            Year = 2019,
            Color = "White",
            Price = 40000,
            Clearance = 180,
            LoadCapacity = 10
        };

        var clonedCar = (DeliveryCar)originalCar.Clone();

        Assert.AreEqual(originalCar.Brand, clonedCar.Brand);
        Assert.AreEqual(originalCar.Year, clonedCar.Year);
        Assert.AreEqual(originalCar.Color, clonedCar.Color);
        Assert.AreEqual(originalCar.Price, clonedCar.Price);
        Assert.AreEqual(originalCar.Clearance, clonedCar.Clearance);
        Assert.AreEqual(originalCar.LoadCapacity, clonedCar.LoadCapacity);

        clonedCar.LoadCapacity = 15;

        Assert.AreNotEqual(originalCar.LoadCapacity, clonedCar.LoadCapacity);
    }
    

    // Тесты для класса LightCar
    [Test]
    public void LightCar_Clone_ShouldCreateDeepCopy()
    {
        var originalCar = new LightCar
        {
            Brand = "Audi",
            Year = 2022,
            Color = "Blue",
            Price = 35000,
            Clearance = 160,
            SeatCount = 5,
            MaxSpeed = 220
        };

        var clonedCar = (LightCar)originalCar.Clone();

        Assert.AreEqual(originalCar.Brand, clonedCar.Brand);
        Assert.AreEqual(originalCar.Year, clonedCar.Year);
        Assert.AreEqual(originalCar.Color, clonedCar.Color);
        Assert.AreEqual(originalCar.Price, clonedCar.Price);
        Assert.AreEqual(originalCar.Clearance, clonedCar.Clearance);
        Assert.AreEqual(originalCar.SeatCount, clonedCar.SeatCount);
        Assert.AreEqual(originalCar.MaxSpeed, clonedCar.MaxSpeed);

        clonedCar.SeatCount = 7;
        clonedCar.MaxSpeed = 250;

        Assert.AreNotEqual(originalCar.SeatCount, clonedCar.SeatCount);
        Assert.AreNotEqual(originalCar.MaxSpeed, clonedCar.MaxSpeed);
    }

    [Test]
    public void LightCar_RandomInit_ShouldSetValidValues()
    {
        var lightCar = new LightCar();
        lightCar.RandomInit();

        Assert.IsNotNull(lightCar.Brand);
        Assert.IsTrue(lightCar.Year >= 1990 && lightCar.Year <= DateTime.Now.Year);
        Assert.IsNotNull(lightCar.Color);
        Assert.IsTrue(lightCar.Price > 0);
        Assert.IsTrue(lightCar.Clearance >= 100 && lightCar.Clearance <= 300);
        Assert.IsTrue(lightCar.SeatCount >= 2 && lightCar.SeatCount <= 7);
        Assert.IsTrue(lightCar.MaxSpeed >= 100 && lightCar.MaxSpeed <= 300);
    }
    
    [Test]
    public void Car_Brand_ShouldThrowException_WhenEmpty()
    {
        var car = new Car.Car();
        Assert.Throws<ArgumentException>(() => car.Brand = "");
    }

    [Test]
    public void Car_Year_ShouldThrowException_WhenOutOfRange()
    {
        var car = new Car.Car();
        Assert.Throws<ArgumentException>(() => car.Year = 1899);
        Assert.Throws<ArgumentException>(() => car.Year = DateTime.Now.Year + 1);
    }

    [Test]
    public void Car_Price_ShouldThrowException_WhenNegative()
    {
        var car = new Car.Car();
        Assert.Throws<ArgumentException>(() => car.Price = -1);
    }

    [Test]
    public void Car_Clearance_ShouldThrowException_WhenNegative()
    {
        var car = new Car.Car();
        Assert.Throws<ArgumentException>(() => car.Clearance = -1);
    }
    
    [Test]
    public void BigCar_OffRoadType_ShouldThrowException_WhenEmpty()
    {
        var bigCar = new BigCar();
        Assert.Throws<ArgumentException>(() => bigCar.OffRoadType = "");
    }
    
    [Test]
    public void DeliveryCar_LoadCapacity_ShouldThrowException_WhenNegative()
    {
        var deliveryCar = new DeliveryCar();
        Assert.Throws<ArgumentException>(() => deliveryCar.LoadCapacity = -1);
    }
    
    [Test]
    public void LightCar_SeatCount_ShouldThrowException_WhenOutOfRange()
    {
        var lightCar = new LightCar();
        Assert.Throws<ArgumentException>(() => lightCar.SeatCount = 1);
        Assert.Throws<ArgumentException>(() => lightCar.SeatCount = 8);
    }

    [Test]
    public void LightCar_MaxSpeed_ShouldThrowException_WhenOutOfRange()
    {
        var lightCar = new LightCar();
        Assert.Throws<ArgumentException>(() => lightCar.MaxSpeed = 99);
        Assert.Throws<ArgumentException>(() => lightCar.MaxSpeed = 301);
    }
    
    [Test]
    public void GetMostExpensiveBigCar_ShouldReturnNull_WhenNoBigCars()
    {
        var cars = new Car.Car[] { new Car.Car(), new LightCar() };
        var result = Car.Car.GetMostExpensiveBigCar(cars);
        Assert.IsNull(result);
    }

    [Test]
    public void GetMostExpensiveBigCar_ShouldReturnCorrectCar()
    {
        var bigCar1 = new BigCar { Price = 50000 };
        var bigCar2 = new BigCar { Price = 60000 };
        var cars = new Car.Car[] { bigCar1, bigCar2 };

        var result = Car.Car.GetMostExpensiveBigCar(cars);
        Assert.AreEqual(bigCar2, result);
    }
    
    [Test]
    public void GetAverageSpeedOfLightCars_ShouldReturnZero_WhenNoLightCars()
    {
        var cars = new Car.Car[] { new Car.Car(), new BigCar() };
        var result = Car.Car.GetAverageSpeedOfLightCars(cars);
        Assert.AreEqual(0, result);
    }

    [Test]
    public void GetAverageSpeedOfLightCars_ShouldCalculateAverage()
    {
        var lightCar1 = new LightCar { MaxSpeed = 200 };
        var lightCar2 = new LightCar { MaxSpeed = 240 };
        var cars = new Car.Car[] { lightCar1, lightCar2 };

        var result = Car.Car.GetAverageSpeedOfLightCars(cars);
        Assert.AreEqual(220, result);
    }
    
    // Тест: Массив содержит только LightCar
        [Test]
        public void GetAverageSpeedOfLightCars_ShouldCalculateCorrectAverage()
        {
            var lightCar1 = new LightCar { MaxSpeed = 200 };
            var lightCar2 = new LightCar { MaxSpeed = 240 };
            var cars = new Car.Car[] { lightCar1, lightCar2 };

            var result = Car.Car.GetAverageSpeedOfLightCars(cars);

            Assert.AreEqual(220, result);
        }

        // Тест: Массив содержит LightCar и другие типы автомобилей
        [Test]
        public void GetAverageSpeedOfLightCars_ShouldIgnoreNonLightCars()
        {
            var lightCar1 = new LightCar { MaxSpeed = 200 };
            var bigCar = new BigCar();
            var deliveryCar = new DeliveryCar();
            var cars = new Car.Car[] { lightCar1, bigCar, deliveryCar };

            var result = Car.Car.GetAverageSpeedOfLightCars(cars);

            Assert.AreEqual(200, result);
        }

        // Тест: Массив пуст
        [Test]
        public void GetAverageSpeedOfLightCars_ShouldReturnZero_WhenArrayIsEmpty()
        {
            var cars = new Car.Car[0];

            var result = Car.Car.GetAverageSpeedOfLightCars(cars);

            Assert.AreEqual(0, result);
        }

        // Тест: Массив содержит один LightCar
        [Test]
        public void GetAverageSpeedOfLightCars_ShouldReturnSingleValue_WhenOneLightCar()
        {
            var lightCar = new LightCar { MaxSpeed = 250 };
            var cars = new Car.Car[] { lightCar };

            var result = Car.Car.GetAverageSpeedOfLightCars(cars);

            Assert.AreEqual(250, result);
        }

        // Тест: Массив содержит несколько LightCar с одинаковой скоростью
        [Test]
        public void GetAverageSpeedOfLightCars_ShouldReturnSameValue_WhenAllLightCarsHaveSameSpeed()
        {
            var lightCar1 = new LightCar { MaxSpeed = 200 };
            var lightCar2 = new LightCar { MaxSpeed = 200 };
            var lightCar3 = new LightCar { MaxSpeed = 200 };
            var cars = new Car.Car[] { lightCar1, lightCar2, lightCar3 };

            var result = Car.Car.GetAverageSpeedOfLightCars(cars);

            Assert.AreEqual(200, result);
        }
        
        // Тест: Массив содержит только DeliveryCar с подходящей грузоподъёмностью
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldReturnAllMatchingTrucks()
        {
            var truck1 = new DeliveryCar { LoadCapacity = 15 };
            var truck2 = new DeliveryCar { LoadCapacity = 20 };
            var cars = new Car.Car[] { truck1, truck2 };

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.AreEqual(2, result.Length);
            Assert.Contains(truck1, result);
            Assert.Contains(truck2, result);
        }

        // Тест: Массив содержит DeliveryCar с разной грузоподъёмностью
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldReturnOnlyMatchingTrucks()
        {
            var truck1 = new DeliveryCar { LoadCapacity = 8 };
            var truck2 = new DeliveryCar { LoadCapacity = 15 };
            var cars = new Car.Car[] { truck1, truck2 };

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.AreEqual(1, result.Length);
            Assert.Contains(truck2, result);
        }

        // Тест: Массив пуст
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldReturnEmptyArray_WhenArrayIsEmpty()
        {
            var cars = new Car.Car[0];

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.IsEmpty(result);
        }

        // Тест: Массив не содержит DeliveryCar
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldReturnEmptyArray_WhenNoDeliveryCars()
        {
            var bigCar = new BigCar();
            var lightCar = new LightCar();
            var cars = new Car.Car[] { bigCar, lightCar };

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.IsEmpty(result);
        }

        // Тест: Массив содержит DeliveryCar, но ни один не соответствует порогу
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldReturnEmptyArray_WhenNoTrucksMatchThreshold()
        {
            var truck1 = new DeliveryCar { LoadCapacity = 5 };
            var truck2 = new DeliveryCar { LoadCapacity = 8 };
            var cars = new Car.Car[] { truck1, truck2 };

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.IsEmpty(result);
        }

        // Тест: Массив содержит DeliveryCar с грузоподъёмностью, равной порогу
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldExcludeTrucksWithEqualLoadCapacity()
        {
            var truck1 = new DeliveryCar { LoadCapacity = 10 };
            var truck2 = new DeliveryCar { LoadCapacity = 15 };
            var cars = new Car.Car[] { truck1, truck2 };

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.AreEqual(1, result.Length);
            Assert.Contains(truck2, result);
        }

        // Тест: Массив содержит DeliveryCar и другие типы автомобилей
        [Test]
        public void GetTrucksWithLoadCapacityAbove_ShouldIgnoreNonDeliveryCars()
        {
            var truck1 = new DeliveryCar { LoadCapacity = 15 };
            var bigCar = new BigCar();
            var lightCar = new LightCar();
            var cars = new Car.Car[] { truck1, bigCar, lightCar };

            var result = Car.Car.GetTrucksWithLoadCapacityAbove(cars, 10);

            Assert.AreEqual(1, result.Length);
            Assert.Contains(truck1, result);
        }
        
        [Test]
        public void LightCar_Init_ShouldSetValidValues()
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw); // Перехватываем вывод консоли

                using (var sr = new System.IO.StringReader("Audi\n2022\nBlue\n35000\n160\n5\n220\n"))
                {
                    Console.SetIn(sr); // Подставляем входные данные

                    var lightCar = new LightCar();
                    lightCar.Init();

                    Assert.AreEqual("Audi", lightCar.Brand);
                    Assert.AreEqual(2022, lightCar.Year);
                    Assert.AreEqual("Blue", lightCar.Color);
                    Assert.AreEqual(35000, lightCar.Price);
                    Assert.AreEqual(160, lightCar.Clearance);
                    Assert.AreEqual(5, lightCar.SeatCount);
                    Assert.AreEqual(220, lightCar.MaxSpeed);
                }
            }
        }
    
        [Test]
        public void LightCar_IRandomInit_ShouldSetRandomValues()
        {
            var lightCar = new LightCar();
            lightCar.IRandomInit();

            Assert.IsNotNull(lightCar.Brand);
            Assert.IsTrue(lightCar.Year >= 1990 && lightCar.Year <= DateTime.Now.Year);
            Assert.IsNotNull(lightCar.Color);
            Assert.IsTrue(lightCar.Price > 0);
            Assert.IsTrue(lightCar.Clearance >= 100 && lightCar.Clearance <= 300);
            Assert.IsTrue(lightCar.SeatCount >= 2 && lightCar.SeatCount <= 7);
            Assert.IsTrue(lightCar.MaxSpeed >= 100 && lightCar.MaxSpeed <= 300);
        }
        
        [Test]
        public void BigCar_Init_ShouldSetValidValues()
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw); // Перехватываем вывод консоли

                using (var sr = new System.IO.StringReader("Jeep\n2021\nBlack\n50000\n200\ntrue\nЛес\n"))
                {
                    Console.SetIn(sr); // Подставляем входные данные

                    var bigCar = new BigCar();
                    bigCar.Init();

                    Assert.AreEqual("Jeep", bigCar.Brand);
                    Assert.AreEqual(2021, bigCar.Year);
                    Assert.AreEqual("Black", bigCar.Color);
                    Assert.AreEqual(50000, bigCar.Price);
                    Assert.AreEqual(200, bigCar.Clearance);
                    Assert.IsTrue(bigCar.AllWheelDrive);
                    Assert.AreEqual("Лес", bigCar.OffRoadType);
                }
            }
        }
        
        [Test]
        public void BigCar_Equals_ShouldReturnTrue_ForIdenticalObjects()
        {
            var car1 = new BigCar { Brand = "Jeep", Year = 2021, AllWheelDrive = true, OffRoadType = "Лес" };
            var car2 = new BigCar { Brand = "Jeep", Year = 2021, AllWheelDrive = true, OffRoadType = "Лес" };

            Assert.IsTrue(car1.Equals(car2));
        }

        [Test]
        public void BigCar_Equals_ShouldReturnFalse_ForDifferentObjects()
        {
            var car1 = new BigCar { Brand = "Jeep", Year = 2021, AllWheelDrive = true, OffRoadType = "Лес" };
            var car2 = new BigCar { Brand = "Toyota", Year = 2021, AllWheelDrive = true, OffRoadType = "Лес" };

            Assert.IsFalse(car1.Equals(car2));
        }
        
        [Test]
        public void DeliveryCar_Init_ShouldSetValidValues()
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw); // Перехватываем вывод консоли

                using (var sr = new System.IO.StringReader("Volvo\n2019\nWhite\n40000\n180\n10\n"))
                {
                    Console.SetIn(sr); // Подставляем входные данные

                    var deliveryCar = new DeliveryCar();
                    deliveryCar.Init();

                    Assert.AreEqual("Volvo", deliveryCar.Brand);
                    Assert.AreEqual(2019, deliveryCar.Year);
                    Assert.AreEqual("White", deliveryCar.Color);
                    Assert.AreEqual(40000, deliveryCar.Price);
                    Assert.AreEqual(180, deliveryCar.Clearance);
                    Assert.AreEqual(10, deliveryCar.LoadCapacity);
                }
            }
        }
}

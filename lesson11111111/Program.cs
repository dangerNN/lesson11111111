namespace lesson11111111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            double distance = 120.0; 
            double time = 2.0;      
            double speed = distance / time;
            Console.WriteLine($"1. Середн'я швидкість: {speed} км/ч");

            // Задание 2
            double loanAmount = 100000;
            double annualInterestRate = 10;
            int loanTerm = 5;

            double monthlyRate = annualInterestRate / 12 / 100;
            int totalMonths = loanTerm * 12;
            double monthlyPayment = loanAmount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -totalMonths));
            Console.WriteLine($"2. Щомісячний платіж: {monthlyPayment:F2} ₴");


            // Задание 3
            double salary = 20000;
            double bonusPercentage = 10;
            double bonus = salary * bonusPercentage / 100;
            Console.WriteLine($"3. Бонус до зарплати: {bonus} ₴");


            // Задание 4
            double triangleBase = 10;
            double height = 5;
            double area = 0.5 * triangleBase * height;
            Console.WriteLine($"4. Площадь трикутника: {area}");

            // Задание 5
            double income = 25000;
            double taxRate = 18; // например, 18% в Украине
            double tax = income * taxRate / 100;
            Console.WriteLine($"5. Сума податку: {tax} ₴");


            // Задание 6
            double distance1 = 60, time1 = 1;
            double distance2 = 90, time2 = 1.5;
            double speed1 = distance1 / time1;
            double speed2 = distance2 / time2;
            double totalSpeed = (distance1 + distance2) / (time1 + time2);
            Console.WriteLine($"6. Скорость этап 1: {speed1}, этап 2: {speed2}, общая: {totalSpeed}");

            // Задание 7
            double currentFuelLevel = 20;
            double fuelConsumption = 8; // витрата палива на 100 км
            double distanceCanDrive = currentFuelLevel / fuelConsumption * 100;
            Console.WriteLine($"7. Можливо проїхати : {distanceCanDrive} км");

            // Задание 8
            double originalPrice = 1500;
            double discountPercentage = 20;
            double discount = originalPrice * discountPercentage / 100;
            double finalPrice = originalPrice - discount;
            Console.WriteLine($"8. Знижка: {discount} ₴, остаточна ціна: {finalPrice} ₴");


            // Задание 9
            double part = 30;
            double whole = 200;
            double percent = part / whole * 100;
            Console.WriteLine($"9. Відсоток: {percent}%");

            // Задание 10
            double score1 = 4.5, score2 = 5, score3 = 3.5;
            double avgScore = (score1 + score2 + score3) / 3;
            Console.WriteLine($"10. Середня оцінка: {avgScore:F2}");

            // Задание 11
            double dailyExpenses = 200; // в день
            int daysInMonth = 30;
            double totalFoodExpenses = dailyExpenses * daysInMonth;
            Console.WriteLine($"11. Витрати на їжу за місяць: {totalFoodExpenses} ₴");


            // Задание 12
            double amountInUSD = 100;
            double exchangeRate = 39.5; // курс доллара к гривне, например
            double amountInUAH = amountInUSD * exchangeRate;
            Console.WriteLine($"12. Сума в гривнях: {amountInUAH} ₴");


            // Задание 13
            double earthWeight = 60;
            double moonWeight = earthWeight * (1.0 / 6);
            Console.WriteLine($"13. Вага на Луні: {moonWeight} кг");

            // Задание 14
            double baseNumber = 2;
            int exponent = 5;
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"14. {baseNumber}^{exponent} = {result}");

            // Задание 15
            int number1 = 10;
            int number2 = 20;

            if (number1 > number2)
                Console.WriteLine("15. перше число більше за друге число");
            else if (number1 < number2)
                Console.WriteLine("15. перше число меньше за друге число");
            else
                Console.WriteLine("15. Числа рівні");




















        }
    }
}

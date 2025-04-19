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
            Console.WriteLine($"1. Средняя скорость: {speed} км/ч");

            // Задание 2
            double loanAmount = 100000;
            double annualInterestRate = 10;
            int loanTerm = 5;

            double monthlyRate = annualInterestRate / 12 / 100;
            int totalMonths = loanTerm * 12;
            double monthlyPayment = loanAmount * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -totalMonths));
            Console.WriteLine($"2. Ежемесячный платёж: {monthlyPayment:F2} гривен.");

            // Задание 3
            double salary = 50000;
            double bonusPercentage = 15;
            double bonus = salary * bonusPercentage / 100;
            Console.WriteLine($"3. Бонус к зарплате: {bonus} гривен.");

            // Задание 4
            double triangleBase = 10;
            double height = 5;
            double area = 0.5 * triangleBase * height;
            Console.WriteLine($"4. Площадь треугольника: {area}");

            // Задание 5
            double income = 60000;
            double taxRate = 13;
            double tax = income * taxRate / 100;
            Console.WriteLine($"5. Налог: {tax} гривен.");

            // Задание 6
            double distance1 = 60, time1 = 1;
            double distance2 = 90, time2 = 1.5;
            double speed1 = distance1 / time1;
            double speed2 = distance2 / time2;
            double totalSpeed = (distance1 + distance2) / (time1 + time2);
            Console.WriteLine($"6. Скорость этап 1: {speed1}, этап 2: {speed2}, общая: {totalSpeed}");

            // Задание 7
            double currentFuelLevel = 20;
            double fuelConsumption = 8; // расход на 100 км
            double distanceCanDrive = currentFuelLevel / fuelConsumption * 100;
            Console.WriteLine($"7. Можно проехать: {distanceCanDrive} км");

            // Задание 8
            double originalPrice = 2000;
            double discountPercentage = 25;
            double discount = originalPrice * discountPercentage / 100;
            double finalPrice = originalPrice - discount;
            Console.WriteLine($"8. Скидка: {discount}, финальная цена: {finalPrice}");

            // Задание 9
            double part = 30;
            double whole = 200;
            double percent = part / whole * 100;
            Console.WriteLine($"9. Процент: {percent}%");

            // Задание 10
            double score1 = 4.5, score2 = 5, score3 = 3.5;
            double avgScore = (score1 + score2 + score3) / 3;
            Console.WriteLine($"10. Средняя оценка: {avgScore:F2}");

            // Задание 11
            double dailyExpenses = 300;
            int daysInMonth = 30;
            double totalFoodExpenses = dailyExpenses * daysInMonth;
            Console.WriteLine($"11. Расходы на еду: {totalFoodExpenses} грн.");

            // Задание 12
            double amountInUSD = 100;
            double exchangeRate = 55;
            double amountInRUB = amountInUSD * exchangeRate;
            Console.WriteLine($"12. Сумма в гривнах: {amountInRUB}");

            // Задание 13
            double earthWeight = 60;
            double moonWeight = earthWeight * (1.0 / 6);
            Console.WriteLine($"13. Вес на Луне: {moonWeight} кг");

            // Задание 14
            double baseNumber = 2;
            int exponent = 5;
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"14. {baseNumber}^{exponent} = {result}");

            // Задание 15
            int number1 = 10;
            int number2 = 20;

            if (number1 > number2)
                Console.WriteLine("15. первое число больше второго числа");
            else if (number1 < number2)
                Console.WriteLine("15. первое число меньше второго числа");
            else
                Console.WriteLine("15. Числа равны");




















        }
    }
}

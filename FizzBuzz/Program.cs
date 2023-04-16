const int countTo = 100;
FizzBuzzCalc(1, countTo);

void FizzBuzzCalc(int number, int count)
{
    var divisbleByThree = IsDivisble(number, 3, "Fizz");
    var divisbleByFive = IsDivisble(number, 5, "Buzz");
    
    var shoutOut = !string.IsNullOrEmpty(divisbleByThree) || !string.IsNullOrEmpty(divisbleByFive) ? $"{divisbleByThree}{divisbleByFive}" : number.ToString();
    Console.WriteLine(shoutOut);

    if (number < count) FizzBuzzCalc(number+1, count);
}

string IsDivisble(int number, int divider, string text)
{
    return number % divider == 0 ? text : string.Empty;
}

namespace Project2
{
    public class Class1
    {
        public bool isANumber(string value)
        {
            double doubleVal;
            return double.TryParse(value, out doubleVal);
        }

        public bool isAPrimeNumber(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}

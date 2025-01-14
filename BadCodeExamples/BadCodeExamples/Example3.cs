namespace BadCodeExamples
{
    public class Class1
    {
        public decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100; // Рекомендуется сначала привести years к типу decimal перед делением
            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            //легче написать перменную и в ней хранить "0.1m * amount", чем каждый раз переписывать данное выражение 
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }
    }
}

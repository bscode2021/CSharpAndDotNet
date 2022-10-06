using static System.Console;

static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");

    for (int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
}

//TimesTable(10);

static decimal CalculateTax(decimal amount, string twoLetterRegionalCode)
{
    decimal rate = 0.0M;

    switch (twoLetterRegionalCode.ToUpper())
    {
        case "CH": // Switzerland
            {
                rate = 0.08M;
                break;
            }
        case "DK": // Denmark
        case "NO": // Norway
            {
                rate = 0.25M;
                break;
            }
        case "GB": // United Kingdom
        case "FR": // France
            {
                rate = 0.2M;
                break;
            }
        case "HU": // Hungary
            {
                rate = 0.27M;
                break;
            }
        case "OR": // Oregon
        case "AK": // Alaska
        case "MT": // Montana
            {
                rate = 0.0M;
                break;
            }
        case "ND": // North Dakota
        case "WI": // Wisconsin
        case "ME": // Main
            {
                rate = 0.08M;
                break;
            }
        case "VA": // Virginia
            {
                rate = 0.05M;
                break;
            }
        case "CA": // California
            {
                rate = 0.0825M;
                break;
            }
        default: // Most US states
            {
                rate = 0.06M;
                break;
            }
    }

    return amount * rate;
}

//int productValue1 = 50;
//decimal tax1 = CalculateTax(productValue1, "hu");
//WriteLine($"The value plus tax for the product in Hungary is: {productValue1 + tax1}");

//decimal tax2 = CalculateTax( twoLetterRegionalCode: "FR", amount: 149);
//WriteLine($"The value plus tax for the product in Oragon is: {149 + tax2}");

//
// Summary:
//     Pass a 32-bit integer and it will be converted into its ordinal equivalent.
//
// Parameters:
//   newIn:
//     A stream that is the new standard input.
//
// Exceptions:
//   T:System.ArgumentNullException:
//     newIn is null.
//
//   T:System.Security.SecurityException:
//     The caller does not have the required permission.
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lasDigit = number % 10;
            string sufix = lasDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
         return $"{number}{sufix}";
    }
}

/// <summary>
/// asdasd
/// </summary>
static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 40; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    ReadLine();
}

RunCardinalToOrdinal();

static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked // for overflow
        {
            int returnVal = Factorial(number - 1);
            int res = number * returnVal;
            return res;
        }
    }
}

static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (OverflowException ex)
        {
            WriteLine($"{i}! is too big for a 32-bit integer.");
        }
        catch (Exception ex)
        {
            throw;
        }
       
    }
}

RunFactorial();
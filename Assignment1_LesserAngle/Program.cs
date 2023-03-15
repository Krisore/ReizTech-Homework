

const double HOUR_HAND_PER_HOUR = 360 / 12.0;
const double MINUTE_HAND_PER_MINUTE = 360 / 60.0;

try
{
    int hours = ValidateUserInput("Enter the hour (1-23): ", 1, 12);
    int minutes = ValidateUserInput("Enter the minute (0-59): ", 0, 59);

    double lesserAngle = CalculateLesserAngle(hours, minutes);
    Console.WriteLine($"The lesser angle between the hour and minute hand is {lesserAngle} degrees.");
}
catch(Exception ex)
{
    Console.WriteLine($"{ex.Message} \nPlease enter the hours in 12-hour clock format without any decimals,for example, '01', '02', '03', ..., '11', '12'. \nThank you.");
}

static int ValidateUserInput(string promptMessage, int minRange, int maxRange)
{
    while (true)
    {
        Console.Write(promptMessage);
        if (int.TryParse(Console.ReadLine(), out int input) && input >= minRange && input <= maxRange)
        {
            return input;
        }
        Console.WriteLine($"Invalid input. Please enter a valid number ({minRange}-{maxRange}).");
    }
}

static double CalculateLesserAngle(int hours, int minutes) 
{
    double hourAngle =  (hours % 12 + minutes / 60.0) * HOUR_HAND_PER_HOUR;
    double minuteAngle = minutes * MINUTE_HAND_PER_MINUTE;
    double angleDiff = Math.Abs(hourAngle - minuteAngle);
    return Math.Min(angleDiff, 360 - angleDiff);
}
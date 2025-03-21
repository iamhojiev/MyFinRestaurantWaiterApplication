using MyFinCassa.Model;
using System;

namespace MyFinCassa.Helper
{
    public static class HallPriceCalculator
    {
        public static (double Price, string Time) CalculatePrice(Hall hall, DateTime orderDate)
        {
            var now = DateTime.Now;
            TimeSpan difference = now - orderDate;
            var minutesElapsed = difference.TotalMinutes;
            var minuteBonus = hall.hall_bonus;

            if (minutesElapsed > minuteBonus)
            {
                double hallPrice = Math.Round(((minutesElapsed - minuteBonus) / 60) * hall.hall_price, 2);
                string formattedTime = $"{difference.Hours:D2}ч:{difference.Minutes:D2}м";
                return (hallPrice, formattedTime);
            }
            return (0.0, "00ч:00м");
        }
    }

}

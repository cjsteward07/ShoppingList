using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class UserPurchase
    {
        private int breadCount = 0;
        private decimal totalBreadPrice = 0;
        private int milkCount = 0;
        private decimal totalMilkPrice = 0;
        private int eggsCount = 0;
        private decimal totalEggsPrice = 0;
        private int baconCount = 0;
        private decimal totalBaconPrice = 0;
        private int appleCount = 0;
        private decimal totalApplePrice = 0;
        private int steakCount = 0;
        private decimal totalSteakPrice = 0;
        private int carrotsCount = 0;
        private decimal totalCarrotsPrice = 0;
        private int cornCount = 0;
        private decimal totalCornPrice = 0;
        public string UserItem { get; set; }
        public decimal UserItemPrice { get; set; }

        public UserPurchase()
        {

        }

        public void UserItemCount(string item, decimal itemPrice)
        {
            if (item == "Bread")
            {
                breadCount++;
                totalBreadPrice = itemPrice * breadCount;
            }
            if (item == "Milk")
            {
                milkCount++;
                totalMilkPrice = itemPrice * milkCount;
            }
            if (item == "Eggs")
            {
                eggsCount++;
                totalEggsPrice = itemPrice * eggsCount;
            }
            if (item == "Bacon")
            {
                baconCount++;
                totalBaconPrice = itemPrice * baconCount;
            }
            if (item == "Apple")
            {
                appleCount++;
                totalApplePrice = itemPrice * appleCount;
            }
            if (item == "Steak")
            {
                steakCount++;
                totalSteakPrice = itemPrice * steakCount;
            }
            if (item == "Carrots")
            {
                carrotsCount++;
                totalCarrotsPrice = itemPrice * carrotsCount;
            }
            if (item == "Corn")
            {
                cornCount++;
                totalCornPrice = itemPrice * cornCount;
            }
        }

        public void ReturnTest()
        {
            Console.WriteLine("\n-------------------");
            Console.WriteLine("Shopping Cart:");
            Console.WriteLine("-------------------");
            if (breadCount > 0)
            {
                Console.WriteLine($"{breadCount} x Bread = ${totalBreadPrice}");
            }
            if (milkCount > 0)
            {
                Console.WriteLine($"{milkCount} x Milk = ${totalMilkPrice}");
            }
            if (eggsCount > 0)
            {
                Console.WriteLine($"{eggsCount} x Eggs = ${totalEggsPrice}");
            }
            if (baconCount > 0)
            {
                Console.WriteLine($"{baconCount} x Bacon = ${totalBaconPrice}");
            }
            if (appleCount > 0)
            {
                Console.WriteLine($"{appleCount} x Apple = ${totalApplePrice}");
            }
            if (steakCount > 0)
            {
                Console.WriteLine($"{steakCount} x Steak = ${totalSteakPrice}");
            }
            if (carrotsCount > 0)
            {
                Console.WriteLine($"{carrotsCount} x Carrots = ${totalCarrotsPrice}");
            }
            if (cornCount > 0)
            {
                Console.WriteLine($"{cornCount} x Corn = ${totalCornPrice}");
            }
        }

        public decimal UserPurchaseTotal(List<UserPurchase> userItemObjectList)
        {
            decimal total = 0;
            foreach (var listItem in userItemObjectList)
            {
                total = total + listItem.UserItemPrice;
            }
            return Math.Round(total, 2);
        }

        public decimal UserPurchaseAverage(List<UserPurchase> userItemObjectList)
        {
            decimal average = 0;
            foreach (var listItem in userItemObjectList)
            {
                average = UserPurchaseTotal(userItemObjectList) / userItemObjectList.Count;
            }
            return Math.Round(average, 2);
        }
    }
}
using ShoppingList;

UserPurchase userItem = new UserPurchase();

List<UserPurchase> userItemObjectList = new List<UserPurchase>();
Dictionary<string, decimal> menuDict = new Dictionary<string, decimal>()
{
    {"Bread", 1.99m},
    {"Milk", 3.99m},
    {"Eggs", 1.89m},
    {"Bacon", 4.79m},
    {"Apple", .35m},
    {"Steak", 12.65m},
    {"Carrots", .65m},
    {"Corn", .89m}
};

bool runAgain = true;

while (runAgain)
{

    UtilitiesClass.Menu(menuDict);

    string userPurchase = UtilitiesClass.ItemInputFormatter();
    var userPurchaseFilter = menuDict
        .Where(x => x.Key.Contains(userPurchase));

    if (userPurchaseFilter.Count() == 0)
    {
        Console.Clear();
        Console.WriteLine($"'{userPurchase}' is invalid. Please enter a valid option from the menu\n");
        UtilitiesClass.Menu(menuDict);
    }

    foreach (var item in userPurchaseFilter)
    {
        userItemObjectList.Add(new UserPurchase
        {
            UserItem = item.Key,
            UserItemPrice = item.Value,
        });

        userItem.UserItemCount(item.Key.ToString(), item.Value);
    }

    decimal total = userItem.UserPurchaseTotal(userItemObjectList);
    decimal average = userItem.UserPurchaseAverage(userItemObjectList);
    userItem.ReturnTest();
    Console.WriteLine($"\nAverage: ${average}");
    Console.WriteLine($"Total: ${total}\n");

    runAgain = UtilitiesClass.RunAgain();
}


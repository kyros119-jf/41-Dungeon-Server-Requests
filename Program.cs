Task<int> goldTask = GetPlayerGold();
Task<int> inventoryTask = GetPlayerInventoryCount();
Task<int> levelTask = GetPlayerLevel();

// Wait for all three requests to finish
await Task.WhenAll(goldTask, inventoryTask, levelTask);

Console.WriteLine("Player Stats Loaded\n");

Console.WriteLine($"Gold: {goldTask.Result}");
Console.WriteLine($"Inventory Items: {inventoryTask.Result}");
Console.WriteLine($"Level: {levelTask.Result}");

static async Task<int> GetPlayerGold()
{
    await Task.Delay(1000);
    return 150;
}

static async Task<int> GetPlayerInventoryCount()
{
    await Task.Delay(2000);
    return 8;
}

static async Task<int> GetPlayerLevel()
{
    await Task.Delay(3000);
    return 12;
}

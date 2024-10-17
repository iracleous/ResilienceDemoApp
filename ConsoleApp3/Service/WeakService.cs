using ConsoleApp3.CustomeExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Service;

public static class WeakService
{
    public static int Counter = 1;


    public static async Task<int> GetConnectionInstance()
    {
        Counter++;
        Console.WriteLine("Tries to execute GetConnectionInstance");
        await Task.Delay(10);
        if (Counter % 4 != 0) throw new BusinessTransientException();
        Console.WriteLine("Executes GetConnectionInstance successfully");
        return 1;
    }
}
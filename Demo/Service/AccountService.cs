using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Service;

public class AccountService : IAccountService
{
    public void Reg(User user)
    {
        Console.WriteLine($"{user.Name} register successful!");
    }
}

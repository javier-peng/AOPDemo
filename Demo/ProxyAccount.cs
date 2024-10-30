using Demo.Model;
using Demo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo;

public class ProxyAccount: IAccountService
{
    private readonly IAccountService _accountService;

    public ProxyAccount()
    {
        _accountService = new AccountService();
    }

    public void Reg(User user)
    {
        Before();

        _accountService.Reg(user);

        After();
    }

    private void Before()
    {
        Console.WriteLine("Run the logic before register");
    }

    private void After()
    {
        Console.WriteLine("Run the logic after register");
    }
}

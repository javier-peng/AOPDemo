using Demo.Model;
using Demo.Service;

namespace Demo;
class Program
{
    static void Main(string[] args)
    {
        User user = new()
        {
            Name = "user",
            PassWord = "password"
        };

        #region Decorator
        IAccountService accountService = new AccountService();
        AccountDecorator accountDecorator = new(accountService);
        accountDecorator.Reg(user);
        #endregion

        #region Proxy
        ProxyAccount proxyAccount = new();
        proxyAccount.Reg(user);
        #endregion
    }
}
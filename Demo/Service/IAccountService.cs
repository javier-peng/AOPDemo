using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Service;

public interface IAccountService
{
    /// <summary>
    /// register user
    /// </summary>
    /// <param name="user"></param>
    void Reg(User user);
}

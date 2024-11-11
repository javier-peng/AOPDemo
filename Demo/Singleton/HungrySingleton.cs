using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Singleton;

public class HungrySingleton
{
    private static HungrySingleton instance = new();

    private HungrySingleton()
    {

    }

    public static HungrySingleton GetInstance()
    {
        return instance;
    }
}

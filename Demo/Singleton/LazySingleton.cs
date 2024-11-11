using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Singleton;

public class LazySingleton
{
    private static LazySingleton instance;

    private LazySingleton() { }

    public static LazySingleton GetInstance()
    {
        if (instance == null)
        {
            instance = new LazySingleton();
        }
        return instance;
    }
}

//new version, avoid the thread safety

public class LazySingleton1
{
    private static readonly Lazy<LazySingleton1> _instance = new Lazy<LazySingleton1>(() => new LazySingleton1());
    private LazySingleton1() { }

    public static LazySingleton1 GetInstance()
    {
        return _instance.Value;
    }

}
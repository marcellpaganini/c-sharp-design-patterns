using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonPattern
    {
        private SingletonPattern() { }
        private static SingletonPattern? _instance;
        public static SingletonPattern GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonPattern();
            }
            return _instance;
        }
        public void SomeBusinessLogic()
        {

        }
    }
}

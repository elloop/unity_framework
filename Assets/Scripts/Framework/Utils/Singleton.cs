using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elloop.Utils {
    public class Singleton<T> where T : Singleton<T> {
        protected Singleton() { }
        private static T _instance;

        public static T Instance {
            get {
                if (_instance == null) {
                    _instance = System.Activator.CreateInstance<T>();
                }

                return _instance;
            }
        }
    }


    /*
     *
     *
     *
     *
     *
     * public abstract class GenericSingleton<T> where T : GenericSingleton<T>
{
  protected GenericSingleton(){}

  public static T Instance { get; } = Create();

  private static T Create()
  {
    Type t = typeof(T);
    var flags = System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic;
    var constructor = t.GetConstructor(flags, null, Type.EmptyTypes,
    null);
    var instance = constructor.Invoke(null);
    return instance as T;
  }
  ...
}

public class FirstSingleton : GenericSingleton<FirstSingleton>
{
  private FirstSingleton(){} //make sure it cannot be instantiated by using new()
}

public class AnotherSingleton : GenericSingleton<AnotherSingleton>
{
  private AnotherSingleton(){} //make sure it cannot be instantiated by using new()
}

//access it like this
FirstSingleton firstSiglenton = FirstSingleton.Instace;
AnotherSingleton anotherSingleton = AnotherSingleton.Instance;
     */
}


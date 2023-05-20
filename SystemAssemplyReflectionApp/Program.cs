using System.Reflection;

string lib = "MyLib";

Assembly assembly = Assembly.LoadFrom($"{lib}.dll");
Console.WriteLine(assembly.FullName);

Type[] types = assembly.GetTypes();
foreach (Type t in types)
    if(t.Namespace == lib)
    {
        Console.WriteLine($"{t.Name} {t.FullName}");
        //foreach (ConstructorInfo c in t.GetConstructors())
        //{
        //    Console.WriteLine($"{c.Name}");
        //    object[] arg = new object[c.GetParameters().Length];
        //    int i = 0;
        //    foreach (ParameterInfo p in c.GetParameters())
        //    {
        //        Console.Write($"{p.ParameterType.FullName} {p.Name}: ");
        //        arg[i++] = Console.ReadLine();
        //    }
        //    object? obj = c?.Invoke(arg);
        //}


        ConstructorInfo? constructor = null;
        constructor = t.GetConstructor(new Type[] { typeof(string), typeof(int) });

        object? obj = constructor?.Invoke(new object[] { "Bob", 22 });
        Console.WriteLine(obj);

        MethodInfo[] methods = t.GetMethods();
        foreach (MethodInfo m in methods)
        {
            if (m.GetParameters().Length == 0)
            {
                Console.WriteLine($"method {m.Name} run:");
                m.Invoke(obj, new object[] { });
            }
                
        }
    }
        
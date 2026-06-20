using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace ModuDevCore.PathweaveUIX.Data {
    [Serializable]
    public class ArgumentType
    {
        public string typeName;

        public static Type ToType(string fullName)
        {
            var type = Type.GetType(fullName);

            if (type != null)
                return type;

            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(fullName);
                if (type != null)
                    return type;
            }

            return null;
        }
        public static List<Type> ToTypes(string[] fullNames)
        {
            List<Type> result = new();

            if (fullNames == null)
                return result;

            foreach (var name in fullNames)
            {
                if (string.IsNullOrEmpty(name))
                    continue;

                Type type = ToType(name);

                if (type != null)
                    result.Add(type);
            }

            return result;
        }
    }
}
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ModuDevCore.PathweaveUIX.Data.Events {
    [Serializable]
    public class Listener
    {
        public GameObject target;
        public Component targetComponent;
        public string methodName;

        public static Type[] GetClasses(GameObject target)
        {
            if (target == null)
                return Array.Empty<Type>();

            return target
                .GetComponents<Component>()
                .Where(c => c != null)
                .Select(c => c.GetType())
                .Distinct()
                .ToArray();
        }
        public static MethodInfo[] FindExactMethods(
            Type type,
            Type[] argTypes)
        {
            var methods = type.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

            return methods.Where(m =>
            {
                var parameters = m.GetParameters();

                if (parameters.Length != argTypes.Length)
                    return false;

                for (int i = 0; i < parameters.Length; i++)
                {
                    Type paramType = parameters[i].ParameterType;
                    Type argType = argTypes[i];

                    if (argType == null)
                        return false;

                    // =========================
                    // EXACT MATCH OR INHERITANCE
                    // =========================
                    if (!paramType.IsAssignableFrom(argType))
                        return false;
                }

                return true;

            }).ToArray();
        }
    }
}
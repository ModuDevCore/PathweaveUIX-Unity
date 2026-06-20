using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using ModuDevCore.PathweaveUIX.Data;
using ModuDevCore.PathweaveUIX.Data.Events;

namespace ModuDevCore.PathweaveUIX.Runtime.Events {
    [Serializable]
    public class PathweaveEvent
    {
        public List<ArgumentType> _argumentTypes = new();
        public List<Listener> _listeners = new();

        public void AddListener(Component target, string methodName)
        {
            if (target == null)
                return;

            _listeners.Add(new Listener
            {
                target = target.gameObject,
                targetComponent = target,
                methodName = methodName
            });
        }

        public void RemoveListener(int index)
        {
            if (index < 0 || index >= _listeners.Count)
                return;

            _listeners.RemoveAt(index);
        }

        public void Invoke(params object[] args)
        {
            Type[] parameterTypes = _argumentTypes
                .Select(x => ArgumentType.ToType(x.typeName))
                .Where(x => x != null)
                .ToArray();

            foreach (Listener listener in _listeners)
            {
                if (listener == null)
                    continue;

                if (listener.targetComponent == null)
                    continue;

                if (string.IsNullOrEmpty(listener.methodName))
                    continue;

                MethodInfo method = listener.targetComponent
                    .GetType()
                    .GetMethod(
                        listener.methodName,
                        BindingFlags.Instance |
                        BindingFlags.Public |
                        BindingFlags.NonPublic,
                        null,
                        parameterTypes,
                        null);

                if (method == null)
                {
                    Debug.LogWarning(
                        $"Method '{listener.methodName}' with matching signature not found on " +
                        $"{listener.targetComponent.GetType().Name}");

                    continue;
                }

                try
                {
                    method.Invoke(listener.targetComponent, args);
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }
        }
    }
}
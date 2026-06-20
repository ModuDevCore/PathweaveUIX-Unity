using System;
using UnityEngine;

namespace ModuDevCore.PathweaveUIX.Data
{
    [Serializable]
    public class SerializedArgumentValue
    {
        public ArgumentType argumentType;

        public string stringValue;
        public int intValue;
        public float floatValue;
        public bool boolValue;

        public UnityEngine.Object objectValue;

        public object GetValue()
        {
            Type type = ArgumentType.ToType(argumentType.typeName);

            // =========================
            // int
            // =========================
            if (type == typeof(int))
                return intValue;

            // =========================
            // float
            // =========================
            if (type == typeof(float))
                return floatValue;

            // =========================
            // bool
            // =========================
            if (type == typeof(bool))
                return boolValue;

            // =========================
            // string
            // =========================
            if (type == typeof(string))
                return stringValue;

            // =========================
            // Vector2
            // =========================
            if (type == typeof(Vector2))
            {
                if (string.IsNullOrEmpty(stringValue))
                    return Vector2.zero;

                try
                {
                    return JsonUtility.FromJson<Vector2>(stringValue);
                }
                catch
                {
                    return Vector2.zero;
                }
            }

            // =========================
            // Vector3
            // =========================
            if (type == typeof(Vector3))
            {
                if (string.IsNullOrEmpty(stringValue))
                    return Vector3.zero;

                try
                {
                    return JsonUtility.FromJson<Vector3>(stringValue);
                }
                catch
                {
                    return Vector3.zero;
                }
            }

            // =========================
            // Unity Objects (GameObject / Component / etc.)
            // =========================
            if (typeof(UnityEngine.Object).IsAssignableFrom(type))
                return objectValue;

            // =========================
            // fallback
            // =========================
            return stringValue;
        }
    }
}
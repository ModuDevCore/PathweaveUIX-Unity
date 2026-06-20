using System;
using System.Collections.Generic;
using UnityEngine;
using ModuDevCore.PathweaveUIX;
using ModuDevCore.PathweaveUIX.Data;

namespace ModuDevCore.PathweaveUIX.Runtime.Actions
{
    [Serializable]
    public class PathweaveAction
    {
        [Serializable]
        public class MethodSignature
        {
            public List<ArgumentType> argumentTypes = new();
            public Action<object[]> action;
        }

        public enum ActionType
        {
            Navigation = 0,
            Call = 1
        }

        public PathweaveUIX PathweaveUIX => PathweaveUIX.Instance;

        public ActionType actionType;

        public string selectedAction;

        public List<SerializedArgumentValue> arguments = new();


        public Dictionary<string, MethodSignature> Actions =>
            actionType switch
            {
                ActionType.Navigation => BuildNavigationActions(),
                ActionType.Call => BuildCallActions(),
                _ => new Dictionary<string, MethodSignature>()
            };

        private Dictionary<string, MethodSignature> BuildNavigationActions()
        {
            return new Dictionary<string, MethodSignature>
            {
                {
                    nameof(PathweaveUIX.SetPage),
                    new MethodSignature
                    {
                        argumentTypes = new List<ArgumentType>
                        {
                            new ArgumentType
                            {
                                typeName = typeof(string).FullName
                            }
                        },

                        action = (args) =>
                            PathweaveUIX.SetPage((string)args[0])
                    }
                },

                {
                    nameof(PathweaveUIX.Navigate),
                    new MethodSignature
                    {
                        argumentTypes = new List<ArgumentType>
                        {
                            new ArgumentType
                            {
                                typeName = typeof(string).FullName
                            }
                        },

                        action = (args) =>
                            PathweaveUIX.Navigate((string)args[0])
                    }
                },

                {
                    nameof(PathweaveUIX.NavigateWithHash),
                    new MethodSignature
                    {
                        argumentTypes = new List<ArgumentType>
                        {
                            new ArgumentType
                            {
                                typeName = typeof(string).FullName
                            }
                        },

                        action = (args) =>
                            PathweaveUIX.NavigateWithHash((string)args[0])
                    }
                },

                {
                    nameof(PathweaveUIX.NavigateBack),
                    new MethodSignature
                    {
                        argumentTypes = new List<ArgumentType>(),

                        action = (_) =>
                            PathweaveUIX.NavigateBack()
                    }
                },

                {
                    nameof(PathweaveUIX.NavigateBackWithHash),
                    new MethodSignature
                    {
                        argumentTypes = new List<ArgumentType>(),

                        action = (_) =>
                            PathweaveUIX.NavigateBackWithHash()
                    }
                },

                {
                    nameof(PathweaveUIX.ClearHash),
                    new MethodSignature
                    {
                        argumentTypes = new List<ArgumentType>(),

                        action = (_) =>
                            PathweaveUIX.ClearHash()
                    }
                }
            };
        }

        private Dictionary<string, MethodSignature> BuildCallActions()
        {
            Dictionary<string, MethodSignature> result = new();

            if (PathweaveUIX == null || PathweaveUIX.CurrentPage == null)
                return result;

            foreach (var uiAction in PathweaveUIX.CurrentPage.actions)
            {
                if (uiAction?.uiEvent == null)
                    continue;

                result[uiAction.name] = new MethodSignature
                {
                    argumentTypes = uiAction.uiEvent._argumentTypes,

                    action = (args) =>
                        uiAction.uiEvent.Invoke(args)
                };
            }

            return result;
        }
        public void SyncArguments()
        {
            var actions = Actions;

            if (!actions.TryGetValue(selectedAction, out var signature))
            {
                arguments.Clear();
                return;
            }

            List<SerializedArgumentValue> oldArguments = new(arguments);
            List<SerializedArgumentValue> newArguments = new();

            for (int i = 0; i < signature.argumentTypes.Count; i++)
            {
                string targetType = signature.argumentTypes[i].typeName;

                SerializedArgumentValue matchedArgument = null;

                if (i < oldArguments.Count)
                {
                    SerializedArgumentValue oldArg = oldArguments[i];

                    if (oldArg != null &&
                        oldArg.argumentType.typeName == targetType)
                    {
                        matchedArgument = oldArg;
                    }
                }
                if (matchedArgument == null)
                {
                    for (int j = 0; j < oldArguments.Count; j++)
                    {
                        SerializedArgumentValue oldArg = oldArguments[j];

                        if (oldArg == null)
                            continue;

                        if (oldArg.argumentType.typeName == targetType)
                        {
                            matchedArgument = oldArg;

                            // Помечаем использованным
                            oldArguments[j] = null;

                            break;
                        }
                    }
                }
                if (matchedArgument != null)
                {
                    newArguments.Add(matchedArgument);
                }
                else
                {
                    newArguments.Add(new SerializedArgumentValue
                    {
                        argumentType = new ArgumentType() { typeName = targetType },
                        stringValue = string.Empty
                    });
                }
            }

            arguments = newArguments;
        }
        public object[] GetArgumentsArray()
        {
            object[] result = new object[arguments.Count];

            for (int i = 0; i < arguments.Count; i++)
            {
                result[i] = arguments[i].GetValue();
            }

            return result;
        }

        public void InvokeSelected()
        {
            if (string.IsNullOrEmpty(selectedAction))
                return;

            var actions = Actions;

            if (!actions.TryGetValue(selectedAction, out var signature))
                return;
            SyncArguments();

            signature.action?.Invoke(GetArgumentsArray());
        }
    }
}
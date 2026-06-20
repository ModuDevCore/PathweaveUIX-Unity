# API Reference

Here are described all **public** classes, interfaces, enumerations, and other types available for use by developers.

---

## Guide

<details>
<summary>PathweaveAction</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction)

### Fields
- [actionType](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.actionType)
- [selectedAction](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.selectedAction)
- [arguments](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.arguments)

### Properties
- [PathweaveUIX](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.PathweaveUIX)
- [Actions](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.Actions)

### Methods
- [SyncArguments](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.SyncArguments)
- [GetArgumentsArray](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.GetArgumentsArray)
- [InvokeSelected](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.InvokeSelected)

### Enumerators
- [ActionType](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.ActionType)

### Nested Classes
- [MethodSignature](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature)

</details>

<details>
<summary>PathweaveAnimatorEvents</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents)

### Fields
- [ReadyToChangeCallback](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChangeCallback)

### Properties
- [animator](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.animator)

### Methods
- [ReadyToChange](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChange)

### Enumerators
**None**

### Nested Classes
**None**

</details>

<details>
<summary>PathweaveButton</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton](#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton)

### Fields
- [action](#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.action)

### Properties
**None**

### Methods
- [OnPointerClick](#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.OnPointerClick)

### Enumerators
**None**

### Nested Classes
**None**

</details>

<details>
<summary>PathweaveEvent</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent)

### Fields
- [_argumentTypes](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._argumentTypes)
- [_listeners](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._listeners)

### Properties
**None**

### Methods
- [AddListener](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.AddListener)
- [RemoveListener](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.RemoveListener)
- [Invoke](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.Invoke)

### Enumerators
**None**

### Nested Classes
**None**

</details>

<details>
<summary>ArgumentType</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.ArgumentType](#ModuDevCore.PathweaveUIX.Data.ArgumentType)

### Fields
- [typeName](#ModuDevCore.PathweaveUIX.Data.ArgumentType.typeName)

### Properties
**None**

### Methods
- [ToType](#ModuDevCore.PathweaveUIX.Data.ArgumentType.ToType)
- [ToTypes](#ModuDevCore.PathweaveUIX.Data.ArgumentType.ToTypes)

### Enumerators
**None**

### Nested Classes
**None**

</details>

<details>
<summary>Listener</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.Events.Listener](#ModuDevCore.PathweaveUIX.Data.Events.Listener)

### Fields
- [target](#ModuDevCore.PathweaveUIX.Data.Events.Listener.target)
- [targetComponent](#ModuDevCore.PathweaveUIX.Data.Events.Listener.targetComponent)
- [methodName](#ModuDevCore.PathweaveUIX.Data.Events.Listener.methodName)

### Properties
**None**

### Methods
- [GetClasses](#ModuDevCore.PathweaveUIX.Data.Events.Listener.GetClasses)
- [FindExactMethods](#ModuDevCore.PathweaveUIX.Data.Events.Listener.FindExactMethods)

### Enumerators
**None**

### Nested Classes
**None**

</details>

<details>
<summary>PathweavePage</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.PathweavePage](#ModuDevCore.PathweaveUIX.Data.PathweavePage)

### Fields
- [descriptor](#ModuDevCore.PathweaveUIX.Data.PathweavePage.descriptor)
- [view](#ModuDevCore.PathweaveUIX.Data.PathweavePage.view)
- [prefab](#ModuDevCore.PathweaveUIX.Data.PathweavePage.prefab)
- [name](#ModuDevCore.PathweaveUIX.Data.PathweavePage.name)
- [animations](#ModuDevCore.PathweaveUIX.Data.PathweavePage.animations)
- [actions](#ModuDevCore.PathweaveUIX.Data.PathweavePage.actions)

### Properties
**None**

### Methods
- [OnAfterDeserialize](#ModuDevCore.PathweaveUIX.Data.PathweavePage.OnAfterDeserialize)
- [OnBeforeSerialize](#ModuDevCore.PathweaveUIX.Data.PathweavePage.OnBeforeSerialize)

### Enumerators
**None**

### Nested Classes
- [TransitionAnimations](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations)
- [PathweaveAction](#ModuDevCore.PathweaveUIX.Data.PathweavePage.PathweaveAction)

</details>

<details>
<summary>SerializedArgumentValue</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue)

### Fields
- [argumentType](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.argumentType)
- [stringValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.stringValue)
- [intValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.intValue)
- [floatValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.floatValue)
- [boolValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.boolValue)
- [objectValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.objectValue)

### Properties
**None**

### Methods
- [GetValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.GetValue)

### Enumerators
**None**

### Nested Classes
**None**

</details>

<details>
<summary>PathweaveUIX</summary>

## Parent
[ModuDevCore.PathweaveUIX.PathweaveUIX](#ModuDevCore.PathweaveUIX.PathweaveUIX)

### Fields
- [pages](#ModuDevCore.PathweaveUIX.PathweaveUIX.pages)
- [autoApplyAnyPrefabOverrides](#ModuDevCore.PathweaveUIX.PathweaveUIX.autoApplyAnyPrefabOverrides)

### Properties
- [RouteData](#ModuDevCore.PathweaveUIX.PathweaveUIX.RouteData)
- [FullPagePath](#ModuDevCore.PathweaveUIX.PathweaveUIX.FullPagePath)
- [LastPageFullPath](#ModuDevCore.PathweaveUIX.PathweaveUIX.LastPageFullPath)
- [LastPagePath](#ModuDevCore.PathweaveUIX.PathweaveUIX.LastPagePath)
- [PagePath](#ModuDevCore.PathweaveUIX.PathweaveUIX.PagePath)
- [LastPageListPath](#ModuDevCore.PathweaveUIX.PathweaveUIX.LastPageListPath)
- [PagePathSegments](#ModuDevCore.PathweaveUIX.PathweaveUIX.PagePathSegments)
- [LastPage](#ModuDevCore.PathweaveUIX.PathweaveUIX.LastPage)
- [CurrentPage](#ModuDevCore.PathweaveUIX.PathweaveUIX.CurrentPage)
- [Instance](#ModuDevCore.PathweaveUIX.PathweaveUIX.Instance)
- [IsAnimating](#ModuDevCore.PathweaveUIX.PathweaveUIX.IsAnimating)

### Methods
- [SetPage](#ModuDevCore.PathweaveUIX.PathweaveUIX.SetPage)
- [NavigateBack](#ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateBack)
- [NavigateBackWithHash](#ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateBackWithHash)
- [Navigate](#ModuDevCore.PathweaveUIX.PathweaveUIX.Navigate)
- [NavigateWithHash](#ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateWithHash)
- [ClearHash](#ModuDevCore.PathweaveUIX.PathweaveUIX.ClearHash)
- [UpdatePage](#ModuDevCore.PathweaveUIX.PathweaveUIX.UpdatePage)

### Enumerators
**None**

### Nested Classes
**None**

</details>

## Classes

<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction"></a>
## ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction

### Opportunities

* Encapsulates navigation and event invocation logic.
* Provides runtime action binding through serialized arguments.
* Supports dynamic action discovery and invocation.

### Declaration

```csharp
[Serializable]
public class PathweaveAction
```

Represents a runtime action that can execute navigation operations or invoke page-defined UI events with serialized arguments.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.actionType"></a>
<td width="70%">

<h5>actionType</h5>

```csharp
public ActionType actionType;
```

Determines the category of action to execute.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.selectedAction"></a>
<td width="70%">

<h5>selectedAction</h5>

```csharp
public string selectedAction;
```

Name of the selected action.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.arguments"></a>
<td width="70%">

<h5>arguments</h5>

```csharp
public List<SerializedArgumentValue> arguments = new();
```

Serialized arguments associated with the selected action.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

<table>
<thead>
<tr>
<td>
<h4>About Property</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.PathweaveUIX"></a>
<td width="70%">

<h5>PathweaveUIX</h5>

```csharp
public PathweaveUIX PathweaveUIX { get; }
```

Returns the active PathweaveUIX instance.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.Actions"></a>
<td width="70%">

<h5>Actions</h5>

```csharp
public Dictionary<string, MethodSignature> Actions { get; }
```

Returns the available action collection based on the selected action type.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.SyncArguments"></a>
<td width="70%">

<h5>SyncArguments</h5>

```csharp
public void SyncArguments()
```

Synchronizes serialized arguments with the selected action signature.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.GetArgumentsArray"></a>
<td width="70%">

<h5>GetArgumentsArray</h5>

```csharp
public object[] GetArgumentsArray()
```

Converts serialized arguments into an object array.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.InvokeSelected"></a>
<td width="70%">

<h5>InvokeSelected</h5>

```csharp
public void InvokeSelected()
```

Invokes the currently selected action using synchronized arguments.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

<table>
<thead>
<tr>
<td>
<h4>About Enum</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.ActionType"></a>
<td width="70%">

<h5>ActionType</h5>

```csharp
public enum ActionType
{
    Navigation,
    Call
}
```

Defines the supported action categories.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Nested Classes

<table>
<thead>
<tr>
<td>
<h4>About Class</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature"></a>
<td width="70%">

<h5>MethodSignature</h5>

```csharp
[Serializable]
public class MethodSignature
{
    public List<ArgumentType> argumentTypes = new();
    public Action<object[]> action;
}
```

Stores argument metadata and execution delegate for a runtime action.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

---

<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents"></a>
## ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents

### Opportunities

* Provides animation event callbacks for UI transitions.
* Bridges Unity animation events with runtime delegates.
* Allows page transition synchronization with Animator clips.

### Declaration

```csharp
public class PathweaveAnimatorEvents : MonoBehaviour
```

Handles animation events used by the Pathweave UIX animation system.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChangeCallback"></a>
<td width="70%">

<h5>ReadyToChangeCallback</h5>

```csharp
public Action ReadyToChangeCallback;
```

Callback invoked when the animation reaches the page transition point.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

<table>
<thead>
<tr>
<td>
<h4>About Property</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.animator"></a>
<td width="70%">

<h5>animator</h5>

```csharp
public Animator animator { get; }
```

Returns the Animator component attached to the current GameObject.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChange"></a>
<td width="70%">

<h5>ReadyToChange</h5>

```csharp
public void ReadyToChange()
```

Invokes the transition callback when called by an animation event.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton"></a>
## ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton

### Opportunities

* Extends Unity Button with Pathweave action support.
* Enables navigation and event execution directly from UI interactions.
* Integrates serialized runtime actions into standard button workflows.

### Declaration

```csharp
public class PathweaveButton : Button
```

A custom button implementation that invokes a configured PathweaveAction when clicked.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.action"></a>
<td width="70%">

<h5>action</h5>

```csharp
public PathweaveAction action = new();
```

Action executed when the button is clicked.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

**None**

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.OnPointerClick"></a>
<td width="70%">

<h5>OnPointerClick</h5>

```csharp
public override void OnPointerClick(
    PointerEventData eventData
)
```

Handles pointer click events and invokes the configured Pathweave action.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent"></a>
## ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent

### Opportunities

* Provides runtime event dispatching with dynamic argument support.
* Allows method binding through serialized listeners.
* Supports invocation of public and private component methods.

### Declaration

```csharp
[Serializable]
public class PathweaveEvent
```

Represents a serialized event container capable of invoking registered component methods using reflection.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._argumentTypes"></a>
<td width="70%">

<h5>_argumentTypes</h5>

```csharp
public List<ArgumentType> _argumentTypes = new();
```

Defines the expected argument signature for event invocation.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._listeners"></a>
<td width="70%">

<h5>_listeners</h5>

```csharp
public List<Listener> _listeners = new();
```

Collection of registered event listeners.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

**None**

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.AddListener"></a>
<td width="70%">

<h5>AddListener</h5>

```csharp
public void AddListener(
    Component target,
    string methodName
)
```

Adds a listener targeting a component method.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.RemoveListener"></a>
<td width="70%">

<h5>RemoveListener</h5>

```csharp
public void RemoveListener(
    int index
)
```

Removes a listener at the specified index.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.Invoke"></a>
<td width="70%">

<h5>Invoke</h5>

```csharp
public void Invoke(
    params object[] args
)
```

Invokes all registered listeners using the provided arguments.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType"></a>
## ModuDevCore.PathweaveUIX.Data.ArgumentType

### Opportunities

* Provides serialization support for runtime type references.
* Converts stored type names into System.Type instances.
* Supports batch resolution of multiple serialized type names.

### Declaration

```csharp
[Serializable]
public class ArgumentType
```

Represents a serialized type reference used for runtime argument and method signature resolution.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType.typeName"></a>
<td width="70%">

<h5>typeName</h5>

```csharp
public string typeName;
```

Fully qualified name of the represented type.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

**None**

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType.ToType"></a>
<td width="70%">

<h5>ToType</h5>

```csharp
public static Type ToType(
    string fullName
)
```

Resolves a fully qualified type name into a Type instance.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType.ToTypes"></a>
<td width="70%">

<h5>ToTypes</h5>

```csharp
public static List<Type> ToTypes(
    string[] fullNames
)
```

Resolves a collection of type names into a list of Type instances.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener"></a>
## ModuDevCore.PathweaveUIX.Data.Events.Listener

### Opportunities

* Stores event listener binding information.
* Provides runtime component type discovery.
* Supports reflection-based method lookup with argument validation.

### Declaration

```csharp
[Serializable]
public class Listener
```

Represents a serialized event listener containing target object, target component, and method binding information.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.target"></a>
<td width="70%">

<h5>target</h5>

```csharp
public GameObject target;
```

Target GameObject that owns the listener component.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.targetComponent"></a>
<td width="70%">

<h5>targetComponent</h5>

```csharp
public Component targetComponent;
```

Component instance that contains the target method.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.methodName"></a>
<td width="70%">

<h5>methodName</h5>

```csharp
public string methodName;
```

Name of the method to invoke on the target component.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

**None**

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.GetClasses"></a>
<td width="70%">

<h5>GetClasses</h5>

```csharp
public static Type[] GetClasses(
    GameObject target
)
```

Returns all unique component types attached to the specified GameObject.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.FindExactMethods"></a>
<td width="70%">

<h5>FindExactMethods</h5>

```csharp
public static MethodInfo[] FindExactMethods(
    Type type,
    Type[] argTypes
)
```

Finds instance methods whose parameter signatures are compatible with the provided argument types.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage"></a>
## ModuDevCore.PathweaveUIX.Data.PathweavePage

### Opportunities

* Stores page configuration used by the Pathweave UIX navigation system.
* Defines transition animation settings for page changes.
* Provides a container for page-specific events and actions.

### Declaration

```csharp
[Serializable]
public class PathweavePage : ISerializationCallbackReceiver
```

Represents a UI page definition containing visual references, transition settings, and page actions.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.descriptor"></a>
<td width="70%">

<h5>descriptor</h5>

```csharp
[HideInInspector]
public string descriptor;
```

Editor-generated page description displayed in inspector tools.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.view"></a>
<td width="70%">

<h5>view</h5>

```csharp
public GameObject view;
```

Instantiated view object associated with the page.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.prefab"></a>
<td width="70%">

<h5>prefab</h5>

```csharp
public GameObject prefab;
```

Prefab used to create the page view.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.name"></a>
<td width="70%">

<h5>name</h5>

```csharp
public string name;
```

Unique page identifier used for navigation.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.animations"></a>
<td width="70%">

<h5>animations</h5>

```csharp
public TransitionAnimations animations;
```

Transition animation configuration for the page.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.actions"></a>
<td width="70%">

<h5>actions</h5>

```csharp
public List<PathweaveAction> actions = new List<PathweaveAction>();
```

Collection of page-specific actions.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

**None**

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.OnAfterDeserialize"></a>
<td width="70%">

<h5>OnAfterDeserialize</h5>

```csharp
public void OnAfterDeserialize()
```

Called after Unity deserializes the page data.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.OnBeforeSerialize"></a>
<td width="70%">

<h5>OnBeforeSerialize</h5>

```csharp
public void OnBeforeSerialize()
```

Updates editor metadata before serialization.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

<table>
<thead>
<tr>
<td>
<h4>About Class</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations"></a>
<td width="70%">

<h5>TransitionAnimations</h5>

```csharp
[Serializable]
public class TransitionAnimations
{
    public string GoRightOpenStateName;
    public string GoLeftOpenStateName;
    public string GoRightCloseStateName;
    public string GoLeftCloseStateName;
    public string StaticOpenStateName;
    public string StaticCloseStateName;
}
```

Contains animator state names used during page transitions.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.PathweaveAction"></a>
<td width="70%">

<h5>PathweaveAction</h5>

```csharp
[Serializable]
public class PathweaveAction
{
    public string name;

    [SerializeField]
    public PathweaveEvent uiEvent = new PathweaveEvent();
}
```

Represents a named page event that can be invoked through the Pathweave event system.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

---

<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue"></a>
## ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue

### Opportunities

* Provides flexible runtime argument serialization for UI actions and events.
* Supports multiple primitive and Unity-specific data types.
* Enables reflection-based invocation with strongly-typed value reconstruction.

### Declaration

```csharp
[Serializable]
public class SerializedArgumentValue
```

Represents a serialized argument container capable of storing and reconstructing runtime values for method invocation.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.argumentType"></a>
<td width="70%">

<h5>argumentType</h5>

```csharp
public ArgumentType argumentType;
```

Defines the expected runtime type of the argument.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.stringValue"></a>
<td width="70%">

<h5>stringValue</h5>

```csharp
public string stringValue;
```

Serialized string representation of the value.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.intValue"></a>
<td width="70%">

<h5>intValue</h5>

```csharp
public int intValue;
```

Serialized integer value.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.floatValue"></a>
<td width="70%">

<h5>floatValue</h5>

```csharp
public float floatValue;
```

Serialized floating-point value.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.boolValue"></a>
<td width="70%">

<h5>boolValue</h5>

```csharp
public bool boolValue;
```

Serialized boolean value.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.objectValue"></a>
<td width="70%">

<h5>objectValue</h5>

```csharp
public UnityEngine.Object objectValue;
```

Serialized Unity object reference.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

**None**

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.GetValue"></a>
<td width="70%">

<h5>GetValue</h5>

```csharp
public object GetValue()
```

Converts the serialized value into its runtime object representation based on the declared argument type.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

<a id="ModuDevCore.PathweaveUIX.PathweaveUIX"></a>
## ModuDevCore.PathweaveUIX.PathweaveUIX

### Opportunities

* Core runtime controller for Pathweave UIX navigation system.
* Manages page stack, routing paths, and hash-based state.
* Handles UI page instantiation and destruction at runtime and edit-time.
* Supports animated transitions between UI pages via Animator states.
* Provides navigation API (SetPage, Navigate, NavigateBack, ClearHash).
* Integrates with Unity Editor workflow for prefab instantiation and overrides.
* Enables runtime debug inspection of UI flow and route state.

### Declaration

```csharp
[ExecuteAlways]
public class PathweaveUIX : MonoBehaviour
```

Main MonoBehaviour responsible for managing UI pages, navigation stack, and animated transitions within the Pathweave UI system.

## Fields

<table>
<thead>
<tr>
<td>
<h4>About Field</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.pages"></a>
<td width="70%">

<h5>pages</h5>

```csharp
public List<PathweavePage> pages = new List<PathweavePage>();
```

Collection of all registered UI pages in the system.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.autoApplyAnyPrefabOverrides"></a>
<td width="70%">

<h5>autoApplyAnyPrefabOverrides</h5>

```csharp
public bool autoApplyAnyPrefabOverrides = false;
```

Enables automatic application of prefab overrides in editor mode.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Properties

<table>
<thead>
<tr>
<td>
<h4>About Property</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.RouteData"></a>
<td width="70%">

<h5>RouteData</h5>

```csharp
public string RouteData { get; set; }
```

Gets or sets hash-based route data associated with the current UI path.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.FullPagePath"></a>
<td width="70%">

<h5>FullPagePath</h5>

```csharp
public string FullPagePath { get; set; }
```

Full navigation path including route data hash.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPageFullPath"></a>
<td width="70%">

<h5>LastPageFullPath</h5>

```csharp
public string LastPageFullPath { get; private set; }
```

Stores the previous full navigation path.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPagePath"></a>
<td width="70%">

<h5>LastPagePath</h5>

```csharp
public string LastPagePath { get; }
```

Previous page path without route data.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.PagePath"></a>
<td width="70%">

<h5>PagePath</h5>

```csharp
public string PagePath { get; set; }
```

Current navigation path without route data hash.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPageListPath"></a>
<td width="70%">

<h5>LastPageListPath</h5>

```csharp
public List<string> LastPageListPath { get; }
```

Split list representation of previous page path.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.PagePathSegments"></a>
<td width="70%">

<h5>PagePathSegments</h5>

```csharp
public List<string> PagePathSegments { get; set; }
```

Split list representation of current navigation path.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPage"></a>
<td width="70%">

<h5>LastPage</h5>

```csharp
public PathweavePage LastPage { get; }
```

Previously active UI page.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.CurrentPage"></a>
<td width="70%">

<h5>CurrentPage</h5>

```csharp
public PathweavePage CurrentPage { get; set; }
```

Currently active UI page based on navigation state.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.Instance"></a>
<td width="70%">

<h5>Instance</h5>

```csharp
public static PathweaveUIX Instance { get; set; }
```

Global singleton access point for Pathweave UIX controller.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.IsAnimating"></a>
<td width="70%">

<h5>IsAnimating</h5>

```csharp
public bool IsAnimating { get; set; }
```

Indicates whether a UI transition animation is currently running.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Methods

<table>
<thead>
<tr>
<td>
<h4>About Method</h4>
</td>
<td>
<h4>Example</h4>
</td>
</tr>
</thead>
<tbody>
<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.SetPage"></a>
<td width="70%">

<h5>SetPage</h5>

```csharp
public void SetPage(string uiName)
```

Directly sets the current page by name without navigation stack behavior.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateBack"></a>
<td width="70%">

<h5>NavigateBack</h5>

```csharp
public void NavigateBack()
```

Returns to the previous page in navigation history.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateBackWithHash"></a>
<td width="70%">

<h5>NavigateBackWithHash</h5>

```csharp
public void NavigateBackWithHash()
```

Returns to previous page while preserving route hash data.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.Navigate"></a>
<td width="70%">

<h5>Navigate</h5>

```csharp
public void Navigate(string path)
```

Navigates forward by appending a new path segment.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateWithHash"></a>
<td width="70%">

<h5>NavigateWithHash</h5>

```csharp
public void NavigateWithHash(string path)
```

Navigates forward while preserving hash-based route data.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.ClearHash"></a>
<td width="70%">

<h5>ClearHash</h5>

```csharp
public void ClearHash()
```

Clears route hash data while keeping the base path intact.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.UpdatePage"></a>
<td width="70%">

<h5>UpdatePage</h5>

```csharp
public void UpdatePage(
    PathweavePage _new,
    bool animating = true
)
```

Switches UI pages and handles transition logic including animations and cleanup of previous pages.
</td>
<td width="30%">
<img src="https://raw.githubusercontent.com/ModuDevCore/about/main/Images/Baner.gif" width="100%" alt="Example" />
</td>
</tr>
</tbody>
</table>

## Enum

**None**

## Nested Classes

**None**

---

# Technical documentation

This is a technical documentation, a brief description is provided in REFERENCE, with public classes and examples. Public and private classes are provided for internal development, but they can be used (at your own risk).
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
- [BuildNavigationActions](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.BuildNavigationActions)
- [BuildCallActions](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.BuildCallActions)

### Enumerators
- [ActionType](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.ActionType)

### Nested Classes
- [MethodSignature](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature)

</details>

<details>
<summary>MethodSignature</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature)

### Fields
- [argumentTypes](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature.argumentTypes)
- [action](#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature.action)

</details>

<details>
<summary>PathweaveAnimatorEvents</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents)

### Properties
- [animator](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.animator)

### Methods
- [ReadyToChange](#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChange)

</details>

<details>
<summary>PathweaveButton</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton](#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton)

### Fields
- [action](#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.action)

### Methods
- [OnPointerClick](#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.OnPointerClick)

</details>

<details>
<summary>PathweaveEvent</summary>

## Parent
[ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent)

### Fields
- [_argumentTypes](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._argumentTypes)
- [_listeners](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._listeners)

### Methods
- [AddListener](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.AddListener)
- [RemoveListener](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.RemoveListener)
- [Invoke](#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.Invoke)

</details>

<details>
<summary>ArgumentType</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.ArgumentType](#ModuDevCore.PathweaveUIX.Data.ArgumentType)

### Fields
- [typeName](#ModuDevCore.PathweaveUIX.Data.ArgumentType.typeName)

### Methods
- [ToType](#ModuDevCore.PathweaveUIX.Data.ArgumentType.ToType)
- [ToTypes](#ModuDevCore.PathweaveUIX.Data.ArgumentType.ToTypes)

</details>

<details>
<summary>Listener</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.Events.Listener](#ModuDevCore.PathweaveUIX.Data.Events.Listener)

### Fields
- [target](#ModuDevCore.PathweaveUIX.Data.Events.Listener.target)
- [targetComponent](#ModuDevCore.PathweaveUIX.Data.Events.Listener.targetComponent)
- [methodName](#ModuDevCore.PathweaveUIX.Data.Events.Listener.methodName)

### Methods
- [GetClasses](#ModuDevCore.PathweaveUIX.Data.Events.Listener.GetClasses)
- [FindExactMethods](#ModuDevCore.PathweaveUIX.Data.Events.Listener.FindExactMethods)

</details>

<details>
<summary>PathweavePage</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.PathweavePage](#ModuDevCore.PathweaveUIX.Data.PathweavePage)

### Fields
- [descriptor](#ModuDevCore.PathweaveUIX.Data.PathweavePage.descriptor)
- [isExpanded](#ModuDevCore.PathweaveUIX.Data.PathweavePage.isExpanded)
- [showActions](#ModuDevCore.PathweaveUIX.Data.PathweavePage.showActions)
- [showAnimations](#ModuDevCore.PathweaveUIX.Data.PathweavePage.showAnimations)
- [view](#ModuDevCore.PathweaveUIX.Data.PathweavePage.view)
- [prefab](#ModuDevCore.PathweaveUIX.Data.PathweavePage.prefab)
- [name](#ModuDevCore.PathweaveUIX.Data.PathweavePage.name)
- [animations](#ModuDevCore.PathweaveUIX.Data.PathweavePage.animations)
- [actions](#ModuDevCore.PathweaveUIX.Data.PathweavePage.actions)

### Methods
- [OnAfterDeserialize](#ModuDevCore.PathweaveUIX.Data.PathweavePage.OnAfterDeserialize)
- [OnBeforeSerialize](#ModuDevCore.PathweaveUIX.Data.PathweavePage.OnBeforeSerialize)

### Nested Classes
- [TransitionAnimations](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations)
- [PathweaveAction](#ModuDevCore.PathweaveUIX.Data.PathweavePage.PathweaveAction)

</details>

<details>
<summary>TransitionAnimations</summary>

## Parent
[ModuDevCore.PathweaveUIX.Data.PathweavePage](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations)

### Fields
- [GoRightOpenStateName](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations.GoRightOpenStateName)
- [GoLeftOpenStateName](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations.GoLeftOpenStateName)
- [GoRightCloseStateName](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations.GoRightCloseStateName)
- [GoLeftCloseStateName](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations.GoLeftCloseStateName)
- [StaticOpenStateName](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations.StaticOpenStateName)
- [StaticCloseStateName](#ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations.StaticCloseStateName)

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

### Methods
- [GetValue](#ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.GetValue)

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
- [ApplyPrefabs](#ModuDevCore.PathweaveUIX.PathweaveUIX.ApplyPrefabs)

</details>

<details>
<summary>PathweaveActionDrawer</summary>

## Parent
[ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer](#ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer)

*(Custom Property Drawer – editor only)*

</details>

<details>
<summary>PathweaveEventDrawer</summary>

## Parent
[ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer](#ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer)

*(Custom Property Drawer – editor only)*

</details>

<details>
<summary>PathweaveUIXEditor</summary>

## Parent
[ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor](#ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor)

*(Custom Editor – editor only)*

</details>

<details>
<summary>PathweaveMenu</summary>

## Parent
[ModuDevCore.PathweaveUIX.Editor.PathweaveMenu](#ModuDevCore.PathweaveUIX.Editor.PathweaveMenu)

### Methods
- [CreateNewPage](#ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.CreateNewPage)
- [CreateButton](#ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.CreateButton)

</details>

<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction"></a>

## ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.actionType"></a>
<td><code>actionType</code></td>
<td>

```csharp
public ActionType actionType;
```

</td>
<td>Determines the category of action to execute.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.selectedAction"></a>
<td><code>selectedAction</code></td>
<td>

```csharp
public string selectedAction;
```

</td>
<td>Name of the selected action.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.arguments"></a>
<td><code>arguments</code></td>
<td>

```csharp
public List<SerializedArgumentValue> arguments = new();
```

</td>
<td>Serialized arguments associated with the selected action.</td>
</tr>
</table>

## Properties

<table>
<tr>
<th>Property</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.PathweaveUIX"></a>
<td><code>PathweaveUIX</code></td>
<td>

```csharp
public PathweaveUIX PathweaveUIX { get; }
```

</td>
<td>Returns the active PathweaveUIX instance.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.Actions"></a>
<td><code>Actions</code></td>
<td>

```csharp
public Dictionary<string, MethodSignature> Actions { get; }
```

</td>
<td>Returns the available action collection based on the selected action type.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.SyncArguments"></a>
<td><code>SyncArguments</code></td>
<td>

```csharp
public void SyncArguments()
```

</td>
<td>Synchronizes serialized arguments with the selected action signature.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.GetArgumentsArray"></a>
<td><code>GetArgumentsArray</code></td>
<td>

```csharp
public object[] GetArgumentsArray()
```

</td>
<td>Converts serialized arguments into an object array.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.InvokeSelected"></a>
<td><code>InvokeSelected</code></td>
<td>

```csharp
public void InvokeSelected()
```

</td>
<td>Invokes the currently selected action using synchronized arguments.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.BuildNavigationActions"></a>
<td><code>BuildNavigationActions</code></td>
<td>

```csharp
private Dictionary<string, MethodSignature> BuildNavigationActions()
```

</td>
<td>Builds the collection of built-in navigation actions.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.BuildCallActions"></a>
<td><code>BuildCallActions</code></td>
<td>

```csharp
private Dictionary<string, MethodSignature> BuildCallActions()
```

</td>
<td>Builds the collection of page-defined callable actions.</td>
</tr>
</table>

## Enum

<table>
<tr>
<th>Enum</th>
<th>Values</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.ActionType"></a>
<td><code>ActionType</code></td>
<td>

```csharp
public enum ActionType
{
    Navigation,
    Call
}
```

</td>
<td>Defines the supported action categories.</td>
</tr>
</table>

## Nested Classes

<table>
<tr>
<th>Class</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Actions.PathweaveAction.MethodSignature"></a>
<td><code>MethodSignature</code></td>
<td>

```csharp
[Serializable]
public class MethodSignature
{
    public List<ArgumentType> argumentTypes = new();
    public Action<object[]> action;
}
```

</td>
<td>Stores argument metadata and execution delegate for a runtime action.</td>
</tr>
</table>

---

<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents"></a>


## ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChangeCallback"></a>
<td><code>ReadyToChangeCallback</code></td>
<td>

```csharp
public Action ReadyToChangeCallback;
```

</td>
<td>Callback invoked when the animation reaches the page transition point.</td>
</tr>
</table>

## Properties

<table>
<tr>
<th>Property</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.animator"></a>
<td><code>animator</code></td>
<td>

```csharp
public Animator animator { get; }
```

</td>
<td>Returns the Animator component attached to the current GameObject.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Animation.PathweaveAnimatorEvents.ReadyToChange"></a>
<td><code>ReadyToChange</code></td>
<td>

```csharp
public void ReadyToChange()
```

</td>
<td>Invokes the transition callback when called by an animation event.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton"></a>

## ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.action"></a>
<td><code>action</code></td>
<td>

```csharp
public PathweaveAction action = new();
```

</td>
<td>Action executed when the button is clicked.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.Awake"></a>
<td><code>Awake</code></td>
<td>

```csharp
protected override void Awake()
```

</td>
<td>Initializes the button and inherited Button functionality.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.UI.PathweaveButton.OnPointerClick"></a>
<td><code>OnPointerClick</code></td>
<td>

```csharp
public override void OnPointerClick(
    PointerEventData eventData
)
```

</td>
<td>Handles pointer click events and invokes the configured Pathweave action.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent"></a>

## ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._argumentTypes"></a>
<td><code>_argumentTypes</code></td>
<td>

```csharp
public List<ArgumentType> _argumentTypes = new();
```

</td>
<td>Defines the expected argument signature for event invocation.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent._listeners"></a>
<td><code>_listeners</code></td>
<td>

```csharp
public List<Listener> _listeners = new();
```

</td>
<td>Collection of registered event listeners.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.AddListener"></a>
<td><code>AddListener</code></td>
<td>

```csharp
public void AddListener(
    Component target,
    string methodName
)
```

</td>
<td>Adds a listener targeting a component method.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.RemoveListener"></a>
<td><code>RemoveListener</code></td>
<td>

```csharp
public void RemoveListener(
    int index
)
```

</td>
<td>Removes a listener at the specified index.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Runtime.Events.PathweaveEvent.Invoke"></a>
<td><code>Invoke</code></td>
<td>

```csharp
public void Invoke(
    params object[] args
)
```

</td>
<td>Invokes all registered listeners using the provided arguments.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType"></a>
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.Data.ArgumentType)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType.typeName"></a>
<td><code>typeName</code></td>
<td>

```csharp
public string typeName;
```

</td>
<td>Fully qualified name of the represented type.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType.ToType"></a>
<td><code>ToType</code></td>
<td>

```csharp
public static Type ToType(
    string fullName
)
```

</td>
<td>Resolves a fully qualified type name into a Type instance.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.ArgumentType.ToTypes"></a>
<td><code>ToTypes</code></td>
<td>

```csharp
public static List<Type> ToTypes(
    string[] fullNames
)
```

</td>
<td>Resolves a collection of type names into a list of Type instances.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.target"></a>
<td><code>target</code></td>
<td>

```csharp
public GameObject target;
```

</td>
<td>Target GameObject that owns the listener component.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.targetComponent"></a>
<td><code>targetComponent</code></td>
<td>

```csharp
public Component targetComponent;
```

</td>
<td>Component instance that contains the target method.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.methodName"></a>
<td><code>methodName</code></td>
<td>

```csharp
public string methodName;
```

</td>
<td>Name of the method to invoke on the target component.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.GetClasses"></a>
<td><code>GetClasses</code></td>
<td>

```csharp
public static Type[] GetClasses(
    GameObject target
)
```

</td>
<td>Returns all unique component types attached to the specified GameObject.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.Events.Listener.FindExactMethods"></a>
<td><code>FindExactMethods</code></td>
<td>

```csharp
public static MethodInfo[] FindExactMethods(
    Type type,
    Type[] argTypes
)
```

</td>
<td>Finds instance methods whose parameter signatures are compatible with the provided argument types.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage"></a>

## ModuDevCore.PathweaveUIX.Data.PathweavePage
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.Data.PathweavePage)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.descriptor"></a>
<td><code>descriptor</code></td>
<td>

```csharp
[HideInInspector]
public string descriptor;
```

</td>
<td>Editor-generated page description displayed in inspector tools.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.isExpanded"></a>
<td><code>isExpanded</code></td>
<td>

```csharp
[NonSerialized]
public bool isExpanded;
```

</td>
<td>Editor state indicating whether the page entry is expanded.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.showActions"></a>
<td><code>showActions</code></td>
<td>

```csharp
[NonSerialized]
public bool showActions;
```

</td>
<td>Editor state controlling action list visibility.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.showAnimations"></a>
<td><code>showAnimations</code></td>
<td>

```csharp
[NonSerialized]
public bool showAnimations;
```

</td>
<td>Editor state controlling animation settings visibility.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.view"></a>
<td><code>view</code></td>
<td>

```csharp
public GameObject view;
```

</td>
<td>Instantiated view object associated with the page.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.prefab"></a>
<td><code>prefab</code></td>
<td>

```csharp
public GameObject prefab;
```

</td>
<td>Prefab used to create the page view.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.name"></a>
<td><code>name</code></td>
<td>

```csharp
public string name;
```

</td>
<td>Unique page identifier used for navigation.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.animations"></a>
<td><code>animations</code></td>
<td>

```csharp
public TransitionAnimations animations;
```

</td>
<td>Transition animation configuration for the page.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.actions"></a>
<td><code>actions</code></td>
<td>

```csharp
public List<PathweaveAction> actions = new List<PathweaveAction>();
```

</td>
<td>Collection of page-specific actions.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.OnAfterDeserialize"></a>
<td><code>OnAfterDeserialize</code></td>
<td>

```csharp
public void OnAfterDeserialize()
```

</td>
<td>Called after Unity deserializes the page data.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.OnBeforeSerialize"></a>
<td><code>OnBeforeSerialize</code></td>
<td>

```csharp
public void OnBeforeSerialize()
```

</td>
<td>Updates editor metadata before serialization.</td>
</tr>
</table>

## Enum

None

## Nested Classes

<table>
<tr>
<th>Class</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.TransitionAnimations"></a>
<td><code>TransitionAnimations</code></td>
<td>

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

</td>
<td>Contains animator state names used during page transitions.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.PathweavePage.PathweaveAction"></a>
<td><code>PathweaveAction</code></td>
<td>

```csharp
[Serializable]
public class PathweaveAction
{
    public string name;

    [SerializeField]
    public PathweaveEvent uiEvent = new PathweaveEvent();
}
```

</td>
<td>Represents a named page event that can be invoked through the Pathweave event system.</td>
</tr>
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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.argumentType"></a>
<td><code>argumentType</code></td>
<td>

```csharp
public ArgumentType argumentType;
```

</td>
<td>Defines the expected runtime type of the argument.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.stringValue"></a>
<td><code>stringValue</code></td>
<td>

```csharp
public string stringValue;
```

</td>
<td>Serialized string representation of the value.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.intValue"></a>
<td><code>intValue</code></td>
<td>

```csharp
public int intValue;
```

</td>
<td>Serialized integer value.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.floatValue"></a>
<td><code>floatValue</code></td>
<td>

```csharp
public float floatValue;
```

</td>
<td>Serialized floating-point value.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.boolValue"></a>
<td><code>boolValue</code></td>
<td>

```csharp
public bool boolValue;
```

</td>
<td>Serialized boolean value.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.objectValue"></a>
<td><code>objectValue</code></td>
<td>

```csharp
public UnityEngine.Object objectValue;
```

</td>
<td>Serialized Unity object reference.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Data.SerializedArgumentValue.GetValue"></a>
<td><code>GetValue</code></td>
<td>

```csharp
public object GetValue()
```

</td>
<td>Converts the serialized value into its runtime object representation based on the declared argument type.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer"></a>

## ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer

### Opportunities

* Provides a custom Unity Inspector UI for PathweaveAction configuration.
* Dynamically generates action dropdown based on runtime available actions.
* Supports serialized argument editing for multiple data types.
* Synchronizes runtime method signatures with inspector UI.

### Declaration

```csharp
[CustomPropertyDrawer(typeof(PathweaveAction))]
public class PathweaveActionDrawer : PropertyDrawer
```

Custom Unity Editor drawer used to visualize and edit PathweaveAction data inside the Inspector.

## Fields

None

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.GetPropertyHeight"></a>
<td><code>GetPropertyHeight</code></td>
<td>

```csharp
public override float GetPropertyHeight(
    SerializedProperty property,
    GUIContent label
)
```

</td>
<td>Calculates dynamic inspector height based on selected action and argument count.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.OnGUI"></a>
<td><code>OnGUI</code></td>
<td>

```csharp
public override void OnGUI(
    Rect position,
    SerializedProperty property,
    GUIContent label
)
```

</td>
<td>Renders the full inspector UI for PathweaveAction including type, action selection, and arguments.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.DrawActionPopup"></a>
<td><code>DrawActionPopup</code></td>
<td>

```csharp
private void DrawActionPopup(
    Rect rect,
    PathweaveAction runtimeAction,
    SerializedProperty selectedAction
)
```

</td>
<td>Draws a dropdown list of available actions for selection.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.DrawArguments"></a>
<td><code>DrawArguments</code></td>
<td>

```csharp
private void DrawArguments(
    Rect rect,
    PathweaveAction runtimeAction,
    SerializedProperty selectedAction,
    SerializedProperty arguments
)
```

</td>
<td>Draws and edits serialized arguments based on the selected method signature.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.GetTargetObjectOfProperty"></a>
<td><code>GetTargetObjectOfProperty</code></td>
<td>

```csharp
private object GetTargetObjectOfProperty(
    SerializedProperty prop
)
```

</td>
<td>Resolves a SerializedProperty into its underlying runtime object instance.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.GetValue"></a>
<td><code>GetValue</code></td>
<td>

```csharp
private object GetValue(
    object source,
    string name
)
```

</td>
<td>Uses reflection to retrieve a field or property value from an object.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveActionDrawer.GetValue"></a>
<td><code>GetValue (indexed)</code></td>
<td>

```csharp
private object GetValue(
    object source,
    string name,
    int index
)
```

</td>
<td>Retrieves an indexed element from a collection field using reflection.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveButtonEditor"></a>

## ModuDevCore.PathweaveUIX.Editor.UI.PathweaveButtonEditor

### Opportunities

* Extends Unity default Button inspector with PathweaveAction support.
* Enables direct configuration of UI actions inside the Inspector.
* Preserves standard Button functionality while adding custom behavior.

### Declaration

```csharp
[CustomEditor(typeof(PathweaveButton))]
public class PathweaveButtonEditor : UnityEditor.UI.ButtonEditor
```

Custom Unity Editor for PathweaveButton that extends the default Button inspector with action configuration.

## Fields

<table>
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveButtonEditor.action"></a>
<td><code>action</code></td>
<td>

```csharp
private SerializedProperty action;
```

</td>
<td>Serialized reference to the PathweaveAction field inside the button.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveButtonEditor.OnEnable"></a>
<td><code>OnEnable</code></td>
<td>

```csharp
protected override void OnEnable()
```

</td>
<td>Initializes serialized properties when the editor is enabled.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.UI.PathweaveButtonEditor.OnInspectorGUI"></a>
<td><code>OnInspectorGUI</code></td>
<td>

```csharp
public override void OnInspectorGUI()
```

</td>
<td>Renders the inspector UI including default Button fields and Pathweave action configuration.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer"></a>

## ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer

### Opportunities

* Provides a custom Unity Inspector for PathweaveEvent serialization.
* Supports dynamic listener binding via reflection-based method selection.
* Enables argument type configuration for event invocation.
* Uses advanced dropdowns for selecting compatible methods and types.

### Declaration

```csharp
[CustomPropertyDrawer(typeof(PathweaveEvent))]
public class PathweaveEventDrawer : PropertyDrawer
```

Custom property drawer that renders the PathweaveEvent system in the Unity Inspector.

## Fields

<table>
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.listenersHeight"></a>
<td><code>listenersHeight</code></td>
<td>

```csharp
private float listenersHeight = 0;
```

</td>
<td>Stores computed height of the listeners list for layout calculation.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.OnGUI"></a>
<td><code>OnGUI</code></td>
<td>

```csharp
public override void OnGUI(
    Rect position,
    SerializedProperty property,
    GUIContent label
)
```

</td>
<td>Renders argument type configuration and listener list UI in the Unity Inspector.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.FindComponent"></a>
<td><code>FindComponent</code></td>
<td>

```csharp
private Component FindComponent(
    GameObject go,
    MethodInfo methodInfo
)
```

</td>
<td>Finds a component instance on a GameObject matching a method’s declaring type.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.DrawTypesList"></a>
<td><code>DrawTypesList</code></td>
<td>

```csharp
private void DrawTypesList(
    Rect position,
    SerializedProperty list
)
```

</td>
<td>Renders argument type selector list for event signature definition.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.GetMethodSignature"></a>
<td><code>GetMethodSignature</code></td>
<td>

```csharp
private string GetMethodSignature(
    MethodInfo method
)
```

</td>
<td>Formats a method signature string for display in the inspector.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.GetTypeLabel"></a>
<td><code>GetTypeLabel</code></td>
<td>

```csharp
private string GetTypeLabel(
    Type type
)
```

</td>
<td>Converts a System.Type into a user-friendly display label.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.GetTypeIcon"></a>
<td><code>GetTypeIcon</code></td>
<td>

```csharp
private Texture GetTypeIcon(
    Type type
)
```

</td>
<td>Returns an editor icon representing the given type.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.FindMonoScript"></a>
<td><code>FindMonoScript</code></td>
<td>

```csharp
private MonoScript FindMonoScript(
    Type type
)
```

</td>
<td>Attempts to locate a MonoScript asset matching the provided type.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.GetTypesListHeight"></a>
<td><code>GetTypesListHeight</code></td>
<td>

```csharp
private float GetTypesListHeight(
    SerializedProperty list
)
```

</td>
<td>Calculates the total vertical height required for the argument type list UI.</td>
</tr>
</table>

## Enum

None

## Nested Classes

<table>
<tr>
<th>Class</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.UIEventMethodsDropdown"></a>
<td><code>UIEventMethodsDropdown</code></td>
<td>

```csharp
public class UIEventMethodsDropdown : AdvancedDropdown
```

</td>
<td>Advanced dropdown used to select compatible methods for event listeners.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.Events.PathweaveEventDrawer.UIArgumentTypeDropdown"></a>
<td><code>UIArgumentTypeDropdown</code></td>
<td>

```csharp
public class UIArgumentTypeDropdown : AdvancedDropdown
```

</td>
<td>Advanced dropdown used to select argument types for event signatures.</td>
</tr>
</table>

---

<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveMenu"></a>

## ModuDevCore.PathweaveUIX.Editor.PathweaveMenu

### Opportunities

* Provides Unity Editor menu shortcuts for Pathweave UIX creation tools.
* Enables fast creation of UI pages from predefined prefab templates.
* Supports instantiation of Pathweave UI buttons inside Canvas hierarchy.
* Automates prefab asset generation with unique paths.

### Declaration

```csharp
public static class PathweaveMenu
```

Utility editor class that exposes menu commands for creating Pathweave UI elements such as pages and buttons.

## Fields

<table>
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.NEW_PAGE_PREFAB_GUID"></a>
<td><code>NEW_PAGE_PREFAB_GUID</code></td>
<td>

```csharp
private const string NEW_PAGE_PREFAB_GUID = "b317da4206c93c6cbae4d23ada388f8b";
```

</td>
<td>GUID reference to the base prefab used for creating new pages.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.BUTTON_PREFAB_GUID"></a>
<td><code>BUTTON_PREFAB_GUID</code></td>
<td>

```csharp
private const string BUTTON_PREFAB_GUID = "49e25970ab91997279abd27b318f3bd0";
```

</td>
<td>GUID reference to the base prefab used for creating Pathweave buttons.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.CreateNewPage"></a>
<td><code>CreateNewPage</code></td>
<td>

```csharp
public static void CreateNewPage()
```

</td>
<td>Creates a new Pathweave page prefab instance from the base template and saves it to the selected folder.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.GetSelectedFolder"></a>
<td><code>GetSelectedFolder</code></td>
<td>

```csharp
private static string GetSelectedFolder()
```

</td>
<td>Determines the currently selected folder in the Unity Project window.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveMenu.CreateButton"></a>
<td><code>CreateButton</code></td>
<td>

```csharp
public static void CreateButton(
    MenuCommand command
)
```

</td>
<td>Creates a PathweaveButton instance and attaches it to the selected UI hierarchy or Canvas.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor"></a>

## ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor

### Opportunities

* Provides a full custom Unity Inspector for the Pathweave UIX runtime system.
* Allows real-time editing of UI pages, navigation flow, and routing state.
* Supports animation state configuration per UI page.
* Enables management of UI actions and event bindings directly in the editor.
* Includes runtime debugging panel for route, page, and state inspection.

### Declaration

```csharp
[CustomEditor(typeof(PathweaveUIX))]
public class PathweaveUIXEditor : UnityEditor.Editor
```

Custom inspector implementation for the Pathweave UIX system that replaces the default Unity inspector with a specialized UI management interface.

## Fields

<table>
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.expandedDrawList"></a>
<td><code>expandedDrawList</code></td>
<td>

```csharp
private bool expandedDrawList = false;
```

</td>
<td>Controls whether the full UI page list is expanded in the inspector.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.pathweaveUIX"></a>
<td><code>pathweaveUIX</code></td>
<td>

```csharp
private PathweaveUIX pathweaveUIX;
```

</td>
<td>Reference to the inspected Pathweave UIX runtime instance.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.current"></a>
<td><code>current</code></td>
<td>

```csharp
private PathweavePage current;
```

</td>
<td>Currently selected UI page.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.banner"></a>
<td><code>banner</code></td>
<td>

```csharp
private Texture2D banner;
```

</td>
<td>Editor banner texture displayed at the top of the inspector.</td>
</tr>
</table>

## Properties

None

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.OnInspectorGUI"></a>
<td><code>OnInspectorGUI</code></td>
<td>

```csharp
public override void OnInspectorGUI()
```

</td>
<td>Draws the full custom inspector UI for Pathweave UIX, including pages, navigation, and debug panel.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.DrawDebugPanel"></a>
<td><code>DrawDebugPanel</code></td>
<td>

```csharp
void DrawDebugPanel()
```

</td>
<td>Renders runtime debugging information such as current page, route data, and animation state.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.DrawBanner"></a>
<td><code>DrawBanner</code></td>
<td>

```csharp
void DrawBanner()
```

</td>
<td>Draws the inspector banner and provides clickable link to the Pathweave repository.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.DrawNavigationMenu"></a>
<td><code>DrawNavigationMenu</code></td>
<td>

```csharp
void DrawNavigationMenu()
```

</td>
<td>Provides navigation controls for switching pages and managing routing behavior.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.DrawUIList"></a>
<td><code>DrawUIList</code></td>
<td>

```csharp
void DrawUIList()
```

</td>
<td>Displays and manages the list of UI pages, including selection, deletion, and editing.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.DrawActions"></a>
<td><code>DrawActions</code></td>
<td>

```csharp
void DrawActions(
    PathweavePage ui
)
```

</td>
<td>Draws and manages UI actions bound to a specific page.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.DrawAnimationsSection"></a>
<td><code>DrawAnimationsSection</code></td>
<td>

```csharp
void DrawAnimationsSection(
    PathweavePage ui
)
```

</td>
<td>Edits transition animation state names for a UI page.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.SafeFind"></a>
<td><code>SafeFind</code></td>
<td>

```csharp
SerializedProperty SafeFind(
    string name
)
```

</td>
<td>Safely retrieves a serialized property from the inspector object.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.Editor.PathweaveUIXEditor.GetSelectedFolder"></a>
<td><code>GetSelectedFolder</code></td>
<td>

```csharp
// Not present in this class
```

</td>
<td>None</td>
</tr>
</table>

## Enum

None

## Nested Classes

None

---

<a id="ModuDevCore.PathweaveUIX.PathweaveUIX"></a>

## ModuDevCore.PathweaveUIX.PathweaveUIX
[REFERENCE.md](./REFERENCE.md#ModuDevCore.PathweaveUIX.PathweaveUIX)

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
<tr>
<th>Field</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.pages"></a>
<td><code>pages</code></td>
<td>

```csharp
public List<PathweavePage> pages = new List<PathweavePage>();
```

</td>
<td>Collection of all registered UI pages in the system.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX._PagePath"></a>
<td><code>_PagePath</code></td>
<td>

```csharp
[SerializeField]
private string _PagePath = "";
```

</td>
<td>Internal serialized routing path string used for navigation state.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.autoApplyAnyPrefabOverrides"></a>
<td><code>autoApplyAnyPrefabOverrides</code></td>
<td>

```csharp
public bool autoApplyAnyPrefabOverrides = false;
```

</td>
<td>Enables automatic application of prefab overrides in editor mode.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.autoApplyOverridesCoroutine"></a>
<td><code>autoApplyOverridesCoroutine</code></td>
<td>

```csharp
private Coroutine autoApplyOverridesCoroutine;
```

</td>
<td>Coroutine handle for automatic prefab override processing.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX._instance"></a>
<td><code>_instance</code></td>
<td>

```csharp
private static PathweaveUIX _instance = null;
```

</td>
<td>Singleton instance reference.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX._isAnimating"></a>
<td><code>_isAnimating</code></td>
<td>

```csharp
private bool _isAnimating = false;
```

</td>
<td>Internal flag indicating whether UI transition animation is in progress.</td>
</tr>
</table>

## Properties

<table>
<tr>
<th>Property</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.RouteData"></a>
<td><code>RouteData</code></td>
<td>

```csharp
public string RouteData { get; set; }
```

</td>
<td>Gets or sets hash-based route data associated with the current UI path.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPageFullPath"></a>
<td><code>LastPageFullPath</code></td>
<td>

```csharp
public string LastPageFullPath { get; private set; }
```

</td>
<td>Stores the previous full navigation path.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.FullPagePath"></a>
<td><code>FullPagePath</code></td>
<td>

```csharp
public string FullPagePath { get; set; }
```

</td>
<td>Full navigation path including route data hash.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPagePath"></a>
<td><code>LastPagePath</code></td>
<td>

```csharp
public string LastPagePath { get; }
```

</td>
<td>Previous page path without route data.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.PagePath"></a>
<td><code>PagePath</code></td>
<td>

```csharp
public string PagePath { get; set; }
```

</td>
<td>Current navigation path without route data hash.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPageListPath"></a>
<td><code>LastPageListPath</code></td>
<td>

```csharp
public List<string> LastPageListPath { get; }
```

</td>
<td>Split list representation of previous page path.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.PagePathSegments"></a>
<td><code>PagePathSegments</code></td>
<td>

```csharp
public List<string> PagePathSegments { get; set; }
```

</td>
<td>Split list representation of current navigation path.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.LastPage"></a>
<td><code>LastPage</code></td>
<td>

```csharp
public PathweavePage LastPage { get; }
```

</td>
<td>Previously active UI page.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.CurrentPage"></a>
<td><code>CurrentPage</code></td>
<td>

```csharp
public PathweavePage CurrentPage { get; set; }
```

</td>
<td>Currently active UI page based on navigation state.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.Instance"></a>
<td><code>Instance</code></td>
<td>

```csharp
public static PathweaveUIX Instance { get; set; }
```

</td>
<td>Global singleton access point for Pathweave UIX controller.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.IsAnimating"></a>
<td><code>IsAnimating</code></td>
<td>

```csharp
public bool IsAnimating { get; set; }
```

</td>
<td>Indicates whether a UI transition animation is currently running.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Method</th>
<th>Declaration</th>
<th>Description</th>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.UpdatePage"></a>
<td><code>UpdatePage</code></td>
<td>

```csharp
public void UpdatePage(
    PathweavePage _new,
    bool animating = true
)
```

</td>
<td>Switches UI pages and handles transition logic including animations and cleanup of previous pages.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.SetPage"></a>
<td><code>SetPage</code></td>
<td>

```csharp
public void SetPage(string uiName)
```

</td>
<td>Directly sets the current page by name without navigation stack behavior.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateBack"></a>
<td><code>NavigateBack</code></td>
<td>

```csharp
public void NavigateBack()
```

</td>
<td>Returns to the previous page in navigation history.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateBackWithHash"></a>
<td><code>NavigateBackWithHash</code></td>
<td>

```csharp
public void NavigateBackWithHash()
```

</td>
<td>Returns to previous page while preserving route hash data.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.Navigate"></a>
<td><code>Navigate</code></td>
<td>

```csharp
public void Navigate(
    string path
)
```

</td>
<td>Navigates forward by appending a new path segment.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.NavigateWithHash"></a>
<td><code>NavigateWithHash</code></td>
<td>

```csharp
public void NavigateWithHash(
    string path
)
```

</td>
<td>Navigates forward while preserving hash-based route data.</td>
</tr>

<tr>
<a id="ModuDevCore.PathweaveUIX.PathweaveUIX.ClearHash"></a>
<td><code>ClearHash</code></td>
<td>

```csharp
public void ClearHash()
```

</td>
<td>Clears route hash data while keeping the base path intact.</td>
</tr>
</table>

## Enum

None

## Nested Classes

None
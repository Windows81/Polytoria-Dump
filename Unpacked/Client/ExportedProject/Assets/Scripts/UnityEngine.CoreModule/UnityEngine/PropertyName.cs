namespace UnityEngine;

[Token(Token = "0x2000117")]
[UsedByNativeCode]
public struct PropertyName : IEquatable<PropertyName>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000505")]
	internal int id; //Field offset: 0x0

	[Address(RVA = "0x196BC80", Offset = "0x196AE80", Length = "0x1E")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertyNameUtils), Member = "PropertyNameFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Token(Token = "0x6000896")]
	public PropertyName(string name) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000897")]
	public PropertyName(PropertyName other) { }

	[Address(RVA = "0x196BB80", Offset = "0x196AD80", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600089B")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600089C")]
	public override bool Equals(PropertyName other) { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x600089A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x196BC10", Offset = "0x196AE10", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CheckUserKeyArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000898")]
	public static bool IsNullOrEmpty(PropertyName prop) { }

	[Address(RVA = "0x196BCA0", Offset = "0x196AEA0", Length = "0x8")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000899")]
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	[Address(RVA = "0x196BCB0", Offset = "0x196AEB0", Length = "0x9")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseField`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "UnbindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "BindHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "UpdateDataFromColumn", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "set_isContentBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "get_isContentBound", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "set_content", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnController", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnItemsSourceSizeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "OnAddClicked", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseListView", Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CollectionViewController", Member = "set_itemsSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeBindingsUpdater", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "DestroyHeaderContent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnHeaderColumn", Member = "UpdateHeaderTemplate", ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(PropertyNameUtils), Member = "PropertyNameFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Token(Token = "0x600089D")]
	public static PropertyName op_Implicit(string name) { }

	[Address(RVA = "0x196BC20", Offset = "0x196AE20", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600089E")]
	public virtual string ToString() { }

}


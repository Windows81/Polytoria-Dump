namespace Battlehub.UIControls;

[Extension]
[Token(Token = "0x2000050")]
public static class VirtualizingTreeViewExtension
{

	[Address(RVA = "0x7D0B90", Offset = "0x7CFD90", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000379")]
	public static void ExpandAll(VirtualizingTreeView treeView, T item, Func<T, T> getParent, Func<T, IEnumerable> getChildren) { }

	[Address(RVA = "0x7D0D70", Offset = "0x7CFF70", Length = "0x3B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000378")]
	public static void ExpandChildren(VirtualizingTreeView treeView, T item, Func<T, IEnumerable> getChildren) { }

	[Address(RVA = "0x7D1130", Offset = "0x7D0330", Length = "0x23C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000377")]
	public static void ExpandTo(VirtualizingTreeView treeView, T item, Func<T, T> getParent) { }

	[Address(RVA = "0x7D1370", Offset = "0x7D0570", Length = "0x7A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 41)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600037A")]
	public static void ItemDropStdHandler(VirtualizingTreeView treeView, ItemDropArgs e, Func<T, T> getParent, Action<T, T> setParent, Func<T, T, Int32> indexOfChild, Action<T, T> removeChild, Action<T, T, Int32> insertChild, Action<T, T> addChild = null) { }

}


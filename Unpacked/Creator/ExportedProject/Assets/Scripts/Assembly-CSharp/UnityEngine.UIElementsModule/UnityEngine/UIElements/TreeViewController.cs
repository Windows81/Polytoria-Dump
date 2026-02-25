namespace UnityEngine.UIElements;

[Token(Token = "0x200005F")]
public abstract class TreeViewController : BaseTreeViewController
{

	[Token(Token = "0x17000069")]
	protected TreeView treeView
	{
		[Address(RVA = "0x1ACC900", Offset = "0x1ACBB00", Length = "0x72")]
		[CalledBy(Type = typeof(TreeViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(TreeViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000339")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x1ACC8B0", Offset = "0x1ACBAB0", Length = "0x49")]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600033E")]
	protected TreeViewController() { }

	[Address(RVA = "0x1ACC550", Offset = "0x1ACB750", Length = "0x1B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600033B")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x1ACC710", Offset = "0x1ACB910", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033D")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x1ACC900", Offset = "0x1ACBB00", Length = "0x72")]
	[CalledBy(Type = typeof(TreeViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(TreeViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000339")]
	protected TreeView get_treeView() { }

	[Address(RVA = "0x1ACC760", Offset = "0x1ACB960", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033A")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x1ACC860", Offset = "0x1ACBA60", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600033C")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}


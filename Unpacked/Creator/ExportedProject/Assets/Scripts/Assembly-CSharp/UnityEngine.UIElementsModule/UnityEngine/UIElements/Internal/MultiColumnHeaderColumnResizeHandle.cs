namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000643")]
internal class MultiColumnHeaderColumnResizeHandle : VisualElement
{
	[Token(Token = "0x400176C")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400176D")]
	public static readonly string dragAreaUssClassName; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400176E")]
	private readonly VisualElement <dragArea>k__BackingField; //Field offset: 0x2D0

	[Token(Token = "0x17000B43")]
	public VisualElement dragArea
	{
		[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C30")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1BF51E0", Offset = "0x1BF43E0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C32")]
	private static MultiColumnHeaderColumnResizeHandle() { }

	[Address(RVA = "0x1BF52D0", Offset = "0x1BF44D0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C31")]
	public MultiColumnHeaderColumnResizeHandle() { }

	[Address(RVA = "0xFA13A0", Offset = "0xFA05A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C30")]
	public VisualElement get_dragArea() { }

}


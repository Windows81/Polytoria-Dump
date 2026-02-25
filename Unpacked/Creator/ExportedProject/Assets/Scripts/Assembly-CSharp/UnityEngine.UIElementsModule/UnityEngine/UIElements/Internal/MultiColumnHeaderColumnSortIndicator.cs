namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000640")]
internal class MultiColumnHeaderColumnSortIndicator : VisualElement
{
	[Token(Token = "0x400174E")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400174F")]
	public static readonly string arrowUssClassName; //Field offset: 0x8
	[Token(Token = "0x4001750")]
	public static readonly string indexLabelUssClassName; //Field offset: 0x10
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4001751")]
	private Label m_IndexLabel; //Field offset: 0x2D0

	[Token(Token = "0x17000B3B")]
	public string sortOrderLabel
	{
		[Address(RVA = "0x1BF58F0", Offset = "0x1BF4AF0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002C0D")]
		 set { } //Length: 45
	}

	[Address(RVA = "0x1BF5610", Offset = "0x1BF4810", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C0F")]
	private static MultiColumnHeaderColumnSortIndicator() { }

	[Address(RVA = "0x1BF5760", Offset = "0x1BF4960", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C0E")]
	public MultiColumnHeaderColumnSortIndicator() { }

	[Address(RVA = "0x1BF58F0", Offset = "0x1BF4AF0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C0D")]
	public void set_sortOrderLabel(string value) { }

}


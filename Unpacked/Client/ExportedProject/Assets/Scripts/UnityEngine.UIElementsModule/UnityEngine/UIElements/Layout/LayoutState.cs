namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005F1")]
internal struct LayoutState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015BF")]
	public IntPtr measureFunctionCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40015C0")]
	public IntPtr baselineFunctionCallback; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015C1")]
	public IntPtr unusedExceptionPointer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40015C2")]
	public uint depth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40015C3")]
	public uint currentGenerationCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015C4")]
	public bool error; //Field offset: 0x20

	[Token(Token = "0x17000A89")]
	public static LayoutState Default
	{
		[Address(RVA = "0x1BAEFB0", Offset = "0x1BAE1B0", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60029A4")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x1BAEFB0", Offset = "0x1BAE1B0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60029A4")]
	public static LayoutState get_Default() { }

}


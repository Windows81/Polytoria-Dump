namespace UnityEngine.UIElements;

[Token(Token = "0x20002BB")]
internal struct SafeHandleAccess
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AFB")]
	private IntPtr m_Handle; //Field offset: 0x0

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001306")]
	public SafeHandleAccess(IntPtr ptr) { }

	[Address(RVA = "0x1C8DF90", Offset = "0x1C8D190", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001307")]
	public bool IsNull() { }

	[Address(RVA = "0x1C8DFA0", Offset = "0x1C8D1A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001308")]
	public static IntPtr op_Implicit(SafeHandleAccess a) { }

}


namespace System.Buffers.Text;

[Token(Token = "0x200061A")]
internal static class ParserHelpers
{
	[Token(Token = "0x40018AC")]
	public static readonly Byte[] s_hexLookup; //Field offset: 0x0

	[Address(RVA = "0x1445F50", Offset = "0x1445150", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C7D")]
	private static ParserHelpers() { }

	[Address(RVA = "0x1445F40", Offset = "0x1445140", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C7C")]
	public static bool IsDigit(int i) { }

}


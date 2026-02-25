namespace System.Runtime.Versioning;

[Token(Token = "0x20003C1")]
internal static class BinaryCompatibility
{
	[Token(Token = "0x4000F0F")]
	public static readonly bool TargetsAtLeast_Desktop_V4_5; //Field offset: 0x0
	[Token(Token = "0x4000F10")]
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; //Field offset: 0x1

	[Address(RVA = "0x1378B10", Offset = "0x1377D10", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001CC0")]
	private static BinaryCompatibility() { }

}


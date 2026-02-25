namespace System.Security.Cryptography;

[Token(Token = "0x20002DA")]
public static class CryptographicOperations
{

	[Address(RVA = "0x1322600", Offset = "0x1321800", Length = "0x43")]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(System.ReadOnlySpan`1<System.Byte>))]
	[CalledBy(Type = "System.Security.Cryptography.CryptoStream+<ReadAsyncCore>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187F20")]
	[Token(Token = "0x6001778")]
	public static void ZeroMemory(Span<Byte> buffer) { }

}


namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F3")]
public class HMACSHA512 : HMAC
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CD7")]
	private bool m_useLegacyBlockSize; //Field offset: 0x68

	[Token(Token = "0x17000272")]
	private int BlockSize
	{
		[Address(RVA = "0x1337DA0", Offset = "0x1336FA0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E7")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x1337EC0", Offset = "0x13370C0", Length = "0x109")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HMAC), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017E5")]
	public HMACSHA512() { }

	[Address(RVA = "0x1337DC0", Offset = "0x1336FC0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HMAC), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017E6")]
	public HMACSHA512(Byte[] key) { }

	[Address(RVA = "0x1337DA0", Offset = "0x1336FA0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E7")]
	private int get_BlockSize() { }

}


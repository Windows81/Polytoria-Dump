namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F1")]
public class HMACSHA256 : HMAC
{

	[Address(RVA = "0x13379C0", Offset = "0x1336BC0", Length = "0xE4")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HMAC), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60017E0")]
	public HMACSHA256() { }

	[Address(RVA = "0x1337AB0", Offset = "0x1336CB0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HMAC), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60017E1")]
	public HMACSHA256(Byte[] key) { }

}


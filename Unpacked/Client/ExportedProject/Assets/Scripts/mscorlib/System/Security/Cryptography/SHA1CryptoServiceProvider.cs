namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000321")]
public sealed class SHA1CryptoServiceProvider : SHA1
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D67")]
	private SHA1Internal sha; //Field offset: 0x28

	[Address(RVA = "0x134DDB0", Offset = "0x134CFB0", Length = "0xFB")]
	[CalledBy(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SHA1Internal), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001921")]
	public SHA1CryptoServiceProvider() { }

	[Address(RVA = "0x134DB30", Offset = "0x134CD30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashAlgorithm), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001923")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x134A640", Offset = "0x1349840", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001922")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x134DB40", Offset = "0x134CD40", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001924")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x134DC90", Offset = "0x134CE90", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001925")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x134DD90", Offset = "0x134CF90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SHA1Internal), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001926")]
	public virtual void Initialize() { }

}


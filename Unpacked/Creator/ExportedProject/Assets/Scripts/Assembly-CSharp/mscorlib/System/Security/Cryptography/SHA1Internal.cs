namespace System.Security.Cryptography;

[Token(Token = "0x2000320")]
internal class SHA1Internal
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D62")]
	private UInt32[] _H; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D63")]
	private ulong count; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D64")]
	private Byte[] _ProcessingBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D65")]
	private int _ProcessingBufferCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D66")]
	private UInt32[] buff; //Field offset: 0x30

	[Address(RVA = "0x134F6C0", Offset = "0x134E8C0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SHA1Internal), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001918")]
	public SHA1Internal() { }

	[Address(RVA = "0x134DEB0", Offset = "0x134D0B0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001920")]
	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	[Address(RVA = "0x134DF90", Offset = "0x134D190", Length = "0x327")]
	[CalledBy(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600191E")]
	private static void FillBuff(UInt32[] buff) { }

	[Address(RVA = "0x134E2C0", Offset = "0x134D4C0", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001919")]
	public void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x134E400", Offset = "0x134D600", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600191A")]
	public Byte[] HashFinal() { }

	[Address(RVA = "0x134E4F0", Offset = "0x134D6F0", Length = "0x776")]
	[CalledBy(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600191D")]
	private static void InitialiseBuff(UInt32[] buff, Byte[] input, uint inputOffset) { }

	[Address(RVA = "0x134EC70", Offset = "0x134DE70", Length = "0x8B")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SHA1Internal), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600191B")]
	public void Initialize() { }

	[Address(RVA = "0x134ED00", Offset = "0x134DF00", Length = "0x76F")]
	[CalledBy(Type = typeof(SHA1Internal), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1Internal), Member = "ProcessFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "HashCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SHA1Internal), Member = "InitialiseBuff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1Internal), Member = "FillBuff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600191C")]
	private void ProcessBlock(Byte[] inputBuffer, uint inputOffset) { }

	[Address(RVA = "0x134F470", Offset = "0x134E670", Length = "0x243")]
	[CalledBy(Type = typeof(SHA1Internal), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "HashFinal", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SHA1Internal), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600191F")]
	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}


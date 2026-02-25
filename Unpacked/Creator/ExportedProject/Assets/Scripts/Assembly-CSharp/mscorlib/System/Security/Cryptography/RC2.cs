namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FA")]
public abstract class RC2 : SymmetricAlgorithm
{
	[Token(Token = "0x4000CE3")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000CE4")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CE2")]
	protected int EffectiveKeySizeValue; //Field offset: 0x48

	[Token(Token = "0x1700027D")]
	public override int EffectiveKeySize
	{
		[Address(RVA = "0x1339070", Offset = "0x1338270", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600180D")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700027E")]
	public virtual int KeySize
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600180E")]
		 get { } //Length: 4
		[Address(RVA = "0x1339080", Offset = "0x1338280", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600180F")]
		 set { } //Length: 126
	}

	[Address(RVA = "0x1338E60", Offset = "0x1338060", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001810")]
	private static RC2() { }

	[Address(RVA = "0x1338FD0", Offset = "0x13381D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600180C")]
	protected RC2() { }

	[Address(RVA = "0x1339070", Offset = "0x1338270", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600180D")]
	public override int get_EffectiveKeySize() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600180E")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1339080", Offset = "0x1338280", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = "set_KeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600180F")]
	public virtual void set_KeySize(int value) { }

}


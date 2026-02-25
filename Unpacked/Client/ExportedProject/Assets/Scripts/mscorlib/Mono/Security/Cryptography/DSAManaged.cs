namespace Mono.Security.Cryptography;

[Token(Token = "0x200006D")]
internal class DSAManaged : DSA
{
	[Token(Token = "0x200006E")]
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x3EACB0", Offset = "0x3E9EB0", Length = "0x125")]
		[CallerCount(Count = 71)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C3")]
		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C4")]
		public override void Invoke(object sender, EventArgs e) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000214")]
	private bool keypairGenerated; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000215")]
	private bool m_disposed; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000216")]
	private BigInteger p; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000217")]
	private BigInteger q; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000218")]
	private BigInteger g; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000219")]
	private BigInteger x; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400021A")]
	private BigInteger y; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400021B")]
	private BigInteger j; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400021C")]
	private BigInteger seed; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400021D")]
	private int counter; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400021E")]
	private bool j_missing; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400021F")]
	private RandomNumberGenerator rng; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000220")]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x70

	[Token(Token = "0x14000002")]
	public event KeyGeneratedEventHandler KeyGenerated
	{
		[Address(RVA = "0x12F05B0", Offset = "0x12EF7B0", Length = "0x9E")]
		[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60001C1")]
		 add { } //Length: 158
		[Address(RVA = "0x12F07C0", Offset = "0x12EF9C0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60001C2")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1700002D")]
	public virtual int KeySize
	{
		[Address(RVA = "0x12F06F0", Offset = "0x12EF8F0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 43
	}

	[Token(Token = "0x1700002E")]
	public bool PublicOnly
	{
		[Address(RVA = "0x12F0720", Offset = "0x12EF920", Length = "0x5E")]
		[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 94
	}

	[Token(Token = "0x1700002C")]
	private RandomNumberGenerator Random
	{
		[Address(RVA = "0x12F0780", Offset = "0x12EF980", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001B9")]
		private get { } //Length: 59
	}

	[Address(RVA = "0x12F04E0", Offset = "0x12EF6E0", Length = "0xCA")]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001B3")]
	public DSAManaged(int dwKeySize) { }

	[Address(RVA = "0x12F0650", Offset = "0x12EF850", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B7")]
	private void add(Byte[] a, Byte[] b, int value) { }

	[Address(RVA = "0x12F05B0", Offset = "0x12EF7B0", Length = "0x9E")]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60001C1")]
	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	[Address(RVA = "0x12EE7A0", Offset = "0x12ED9A0", Length = "0x2B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60001C0")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x12EEA60", Offset = "0x12EDC60", Length = "0x3A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DSAManaged), Member = "NormalizeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BigInteger), Member = "GetBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[Calls(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001BD")]
	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B4")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x12EF9F0", Offset = "0x12EEBF0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DSAManaged), Member = "GenerateParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DSAManaged), Member = "GenerateKeyPair", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001B5")]
	private void Generate() { }

	[Address(RVA = "0x12EEE10", Offset = "0x12EE010", Length = "0x240")]
	[CalledBy(Type = typeof(DSAManaged), Member = "Generate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DSAParameters))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RandomNumberGenerator)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BigInteger), Member = "Randomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RandomNumberGenerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ModulusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ModulusRing), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001B6")]
	private void GenerateKeyPair() { }

	[Address(RVA = "0x12EF060", Offset = "0x12EE260", Length = "0x984")]
	[CalledBy(Type = typeof(DSAManaged), Member = "Generate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DSAParameters))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RandomNumberGenerator)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_Rng", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "MultiplyByDword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(uint)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "IsProbablePrime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B8")]
	private void GenerateParams(int keyLength) { }

	[Address(RVA = "0x12F06F0", Offset = "0x12EF8F0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BA")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x12F0720", Offset = "0x12EF920", Length = "0x5E")]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "OnKeyGenerated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(EventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001BB")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x12F0780", Offset = "0x12EF980", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001B9")]
	private RandomNumberGenerator get_Random() { }

	[Address(RVA = "0x12EFA40", Offset = "0x12EEC40", Length = "0x42A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = typeof(BigInteger), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60001BE")]
	public virtual void ImportParameters(DSAParameters parameters) { }

	[Address(RVA = "0x12EFE70", Offset = "0x12EF070", Length = "0xAD")]
	[CalledBy(Type = typeof(DSAManaged), Member = "ExportParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DSAParameters))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001BC")]
	private Byte[] NormalizeArray(Byte[] array) { }

	[Address(RVA = "0x12F07C0", Offset = "0x12EF9C0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60001C2")]
	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	[Address(RVA = "0x12EFF20", Offset = "0x12EF120", Length = "0x5BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(BigInteger), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BigInteger), Member = "ModPow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "multiByteDivide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.Math.BigInteger+Kernel", Member = "modInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60001BF")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}


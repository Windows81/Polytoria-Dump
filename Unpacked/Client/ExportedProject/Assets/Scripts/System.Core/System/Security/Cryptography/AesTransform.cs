namespace System.Security.Cryptography;

[Token(Token = "0x2000015")]
internal class AesTransform : SymmetricTransform
{
	[Token(Token = "0x4000005")]
	private static readonly UInt32[] Rcon; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static readonly Byte[] SBox; //Field offset: 0x8
	[Token(Token = "0x4000007")]
	private static readonly Byte[] iSBox; //Field offset: 0x10
	[Token(Token = "0x4000008")]
	private static readonly UInt32[] T0; //Field offset: 0x18
	[Token(Token = "0x4000009")]
	private static readonly UInt32[] T1; //Field offset: 0x20
	[Token(Token = "0x400000A")]
	private static readonly UInt32[] T2; //Field offset: 0x28
	[Token(Token = "0x400000B")]
	private static readonly UInt32[] T3; //Field offset: 0x30
	[Token(Token = "0x400000C")]
	private static readonly UInt32[] iT0; //Field offset: 0x38
	[Token(Token = "0x400000D")]
	private static readonly UInt32[] iT1; //Field offset: 0x40
	[Token(Token = "0x400000E")]
	private static readonly UInt32[] iT2; //Field offset: 0x48
	[Token(Token = "0x400000F")]
	private static readonly UInt32[] iT3; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000002")]
	private UInt32[] expandedKey; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000003")]
	private int Nk; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000004")]
	private int Nr; //Field offset: 0x64

	[Address(RVA = "0x1571410", Offset = "0x1570610", Length = "0x448")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000050")]
	private static AesTransform() { }

	[Address(RVA = "0x1571860", Offset = "0x1570A60", Length = "0x7DA")]
	[CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(AesCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(AesTransform), Member = "SubByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = "Mono.Security.Cryptography.SymmetricTransform", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004B")]
	public AesTransform(Aes algo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x156B710", Offset = "0x156A910", Length = "0x2DF6")]
	[CalledBy(Type = typeof(AesTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600004F")]
	private void Decrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	[Address(RVA = "0x156E510", Offset = "0x156D710", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AesTransform), Member = "Decrypt128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AesTransform), Member = "Encrypt128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600004C")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x156E540", Offset = "0x156D740", Length = "0x2DC4")]
	[CalledBy(Type = typeof(AesTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600004E")]
	private void Encrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	[Address(RVA = "0x1571310", Offset = "0x1570510", Length = "0xF2")]
	[CalledBy(Type = typeof(AesTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Aes), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600004D")]
	private uint SubByte(uint a) { }

}


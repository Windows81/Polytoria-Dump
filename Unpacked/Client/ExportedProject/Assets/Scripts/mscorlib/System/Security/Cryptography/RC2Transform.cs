namespace System.Security.Cryptography;

[Token(Token = "0x200031C")]
internal class RC2Transform : SymmetricTransform
{
	[Token(Token = "0x4000D5D")]
	private static readonly Byte[] pitable; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D57")]
	private ushort R0; //Field offset: 0x58
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000D58")]
	private ushort R1; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000D59")]
	private ushort R2; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5E")]
	[Token(Token = "0x4000D5A")]
	private ushort R3; //Field offset: 0x5E
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D5B")]
	private UInt16[] K; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D5C")]
	private int j; //Field offset: 0x68

	[Address(RVA = "0x134CA90", Offset = "0x134BC90", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001907")]
	private static RC2Transform() { }

	[Address(RVA = "0x134CB20", Offset = "0x134BD20", Length = "0x5EE")]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(KeySizes), Member = "IsLegalKeySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeySizes[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(SymmetricTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001905")]
	public RC2Transform(RC2 rc2Algo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x134BF50", Offset = "0x134B150", Length = "0xB39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001906")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

}


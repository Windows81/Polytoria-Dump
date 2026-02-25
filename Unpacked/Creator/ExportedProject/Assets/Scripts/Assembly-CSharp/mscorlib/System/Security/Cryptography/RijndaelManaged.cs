namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FD")]
public sealed class RijndaelManaged : Rijndael
{

	[Address(RVA = "0x13410C0", Offset = "0x13402C0", Length = "0x15B")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600181A")]
	public RijndaelManaged() { }

	[Address(RVA = "0x1340D70", Offset = "0x133FF70", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(int), typeof(PaddingMode), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600181C")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1340E60", Offset = "0x1340060", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(int), typeof(PaddingMode), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600181B")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1340F50", Offset = "0x1340150", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600181E")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x1340F90", Offset = "0x1340190", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600181D")]
	public virtual void GenerateKey() { }

	[Address(RVA = "0x1340FD0", Offset = "0x13401D0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RijndaelManagedTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CipherMode), typeof(Byte[]), typeof(int), typeof(int), typeof(PaddingMode), typeof(RijndaelManagedTransformMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600181F")]
	private ICryptoTransform NewEncryptor(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}


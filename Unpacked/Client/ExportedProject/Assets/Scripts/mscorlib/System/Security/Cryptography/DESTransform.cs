namespace System.Security.Cryptography;

[Token(Token = "0x2000319")]
internal class DESTransform : SymmetricTransform
{
	[Token(Token = "0x4000D3D")]
	internal static readonly int KEY_BIT_SIZE; //Field offset: 0x0
	[Token(Token = "0x4000D3E")]
	internal static readonly int KEY_BYTE_SIZE; //Field offset: 0x4
	[Token(Token = "0x4000D3F")]
	internal static readonly int BLOCK_BIT_SIZE; //Field offset: 0x8
	[Token(Token = "0x4000D40")]
	internal static readonly int BLOCK_BYTE_SIZE; //Field offset: 0xC
	[Token(Token = "0x4000D44")]
	private static readonly UInt32[] spBoxes; //Field offset: 0x10
	[Token(Token = "0x4000D45")]
	private static readonly Byte[] PC1; //Field offset: 0x18
	[Token(Token = "0x4000D46")]
	private static readonly Byte[] leftRotTotal; //Field offset: 0x20
	[Token(Token = "0x4000D47")]
	private static readonly Byte[] PC2; //Field offset: 0x28
	[Token(Token = "0x4000D48")]
	internal static readonly UInt32[] ipTab; //Field offset: 0x30
	[Token(Token = "0x4000D49")]
	internal static readonly UInt32[] fpTab; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D41")]
	private Byte[] keySchedule; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D42")]
	private Byte[] byteBuff; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D43")]
	private UInt32[] dwordBuff; //Field offset: 0x68

	[Address(RVA = "0x1349980", Offset = "0x1348B80", Length = "0x2E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60018EF")]
	private static DESTransform() { }

	[Address(RVA = "0x1349C70", Offset = "0x1348E70", Length = "0x323")]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(ICryptoTransform))]
	[CalledBy(Type = typeof(TripleDESTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TripleDES), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(DESTransform), Member = "SetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SymmetricTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60018E7")]
	internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x13488D0", Offset = "0x1347AD0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018EA")]
	private static void BSwap(Byte[] byteBuff) { }

	[Address(RVA = "0x1348960", Offset = "0x1347B60", Length = "0x2C1")]
	[CalledBy(Type = typeof(DESTransform), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018E8")]
	private uint CipherFunct(uint r, int n) { }

	[Address(RVA = "0x1348C30", Offset = "0x1347E30", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DESTransform), Member = "Permutation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[]), typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DESTransform), Member = "ProcessBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60018ED")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1348D00", Offset = "0x1347F00", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KeyBuilder), Member = "Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x60018EE")]
	internal static Byte[] GetStrongKey() { }

	[Address(RVA = "0x1348DB0", Offset = "0x1347FB0", Length = "0x38B")]
	[CalledBy(Type = typeof(DESTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018E9")]
	internal static void Permutation(Byte[] input, Byte[] output, UInt32[] permTab, bool preSwap) { }

	[Address(RVA = "0x1349140", Offset = "0x1348340", Length = "0x44A")]
	[CalledBy(Type = typeof(DESTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TripleDESTransform), Member = "ECB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DESTransform), Member = "CipherFunct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60018EC")]
	public void ProcessBlock(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1349590", Offset = "0x1348790", Length = "0x3E8")]
	[CalledBy(Type = typeof(DESTransform), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymmetricAlgorithm), typeof(bool), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60018EB")]
	internal void SetKey(Byte[] key) { }

}


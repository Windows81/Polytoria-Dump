namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FC")]
public abstract class Rijndael : SymmetricAlgorithm
{
	[Token(Token = "0x4000CE7")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000CE8")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	[Address(RVA = "0x1341220", Offset = "0x1340420", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001819")]
	private static Rijndael() { }

	[Address(RVA = "0x1341390", Offset = "0x1340590", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001818")]
	protected Rijndael() { }

}


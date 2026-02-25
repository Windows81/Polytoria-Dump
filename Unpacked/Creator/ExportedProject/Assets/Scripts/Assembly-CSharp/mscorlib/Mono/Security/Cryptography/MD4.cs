namespace Mono.Security.Cryptography;

[Token(Token = "0x2000067")]
internal abstract class MD4 : HashAlgorithm
{

	[Address(RVA = "0x12CAE20", Offset = "0x12CA020", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000173")]
	protected MD4() { }

	[Address(RVA = "0x12F55E0", Offset = "0x12F47E0", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	public static MD4 Create() { }

}


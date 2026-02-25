namespace Mono.Security.Cryptography;

[Token(Token = "0x2000065")]
internal abstract class MD2 : HashAlgorithm
{

	[Address(RVA = "0x12CAE20", Offset = "0x12CA020", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	protected MD2() { }

	[Address(RVA = "0x12F50A0", Offset = "0x12F42A0", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600016B")]
	public static MD2 Create() { }

}


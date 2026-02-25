namespace Mono.Security.Cryptography;

[Token(Token = "0x2000049")]
public abstract class MD2 : HashAlgorithm
{

	[Address(RVA = "0x12CAE20", Offset = "0x12CA020", Length = "0x1D")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000182")]
	protected MD2() { }

	[Address(RVA = "0x12CAD10", Offset = "0x12C9F10", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000183")]
	public static MD2 Create() { }

}


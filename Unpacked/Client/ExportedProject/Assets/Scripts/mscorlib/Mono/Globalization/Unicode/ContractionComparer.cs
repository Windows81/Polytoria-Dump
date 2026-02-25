namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000052")]
internal class ContractionComparer : IComparer<Contraction>
{
	[Token(Token = "0x4000163")]
	public static readonly ContractionComparer Instance; //Field offset: 0x0

	[Address(RVA = "0x12D7A90", Offset = "0x12D6C90", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BF")]
	private static ContractionComparer() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BE")]
	public ContractionComparer() { }

	[Address(RVA = "0x12D7990", Offset = "0x12D6B90", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000BD")]
	public override int Compare(Contraction c1, Contraction c2) { }

}


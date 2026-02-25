namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000401")]
internal sealed class BinaryCrossAppDomainAssembly
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FFF")]
	internal int assemId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001000")]
	internal int assemblyIndex; //Field offset: 0x14

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE5")]
	internal BinaryCrossAppDomainAssembly() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE7")]
	public void Dump() { }

	[Address(RVA = "0x1399BA0", Offset = "0x1398DA0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE6")]
	public override void Read(__BinaryParser input) { }

}


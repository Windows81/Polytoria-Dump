namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000406")]
internal sealed class BinaryCrossAppDomainString
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001014")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001015")]
	internal int value; //Field offset: 0x14

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF9")]
	internal BinaryCrossAppDomainString() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFB")]
	public void Dump() { }

	[Address(RVA = "0x1399BA0", Offset = "0x1398DA0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFA")]
	public override void Read(__BinaryParser input) { }

}


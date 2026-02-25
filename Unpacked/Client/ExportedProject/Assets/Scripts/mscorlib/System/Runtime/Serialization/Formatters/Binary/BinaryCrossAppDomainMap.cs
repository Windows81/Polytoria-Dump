namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000407")]
internal sealed class BinaryCrossAppDomainMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001016")]
	internal int crossAppDomainArrayIndex; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFC")]
	internal BinaryCrossAppDomainMap() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFE")]
	public void Dump() { }

	[Address(RVA = "0x1399C10", Offset = "0x1398E10", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DFD")]
	public override void Read(__BinaryParser input) { }

}


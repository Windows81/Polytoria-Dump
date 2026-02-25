namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000402")]
internal sealed class BinaryObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001001")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001002")]
	internal int mapId; //Field offset: 0x14

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE8")]
	internal BinaryObject() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DEC")]
	public void Dump() { }

	[Address(RVA = "0x1399BA0", Offset = "0x1398DA0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DEB")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x139B9D0", Offset = "0x139ABD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001DE9")]
	internal void Set(int objectId, int mapId) { }

	[Address(RVA = "0x139B9E0", Offset = "0x139ABE0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001DEA")]
	public override void Write(__BinaryWriter sout) { }

}


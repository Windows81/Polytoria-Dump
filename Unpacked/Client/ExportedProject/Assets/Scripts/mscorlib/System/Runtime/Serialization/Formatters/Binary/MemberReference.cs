namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040D")]
internal sealed class MemberReference
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001033")]
	internal int idRef; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E1A")]
	internal MemberReference() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E1E")]
	public void Dump() { }

	[Address(RVA = "0x1399C10", Offset = "0x1398E10", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E1D")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E1B")]
	internal void Set(int idRef) { }

	[Address(RVA = "0x139EC60", Offset = "0x139DE60", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001E1C")]
	public override void Write(__BinaryWriter sout) { }

}


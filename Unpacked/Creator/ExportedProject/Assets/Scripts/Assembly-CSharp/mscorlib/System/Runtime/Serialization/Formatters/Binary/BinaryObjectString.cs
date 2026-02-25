namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000405")]
internal sealed class BinaryObjectString
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001012")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001013")]
	internal string value; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF4")]
	internal BinaryObjectString() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF8")]
	public void Dump() { }

	[Address(RVA = "0x1398B50", Offset = "0x1397D50", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF7")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x1398BC0", Offset = "0x1397DC0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF5")]
	internal void Set(int objectId, string value) { }

	[Address(RVA = "0x139AFA0", Offset = "0x139A1A0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001DF6")]
	public override void Write(__BinaryWriter sout) { }

}


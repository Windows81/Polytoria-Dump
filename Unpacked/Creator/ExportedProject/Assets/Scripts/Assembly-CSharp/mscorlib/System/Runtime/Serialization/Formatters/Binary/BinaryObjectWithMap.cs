namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000409")]
internal sealed class BinaryObjectWithMap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001019")]
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400101A")]
	internal int objectId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400101B")]
	internal string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400101C")]
	internal int numMembers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400101D")]
	internal String[] memberNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400101E")]
	internal int assemId; //Field offset: 0x30

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E04")]
	internal BinaryObjectWithMap() { }

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E05")]
	internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E09")]
	public void Dump() { }

	[Address(RVA = "0x139B6A0", Offset = "0x139A8A0", Length = "0x186")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001E08")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x139B830", Offset = "0x139AA30", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E06")]
	internal void Set(int objectId, string name, int numMembers, String[] memberNames, int assemId) { }

	[Address(RVA = "0x139B890", Offset = "0x139AA90", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001E07")]
	public override void Write(__BinaryWriter sout) { }

}


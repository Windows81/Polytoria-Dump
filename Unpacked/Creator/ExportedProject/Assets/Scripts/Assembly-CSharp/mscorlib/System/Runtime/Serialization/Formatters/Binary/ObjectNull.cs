namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040E")]
internal sealed class ObjectNull
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001034")]
	internal int nullCount; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E1F")]
	internal ObjectNull() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E23")]
	public void Dump() { }

	[Address(RVA = "0x139F850", Offset = "0x139EA50", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001E22")]
	public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E20")]
	internal void SetNullCount(int nullCount) { }

	[Address(RVA = "0x139F8F0", Offset = "0x139EAF0", Length = "0xF4")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteNullMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "CheckForNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001E21")]
	public override void Write(__BinaryWriter sout) { }

}


namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040B")]
internal sealed class BinaryArray
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001028")]
	internal int objectId; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001029")]
	internal int rank; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400102A")]
	internal Int32[] lengthA; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400102B")]
	internal Int32[] lowerBoundA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400102C")]
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400102D")]
	internal object typeInformation; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400102E")]
	internal int assemId; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400102F")]
	private BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001030")]
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; //Field offset: 0x40

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E0F")]
	internal BinaryArray() { }

	[Address(RVA = "0x13989F0", Offset = "0x1397BF0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E10")]
	internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x1397F00", Offset = "0x1397100", Length = "0x230")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001E13")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x13985C0", Offset = "0x13977C0", Length = "0xC0")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E11")]
	internal void Set(int objectId, int rank, Int32[] lengthA, Int32[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	[Address(RVA = "0x1398680", Offset = "0x1397880", Length = "0x367")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BinaryConverter), Member = "WriteTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(int), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 14)]
	[Token(Token = "0x6001E12")]
	public override void Write(__BinaryWriter sout) { }

}


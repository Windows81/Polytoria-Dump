namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000420")]
internal sealed class ParseRecord
{
	[Token(Token = "0x400111C")]
	internal static int parseRecordIdCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400111D")]
	internal InternalParseTypeE PRparseTypeEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400111E")]
	internal InternalObjectTypeE PRobjectTypeEnum; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400111F")]
	internal InternalArrayTypeE PRarrayTypeEnum; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001120")]
	internal InternalMemberTypeE PRmemberTypeEnum; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001121")]
	internal InternalMemberValueE PRmemberValueEnum; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001122")]
	internal InternalObjectPositionE PRobjectPositionEnum; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001123")]
	internal string PRname; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001124")]
	internal string PRvalue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001125")]
	internal object PRvarValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001126")]
	internal string PRkeyDt; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001127")]
	internal Type PRdtType; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001128")]
	internal InternalPrimitiveTypeE PRdtTypeCode; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001129")]
	internal bool PRisEnum; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400112A")]
	internal long PRobjectId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400112B")]
	internal long PRidRef; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400112C")]
	internal string PRarrayElementTypeString; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400112D")]
	internal Type PRarrayElementType; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400112E")]
	internal bool PRisArrayVariant; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400112F")]
	internal InternalPrimitiveTypeE PRarrayElementTypeCode; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001130")]
	internal int PRrank; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001131")]
	internal Int32[] PRlengthA; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001132")]
	internal Int32[] PRpositionA; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001133")]
	internal Int32[] PRlowerBoundA; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001134")]
	internal Int32[] PRupperBoundA; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001135")]
	internal Int32[] PRindexMap; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001136")]
	internal int PRmemberIndex; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4001137")]
	internal int PRlinearlength; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001138")]
	internal Int32[] PRrectangularMap; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001139")]
	internal bool PRisLowerBound; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400113A")]
	internal long PRtopId; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400113B")]
	internal long PRheaderId; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400113C")]
	internal ReadObjectInfo PRobjectInfo; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400113D")]
	internal bool PRisValueTypeFixup; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400113E")]
	internal object PRnewObj; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400113F")]
	internal Object[] PRobjectA; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001140")]
	internal PrimitiveArray PRprimitiveArray; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4001141")]
	internal bool PRisRegistered; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001142")]
	internal Object[] PRmemberData; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001143")]
	internal SerializationInfo PRsi; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001144")]
	internal int PRnullCount; //Field offset: 0x118

	[Address(RVA = "0x13C0540", Offset = "0x13BF740", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001F23")]
	private static ParseRecord() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F21")]
	internal ParseRecord() { }

	[Address(RVA = "0x13C0370", Offset = "0x13BF570", Length = "0x1C3")]
	[CalledBy(Type = typeof(ObjectProgress), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001F22")]
	internal void Init() { }

}


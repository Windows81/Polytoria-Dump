namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000411")]
internal sealed class ObjectProgress
{
	[Token(Token = "0x4001040")]
	internal static int opRecordIdCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001041")]
	internal bool isInitial; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001042")]
	internal int count; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001043")]
	internal BinaryTypeEnum expectedType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001044")]
	internal object expectedTypeInformation; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001045")]
	internal string name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001046")]
	internal InternalObjectTypeE objectTypeEnum; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001047")]
	internal InternalMemberTypeE memberTypeEnum; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001048")]
	internal InternalMemberValueE memberValueEnum; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001049")]
	internal Type dtType; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400104A")]
	internal int numItems; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400104B")]
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400104C")]
	internal object typeInformation; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400104D")]
	internal int nullCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400104E")]
	internal int memberLength; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400104F")]
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001050")]
	internal Object[] typeInformationA; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001051")]
	internal String[] memberNames; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001052")]
	internal Type[] memberTypes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001053")]
	internal ParseRecord pr; //Field offset: 0x80

	[Address(RVA = "0x139FC30", Offset = "0x139EE30", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001E32")]
	private static ObjectProgress() { }

	[Address(RVA = "0x139FC70", Offset = "0x139EE70", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001E2E")]
	internal ObjectProgress() { }

	[Address(RVA = "0x139F9F0", Offset = "0x139EBF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E30")]
	internal void ArrayCountIncrement(int value) { }

	[Address(RVA = "0x139FA00", Offset = "0x139EC00", Length = "0x157")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E31")]
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	[Address(RVA = "0x139FB60", Offset = "0x139ED60", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E2F")]
	internal void Init() { }

}


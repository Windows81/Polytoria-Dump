namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040A")]
internal sealed class BinaryObjectWithMapTyped
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400101F")]
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001020")]
	internal int objectId; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001021")]
	internal string name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001022")]
	internal int numMembers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001023")]
	internal String[] memberNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001024")]
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001025")]
	internal Object[] typeInformationA; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001026")]
	internal Int32[] memberAssemIds; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001027")]
	internal int assemId; //Field offset: 0x48

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E0A")]
	internal BinaryObjectWithMapTyped() { }

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E0B")]
	internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	[Address(RVA = "0x139B030", Offset = "0x139A230", Length = "0x3A0")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(__BinaryParser), typeof(Int32&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001E0E")]
	public override void Read(__BinaryParser input) { }

	[Address(RVA = "0x139B3E0", Offset = "0x139A5E0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E0C")]
	internal void Set(int objectId, string name, int numMembers, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, int assemId) { }

	[Address(RVA = "0x139B480", Offset = "0x139A680", Length = "0x217")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryConverter), Member = "WriteTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(int), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6001E0D")]
	public override void Write(__BinaryWriter sout) { }

}


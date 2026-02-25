namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000414")]
internal sealed class __BinaryWriter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400108B")]
	internal Stream sout; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400108C")]
	internal FormatterTypeStyle formatterTypeStyle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400108D")]
	internal Hashtable objectMapTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400108E")]
	internal ObjectWriter objectWriter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400108F")]
	internal BinaryWriter dataWriter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001090")]
	internal int m_nestedObjectCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001091")]
	private int nullCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001092")]
	internal BinaryMethodCall binaryMethodCall; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001093")]
	internal BinaryMethodReturn binaryMethodReturn; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001094")]
	internal BinaryObject binaryObject; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001095")]
	internal BinaryObjectWithMap binaryObjectWithMap; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001096")]
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001097")]
	internal BinaryObjectString binaryObjectString; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001098")]
	internal BinaryArray binaryArray; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001099")]
	private Byte[] byteBuffer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400109A")]
	private int chunkSize; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400109B")]
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400109C")]
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400109D")]
	internal ObjectNull objectNull; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400109E")]
	internal MemberReference memberReference; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400109F")]
	internal BinaryAssembly binaryAssembly; //Field offset: 0xA8

	[Address(RVA = "0x13B49A0", Offset = "0x13B3BA0", Length = "0x579")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E50")]
	internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	[Address(RVA = "0x13B1E70", Offset = "0x13B1070", Length = "0xAE")]
	[CallerCount(Count = 34)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E7B")]
	private void InternalWriteItemNull() { }

	[Address(RVA = "0x13B1F20", Offset = "0x13B1120", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E6E")]
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	[Address(RVA = "0x13B2080", Offset = "0x13B1280", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001E7D")]
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E51")]
	internal void WriteBegin() { }

	[Address(RVA = "0x13B21D0", Offset = "0x13B13D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E53")]
	internal void WriteBoolean(bool value) { }

	[Address(RVA = "0x13B2200", Offset = "0x13B1400", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E54")]
	internal void WriteByte(byte value) { }

	[Address(RVA = "0x133BBB0", Offset = "0x133ADB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E55")]
	private void WriteBytes(Byte[] value) { }

	[Address(RVA = "0x13B2230", Offset = "0x13B1430", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E56")]
	private void WriteBytes(Byte[] byteA, int offset, int size) { }

	[Address(RVA = "0x13B2260", Offset = "0x13B1460", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E57")]
	internal void WriteChar(char value) { }

	[Address(RVA = "0x13B2290", Offset = "0x13B1490", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E58")]
	internal void WriteChars(Char[] value) { }

	[Address(RVA = "0x13B22C0", Offset = "0x13B14C0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E62")]
	internal void WriteDateTime(DateTime value) { }

	[Address(RVA = "0x13B2340", Offset = "0x13B1540", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E59")]
	internal void WriteDecimal(decimal value) { }

	[Address(RVA = "0x13B2400", Offset = "0x13B1600", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001E79")]
	internal void WriteDelayedNullItem() { }

	[Address(RVA = "0x13B2410", Offset = "0x13B1610", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5B")]
	internal void WriteDouble(double value) { }

	[Address(RVA = "0x134A3E0", Offset = "0x13495E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E52")]
	internal void WriteEnd() { }

	[Address(RVA = "0x13B2440", Offset = "0x13B1640", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5C")]
	internal void WriteInt16(short value) { }

	[Address(RVA = "0x13B2470", Offset = "0x13B1670", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5D")]
	internal void WriteInt32(int value) { }

	[Address(RVA = "0x13B24A0", Offset = "0x13B16A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5E")]
	internal void WriteInt64(long value) { }

	[Address(RVA = "0x13B2520", Offset = "0x13B1720", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E77")]
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	[Address(RVA = "0x13B24D0", Offset = "0x13B16D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Token(Token = "0x6001E7A")]
	internal void WriteItemEnd() { }

	[Address(RVA = "0x13B24E0", Offset = "0x13B16E0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E7C")]
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	[Address(RVA = "0x13B2580", Offset = "0x13B1780", Length = "0x1FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E6F")]
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	[Address(RVA = "0x13B2910", Offset = "0x13B1B10", Length = "0x1C3")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001E72")]
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	[Address(RVA = "0x13B2780", Offset = "0x13B1980", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E75")]
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	[Address(RVA = "0x13B27B0", Offset = "0x13B19B0", Length = "0xF8")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItemObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001E74")]
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	[Address(RVA = "0x13B28B0", Offset = "0x13B1AB0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001E76")]
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	[Address(RVA = "0x13B2AE0", Offset = "0x13B1CE0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E69")]
	internal void WriteMethodCall() { }

	[Address(RVA = "0x13B2B70", Offset = "0x13B1D70", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E6A")]
	internal void WriteMethodReturn() { }

	[Address(RVA = "0x13B2C00", Offset = "0x13B1E00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Token(Token = "0x6001E78")]
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x13B2C10", Offset = "0x13B1E10", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E73")]
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x13B2E60", Offset = "0x13B2060", Length = "0x8DE")]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(String[]), typeof(Type[]), typeof(Object[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BinaryObjectWithMapTyped), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E6B")]
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, String[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	[Address(RVA = "0x13B2CE0", Offset = "0x13B1EE0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001E71")]
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Byte[] byteA) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E66")]
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[Address(RVA = "0x13B2D40", Offset = "0x13B1F40", Length = "0x112")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMemberString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001E6C")]
	internal void WriteObjectString(int objectId, string value) { }

	[Address(RVA = "0x13B3740", Offset = "0x13B2940", Length = "0x1A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E70")]
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Int32[] lengthA, Int32[] lowerBoundA) { }

	[Address(RVA = "0x13B2200", Offset = "0x13B1400", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E5F")]
	internal void WriteSByte(sbyte value) { }

	[Address(RVA = "0x13B3970", Offset = "0x13B2B70", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001E68")]
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	[Address(RVA = "0x13B38F0", Offset = "0x13B2AF0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E67")]
	internal void WriteSerializationHeaderEnd() { }

	[Address(RVA = "0x13B3F80", Offset = "0x13B3180", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E5A")]
	internal void WriteSingle(float value) { }

	[Address(RVA = "0x13B3AB0", Offset = "0x13B2CB0", Length = "0x488")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObjectByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(Buffer), Member = "InternalBlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Converter), Member = "TypeLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001E6D")]
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	[Address(RVA = "0x13B3FB0", Offset = "0x13B31B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E60")]
	internal void WriteString(string value) { }

	[Address(RVA = "0x13B3FE0", Offset = "0x13B31E0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E61")]
	internal void WriteTimeSpan(TimeSpan value) { }

	[Address(RVA = "0x13B4060", Offset = "0x13B3260", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E63")]
	internal void WriteUInt16(ushort value) { }

	[Address(RVA = "0x13B4090", Offset = "0x13B3290", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E64")]
	internal void WriteUInt32(uint value) { }

	[Address(RVA = "0x13B40C0", Offset = "0x13B32C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E65")]
	internal void WriteUInt64(ulong value) { }

	[Address(RVA = "0x13B40F0", Offset = "0x13B32F0", Length = "0x868")]
	[CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberPrimitiveTyped), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MemberPrimitiveUnTyped), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 13)]
	[Token(Token = "0x6001E7E")]
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }

}


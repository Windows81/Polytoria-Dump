namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000412")]
internal sealed class Converter
{
	[Token(Token = "0x4001054")]
	private static int primitiveTypeEnumLength; //Field offset: 0x0
	[Token(Token = "0x4001055")]
	private static Type[] typeA; //Field offset: 0x8
	[Token(Token = "0x4001056")]
	private static Type[] arrayTypeA; //Field offset: 0x10
	[Token(Token = "0x4001057")]
	private static String[] valueA; //Field offset: 0x18
	[Token(Token = "0x4001058")]
	private static TypeCode[] typeCodeA; //Field offset: 0x20
	[Token(Token = "0x4001059")]
	private static InternalPrimitiveTypeE[] codeA; //Field offset: 0x28
	[Token(Token = "0x400105A")]
	internal static Type typeofISerializable; //Field offset: 0x30
	[Token(Token = "0x400105B")]
	internal static Type typeofString; //Field offset: 0x38
	[Token(Token = "0x400105C")]
	internal static Type typeofConverter; //Field offset: 0x40
	[Token(Token = "0x400105D")]
	internal static Type typeofBoolean; //Field offset: 0x48
	[Token(Token = "0x400105E")]
	internal static Type typeofByte; //Field offset: 0x50
	[Token(Token = "0x400105F")]
	internal static Type typeofChar; //Field offset: 0x58
	[Token(Token = "0x4001060")]
	internal static Type typeofDecimal; //Field offset: 0x60
	[Token(Token = "0x4001061")]
	internal static Type typeofDouble; //Field offset: 0x68
	[Token(Token = "0x4001062")]
	internal static Type typeofInt16; //Field offset: 0x70
	[Token(Token = "0x4001063")]
	internal static Type typeofInt32; //Field offset: 0x78
	[Token(Token = "0x4001064")]
	internal static Type typeofInt64; //Field offset: 0x80
	[Token(Token = "0x4001065")]
	internal static Type typeofSByte; //Field offset: 0x88
	[Token(Token = "0x4001066")]
	internal static Type typeofSingle; //Field offset: 0x90
	[Token(Token = "0x4001067")]
	internal static Type typeofTimeSpan; //Field offset: 0x98
	[Token(Token = "0x4001068")]
	internal static Type typeofDateTime; //Field offset: 0xA0
	[Token(Token = "0x4001069")]
	internal static Type typeofUInt16; //Field offset: 0xA8
	[Token(Token = "0x400106A")]
	internal static Type typeofUInt32; //Field offset: 0xB0
	[Token(Token = "0x400106B")]
	internal static Type typeofUInt64; //Field offset: 0xB8
	[Token(Token = "0x400106C")]
	internal static Type typeofObject; //Field offset: 0xC0
	[Token(Token = "0x400106D")]
	internal static Type typeofSystemVoid; //Field offset: 0xC8
	[Token(Token = "0x400106E")]
	internal static Assembly urtAssembly; //Field offset: 0xD0
	[Token(Token = "0x400106F")]
	internal static string urtAssemblyString; //Field offset: 0xD8
	[Token(Token = "0x4001070")]
	internal static Type typeofTypeArray; //Field offset: 0xE0
	[Token(Token = "0x4001071")]
	internal static Type typeofObjectArray; //Field offset: 0xE8
	[Token(Token = "0x4001072")]
	internal static Type typeofStringArray; //Field offset: 0xF0
	[Token(Token = "0x4001073")]
	internal static Type typeofBooleanArray; //Field offset: 0xF8
	[Token(Token = "0x4001074")]
	internal static Type typeofByteArray; //Field offset: 0x100
	[Token(Token = "0x4001075")]
	internal static Type typeofCharArray; //Field offset: 0x108
	[Token(Token = "0x4001076")]
	internal static Type typeofDecimalArray; //Field offset: 0x110
	[Token(Token = "0x4001077")]
	internal static Type typeofDoubleArray; //Field offset: 0x118
	[Token(Token = "0x4001078")]
	internal static Type typeofInt16Array; //Field offset: 0x120
	[Token(Token = "0x4001079")]
	internal static Type typeofInt32Array; //Field offset: 0x128
	[Token(Token = "0x400107A")]
	internal static Type typeofInt64Array; //Field offset: 0x130
	[Token(Token = "0x400107B")]
	internal static Type typeofSByteArray; //Field offset: 0x138
	[Token(Token = "0x400107C")]
	internal static Type typeofSingleArray; //Field offset: 0x140
	[Token(Token = "0x400107D")]
	internal static Type typeofTimeSpanArray; //Field offset: 0x148
	[Token(Token = "0x400107E")]
	internal static Type typeofDateTimeArray; //Field offset: 0x150
	[Token(Token = "0x400107F")]
	internal static Type typeofUInt16Array; //Field offset: 0x158
	[Token(Token = "0x4001080")]
	internal static Type typeofUInt32Array; //Field offset: 0x160
	[Token(Token = "0x4001081")]
	internal static Type typeofUInt64Array; //Field offset: 0x168
	[Token(Token = "0x4001082")]
	internal static Type typeofMarshalByRefObject; //Field offset: 0x170

	[Address(RVA = "0x139DD30", Offset = "0x139CF30", Length = "0xBE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Assembly), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E43")]
	private static Converter() { }

	[Address(RVA = "0x139BA70", Offset = "0x139AC70", Length = "0x19C")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E3A")]
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	[Address(RVA = "0x139BC50", Offset = "0x139AE50", Length = "0xCE")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Converter), Member = "ToTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TypeCode), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x6001E42")]
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x139BD20", Offset = "0x139AF20", Length = "0x658")]
	[CalledBy(Type = typeof(Converter), Member = "ToArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E38")]
	private static void InitArrayTypeA() { }

	[Address(RVA = "0x139C380", Offset = "0x139B580", Length = "0x1C1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E40")]
	private static void InitCodeA() { }

	[Address(RVA = "0x139C550", Offset = "0x139B750", Length = "0x643")]
	[CalledBy(Type = typeof(Converter), Member = "ToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E37")]
	private static void InitTypeA() { }

	[Address(RVA = "0x139CBA0", Offset = "0x139BDA0", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E3E")]
	private static void InitTypeCodeA() { }

	[Address(RVA = "0x139CD50", Offset = "0x139BF50", Length = "0x35C")]
	[CalledBy(Type = typeof(Converter), Member = "ToComType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E3C")]
	private static void InitValueA() { }

	[Address(RVA = "0x139D0B0", Offset = "0x139C2B0", Length = "0x2E9")]
	[CalledBy(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6001E3B")]
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	[Address(RVA = "0x139D3A0", Offset = "0x139C5A0", Length = "0x2C")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E34")]
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x139D410", Offset = "0x139C610", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Converter), Member = "InitArrayTypeA", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E36")]
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x139D4E0", Offset = "0x139C6E0", Length = "0x11C")]
	[CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Converter), Member = "ToPrimitiveTypeEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Token(Token = "0x6001E33")]
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	[Address(RVA = "0x139D600", Offset = "0x139C800", Length = "0xCC")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Converter), Member = "InitValueA", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E3D")]
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x139D6D0", Offset = "0x139C8D0", Length = "0x283")]
	[CalledBy(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E41")]
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	[Address(RVA = "0x139DBD0", Offset = "0x139CDD0", Length = "0xCC")]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Converter), Member = "InitTypeA", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E39")]
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x139D960", Offset = "0x139CB60", Length = "0x26E")]
	[CalledBy(Type = typeof(Converter), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001E3F")]
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	[Address(RVA = "0x139DCA0", Offset = "0x139CEA0", Length = "0x44")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001E35")]
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

}


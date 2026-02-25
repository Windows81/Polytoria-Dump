namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000428")]
internal sealed class PrimitiveArray
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001167")]
	private InternalPrimitiveTypeE code; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001168")]
	private Boolean[] booleanA; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001169")]
	private Char[] charA; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400116A")]
	private Double[] doubleA; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400116B")]
	private Int16[] int16A; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400116C")]
	private Int32[] int32A; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400116D")]
	private Int64[] int64A; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400116E")]
	private SByte[] sbyteA; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400116F")]
	private Single[] singleA; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001170")]
	private UInt16[] uint16A; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001171")]
	private UInt32[] uint32A; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001172")]
	private UInt64[] uint64A; //Field offset: 0x68

	[Address(RVA = "0x13C11A0", Offset = "0x13C03A0", Length = "0x3D")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PrimitiveArray), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(Array)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F45")]
	internal PrimitiveArray(InternalPrimitiveTypeE code, Array array) { }

	[Address(RVA = "0x13C07E0", Offset = "0x13BF9E0", Length = "0x57C")]
	[CalledBy(Type = typeof(PrimitiveArray), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(Array)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F46")]
	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	[Address(RVA = "0x13C0DA0", Offset = "0x13BFFA0", Length = "0x3BC")]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(long), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(char), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F47")]
	internal void SetValue(string value, int index) { }

}


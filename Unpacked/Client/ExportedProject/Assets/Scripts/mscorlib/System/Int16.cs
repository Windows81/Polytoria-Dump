namespace System;

[IsReadOnly]
[Token(Token = "0x2000100")]
public struct short : IComparable, IConvertible, IFormattable, IComparable<Int16>, IEquatable<Int16>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000417")]
	private readonly short m_value; //Field offset: 0x0

	[Address(RVA = "0x149EA80", Offset = "0x149DC80", Length = "0xAA")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_short", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60007AF")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x149EB30", Offset = "0x149DD30", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60007B0")]
	public override int CompareTo(short value) { }

	[Address(RVA = "0x149EB40", Offset = "0x149DD40", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007B1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x140E7E0", Offset = "0x140D9E0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60007B2")]
	public override bool Equals(short obj) { }

	[Address(RVA = "0x149EBA0", Offset = "0x149DDA0", Length = "0xC")]
	[CalledBy(Type = typeof(Vector`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ShortEnumEqualityComparer`1), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x60007B3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BE")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x149EBB0", Offset = "0x149DDB0", Length = "0xA4")]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	[Token(Token = "0x60007B8")]
	public static short Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x149EC60", Offset = "0x149DE60", Length = "0xB6")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = "System.ComponentModel.Int16Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	[Token(Token = "0x60007B9")]
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x149ED20", Offset = "0x149DF20", Length = "0x189")]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BA")]
	private static short Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x149EEB0", Offset = "0x149E0B0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007BF")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x149EF00", Offset = "0x149E100", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(byte))]
	[Token(Token = "0x60007C2")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x149EF50", Offset = "0x149E150", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(char))]
	[Token(Token = "0x60007C0")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x149EFA0", Offset = "0x149E1A0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007CC")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x149F030", Offset = "0x149E230", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x60007CB")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x149F0A0", Offset = "0x149E2A0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(double))]
	[Token(Token = "0x60007CA")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C3")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x149F0F0", Offset = "0x149E2F0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(int))]
	[Token(Token = "0x60007C5")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x149F140", Offset = "0x149E340", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(long))]
	[Token(Token = "0x60007C7")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x149F190", Offset = "0x149E390", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x60007C1")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x149F1E0", Offset = "0x149E3E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(float))]
	[Token(Token = "0x60007C9")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x149F230", Offset = "0x149E430", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x60007CD")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x149F2C0", Offset = "0x149E4C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x60007C4")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x149F310", Offset = "0x149E510", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60007C6")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x149F360", Offset = "0x149E560", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60007C8")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x149F3B0", Offset = "0x149E5B0", Length = "0x18E")]
	[CalledBy(Type = "System.ComponentModel.Int16Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007B6")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x149F5D0", Offset = "0x149E7D0", Length = "0x7F")]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007B4")]
	public virtual string ToString() { }

	[Address(RVA = "0x149F540", Offset = "0x149E740", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007B5")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x149F650", Offset = "0x149E850", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007B7")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x149F780", Offset = "0x149E980", Length = "0xC5")]
	[CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007BD")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

	[Address(RVA = "0x149F9E0", Offset = "0x149EBE0", Length = "0xBB")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int16&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007BC")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	[Address(RVA = "0x149F850", Offset = "0x149EA50", Length = "0x185")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterInt16Converters>b__18_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(short))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(short))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007BB")]
	public static bool TryParse(string s, out short result) { }

}


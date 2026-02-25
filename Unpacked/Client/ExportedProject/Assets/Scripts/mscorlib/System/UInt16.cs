namespace System;

[CLSCompliant(False)]
[IsReadOnly]
[Token(Token = "0x2000149")]
public struct ushort : IComparable, IConvertible, IFormattable, IComparable<UInt16>, IEquatable<UInt16>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049E")]
	private readonly ushort m_value; //Field offset: 0x0

	[Address(RVA = "0x14CAB00", Offset = "0x14C9D00", Length = "0xAA")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedShort", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000B0A")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x140E480", Offset = "0x140D680", Length = "0x9")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0B")]
	public override int CompareTo(ushort value) { }

	[Address(RVA = "0x14CABB0", Offset = "0x14C9DB0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B0C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x140E7E0", Offset = "0x140D9E0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x6000B0D")]
	public override bool Equals(ushort obj) { }

	[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1A")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x14CAC10", Offset = "0x14C9E10", Length = "0x90")]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B14")]
	public static ushort Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x14CACB0", Offset = "0x14C9EB0", Length = "0xA2")]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "System.ComponentModel.UInt16Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B15")]
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x14CAD60", Offset = "0x14C9F60", Length = "0x123")]
	[CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B16")]
	private static ushort Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[Address(RVA = "0x14CAE90", Offset = "0x14CA090", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B1B")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x14CAEE0", Offset = "0x14CA0E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(byte))]
	[Token(Token = "0x6000B1E")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x14CAF30", Offset = "0x14CA130", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B1C")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x14CAF80", Offset = "0x14CA180", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B28")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x14CB010", Offset = "0x14CA210", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x6000B27")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x14CB080", Offset = "0x14CA280", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000B26")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x14CB0D0", Offset = "0x14CA2D0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(short))]
	[Token(Token = "0x6000B1F")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14CB120", Offset = "0x14CA320", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B21")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14CB170", Offset = "0x14CA370", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B23")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14CB1C0", Offset = "0x14CA3C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x6000B1D")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x14CB210", Offset = "0x14CA410", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000B25")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x14CB260", Offset = "0x14CA460", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000B29")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x7C8EA0", Offset = "0x7C80A0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B20")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14CB2F0", Offset = "0x14CA4F0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B22")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14CB340", Offset = "0x14CA540", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B24")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14CB4D0", Offset = "0x14CA6D0", Length = "0xC7")]
	[CalledBy(Type = "System.ComponentModel.UInt16Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B12")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x14CB410", Offset = "0x14CA610", Length = "0xBA")]
	[CalledBy(Type = "SimpleJSON.JSONNode", Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B11")]
	public string ToString(string format) { }

	[Address(RVA = "0x14CB5A0", Offset = "0x14CA7A0", Length = "0x8B")]
	[CalledBy(Type = "System.Uri", Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UriComponents", typeof(ushort), "System.UriFormat"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Uri", Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UriComponents", "System.UriFormat"}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B10")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x14CB390", Offset = "0x14CA590", Length = "0x7F")]
	[CalledBy(Type = "Mirror.NetworkManagerHUD", Member = "StartButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_15", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B0F")]
	public virtual string ToString() { }

	[Address(RVA = "0x14CB630", Offset = "0x14CA830", Length = "0xA1")]
	[CalledBy(Type = "System.IPv6AddressHelper", Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B13")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x14CB6E0", Offset = "0x14CA8E0", Length = "0xF8")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterUInt16Converters>b__22_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = "Mirror.NetworkManagerHUD", Member = "StartButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_14", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B17")]
	public static bool TryParse(string s, out ushort result) { }

	[Address(RVA = "0x14CB7E0", Offset = "0x14CA9E0", Length = "0xFE")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B18")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result) { }

	[Address(RVA = "0x14CB8E0", Offset = "0x14CAAE0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B19")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out ushort result) { }

}


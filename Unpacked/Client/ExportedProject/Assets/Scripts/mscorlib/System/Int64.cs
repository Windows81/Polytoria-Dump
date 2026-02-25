namespace System;

[IsReadOnly]
[Token(Token = "0x2000102")]
public struct long : IComparable, IConvertible, IFormattable, IComparable<Int64>, IEquatable<Int64>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000419")]
	private readonly long m_value; //Field offset: 0x0

	[Address(RVA = "0x14A0A10", Offset = "0x149FC10", Length = "0xB1")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_long", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60007EE")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x14A0AD0", Offset = "0x149FCD0", Length = "0x14")]
	[CalledBy(Type = "Unity.IntegerTime.DiscreteTime", Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.IntegerTime.DiscreteTime"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.NetworkRuntimeProfiler+Sorter", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkRuntimeProfiler+Stat", "Mirror.NetworkRuntimeProfiler+Stat"}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007EF")]
	public override int CompareTo(long value) { }

	[Address(RVA = "0x14A0B00", Offset = "0x149FD00", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x14A0AF0", Offset = "0x149FCF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60007F1")]
	public override bool Equals(long obj) { }

	[Address(RVA = "0x14A0B60", Offset = "0x149FD60", Length = "0xA")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007F2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14A0B70", Offset = "0x149FD70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FD")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x14A0C70", Offset = "0x149FE70", Length = "0xC9")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1RelativeOid", Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DerObjectIdentifier", Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Byte[]")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[Token(Token = "0x60007F8")]
	public static long Parse(string s) { }

	[Address(RVA = "0x14A0D40", Offset = "0x149FF40", Length = "0xD8")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[Token(Token = "0x60007F9")]
	public static long Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x14A0B80", Offset = "0x149FD80", Length = "0xEA")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.ComponentModel.Int64Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(long))]
	[Token(Token = "0x60007FA")]
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x14A0E20", Offset = "0x14A0020", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007FE")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x14A0E70", Offset = "0x14A0070", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(byte))]
	[Token(Token = "0x6000801")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x14A0EC0", Offset = "0x14A00C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(char))]
	[Token(Token = "0x60007FF")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x14A0F10", Offset = "0x14A0110", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600080B")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x14A0FA0", Offset = "0x14A01A0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x600080A")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x14A1010", Offset = "0x14A0210", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000809")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x14A1060", Offset = "0x14A0260", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(short))]
	[Token(Token = "0x6000802")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14A10B0", Offset = "0x14A02B0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000804")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000806")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14A1100", Offset = "0x14A0300", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x6000800")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x14A1150", Offset = "0x14A0350", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000808")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x14A11A0", Offset = "0x14A03A0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x600080C")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x14A1230", Offset = "0x14A0430", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000803")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14A1280", Offset = "0x14A0480", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000805")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14A12D0", Offset = "0x14A04D0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x6000807")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14A1430", Offset = "0x14A0630", Length = "0xC8")]
	[CalledBy(Type = typeof(IntPtr), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(IntPtr), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.Int64Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007F6")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x14A1500", Offset = "0x14A0700", Length = "0xBB")]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007F5")]
	public string ToString(string format) { }

	[Address(RVA = "0x14A1320", Offset = "0x14A0520", Length = "0x80")]
	[CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "CreateDefaultHandler", ReturnType = "System.Net.Http.IMonoHttpClientHandler")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.RangeItemHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007F3")]
	public virtual string ToString() { }

	[Address(RVA = "0x14A13A0", Offset = "0x14A05A0", Length = "0x8C")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequest"}, ReturnType = "PipelineEntry[]")]
	[CalledBy(Type = "System.Net.FileWebResponse", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.FileWebRequest", "System.Uri", typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.Headers.ContentRangeHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007F4")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x14A15C0", Offset = "0x14A07C0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007F7")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x14A17E0", Offset = "0x14A09E0", Length = "0xF1")]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+Long", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateContentLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Http.Headers.ContentRangeHeaderValue", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.ContentRangeHeaderValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetNumericValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Token", typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.RangeHeaderValue", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Net.Http.Headers.RangeHeaderValue&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "TryParseInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007FC")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	[Address(RVA = "0x14A1670", Offset = "0x14A0870", Length = "0x16A")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterInt64Converters>b__20_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField", Member = "CanTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlLongAttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlLongAttributeDescription", Member = "ConvertValueToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Net.HttpWebResponse", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Uri", typeof(string), "System.Net.WebResponseStream", "System.Net.CookieContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_10", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseInt64IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int64&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007FB")]
	public static bool TryParse(string s, out long result) { }

}


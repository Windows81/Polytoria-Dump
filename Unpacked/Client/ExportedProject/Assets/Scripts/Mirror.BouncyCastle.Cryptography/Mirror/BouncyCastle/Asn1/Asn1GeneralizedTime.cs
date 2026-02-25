namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x200019C")]
public class Asn1GeneralizedTime : Asn1Object
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000425")]
	private readonly string m_timeString; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000426")]
	private readonly bool m_timeStringCanonical; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000427")]
	private readonly DateTime m_dateTime; //Field offset: 0x20

	[Address(RVA = "0x10E4300", Offset = "0x10E3500", Length = "0x12B")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "CreatePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Asn1GeneralizedTime))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F2B")]
	public Asn1GeneralizedTime(string timeString) { }

	[Address(RVA = "0x10E42A0", Offset = "0x10E34A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000F2C")]
	internal Asn1GeneralizedTime(Byte[] contents) { }

	[Address(RVA = "0x10E3050", Offset = "0x10E2250", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000F32")]
	protected virtual bool Asn1Equals(Asn1Object asn1Object) { }

	[Address(RVA = "0x10E3120", Offset = "0x10E2320", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[Token(Token = "0x6000F33")]
	protected virtual int Asn1GetHashCode() { }

	[Address(RVA = "0x10E3180", Offset = "0x10E2380", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F34")]
	internal static Asn1GeneralizedTime CreatePrimitive(Byte[] contents) { }

	[Address(RVA = "0x10E3200", Offset = "0x10E2400", Length = "0x5E0")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Platform), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "ParseLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "ParseTimeZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(DateTime))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000F35")]
	private static DateTime FromString(string s) { }

	[Address(RVA = "0x10E3C40", Offset = "0x10E2E40", Length = "0x121")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "GetEncodingDer", ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "GetEncodingDerImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "Asn1Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "Asn1GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F2D")]
	internal Byte[] GetContents(int encoding) { }

	[Address(RVA = "0x10E3F10", Offset = "0x10E3110", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F2E")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x10E3E00", Offset = "0x10E3000", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F30")]
	internal virtual DerEncoding GetEncodingDer() { }

	[Address(RVA = "0x10E3D70", Offset = "0x10E2F70", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F31")]
	internal virtual DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo) { }

	[Address(RVA = "0x10E3E80", Offset = "0x10E3080", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1GeneralizedTime), Member = "GetContents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F2F")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x10E3F90", Offset = "0x10E3190", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Platform), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000F36")]
	private static int IndexOfSign(string s, int startIndex) { }

	[Address(RVA = "0x10E4020", Offset = "0x10E3220", Length = "0x9E")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000F37")]
	private static DateTime ParseLocal(string s, string format) { }

	[Address(RVA = "0x10E40C0", Offset = "0x10E32C0", Length = "0x9E")]
	[CalledBy(Type = typeof(Asn1GeneralizedTime), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000F38")]
	private static DateTime ParseTimeZone(string s, string format) { }

	[Address(RVA = "0x10E4160", Offset = "0x10E3360", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles)}, ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000F39")]
	private static DateTime ParseUtc(string s, string format) { }

	[Address(RVA = "0x10E4200", Offset = "0x10E3400", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000F3A")]
	private static string ToStringCanonical(DateTime dateTime) { }

}


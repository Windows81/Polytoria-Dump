namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001C4")]
public class DerBmpString : DerStringBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046B")]
	private readonly string m_str; //Field offset: 0x10

	[Address(RVA = "0x1104630", Offset = "0x1103830", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001060")]
	internal DerBmpString(Char[] str) { }

	[Address(RVA = "0x1104200", Offset = "0x1103400", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001062")]
	protected virtual bool Asn1Equals(Asn1Object asn1Object) { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001063")]
	protected virtual int Asn1GetHashCode() { }

	[Address(RVA = "0x1104290", Offset = "0x1103490", Length = "0xBA")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "CreateDerBmpString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DefiniteLengthInputStream)}, ReturnType = typeof(DerBmpString))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001069")]
	internal static DerBmpString CreatePrimitive(Char[] str) { }

	[Address(RVA = "0x1104350", Offset = "0x1103550", Length = "0xB6")]
	[CalledBy(Type = typeof(DerBmpString), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerBmpString), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerBmpString), Member = "GetEncodingDer", ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(DerBmpString), Member = "GetEncodingDerImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(DerEncoding))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001068")]
	private Byte[] GetContents() { }

	[Address(RVA = "0x11045B0", Offset = "0x11037B0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerBmpString), Member = "GetContents", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001064")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x11044A0", Offset = "0x11036A0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerBmpString), Member = "GetContents", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001066")]
	internal virtual DerEncoding GetEncodingDer() { }

	[Address(RVA = "0x1104410", Offset = "0x1103610", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerBmpString), Member = "GetContents", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001067")]
	internal virtual DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo) { }

	[Address(RVA = "0x1104520", Offset = "0x1103720", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerBmpString), Member = "GetContents", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001065")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001061")]
	public virtual string GetString() { }

}


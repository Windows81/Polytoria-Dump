namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001D6")]
public class DerPrintableString : DerStringBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048B")]
	private readonly Byte[] m_contents; //Field offset: 0x10

	[Address(RVA = "0x110AD90", Offset = "0x1109F90", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010F8")]
	internal DerPrintableString(Byte[] contents, bool clone) { }

	[Address(RVA = "0x110A990", Offset = "0x1109B90", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x60010FE")]
	protected virtual bool Asn1Equals(Asn1Object asn1Object) { }

	[Address(RVA = "0x110AA40", Offset = "0x1109C40", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[Token(Token = "0x60010FF")]
	protected virtual int Asn1GetHashCode() { }

	[Address(RVA = "0x110AA90", Offset = "0x1109C90", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001100")]
	internal static DerPrintableString CreatePrimitive(Byte[] contents) { }

	[Address(RVA = "0x110AD10", Offset = "0x1109F10", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FA")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x110AC00", Offset = "0x1109E00", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FC")]
	internal virtual DerEncoding GetEncodingDer() { }

	[Address(RVA = "0x110AB70", Offset = "0x1109D70", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FD")]
	internal virtual DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo) { }

	[Address(RVA = "0x110AC80", Offset = "0x1109E80", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FB")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x11068E0", Offset = "0x1105AE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Strings), Member = "FromAsciiByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F9")]
	public virtual string GetString() { }

}


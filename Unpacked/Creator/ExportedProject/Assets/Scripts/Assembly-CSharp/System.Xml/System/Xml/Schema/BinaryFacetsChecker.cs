namespace System.Xml.Schema;

[Token(Token = "0x2000132")]
internal class BinaryFacetsChecker : FacetsChecker
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A7F")]
	public BinaryFacetsChecker() { }

	[Address(RVA = "0x16BAAE0", Offset = "0x16B9CE0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A7B")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16BAB80", Offset = "0x16B9D80", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFacetsChecker), Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(ArrayList), typeof(XmlSchemaDatatype)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A7C")]
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16BAD60", Offset = "0x16B9F60", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A7D")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16BAEC0", Offset = "0x16BA0C0", Length = "0x108")]
	[CalledBy(Type = typeof(BinaryFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A7E")]
	private bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}


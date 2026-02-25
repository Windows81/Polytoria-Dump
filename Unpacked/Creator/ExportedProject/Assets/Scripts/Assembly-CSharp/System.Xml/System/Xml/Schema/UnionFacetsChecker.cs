namespace System.Xml.Schema;

[Token(Token = "0x2000134")]
internal class UnionFacetsChecker : FacetsChecker
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A85")]
	public UnionFacetsChecker() { }

	[Address(RVA = "0x16BD880", Offset = "0x16BCA80", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A83")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16BB260", Offset = "0x16BA460", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A84")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}


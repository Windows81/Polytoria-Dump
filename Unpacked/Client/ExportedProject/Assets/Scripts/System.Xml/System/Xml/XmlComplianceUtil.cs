namespace System.Xml;

[Token(Token = "0x200009D")]
internal static class XmlComplianceUtil
{

	[Address(RVA = "0x1691C20", Offset = "0x1690E20", Length = "0x1BB")]
	[CalledBy(Type = typeof(FacetsChecker), Member = "CheckLexicalFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(FacetsChecker), Member = "CheckWhitespaceFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000750")]
	public static string CDataNormalize(string value) { }

	[Address(RVA = "0x1691DE0", Offset = "0x1690FE0", Length = "0x2E1")]
	[CalledBy(Type = typeof(Datatype_anySimpleType), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(FacetsChecker), Member = "CheckLexicalFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(FacetsChecker), Member = "CheckWhitespaceFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(XmlSchemaDatatype)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlCharType), Member = "InitInstance", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600074F")]
	public static string NonCDataNormalize(string value) { }

}


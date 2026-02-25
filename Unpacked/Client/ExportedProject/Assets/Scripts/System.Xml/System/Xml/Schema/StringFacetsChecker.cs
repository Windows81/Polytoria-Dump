namespace System.Xml.Schema;

[Token(Token = "0x200012F")]
internal class StringFacetsChecker : FacetsChecker
{
	[Token(Token = "0x4000566")]
	private static Regex languagePattern; //Field offset: 0x0

	[Token(Token = "0x170002B2")]
	private static Regex LanguagePattern
	{
		[Address(RVA = "0x16B27D0", Offset = "0x16B19D0", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Token(Token = "0x6000A6D")]
		private get { } //Length: 169
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A74")]
	public StringFacetsChecker() { }

	[Address(RVA = "0x16B1E10", Offset = "0x16B1010", Length = "0x2BC")]
	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaDatatype), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "TryVerifyTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "TryVerifyNormalizedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlConvert), Member = "TryVerifyNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A73")]
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	[Address(RVA = "0x16B2120", Offset = "0x16B1320", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaDatatype), typeof(bool)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A6E")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16B2100", Offset = "0x16B1300", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaDatatype), typeof(bool)}, ReturnType = typeof(Exception))]
	[Token(Token = "0x6000A6F")]
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16B21B0", Offset = "0x16B13B0", Length = "0x24C")]
	[CalledBy(Type = typeof(Datatype_anyURI), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringFacetsChecker), Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringFacetsChecker), Member = "MatchEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ArrayList), typeof(XmlSchemaDatatype)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000A70")]
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	[Address(RVA = "0x16B27D0", Offset = "0x16B19D0", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Token(Token = "0x6000A6D")]
	private static Regex get_LanguagePattern() { }

	[Address(RVA = "0x16B25D0", Offset = "0x16B17D0", Length = "0x1FF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000A71")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16B2400", Offset = "0x16B1600", Length = "0x1CC")]
	[CalledBy(Type = typeof(StringFacetsChecker), Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaDatatype), typeof(bool)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000A72")]
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}


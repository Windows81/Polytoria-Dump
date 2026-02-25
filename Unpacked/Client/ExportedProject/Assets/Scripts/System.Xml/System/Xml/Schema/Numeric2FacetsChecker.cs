namespace System.Xml.Schema;

[Token(Token = "0x200012C")]
internal class Numeric2FacetsChecker : FacetsChecker
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A62")]
	public Numeric2FacetsChecker() { }

	[Address(RVA = "0x16AD6E0", Offset = "0x16AC8E0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000A5D")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AD390", Offset = "0x16AC590", Length = "0x32D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A5E")]
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AD6C0", Offset = "0x16AC8C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A5F")]
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AD830", Offset = "0x16ACA30", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A60")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x16AD770", Offset = "0x16AC970", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A61")]
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

}


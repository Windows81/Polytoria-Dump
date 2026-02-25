namespace System.Xml.Schema;

[Token(Token = "0x2000160")]
public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060E")]
	private XmlQualifiedName baseTypeName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400060F")]
	private XmlSchemaObjectCollection facets; //Field offset: 0x18

	[Token(Token = "0x17000332")]
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[Address(RVA = "0x16DA670", Offset = "0x16D9870", Length = "0xA0")]
		[CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B85")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x16DA5C0", Offset = "0x16D97C0", Length = "0xA9")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B86")]
	public XmlSchemaSimpleTypeRestriction() { }

	[Address(RVA = "0x16DA670", Offset = "0x16D9870", Length = "0xA0")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B85")]
	public void set_BaseTypeName(XmlQualifiedName value) { }

}


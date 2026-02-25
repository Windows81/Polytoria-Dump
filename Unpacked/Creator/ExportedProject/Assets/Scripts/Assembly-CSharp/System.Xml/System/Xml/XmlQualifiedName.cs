namespace System.Xml;

[Token(Token = "0x20000B8")]
public class XmlQualifiedName
{
	[Token(Token = "0x20000B9")]
	private sealed class HashCodeOfStringDelegate : MulticastDelegate
	{

		[Address(RVA = "0x162D1B0", Offset = "0x162C3B0", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000829")]
		public HashCodeOfStringDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600082A")]
		public override int Invoke(string s, int sLen, long additionalEntropy) { }

	}

	[Token(Token = "0x4000436")]
	private static HashCodeOfStringDelegate hashCodeDelegate; //Field offset: 0x0
	[Token(Token = "0x400043A")]
	public static readonly XmlQualifiedName Empty; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000437")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000438")]
	private string ns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000439")]
	private int hash; //Field offset: 0x20

	[Token(Token = "0x170001D4")]
	public bool IsEmpty
	{
		[Address(RVA = "0x16BA030", Offset = "0x16B9230", Length = "0x34")]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
		[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CalledBy(Type = typeof(SchemaEntity), Member = "System.Xml.IDtdEntityInfo.get_IsUnparsedEntity", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600081E")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170001D3")]
	public string Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D2")]
	public string Namespace
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600081B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x16B9D30", Offset = "0x16B8F30", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000828")]
	private static XmlQualifiedName() { }

	[Address(RVA = "0x16B9F00", Offset = "0x16B9100", Length = "0x84")]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(SchemaElementDecl), Member = "System.Xml.IDtdAttributeListInfo.LookupAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(IDtdAttributeInfo))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "System.Xml.IDtdInfo.LookupAttributeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(IDtdAttributeListInfo))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(XmlQualifiedName))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600081A")]
	public XmlQualifiedName(string name, string ns) { }

	[Address(RVA = "0x16B9F90", Offset = "0x16B9190", Length = "0x92")]
	[CalledBy(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000818")]
	public XmlQualifiedName() { }

	[Address(RVA = "0x16B9E60", Offset = "0x16B9060", Length = "0x92")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "System.Xml.IDtdInfo.LookupEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IDtdEntityInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000819")]
	public XmlQualifiedName(string name) { }

	[Address(RVA = "0x16B9670", Offset = "0x16B8870", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000820")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x16BA030", Offset = "0x16B9230", Length = "0x34")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CalledBy(Type = typeof(SchemaEntity), Member = "System.Xml.IDtdEntityInfo.get_IsUnparsedEntity", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600081E")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081C")]
	public string get_Name() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081B")]
	public string get_Namespace() { }

	[Address(RVA = "0x16B9980", Offset = "0x16B8B80", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlQualifiedName), Member = "GetHashCodeDelegate", ReturnType = typeof(HashCodeOfStringDelegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600081D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16B9790", Offset = "0x16B8990", Length = "0x1ED")]
	[CalledBy(Type = typeof(XmlQualifiedName), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000823")]
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	[Address(RVA = "0x1002460", Offset = "0x1001660", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000825")]
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	[Address(RVA = "0x16B9A80", Offset = "0x16B8C80", Length = "0x3F")]
	[CalledBy(Type = typeof(QueryOutputWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000826")]
	internal void Init(string name, string ns) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000824")]
	private static bool IsRandomizedHashingDisabled() { }

	[Address(RVA = "0x16BA070", Offset = "0x16B9270", Length = "0x67")]
	[CalledBy(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000821")]
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	[Address(RVA = "0x16BA0E0", Offset = "0x16B92E0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000822")]
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	[Address(RVA = "0x16B9AC0", Offset = "0x16B8CC0", Length = "0x209")]
	[CalledBy(Type = typeof(Datatype_QName), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_NOTATION), Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver), typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Datatype_QNameXdr), Member = "ParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNameTable), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValidateNames), Member = "ParseQNameThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000827")]
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	[Address(RVA = "0x16B9CD0", Offset = "0x16B8ED0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600081F")]
	public virtual string ToString() { }

}


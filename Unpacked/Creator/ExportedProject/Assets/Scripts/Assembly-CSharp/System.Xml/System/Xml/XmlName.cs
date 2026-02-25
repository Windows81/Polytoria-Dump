namespace System.Xml;

[Token(Token = "0x200007F")]
internal class XmlName : IXmlSchemaInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000339")]
	private string prefix; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033A")]
	private string localName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400033B")]
	private string ns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400033C")]
	private string name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400033D")]
	private int hashCode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400033E")]
	internal XmlDocument ownerDoc; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400033F")]
	internal XmlName next; //Field offset: 0x40

	[Token(Token = "0x17000165")]
	public int HashCode
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000601")]
		 get { } //Length: 174
	}

	[Token(Token = "0x17000169")]
	public override bool IsDefault
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000605")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700016A")]
	public override bool IsNil
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000606")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000162")]
	public string LocalName
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005FE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016B")]
	public override XmlSchemaSimpleType MemberType
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000607")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000167")]
	public string Name
	{
		[Address(RVA = "0x167CF60", Offset = "0x167C160", Length = "0x1AA")]
		[CalledBy(Type = typeof(XmlAttribute), Member = "get_Name", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlElement), Member = "get_Name", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000603")]
		 get { } //Length: 426
	}

	[Token(Token = "0x17000163")]
	public string NamespaceURI
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005FF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000166")]
	public XmlDocument OwnerDocument
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000602")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000164")]
	public string Prefix
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000600")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016E")]
	public override XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700016D")]
	public override XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000609")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700016C")]
	public override XmlSchemaType SchemaType
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000608")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000168")]
	public override XmlSchemaValidity Validity
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000604")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x167CEB0", Offset = "0x167C0B0", Length = "0xA9")]
	[CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlName), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlNameEx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005FD")]
	internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	[Address(RVA = "0x167CD30", Offset = "0x167BF30", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlNameEx), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName)}, ReturnType = typeof(void))]
	[Token(Token = "0x60005FC")]
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x153A6F0", Offset = "0x15398F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600060B")]
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000601")]
	public int get_HashCode() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000605")]
	public override bool get_IsDefault() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000606")]
	public override bool get_IsNil() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005FE")]
	public string get_LocalName() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000607")]
	public override XmlSchemaSimpleType get_MemberType() { }

	[Address(RVA = "0x167CF60", Offset = "0x167C160", Length = "0x1AA")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "get_Name", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlElement), Member = "get_Name", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000603")]
	public string get_Name() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005FF")]
	public string get_NamespaceURI() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000602")]
	public XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000600")]
	public string get_Prefix() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600060A")]
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000609")]
	public override XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000608")]
	public override XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000604")]
	public override XmlSchemaValidity get_Validity() { }

	[Address(RVA = "0x167CE40", Offset = "0x167C040", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Token(Token = "0x600060C")]
	public static int GetHashCode(string name) { }

}


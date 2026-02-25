namespace System.Xml;

[Token(Token = "0x2000076")]
public class XmlDocumentType : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031B")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031C")]
	private string publicId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031D")]
	private string systemId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400031E")]
	private string internalSubset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400031F")]
	private bool namespaces; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000320")]
	private XmlNamedNodeMap entities; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000321")]
	private XmlNamedNodeMap notations; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000322")]
	private SchemaInfo schemaInfo; //Field offset: 0x58

	[Token(Token = "0x1700013B")]
	internal SchemaInfo DtdSchemaInfo
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600058D")]
		internal get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600058E")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000135")]
	public XmlNamedNodeMap Entities
	{
		[Address(RVA = "0x16700B0", Offset = "0x166F2B0", Length = "0x79")]
		[CalledBy(Type = typeof(XmlDocument), Member = "GetEntityNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlEntity))]
		[CalledBy(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000585")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000139")]
	public string InternalSubset
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000589")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000134")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000584")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000132")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000581")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000131")]
	public virtual string Name
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000580")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000133")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000582")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000136")]
	public XmlNamedNodeMap Notations
	{
		[Address(RVA = "0x1670130", Offset = "0x166F330", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000586")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700013A")]
	internal bool ParseWithNamespaces
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600058A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000137")]
	public string PublicId
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000587")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000138")]
	public string SystemId
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000588")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x166FEE0", Offset = "0x166F0E0", Length = "0x1C7")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlDocumentType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057F")]
	protected private XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	[Address(RVA = "0x166FE30", Offset = "0x166F030", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000583")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600058D")]
	internal SchemaInfo get_DtdSchemaInfo() { }

	[Address(RVA = "0x16700B0", Offset = "0x166F2B0", Length = "0x79")]
	[CalledBy(Type = typeof(XmlDocument), Member = "GetEntityNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlEntity))]
	[CalledBy(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000585")]
	public XmlNamedNodeMap get_Entities() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000589")]
	public string get_InternalSubset() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000584")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000581")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000580")]
	public virtual string get_Name() { }

	[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000582")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1670130", Offset = "0x166F330", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000586")]
	public XmlNamedNodeMap get_Notations() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600058A")]
	internal bool get_ParseWithNamespaces() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000587")]
	public string get_PublicId() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000588")]
	public string get_SystemId() { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600058E")]
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600058C")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x166FE90", Offset = "0x166F090", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600058B")]
	public virtual void WriteTo(XmlWriter w) { }

}


namespace System.Xml;

[Token(Token = "0x2000079")]
public class XmlEntity : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000326")]
	private string publicId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000327")]
	private string systemId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000328")]
	private string notationName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000329")]
	private string name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400032A")]
	private string unparsedReplacementStr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400032B")]
	private string baseURI; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400032C")]
	private XmlLinkedNode lastChild; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400032D")]
	private bool childrenFoliating; //Field offset: 0x50

	[Token(Token = "0x17000155")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014F")]
	public virtual string InnerText
	{
		[Address(RVA = "0x1676290", Offset = "0x1675490", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BB")]
		 get { } //Length: 7
		[Address(RVA = "0x16772D0", Offset = "0x16764D0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005BC")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000154")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x1677330", Offset = "0x1676530", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60005C3")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000150")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BD")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700014C")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000151")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x16771D0", Offset = "0x16763D0", Length = "0xFB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005BE")]
		internal get { } //Length: 251
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700014E")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005BA")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700014D")]
	public virtual string Name
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005B9")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000152")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000153")]
	public string SystemId
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1677080", Offset = "0x1676280", Length = "0x149")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005B6")]
	internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	[Address(RVA = "0x1677000", Offset = "0x1676200", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005B7")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C6")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x1676290", Offset = "0x1675490", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BB")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BD")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B8")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x16771D0", Offset = "0x16763D0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005BE")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BA")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005B9")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2FE8E0", Offset = "0x2FDAE0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C1")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C2")]
	public string get_SystemId() { }

	[Address(RVA = "0x1677060", Offset = "0x1676260", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60005C0")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x16772D0", Offset = "0x16764D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005BC")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x1677330", Offset = "0x1676530", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005C3")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005BF")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C7")]
	internal void SetBaseURI(string inBaseURI) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C5")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C4")]
	public virtual void WriteTo(XmlWriter w) { }

}


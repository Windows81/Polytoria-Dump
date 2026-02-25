namespace System.Xml;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x200003E")]
public class XmlTextReader : XmlReader, IXmlNamespaceResolver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000101")]
	private XmlTextReaderImpl impl; //Field offset: 0x10

	[Token(Token = "0x17000075")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x1659E60", Offset = "0x1659060", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600024B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700007A")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000258")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700007F")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x1659E90", Offset = "0x1659090", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000260")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700007B")]
	public EntityHandling EntityHandling
	{
		[Address(RVA = "0x1659F50", Offset = "0x1659150", Length = "0x1E")]
		[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
		[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600025C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x1700007D")]
	internal XmlTextReaderImpl Impl
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600025E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000077")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x1393620", Offset = "0x1392820", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000076")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x1659EC0", Offset = "0x16590C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600024C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000071")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1393590", Offset = "0x1392790", Length = "0x2A")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000247")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000070")]
	public virtual string Name
	{
		[Address(RVA = "0x1659EF0", Offset = "0x16590F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000246")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000072")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x1393680", Offset = "0x1392880", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000248")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000079")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000256")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700006F")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x1659F20", Offset = "0x1659120", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000245")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000073")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1393650", Offset = "0x1392850", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000249")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000078")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x143D0D0", Offset = "0x143C2D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000255")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000074")]
	public virtual string Value
	{
		[Address(RVA = "0x15925E0", Offset = "0x15917E0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600024A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700007C")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x1659F70", Offset = "0x1659170", Length = "0x1E")]
		[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
		[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600025D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x1700007E")]
	internal bool XmlValidatingReaderCompatibilityMode
	{
		[Address(RVA = "0x1659F90", Offset = "0x1659190", Length = "0x1E")]
		[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
		[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600025F")]
		internal set { } //Length: 30
	}

	[Address(RVA = "0x1659D90", Offset = "0x1658F90", Length = "0xCC")]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000244")]
	public XmlTextReader(TextReader input, XmlNameTable nt) { }

	[Address(RVA = "0x143D0A0", Offset = "0x143C2A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000254")]
	public virtual void Close() { }

	[Address(RVA = "0x1659E60", Offset = "0x1659060", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024B")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000258")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0x1659E90", Offset = "0x1659090", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000260")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600025E")]
	internal XmlTextReaderImpl get_Impl() { }

	[Address(RVA = "0x1393620", Offset = "0x1392820", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024D")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x1659EC0", Offset = "0x16590C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024C")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x1393590", Offset = "0x1392790", Length = "0x2A")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000247")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x1659EF0", Offset = "0x16590F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000246")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1393680", Offset = "0x1392880", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000248")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000256")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x1659F20", Offset = "0x1659120", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000245")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1393650", Offset = "0x1392850", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000249")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x143D0D0", Offset = "0x143C2D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000255")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x15925E0", Offset = "0x15917E0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024A")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1659C10", Offset = "0x1658E10", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000257")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x1659C50", Offset = "0x1658E50", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600024E")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x1659C80", Offset = "0x1658E80", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000251")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x1659CB0", Offset = "0x1658EB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600024F")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x144FC40", Offset = "0x144EE40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000250")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000253")]
	public virtual bool Read() { }

	[Address(RVA = "0x1659CE0", Offset = "0x1658EE0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000252")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x1659D10", Offset = "0x1658F10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000259")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x1659F50", Offset = "0x1659150", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025C")]
	public void set_EntityHandling(EntityHandling value) { }

	[Address(RVA = "0x1659F70", Offset = "0x1659170", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025D")]
	public void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x1659F90", Offset = "0x1659190", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTextReader)}, ReturnType = typeof(XmlTextReader))]
	[CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025F")]
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	[Address(RVA = "0x1659D40", Offset = "0x1658F40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600025A")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x1659D70", Offset = "0x1658F70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600025B")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}


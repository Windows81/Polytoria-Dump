namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
[Token(Token = "0x2000084")]
public abstract class XmlNode : ICloneable, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000349")]
	internal XmlNode parentNode; //Field offset: 0x10

	[Token(Token = "0x17000181")]
	public override XmlAttributeCollection Attributes
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000639")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700018E")]
	public override string BaseURI
	{
		[Address(RVA = "0x1680350", Offset = "0x167F550", Length = "0x101")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000659")]
		 get { } //Length: 257
	}

	[Token(Token = "0x1700017E")]
	public override XmlNodeList ChildNodes
	{
		[Address(RVA = "0x1680460", Offset = "0x167F660", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000636")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000183")]
	public override XmlNode FirstChild
	{
		[Address(RVA = "0x16804C0", Offset = "0x167F6C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600063B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000187")]
	public override bool HasChildNodes
	{
		[Address(RVA = "0x16804F0", Offset = "0x167F6F0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600064A")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700018C")]
	public override string InnerText
	{
		[Address(RVA = "0x1680520", Offset = "0x167F720", Length = "0x11C")]
		[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlElement), Member = "get_InnerText", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlEntity), Member = "get_InnerText", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x6000656")]
		 get { } //Length: 284
		[Address(RVA = "0x16808E0", Offset = "0x167FAE0", Length = "0x109")]
		[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x6000657")]
		 set { } //Length: 265
	}

	[Token(Token = "0x1700018D")]
	public override string InnerXml
	{
		[Address(RVA = "0x16809F0", Offset = "0x167FBF0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000658")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000185")]
	internal override bool IsContainer
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063D")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700018B")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x1680640", Offset = "0x167F840", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000650")]
		 get { } //Length: 219
	}

	[Token(Token = "0x1700018F")]
	internal override bool IsText
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000664")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000184")]
	public override XmlNode LastChild
	{
		[Address(RVA = "0xCF4F90", Offset = "0xCF4190", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063C")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000186")]
	internal override XmlLinkedNode LastNode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063E")]
		internal get { } //Length: 3
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600063F")]
		internal set { } //Length: 3
	}

	[Token(Token = "0x1700018A")]
	public abstract string LocalName
	{
		[Token(Token = "0x600064F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700017A")]
	public abstract string Name
	{
		[Token(Token = "0x6000631")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000188")]
	public override string NamespaceURI
	{
		[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064D")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000180")]
	public override XmlNode NextSibling
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000638")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700017C")]
	public abstract XmlNodeType NodeType
	{
		[Token(Token = "0x6000634")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000182")]
	public override XmlDocument OwnerDocument
	{
		[Address(RVA = "0x1680720", Offset = "0x167F920", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600063A")]
		 get { } //Length: 190
	}

	[Token(Token = "0x1700017D")]
	public override XmlNode ParentNode
	{
		[Address(RVA = "0x16807E0", Offset = "0x167F9E0", Length = "0xF8")]
		[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000635")]
		 get { } //Length: 248
	}

	[Token(Token = "0x17000189")]
	public override string Prefix
	{
		[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600064E")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700017F")]
	public override XmlNode PreviousSibling
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000637")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700017B")]
	public override string Value
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000632")]
		 get { } //Length: 3
		[Address(RVA = "0x1680A50", Offset = "0x167FC50", Length = "0xD4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000633")]
		 set { } //Length: 212
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600062F")]
	internal XmlNode() { }

	[Address(RVA = "0x16802C0", Offset = "0x167F4C0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000630")]
	internal XmlNode(XmlDocument doc) { }

	[Address(RVA = "0x167DCA0", Offset = "0x167CEA0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000663")]
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x167DCF0", Offset = "0x167CEF0", Length = "0x72")]
	[CalledBy(Type = typeof(XmlNode), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000640")]
	internal bool AncestorNode(XmlNode node) { }

	[Address(RVA = "0x167E0A0", Offset = "0x167D2A0", Length = "0x655")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 27)]
	[Token(Token = "0x6000645")]
	public override XmlNode AppendChild(XmlNode newChild) { }

	[Address(RVA = "0x167DD70", Offset = "0x167CF70", Length = "0x1F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000646")]
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x167DF70", Offset = "0x167D170", Length = "0x122")]
	[CalledBy(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000655")]
	private void AppendChildText(StringBuilder builder) { }

	[Address(RVA = "0x167E700", Offset = "0x167D900", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000662")]
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000649")]
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000648")]
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Token(Token = "0x600064B")]
	public abstract XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x167E750", Offset = "0x167D950", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600064C")]
	internal override void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	[Address(RVA = "0x167E810", Offset = "0x167DA10", Length = "0x83")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000660")]
	internal override XmlNode FindChild(XmlNodeType type) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000639")]
	public override XmlAttributeCollection get_Attributes() { }

	[Address(RVA = "0x1680350", Offset = "0x167F550", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000659")]
	public override string get_BaseURI() { }

	[Address(RVA = "0x1680460", Offset = "0x167F660", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000636")]
	public override XmlNodeList get_ChildNodes() { }

	[Address(RVA = "0x16804C0", Offset = "0x167F6C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600063B")]
	public override XmlNode get_FirstChild() { }

	[Address(RVA = "0x16804F0", Offset = "0x167F6F0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600064A")]
	public override bool get_HasChildNodes() { }

	[Address(RVA = "0x1680520", Offset = "0x167F720", Length = "0x11C")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "get_InnerText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlEntity), Member = "get_InnerText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNode), Member = "AppendChildText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000656")]
	public override string get_InnerText() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063D")]
	internal override bool get_IsContainer() { }

	[Address(RVA = "0x1680640", Offset = "0x167F840", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000650")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000664")]
	internal override bool get_IsText() { }

	[Address(RVA = "0xCF4F90", Offset = "0xCF4190", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063C")]
	public override XmlNode get_LastChild() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063E")]
	internal override XmlLinkedNode get_LastNode() { }

	[Token(Token = "0x600064F")]
	public abstract string get_LocalName() { }

	[Token(Token = "0x6000631")]
	public abstract string get_Name() { }

	[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064D")]
	public override string get_NamespaceURI() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000638")]
	public override XmlNode get_NextSibling() { }

	[Token(Token = "0x6000634")]
	public abstract XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1680720", Offset = "0x167F920", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600063A")]
	public override XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x16807E0", Offset = "0x167F9E0", Length = "0xF8")]
	[CalledBy(Type = typeof(XmlSignificantWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlWhitespace), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000635")]
	public override XmlNode get_ParentNode() { }

	[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600064E")]
	public override string get_Prefix() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000637")]
	public override XmlNode get_PreviousSibling() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000632")]
	public override string get_Value() { }

	[Address(RVA = "0x167E8A0", Offset = "0x167DAA0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000654")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x167E940", Offset = "0x167DB40", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000661")]
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[Address(RVA = "0x167EA80", Offset = "0x167DC80", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000651")]
	internal static bool HasReadOnlyParent(XmlNode n) { }

	[Address(RVA = "0x167EB50", Offset = "0x167DD50", Length = "0x7B1")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 33)]
	[Token(Token = "0x6000642")]
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x167F310", Offset = "0x167E510", Length = "0x7D7")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNode), Member = "AncestorNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 33)]
	[Token(Token = "0x6000641")]
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000647")]
	internal override bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x167FAF0", Offset = "0x167ECF0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000665")]
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	[Address(RVA = "0x167FB20", Offset = "0x167ED20", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000644")]
	public override XmlNode PrependChild(XmlNode newChild) { }

	[Address(RVA = "0x167FB70", Offset = "0x167ED70", Length = "0x7C")]
	[CalledBy(Type = typeof(XmlElement), Member = "CloneNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "RemoveAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_InnerXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600065C")]
	public override void RemoveAll() { }

	[Address(RVA = "0x167FBF0", Offset = "0x167EDF0", Length = "0x4A7")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	[Token(Token = "0x6000643")]
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	[Address(RVA = "0x16808E0", Offset = "0x167FAE0", Length = "0x109")]
	[CalledBy(Type = typeof(XmlAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUnspecifiedAttribute), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000657")]
	public override void set_InnerText(string value) { }

	[Address(RVA = "0x16809F0", Offset = "0x167FBF0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000658")]
	public override void set_InnerXml(string value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600063F")]
	internal override void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x1680A50", Offset = "0x167FC50", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000633")]
	public override void set_Value(string value) { }

	[Address(RVA = "0x16800A0", Offset = "0x167F2A0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600065D")]
	internal override void SetParent(XmlNode node) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600065E")]
	internal override void SetParentForLoad(XmlNode node) { }

	[Address(RVA = "0x16800E0", Offset = "0x167F2E0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600065F")]
	internal static void SplitName(string name, out string prefix, out string localName) { }

	[Address(RVA = "0x16801B0", Offset = "0x167F3B0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000653")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1680250", Offset = "0x167F450", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000652")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x1680270", Offset = "0x167F470", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000666")]
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	[Token(Token = "0x600065B")]
	public abstract void WriteContentTo(XmlWriter w) { }

	[Token(Token = "0x600065A")]
	public abstract void WriteTo(XmlWriter w) { }

}


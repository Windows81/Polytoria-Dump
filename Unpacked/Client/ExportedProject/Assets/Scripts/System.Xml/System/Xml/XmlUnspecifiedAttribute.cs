namespace System.Xml;

[Token(Token = "0x200008C")]
internal class XmlUnspecifiedAttribute : XmlAttribute
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000355")]
	private bool fSpecified; //Field offset: 0x28

	[Token(Token = "0x170001AA")]
	public virtual string InnerText
	{
		[Address(RVA = "0x1681950", Offset = "0x1680B50", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x600069F")]
		 set { } //Length: 119
	}

	[Token(Token = "0x170001A9")]
	public virtual bool Specified
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600069D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x166DF10", Offset = "0x166D110", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600069C")]
	protected private XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[Address(RVA = "0x16814E0", Offset = "0x16806E0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A3")]
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	[Address(RVA = "0x1681570", Offset = "0x1680770", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600069E")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069D")]
	public virtual bool get_Specified() { }

	[Address(RVA = "0x16816C0", Offset = "0x16808C0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "InsertAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A1")]
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x1681750", Offset = "0x1680950", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "InsertBefore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A0")]
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x16817E0", Offset = "0x16809E0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A2")]
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	[Address(RVA = "0x1681950", Offset = "0x1680B50", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlAttribute), Member = "PrepareOwnerElementInElementIdAttrMap", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlAttribute), Member = "ResetOwnerElementInElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600069F")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A5")]
	internal void SetSpecified(bool f) { }

	[Address(RVA = "0x1681870", Offset = "0x1680A70", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60006A4")]
	public virtual void WriteTo(XmlWriter w) { }

}


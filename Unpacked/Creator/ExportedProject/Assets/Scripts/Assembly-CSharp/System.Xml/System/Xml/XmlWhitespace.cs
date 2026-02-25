namespace System.Xml;

[Token(Token = "0x200008D")]
public class XmlWhitespace : XmlCharacterData
{

	[Token(Token = "0x170001B0")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B0")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001AC")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1681BD0", Offset = "0x1680DD0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A8")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001AB")]
	public virtual string Name
	{
		[Address(RVA = "0x1681BD0", Offset = "0x1680DD0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A7")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001AD")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x14BF860", Offset = "0x14BEA60", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A9")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001AE")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x16811B0", Offset = "0x16803B0", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006AA")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170001AF")]
	public virtual string Value
	{
		[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006AB")]
		 get { } //Length: 20
		[Address(RVA = "0x1681C00", Offset = "0x1680E00", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006AC")]
		 set { } //Length: 169
	}

	[Address(RVA = "0x1681A90", Offset = "0x1680C90", Length = "0x13F")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlWhitespace))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60006A6")]
	protected private XmlWhitespace(string strData, XmlDocument doc) { }

	[Address(RVA = "0x16819D0", Offset = "0x1680BD0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60006AD")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B0")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x1681BD0", Offset = "0x1680DD0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A8")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x1681BD0", Offset = "0x1680DD0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A7")]
	public virtual string get_Name() { }

	[Address(RVA = "0x14BF860", Offset = "0x14BEA60", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A9")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x16811B0", Offset = "0x16803B0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AA")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AB")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1681C00", Offset = "0x1680E00", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006AC")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AF")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x1681A40", Offset = "0x1680C40", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006AE")]
	public virtual void WriteTo(XmlWriter w) { }

}


namespace System.Xml;

[Token(Token = "0x200008A")]
public class XmlSignificantWhitespace : XmlCharacterData
{

	[Token(Token = "0x170001A2")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600068F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700019E")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1681180", Offset = "0x1680380", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000687")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700019D")]
	public virtual string Name
	{
		[Address(RVA = "0x1681180", Offset = "0x1680380", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000686")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700019F")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x1498F70", Offset = "0x1498170", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000688")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A0")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x16811B0", Offset = "0x16803B0", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000689")]
		 get { } //Length: 163
	}

	[Token(Token = "0x170001A1")]
	public virtual string Value
	{
		[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600068B")]
		 get { } //Length: 20
		[Address(RVA = "0x1681260", Offset = "0x1680460", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600068C")]
		 set { } //Length: 169
	}

	[Address(RVA = "0x1681040", Offset = "0x1680240", Length = "0x13F")]
	[CalledBy(Type = typeof(XmlDocument), Member = "CreateSignificantWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSignificantWhitespace))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000685")]
	protected private XmlSignificantWhitespace(string strData, XmlDocument doc) { }

	[Address(RVA = "0x1680F80", Offset = "0x1680180", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600068A")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600068F")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x1681180", Offset = "0x1680380", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000687")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x1681180", Offset = "0x1680380", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000686")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1498F70", Offset = "0x1498170", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000688")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x16811B0", Offset = "0x16803B0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNode), Member = "get_ParentNode", ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000689")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600068B")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1681260", Offset = "0x1680460", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600068C")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600068E")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x1680FF0", Offset = "0x16801F0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600068D")]
	public virtual void WriteTo(XmlWriter w) { }

}


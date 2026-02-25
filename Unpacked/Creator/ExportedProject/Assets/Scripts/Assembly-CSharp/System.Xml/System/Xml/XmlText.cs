namespace System.Xml;

[Token(Token = "0x200008B")]
public class XmlText : XmlCharacterData
{

	[Token(Token = "0x170001A8")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600069B")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001A4")]
	public virtual string LocalName
	{
		[Address(RVA = "0x16813F0", Offset = "0x16805F0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000693")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001A3")]
	public virtual string Name
	{
		[Address(RVA = "0x16813F0", Offset = "0x16805F0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000692")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001A5")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000694")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A6")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x166E550", Offset = "0x166D750", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000695")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170001A7")]
	public virtual string Value
	{
		[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000697")]
		 get { } //Length: 20
		[Address(RVA = "0x1681420", Offset = "0x1680620", Length = "0xBA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000698")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x1681380", Offset = "0x1680580", Length = "0x66")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000690")]
	internal XmlText(string strData) { }

	[Address(RVA = "0x166E460", Offset = "0x166D660", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000691")]
	protected private XmlText(string strData, XmlDocument doc) { }

	[Address(RVA = "0x1681310", Offset = "0x1680510", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000696")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069B")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x16813F0", Offset = "0x16805F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000693")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x16813F0", Offset = "0x16805F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000692")]
	public virtual string get_Name() { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000694")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x166E550", Offset = "0x166D750", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000695")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000697")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1681420", Offset = "0x1680620", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000698")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069A")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x1680FF0", Offset = "0x16801F0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000699")]
	public virtual void WriteTo(XmlWriter w) { }

}


namespace System.Xml;

[Token(Token = "0x200006F")]
public abstract class XmlCharacterData : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E6")]
	private string data; //Field offset: 0x20

	[Token(Token = "0x17000102")]
	public override string Data
	{
		[Address(RVA = "0x166E620", Offset = "0x166D820", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F6")]
		 get { } //Length: 30
		[Address(RVA = "0x166E660", Offset = "0x166D860", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60004F7")]
		 set { } //Length: 218
	}

	[Token(Token = "0x17000101")]
	public virtual string InnerText
	{
		[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
		[CallerCount(Count = 25)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F4")]
		 get { } //Length: 20
		[Address(RVA = "0x166E740", Offset = "0x166D940", Length = "0x14")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F5")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000100")]
	public virtual string Value
	{
		[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F2")]
		 get { } //Length: 20
		[Address(RVA = "0x166E760", Offset = "0x166D960", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004F3")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x166E460", Offset = "0x166D660", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F1")]
	protected private XmlCharacterData(string data, XmlDocument doc) { }

	[Address(RVA = "0x166E5F0", Offset = "0x166D7F0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60004F8")]
	internal bool CheckOnData(string data) { }

	[Address(RVA = "0x166E620", Offset = "0x166D820", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F6")]
	public override string get_Data() { }

	[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F4")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x166E640", Offset = "0x166D840", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F2")]
	public virtual string get_Value() { }

	[Address(RVA = "0x166E660", Offset = "0x166D860", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60004F7")]
	public override void set_Data(string value) { }

	[Address(RVA = "0x166E740", Offset = "0x166D940", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F5")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x166E760", Offset = "0x166D960", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F3")]
	public virtual void set_Value(string value) { }

}


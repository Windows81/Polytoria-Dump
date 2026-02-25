namespace System.Xml;

[Token(Token = "0x2000089")]
public class XmlProcessingInstruction : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000353")]
	private string target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000354")]
	private string data; //Field offset: 0x28

	[Token(Token = "0x1700019A")]
	public string Data
	{
		[Address(RVA = "0x1680E90", Offset = "0x1680090", Length = "0xDA")]
		[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600067E")]
		 set { } //Length: 218
	}

	[Token(Token = "0x1700019B")]
	public virtual string InnerText
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067F")]
		 get { } //Length: 5
		[Address(RVA = "0x1680F70", Offset = "0x1680170", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000680")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000198")]
	public virtual string LocalName
	{
		[Address(RVA = "0x166F2B0", Offset = "0x166E4B0", Length = "0x14")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067B")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000197")]
	public virtual string Name
	{
		[Address(RVA = "0x166E620", Offset = "0x166D820", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067A")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700019C")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000681")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000199")]
	public virtual string Value
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600067C")]
		 get { } //Length: 5
		[Address(RVA = "0x1680F70", Offset = "0x1680170", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600067D")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1680DB0", Offset = "0x167FFB0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000679")]
	protected private XmlProcessingInstruction(string target, string data, XmlDocument doc) { }

	[Address(RVA = "0x1680D20", Offset = "0x167FF20", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000682")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067F")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x166F2B0", Offset = "0x166E4B0", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067B")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x166E620", Offset = "0x166D820", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067A")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2FF230", Offset = "0x2FE430", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000681")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600067C")]
	public virtual string get_Value() { }

	[Address(RVA = "0x1680E90", Offset = "0x1680090", Length = "0xDA")]
	[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlProcessingInstruction), Member = "set_InnerText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600067E")]
	public void set_Data(string value) { }

	[Address(RVA = "0x1680F70", Offset = "0x1680170", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000680")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x1680F70", Offset = "0x1680170", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600067D")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000684")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x1680D70", Offset = "0x167FF70", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000683")]
	public virtual void WriteTo(XmlWriter w) { }

}


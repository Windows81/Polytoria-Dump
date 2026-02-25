namespace System.Xml;

[Token(Token = "0x200007D")]
public abstract class XmlLinkedNode : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000335")]
	internal XmlLinkedNode next; //Field offset: 0x18

	[Token(Token = "0x17000161")]
	public virtual XmlNode NextSibling
	{
		[Address(RVA = "0x1677500", Offset = "0x1676700", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60005E1")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000160")]
	public virtual XmlNode PreviousSibling
	{
		[Address(RVA = "0x1677560", Offset = "0x1676760", Length = "0x82")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60005E0")]
		 get { } //Length: 130
	}

	[Address(RVA = "0x1677460", Offset = "0x1676660", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005DF")]
	internal XmlLinkedNode(XmlDocument doc) { }

	[Address(RVA = "0x1677500", Offset = "0x1676700", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60005E1")]
	public virtual XmlNode get_NextSibling() { }

	[Address(RVA = "0x1677560", Offset = "0x1676760", Length = "0x82")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60005E0")]
	public virtual XmlNode get_PreviousSibling() { }

}


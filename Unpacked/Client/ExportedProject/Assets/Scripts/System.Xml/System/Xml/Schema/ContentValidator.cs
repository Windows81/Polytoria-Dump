namespace System.Xml.Schema;

[Token(Token = "0x20000DE")]
internal class ContentValidator
{
	[Token(Token = "0x4000488")]
	public static readonly ContentValidator Empty; //Field offset: 0x0
	[Token(Token = "0x4000489")]
	public static readonly ContentValidator TextOnly; //Field offset: 0x8
	[Token(Token = "0x400048A")]
	public static readonly ContentValidator Mixed; //Field offset: 0x10
	[Token(Token = "0x400048B")]
	public static readonly ContentValidator Any; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000485")]
	private XmlSchemaContentType contentType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000486")]
	private bool isOpen; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x4000487")]
	private bool isEmptiable; //Field offset: 0x15

	[Token(Token = "0x1700020A")]
	public XmlSchemaContentType ContentType
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008C7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700020B")]
	public bool IsOpen
	{
		[Address(RVA = "0x1698F10", Offset = "0x1698110", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60008C8")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x1698D20", Offset = "0x1697F20", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60008C9")]
	private static ContentValidator() { }

	[Address(RVA = "0x1698E90", Offset = "0x1698090", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C5")]
	public ContentValidator(XmlSchemaContentType contentType) { }

	[Address(RVA = "0x1698EC0", Offset = "0x16980C0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C6")]
	protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C7")]
	public XmlSchemaContentType get_ContentType() { }

	[Address(RVA = "0x1698F10", Offset = "0x1698110", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60008C8")]
	public bool get_IsOpen() { }

}


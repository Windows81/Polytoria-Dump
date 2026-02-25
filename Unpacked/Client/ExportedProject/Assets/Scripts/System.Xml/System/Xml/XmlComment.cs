namespace System.Xml;

[Token(Token = "0x2000072")]
public class XmlComment : XmlCharacterData
{

	[Token(Token = "0x17000107")]
	public virtual string LocalName
	{
		[Address(RVA = "0x166EB80", Offset = "0x166DD80", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000504")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000106")]
	public virtual string Name
	{
		[Address(RVA = "0x166EB80", Offset = "0x166DD80", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000503")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000108")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000505")]
		 get { } //Length: 6
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
	[Token(Token = "0x6000502")]
	protected private XmlComment(string comment, XmlDocument doc) { }

	[Address(RVA = "0x166EAC0", Offset = "0x166DCC0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000506")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x166EB80", Offset = "0x166DD80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000504")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x166EB80", Offset = "0x166DD80", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000503")]
	public virtual string get_Name() { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000505")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000508")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x166EB30", Offset = "0x166DD30", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000507")]
	public virtual void WriteTo(XmlWriter w) { }

}


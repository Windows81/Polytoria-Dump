namespace System.Xml;

[Token(Token = "0x200006E")]
public class XmlCDataSection : XmlCharacterData
{

	[Token(Token = "0x170000FF")]
	internal virtual bool IsText
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F0")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170000FC")]
	public virtual string LocalName
	{
		[Address(RVA = "0x166E520", Offset = "0x166D720", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EA")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000FB")]
	public virtual string Name
	{
		[Address(RVA = "0x166E520", Offset = "0x166D720", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E9")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000FD")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000FE")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x166E550", Offset = "0x166D750", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EC")]
		 get { } //Length: 147
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
	[Token(Token = "0x60004E8")]
	protected private XmlCDataSection(string data, XmlDocument doc) { }

	[Address(RVA = "0x166E3A0", Offset = "0x166D5A0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004ED")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F0")]
	internal virtual bool get_IsText() { }

	[Address(RVA = "0x166E520", Offset = "0x166D720", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EA")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x166E520", Offset = "0x166D720", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E9")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2FFDE0", Offset = "0x2FEFE0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EB")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x166E550", Offset = "0x166D750", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EC")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EF")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x166E410", Offset = "0x166D610", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004EE")]
	public virtual void WriteTo(XmlWriter w) { }

}


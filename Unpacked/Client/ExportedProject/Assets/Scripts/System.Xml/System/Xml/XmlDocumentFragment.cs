namespace System.Xml;

[Token(Token = "0x2000075")]
public class XmlDocumentFragment : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400031A")]
	private XmlLinkedNode lastChild; //Field offset: 0x18

	[Token(Token = "0x1700012E")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x166FD90", Offset = "0x166EF90", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000575")]
		 set { } //Length: 151
	}

	[Token(Token = "0x1700012F")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000577")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000130")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000578")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000579")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700012A")]
	public virtual string LocalName
	{
		[Address(RVA = "0x166FCF0", Offset = "0x166EEF0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000571")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000129")]
	public virtual string Name
	{
		[Address(RVA = "0x166FCF0", Offset = "0x166EEF0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000570")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700012B")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x14A0B70", Offset = "0x149FD70", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000572")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700012D")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x166FD20", Offset = "0x166EF20", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000574")]
		 get { } //Length: 107
	}

	[Token(Token = "0x1700012C")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000573")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x166FC60", Offset = "0x166EE60", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600056F")]
	protected private XmlDocumentFragment(XmlDocument ownerDocument) { }

	[Address(RVA = "0x166F760", Offset = "0x166E960", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057B")]
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x166F7E0", Offset = "0x166E9E0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057C")]
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x166F860", Offset = "0x166EA60", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000576")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000577")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000578")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x166FCF0", Offset = "0x166EEF0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000571")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x166FCF0", Offset = "0x166EEF0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000570")]
	public virtual string get_Name() { }

	[Address(RVA = "0x14A0B70", Offset = "0x149FD70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000572")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x166FD20", Offset = "0x166EF20", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000574")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000573")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x166F900", Offset = "0x166EB00", Length = "0x70")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600057A")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x166FD90", Offset = "0x166EF90", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlLoader), Member = "ParsePartialContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(string), typeof(XmlNodeType)}, ReturnType = typeof(XmlNamespaceManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000575")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000579")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x166F9C0", Offset = "0x166EBC0", Length = "0x270")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600057E")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x166FC40", Offset = "0x166EE40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600057D")]
	public virtual void WriteTo(XmlWriter w) { }

}


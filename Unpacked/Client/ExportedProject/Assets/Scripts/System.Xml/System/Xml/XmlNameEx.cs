namespace System.Xml;

[Token(Token = "0x2000080")]
internal sealed class XmlNameEx : XmlName
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000340")]
	private byte flags; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000341")]
	private XmlSchemaSimpleType memberType; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000342")]
	private XmlSchemaType schemaType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000343")]
	private object decl; //Field offset: 0x60

	[Token(Token = "0x17000170")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x167CBE0", Offset = "0x167BDE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600060F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000171")]
	public virtual bool IsNil
	{
		[Address(RVA = "0x167CBF0", Offset = "0x167BDF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000610")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000172")]
	public virtual XmlSchemaSimpleType MemberType
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000611")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000175")]
	public virtual XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x167CC00", Offset = "0x167BE00", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000614")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000174")]
	public virtual XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x167CC80", Offset = "0x167BE80", Length = "0x72")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000613")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000173")]
	public virtual XmlSchemaType SchemaType
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000612")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016F")]
	public virtual XmlSchemaValidity Validity
	{
		[Address(RVA = "0x167CD00", Offset = "0x167BF00", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600060E")]
		 get { } //Length: 43
	}

	[Address(RVA = "0x167CA30", Offset = "0x167BC30", Length = "0x1AB")]
	[CalledBy(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CalledBy(Type = typeof(XmlName), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName), typeof(IXmlSchemaInfo)}, ReturnType = typeof(XmlName))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(XmlDocument), typeof(XmlName)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600060D")]
	internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x167C7E0", Offset = "0x167B9E0", Length = "0x1DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000618")]
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x167CBE0", Offset = "0x167BDE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600060F")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x167CBF0", Offset = "0x167BDF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000610")]
	public virtual bool get_IsNil() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000611")]
	public virtual XmlSchemaSimpleType get_MemberType() { }

	[Address(RVA = "0x167CC00", Offset = "0x167BE00", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000614")]
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x167CC80", Offset = "0x167BE80", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000613")]
	public virtual XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000612")]
	public virtual XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x167CD00", Offset = "0x167BF00", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600060E")]
	public virtual XmlSchemaValidity get_Validity() { }

	[Address(RVA = "0x167C9C0", Offset = "0x167BBC0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000616")]
	public void SetIsDefault(bool value) { }

	[Address(RVA = "0x167C9F0", Offset = "0x167BBF0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000617")]
	public void SetIsNil(bool value) { }

	[Address(RVA = "0x167CA20", Offset = "0x167BC20", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000615")]
	public void SetValidity(XmlSchemaValidity value) { }

}


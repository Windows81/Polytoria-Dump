namespace System.Xml.Schema;

[Token(Token = "0x200014C")]
public class XmlSchemaComplexType : XmlSchemaType
{
	[Token(Token = "0x40005CF")]
	private static XmlSchemaComplexType anyTypeLax; //Field offset: 0x0
	[Token(Token = "0x40005D0")]
	private static XmlSchemaComplexType anyTypeSkip; //Field offset: 0x8
	[Token(Token = "0x40005D1")]
	private static XmlSchemaComplexType untypedAnyType; //Field offset: 0x10
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005CC")]
	private XmlSchemaDerivationMethod block; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005CD")]
	private XmlSchemaParticle contentTypeParticle; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005CE")]
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005D2")]
	private byte pvFlags; //Field offset: 0x58

	[Token(Token = "0x17000316")]
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType
	{
		[Address(RVA = "0x16D8570", Offset = "0x16D7770", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000B3C")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000317")]
	internal static ContentValidator AnyTypeContentValidator
	{
		[Address(RVA = "0x16D84F0", Offset = "0x16D76F0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B3D")]
		internal get { } //Length: 112
	}

	[Token(Token = "0x17000319")]
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B3F")]
		 get { } //Length: 5
	}

	[DefaultValue(False)]
	[Token(Token = "0x17000318")]
	[XmlAttribute("mixed")]
	public virtual bool IsMixed
	{
		[Address(RVA = "0x16D85C0", Offset = "0x16D77C0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000B3E")]
		 set { } //Length: 33
	}

	[Address(RVA = "0x16D80E0", Offset = "0x16D72E0", Length = "0x32D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B39")]
	private static XmlSchemaComplexType() { }

	[Address(RVA = "0x16D8410", Offset = "0x16D7610", Length = "0xDC")]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B3B")]
	public XmlSchemaComplexType() { }

	[Address(RVA = "0x16D78C0", Offset = "0x16D6AC0", Length = "0x818")]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NamespaceList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000B3A")]
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	[Address(RVA = "0x16D8570", Offset = "0x16D7770", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000B3C")]
	internal static XmlSchemaComplexType get_AnyType() { }

	[Address(RVA = "0x16D84F0", Offset = "0x16D76F0", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3D")]
	internal static ContentValidator get_AnyTypeContentValidator() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B3F")]
	public XmlSchemaParticle get_ContentTypeParticle() { }

	[Address(RVA = "0x16D85C0", Offset = "0x16D77C0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000B3E")]
	public virtual void set_IsMixed(bool value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B41")]
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B40")]
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

}


namespace System.Xml.Schema;

[Token(Token = "0x200013A")]
internal abstract class SchemaDeclBase
{
	[Token(Token = "0x200013B")]
	public enum Use
	{
		Default = 0,
		Required = 1,
		Implied = 2,
		Fixed = 3,
		RequiredFixed = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000579")]
	protected XmlQualifiedName name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400057A")]
	protected string prefix; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057B")]
	protected bool isDeclaredInExternal; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400057C")]
	protected Use presence; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400057D")]
	protected XmlSchemaType schemaType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400057E")]
	protected XmlSchemaDatatype datatype; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400057F")]
	protected string defaultValueRaw; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000580")]
	protected object defaultValueTyped; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000581")]
	protected long maxLength; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000582")]
	protected long minLength; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000583")]
	protected List<String> values; //Field offset: 0x58

	[Token(Token = "0x170002D4")]
	internal XmlSchemaDatatype Datatype
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABB")]
		internal get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABC")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002D6")]
	internal string DefaultValueRaw
	{
		[Address(RVA = "0x16BC890", Offset = "0x16BBA90", Length = "0x1E")]
		[CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000ABF")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x170002D7")]
	internal object DefaultValueTyped
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC0")]
		internal get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC1")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002D1")]
	internal bool IsDeclaredInExternal
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB6")]
		internal get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB7")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002CF")]
	internal XmlQualifiedName Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB4")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002D0")]
	internal string Prefix
	{
		[Address(RVA = "0x16BC8B0", Offset = "0x16BBAB0", Length = "0x1E")]
		[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x6000AB5")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x170002D2")]
	internal Use Presence
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB8")]
		internal get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AB9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002D3")]
	internal XmlSchemaType SchemaType
	{
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABA")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002D5")]
	internal List<String> Values
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ABE")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x16BC7D0", Offset = "0x16BB9D0", Length = "0xB5")]
	[CalledBy(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AB2")]
	protected SchemaDeclBase(XmlQualifiedName name, string prefix) { }

	[Address(RVA = "0x16BC5C0", Offset = "0x16BB7C0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB3")]
	protected SchemaDeclBase() { }

	[Address(RVA = "0x16BC6D0", Offset = "0x16BB8D0", Length = "0xFC")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000ABD")]
	internal void AddValue(string value) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABB")]
	internal XmlSchemaDatatype get_Datatype() { }

	[Address(RVA = "0x16BC890", Offset = "0x16BBA90", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000ABF")]
	internal string get_DefaultValueRaw() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC0")]
	internal object get_DefaultValueTyped() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB6")]
	internal bool get_IsDeclaredInExternal() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB4")]
	internal XmlQualifiedName get_Name() { }

	[Address(RVA = "0x16BC8B0", Offset = "0x16BBAB0", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x6000AB5")]
	internal string get_Prefix() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB8")]
	internal Use get_Presence() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABE")]
	internal List<String> get_Values() { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABC")]
	internal void set_Datatype(XmlSchemaDatatype value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC1")]
	internal void set_DefaultValueTyped(object value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB7")]
	internal void set_IsDeclaredInExternal(bool value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AB9")]
	internal void set_Presence(Use value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ABA")]
	internal void set_SchemaType(XmlSchemaType value) { }

}


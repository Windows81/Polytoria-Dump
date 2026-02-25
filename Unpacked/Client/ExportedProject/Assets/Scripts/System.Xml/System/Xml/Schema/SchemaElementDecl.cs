namespace System.Xml.Schema;

[Token(Token = "0x200013C")]
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
{
	[Token(Token = "0x4000593")]
	internal static readonly SchemaElementDecl Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400058A")]
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400058B")]
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400058C")]
	private bool isIdDeclared; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x400058D")]
	private bool hasNonCDataAttribute; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x400058E")]
	private bool hasRequiredAttribute; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x400058F")]
	private bool isNotationDeclared; //Field offset: 0x73
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000590")]
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000591")]
	private ContentValidator contentValidator; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000592")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x88

	[Token(Token = "0x170002DD")]
	internal XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD1")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170002DF")]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD5")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002DC")]
	internal ContentValidator ContentValidator
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ACF")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD0")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x170002DE")]
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD4")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002DA")]
	internal bool HasNonCDataAttribute
	{
		[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ACB")]
		internal get { } //Length: 5
		[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ACC")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002D9")]
	internal bool IsIdDeclared
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC9")]
		internal get { } //Length: 5
		[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ACA")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002DB")]
	internal bool IsNotationDeclared
	{
		[Address(RVA = "0x16BD010", Offset = "0x16BC210", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000ACD")]
		internal get { } //Length: 5
		[Address(RVA = "0x16BD020", Offset = "0x16BC220", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000ACE")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002D8")]
	private override bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
	{
		[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AC6")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x16BCC30", Offset = "0x16BBE30", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000AD6")]
	private static SchemaElementDecl() { }

	[Address(RVA = "0x16BCE20", Offset = "0x16BC020", Length = "0xDE")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AC4")]
	internal SchemaElementDecl(XmlQualifiedName name, string prefix) { }

	[Address(RVA = "0x16BCF00", Offset = "0x16BC100", Length = "0x110")]
	[CalledBy(Type = typeof(SchemaElementDecl), Member = "CreateAnyTypeElementDecl", ReturnType = typeof(SchemaElementDecl))]
	[CalledBy(Type = typeof(SchemaElementDecl), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC2")]
	internal SchemaElementDecl() { }

	[Address(RVA = "0x16BCCA0", Offset = "0x16BBEA0", Length = "0x176")]
	[CalledBy(Type = typeof(DatatypeImplementation), Member = "StartBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlSchemaDatatype)}, ReturnType = typeof(XmlSchemaSimpleType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AC3")]
	internal SchemaElementDecl(XmlSchemaDatatype dtype) { }

	[Address(RVA = "0x16BC8D0", Offset = "0x16BBAD0", Length = "0x152")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AD2")]
	internal void AddAttDef(SchemaAttDef attdef) { }

	[Address(RVA = "0x16BCA30", Offset = "0x16BBC30", Length = "0xC8")]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AC5")]
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD5")]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACF")]
	internal ContentValidator get_ContentValidator() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD4")]
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACB")]
	internal bool get_HasNonCDataAttribute() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC9")]
	internal bool get_IsIdDeclared() { }

	[Address(RVA = "0x16BD010", Offset = "0x16BC210", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000ACD")]
	internal bool get_IsNotationDeclared() { }

	[Address(RVA = "0x16BCB00", Offset = "0x16BBD00", Length = "0x78")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AD3")]
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD1")]
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD0")]
	internal void set_ContentValidator(ContentValidator value) { }

	[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACC")]
	internal void set_HasNonCDataAttribute(bool value) { }

	[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ACA")]
	internal void set_IsIdDeclared(bool value) { }

	[Address(RVA = "0x16BD020", Offset = "0x16BC220", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000ACE")]
	internal void set_IsNotationDeclared(bool value) { }

	[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC6")]
	private override bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	[Address(RVA = "0x16BCB80", Offset = "0x16BBD80", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AC7")]
	private override IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AC8")]
	private override IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

}


namespace System.Xml.Schema;

[Token(Token = "0x200013E")]
internal class SchemaInfo : IDtdInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A1")]
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A2")]
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A3")]
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005A4")]
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005A5")]
	private XmlQualifiedName docTypeName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005A6")]
	private string internalDtdSubset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005A7")]
	private bool hasNonCDataAttributes; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40005A8")]
	private bool hasDefaultAttributes; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005A9")]
	private Dictionary<String, Boolean> targetNamespaces; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005AA")]
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40005AB")]
	private SchemaType schemaType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005AC")]
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005AD")]
	private Dictionary<String, SchemaNotation> notations; //Field offset: 0x68

	[Token(Token = "0x170002F8")]
	public XmlQualifiedName DocTypeName
	{
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002FA")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFE")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002FC")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
	{
		[Address(RVA = "0x16BD700", Offset = "0x16BC900", Length = "0x7A")]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
		[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B00")]
		internal get { } //Length: 122
	}

	[Token(Token = "0x170002F9")]
	internal string InternalDtdSubset
	{
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFD")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002FF")]
	internal Dictionary<String, SchemaNotation> Notations
	{
		[Address(RVA = "0x16BD780", Offset = "0x16BC980", Length = "0x7A")]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B04")]
		internal get { } //Length: 122
	}

	[Token(Token = "0x170002FD")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
	{
		[Address(RVA = "0x16BD800", Offset = "0x16BCA00", Length = "0x7A")]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000B01")]
		internal get { } //Length: 122
	}

	[Token(Token = "0x170002FE")]
	internal SchemaType SchemaType
	{
		[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B02")]
		internal get { } //Length: 4
		[Address(RVA = "0x599420", Offset = "0x598620", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B03")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000300")]
	private override bool System.Xml.IDtdInfo.HasDefaultAttributes
	{
		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B06")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000301")]
	private override bool System.Xml.IDtdInfo.HasNonCDataAttributes
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B07")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000303")]
	private override string System.Xml.IDtdInfo.InternalDtdSubset
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0B")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000302")]
	private override XmlQualifiedName System.Xml.IDtdInfo.Name
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0A")]
		private get { } //Length: 95
	}

	[Token(Token = "0x170002FB")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFF")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x16BD530", Offset = "0x16BC730", Length = "0x1C8")]
	[CalledBy(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AFB")]
	internal SchemaInfo() { }

	[Address(RVA = "0x16BD200", Offset = "0x16BC400", Length = "0x183")]
	[CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000B05")]
	internal void Finish() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFE")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	[Address(RVA = "0x16BD700", Offset = "0x16BC900", Length = "0x7A")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B00")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	[Address(RVA = "0x16BD780", Offset = "0x16BC980", Length = "0x7A")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B04")]
	internal Dictionary<String, SchemaNotation> get_Notations() { }

	[Address(RVA = "0x16BD800", Offset = "0x16BCA00", Length = "0x7A")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(SchemaEntity))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B01")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	[Address(RVA = "0x406220", Offset = "0x405420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B02")]
	internal SchemaType get_SchemaType() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFF")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFC")]
	public void set_DocTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFD")]
	internal void set_InternalDtdSubset(string value) { }

	[Address(RVA = "0x599420", Offset = "0x598620", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B03")]
	internal void set_SchemaType(SchemaType value) { }

	[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B06")]
	private override bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B07")]
	private override bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0B")]
	private override string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0A")]
	private override XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	[Address(RVA = "0x16BD390", Offset = "0x16BC590", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B08")]
	private override IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	[Address(RVA = "0x16BD460", Offset = "0x16BC660", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B09")]
	private override IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

}


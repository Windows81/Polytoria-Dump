namespace System.Xml.Schema;

[Token(Token = "0x200013D")]
internal sealed class SchemaEntity : IDtdEntityInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000594")]
	private XmlQualifiedName qname; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000595")]
	private string url; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000596")]
	private string pubid; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000597")]
	private string text; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000598")]
	private XmlQualifiedName ndata; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000599")]
	private int lineNumber; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400059A")]
	private int linePosition; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400059B")]
	private bool isParameter; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400059C")]
	private bool isExternal; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x400059D")]
	private bool parsingInProgress; //Field offset: 0x42
	[FieldOffset(Offset = "0x43")]
	[Token(Token = "0x400059E")]
	private bool isDeclaredInExternal; //Field offset: 0x43
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400059F")]
	private string baseURI; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005A0")]
	private string declaredURI; //Field offset: 0x50

	[Token(Token = "0x170002F5")]
	internal string BaseURI
	{
		[Address(RVA = "0x16BD140", Offset = "0x16BC340", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AF5")]
		internal get { } //Length: 30
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF6")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002F0")]
	internal bool DeclaredInExternal
	{
		[Address(RVA = "0x145D750", Offset = "0x145C950", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEB")]
		internal get { } //Length: 5
		[Address(RVA = "0x16BD190", Offset = "0x16BC390", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AEC")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002F7")]
	internal string DeclaredURI
	{
		[Address(RVA = "0x16BD160", Offset = "0x16BC360", Length = "0x1E")]
		[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000AF9")]
		internal get { } //Length: 30
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AFA")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002EF")]
	internal bool IsExternal
	{
		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE9")]
		internal get { } //Length: 5
		[Address(RVA = "0x16BD1A0", Offset = "0x16BC3A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEA")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002F3")]
	internal int Line
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF1")]
		internal get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF2")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002EC")]
	internal XmlQualifiedName Name
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE4")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002F1")]
	internal XmlQualifiedName NData
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AED")]
		internal get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEE")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002F6")]
	internal bool ParsingInProgress
	{
		[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF7")]
		internal get { } //Length: 5
		[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF8")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002F4")]
	internal int Pos
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF3")]
		internal get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AF4")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002EE")]
	internal string Pubid
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE7")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE8")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002E5")]
	private override string System.Xml.IDtdEntityInfo.BaseUriString
	{
		[Address(RVA = "0x16BD030", Offset = "0x16BC230", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000ADD")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170002E6")]
	private override string System.Xml.IDtdEntityInfo.DeclaredUriString
	{
		[Address(RVA = "0x16BD050", Offset = "0x16BC250", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000ADE")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170002E2")]
	private override bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
	{
		[Address(RVA = "0x145D750", Offset = "0x145C950", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ADA")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002E1")]
	private override bool System.Xml.IDtdEntityInfo.IsExternal
	{
		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD9")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002E4")]
	private override bool System.Xml.IDtdEntityInfo.IsParameterEntity
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ADC")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002E3")]
	private override bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
	{
		[Address(RVA = "0x16BD070", Offset = "0x16BC270", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000ADB")]
		private get { } //Length: 32
	}

	[Token(Token = "0x170002EA")]
	private override int System.Xml.IDtdEntityInfo.LineNumber
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE2")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170002EB")]
	private override int System.Xml.IDtdEntityInfo.LinePosition
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE3")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170002E0")]
	private override string System.Xml.IDtdEntityInfo.Name
	{
		[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AD8")]
		private get { } //Length: 27
	}

	[Token(Token = "0x170002E8")]
	private override string System.Xml.IDtdEntityInfo.PublicId
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE0")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002E7")]
	private override string System.Xml.IDtdEntityInfo.SystemId
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000ADF")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002E9")]
	private override string System.Xml.IDtdEntityInfo.Text
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE1")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002F2")]
	internal string Text
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEF")]
		internal get { } //Length: 5
		[Address(RVA = "0x16BD1C0", Offset = "0x16BC3C0", Length = "0x20")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000AF0")]
		internal set { } //Length: 32
	}

	[Token(Token = "0x170002ED")]
	internal string Url
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE5")]
		internal get { } //Length: 5
		[Address(RVA = "0x16BD1E0", Offset = "0x16BC3E0", Length = "0x20")]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000AE6")]
		internal set { } //Length: 32
	}

	[Address(RVA = "0x16BD0A0", Offset = "0x16BC2A0", Length = "0x9A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AD7")]
	internal SchemaEntity(XmlQualifiedName qname, bool isParameter) { }

	[Address(RVA = "0x16BD140", Offset = "0x16BC340", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AF5")]
	internal string get_BaseURI() { }

	[Address(RVA = "0x145D750", Offset = "0x145C950", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEB")]
	internal bool get_DeclaredInExternal() { }

	[Address(RVA = "0x16BD160", Offset = "0x16BC360", Length = "0x1E")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdInfo), typeof(XmlDocumentType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000AF9")]
	internal string get_DeclaredURI() { }

	[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE9")]
	internal bool get_IsExternal() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF1")]
	internal int get_Line() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE4")]
	internal XmlQualifiedName get_Name() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AED")]
	internal XmlQualifiedName get_NData() { }

	[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF7")]
	internal bool get_ParsingInProgress() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF3")]
	internal int get_Pos() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE7")]
	internal string get_Pubid() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEF")]
	internal string get_Text() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE5")]
	internal string get_Url() { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF6")]
	internal void set_BaseURI(string value) { }

	[Address(RVA = "0x16BD190", Offset = "0x16BC390", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AEC")]
	internal void set_DeclaredInExternal(bool value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AFA")]
	internal void set_DeclaredURI(string value) { }

	[Address(RVA = "0x16BD1A0", Offset = "0x16BC3A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEA")]
	internal void set_IsExternal(bool value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF2")]
	internal void set_Line(int value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEE")]
	internal void set_NData(XmlQualifiedName value) { }

	[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF8")]
	internal void set_ParsingInProgress(bool value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AF4")]
	internal void set_Pos(int value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE8")]
	internal void set_Pubid(string value) { }

	[Address(RVA = "0x16BD1C0", Offset = "0x16BC3C0", Length = "0x20")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000AF0")]
	internal void set_Text(string value) { }

	[Address(RVA = "0x16BD1E0", Offset = "0x16BC3E0", Length = "0x20")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000AE6")]
	internal void set_Url(string value) { }

	[Address(RVA = "0x16BD030", Offset = "0x16BC230", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000ADD")]
	private override string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	[Address(RVA = "0x16BD050", Offset = "0x16BC250", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000ADE")]
	private override string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	[Address(RVA = "0x145D750", Offset = "0x145C950", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADA")]
	private override bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD9")]
	private override bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADC")]
	private override bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	[Address(RVA = "0x16BD070", Offset = "0x16BC270", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000ADB")]
	private override bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE2")]
	private override int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE3")]
	private override int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AD8")]
	private override string System.Xml.IDtdEntityInfo.get_Name() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE0")]
	private override string System.Xml.IDtdEntityInfo.get_PublicId() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000ADF")]
	private override string System.Xml.IDtdEntityInfo.get_SystemId() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE1")]
	private override string System.Xml.IDtdEntityInfo.get_Text() { }

}


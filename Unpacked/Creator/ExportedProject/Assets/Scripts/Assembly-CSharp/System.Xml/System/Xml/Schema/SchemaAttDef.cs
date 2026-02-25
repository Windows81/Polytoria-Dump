namespace System.Xml.Schema;

[Token(Token = "0x2000138")]
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
{
	[Token(Token = "0x2000139")]
	public enum Reserve
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
	}

	[Token(Token = "0x4000574")]
	public static readonly SchemaAttDef Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400056E")]
	private string defExpanded; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400056F")]
	private int lineNum; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000570")]
	private int linePos; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000571")]
	private int valueLineNum; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000572")]
	private int valueLinePos; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000573")]
	private Reserve reserved; //Field offset: 0x78

	[Token(Token = "0x170002CC")]
	internal string DefaultValueExpanded
	{
		[Address(RVA = "0x16BC630", Offset = "0x16BB830", Length = "0x1E")]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DtdValidator), Member = "SetDefaultTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000AAA")]
		internal get { } //Length: 30
		[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAB")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002C9")]
	internal int LineNumber
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA4")]
		internal get { } //Length: 4
		[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA5")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002C8")]
	internal int LinePosition
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA2")]
		internal get { } //Length: 4
		[Address(RVA = "0x96AC70", Offset = "0x969E70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA3")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002CE")]
	internal Reserve Reserved
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAE")]
		internal get { } //Length: 4
		[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAF")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002C2")]
	private override bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9C")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002C1")]
	private override bool System.Xml.IDtdAttributeInfo.IsNonCDataType
	{
		[Address(RVA = "0x16BC460", Offset = "0x16BB660", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A9B")]
		private get { } //Length: 47
	}

	[Token(Token = "0x170002C3")]
	private override bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
	{
		[Address(RVA = "0x16BC490", Offset = "0x16BB690", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000A9D")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170002BF")]
	private override int System.Xml.IDtdAttributeInfo.LineNumber
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A99")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170002C0")]
	private override int System.Xml.IDtdAttributeInfo.LinePosition
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9A")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170002BE")]
	private override string System.Xml.IDtdAttributeInfo.LocalName
	{
		[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A98")]
		private get { } //Length: 27
	}

	[Token(Token = "0x170002BD")]
	private override string System.Xml.IDtdAttributeInfo.Prefix
	{
		[Address(RVA = "0x16BC4A0", Offset = "0x16BB6A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A97")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170002C4")]
	private override string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
	{
		[Address(RVA = "0x16BC4C0", Offset = "0x16BB6C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000A9E")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170002C5")]
	private override object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A9F")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002C6")]
	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA0")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170002C7")]
	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
	{
		[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA1")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170002CD")]
	internal XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x10AA180", Offset = "0x10A9380", Length = "0x2A")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AAC")]
		internal get { } //Length: 42
		[Address(RVA = "0x16BC650", Offset = "0x16BB850", Length = "0x63")]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000AAD")]
		internal set { } //Length: 99
	}

	[Token(Token = "0x170002CB")]
	internal int ValueLineNumber
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA8")]
		internal get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002CA")]
	internal int ValueLinePosition
	{
		[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA6")]
		internal get { } //Length: 4
		[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AA7")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x16BC4F0", Offset = "0x16BB6F0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AB1")]
	private static SchemaAttDef() { }

	[Address(RVA = "0x16BC5B0", Offset = "0x16BB7B0", Length = "0x8")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A95")]
	public SchemaAttDef(XmlQualifiedName name, string prefix) { }

	[Address(RVA = "0x16BC5C0", Offset = "0x16BB7C0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A96")]
	private SchemaAttDef() { }

	[Address(RVA = "0x16BC1B0", Offset = "0x16BB3B0", Length = "0x2A3")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000AB0")]
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	[Address(RVA = "0x16BC630", Offset = "0x16BB830", Length = "0x1E")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdValidator), Member = "SetDefaultTypedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(IDtdParserAdapter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000AAA")]
	internal string get_DefaultValueExpanded() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA4")]
	internal int get_LineNumber() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA2")]
	internal int get_LinePosition() { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAE")]
	internal Reserve get_Reserved() { }

	[Address(RVA = "0x10AA180", Offset = "0x10A9380", Length = "0x2A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAC")]
	internal XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA8")]
	internal int get_ValueLineNumber() { }

	[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA6")]
	internal int get_ValueLinePosition() { }

	[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAB")]
	internal void set_DefaultValueExpanded(string value) { }

	[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA5")]
	internal void set_LineNumber(int value) { }

	[Address(RVA = "0x96AC70", Offset = "0x969E70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA3")]
	internal void set_LinePosition(int value) { }

	[Address(RVA = "0x504780", Offset = "0x503980", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAF")]
	internal void set_Reserved(Reserve value) { }

	[Address(RVA = "0x16BC650", Offset = "0x16BB850", Length = "0x63")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef), typeof(SchemaElementDecl), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DatatypeImplementation), Member = "FromXmlTokenizedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTokenizedType)}, ReturnType = typeof(DatatypeImplementation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000AAD")]
	internal void set_TokenizedType(XmlTokenizedType value) { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA9")]
	internal void set_ValueLineNumber(int value) { }

	[Address(RVA = "0x16BC6C0", Offset = "0x16BB8C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA7")]
	internal void set_ValueLinePosition(int value) { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9C")]
	private override bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	[Address(RVA = "0x16BC460", Offset = "0x16BB660", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A9B")]
	private override bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	[Address(RVA = "0x16BC490", Offset = "0x16BB690", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000A9D")]
	private override bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A99")]
	private override int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9A")]
	private override int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A98")]
	private override string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	[Address(RVA = "0x16BC4A0", Offset = "0x16BB6A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A97")]
	private override string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	[Address(RVA = "0x16BC4C0", Offset = "0x16BB6C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000A9E")]
	private override string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9F")]
	private override object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA0")]
	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AA1")]
	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

}


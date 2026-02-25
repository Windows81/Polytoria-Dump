namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
[Token(Token = "0x200003A")]
public abstract class XmlReader : IDisposable
{
	[Token(Token = "0x40000E0")]
	private static uint IsTextualNodeBitmap; //Field offset: 0x0
	[Token(Token = "0x40000E1")]
	private static uint CanReadContentAsBitmap; //Field offset: 0x4
	[Token(Token = "0x40000E2")]
	private static uint HasValueBitmap; //Field offset: 0x8

	[Token(Token = "0x17000055")]
	public abstract string BaseURI
	{
		[Token(Token = "0x6000206")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700005B")]
	public override bool CanResolveEntity
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000214")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700005C")]
	internal override IDtdInfo DtdInfo
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000218")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000057")]
	public override bool IsDefault
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000208")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000056")]
	public abstract bool IsEmptyElement
	{
		[Token(Token = "0x6000207")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000051")]
	public abstract string LocalName
	{
		[Token(Token = "0x6000202")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000050")]
	public override string Name
	{
		[Address(RVA = "0x163BB70", Offset = "0x163AD70", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000201")]
		 get { } //Length: 261
	}

	[Token(Token = "0x17000052")]
	public abstract string NamespaceURI
	{
		[Token(Token = "0x6000203")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700005A")]
	public abstract XmlNameTable NameTable
	{
		[Token(Token = "0x6000212")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004F")]
	public abstract XmlNodeType NodeType
	{
		[Token(Token = "0x6000200")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000053")]
	public abstract string Prefix
	{
		[Token(Token = "0x6000204")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000059")]
	public abstract ReadState ReadState
	{
		[Token(Token = "0x6000211")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000058")]
	public override IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x163BC80", Offset = "0x163AE80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Token(Token = "0x6000209")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700004E")]
	public override XmlReaderSettings Settings
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000054")]
	public abstract string Value
	{
		[Token(Token = "0x6000205")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x163BB00", Offset = "0x163AD00", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600021B")]
	private static XmlReader() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021A")]
	protected XmlReader() { }

	[Address(RVA = "0x163BA00", Offset = "0x163AC00", Length = "0x96")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000219")]
	internal static int CalcBufferSize(Stream input) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000210")]
	public override void Close() { }

	[Address(RVA = "0x163BAA0", Offset = "0x163ACA0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000216")]
	public override void Dispose() { }

	[Address(RVA = "0x163BAC0", Offset = "0x163ACC0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000217")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x6000206")]
	public abstract string get_BaseURI() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000214")]
	public override bool get_CanResolveEntity() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000218")]
	internal override IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000208")]
	public override bool get_IsDefault() { }

	[Token(Token = "0x6000207")]
	public abstract bool get_IsEmptyElement() { }

	[Token(Token = "0x6000202")]
	public abstract string get_LocalName() { }

	[Address(RVA = "0x163BB70", Offset = "0x163AD70", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000201")]
	public override string get_Name() { }

	[Token(Token = "0x6000203")]
	public abstract string get_NamespaceURI() { }

	[Token(Token = "0x6000212")]
	public abstract XmlNameTable get_NameTable() { }

	[Token(Token = "0x6000200")]
	public abstract XmlNodeType get_NodeType() { }

	[Token(Token = "0x6000204")]
	public abstract string get_Prefix() { }

	[Token(Token = "0x6000211")]
	public abstract ReadState get_ReadState() { }

	[Address(RVA = "0x163BC80", Offset = "0x163AE80", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x6000209")]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FF")]
	public override XmlReaderSettings get_Settings() { }

	[Token(Token = "0x6000205")]
	public abstract string get_Value() { }

	[Token(Token = "0x6000213")]
	public abstract string LookupNamespace(string prefix) { }

	[Token(Token = "0x600020A")]
	public abstract bool MoveToAttribute(string name) { }

	[Token(Token = "0x600020D")]
	public abstract bool MoveToElement() { }

	[Token(Token = "0x600020B")]
	public abstract bool MoveToFirstAttribute() { }

	[Token(Token = "0x600020C")]
	public abstract bool MoveToNextAttribute() { }

	[Token(Token = "0x600020F")]
	public abstract bool Read() { }

	[Token(Token = "0x600020E")]
	public abstract bool ReadAttributeValue() { }

	[Token(Token = "0x6000215")]
	public abstract void ResolveEntity() { }

}


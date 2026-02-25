namespace System.Xml;

[Token(Token = "0x200003B")]
public sealed class XmlReaderSettings
{
	[Token(Token = "0x40000F6")]
	private static Nullable<Boolean> s_enableLegacyXmlSettings; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E3")]
	private bool useAsync; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E4")]
	private XmlNameTable nameTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E5")]
	private XmlResolver xmlResolver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E6")]
	private int lineNumberOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000E7")]
	private int linePositionOffset; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E8")]
	private ConformanceLevel conformanceLevel; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000E9")]
	private bool checkCharacters; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000EA")]
	private long maxCharactersInDocument; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000EB")]
	private long maxCharactersFromEntities; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000EC")]
	private bool ignoreWhitespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40000ED")]
	private bool ignorePIs; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x40000EE")]
	private bool ignoreComments; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000EF")]
	private DtdProcessing dtdProcessing; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000F0")]
	private ValidationType validationType; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000F1")]
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000F2")]
	private XmlSchemaSet schemas; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000F3")]
	private bool closeInput; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40000F4")]
	private bool isReadOnly; //Field offset: 0x61
	[CompilerGenerated]
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x40000F5")]
	private bool <IsXmlResolverSet>k__BackingField; //Field offset: 0x62

	[Token(Token = "0x17000063")]
	public bool CheckCharacters
	{
		[Address(RVA = "0x163B4E0", Offset = "0x163A6E0", Length = "0x4D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000224")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000062")]
	public ConformanceLevel ConformanceLevel
	{
		[Address(RVA = "0x163B530", Offset = "0x163A730", Length = "0x98")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000223")]
		 set { } //Length: 152
	}

	[Token(Token = "0x17000069")]
	public DtdProcessing DtdProcessing
	{
		[Address(RVA = "0x163B5D0", Offset = "0x163A7D0", Length = "0x98")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600022A")]
		 set { } //Length: 152
	}

	[Token(Token = "0x17000068")]
	public bool IgnoreComments
	{
		[Address(RVA = "0x163B670", Offset = "0x163A870", Length = "0x4D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000229")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000067")]
	public bool IgnoreProcessingInstructions
	{
		[Address(RVA = "0x163B6C0", Offset = "0x163A8C0", Length = "0x4D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000228")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000066")]
	public bool IgnoreWhitespace
	{
		[Address(RVA = "0x163B710", Offset = "0x163A910", Length = "0x4D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000227")]
		 set { } //Length: 77
	}

	[Token(Token = "0x1700005E")]
	internal bool IsXmlResolverSet
	{
		[Address(RVA = "0x3D02B0", Offset = "0x3CF4B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600021E")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000060")]
	public int LineNumberOffset
	{
		[Address(RVA = "0x163B760", Offset = "0x163A960", Length = "0x4B")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000221")]
		 set { } //Length: 75
	}

	[Token(Token = "0x17000061")]
	public int LinePositionOffset
	{
		[Address(RVA = "0x163B7B0", Offset = "0x163A9B0", Length = "0x4B")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000222")]
		 set { } //Length: 75
	}

	[Token(Token = "0x17000065")]
	public long MaxCharactersFromEntities
	{
		[Address(RVA = "0x163B800", Offset = "0x163AA00", Length = "0x9A")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000226")]
		 set { } //Length: 154
	}

	[Token(Token = "0x17000064")]
	public long MaxCharactersInDocument
	{
		[Address(RVA = "0x163B8A0", Offset = "0x163AAA0", Length = "0x9A")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000225")]
		 set { } //Length: 154
	}

	[Token(Token = "0x1700005D")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x163B940", Offset = "0x163AB40", Length = "0x58")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600021D")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700006C")]
	internal bool ReadOnly
	{
		[Address(RVA = "0x3D02C0", Offset = "0x3CF4C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022D")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700006B")]
	public XmlSchemaSet Schemas
	{
		[Address(RVA = "0x163B470", Offset = "0x163A670", Length = "0x69")]
		[CalledBy(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600022C")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700006A")]
	public ValidationType ValidationType
	{
		[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700005F")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x163B9A0", Offset = "0x163ABA0", Length = "0x5D")]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
		[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600021F")]
		 set { } //Length: 93
	}

	[Address(RVA = "0x163B440", Offset = "0x163A640", Length = "0x22")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600021C")]
	public XmlReaderSettings() { }

	[Address(RVA = "0x163B0D0", Offset = "0x163A2D0", Length = "0xAC")]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Token(Token = "0x600022E")]
	private void CheckReadOnly(string propertyName) { }

	[Address(RVA = "0x163B180", Offset = "0x163A380", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000231")]
	private static XmlResolver CreateDefaultResolver() { }

	[Address(RVA = "0x163B1D0", Offset = "0x163A3D0", Length = "0xCB")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000232")]
	internal static bool EnableLegacyXmlSettings() { }

	[Address(RVA = "0x163B470", Offset = "0x163A670", Length = "0x69")]
	[CalledBy(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaSet), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600022C")]
	public XmlSchemaSet get_Schemas() { }

	[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022B")]
	public ValidationType get_ValidationType() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000220")]
	internal XmlResolver GetXmlResolver() { }

	[Address(RVA = "0x163B2A0", Offset = "0x163A4A0", Length = "0x18E")]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000230")]
	private void Initialize(XmlResolver resolver) { }

	[Address(RVA = "0x163B430", Offset = "0x163A630", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Token(Token = "0x600022F")]
	private void Initialize() { }

	[Address(RVA = "0x163B4E0", Offset = "0x163A6E0", Length = "0x4D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000224")]
	public void set_CheckCharacters(bool value) { }

	[Address(RVA = "0x163B530", Offset = "0x163A730", Length = "0x98")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000223")]
	public void set_ConformanceLevel(ConformanceLevel value) { }

	[Address(RVA = "0x163B5D0", Offset = "0x163A7D0", Length = "0x98")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600022A")]
	public void set_DtdProcessing(DtdProcessing value) { }

	[Address(RVA = "0x163B670", Offset = "0x163A870", Length = "0x4D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000229")]
	public void set_IgnoreComments(bool value) { }

	[Address(RVA = "0x163B6C0", Offset = "0x163A8C0", Length = "0x4D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000228")]
	public void set_IgnoreProcessingInstructions(bool value) { }

	[Address(RVA = "0x163B710", Offset = "0x163A910", Length = "0x4D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000227")]
	public void set_IgnoreWhitespace(bool value) { }

	[Address(RVA = "0x3D02B0", Offset = "0x3CF4B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600021E")]
	internal void set_IsXmlResolverSet(bool value) { }

	[Address(RVA = "0x163B760", Offset = "0x163A960", Length = "0x4B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000221")]
	public void set_LineNumberOffset(int value) { }

	[Address(RVA = "0x163B7B0", Offset = "0x163A9B0", Length = "0x4B")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000222")]
	public void set_LinePositionOffset(int value) { }

	[Address(RVA = "0x163B800", Offset = "0x163AA00", Length = "0x9A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000226")]
	public void set_MaxCharactersFromEntities(long value) { }

	[Address(RVA = "0x163B8A0", Offset = "0x163AAA0", Length = "0x9A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000225")]
	public void set_MaxCharactersInDocument(long value) { }

	[Address(RVA = "0x163B940", Offset = "0x163AB40", Length = "0x58")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600021D")]
	public void set_NameTable(XmlNameTable value) { }

	[Address(RVA = "0x3D02C0", Offset = "0x3CF4C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022D")]
	internal void set_ReadOnly(bool value) { }

	[Address(RVA = "0x163B9A0", Offset = "0x163ABA0", Length = "0x5D")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Settings", ReturnType = typeof(XmlReaderSettings))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlReaderSettings), Member = "CheckReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600021F")]
	public void set_XmlResolver(XmlResolver value) { }

}


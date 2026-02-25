namespace System;

[Token(Token = "0x20000CB")]
public abstract class UriParser
{
	[Token(Token = "0x20000CD")]
	private class BuiltInUriParser : UriParser
	{

		[Address(RVA = "0x174D590", Offset = "0x174C790", Length = "0x8C")]
		[CalledBy(Type = typeof(UriParser), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriParser), Member = "FindOrFetchAsUnknownV1Syntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UriParser))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600043B")]
		internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

	}

	[Token(Token = "0x20000CC")]
	private enum UriQuirksVersion
	{
		V2 = 2,
		V3 = 3,
	}

	[Token(Token = "0x40002EF")]
	private const UriSyntaxFlags SchemeOnlyFlags = 16; //Field offset: 0x0
	[Token(Token = "0x4000316")]
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796; //Field offset: 0x0
	[Token(Token = "0x4000315")]
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565; //Field offset: 0x0
	[Token(Token = "0x4000314")]
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405; //Field offset: 0x0
	[Token(Token = "0x4000313")]
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405; //Field offset: 0x0
	[Token(Token = "0x4000312")]
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536; //Field offset: 0x0
	[Token(Token = "0x4000311")]
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405; //Field offset: 0x0
	[Token(Token = "0x4000310")]
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697; //Field offset: 0x0
	[Token(Token = "0x400030E")]
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533; //Field offset: 0x0
	[Token(Token = "0x400030C")]
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590; //Field offset: 0x0
	[Token(Token = "0x400030B")]
	private const int c_MaxCapacity = 512; //Field offset: 0x0
	[Token(Token = "0x4000317")]
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729; //Field offset: 0x0
	[Token(Token = "0x4000318")]
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737; //Field offset: 0x0
	[Token(Token = "0x40002F0")]
	private static readonly Dictionary<String, UriParser> m_Table; //Field offset: 0x0
	[Token(Token = "0x40002F5")]
	private const UriSyntaxFlags c_UpdatableFlags = 33554432; //Field offset: 0x0
	[Token(Token = "0x40002F8")]
	internal const int NoDefaultPort = -1; //Field offset: 0x0
	[Token(Token = "0x40002F9")]
	private const int c_InitialTableSize = 25; //Field offset: 0x0
	[Token(Token = "0x40002F1")]
	private static Dictionary<String, UriParser> m_TempTable; //Field offset: 0x8
	[Token(Token = "0x40002FA")]
	internal static UriParser HttpUri; //Field offset: 0x10
	[Token(Token = "0x40002FB")]
	internal static UriParser HttpsUri; //Field offset: 0x18
	[Token(Token = "0x40002FC")]
	internal static UriParser WsUri; //Field offset: 0x20
	[Token(Token = "0x40002FD")]
	internal static UriParser WssUri; //Field offset: 0x28
	[Token(Token = "0x40002FE")]
	internal static UriParser FtpUri; //Field offset: 0x30
	[Token(Token = "0x40002FF")]
	internal static UriParser FileUri; //Field offset: 0x38
	[Token(Token = "0x4000300")]
	internal static UriParser GopherUri; //Field offset: 0x40
	[Token(Token = "0x4000301")]
	internal static UriParser NntpUri; //Field offset: 0x48
	[Token(Token = "0x4000302")]
	internal static UriParser NewsUri; //Field offset: 0x50
	[Token(Token = "0x4000303")]
	internal static UriParser MailToUri; //Field offset: 0x58
	[Token(Token = "0x4000304")]
	internal static UriParser UuidUri; //Field offset: 0x60
	[Token(Token = "0x4000305")]
	internal static UriParser TelnetUri; //Field offset: 0x68
	[Token(Token = "0x4000306")]
	internal static UriParser LdapUri; //Field offset: 0x70
	[Token(Token = "0x4000307")]
	internal static UriParser NetTcpUri; //Field offset: 0x78
	[Token(Token = "0x4000308")]
	internal static UriParser NetPipeUri; //Field offset: 0x80
	[Token(Token = "0x4000309")]
	internal static UriParser VsMacrosUri; //Field offset: 0x88
	[Token(Token = "0x400030A")]
	private static readonly UriQuirksVersion s_QuirksVersion; //Field offset: 0x90
	[Token(Token = "0x400030D")]
	private static readonly UriSyntaxFlags HttpSyntaxFlags; //Field offset: 0x94
	[Token(Token = "0x400030F")]
	private static readonly UriSyntaxFlags FileSyntaxFlags; //Field offset: 0x98
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F2")]
	private UriSyntaxFlags m_Flags; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002F3")]
	private UriSyntaxFlags m_UpdatableFlags; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F4")]
	private bool m_UpdatableFlagsUsed; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002F6")]
	private int m_Port; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F7")]
	private string m_Scheme; //Field offset: 0x20

	[Token(Token = "0x170000B7")]
	internal int DefaultPort
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000422")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000B9")]
	internal UriSyntaxFlags Flags
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042C")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170000BA")]
	internal bool IsSimple
	{
		[Address(RVA = "0x174B3C0", Offset = "0x174A5C0", Length = "0xB")]
		[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
		[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 16)]
		[Token(Token = "0x6000434")]
		internal get { } //Length: 11
	}

	[Token(Token = "0x170000B6")]
	internal string SchemeName
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000421")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000B8")]
	internal static bool ShouldUseLegacyV2Quirks
	{
		[Address(RVA = "0x174B3D0", Offset = "0x174A5D0", Length = "0x55")]
		[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
		[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
		[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600042A")]
		internal get { } //Length: 85
	}

	[Address(RVA = "0x174A660", Offset = "0x1749860", Length = "0xCCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BuiltInUriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042B")]
	private static UriParser() { }

	[Address(RVA = "0x174B380", Offset = "0x174A580", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000423")]
	protected UriParser() { }

	[Address(RVA = "0x174B330", Offset = "0x174A530", Length = "0x41")]
	[CalledBy(Type = typeof(BuiltInUriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000431")]
	internal UriParser(UriSyntaxFlags flags) { }

	[Address(RVA = "0x1749A80", Offset = "0x1748C80", Length = "0x33B")]
	[CalledBy(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuiltInUriParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(UriSyntaxFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x6000432")]
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000422")]
	internal int get_DefaultPort() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042C")]
	internal UriSyntaxFlags get_Flags() { }

	[Address(RVA = "0x174B3C0", Offset = "0x174A5C0", Length = "0xB")]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Token(Token = "0x6000434")]
	internal bool get_IsSimple() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000421")]
	internal string get_SchemeName() { }

	[Address(RVA = "0x174B3D0", Offset = "0x174A5D0", Length = "0x55")]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042A")]
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	[Address(RVA = "0x1749DC0", Offset = "0x1748FC0", Length = "0x279")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_UserDrivenParsing", ReturnType = typeof(bool))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000428")]
	protected override string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	[Address(RVA = "0x174A040", Offset = "0x1749240", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000433")]
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	[Address(RVA = "0x174A120", Offset = "0x1749320", Length = "0x5C")]
	[CalledBy(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(Uri), Member = "IriParsingStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "StaticIsFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = "System.Uri+Check")]
	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042E")]
	internal bool InFact(UriSyntaxFlags flags) { }

	[Address(RVA = "0x174A180", Offset = "0x1749380", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000425")]
	protected override void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	[Address(RVA = "0x174A1C0", Offset = "0x17493C0", Length = "0x19")]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000439")]
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	[Address(RVA = "0x174A1E0", Offset = "0x17493E0", Length = "0x14")]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000438")]
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	[Address(RVA = "0x174A200", Offset = "0x1749400", Length = "0x14")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600043A")]
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

	[Address(RVA = "0x174A220", Offset = "0x1749420", Length = "0x5D")]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000435")]
	internal UriParser InternalOnNewUri() { }

	[Address(RVA = "0x174A280", Offset = "0x1749480", Length = "0x19")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000437")]
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	[Address(RVA = "0x174A2A0", Offset = "0x17494A0", Length = "0x14")]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000436")]
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	[Address(RVA = "0x174A2C0", Offset = "0x17494C0", Length = "0x5E")]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042F")]
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	[Address(RVA = "0x174A320", Offset = "0x1749520", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000427")]
	protected override bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	[Address(RVA = "0x174A350", Offset = "0x1749550", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000430")]
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	[Address(RVA = "0x174A3C0", Offset = "0x17495C0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000429")]
	protected override bool IsWellFormedOriginalString(Uri uri) { }

	[Address(RVA = "0x174A3E0", Offset = "0x17495E0", Length = "0x5C")]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042D")]
	internal bool NotAny(UriSyntaxFlags flags) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000424")]
	protected override UriParser OnNewUri() { }

	[Address(RVA = "0x174A440", Offset = "0x1749640", Length = "0x21A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "get_UserDrivenParsing", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000426")]
	protected override string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

}


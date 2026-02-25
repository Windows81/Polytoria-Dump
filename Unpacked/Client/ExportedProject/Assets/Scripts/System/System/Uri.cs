namespace System;

[Token(Token = "0x20000BC")]
[TypeConverter(typeof(UriTypeConverter))]
public class Uri : ISerializable
{
	[Flags]
	[Token(Token = "0x20000C1")]
	private enum Check
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 128,
		BackslashInPath = 16,
		ReservedFound = 32,
		NotIriCanonical = 64,
		FoundNonAscii = 8,
	}

	[Flags]
	[Token(Token = "0x20000BD")]
	private enum Flags
	{
		Zero = 0,
		SchemeNotCanonical = 1,
		UserNotCanonical = 2,
		HostNotCanonical = 4,
		PortNotCanonical = 8,
		PathNotCanonical = 16,
		QueryNotCanonical = 32,
		FragmentNotCanonical = 64,
		CannotDisplayCanonical = 127,
		E_UserNotCanonical = 128,
		E_HostNotCanonical = 256,
		E_PortNotCanonical = 512,
		E_PathNotCanonical = 1024,
		E_QueryNotCanonical = 2048,
		E_FragmentNotCanonical = 4096,
		E_CannotDisplayCanonical = 8064,
		ShouldBeCompressed = 8192,
		FirstSlashAbsent = 16384,
		BackslashInPath = 32768,
		IndexMask = 65535,
		HostTypeMask = 458752,
		HostNotParsed = 0,
		IPv6HostType = 65536,
		IPv4HostType = 131072,
		DnsHostType = 196608,
		UncHostType = 262144,
		BasicHostType = 327680,
		UnusedHostType = 393216,
		UnknownHostType = 458752,
		UserEscaped = 524288,
		AuthorityFound = 1048576,
		HasUserInfo = 2097152,
		LoopbackHost = 4194304,
		NotDefaultPort = 8388608,
		UserDrivenParsing = 16777216,
		CanonicalDnsHost = 33554432,
		ErrorOrParsingRecursion = 67108864,
		DosPath = 134217728,
		UncPath = 268435456,
		ImplicitFile = 536870912,
		MinimalUriInfoSet = 1073741824,
		AllUriInfoSet = 2147483648,
		IdnHost = 4294967296,
		HasUnicode = 8589934592,
		HostUnicodeNormalized = 17179869184,
		RestUnicodeNormalized = 34359738368,
		UnicodeHost = 68719476736,
		IntranetUri = 137438953472,
		UseOrigUncdStrOffset = 274877906944,
		UserIriCanonical = 549755813888,
		PathIriCanonical = 1099511627776,
		QueryIriCanonical = 2199023255552,
		FragmentIriCanonical = 4398046511104,
		IriCanonical = 8246337208320,
		CompressedSlashes = 17592186044416,
	}

	[Token(Token = "0x20000C0")]
	private class MoreInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002A3")]
		public string Path; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002A4")]
		public string Query; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002A5")]
		public string Fragment; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002A6")]
		public string AbsoluteUri; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002A7")]
		public int Hash; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40002A8")]
		public string RemoteUrl; //Field offset: 0x38

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040F")]
		public MoreInfo() { }

	}

	[Token(Token = "0x20000BF")]
	private struct Offset
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029B")]
		public ushort Scheme; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400029C")]
		public ushort User; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400029D")]
		public ushort Host; //Field offset: 0x4
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x400029E")]
		public ushort PortValue; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400029F")]
		public ushort Path; //Field offset: 0x8
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x40002A0")]
		public ushort Query; //Field offset: 0xA
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40002A1")]
		public ushort Fragment; //Field offset: 0xC
		[FieldOffset(Offset = "0xE")]
		[Token(Token = "0x40002A2")]
		public ushort End; //Field offset: 0xE

	}

	[Token(Token = "0x20000BE")]
	private class UriInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000295")]
		public string Host; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000296")]
		public string ScopeId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000297")]
		public string String; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000298")]
		public Offset Offset; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000299")]
		public string DnsSafeHost; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400029A")]
		public MoreInfo MoreInfo; //Field offset: 0x40

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040E")]
		public UriInfo() { }

	}

	[Token(Token = "0x4000239")]
	public static readonly string UriSchemeFile; //Field offset: 0x0
	[Token(Token = "0x4000255")]
	private const UriKind DotNetRelativeOrAbsolute = 300; //Field offset: 0x0
	[Token(Token = "0x4000258")]
	private const UriFormat V1ToStringUnescape = 32767; //Field offset: 0x0
	[Token(Token = "0x4000259")]
	internal const char c_DummyChar = '\uFFFF'; //Field offset: 0x0
	[Token(Token = "0x400025A")]
	internal const char c_EOL = '\uFFFE'; //Field offset: 0x0
	[Token(Token = "0x4000248")]
	private const int c_MaxUriSchemeName = 1024; //Field offset: 0x0
	[Token(Token = "0x4000247")]
	internal const int c_MaxUriBufferSize = 65520; //Field offset: 0x0
	[Token(Token = "0x4000246")]
	private const int c_Max16BitUtf8SequenceLength = 12; //Field offset: 0x0
	[Token(Token = "0x400023A")]
	public static readonly string UriSchemeFtp; //Field offset: 0x8
	[Token(Token = "0x400023B")]
	public static readonly string UriSchemeGopher; //Field offset: 0x10
	[Token(Token = "0x400023C")]
	public static readonly string UriSchemeHttp; //Field offset: 0x18
	[Token(Token = "0x400023D")]
	public static readonly string UriSchemeHttps; //Field offset: 0x20
	[Token(Token = "0x400023E")]
	internal static readonly string UriSchemeWs; //Field offset: 0x28
	[Token(Token = "0x400023F")]
	internal static readonly string UriSchemeWss; //Field offset: 0x30
	[Token(Token = "0x4000240")]
	public static readonly string UriSchemeMailto; //Field offset: 0x38
	[Token(Token = "0x4000241")]
	public static readonly string UriSchemeNews; //Field offset: 0x40
	[Token(Token = "0x4000242")]
	public static readonly string UriSchemeNntp; //Field offset: 0x48
	[Token(Token = "0x4000243")]
	public static readonly string UriSchemeNetTcp; //Field offset: 0x50
	[Token(Token = "0x4000244")]
	public static readonly string UriSchemeNetPipe; //Field offset: 0x58
	[Token(Token = "0x4000245")]
	public static readonly string SchemeDelimiter; //Field offset: 0x60
	[Token(Token = "0x4000250")]
	private static bool s_ConfigInitialized; //Field offset: 0x68
	[Token(Token = "0x4000251")]
	private static bool s_ConfigInitializing; //Field offset: 0x69
	[Token(Token = "0x4000252")]
	private static UriIdnScope s_IdnScope; //Field offset: 0x6C
	[Token(Token = "0x4000253")]
	private static bool s_IriParsing; //Field offset: 0x70
	[Token(Token = "0x4000254")]
	private static bool useDotNetRelativeOrAbsolute; //Field offset: 0x71
	[Token(Token = "0x4000256")]
	internal static readonly bool IsWindowsFileSystem; //Field offset: 0x72
	[Token(Token = "0x4000257")]
	private static object s_initLock; //Field offset: 0x78
	[Token(Token = "0x400025B")]
	internal static readonly Char[] HexLowerChars; //Field offset: 0x80
	[Token(Token = "0x400025C")]
	private static readonly Char[] _WSchars; //Field offset: 0x88
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000249")]
	private string m_String; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024A")]
	private string m_originalUnicodeString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024B")]
	private UriParser m_Syntax; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024C")]
	private string m_DnsSafeHost; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024D")]
	private Flags m_Flags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400024E")]
	private UriInfo m_Info; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400024F")]
	private bool m_iriParsing; //Field offset: 0x40

	[Token(Token = "0x1700009D")]
	public string AbsolutePath
	{
		[Address(RVA = "0x16FB4A0", Offset = "0x16FA6A0", Length = "0xC2")]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool), typeof(int), typeof(CookieCollection), typeof(System.Collections.Generic.List`1<System.String>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003AF")]
		 get { } //Length: 194
	}

	[Token(Token = "0x1700009F")]
	public string AbsoluteUri
	{
		[Address(RVA = "0x16FB570", Offset = "0x16FA770", Length = "0x146")]
		[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
		[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B1")]
		 get { } //Length: 326
	}

	[Token(Token = "0x1700009A")]
	private bool AllowIdn
	{
		[Address(RVA = "0x16FB6C0", Offset = "0x16FA8C0", Length = "0xE5")]
		[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimalIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x6000398")]
		private get { } //Length: 229
	}

	[Token(Token = "0x170000A1")]
	public string Authority
	{
		[Address(RVA = "0x16FB7B0", Offset = "0x16FA9B0", Length = "0x8B")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003B3")]
		 get { } //Length: 139
	}

	[Token(Token = "0x170000B1")]
	public string DnsSafeHost
	{
		[Address(RVA = "0x16FB840", Offset = "0x16FAA40", Length = "0x2F7")]
		[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003C6")]
		 get { } //Length: 759
	}

	[Token(Token = "0x170000AD")]
	public string Fragment
	{
		[Address(RVA = "0x16FBB40", Offset = "0x16FAD40", Length = "0x146")]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003C2")]
		 get { } //Length: 326
	}

	[Token(Token = "0x170000B5")]
	internal bool HasAuthority
	{
		[Address(RVA = "0x16FBC90", Offset = "0x16FAE90", Length = "0xD")]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003F1")]
		internal get { } //Length: 13
	}

	[Token(Token = "0x170000A9")]
	public string Host
	{
		[Address(RVA = "0x16FBE00", Offset = "0x16FB000", Length = "0x8B")]
		[CallerCount(Count = 33)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003BB")]
		 get { } //Length: 139
	}

	[Token(Token = "0x170000A2")]
	public UriHostNameType HostNameType
	{
		[Address(RVA = "0x16FBCA0", Offset = "0x16FAEA0", Length = "0x14C")]
		[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003B4")]
		 get { } //Length: 332
	}

	[Token(Token = "0x17000097")]
	private Flags HostType
	{
		[Address(RVA = "0x16FBDF0", Offset = "0x16FAFF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000394")]
		private get { } //Length: 9
	}

	[Token(Token = "0x170000AA")]
	private static object InitializeLock
	{
		[Address(RVA = "0x16FBE90", Offset = "0x16FB090", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003BD")]
		private get { } //Length: 234
	}

	[Token(Token = "0x170000B2")]
	public bool IsAbsoluteUri
	{
		[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C7")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170000A3")]
	public bool IsDefaultPort
	{
		[Address(RVA = "0x16FBF80", Offset = "0x16FB180", Length = "0xF8")]
		[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003B5")]
		 get { } //Length: 248
	}

	[Token(Token = "0x17000095")]
	private bool IsDosPath
	{
		[Address(RVA = "0x16FC080", Offset = "0x16FB280", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000392")]
		private get { } //Length: 13
	}

	[Token(Token = "0x170000A4")]
	public bool IsFile
	{
		[Address(RVA = "0x16FC090", Offset = "0x16FB290", Length = "0xC5")]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B6")]
		 get { } //Length: 197
	}

	[Token(Token = "0x17000093")]
	private bool IsImplicitFile
	{
		[Address(RVA = "0x16FC160", Offset = "0x16FB360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000390")]
		private get { } //Length: 13
	}

	[Token(Token = "0x170000A5")]
	public bool IsLoopback
	{
		[Address(RVA = "0x16FC170", Offset = "0x16FB370", Length = "0xBA")]
		[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B7")]
		 get { } //Length: 186
	}

	[Token(Token = "0x17000099")]
	private bool IsNotAbsoluteUri
	{
		[Address(RVA = "0x9E74F0", Offset = "0x9E66F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000396")]
		private get { } //Length: 9
	}

	[Token(Token = "0x170000A8")]
	public bool IsUnc
	{
		[Address(RVA = "0x16FC250", Offset = "0x16FB450", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003BA")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000094")]
	private bool IsUncOrDosPath
	{
		[Address(RVA = "0x16FC230", Offset = "0x16FB430", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000391")]
		private get { } //Length: 13
	}

	[Token(Token = "0x17000096")]
	private bool IsUncPath
	{
		[Address(RVA = "0x16FC240", Offset = "0x16FB440", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000393")]
		private get { } //Length: 13
	}

	[Token(Token = "0x170000A0")]
	public string LocalPath
	{
		[Address(RVA = "0x16FC2E0", Offset = "0x16FB4E0", Length = "0x7F")]
		[CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileWebRequest), typeof(Uri), typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.XmlDownloadManager+<>c__DisplayClass4_0", Member = "<GetStreamAsync>b__0", ReturnType = typeof(Stream))]
		[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
		[CalledBy(Type = "GLTFast.GltfImportBase+<LoadFromUri>d__98", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.UriHelper", Member = "IsGltfBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = "System.Nullable`1<Boolean>")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003B2")]
		 get { } //Length: 127
	}

	[Token(Token = "0x170000B0")]
	public string OriginalString
	{
		[Address(RVA = "0x16FC3C0", Offset = "0x16FB5C0", Length = "0x5E")]
		[CallerCount(Count = 31)]
		[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		[Token(Token = "0x60003C5")]
		 get { } //Length: 94
	}

	[Token(Token = "0x170000AF")]
	private bool OriginalStringSwitched
	{
		[Address(RVA = "0x16FC360", Offset = "0x16FB560", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003C4")]
		private get { } //Length: 95
	}

	[Token(Token = "0x170000A6")]
	public string PathAndQuery
	{
		[Address(RVA = "0x16FC420", Offset = "0x16FB620", Length = "0xCE")]
		[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "TryGetHostUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003B8")]
		 get { } //Length: 206
	}

	[Token(Token = "0x170000AB")]
	public int Port
	{
		[Address(RVA = "0x16FC4F0", Offset = "0x16FB6F0", Length = "0x108")]
		[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(CookieCollection))]
		[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C0")]
		 get { } //Length: 264
	}

	[Token(Token = "0x1700009E")]
	private string PrivateAbsolutePath
	{
		[Address(RVA = "0x16FC600", Offset = "0x16FB800", Length = "0xE0")]
		[CalledBy(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "get_Segments", ReturnType = typeof(String[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003B0")]
		private get { } //Length: 224
	}

	[Token(Token = "0x170000AC")]
	public string Query
	{
		[Address(RVA = "0x16FC6F0", Offset = "0x16FB8F0", Length = "0x146")]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003C1")]
		 get { } //Length: 326
	}

	[Token(Token = "0x170000AE")]
	public string Scheme
	{
		[Address(RVA = "0x16FC840", Offset = "0x16FBA40", Length = "0x81")]
		[CallerCount(Count = 44)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C3")]
		 get { } //Length: 129
	}

	[Token(Token = "0x1700009C")]
	private ushort SecuredPathIndex
	{
		[Address(RVA = "0x16FC8D0", Offset = "0x16FBAD0", Length = "0x54")]
		[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600039D")]
		private get { } //Length: 84
	}

	[Token(Token = "0x170000A7")]
	public String[] Segments
	{
		[Address(RVA = "0x16FC930", Offset = "0x16FBB30", Length = "0x1FA")]
		[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60003B9")]
		 get { } //Length: 506
	}

	[Token(Token = "0x17000098")]
	private UriParser Syntax
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000395")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700009B")]
	internal bool UserDrivenParsing
	{
		[Address(RVA = "0x16FCB30", Offset = "0x16FBD30", Length = "0xD")]
		[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600039B")]
		internal get { } //Length: 13
	}

	[Token(Token = "0x170000B3")]
	public bool UserEscaped
	{
		[Address(RVA = "0x16FCB40", Offset = "0x16FBD40", Length = "0xD")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60003C8")]
		 get { } //Length: 13
	}

	[Token(Token = "0x170000B4")]
	public string UserInfo
	{
		[Address(RVA = "0x16FCB50", Offset = "0x16FBD50", Length = "0x8B")]
		[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C9")]
		 get { } //Length: 139
	}

	[Address(RVA = "0x16FA6F0", Offset = "0x16F98F0", Length = "0x5CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600040D")]
	private static Uri() { }

	[Address(RVA = "0x16FB250", Offset = "0x16FA450", Length = "0x24F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003AC")]
	protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x16FB160", Offset = "0x16FA360", Length = "0xE6")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetBaseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003A7")]
	public Uri(Uri baseUri, string relativeUri) { }

	[Address(RVA = "0x16FACC0", Offset = "0x16F9EC0", Length = "0x96")]
	[CalledBy(Type = "System.Net.Http.HttpRequestMessage", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpMethod", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<Load>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetBaseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = "GetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Threading.Tasks.Task`1<HttpResponseMessage>")]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003A6")]
	public Uri(string uriString, UriKind uriKind) { }

	[Address(RVA = "0x16FAFD0", Offset = "0x16FA1D0", Length = "0x123")]
	[CalledBy(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(WebProxy), Member = "ProxyUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
	[CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003A5")]
	public Uri(string uriString) { }

	[Address(RVA = "0x16FAD60", Offset = "0x16F9F60", Length = "0x266")]
	[CalledBy(Type = "System.Net.Http.HttpClient", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage", "System.Net.Http.HttpCompletionOption", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<HttpResponseMessage>")]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A9")]
	public Uri(Uri baseUri, Uri relativeUri) { }

	[Address(RVA = "0x16FB100", Offset = "0x16FA300", Length = "0x5F")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000405")]
	private Uri(Flags flags, UriParser uriParser, string uri) { }

	[Address(RVA = "0x16EC4B0", Offset = "0x16EB6B0", Length = "0xF1")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000399")]
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	[Address(RVA = "0x16EC5B0", Offset = "0x16EB7B0", Length = "0xA3")]
	[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003EF")]
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	[Address(RVA = "0x16ECEB0", Offset = "0x16EC0B0", Length = "0x1020")]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UncNameHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(string), typeof(Flags&), typeof(Boolean&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IsValidByIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Int32&), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser), typeof(Flags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Int32&), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(bool), typeof(bool), typeof(UriParser), typeof(Flags&), typeof(String&), typeof(ParsingError&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E6")]
	private ushort CheckAuthorityHelper(Char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost) { }

	[Address(RVA = "0x16EC660", Offset = "0x16EB860", Length = "0x2F8")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser), typeof(Flags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003E8")]
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err) { }

	[Address(RVA = "0x16EC960", Offset = "0x16EBB60", Length = "0x542")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriParser), typeof(Flags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E7")]
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	[Address(RVA = "0x16EDEE0", Offset = "0x16ED0E0", Length = "0x3E8")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003EB")]
	private Check CheckCanonical(Char* str, ref ushort idx, ushort end, char delim) { }

	[Address(RVA = "0x16EE2D0", Offset = "0x16ED4D0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003D3")]
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	[Address(RVA = "0x16EE380", Offset = "0x16ED580", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F9")]
	private bool CheckForConfigLoad(string data) { }

	[Address(RVA = "0x16EE440", Offset = "0x16ED640", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FB")]
	private bool CheckForEscapedUnreserved(string data) { }

	[Address(RVA = "0x16EE5E0", Offset = "0x16ED7E0", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003FA")]
	private bool CheckForUnicode(string data) { }

	[Address(RVA = "0x16EE730", Offset = "0x16ED930", Length = "0x520")]
	[CalledBy(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60003E4")]
	private static bool CheckKnownSchemes(Int64* lptr, ushort nChars, ref UriParser syntax) { }

	[Address(RVA = "0x16EEC50", Offset = "0x16EDE50", Length = "0x16F")]
	[CalledBy(Type = typeof(UriBuilder), Member = "set_Scheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60003CB")]
	public static bool CheckSchemeName(string schemeName) { }

	[Address(RVA = "0x16EEDC0", Offset = "0x16EDFC0", Length = "0x11B")]
	[CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriParser), Member = "FindOrFetchAsUnknownV1Syntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UriParser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E5")]
	private static ParsingError CheckSchemeSyntax(Char* ptr, ushort length, ref UriParser syntax) { }

	[Address(RVA = "0x16EEEE0", Offset = "0x16EE0E0", Length = "0x9E4")]
	[CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(ParsingError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003F0")]
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	[Address(RVA = "0x16EF8D0", Offset = "0x16EEAD0", Length = "0x4BE")]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003EE")]
	private static Char[] Compress(Char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	[Address(RVA = "0x16EFD90", Offset = "0x16EEF90", Length = "0x2DC")]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(UriParser), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000406")]
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	[Address(RVA = "0x16F0270", Offset = "0x16EF470", Length = "0x463")]
	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(Check))]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003DA")]
	private void CreateHostString() { }

	[Address(RVA = "0x16F0070", Offset = "0x16EF270", Length = "0x1FF")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DomainNameHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IPv4AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UncNameHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[Token(Token = "0x60003DB")]
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId) { }

	[Address(RVA = "0x16F0890", Offset = "0x16EFA90", Length = "0x1D0")]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x60003F7")]
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	[Address(RVA = "0x16F06E0", Offset = "0x16EF8E0", Length = "0x1A3")]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040C")]
	private void CreateThisFromUri(Uri otherUri) { }

	[Address(RVA = "0x16F1010", Offset = "0x16F0210", Length = "0x329")]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003A8")]
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	[Address(RVA = "0x16F0A70", Offset = "0x16EFC70", Length = "0x59F")]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[CalledBy(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "EnsureUriInfo", ReturnType = typeof(UriInfo))]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003D9")]
	private void CreateUriInfo(Flags cF) { }

	[Address(RVA = "0x16F1340", Offset = "0x16F0540", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A4")]
	private void EnsureHostString(bool allowDnsOptimization) { }

	[Address(RVA = "0x16F13B0", Offset = "0x16F05B0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A3")]
	private void EnsureParseRemaining() { }

	[Address(RVA = "0x16F13D0", Offset = "0x16F05D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A2")]
	private UriInfo EnsureUriInfo() { }

	[Address(RVA = "0x16F1410", Offset = "0x16F0610", Length = "0x743")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003D2")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x16F1B60", Offset = "0x16F0D60", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000404")]
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	[Address(RVA = "0x16F1C60", Offset = "0x16F0E60", Length = "0xAF")]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60003E9")]
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	[Address(RVA = "0x16F1BC0", Offset = "0x16F0DC0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60003EA")]
	private void FindEndOfComponent(Char* str, ref ushort idx, ushort end, char delim) { }

	[Address(RVA = "0x16F1D10", Offset = "0x16F0F10", Length = "0x9D")]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(UInt16*), typeof(int), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpEncoder), Member = "HtmlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CD")]
	public static int FromHex(char digit) { }

	[Address(RVA = "0x16FB4A0", Offset = "0x16FA6A0", Length = "0xC2")]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool), typeof(int), typeof(CookieCollection), typeof(System.Collections.Generic.List`1<System.String>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003AF")]
	public string get_AbsolutePath() { }

	[Address(RVA = "0x16FB570", Offset = "0x16FA770", Length = "0x146")]
	[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "RedirectTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003B1")]
	public string get_AbsoluteUri() { }

	[Address(RVA = "0x16FB6C0", Offset = "0x16FA8C0", Length = "0xE5")]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimalIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000398")]
	private bool get_AllowIdn() { }

	[Address(RVA = "0x16FB7B0", Offset = "0x16FA9B0", Length = "0x8B")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B3")]
	public string get_Authority() { }

	[Address(RVA = "0x16FB840", Offset = "0x16FAA40", Length = "0x2F7")]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C6")]
	public string get_DnsSafeHost() { }

	[Address(RVA = "0x16FBB40", Offset = "0x16FAD40", Length = "0x146")]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C2")]
	public string get_Fragment() { }

	[Address(RVA = "0x16FBC90", Offset = "0x16FAE90", Length = "0xD")]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F1")]
	internal bool get_HasAuthority() { }

	[Address(RVA = "0x16FBE00", Offset = "0x16FB000", Length = "0x8B")]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003BB")]
	public string get_Host() { }

	[Address(RVA = "0x16FBCA0", Offset = "0x16FAEA0", Length = "0x14C")]
	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B4")]
	public UriHostNameType get_HostNameType() { }

	[Address(RVA = "0x16FBDF0", Offset = "0x16FAFF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000394")]
	private Flags get_HostType() { }

	[Address(RVA = "0x16FBE90", Offset = "0x16FB090", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003BD")]
	private static object get_InitializeLock() { }

	[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C7")]
	public bool get_IsAbsoluteUri() { }

	[Address(RVA = "0x16FBF80", Offset = "0x16FB180", Length = "0xF8")]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B5")]
	public bool get_IsDefaultPort() { }

	[Address(RVA = "0x16FC080", Offset = "0x16FB280", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000392")]
	private bool get_IsDosPath() { }

	[Address(RVA = "0x16FC090", Offset = "0x16FB290", Length = "0xC5")]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003B6")]
	public bool get_IsFile() { }

	[Address(RVA = "0x16FC160", Offset = "0x16FB360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000390")]
	private bool get_IsImplicitFile() { }

	[Address(RVA = "0x16FC170", Offset = "0x16FB370", Length = "0xBA")]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003B7")]
	public bool get_IsLoopback() { }

	[Address(RVA = "0x9E74F0", Offset = "0x9E66F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000396")]
	private bool get_IsNotAbsoluteUri() { }

	[Address(RVA = "0x16FC250", Offset = "0x16FB450", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003BA")]
	public bool get_IsUnc() { }

	[Address(RVA = "0x16FC230", Offset = "0x16FB430", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000391")]
	private bool get_IsUncOrDosPath() { }

	[Address(RVA = "0x16FC240", Offset = "0x16FB440", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000393")]
	private bool get_IsUncPath() { }

	[Address(RVA = "0x16FC2E0", Offset = "0x16FB4E0", Length = "0x7F")]
	[CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileWebRequest), typeof(Uri), typeof(FileAccess), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlDownloadManager+<>c__DisplayClass4_0", Member = "<GetStreamAsync>b__0", ReturnType = typeof(Stream))]
	[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadFromUri>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "IsGltfBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = "System.Nullable`1<Boolean>")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B2")]
	public string get_LocalPath() { }

	[Address(RVA = "0x16FC3C0", Offset = "0x16FB5C0", Length = "0x5E")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Token(Token = "0x60003C5")]
	public string get_OriginalString() { }

	[Address(RVA = "0x16FC360", Offset = "0x16FB560", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C4")]
	private bool get_OriginalStringSwitched() { }

	[Address(RVA = "0x16FC420", Offset = "0x16FB620", Length = "0xCE")]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "TryGetHostUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003B8")]
	public string get_PathAndQuery() { }

	[Address(RVA = "0x16FC4F0", Offset = "0x16FB6F0", Length = "0x108")]
	[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(CookieCollection))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientHandshake", Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003C0")]
	public int get_Port() { }

	[Address(RVA = "0x16FC600", Offset = "0x16FB800", Length = "0xE0")]
	[CalledBy(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "get_Segments", ReturnType = typeof(String[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003B0")]
	private string get_PrivateAbsolutePath() { }

	[Address(RVA = "0x16FC6F0", Offset = "0x16FB8F0", Length = "0x146")]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C1")]
	public string get_Query() { }

	[Address(RVA = "0x16FC840", Offset = "0x16FBA40", Length = "0x81")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003C3")]
	public string get_Scheme() { }

	[Address(RVA = "0x16FC8D0", Offset = "0x16FBAD0", Length = "0x54")]
	[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600039D")]
	private ushort get_SecuredPathIndex() { }

	[Address(RVA = "0x16FC930", Offset = "0x16FBB30", Length = "0x1FA")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60003B9")]
	public String[] get_Segments() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000395")]
	private UriParser get_Syntax() { }

	[Address(RVA = "0x16FCB30", Offset = "0x16FBD30", Length = "0xD")]
	[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600039B")]
	internal bool get_UserDrivenParsing() { }

	[Address(RVA = "0x16FCB40", Offset = "0x16FBD40", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003C8")]
	public bool get_UserEscaped() { }

	[Address(RVA = "0x16FCB50", Offset = "0x16FBD50", Length = "0x8B")]
	[CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003C9")]
	public string get_UserInfo() { }

	[Address(RVA = "0x16F1DB0", Offset = "0x16F0FB0", Length = "0x7B2")]
	[CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Uri), Member = "UnescapeOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003EC")]
	private Char[] GetCanonicalPath(Char[] dest, ref int pos, UriFormat formatAs) { }

	[Address(RVA = "0x16F2570", Offset = "0x16F1770", Length = "0x209")]
	[CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003AA")]
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	[Address(RVA = "0x16F2A90", Offset = "0x16F1C90", Length = "0x1F5")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InternalGetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetRelativeSerializationString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003FF")]
	public string GetComponents(UriComponents components, UriFormat format) { }

	[Address(RVA = "0x16F2780", Offset = "0x16F1980", Length = "0x30F")]
	[CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000409")]
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	[Address(RVA = "0x16F2C90", Offset = "0x16F1E90", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003DE")]
	private string GetEscapedParts(UriComponents uriParts) { }

	[Address(RVA = "0x16F2D80", Offset = "0x16F1F80", Length = "0x170")]
	[CalledBy(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003AB")]
	private static UriFormatException GetException(ParsingError err) { }

	[Address(RVA = "0x16F2F30", Offset = "0x16F2130", Length = "0x1AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CalculateCaseInsensitiveHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16F30E0", Offset = "0x16F22E0", Length = "0x4AA")]
	[CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(ushort), typeof(Flags&), typeof(String&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriParser), Member = "InternalGetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003DC")]
	private void GetHostViaCustomSyntax() { }

	[Address(RVA = "0x16F3590", Offset = "0x16F2790", Length = "0x85A")]
	[CalledBy(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(ushort), typeof(Int32&), typeof(UriParser)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003BF")]
	private string GetLocalPath() { }

	[Address(RVA = "0x16F3DF0", Offset = "0x16F2FF0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AE")]
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x16F3ED0", Offset = "0x16F30D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Token(Token = "0x60003DD")]
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	[Address(RVA = "0x16F3EE0", Offset = "0x16F30E0", Length = "0x3BB")]
	[CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Token(Token = "0x6000408")]
	private string GetRelativeSerializationString(UriFormat format) { }

	[Address(RVA = "0x16F42A0", Offset = "0x16F34A0", Length = "0xCB")]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(ushort), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003DF")]
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	[Address(RVA = "0x16F4370", Offset = "0x16F3570", Length = "0x8D6")]
	[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E1")]
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	[Address(RVA = "0x16F4C50", Offset = "0x16F3E50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600039F")]
	private bool InFact(Flags flags) { }

	[Address(RVA = "0x16F4EC0", Offset = "0x16F40C0", Length = "0xB22")]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InternalOnNewUri", ReturnType = typeof(UriParser))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(UriParser), Member = "InternalValidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F8")]
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	[Address(RVA = "0x16F4C60", Offset = "0x16F3E60", Length = "0x254")]
	[CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003BE")]
	private static void InitializeUriConfig() { }

	[Address(RVA = "0x16F59F0", Offset = "0x16F4BF0", Length = "0xDB")]
	[CalledBy(Type = typeof(UriBuilder), Member = "set_Path", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x60003D4")]
	internal static string InternalEscapeString(string rawString) { }

	[Address(RVA = "0x16F5AD0", Offset = "0x16F4CD0", Length = "0x54B")]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriParser), Member = "IsWellFormedOriginalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(Check))]
	[Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000402")]
	internal bool InternalIsWellFormedOriginalString() { }

	[Address(RVA = "0x16F6020", Offset = "0x16F5220", Length = "0xA0")]
	[CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000397")]
	internal static bool IriParsingStatic(UriParser syntax) { }

	[Address(RVA = "0x16F6140", Offset = "0x16F5340", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F3")]
	private static bool IsAsciiLetter(char character) { }

	[Address(RVA = "0x16F60C0", Offset = "0x16F52C0", Length = "0x72")]
	[CalledBy(Type = typeof(UriHelper), Member = "IsUnreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F4")]
	internal static bool IsAsciiLetterOrDigit(char character) { }

	[Address(RVA = "0x16F63C0", Offset = "0x16F55C0", Length = "0xC3")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UriParser), Member = "InternalIsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600040A")]
	public bool IsBaseOf(Uri uri) { }

	[Address(RVA = "0x16F6160", Offset = "0x16F5360", Length = "0x25C")]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriParser), Member = "IsBaseOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UriHelper), Member = "TestForSubPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(Char*), typeof(ushort), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600040B")]
	internal bool IsBaseOfHelper(Uri uriLink) { }

	[Address(RVA = "0x16F6490", Offset = "0x16F5690", Length = "0x31")]
	[CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char[]), typeof(Int32&), typeof(Char[]), typeof(int), typeof(Byte[]), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F5")]
	internal static bool IsBidiControlCharacter(char ch) { }

	[Address(RVA = "0x16F64D0", Offset = "0x16F56D0", Length = "0x24")]
	[CalledBy(Type = typeof(IriHelper), Member = "CheckIsReserved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UriComponents)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CA")]
	internal static bool IsGenDelim(char ch) { }

	[Address(RVA = "0x16F6500", Offset = "0x16F5700", Length = "0x26")]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Int32&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpEncoder), Member = "HtmlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CC")]
	public static bool IsHexDigit(char character) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600039A")]
	private bool IsIntranet(string schemeHost) { }

	[Address(RVA = "0x16F6530", Offset = "0x16F5730", Length = "0x24")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003F2")]
	private static bool IsLWS(char ch) { }

	[Address(RVA = "0x16F6560", Offset = "0x16F5760", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000400")]
	public bool IsWellFormedOriginalString() { }

	[Address(RVA = "0x16F65B0", Offset = "0x16F57B0", Length = "0x16B")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextEventHandler", Member = "HyperlinkOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextEventHandler", Member = "ATagOnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerUpEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000401")]
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	[Address(RVA = "0x16F6720", Offset = "0x16F5920", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600039E")]
	private bool NotAny(Flags flags) { }

	[Address(RVA = "0x16FCBE0", Offset = "0x16FBDE0", Length = "0x32")]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60003D0")]
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	[Address(RVA = "0x16FCC20", Offset = "0x16FBE20", Length = "0x1AE")]
	[CalledBy(Type = "System.Xml.DtdParser", Member = "InitializeFreeFloatingDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), "System.Xml.IDtdParserAdapter"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpRequestMessage", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.HttpRequestMessage", Member = "set_RequestUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "System.Xml.DtdParser", Member = "get_BaseUriStr", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.DtdParser", Member = "ParseExternalSubset", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.DtdParser", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.IDtdParserAdapter"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "OpenUrl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SPKey), Member = "get_UsesProxy", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(WebProxy), Member = "GetProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITypeDescriptorContext), typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SPKey), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003D1")]
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	[Address(RVA = "0x16F6730", Offset = "0x16F5930", Length = "0x76")]
	[CalledBy(Type = typeof(UriParser), Member = "InitializeAndValidate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Token(Token = "0x60003D6")]
	internal UriFormatException ParseMinimal() { }

	[Address(RVA = "0x16F67B0", Offset = "0x16F59B0", Length = "0xD77")]
	[CalledBy(Type = typeof(Uri), Member = "EnsureParseRemaining", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NormalizationForm)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(Check))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(UriComponents)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt16&), typeof(ushort), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E2")]
	private void ParseRemaining() { }

	[Address(RVA = "0x16F79F0", Offset = "0x16F6BF0", Length = "0xE4")]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003D5")]
	private static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax) { }

	[Address(RVA = "0x16F7530", Offset = "0x16F6730", Length = "0x4B8")]
	[CalledBy(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags&), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CheckKnownSchemes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(UriParser&)}, ReturnType = typeof(ParsingError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E3")]
	private static ushort ParseSchemeCheckImplicitFile(Char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax) { }

	[Address(RVA = "0x16F7C00", Offset = "0x16F6E00", Length = "0x765")]
	[CalledBy(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
	[CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UriParser), Member = "IsAllSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(ushort), typeof(ushort), typeof(ParsingError&), typeof(Flags&), typeof(UriParser), typeof(String&)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003D7")]
	private ParsingError PrivateParseMinimal() { }

	[Address(RVA = "0x16F7AE0", Offset = "0x16F6CE0", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003D8")]
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	[Address(RVA = "0x16F8370", Offset = "0x16F7570", Length = "0x120C")]
	[CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(bool), typeof(char), typeof(char), typeof(char)}, ReturnType = typeof(Char[]))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003E0")]
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	[Address(RVA = "0x16F9580", Offset = "0x16F8780", Length = "0x53E")]
	[CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(UriFormatException&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(ParsingError))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParsingError)}, ReturnType = typeof(UriFormatException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000407")]
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	[Address(RVA = "0x16F9AC0", Offset = "0x16F8CC0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600039C")]
	private void SetUserDrivenParsing() { }

	[Address(RVA = "0x16F9AE0", Offset = "0x16F8CE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A1")]
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	[Address(RVA = "0x16F9AF0", Offset = "0x16F8CF0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriSyntaxFlags)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003BC")]
	private static bool StaticIsFile(UriParser syntax) { }

	[Address(RVA = "0x16F9B10", Offset = "0x16F8D10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003A0")]
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	[Address(RVA = "0x16F9B20", Offset = "0x16F8D20", Length = "0x172")]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F6")]
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	[Address(RVA = "0x16F3DF0", Offset = "0x16F2FF0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003AD")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x16F9CA0", Offset = "0x16F8EA0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UriComponents), typeof(UriFormat)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003CF")]
	public virtual string ToString() { }

	[Address(RVA = "0x16F9EA0", Offset = "0x16F90A0", Length = "0x2E1")]
	[CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FtpWebRequest)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003FD")]
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	[Address(RVA = "0x16FA190", Offset = "0x16F9390", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri), typeof(String&), typeof(Boolean&), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003FE")]
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	[Address(RVA = "0x16F9DC0", Offset = "0x16F8FC0", Length = "0xD8")]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "TryGetHostUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+Host", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+Uri", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(UriKind), typeof(UriFormatException&)}, ReturnType = typeof(Uri))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60003FC")]
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	[Address(RVA = "0x16FA340", Offset = "0x16F9540", Length = "0x1A3")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.UriHelper", Member = "GetUriString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri)}, ReturnType = typeof(Uri))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Char[]), typeof(Int32&), typeof(char), typeof(char), typeof(char), typeof(UnescapeMode), typeof(UriParser), typeof(bool)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000403")]
	public static string UnescapeDataString(string stringToUnescape) { }

	[Address(RVA = "0x16FA4F0", Offset = "0x16F96F0", Length = "0x1FC")]
	[CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(Int32&), typeof(UriFormat)}, ReturnType = typeof(Char[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(char))]
	[Token(Token = "0x60003ED")]
	private static void UnescapeOnly(Char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

}


namespace System.Net;

[Token(Token = "0x200025B")]
public sealed class Cookie
{
	[Token(Token = "0x40009A9")]
	internal static readonly Char[] PortSplitDelimiters; //Field offset: 0x0
	[Token(Token = "0x40009AA")]
	internal static readonly Char[] Reserved2Name; //Field offset: 0x8
	[Token(Token = "0x40009AB")]
	internal static readonly Char[] Reserved2Value; //Field offset: 0x10
	[Token(Token = "0x40009AC")]
	private static Comparer staticComparer; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009AD")]
	private string m_comment; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009AE")]
	private Uri m_commentUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009AF")]
	private CookieVariant m_cookieVariant; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009B0")]
	private bool m_discard; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009B1")]
	private string m_domain; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009B2")]
	private bool m_domain_implicit; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009B3")]
	private DateTime m_expires; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009B4")]
	private string m_name; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009B5")]
	private string m_path; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009B6")]
	private bool m_path_implicit; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009B7")]
	private string m_port; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40009B8")]
	private bool m_port_implicit; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40009B9")]
	private Int32[] m_port_list; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40009BA")]
	private bool m_secure; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[OptionalField]
	[Token(Token = "0x40009BB")]
	private bool m_httpOnly; //Field offset: 0x71
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40009BC")]
	private DateTime m_timeStamp; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40009BD")]
	private string m_value; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40009BE")]
	private int m_version; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40009BF")]
	private string m_domainKey; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40009C0")]
	internal bool IsQuotedVersion; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40009C1")]
	internal bool IsQuotedDomain; //Field offset: 0x99

	[Token(Token = "0x17000303")]
	private string _Domain
	{
		[Address(RVA = "0x17D24C0", Offset = "0x17D16C0", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFF")]
		private get { } //Length: 176
	}

	[Token(Token = "0x17000308")]
	private string _Path
	{
		[Address(RVA = "0x17D2580", Offset = "0x17D1780", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F06")]
		private get { } //Length: 115
	}

	[Token(Token = "0x1700030C")]
	private string _Port
	{
		[Address(RVA = "0x17D2600", Offset = "0x17D1800", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F0D")]
		private get { } //Length: 171
	}

	[Token(Token = "0x17000312")]
	private string _Version
	{
		[Address(RVA = "0x17D26B0", Offset = "0x17D18B0", Length = "0xEB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000F16")]
		private get { } //Length: 235
	}

	[Token(Token = "0x170002FE")]
	public string Comment
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 5
		[Address(RVA = "0x17D27A0", Offset = "0x17D19A0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000EF9")]
		 set { } //Length: 35
	}

	[Token(Token = "0x170002FF")]
	public Uri CommentUri
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EFA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000301")]
	public bool Discard
	{
		[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EFC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000302")]
	public string Domain
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EFD")]
		 get { } //Length: 5
		[Address(RVA = "0x17D27D0", Offset = "0x17D19D0", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFE")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000310")]
	internal string DomainKey
	{
		[Address(RVA = "0x17D23E0", Offset = "0x17D15E0", Length = "0x13")]
		[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x6000F13")]
		internal get { } //Length: 19
	}

	[Token(Token = "0x17000304")]
	public bool Expired
	{
		[Address(RVA = "0x17D2400", Offset = "0x17D1600", Length = "0xB3")]
		[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection), typeof(CookieCollection), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000F00")]
		 get { } //Length: 179
	}

	[Token(Token = "0x17000305")]
	public DateTime Expires
	{
		[Address(RVA = "0x5C0A50", Offset = "0x5BFC50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F01")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000300")]
	public bool HttpOnly
	{
		[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EFB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000306")]
	public string Name
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F02")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000307")]
	public string Path
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F04")]
		 get { } //Length: 5
		[Address(RVA = "0x17D2840", Offset = "0x17D1A40", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F05")]
		 set { } //Length: 64
	}

	[Token(Token = "0x17000309")]
	internal bool Plain
	{
		[Address(RVA = "0x1219510", Offset = "0x1218710", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F07")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700030A")]
	public string Port
	{
		[Address(RVA = "0x17D2890", Offset = "0x17D1A90", Length = "0x4AE")]
		[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
		[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6000F0B")]
		 set { } //Length: 1198
	}

	[Token(Token = "0x1700030B")]
	internal Int32[] PortList
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700030D")]
	public bool Secure
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0E")]
		 get { } //Length: 5
		[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700030E")]
	public string Value
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F10")]
		 get { } //Length: 8
		[Address(RVA = "0x17D2D40", Offset = "0x17D1F40", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F11")]
		 set { } //Length: 56
	}

	[Token(Token = "0x1700030F")]
	internal CookieVariant Variant
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F12")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000311")]
	public int Version
	{
		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F14")]
		 get { } //Length: 7
		[Address(RVA = "0x17D2D80", Offset = "0x17D1F80", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000F15")]
		 set { } //Length: 116
	}

	[Address(RVA = "0x17D20D0", Offset = "0x17D12D0", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F1B")]
	private static Cookie() { }

	[Address(RVA = "0x17D2280", Offset = "0x17D1480", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EF7")]
	public Cookie() { }

	[Address(RVA = "0x17D0700", Offset = "0x17CF900", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F0A")]
	private static bool DomainCharsTest(string name) { }

	[Address(RVA = "0x17D0790", Offset = "0x17CF990", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F18")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x17D24C0", Offset = "0x17D16C0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFF")]
	private string get__Domain() { }

	[Address(RVA = "0x17D2580", Offset = "0x17D1780", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F06")]
	private string get__Path() { }

	[Address(RVA = "0x17D2600", Offset = "0x17D1800", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F0D")]
	private string get__Port() { }

	[Address(RVA = "0x17D26B0", Offset = "0x17D18B0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000F16")]
	private string get__Version() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF8")]
	public string get_Comment() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EFD")]
	public string get_Domain() { }

	[Address(RVA = "0x17D23E0", Offset = "0x17D15E0", Length = "0x13")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6000F13")]
	internal string get_DomainKey() { }

	[Address(RVA = "0x17D2400", Offset = "0x17D1600", Length = "0xB3")]
	[CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cookie), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CookieContainer), Member = "ExpireCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CookieContainer), Member = "MergeUpdateCollections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection), typeof(CookieCollection), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000F00")]
	public bool get_Expired() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F02")]
	public string get_Name() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F04")]
	public string get_Path() { }

	[Address(RVA = "0x1219510", Offset = "0x1218710", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F07")]
	internal bool get_Plain() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0C")]
	internal Int32[] get_PortList() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0E")]
	public bool get_Secure() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F10")]
	public string get_Value() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F12")]
	internal CookieVariant get_Variant() { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F14")]
	public int get_Version() { }

	[Address(RVA = "0x17D08A0", Offset = "0x17CFAA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000F17")]
	internal static IComparer GetComparer() { }

	[Address(RVA = "0x17D08F0", Offset = "0x17CFAF0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F19")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x17D0AB0", Offset = "0x17CFCB0", Length = "0xED")]
	[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F03")]
	internal bool InternalSetName(string value) { }

	[Address(RVA = "0x17D0BA0", Offset = "0x17CFDA0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F08")]
	private static bool IsDomainEqualToHost(string domain, string host) { }

	[Address(RVA = "0x17D27A0", Offset = "0x17D19A0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000EF9")]
	public void set_Comment(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EFA")]
	public void set_CommentUri(Uri value) { }

	[Address(RVA = "0x387950", Offset = "0x386B50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EFC")]
	public void set_Discard(bool value) { }

	[Address(RVA = "0x17D27D0", Offset = "0x17D19D0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFE")]
	public void set_Domain(string value) { }

	[Address(RVA = "0x5C0A50", Offset = "0x5BFC50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F01")]
	public void set_Expires(DateTime value) { }

	[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EFB")]
	public void set_HttpOnly(bool value) { }

	[Address(RVA = "0x17D2840", Offset = "0x17D1A40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F05")]
	public void set_Path(string value) { }

	[Address(RVA = "0x17D2890", Offset = "0x17D1A90", Length = "0x4AE")]
	[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000F0B")]
	public void set_Port(string value) { }

	[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0F")]
	public void set_Secure(bool value) { }

	[Address(RVA = "0x17D2D40", Offset = "0x17D1F40", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F11")]
	public void set_Value(string value) { }

	[Address(RVA = "0x17D2D80", Offset = "0x17D1F80", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F15")]
	public void set_Version(int value) { }

	[Address(RVA = "0x17D0C00", Offset = "0x17CFE00", Length = "0x4C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F1A")]
	public virtual string ToString() { }

	[Address(RVA = "0x17D10D0", Offset = "0x17D02D0", Length = "0xFFF")]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CookieParser), Member = "CheckQuoted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F09")]
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

}


namespace System.Net;

[Token(Token = "0x2000281")]
internal class DigestSession
{
	[Token(Token = "0x4000A47")]
	private static RandomNumberGenerator rng; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A48")]
	private DateTime lastUse; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A49")]
	private int _nc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A4A")]
	private HashAlgorithm hash; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A4B")]
	private DigestHeaderParser parser; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A4C")]
	private string _cnonce; //Field offset: 0x30

	[Token(Token = "0x1700033F")]
	public string Algorithm
	{
		[Address(RVA = "0x17EF830", Offset = "0x17EEA30", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000FE9")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000344")]
	public string CNonce
	{
		[Address(RVA = "0x17EF870", Offset = "0x17EEA70", Length = "0xFB")]
		[CalledBy(Type = typeof(DigestSession), Member = "HA1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000FEE")]
		 get { } //Length: 251
	}

	[Token(Token = "0x17000345")]
	public DateTime LastUse
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FF5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000341")]
	public string Nonce
	{
		[Address(RVA = "0x17EF970", Offset = "0x17EEB70", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000FEB")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000342")]
	public string Opaque
	{
		[Address(RVA = "0x17EF9B0", Offset = "0x17EEBB0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000FEC")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000343")]
	public string QOP
	{
		[Address(RVA = "0x17EF9F0", Offset = "0x17EEBF0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000FED")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000340")]
	public string Realm
	{
		[Address(RVA = "0x17EFA30", Offset = "0x17EEC30", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000FEA")]
		 get { } //Length: 48
	}

	[Address(RVA = "0x17EF770", Offset = "0x17EE970", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000FE7")]
	private static DigestSession() { }

	[Address(RVA = "0x17EF7D0", Offset = "0x17EE9D0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FE8")]
	public DigestSession() { }

	[Address(RVA = "0x17EE8C0", Offset = "0x17EDAC0", Length = "0x5A0")]
	[CalledBy(Type = typeof(DigestClient), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CalledBy(Type = typeof(DigestClient), Member = "PreAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DigestSession), Member = "get_CNonce", ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FF4")]
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x17EF830", Offset = "0x17EEA30", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FE9")]
	public string get_Algorithm() { }

	[Address(RVA = "0x17EF870", Offset = "0x17EEA70", Length = "0xFB")]
	[CalledBy(Type = typeof(DigestSession), Member = "HA1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FEE")]
	public string get_CNonce() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FF5")]
	public DateTime get_LastUse() { }

	[Address(RVA = "0x17EF970", Offset = "0x17EEB70", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FEB")]
	public string get_Nonce() { }

	[Address(RVA = "0x17EF9B0", Offset = "0x17EEBB0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FEC")]
	public string get_Opaque() { }

	[Address(RVA = "0x17EF9F0", Offset = "0x17EEBF0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FED")]
	public string get_QOP() { }

	[Address(RVA = "0x17EFA30", Offset = "0x17EEC30", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FEA")]
	public string get_Realm() { }

	[Address(RVA = "0x17EEE70", Offset = "0x17EE070", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(DigestSession), Member = "HashToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DigestSession), Member = "get_CNonce", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000FF1")]
	private string HA1(string username, string password) { }

	[Address(RVA = "0x17EEFD0", Offset = "0x17EE1D0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000FF2")]
	private string HA2(HttpWebRequest webRequest) { }

	[Address(RVA = "0x17EF0D0", Offset = "0x17EE2D0", Length = "0x169")]
	[CalledBy(Type = typeof(DigestSession), Member = "HA1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DigestSession), Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(HttpWebRequest)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000FF0")]
	private string HashToHexString(string toBeHashed) { }

	[Address(RVA = "0x17EF240", Offset = "0x17EE440", Length = "0x1B6")]
	[CalledBy(Type = typeof(DigestClient), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(DigestHeaderParser), Member = "Parse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FEF")]
	public bool Parse(string challenge) { }

	[Address(RVA = "0x17EF400", Offset = "0x17EE600", Length = "0x36B")]
	[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DigestSession), Member = "get_CNonce", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(DigestSession), Member = "HashToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FF3")]
	private string Response(string username, string password, HttpWebRequest webRequest) { }

}


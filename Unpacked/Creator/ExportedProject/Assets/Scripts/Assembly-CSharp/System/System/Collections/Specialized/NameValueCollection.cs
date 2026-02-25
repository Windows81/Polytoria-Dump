namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001A4")]
public class NameValueCollection : NameObjectCollectionBase
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000679")]
	private String[] _all; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400067A")]
	private String[] _allKeys; //Field offset: 0x58

	[Token(Token = "0x170001DC")]
	public string Item
	{
		[Address(RVA = "0x17C7390", Offset = "0x17C6590", Length = "0x14")]
		[CalledBy(Type = typeof(WebHeaderCollection), Member = "GetAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameValueCollection), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "get_TransferEncoding", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A04")]
		 get { } //Length: 20
		[Address(RVA = "0x17C73B0", Offset = "0x17C65B0", Length = "0x14")]
		[CalledBy(Type = "System.Net.HttpWebRequest+AuthorizationState", Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000A05")]
		 set { } //Length: 20
	}

	[Address(RVA = "0x17C72B0", Offset = "0x17C64B0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009F9")]
	public NameValueCollection() { }

	[Address(RVA = "0x17C7240", Offset = "0x17C6440", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009FB")]
	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x17C7340", Offset = "0x17C6540", Length = "0x49")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "get_Headers", ReturnType = typeof(WebHeaderCollection))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebHeaderCollectionType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A09")]
	internal NameValueCollection(DBNull dummy) { }

	[Address(RVA = "0x17C71C0", Offset = "0x17C63C0", Length = "0x72")]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "get_InnerCollection", ReturnType = typeof(NameValueCollection))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEqualityComparer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009FA")]
	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x17C68C0", Offset = "0x17C5AC0", Length = "0x18B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009FF")]
	public override void Add(string name, string value) { }

	[Address(RVA = "0x17C6EE0", Offset = "0x17C60E0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(NameValueCollection), Member = "GetAsOneString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A00")]
	public override string Get(string name) { }

	[Address(RVA = "0x17C6E40", Offset = "0x17C6040", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NameValueCollection), Member = "GetAsOneString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A06")]
	public override string Get(int index) { }

	[Address(RVA = "0x17C7390", Offset = "0x17C6590", Length = "0x14")]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "GetAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameValueCollection), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "get_TransferEncoding", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode), typeof(WebResponse)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferOffsetSize)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A04")]
	public string get_Item(string name) { }

	[Address(RVA = "0x17C6A50", Offset = "0x17C5C50", Length = "0x1EB")]
	[CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NameValueCollection), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60009FD")]
	private static string GetAsOneString(ArrayList list) { }

	[Address(RVA = "0x17C6C40", Offset = "0x17C5E40", Length = "0xA9")]
	[CalledBy(Type = typeof(NameValueCollection), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(NameValueCollection), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60009FE")]
	private static String[] GetAsStringArray(ArrayList list) { }

	[Address(RVA = "0x17C6CF0", Offset = "0x17C5EF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000A08")]
	public override string GetKey(int index) { }

	[Address(RVA = "0x17C6DA0", Offset = "0x17C5FA0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NameValueCollection), Member = "GetAsStringArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A07")]
	public override String[] GetValues(int index) { }

	[Address(RVA = "0x17C6D00", Offset = "0x17C5F00", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(NameValueCollection), Member = "GetAsStringArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000A01")]
	public override String[] GetValues(string name) { }

	[Address(RVA = "0x17C6F80", Offset = "0x17C6180", Length = "0x34")]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60009FC")]
	protected void InvalidateCachedArrays() { }

	[Address(RVA = "0x17C6FC0", Offset = "0x17C61C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A03")]
	public override void Remove(string name) { }

	[Address(RVA = "0x17C7010", Offset = "0x17C6210", Length = "0x1A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameObjectEntry))]
	[Calls(Type = typeof(NameObjectCollectionBase), Member = "BaseAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A02")]
	public override void Set(string name, string value) { }

	[Address(RVA = "0x17C73B0", Offset = "0x17C65B0", Length = "0x14")]
	[CalledBy(Type = "System.Net.HttpWebRequest+AuthorizationState", Member = "CheckAuthorization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebResponse), typeof(HttpStatusCode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A05")]
	public void set_Item(string name, string value) { }

}


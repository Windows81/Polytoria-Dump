namespace System.Net;

[Token(Token = "0x2000290")]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AC4")]
	private Uri uri; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AC5")]
	private WebHeaderCollection webHeaders; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AC6")]
	private CookieCollection cookieCollection; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AC7")]
	private string method; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AC8")]
	private Version version; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AC9")]
	private HttpStatusCode statusCode; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000ACA")]
	private string statusDescription; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000ACB")]
	private long contentLength; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000ACC")]
	private string contentType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000ACD")]
	private CookieContainer cookie_container; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000ACE")]
	private bool disposed; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000ACF")]
	private Stream stream; //Field offset: 0x78

	[Token(Token = "0x17000375")]
	public virtual WebHeaderCollection Headers
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600108C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000376")]
	public virtual Uri ResponseUri
	{
		[Address(RVA = "0x17FA2C0", Offset = "0x17F94C0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[Token(Token = "0x600108D")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000377")]
	public override HttpStatusCode StatusCode
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x600108E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000378")]
	public override string StatusDescription
	{
		[Address(RVA = "0x17FA2E0", Offset = "0x17F94E0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[Token(Token = "0x600108F")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001088")]
	public HttpWebResponse() { }

	[Address(RVA = "0x17F9B20", Offset = "0x17F8D20", Length = "0xE8")]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001089")]
	internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	[Address(RVA = "0x17FA000", Offset = "0x17F9200", Length = "0x2B9")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpStatusCode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
	[Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(CompressionMode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600108A")]
	internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Address(RVA = "0x17F9C10", Offset = "0x17F8E10", Length = "0x3EE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Obsolete("Serialization is obsoleted for this type", False)]
	[Token(Token = "0x600108B")]
	protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F9680", Offset = "0x17F8880", Length = "0x81")]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "get_StatusDescription", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001096")]
	private void CheckDisposed() { }

	[Address(RVA = "0x17F9710", Offset = "0x17F8910", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001093")]
	public virtual void Close() { }

	[Address(RVA = "0x17F9750", Offset = "0x17F8950", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebResponse), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001095")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17F9760", Offset = "0x17F8960", Length = "0x185")]
	[CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(WebResponseStream), typeof(CookieContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001097")]
	private void FillCookies() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600108C")]
	public virtual WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x17FA2C0", Offset = "0x17F94C0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Token(Token = "0x600108D")]
	public virtual Uri get_ResponseUri() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x600108E")]
	public override HttpStatusCode get_StatusCode() { }

	[Address(RVA = "0x17FA2E0", Offset = "0x17F94E0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Token(Token = "0x600108F")]
	public override string get_StatusDescription() { }

	[Address(RVA = "0x17F98F0", Offset = "0x17F8AF0", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001092")]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17F9A60", Offset = "0x17F8C60", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001090")]
	public virtual Stream GetResponseStream() { }

	[Address(RVA = "0x17F9B00", Offset = "0x17F8D00", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001094")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x17E8170", Offset = "0x17E7370", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001091")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}


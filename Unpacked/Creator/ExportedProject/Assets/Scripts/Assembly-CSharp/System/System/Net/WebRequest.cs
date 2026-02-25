namespace System.Net;

[Token(Token = "0x2000243")]
public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	[CompilerGenerated]
	[Token(Token = "0x2000245")]
	private sealed class <>c__DisplayClass78_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400096B")]
		public WindowsIdentity currentUser; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400096C")]
		public WebRequest <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA1")]
		public <>c__DisplayClass78_0() { }

		[Address(RVA = "0x17E2CD0", Offset = "0x17E1ED0", Length = "0x22F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000EA2")]
		internal Task<Stream> <GetRequestStreamAsync>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000246")]
	private sealed class <>c__DisplayClass79_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400096D")]
		public WindowsIdentity currentUser; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400096E")]
		public WebRequest <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA3")]
		public <>c__DisplayClass79_0() { }

		[Address(RVA = "0x17E2F10", Offset = "0x17E2110", Length = "0x22F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000EA4")]
		internal Task<WebResponse> <GetResponseAsync>b__1() { }

	}

	[Token(Token = "0x2000244")]
	public class DesignerWebRequestCreate : IWebRequestCreate
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EA0")]
		public DesignerWebRequestCreate() { }

		[Address(RVA = "0x17D2EA0", Offset = "0x17D20A0", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E9F")]
		public override WebRequest Create(Uri uri) { }

	}

	[Token(Token = "0x4000960")]
	private static ArrayList s_PrefixList; //Field offset: 0x0
	[Token(Token = "0x4000961")]
	private static object s_InternalSyncObject; //Field offset: 0x8
	[Token(Token = "0x4000962")]
	private static Queue s_DefaultTimerQueue; //Field offset: 0x10
	[Token(Token = "0x4000968")]
	private static DesignerWebRequestCreate webRequestCreate; //Field offset: 0x18
	[Token(Token = "0x4000969")]
	private static IWebProxy s_DefaultWebProxy; //Field offset: 0x20
	[Token(Token = "0x400096A")]
	private static bool s_DefaultWebProxyInitialized; //Field offset: 0x28
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000963")]
	private AuthenticationLevel m_AuthenticationLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000964")]
	private TokenImpersonationLevel m_ImpersonationLevel; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000965")]
	private RequestCachePolicy m_CachePolicy; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000966")]
	private RequestCacheProtocol m_CacheProtocol; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000967")]
	private RequestCacheBinding m_CacheBinding; //Field offset: 0x30

	[Token(Token = "0x170002DC")]
	public override RequestCachePolicy CachePolicy
	{
		[Address(RVA = "0x17E71F0", Offset = "0x17E63F0", Length = "0xD8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RequestCacheValidator), Member = "CreateValidator", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(RequestCacheProtocol), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E7F")]
		 set { } //Length: 216
	}

	[Token(Token = "0x170002E7")]
	internal RequestCacheProtocol CacheProtocol
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E99")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E9A")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002DF")]
	public override string ConnectionGroupName
	{
		[Address(RVA = "0x17E7F50", Offset = "0x17E7150", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E84")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002E1")]
	public override long ContentLength
	{
		[Address(RVA = "0x17E78E0", Offset = "0x17E6AE0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E86")]
		 get { } //Length: 39
		[Address(RVA = "0x17E7F80", Offset = "0x17E7180", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E87")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002E2")]
	public override ICredentials Credentials
	{
		[Address(RVA = "0x17E7910", Offset = "0x17E6B10", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E88")]
		 get { } //Length: 39
		[Address(RVA = "0x17E7FB0", Offset = "0x17E71B0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E89")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002DB")]
	public static RequestCachePolicy DefaultCachePolicy
	{
		[Address(RVA = "0x17E7940", Offset = "0x17E6B40", Length = "0x66")]
		[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "CreateDefaultHandler", ReturnType = "System.Net.Http.IMonoHttpClientHandler")]
		[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RequestCacheBinding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000E7E")]
		 get { } //Length: 102
	}

	[Token(Token = "0x170002E0")]
	public override WebHeaderCollection Headers
	{
		[Address(RVA = "0x17E79B0", Offset = "0x17E6BB0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E85")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170002E8")]
	internal static IWebProxy InternalDefaultWebProxy
	{
		[Address(RVA = "0x17E79E0", Offset = "0x17E6BE0", Length = "0x1DF")]
		[CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultProxySectionInternal), Member = "GetSection", ReturnType = typeof(DefaultProxySectionInternal))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000E9B")]
		internal get { } //Length: 479
	}

	[Token(Token = "0x170002D9")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x17E7BC0", Offset = "0x17E6DC0", Length = "0xEA")]
		[CalledBy(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
		[CalledBy(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E74")]
		private get { } //Length: 234
	}

	[Token(Token = "0x170002DD")]
	public override string Method
	{
		[Address(RVA = "0x17E7CB0", Offset = "0x17E6EB0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E81")]
		 get { } //Length: 39
		[Address(RVA = "0x17E7FE0", Offset = "0x17E71E0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E82")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002E5")]
	public override bool PreAuthenticate
	{
		[Address(RVA = "0x17E8010", Offset = "0x17E7210", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E8D")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002DA")]
	internal static ArrayList PrefixList
	{
		[Address(RVA = "0x17E7CE0", Offset = "0x17E6EE0", Length = "0x1A2")]
		[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WebRequest), Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000E78")]
		internal get { } //Length: 418
	}

	[Token(Token = "0x170002E4")]
	public override IWebProxy Proxy
	{
		[Address(RVA = "0x17E7E90", Offset = "0x17E7090", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E8B")]
		 get { } //Length: 39
		[Address(RVA = "0x17E8040", Offset = "0x17E7240", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E8C")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002DE")]
	public override Uri RequestUri
	{
		[Address(RVA = "0x17E7EC0", Offset = "0x17E70C0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E83")]
		 get { } //Length: 39
	}

	[Token(Token = "0x170002E6")]
	public override int Timeout
	{
		[Address(RVA = "0x17E7EF0", Offset = "0x17E70F0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E8E")]
		 get { } //Length: 39
		[Address(RVA = "0x17E8070", Offset = "0x17E7270", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E8F")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170002E3")]
	public override bool UseDefaultCredentials
	{
		[Address(RVA = "0x17E7F20", Offset = "0x17E7120", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000E8A")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x17E77D0", Offset = "0x17E69D0", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimerThread), Member = "CreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Queue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E9C")]
	private static WebRequest() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7B")]
	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17E78B0", Offset = "0x17E6AB0", Length = "0x24")]
	[CalledBy(Type = typeof(FileWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebRequestCreator), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E7A")]
	protected WebRequest() { }

	[Address(RVA = "0x17E75D0", Offset = "0x17E67D0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x6000E9D")]
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[Address(RVA = "0x17E76D0", Offset = "0x17E68D0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task`1), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.TaskFactory`1<System.Object>), Member = "FromAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), typeof(System.Func`2<System.IAsyncResult, System.Object>), typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CompilerGenerated]
	[Token(Token = "0x6000E9E")]
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

	[Address(RVA = "0x17E67B0", Offset = "0x17E59B0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E98")]
	public override void Abort() { }

	[Address(RVA = "0x17E67E0", Offset = "0x17E59E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E93")]
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	[Address(RVA = "0x17E6810", Offset = "0x17E5A10", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E91")]
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	[Address(RVA = "0x17E6B00", Offset = "0x17E5D00", Length = "0xC6")]
	[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetNonFileStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E77")]
	public static WebRequest Create(Uri requestUri) { }

	[Address(RVA = "0x17E6BD0", Offset = "0x17E5DD0", Length = "0xCC")]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E76")]
	public static WebRequest Create(string requestUriString) { }

	[Address(RVA = "0x17E6840", Offset = "0x17E5A40", Length = "0x2B2")]
	[CalledBy(Type = typeof(DesignerWebRequestCreate), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(WebRequest))]
	[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(WebRequest))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(WebRequestPrefixElement), Member = "get_Creator", ReturnType = typeof(IWebRequestCreate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000E75")]
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	[Address(RVA = "0x17E6CA0", Offset = "0x17E5EA0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E94")]
	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	[Address(RVA = "0x17E6CD0", Offset = "0x17E5ED0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E92")]
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E99")]
	internal RequestCacheProtocol get_CacheProtocol() { }

	[Address(RVA = "0x17E78E0", Offset = "0x17E6AE0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E86")]
	public override long get_ContentLength() { }

	[Address(RVA = "0x17E7910", Offset = "0x17E6B10", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E88")]
	public override ICredentials get_Credentials() { }

	[Address(RVA = "0x17E7940", Offset = "0x17E6B40", Length = "0x66")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "CreateDefaultHandler", ReturnType = "System.Net.Http.IMonoHttpClientHandler")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RequestCacheBinding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E7E")]
	public static RequestCachePolicy get_DefaultCachePolicy() { }

	[Address(RVA = "0x17E79B0", Offset = "0x17E6BB0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E85")]
	public override WebHeaderCollection get_Headers() { }

	[Address(RVA = "0x17E79E0", Offset = "0x17E6BE0", Length = "0x1DF")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultProxySectionInternal), Member = "GetSection", ReturnType = typeof(DefaultProxySectionInternal))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000E9B")]
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	[Address(RVA = "0x17E7BC0", Offset = "0x17E6DC0", Length = "0xEA")]
	[CalledBy(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
	[CalledBy(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E74")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x17E7CB0", Offset = "0x17E6EB0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E81")]
	public override string get_Method() { }

	[Address(RVA = "0x17E7CE0", Offset = "0x17E6EE0", Length = "0x1A2")]
	[CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool)}, ReturnType = typeof(WebRequest))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(WebRequest), Member = "get_InternalSyncObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WebRequest), Member = "PopulatePrefixList", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000E78")]
	internal static ArrayList get_PrefixList() { }

	[Address(RVA = "0x17E7E90", Offset = "0x17E7090", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E8B")]
	public override IWebProxy get_Proxy() { }

	[Address(RVA = "0x17E7EC0", Offset = "0x17E70C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E83")]
	public override Uri get_RequestUri() { }

	[Address(RVA = "0x17E7EF0", Offset = "0x17E70F0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E8E")]
	public override int get_Timeout() { }

	[Address(RVA = "0x17E7F20", Offset = "0x17E7120", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E8A")]
	public override bool get_UseDefaultCredentials() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7D")]
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x17E6D00", Offset = "0x17E5F00", Length = "0x257")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
	[Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<Task`1<TResult>>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000E95")]
	public override Task<Stream> GetRequestStreamAsync() { }

	[Address(RVA = "0x17E71C0", Offset = "0x17E63C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E90")]
	public override WebResponse GetResponse() { }

	[Address(RVA = "0x17E6F60", Offset = "0x17E6160", Length = "0x257")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "IsFlowSuppressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
	[Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<Task`1<TResult>>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000E96")]
	public override Task<WebResponse> GetResponseAsync() { }

	[Address(RVA = "0x17E71F0", Offset = "0x17E63F0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RequestCacheValidator), Member = "CreateValidator", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RequestCacheProtocol), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E80")]
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	[Address(RVA = "0x17E72D0", Offset = "0x17E64D0", Length = "0x280")]
	[CalledBy(Type = typeof(WebRequest), Member = "get_PrefixList", ReturnType = typeof(ArrayList))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000E79")]
	private static ArrayList PopulatePrefixList() { }

	[Address(RVA = "0x17E7560", Offset = "0x17E6760", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WindowsIdentity), Member = "GetCurrent", ReturnType = typeof(WindowsIdentity))]
	[Token(Token = "0x6000E97")]
	private WindowsIdentity SafeCaptureIdenity() { }

	[Address(RVA = "0x17E71F0", Offset = "0x17E63F0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RequestCacheValidator), Member = "CreateValidator", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RequestCacheProtocol), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7F")]
	public override void set_CachePolicy(RequestCachePolicy value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E9A")]
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	[Address(RVA = "0x17E7F50", Offset = "0x17E7150", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E84")]
	public override void set_ConnectionGroupName(string value) { }

	[Address(RVA = "0x17E7F80", Offset = "0x17E7180", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E87")]
	public override void set_ContentLength(long value) { }

	[Address(RVA = "0x17E7FB0", Offset = "0x17E71B0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E89")]
	public override void set_Credentials(ICredentials value) { }

	[Address(RVA = "0x17E7FE0", Offset = "0x17E71E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E82")]
	public override void set_Method(string value) { }

	[Address(RVA = "0x17E8010", Offset = "0x17E7210", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E8D")]
	public override void set_PreAuthenticate(bool value) { }

	[Address(RVA = "0x17E8040", Offset = "0x17E7240", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E8C")]
	public override void set_Proxy(IWebProxy value) { }

	[Address(RVA = "0x17E8070", Offset = "0x17E7270", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E8F")]
	public override void set_Timeout(int value) { }

	[Address(RVA = "0x17E75A0", Offset = "0x17E67A0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E7C")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}


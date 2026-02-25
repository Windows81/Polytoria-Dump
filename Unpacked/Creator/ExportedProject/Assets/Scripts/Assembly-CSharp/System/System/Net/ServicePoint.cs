namespace System.Net;

[Token(Token = "0x2000299")]
public class ServicePoint
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AF5")]
	private readonly Uri uri; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AF6")]
	private DateTime lastDnsResolve; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AF7")]
	private Version protocolVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AF8")]
	private IPHostEntry host; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AF9")]
	private bool usesProxy; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000AFA")]
	private bool sendContinue; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x4000AFB")]
	private bool useConnect; //Field offset: 0x32
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AFC")]
	private object hostE; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AFD")]
	private bool useNagle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AFE")]
	private BindIPEndPoint endPointCallback; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AFF")]
	private bool tcp_keepalive; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000B00")]
	private int tcp_keepalive_time; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B01")]
	private int tcp_keepalive_interval; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000B02")]
	private bool disposed; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B03")]
	private int connectionLeaseTimeout; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000B04")]
	private int receiveBufferSize; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B05")]
	private readonly SPKey <Key>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B06")]
	private ServicePointScheduler <Scheduler>k__BackingField; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B07")]
	private int connectionLimit; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B08")]
	private int maxIdleTime; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B09")]
	private object m_ServerCertificateOrBytes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B0A")]
	private object m_ClientCertificateOrBytes; //Field offset: 0x88

	[Token(Token = "0x17000380")]
	public Uri Address
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000381")]
	public int ConnectionLimit
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000383")]
	public bool Expect100Continue
	{
		[Address(RVA = "0x35C830", Offset = "0x35BA30", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000388")]
	private bool HasTimedOut
	{
		[Address(RVA = "0x17FCB00", Offset = "0x17FBD00", Length = "0x11A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010C9")]
		private get { } //Length: 282
	}

	[Token(Token = "0x17000389")]
	internal IPHostEntry HostEntry
	{
		[Address(RVA = "0x17FCC20", Offset = "0x17FBE20", Length = "0x454")]
		[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(IPHostEntry), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
		[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010CA")]
		internal get { } //Length: 1108
	}

	[Token(Token = "0x1700037E")]
	internal SPKey Key
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B7")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000382")]
	public override Version ProtocolVersion
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700037F")]
	private ServicePointScheduler Scheduler
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B8")]
		private get { } //Length: 5
		[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000385")]
	internal bool SendContinue
	{
		[Address(RVA = "0x17FD080", Offset = "0x17FC280", Length = "0x8B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60010C0")]
		internal get { } //Length: 139
		[Address(RVA = "0x35C830", Offset = "0x35BA30", Length = "0x4")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000387")]
	internal bool UseConnect
	{
		[Address(RVA = "0x35C810", Offset = "0x35BA10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C7")]
		internal get { } //Length: 5
		[Address(RVA = "0x35C840", Offset = "0x35BA40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C8")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000384")]
	public bool UseNagleAlgorithm
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BE")]
		 get { } //Length: 5
		[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000386")]
	internal bool UsesProxy
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C5")]
		internal get { } //Length: 5
		[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C6")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x17FC9F0", Offset = "0x17FBBF0", Length = "0x10A")]
	[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ServicePointScheduler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServicePoint), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60010B6")]
	internal ServicePoint(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[Address(RVA = "0x17FC380", Offset = "0x17FB580", Length = "0xD0")]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010D1")]
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[Address(RVA = "0x17FC460", Offset = "0x17FB660", Length = "0xD4")]
	[CalledBy(Type = typeof(ServicePointManager), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60010CD")]
	public bool CloseConnectionGroup(string connectionGroupName) { }

	[Address(RVA = "0x17FC540", Offset = "0x17FB740", Length = "0x17")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "FinalCleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60010CE")]
	internal void FreeServicePoint() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BA")]
	public Uri get_Address() { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BB")]
	public int get_ConnectionLimit() { }

	[Address(RVA = "0x17FCB00", Offset = "0x17FBD00", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C9")]
	private bool get_HasTimedOut() { }

	[Address(RVA = "0x17FCC20", Offset = "0x17FBE20", Length = "0x454")]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(TimeSpan)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IPHostEntry), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010CA")]
	internal IPHostEntry get_HostEntry() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B7")]
	internal SPKey get_Key() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BC")]
	public override Version get_ProtocolVersion() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B8")]
	private ServicePointScheduler get_Scheduler() { }

	[Address(RVA = "0x17FD080", Offset = "0x17FC280", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010C0")]
	internal bool get_SendContinue() { }

	[Address(RVA = "0x35C810", Offset = "0x35BA10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C7")]
	internal bool get_UseConnect() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BE")]
	public bool get_UseNagleAlgorithm() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C5")]
	internal bool get_UsesProxy() { }

	[Address(RVA = "0x17FC560", Offset = "0x17FB760", Length = "0x146")]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Socket), Member = "IOControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IOControlCode), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C3")]
	internal void KeepAliveSetup(Socket socket) { }

	[Address(RVA = "0x17FC6B0", Offset = "0x17FB8B0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60010C4")]
	private static void PutBytes(Byte[] bytes, uint v, int offset) { }

	[Address(RVA = "0x17FC720", Offset = "0x17FB920", Length = "0x136")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(BufferOffsetSize), typeof(CancellationToken)}, ReturnType = typeof(WebOperation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePointScheduler), Member = "SendRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Token(Token = "0x60010CC")]
	internal void SendRequest(WebOperation operation, string groupName) { }

	[Address(RVA = "0x35C830", Offset = "0x35BA30", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BD")]
	public void set_Expect100Continue(bool value) { }

	[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B9")]
	private void set_Scheduler(ServicePointScheduler value) { }

	[Address(RVA = "0x35C830", Offset = "0x35BA30", Length = "0x4")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C1")]
	internal void set_SendContinue(bool value) { }

	[Address(RVA = "0x35C840", Offset = "0x35BA40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C8")]
	internal void set_UseConnect(bool value) { }

	[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BF")]
	public void set_UseNagleAlgorithm(bool value) { }

	[Address(RVA = "0x3351C0", Offset = "0x3343C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010C6")]
	internal void set_UsesProxy(bool value) { }

	[Address(RVA = "0x17FC860", Offset = "0x17FBA60", Length = "0xE3")]
	[CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(IWebProxy)}, ReturnType = typeof(ServicePoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60010C2")]
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60010CB")]
	internal void SetVersion(Version version) { }

	[Address(RVA = "0x17FC950", Offset = "0x17FBB50", Length = "0x49")]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream+<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010D0")]
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	[Address(RVA = "0x17FC9A0", Offset = "0x17FBBA0", Length = "0x49")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010CF")]
	internal void UpdateServerCertificate(X509Certificate certificate) { }

}


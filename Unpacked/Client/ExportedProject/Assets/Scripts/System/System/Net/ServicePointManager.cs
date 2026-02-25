namespace System.Net;

[Token(Token = "0x200029A")]
public class ServicePointManager
{
	[Token(Token = "0x200029B")]
	public class SPKey
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B19")]
		private Uri uri; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B1A")]
		private Uri proxy; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B1B")]
		private bool use_connect; //Field offset: 0x20

		[Token(Token = "0x1700038F")]
		public bool UsesProxy
		{
			[Address(RVA = "0x1701450", Offset = "0x1700650", Length = "0x50")]
			[CalledBy(Type = typeof(SPKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
			[Token(Token = "0x60010DD")]
			 get { } //Length: 80
		}

		[Address(RVA = "0x13A9EC0", Offset = "0x13A90C0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DC")]
		public SPKey(Uri uri, Uri proxy, bool use_connect) { }

		[Address(RVA = "0x1701260", Offset = "0x1700460", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SPKey), Member = "get_UsesProxy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60010DF")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1701450", Offset = "0x1700650", Length = "0x50")]
		[CalledBy(Type = typeof(SPKey), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60010DD")]
		public bool get_UsesProxy() { }

		[Address(RVA = "0x1701370", Offset = "0x1700570", Length = "0xD6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60010DE")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x4000B0B")]
	private static ConcurrentDictionary<SPKey, ServicePoint> servicePoints; //Field offset: 0x0
	[Token(Token = "0x4000B0C")]
	private static ICertificatePolicy policy; //Field offset: 0x8
	[Token(Token = "0x4000B0D")]
	private static int defaultConnectionLimit; //Field offset: 0x10
	[Token(Token = "0x4000B0E")]
	private static int maxServicePointIdleTime; //Field offset: 0x14
	[Token(Token = "0x4000B0F")]
	private static int maxServicePoints; //Field offset: 0x18
	[Token(Token = "0x4000B10")]
	private static int dnsRefreshTimeout; //Field offset: 0x1C
	[Token(Token = "0x4000B11")]
	private static bool _checkCRL; //Field offset: 0x20
	[Token(Token = "0x4000B12")]
	private static SecurityProtocolType _securityProtocol; //Field offset: 0x24
	[Token(Token = "0x4000B13")]
	private static bool expectContinue; //Field offset: 0x28
	[Token(Token = "0x4000B14")]
	private static bool useNagle; //Field offset: 0x29
	[Token(Token = "0x4000B15")]
	private static ServerCertValidationCallback server_cert_cb; //Field offset: 0x30
	[Token(Token = "0x4000B16")]
	private static bool tcp_keepalive; //Field offset: 0x38
	[Token(Token = "0x4000B17")]
	private static int tcp_keepalive_time; //Field offset: 0x3C
	[Token(Token = "0x4000B18")]
	private static int tcp_keepalive_interval; //Field offset: 0x40

	[MonoTODO("CRL checks not implemented")]
	[Token(Token = "0x1700038A")]
	public static bool CheckCertificateRevocationList
	{
		[Address(RVA = "0x17020F0", Offset = "0x17012F0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60010D4")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700038B")]
	public static int DnsRefreshTimeout
	{
		[Address(RVA = "0x1702140", Offset = "0x1701340", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60010D5")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700038C")]
	public static SecurityProtocolType SecurityProtocol
	{
		[Address(RVA = "0x1702190", Offset = "0x1701390", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60010D6")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700038E")]
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		[Address(RVA = "0x1702230", Offset = "0x1701430", Length = "0x84")]
		[CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Socket), typeof(string), typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010D8")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700038D")]
	internal static ServerCertValidationCallback ServerCertValidationCallback
	{
		[Address(RVA = "0x17021E0", Offset = "0x17013E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60010D7")]
		internal get { } //Length: 79
	}

	[Address(RVA = "0x1701FE0", Offset = "0x17011E0", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60010D2")]
	private static ServicePointManager() { }

	[Address(RVA = "0x17014A0", Offset = "0x17006A0", Length = "0x337")]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ServicePoint), Member = "CloseConnectionGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60010DA")]
	internal static void CloseConnectionGroup(string connectionGroupName) { }

	[Address(RVA = "0x17017E0", Offset = "0x17009E0", Length = "0x710")]
	[CalledBy(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "GetOrAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ServicePoint), Member = "SetTcpKeepAlive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServicePoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SPKey), typeof(Uri), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010D9")]
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	[Address(RVA = "0x17020F0", Offset = "0x17012F0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010D4")]
	public static bool get_CheckCertificateRevocationList() { }

	[Address(RVA = "0x1702140", Offset = "0x1701340", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010D5")]
	public static int get_DnsRefreshTimeout() { }

	[Address(RVA = "0x1702190", Offset = "0x1701390", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010D6")]
	public static SecurityProtocolType get_SecurityProtocol() { }

	[Address(RVA = "0x1702230", Offset = "0x1701430", Length = "0x84")]
	[CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Socket), typeof(string), typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010D8")]
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	[Address(RVA = "0x17021E0", Offset = "0x17013E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010D7")]
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	[Address(RVA = "0x1701F00", Offset = "0x1701100", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010D3")]
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	[Address(RVA = "0x1701F50", Offset = "0x1701150", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010DB")]
	internal static void RemoveServicePoint(ServicePoint sp) { }

}


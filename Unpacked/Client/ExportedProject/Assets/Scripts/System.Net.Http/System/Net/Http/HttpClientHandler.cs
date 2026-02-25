namespace System.Net.Http;

[Token(Token = "0x2000003")]
public class HttpClientHandler : HttpMessageHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000004")]
	private sealed class <>c
	{
		[Token(Token = "0x4000003")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000004")]
		public static LocalCertificateSelectionCallback <>9__23_1; //Field offset: 0x8

		[Address(RVA = "0x16209A0", Offset = "0x161FBA0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		public <>c() { }

		[Address(RVA = "0x1620990", Offset = "0x161FB90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "System.Net.Security.CertificateHelper", Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
		[Token(Token = "0x6000010")]
		internal X509Certificate <set_ClientCertificateOptions>b__23_1(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private readonly IMonoHttpClientHandler _delegatingHandler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000002")]
	private ClientCertificateOption _clientCertificateOptions; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public ClientCertificateOption ClientCertificateOptions
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000008")]
		 get { } //Length: 4
		[Address(RVA = "0x160BD00", Offset = "0x160AF00", Length = "0x212")]
		[CalledBy(Type = typeof(HttpClientHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoHttpClientHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(HttpClientHandler), Member = "ThrowForModifiedManagedSslOptionsIfStarted", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LocalCertificateSelectionCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000009")]
		 set { } //Length: 530
	}

	[Token(Token = "0x17000002")]
	public X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x160BBB0", Offset = "0x160ADB0", Length = "0x14B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000A")]
		 get { } //Length: 331
	}

	[Address(RVA = "0x160B9A0", Offset = "0x160ABA0", Length = "0x20F")]
	[CalledBy(Type = typeof(HttpClient), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000004")]
	public HttpClientHandler() { }

	[Address(RVA = "0x160B960", Offset = "0x160AB60", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HttpClientHandler), Member = "set_ClientCertificateOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCertificateOption)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	internal HttpClientHandler(IMonoHttpClientHandler handler) { }

	[Address(RVA = "0x160B800", Offset = "0x160AA00", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "System.Net.Security.CertificateHelper", Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600000D")]
	private X509Certificate <set_ClientCertificateOptions>b__23_0(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	[Address(RVA = "0x160B340", Offset = "0x160A540", Length = "0x1E0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int64&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	private static IMonoHttpClientHandler CreateDefaultHandler() { }

	[Address(RVA = "0x160B520", Offset = "0x160A720", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000006")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public ClientCertificateOption get_ClientCertificateOptions() { }

	[Address(RVA = "0x160BBB0", Offset = "0x160ADB0", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	public X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x160B580", Offset = "0x160A780", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	protected private virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[Address(RVA = "0x160BD00", Offset = "0x160AF00", Length = "0x212")]
	[CalledBy(Type = typeof(HttpClientHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoHttpClientHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpClientHandler), Member = "ThrowForModifiedManagedSslOptionsIfStarted", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LocalCertificateSelectionCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000009")]
	public void set_ClientCertificateOptions(ClientCertificateOption value) { }

	[Address(RVA = "0x160B650", Offset = "0x160A850", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	internal void SetWebRequestTimeout(TimeSpan timeout) { }

	[Address(RVA = "0x160B720", Offset = "0x160A920", Length = "0xD0")]
	[CalledBy(Type = typeof(HttpClientHandler), Member = "set_ClientCertificateOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCertificateOption)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	private void ThrowForModifiedManagedSslOptionsIfStarted() { }

}


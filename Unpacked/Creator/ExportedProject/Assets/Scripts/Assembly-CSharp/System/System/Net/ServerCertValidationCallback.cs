namespace System.Net;

[Token(Token = "0x2000275")]
internal class ServerCertValidationCallback
{
	[Token(Token = "0x2000276")]
	private class CallbackContext
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A29")]
		internal readonly object request; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A2A")]
		internal readonly X509Certificate certificate; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A2B")]
		internal readonly X509Chain chain; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A2C")]
		internal readonly SslPolicyErrors sslPolicyErrors; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000A2D")]
		internal bool result; //Field offset: 0x2C

		[Address(RVA = "0x17E9BB0", Offset = "0x17E8DB0", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000FC4")]
		internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A27")]
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A28")]
	private readonly ExecutionContext m_Context; //Field offset: 0x18

	[Token(Token = "0x17000337")]
	internal RemoteCertificateValidationCallback ValidationCallback
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FC1")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x17FC300", Offset = "0x17FB500", Length = "0x7C")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "GetValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(ServerCertValidationCallback))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FC0")]
	internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback) { }

	[Address(RVA = "0x17FC0E0", Offset = "0x17FB2E0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FC2")]
	internal void Callback(object state) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FC1")]
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	[Address(RVA = "0x17FC190", Offset = "0x17FB390", Length = "0x16A")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "InvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FC3")]
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}


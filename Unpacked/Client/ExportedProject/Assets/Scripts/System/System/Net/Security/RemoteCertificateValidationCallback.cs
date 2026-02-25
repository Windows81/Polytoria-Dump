namespace System.Net.Security;

[Token(Token = "0x2000316")]
public sealed class RemoteCertificateValidationCallback : MulticastDelegate
{

	[Address(RVA = "0x171BE10", Offset = "0x171B010", Length = "0x125")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "GetValidationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(ServerCertValidationCallback))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientSslHelper", Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientSslHelper", Member = "CreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream), typeof(Uri)}, ReturnType = typeof(Stream))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerSslHelper", Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerSslHelper", Member = "CreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkStream)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013EA")]
	public RemoteCertificateValidationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EB")]
	public override bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}


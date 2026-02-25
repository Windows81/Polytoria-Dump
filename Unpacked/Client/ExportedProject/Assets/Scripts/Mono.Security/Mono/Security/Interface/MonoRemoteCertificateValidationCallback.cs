namespace Mono.Security.Interface;

[Token(Token = "0x2000040")]
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate
{

	[Address(RVA = "0x12CD580", Offset = "0x12CC780", Length = "0xB5")]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.Private.CallbackHelpers", Member = "PublicToMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600014E")]
	public MonoRemoteCertificateValidationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	public override bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}


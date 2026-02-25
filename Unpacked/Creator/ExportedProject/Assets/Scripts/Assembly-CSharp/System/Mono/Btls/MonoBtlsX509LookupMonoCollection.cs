namespace Mono.Btls;

[Token(Token = "0x200009A")]
internal class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BF")]
	private Int64[] hashes; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001C0")]
	private MonoBtlsX509[] certificates; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001C1")]
	private X509CertificateCollection collection; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001C2")]
	private MonoBtlsX509TrustKind trust; //Field offset: 0x60

	[Address(RVA = "0x173CE80", Offset = "0x173C080", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60002CB")]
	internal MonoBtlsX509LookupMonoCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	[Address(RVA = "0x173C940", Offset = "0x173BB40", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60002CE")]
	protected virtual void Close() { }

	[Address(RVA = "0x173CAA0", Offset = "0x173BCA0", Length = "0x303")]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name)}, ReturnType = typeof(MonoBtlsX509))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "GetSubjectNameHash", ReturnType = typeof(long))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002CC")]
	private void Initialize() { }

	[Address(RVA = "0x173CDB0", Offset = "0x173BFB0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Initialize", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60002CD")]
	protected virtual MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

}


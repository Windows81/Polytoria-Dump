namespace Mono.Btls;

[Token(Token = "0x2000097")]
internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject
{
	[Token(Token = "0x2000098")]
	public class BoringX509LookupMonoHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C7")]
		public BoringX509LookupMonoHandle(IntPtr handle) { }

		[Address(RVA = "0x1732550", Offset = "0x1731750", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002C8")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000099")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BySubjectFunc : MulticastDelegate
	{

		[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60002C9")]
		public BySubjectFunc(object object, IntPtr method) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CA")]
		public override int Invoke(IntPtr instance, IntPtr name, out IntPtr x509_ptr) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001BA")]
	private GCHandle gch; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001BB")]
	private IntPtr instance; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001BC")]
	private BySubjectFunc bySubjectFunc; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001BD")]
	private IntPtr bySubjectFuncPtr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001BE")]
	private MonoBtlsX509Lookup lookup; //Field offset: 0x40

	[Token(Token = "0x1700007A")]
	internal BoringX509LookupMonoHandle Handle
	{
		[Address(RVA = "0x173D600", Offset = "0x173C800", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60002BD")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x173D370", Offset = "0x173C570", Length = "0x280")]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection), typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection), typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = "get_Handle", ReturnType = typeof(BoringX509LookupMonoHandle))]
	[Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60002C1")]
	internal MonoBtlsX509LookupMono() { }

	[Address(RVA = "0x173CED0", Offset = "0x173C0D0", Length = "0x113")]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name)}, ReturnType = typeof(MonoBtlsX509))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C3")]
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	[Address(RVA = "0x173CFF0", Offset = "0x173C1F0", Length = "0x89")]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181732120")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60002C6")]
	protected virtual void Close() { }

	[Address(RVA = "0x173D600", Offset = "0x173C800", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMono), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60002BD")]
	internal BoringX509LookupMonoHandle get_Handle() { }

	[Address(RVA = "0x173D080", Offset = "0x173C280", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60002C2")]
	internal void Install(MonoBtlsX509Lookup lookup) { }

	[Address(RVA = "0x173D680", Offset = "0x173C880", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002C0")]
	private static int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	[Address(RVA = "0x173D700", Offset = "0x173C900", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002BF")]
	private static void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	[Address(RVA = "0x173D7A0", Offset = "0x173C9A0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002BE")]
	private static IntPtr mono_btls_x509_lookup_mono_new() { }

	[Token(Token = "0x60002C4")]
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	[Address(RVA = "0x173D0E0", Offset = "0x173C2E0", Length = "0x28D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(BySubjectFunc))]
	[Token(Token = "0x60002C5")]
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) { }

}


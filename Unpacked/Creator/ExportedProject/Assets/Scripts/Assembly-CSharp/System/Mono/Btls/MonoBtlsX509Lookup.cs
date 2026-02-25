namespace Mono.Btls;

[Token(Token = "0x2000095")]
internal class MonoBtlsX509Lookup : MonoBtlsObject
{
	[Token(Token = "0x2000096")]
	public class BoringX509LookupHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x1732310", Offset = "0x1731510", Length = "0xB")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60002BB")]
		public BoringX509LookupHandle(IntPtr handle) { }

		[Address(RVA = "0x17324D0", Offset = "0x17316D0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60002BC")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B7")]
	private MonoBtlsX509Store store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B8")]
	private MonoBtlsX509LookupType type; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B9")]
	private List<MonoBtlsX509LookupMono> monoLookups; //Field offset: 0x30

	[Token(Token = "0x17000079")]
	internal BoringX509LookupHandle Handle
	{
		[Address(RVA = "0x173E210", Offset = "0x173D410", Length = "0x71")]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "GetNativeLookup", ReturnType = typeof(IntPtr))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(MonoBtlsX509Lookup))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x60002AE")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x173E0A0", Offset = "0x173D2A0", Length = "0x16E")]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(MonoBtlsX509Lookup))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection), typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B5")]
	internal MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x173D810", Offset = "0x173CA10", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "get_Handle", ReturnType = typeof(BoringX509Handle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B9")]
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	[Address(RVA = "0x173D920", Offset = "0x173CB20", Length = "0x19B")]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddDirectoryLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1817320D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B7")]
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	[Address(RVA = "0x173DAC0", Offset = "0x173CCC0", Length = "0x271")]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection), typeof(MonoBtlsX509TrustKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsX509LookupMono), Member = "get_Handle", ReturnType = typeof(BoringX509LookupMonoHandle))]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B8")]
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	[Address(RVA = "0x173DD40", Offset = "0x173CF40", Length = "0x185")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60002BA")]
	protected virtual void Close() { }

	[Address(RVA = "0x173DED0", Offset = "0x173D0D0", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsX509Store), Member = "get_Handle", ReturnType = typeof(BoringX509StoreHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B4")]
	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x173E210", Offset = "0x173D410", Length = "0x71")]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "GetNativeLookup", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MonoBtlsX509FileType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Lookup), Member = "AddMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509Store), Member = "AddLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509LookupType)}, ReturnType = typeof(MonoBtlsX509Lookup))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60002AE")]
	internal BoringX509LookupHandle get_Handle() { }

	[Address(RVA = "0x173E000", Offset = "0x173D200", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509Lookup), Member = "get_Handle", ReturnType = typeof(BoringX509LookupHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B6")]
	internal IntPtr GetNativeLookup() { }

	[Address(RVA = "0x173E290", Offset = "0x173D490", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B0")]
	private static int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	[Address(RVA = "0x173E330", Offset = "0x173D530", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B1")]
	private static int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	[Address(RVA = "0x173E3C0", Offset = "0x173D5C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B2")]
	private static void mono_btls_x509_lookup_free(IntPtr handle) { }

	[Address(RVA = "0x173E440", Offset = "0x173D640", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002AF")]
	private static IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x173E4D0", Offset = "0x173D6D0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B3")]
	private static IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

}


namespace Mono.Btls;

[Token(Token = "0x200006C")]
internal class MonoBtlsBio : MonoBtlsObject
{
	[Token(Token = "0x200006D")]
	private class BoringBioHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x15ED8C0", Offset = "0x15ECAC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600019B")]
		public BoringBioHandle(IntPtr handle) { }

		[Address(RVA = "0x15ED820", Offset = "0x15ECA20", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600019C")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000061")]
	protected private BoringBioHandle Handle
	{
		[Address(RVA = "0x15F3D40", Offset = "0x15F2F40", Length = "0x75")]
		[CalledBy(Type = typeof(MonoBtlsBioMemory), Member = "GetData", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(MonoBtlsBioMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoBtlsBioMono)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetBio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsBio)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = "System.Threading.ReaderWriterLockSlim+TimeoutTracker", Member = "get_RemainingMilliseconds", ReturnType = typeof(int))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000199")]
		private get { } //Length: 117
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000198")]
	internal MonoBtlsBio(BoringBioHandle handle) { }

	[Address(RVA = "0x15F3D40", Offset = "0x15F2F40", Length = "0x75")]
	[CalledBy(Type = typeof(MonoBtlsBioMemory), Member = "GetData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsBioMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoBtlsBioMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetBio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsBio)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim+TimeoutTracker", Member = "get_RemainingMilliseconds", ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000199")]
	protected private BoringBioHandle get_Handle() { }

	[Address(RVA = "0x15F3DC0", Offset = "0x15F2FC0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600019A")]
	private static void mono_btls_bio_free(IntPtr handle) { }

}


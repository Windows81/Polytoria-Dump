namespace System.Runtime.InteropServices;

[Token(Token = "0x200044B")]
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	[Token(Token = "0x400121F")]
	private const int RefCount_Mask = 2147483644; //Field offset: 0x0
	[Token(Token = "0x4001220")]
	private const int RefCount_One = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400121B")]
	protected IntPtr handle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400121C")]
	private int _state; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400121D")]
	private bool _ownsHandle; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x400121E")]
	private bool _fullyInitialized; //Field offset: 0x1D

	[Token(Token = "0x170003EB")]
	public bool IsClosed
	{
		[Address(RVA = "0x13C9E10", Offset = "0x13C9010", Length = "0x7")]
		[CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FileStream), Member = "ReadByte", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(FileStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterface", Member = "get_FixedInfo", ReturnType = "System.Net.NetworkInformation.Win32_FIXED_INFO")]
		[CalledBy(Type = typeof(FileStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
		[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FileStream), Member = "Flush", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001F89")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170003EC")]
	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001F8A")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x13C9D80", Offset = "0x13C8F80", Length = "0x86")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001F85")]
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle) { }

	[Address(RVA = "0x13C6E50", Offset = "0x13C6050", Length = "0x16")]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F8B")]
	public void Close() { }

	[Address(RVA = "0x13C99F0", Offset = "0x13C8BF0", Length = "0x67")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813B4CB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001F90")]
	public void DangerousAddRef(ref bool success) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F88")]
	public IntPtr DangerousGetHandle() { }

	[Address(RVA = "0x13C9B00", Offset = "0x13C8D00", Length = "0xA")]
	[CallerCount(Count = 76)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F91")]
	public void DangerousRelease() { }

	[Address(RVA = "0x13C9A60", Offset = "0x13C8C60", Length = "0x99")]
	[CalledBy(Type = typeof(SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "InternalDispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SafeHandle), Member = "InternalFinalize", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813B4AF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001F94")]
	private void DangerousReleaseInternal(bool dispose) { }

	[Address(RVA = "0x13C6E50", Offset = "0x13C6050", Length = "0x16")]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F8C")]
	public override void Dispose() { }

	[Address(RVA = "0x13C9B10", Offset = "0x13C8D10", Length = "0xB2")]
	[CalledBy(Type = typeof(SafePasswordHandle), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F8D")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x13C9BD0", Offset = "0x13C8DD0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F86")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x13C9E10", Offset = "0x13C9010", Length = "0x7")]
	[CalledBy(Type = typeof(FileStream), Member = "Flush", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32NetworkInterface", Member = "get_FixedInfo", ReturnType = "System.Net.NetworkInformation.Win32_FIXED_INFO")]
	[CalledBy(Type = typeof(FileStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F89")]
	public bool get_IsClosed() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F8A")]
	public abstract bool get_IsInvalid() { }

	[Address(RVA = "0x13C9C40", Offset = "0x13C8E40", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001F92")]
	private void InternalDispose() { }

	[Address(RVA = "0x13C9CE0", Offset = "0x13C8EE0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousReleaseInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001F93")]
	private void InternalFinalize() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F8E")]
	protected abstract bool ReleaseHandle() { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F87")]
	protected void SetHandle(IntPtr handle) { }

	[Address(RVA = "0x13C9D00", Offset = "0x13C8F00", Length = "0x7C")]
	[CalledBy(Type = typeof(RegistryKey), Member = "Win32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WaitHandle), Member = "set_Handle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813B4A70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001F8F")]
	public void SetHandleAsInvalid() { }

}


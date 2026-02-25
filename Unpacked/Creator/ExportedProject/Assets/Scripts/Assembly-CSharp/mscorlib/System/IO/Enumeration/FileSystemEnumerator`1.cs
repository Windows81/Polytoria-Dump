namespace System.IO.Enumeration;

[Token(Token = "0x2000667")]
public abstract class FileSystemEnumerator : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A16")]
	private readonly string _originalRootDirectory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A17")]
	private readonly string _rootDirectory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A18")]
	private readonly EnumerationOptions _options; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A19")]
	private readonly object _lock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A1A")]
	private FILE_FULL_DIR_INFORMATION* _entry; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A1B")]
	private TResult _current; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A1C")]
	private IntPtr _buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A1D")]
	private int _bufferLength; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A1E")]
	private IntPtr _directoryHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A1F")]
	private string _currentPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A20")]
	private bool _lastEntryFound; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001A21")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"Handle", "Path"})]
	private Queue<ValueTuple`2<IntPtr, String>> _pending; //Field offset: 0x0

	[Token(Token = "0x17000751")]
	public override TResult Current
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FAD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000752")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002FAE")]
		private get { } //Length: 5
	}

	[Address(RVA = "0xC3CA10", Offset = "0xC3BC10", Length = "0x36E")]
	[CalledBy(Type = "System.IO.Enumeration.FileSystemEnumerable`1+DelegateEnumerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Enumeration.FileSystemEnumerable`1<TResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "CreateDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DisableMediaInsertionPrompt), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(PathInternal), Member = "TrimEndingDirectorySeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F9E")]
	public FileSystemEnumerator`1(string directory, EnumerationOptions options = null) { }

	[Address(RVA = "0xC3B550", Offset = "0xC3A750", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F9F")]
	private void CloseDirectoryHandle() { }

	[Address(RVA = "0xC3B580", Offset = "0xC3A780", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA1")]
	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FAC")]
	protected override bool ContinueOnError(int error) { }

	[Address(RVA = "0xC3B5E0", Offset = "0xC3A7E0", Length = "0x1FB")]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "CreateRelativeDirectoryHandleUWP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileSystem), Member = "UnityCreateFile_IntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(FileShare), typeof(FileMode), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA0")]
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = false) { }

	[Address(RVA = "0xC3B800", Offset = "0xC3AA00", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NtDll), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IntPtr), typeof(CreateDisposition), typeof(DesiredAccess), typeof(FileShare), typeof(FileAttributes), typeof(CreateOptions), typeof(ObjectAttributes)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA7")]
	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<Char> relativePath, string fullPath) { }

	[Address(RVA = "0xC3B7E0", Offset = "0xC3A9E0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "CreateDirectoryHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F9D")]
	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<Char> relativePath, string fullPath) { }

	[Address(RVA = "0xC3B920", Offset = "0xC3AB20", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Dequeue", ReturnType = typeof(System.ValueTuple`2<System.IntPtr, System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA4")]
	private bool DequeueNextDirectory() { }

	[Address(RVA = "0xC3B9B0", Offset = "0xC3ABB0", Length = "0x148")]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "FindNextEntry", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Dequeue", ReturnType = typeof(System.ValueTuple`2<System.IntPtr, System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABBD0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FAF")]
	private void DirectoryFinished() { }

	[Address(RVA = "0xC3BB00", Offset = "0xC3AD00", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "InternalDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FB1")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FB2")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0xC3BB80", Offset = "0xC3AD80", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "InternalDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FB3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xC3BC00", Offset = "0xC3AE00", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "GetNextInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FILE_FULL_DIR_INFORMATION*)}, ReturnType = typeof(FILE_FULL_DIR_INFORMATION*))]
	[Calls(Type = typeof(NtDll), Member = "NtQueryDirectoryFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IO_STATUS_BLOCK&), typeof(IntPtr), typeof(uint), typeof(FILE_INFORMATION_CLASS), typeof(BOOLEAN), typeof(UNICODE_STRING*), typeof(BOOLEAN)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "DirectoryFinished", ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA3")]
	private void FindNextEntry() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FAD")]
	public override TResult get_Current() { }

	[Address(RVA = "0xC3BE60", Offset = "0xC3B060", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NtDll), Member = "NtQueryDirectoryFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IO_STATUS_BLOCK&), typeof(IntPtr), typeof(uint), typeof(FILE_INFORMATION_CLASS), typeof(BOOLEAN), typeof(UNICODE_STRING*), typeof(BOOLEAN)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABA80")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA6")]
	private bool GetData() { }

	[Address(RVA = "0xC3BD40", Offset = "0xC3AF40", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Kernel32), Member = "GetFileInformationByHandleEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FILE_INFO_BY_HANDLE_CLASS), typeof(IntPtr), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "GetLastWin32Error", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800ABA80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002F9C")]
	private bool GetDataUWP() { }

	[Address(RVA = "0xC3BFA0", Offset = "0xC3B1A0", Length = "0x1DB")]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileSystemEnumerator`1), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Dequeue", ReturnType = typeof(System.ValueTuple`2<System.IntPtr, System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA5")]
	private void InternalDispose(bool disposing) { }

	[Address(RVA = "0xC3C180", Offset = "0xC3B380", Length = "0x880")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Win32Marshal), Member = "GetExceptionForWin32Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.ValueTuple`2<System.IntPtr, System.Object>>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.IntPtr, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NtDll), Member = "CreateFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(IntPtr), typeof(CreateDisposition), typeof(DesiredAccess), typeof(FileShare), typeof(FileAttributes), typeof(CreateOptions), typeof(ObjectAttributes)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(Path), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "get_FileName", ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(FileSystemEntry), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEntry&), typeof(FILE_FULL_DIR_INFORMATION*), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(FileSystemEnumerator`1), Member = "DirectoryFinished", ReturnType = typeof(void))]
	[Calls(Type = typeof(NtDll), Member = "RtlNtStatusToDosError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(NtDll), Member = "NtQueryDirectoryFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IO_STATUS_BLOCK&), typeof(IntPtr), typeof(uint), typeof(FILE_INFORMATION_CLASS), typeof(BOOLEAN), typeof(UNICODE_STRING*), typeof(BOOLEAN)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FILE_FULL_DIR_INFORMATION), Member = "GetNextInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FILE_FULL_DIR_INFORMATION*)}, ReturnType = typeof(FILE_FULL_DIR_INFORMATION*))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Kernel32), Member = "CloseHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA2")]
	public override bool MoveNext() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FAB")]
	protected override void OnDirectoryFinished(ReadOnlySpan<Char> directory) { }

	[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FB0")]
	public override void Reset() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA8")]
	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FA9")]
	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002FAE")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Token(Token = "0x6002FAA")]
	protected abstract TResult TransformEntry(ref FileSystemEntry entry) { }

}


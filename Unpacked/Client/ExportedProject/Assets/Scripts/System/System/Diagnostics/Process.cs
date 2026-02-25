namespace System.Diagnostics;

[DefaultEvent("Exited")]
[DefaultProperty("StartInfo")]
[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
[Token(Token = "0x2000101")]
public class Process : Component
{
	[Token(Token = "0x2000104")]
	private struct ProcInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000490")]
		public IntPtr process_handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000491")]
		public int pid; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000492")]
		public String[] envVariables; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000493")]
		public string UserName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000494")]
		public string Domain; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000495")]
		public IntPtr Password; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000496")]
		public bool LoadUserProfile; //Field offset: 0x30

	}

	[Token(Token = "0x2000103")]
	private enum State
	{
		HaveId = 1,
		IsLocal = 2,
		IsNt = 4,
		HaveProcessInfo = 8,
		Exited = 16,
		Associated = 32,
		IsWin2k = 64,
		HaveNtProcessInfo = 12,
	}

	[Token(Token = "0x2000102")]
	private enum StreamReadMode
	{
		undefined = 0,
		syncMode = 1,
		asyncMode = 2,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000462")]
	private bool haveProcessId; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000463")]
	private int processId; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000464")]
	private bool haveProcessHandle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000465")]
	private SafeProcessHandle m_processHandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000466")]
	private bool isRemoteMachine; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000467")]
	private string machineName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000468")]
	private int m_processAccess; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000469")]
	private ProcessThreadCollection threads; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400046A")]
	private ProcessModuleCollection modules; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400046B")]
	private bool haveWorkingSetLimits; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x400046C")]
	private bool havePriorityClass; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400046D")]
	private ProcessStartInfo startInfo; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400046E")]
	private bool watchForExit; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x400046F")]
	private bool watchingForExit; //Field offset: 0x79
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000470")]
	private EventHandler onExited; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000471")]
	private bool exited; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000472")]
	private int exitCode; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000473")]
	private bool signaled; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x4000474")]
	private bool haveExitTime; //Field offset: 0x91
	[FieldOffset(Offset = "0x92")]
	[Token(Token = "0x4000475")]
	private bool raisedOnExited; //Field offset: 0x92
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000476")]
	private RegisteredWaitHandle registeredWaitHandle; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000477")]
	private WaitHandle waitHandle; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000478")]
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000479")]
	private StreamReader standardOutput; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400047A")]
	private StreamWriter standardInput; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400047B")]
	private StreamReader standardError; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400047C")]
	private bool disposed; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x400047D")]
	private StreamReadMode outputStreamReadMode; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400047E")]
	private StreamReadMode errorStreamReadMode; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x400047F")]
	private StreamReadMode inputStreamReadMode; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000480")]
	internal AsyncStreamReader output; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000481")]
	internal AsyncStreamReader error; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000482")]
	private string process_name; //Field offset: 0xE8

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the process component is associated with a real process.")]
	[Token(Token = "0x170000E8")]
	private bool Associated
	{
		[Address(RVA = "0x1768F90", Offset = "0x1768190", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000622")]
		private get { } //Length: 13
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The value returned from the associated process when it terminated.")]
	[Token(Token = "0x170000E9")]
	public int ExitCode
	{
		[Address(RVA = "0x1768FA0", Offset = "0x17681A0", Length = "0x123")]
		[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "OS_Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(RuntimeInformation), Member = "IsOSPlatform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OSPlatform)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000623")]
		 get { } //Length: 291
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
	[Token(Token = "0x170000EB")]
	public IntPtr Handle
	{
		[Address(RVA = "0x17690D0", Offset = "0x17682D0", Length = "0xDB")]
		[CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000625")]
		 get { } //Length: 219
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("Indicates if the associated process has been terminated.")]
	[Token(Token = "0x170000EA")]
	public bool HasExited
	{
		[Address(RVA = "0x17691B0", Offset = "0x17683B0", Length = "0x364")]
		[CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
		[Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000624")]
		 get { } //Length: 868
	}

	[Token(Token = "0x170000EF")]
	private static bool IsWindows
	{
		[Address(RVA = "0x147DA80", Offset = "0x147CC80", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000645")]
		private get { } //Length: 54
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	[MonitoringDescription("The name of this process.")]
	[Token(Token = "0x170000EE")]
	public string ProcessName
	{
		[Address(RVA = "0x1769520", Offset = "0x1768720", Length = "0x24E")]
		[CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
		[Calls(Type = typeof(Process), Member = "ProcessName_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000640")]
		 get { } //Length: 590
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	[MonitoringDescription("Specifies information used to start a process.")]
	[Token(Token = "0x170000EC")]
	public ProcessStartInfo StartInfo
	{
		[Address(RVA = "0x1769770", Offset = "0x1768970", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Process)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000626")]
		 get { } //Length: 109
		[Address(RVA = "0x1769960", Offset = "0x1768B60", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000627")]
		 set { } //Length: 108
	}

	[Browsable(False)]
	[DefaultValue(null)]
	[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
	[Token(Token = "0x170000ED")]
	public ISynchronizeInvoke SynchronizingObject
	{
		[Address(RVA = "0x17697E0", Offset = "0x17689E0", Length = "0x176")]
		[CalledBy(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Component), Member = "get_DesignMode", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000628")]
		 get { } //Length: 374
	}

	[Address(RVA = "0x1768E60", Offset = "0x1768060", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000620")]
	public Process() { }

	[Address(RVA = "0x1768EF0", Offset = "0x17680F0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000621")]
	private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	[Address(RVA = "0x1765CD0", Offset = "0x1764ED0", Length = "0x22C")]
	[CalledBy(Type = typeof(Process), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600062C")]
	public void Close() { }

	[Address(RVA = "0x1765F00", Offset = "0x1765100", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "StopWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	[Token(Token = "0x600062A")]
	private void CompletionCallback(object context, bool wasSignaled) { }

	[Address(RVA = "0x1765F20", Offset = "0x1765120", Length = "0x2F5")]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
	[Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.MonoIOError"}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "System.IO.MonoIO", Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr&), typeof(int), typeof(int), typeof(int), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[Calls(Type = "System.IO.MonoIO", Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6000644")]
	private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection) { }

	[Address(RVA = "0x12F3760", Offset = "0x12F2960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000642")]
	private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref ProcInfo procInfo) { }

	[Address(RVA = "0x1766220", Offset = "0x1765420", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600062B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1766270", Offset = "0x1765470", Length = "0x27E")]
	[CalledBy(Type = typeof(Process), Member = "get_ExitCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600062D")]
	private void EnsureState(State state) { }

	[Address(RVA = "0x17664F0", Offset = "0x17656F0", Length = "0x1CD")]
	[CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "SetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(int), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600062E")]
	private void EnsureWatchingForExit() { }

	[Address(RVA = "0x17666C0", Offset = "0x17658C0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_UserName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_Domain", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000647")]
	private static void FillUserInfo(ProcessStartInfo startInfo, ref ProcInfo procInfo) { }

	[Address(RVA = "0x1768F90", Offset = "0x1768190", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000622")]
	private bool get_Associated() { }

	[Address(RVA = "0x1768FA0", Offset = "0x17681A0", Length = "0x123")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "OS_Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeInformation), Member = "IsOSPlatform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OSPlatform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000623")]
	public int get_ExitCode() { }

	[Address(RVA = "0x17690D0", Offset = "0x17682D0", Length = "0xDB")]
	[CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000625")]
	public IntPtr get_Handle() { }

	[Address(RVA = "0x17691B0", Offset = "0x17683B0", Length = "0x364")]
	[CalledBy(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000624")]
	public bool get_HasExited() { }

	[Address(RVA = "0x147DA80", Offset = "0x147CC80", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000645")]
	private static bool get_IsWindows() { }

	[Address(RVA = "0x1769520", Offset = "0x1768720", Length = "0x24E")]
	[CalledBy(Type = typeof(Process), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Process), Member = "ProcessName_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000640")]
	public string get_ProcessName() { }

	[Address(RVA = "0x1769770", Offset = "0x1768970", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Process)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000626")]
	public ProcessStartInfo get_StartInfo() { }

	[Address(RVA = "0x17697E0", Offset = "0x17689E0", Length = "0x176")]
	[CalledBy(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_DesignMode", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000628")]
	public ISynchronizeInvoke get_SynchronizingObject() { }

	[Address(RVA = "0x17667A0", Offset = "0x17659A0", Length = "0xCF")]
	[CalledBy(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcessId", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600062F")]
	public static Process GetCurrentProcess() { }

	[Address(RVA = "0x1766870", Offset = "0x1765A70", Length = "0x4A5")]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "get_Handle", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "OpenProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SafeProcessHandle))]
	[CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(NativeMethods), Member = "GetExitCodeProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeMethods), Member = "DuplicateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HandleRef), typeof(HandleRef), typeof(HandleRef), typeof(SafeProcessHandle&), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcess", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Process), Member = "EnsureState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000631")]
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	[Address(RVA = "0x1766D20", Offset = "0x1765F20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Token(Token = "0x6000632")]
	private SafeProcessHandle GetProcessHandle(int access) { }

	[Address(RVA = "0x1766D30", Offset = "0x1765F30", Length = "0x253")]
	[CalledBy(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Process), Member = "get_SynchronizingObject", ReturnType = typeof(ISynchronizeInvoke))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000630")]
	protected void OnExited() { }

	[Address(RVA = "0x1766F90", Offset = "0x1766190", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000633")]
	private SafeProcessHandle OpenProcessHandle(int access) { }

	[Address(RVA = "0x1767050", Offset = "0x1766250", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802257C0")]
	[Token(Token = "0x600063E")]
	private static string ProcessName_icall(IntPtr handle) { }

	[Address(RVA = "0x1767060", Offset = "0x1766260", Length = "0xC2")]
	[CalledBy(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802257C0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600063F")]
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	[Address(RVA = "0x1767130", Offset = "0x1766330", Length = "0xA7")]
	[CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "CompletionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "OnExited", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000648")]
	private void RaiseOnExited() { }

	[Address(RVA = "0x17671E0", Offset = "0x17663E0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000634")]
	public void Refresh() { }

	[Address(RVA = "0x1767230", Offset = "0x1766430", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000629")]
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	[Address(RVA = "0x1769960", Offset = "0x1768B60", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000627")]
	public void set_StartInfo(ProcessStartInfo value) { }

	[Address(RVA = "0x1767250", Offset = "0x1766450", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Token(Token = "0x6000635")]
	private void SetProcessHandle(SafeProcessHandle processHandle) { }

	[Address(RVA = "0x1767290", Offset = "0x1766490", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000636")]
	private void SetProcessId(int processId) { }

	[Address(RVA = "0x12F3760", Offset = "0x12F2960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000641")]
	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref ProcInfo procInfo) { }

	[Address(RVA = "0x1768A10", Offset = "0x1767C10", Length = "0x5A")]
	[CalledBy(Type = "Polytoria.Controllers.ScriptingAPIDumper", Member = "DumpAPI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[Token(Token = "0x6000638")]
	public static Process Start(string fileName) { }

	[Address(RVA = "0x17686E0", Offset = "0x17678E0", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Process)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_FileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000637")]
	public bool Start() { }

	[Address(RVA = "0x17687F0", Offset = "0x17679F0", Length = "0x21E")]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Process))]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "OS_Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_FileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProcessStartInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Process)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000639")]
	public static Process Start(ProcessStartInfo startInfo) { }

	[Address(RVA = "0x17672A0", Offset = "0x17664A0", Length = "0xFF0")]
	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "SecureStringToBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = "System.IO.MonoIO", Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeProcessHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(FileAccess), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181765770")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_FileName", ReturnType = typeof(string))]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_Arguments", ReturnType = typeof(string))]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_WorkingDirectory", ReturnType = typeof(string))]
	[Calls(Type = typeof(Win32Exception), Member = "GetErrorMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_RedirectStandardError", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gc_has_strict_wbarriers")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_Domain", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_HaveEnvVars", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_EnvironmentVariables", ReturnType = typeof(StringDictionary))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_ArgumentList", ReturnType = typeof(System.Collections.ObjectModel.Collection`1<System.String>))]
	[Calls(Type = typeof(Collection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Collection`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(PasteArguments), Member = "AppendArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleInput", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Process), Member = "CreatePipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr&), typeof(IntPtr&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleOutput", ReturnType = typeof(IntPtr))]
	[Calls(Type = "System.IO.MonoIO", Member = "get_ConsoleError", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_UserName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000646")]
	private bool StartWithCreateProcess(ProcessStartInfo startInfo) { }

	[Address(RVA = "0x17682A0", Offset = "0x17674A0", Length = "0x54")]
	[CalledBy(Type = typeof(Process), Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Process), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProcessStartInfo)}, ReturnType = typeof(Process))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000643")]
	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) { }

	[Address(RVA = "0x1768A70", Offset = "0x1767C70", Length = "0x109")]
	[CalledBy(Type = typeof(Process), Member = "CompletionCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Process), Member = "Close", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegisteredWaitHandle), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600063A")]
	private void StopWatchingForExit() { }

	[Address(RVA = "0x1768B80", Offset = "0x1767D80", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Process), Member = "get_ProcessName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600063B")]
	public virtual string ToString() { }

	[Address(RVA = "0x1768C80", Offset = "0x1767E80", Length = "0x1C1")]
	[CalledBy(Type = typeof(Process), Member = "WaitForExit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(SafeProcessHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeProcessHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncStreamReader), Member = "WaitUtilEOF", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181765830")]
	[Calls(Type = typeof(Process), Member = "RaiseOnExited", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600063C")]
	public bool WaitForExit(int milliseconds) { }

	[Address(RVA = "0x1768E50", Offset = "0x1768050", Length = "0xD")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.StandardPlatformAccessor", Member = "OS_Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600063D")]
	public void WaitForExit() { }

}


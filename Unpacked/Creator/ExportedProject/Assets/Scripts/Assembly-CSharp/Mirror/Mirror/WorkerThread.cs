namespace Mirror;

[Token(Token = "0x200008E")]
public class WorkerThread
{
	[CompilerGenerated]
	[Token(Token = "0x200008F")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001E2")]
		public WorkerThread <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001E3")]
		public string identifier; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048F")]
		public <>c__DisplayClass6_0() { }

		[Address(RVA = "0x12A43C0", Offset = "0x12A35C0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WorkerThread), Member = "Guard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000490")]
		internal void <.ctor>b__0() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DC")]
	private readonly Thread thread; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001DD")]
	protected bool active; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DE")]
	private readonly Stopwatch watch; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DF")]
	public Action Init; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E0")]
	public Func<Boolean> Tick; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E1")]
	public Action Cleanup; //Field offset: 0x38

	[Token(Token = "0x17000080")]
	public bool IsAlive
	{
		[Address(RVA = "0x12A67B0", Offset = "0x12A59B0", Length = "0x6D")]
		[CalledBy(Type = "Mirror.ThreadedTransport", Member = "EnsureThread", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000489")]
		 get { } //Length: 109
	}

	[Address(RVA = "0x12A6660", Offset = "0x12A5860", Length = "0x14E")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "EnsureThread", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000485")]
	public WorkerThread(string identifier) { }

	[Address(RVA = "0x12A67B0", Offset = "0x12A59B0", Length = "0x6D")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "EnsureThread", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000489")]
	public bool get_IsAlive() { }

	[Address(RVA = "0x12A61E0", Offset = "0x12A53E0", Length = "0x211")]
	[CalledBy(Type = typeof(<>c__DisplayClass6_0), Member = "<.ctor>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1812871B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600048E")]
	public void Guard(string identifier) { }

	[Address(RVA = "0x12A6400", Offset = "0x12A5600", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600048A")]
	public void Interrupt() { }

	[Address(RVA = "0x12A6420", Offset = "0x12A5620", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600048D")]
	private void OnCleanup() { }

	[Address(RVA = "0x12A6440", Offset = "0x12A5640", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048B")]
	private void OnInit() { }

	[Address(RVA = "0x12A6460", Offset = "0x12A5660", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600048C")]
	private bool OnTick() { }

	[Address(RVA = "0x12A6480", Offset = "0x12A5680", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000487")]
	public override void SignalStop() { }

	[Address(RVA = "0x12A64A0", Offset = "0x12A56A0", Length = "0x90")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "EnsureThread", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000486")]
	public void Start() { }

	[Address(RVA = "0x12A6540", Offset = "0x12A5740", Length = "0x113")]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Stopwatch), Member = "Restart", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000488")]
	public bool StopBlocking(float timeout) { }

}


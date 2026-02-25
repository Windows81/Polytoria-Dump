namespace Internal.Runtime.Augments;

[Token(Token = "0x200008F")]
internal sealed class RuntimeThread
{
	[Token(Token = "0x4000267")]
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000268")]
	private readonly Thread thread; //Field offset: 0x10

	[Token(Token = "0x17000039")]
	public bool IsBackground
	{
		[Address(RVA = "0x12FCD00", Offset = "0x12FBF00", Length = "0x1E")]
		[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000264")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x12FCCC0", Offset = "0x12FBEC0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600026A")]
	private static RuntimeThread() { }

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000262")]
	private RuntimeThread(Thread t) { }

	[Address(RVA = "0x12FCBC0", Offset = "0x12FBDC0", Length = "0x98")]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000263")]
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000269")]
	public static int GetCurrentProcessorId() { }

	[Address(RVA = "0x12FCD00", Offset = "0x12FBF00", Length = "0x1E")]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000264")]
	public void set_IsBackground(bool value) { }

	[Address(RVA = "0x12FCC60", Offset = "0x12FBE60", Length = "0x7")]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000266")]
	public static void Sleep(int millisecondsTimeout) { }

	[Address(RVA = "0x12FCC70", Offset = "0x12FBE70", Length = "0x12")]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000268")]
	public static bool SpinWait(int iterations) { }

	[Address(RVA = "0x12FCC90", Offset = "0x12FBE90", Length = "0x1E")]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000265")]
	public void Start(object state) { }

	[Address(RVA = "0x12FCCB0", Offset = "0x12FBEB0", Length = "0x7")]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000267")]
	public static bool Yield() { }

}


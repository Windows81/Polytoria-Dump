namespace System.Threading;

[Token(Token = "0x20001FF")]
public struct SpinWait
{
	[Token(Token = "0x40009B1")]
	internal static readonly int SpinCountforSpinBeforeWait; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009B2")]
	private int _count; //Field offset: 0x0

	[Token(Token = "0x17000195")]
	public int Count
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x600114B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000196")]
	public bool NextSpinWillYield
	{
		[Address(RVA = "0x15190A0", Offset = "0x15182A0", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600114C")]
		 get { } //Length: 98
	}

	[Address(RVA = "0x1519020", Offset = "0x1518220", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001150")]
	private static SpinWait() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x600114B")]
	public int get_Count() { }

	[Address(RVA = "0x15190A0", Offset = "0x15182A0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600114C")]
	public bool get_NextSpinWillYield() { }

	[Address(RVA = "0x1518EE0", Offset = "0x15180E0", Length = "0x4F")]
	[CalledBy(Type = typeof(Segment), Member = "EnsureFrozenForEnqueues", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue", Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "GetItemWhenAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Concurrent.ConcurrentQueue`1<T>+Segment<T>", typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(ConcurrentQueue`1), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Segment), Member = "TryEnqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Segment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hashtable), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "SpinUntilCompleted", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QueueSegment), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Lazy`1), Member = "PublicationOnlyWaitForOtherThreadToPublish", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "FreezeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600114D")]
	public void SpinOnce() { }

	[Address(RVA = "0x1518F30", Offset = "0x1518130", Length = "0xEC")]
	[CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600114E")]
	public void SpinOnce(int sleep1Threshold) { }

	[Address(RVA = "0x1518D50", Offset = "0x1517F50", Length = "0x187")]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "WaitForCallbackToComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationCallbackInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "UpdateStateAtomically", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinWait), Member = "SpinOnce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpinLock), Member = "DecrementWaiters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(RuntimeThread), Member = "SpinWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeThread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeThread), Member = "Yield", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600114F")]
	private void SpinOnceCore(int sleep1Threshold) { }

}


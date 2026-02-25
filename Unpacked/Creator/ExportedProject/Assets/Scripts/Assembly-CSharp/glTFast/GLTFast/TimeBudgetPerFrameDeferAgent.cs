namespace GLTFast;

[DefaultExecutionOrder(-10)]
[Token(Token = "0x2000052")]
public class TimeBudgetPerFrameDeferAgent : MonoBehaviour, IDeferAgent
{
	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private struct <BreakPoint>d__11 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A0")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A2")]
		public TimeBudgetPerFrameDeferAgent <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A3")]
		private YieldAwaiter <>u__1; //Field offset: 0x28

		[Address(RVA = "0x107B1D0", Offset = "0x107A3D0", Length = "0x1E5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6000159")]
		private override void MoveNext() { }

		[Address(RVA = "0x107B3C0", Offset = "0x107A5C0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600015A")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private struct <BreakPoint>d__12 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A4")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001A5")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A6")]
		public TimeBudgetPerFrameDeferAgent <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A7")]
		public float duration; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001A8")]
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		[Address(RVA = "0x107B420", Offset = "0x107A620", Length = "0x204")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x600015B")]
		private override void MoveNext() { }

		[Address(RVA = "0x107B630", Offset = "0x107A830", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[Token(Token = "0x600015C")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Range(0.01, 5)]
	[SerializeField]
	[Token(Token = "0x400019D")]
	[Tooltip("Per-frame time budget as fraction of the targeted frame time. Keep it well below 0.5, so there's enough time for other game logic and rendering. A value of 1.0 can lead to dropping a full frame. Even higher values can stall for multiple frames.")]
	private float frameBudget; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400019E")]
	private float m_LastTime; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400019F")]
	private float m_TimeBudget; //Field offset: 0x28

	[Address(RVA = "0x107AE80", Offset = "0x107A080", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000158")]
	public TimeBudgetPerFrameDeferAgent() { }

	[Address(RVA = "0x107AB30", Offset = "0x1079D30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeBudgetPerFrameDeferAgent), Member = "UpdateTimeBudget", ReturnType = typeof(void))]
	[Token(Token = "0x6000150")]
	private void Awake() { }

	[Address(RVA = "0x107AB40", Offset = "0x1079D40", Length = "0xC5")]
	[AsyncStateMachine(typeof(<BreakPoint>d__11))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BreakPoint>d__11)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BreakPoint>d__11&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000156")]
	public override Task BreakPoint() { }

	[Address(RVA = "0x107AC10", Offset = "0x1079E10", Length = "0xDE")]
	[AsyncStateMachine(typeof(<BreakPoint>d__12))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BreakPoint>d__12)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<BreakPoint>d__12&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000157")]
	public override Task BreakPoint(float duration) { }

	[Address(RVA = "0x107ACF0", Offset = "0x1079EF0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000155")]
	private bool FitsInCurrentFrame(float duration) { }

	[Address(RVA = "0x107AD40", Offset = "0x1079F40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000152")]
	private void ResetLastTime() { }

	[Address(RVA = "0x107AD60", Offset = "0x1079F60", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeBudgetPerFrameDeferAgent), Member = "UpdateTimeBudget", ReturnType = typeof(void))]
	[Token(Token = "0x600014E")]
	public void SetFrameBudget(float newFrameBudget = 0.5) { }

	[Address(RVA = "0x107AD70", Offset = "0x1079F70", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000153")]
	public override bool ShouldDefer() { }

	[Address(RVA = "0x107ADB0", Offset = "0x1079FB0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000154")]
	public override bool ShouldDefer(float duration) { }

	[Address(RVA = "0x107AD40", Offset = "0x1079F40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000151")]
	private void Update() { }

	[Address(RVA = "0x107AE00", Offset = "0x107A000", Length = "0x78")]
	[CalledBy(Type = typeof(TimeBudgetPerFrameDeferAgent), Member = "SetFrameBudget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeBudgetPerFrameDeferAgent), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_targetFrameRate", ReturnType = typeof(int))]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Token(Token = "0x600014F")]
	private void UpdateTimeBudget() { }

}


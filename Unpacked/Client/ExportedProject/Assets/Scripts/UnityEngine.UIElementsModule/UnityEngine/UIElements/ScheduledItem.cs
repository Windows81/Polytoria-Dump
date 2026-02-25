namespace UnityEngine.UIElements;

[Token(Token = "0x20002DA")]
internal abstract class ScheduledItem
{
	[CompilerGenerated]
	[Token(Token = "0x20002DB")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B8E")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1AEC210", Offset = "0x1AEB410", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60013F4")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F5")]
		public <>c() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F6")]
		internal bool <.cctor>b__25_0() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013F7")]
		internal bool <.cctor>b__25_1() { }

	}

	[Token(Token = "0x4000B88")]
	public static readonly Func<Boolean> OnceCondition; //Field offset: 0x0
	[Token(Token = "0x4000B89")]
	public static readonly Func<Boolean> ForeverCondition; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B87")]
	public Func<Boolean> timerUpdateStopCondition; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B8A")]
	private long <startMs>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B8B")]
	private long <delayMs>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B8C")]
	private long <intervalMs>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B8D")]
	private long <endTimeMs>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170003D4")]
	public long delayMs
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E9")]
		 get { } //Length: 5
		[Address(RVA = "0x1AE9DA0", Offset = "0x1AE8FA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EA")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170003D6")]
	public long endTimeMs
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013ED")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170003D5")]
	public long intervalMs
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EB")]
		 get { } //Length: 5
		[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EC")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170003D3")]
	public long startMs
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E7")]
		 get { } //Length: 5
		[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E8")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x1AE9BB0", Offset = "0x1AE8DB0", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60013F3")]
	private static ScheduledItem() { }

	[Address(RVA = "0x1AE9CF0", Offset = "0x1AE8EF0", Length = "0xA6")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013EE")]
	public ScheduledItem() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E9")]
	public long get_delayMs() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013ED")]
	public long get_endTimeMs() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EB")]
	public long get_intervalMs() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E7")]
	public long get_startMs() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F1")]
	internal override void OnItemUnscheduled() { }

	[Token(Token = "0x60013F0")]
	public abstract void PerformTimerUpdate(TimerState state) { }

	[Address(RVA = "0x1AE9B30", Offset = "0x1AE8D30", Length = "0x4B")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = "SendActivation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = "ExecuteLater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement+BaseVisualElementScheduledItem", Member = "OnPanelActivate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Token(Token = "0x60013EF")]
	protected void ResetStartTime() { }

	[Address(RVA = "0x1AE9DA0", Offset = "0x1AE8FA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EA")]
	public void set_delayMs(long value) { }

	[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EC")]
	public void set_intervalMs(long value) { }

	[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E8")]
	public void set_startMs(long value) { }

	[Address(RVA = "0x1AE9B80", Offset = "0x1AE8D80", Length = "0x29")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013F2")]
	public override bool ShouldUnschedule() { }

}


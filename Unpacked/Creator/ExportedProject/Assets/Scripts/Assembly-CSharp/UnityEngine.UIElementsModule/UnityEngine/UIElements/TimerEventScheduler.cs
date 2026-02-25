namespace UnityEngine.UIElements;

[Token(Token = "0x20002DC")]
internal class TimerEventScheduler : IScheduler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B8F")]
	private readonly List<ScheduledItem> m_ScheduledItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B90")]
	private bool m_TransactionMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B91")]
	private readonly List<ScheduledItem> m_ScheduleTransactions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B92")]
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000B93")]
	internal bool disableThrottling; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000B94")]
	private int m_LastUpdatedIndex; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B95")]
	private long frameCount; //Field offset: 0x38

	[Token(Token = "0x170003D7")]
	public override long FrameCount
	{
		[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FC")]
		 get { } //Length: 7
		[Address(RVA = "0x5C0A50", Offset = "0x5BFC50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FD")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x1AEAF60", Offset = "0x1AEA160", Length = "0xF6")]
	[CalledBy(Type = typeof(Panel), Member = "get_timerEventScheduler", ReturnType = typeof(TimerEventScheduler))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60013FF")]
	public TimerEventScheduler() { }

	[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FC")]
	public override long get_FrameCount() { }

	[Address(RVA = "0x1AEA390", Offset = "0x1AE9590", Length = "0xD3")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "get_profilerMarker", ReturnType = typeof(ProfilerMarker))]
	[CalledBy(Type = typeof(TimerEventScheduler), Member = "Unschedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimerEventScheduler), Member = "UpdateScheduledEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013FB")]
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	[Address(RVA = "0x1AEA470", Offset = "0x1AE9670", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013F9")]
	private bool RemovedScheduledItemAt(int index) { }

	[Address(RVA = "0x1AEA4E0", Offset = "0x1AE96E0", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013F8")]
	public override void Schedule(ScheduledItem item) { }

	[Address(RVA = "0x5C0A50", Offset = "0x5BFC50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FD")]
	public void set_FrameCount(long value) { }

	[Address(RVA = "0x1AEA6C0", Offset = "0x1AE98C0", Length = "0x26B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013FA")]
	public override void Unschedule(ScheduledItem item) { }

	[Address(RVA = "0x1AEA930", Offset = "0x1AE9B30", Length = "0x623")]
	[CalledBy(Type = typeof(Panel), Member = "TickSchedulingUpdaters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AD2180")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimerEventScheduler), Member = "PrivateUnSchedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScheduledItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013FE")]
	public override void UpdateScheduledEvents() { }

}


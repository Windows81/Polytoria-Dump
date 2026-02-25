namespace UnityEngine.UIElements;

[Token(Token = "0x20001A4")]
public sealed class EventDispatcher
{
	[CompilerGenerated]
	[Token(Token = "0x20001A7")]
	private sealed class <>c
	{
		[Token(Token = "0x40007CE")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C616A0", Offset = "0x1C608A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C2D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C2E")]
		public <>c() { }

		[Address(RVA = "0x1C61270", Offset = "0x1C60470", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000C2F")]
		internal Queue<EventRecord> <.cctor>b__35_0() { }

	}

	[Token(Token = "0x20001A6")]
	private struct DispatchContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CC")]
		public uint m_GateCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007CD")]
		public Queue<EventRecord> m_Queue; //Field offset: 0x8

	}

	[Token(Token = "0x20001A5")]
	private struct EventRecord
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CA")]
		public EventBase m_Event; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007CB")]
		public BaseVisualElementPanel m_Panel; //Field offset: 0x8

	}

	[Token(Token = "0x40007BD")]
	private static readonly ObjectPool<Queue`1<EventRecord>> k_EventQueuePool; //Field offset: 0x0
	[Token(Token = "0x40007C2")]
	internal const int k_MaxGateDepth = 500; //Field offset: 0x0
	[Token(Token = "0x40007C3")]
	internal const int k_NumberOfEventsWithStackInfo = 10; //Field offset: 0x0
	[Token(Token = "0x40007C4")]
	internal const int k_NumberOfEventsWithEventInfo = 100; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007BC")]
	internal ClickDetector m_ClickDetector; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007BE")]
	private Queue<EventRecord> m_Queue; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007BF")]
	private readonly PointerDispatchState <pointerState>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007C0")]
	private uint m_GateCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40007C1")]
	private uint m_GateDepth; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007C5")]
	private int m_DispatchStackFrame; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007C6")]
	private EventBase m_CurrentEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007C7")]
	private Stack<DispatchContext> m_DispatchContexts; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007C8")]
	private bool m_Immediate; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40007C9")]
	private bool <processingEvents>k__BackingField; //Field offset: 0x49

	[Token(Token = "0x1700022A")]
	private bool dispatchImmediately
	{
		[Address(RVA = "0x1C514D0", Offset = "0x1C506D0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C24")]
		private get { } //Length: 21
	}

	[Token(Token = "0x17000229")]
	internal PointerDispatchState pointerState
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C21")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700022B")]
	private bool processingEvents
	{
		[Address(RVA = "0x347A40", Offset = "0x346C40", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C25")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1C51260", Offset = "0x1C50460", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C2C")]
	private static EventDispatcher() { }

	[Address(RVA = "0x1C51370", Offset = "0x1C50570", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ClickDetector), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerDispatchState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Obsolete("Please use EventDispatcher.CreateDefault().")]
	[Token(Token = "0x6000C23")]
	internal EventDispatcher() { }

	[Address(RVA = "0x1C50410", Offset = "0x1C4F610", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C28")]
	internal void CloseGate() { }

	[Address(RVA = "0x1C50420", Offset = "0x1C4F620", Length = "0x17E")]
	[CalledBy(Type = typeof(RuntimeEventDispatcher), Member = "Create", ReturnType = typeof(EventDispatcher))]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ClickDetector), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerDispatchState), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C22")]
	internal static EventDispatcher CreateDefault() { }

	[Address(RVA = "0x1C505A0", Offset = "0x1C4F7A0", Length = "0x1F2")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C489F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Queue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcher), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C26")]
	internal void Dispatch(EventBase evt, BaseVisualElementPanel panel, DispatchMode dispatchMode) { }

	[Address(RVA = "0x1C514D0", Offset = "0x1C506D0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C24")]
	private bool get_dispatchImmediately() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C21")]
	internal PointerDispatchState get_pointerState() { }

	[Address(RVA = "0x1C507A0", Offset = "0x1C4F9A0", Length = "0x3E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Debug), Member = "LogFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LogType), typeof(LogOption), typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000C27")]
	private bool HandleRecursiveState(EventBase evt) { }

	[Address(RVA = "0x1C50B90", Offset = "0x1C4FD90", Length = "0xDD")]
	[CalledBy(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventDispatcher), Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C48050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C29")]
	internal void OpenGate() { }

	[Address(RVA = "0x1C50F10", Offset = "0x1C50110", Length = "0x34A")]
	[CalledBy(Type = typeof(EventDispatcher), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventDispatcher), Member = "ProcessEventQueue", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EventDispatcher), Member = "OpenGate", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C2B")]
	private void ProcessEvent(EventBase evt, BaseVisualElementPanel panel) { }

	[Address(RVA = "0x1C50C70", Offset = "0x1C4FE70", Length = "0x298")]
	[CalledBy(Type = typeof(EventDispatcher), Member = "OpenGate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Queue`1), Member = "Dequeue", ReturnType = "T")]
	[Calls(Type = typeof(EventDispatcher), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C48210")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C2A")]
	private void ProcessEventQueue() { }

	[Address(RVA = "0x347A40", Offset = "0x346C40", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C25")]
	private void set_processingEvents(bool value) { }

}


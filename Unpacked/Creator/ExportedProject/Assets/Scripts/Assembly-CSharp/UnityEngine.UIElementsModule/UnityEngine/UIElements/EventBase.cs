namespace UnityEngine.UIElements;

[Token(Token = "0x20001BA")]
public abstract class EventBase : IDisposable
{
	[Flags]
	[Token(Token = "0x20001BB")]
	public enum EventPropagation
	{
		None = 0,
		Bubbles = 1,
		TricklesDown = 2,
		SkipDisabledElements = 4,
		BubblesOrTricklesDown = 3,
	}

	[Flags]
	[Token(Token = "0x20001BC")]
	private enum LifeCycleStatus
	{
		None = 0,
		PropagationStopped = 1,
		ImmediatePropagationStopped = 2,
		Dispatching = 4,
		Pooled = 8,
		IMGUIEventIsValid = 16,
		PropagateToIMGUI = 32,
		Dispatched = 64,
		Processed = 128,
		ProcessedByFocusController = 256,
	}

	[Token(Token = "0x40007E1")]
	private static long s_LastTypeId; //Field offset: 0x0
	[Token(Token = "0x40007E3")]
	private static ulong s_NextEventId; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007E2")]
	private readonly int <eventCategories>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007E4")]
	private long <timestamp>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007E5")]
	private ulong <eventId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007E6")]
	private ulong <triggerEventId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007E7")]
	private EventPropagation <propagation>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40007E8")]
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007E9")]
	private VisualElement <elementTarget>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007EA")]
	private PropagationPhase <propagationPhase>k__BackingField; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007EB")]
	private IEventHandler m_CurrentTarget; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007EC")]
	private Event m_ImguiEvent; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007ED")]
	private Vector2 <originalMousePosition>k__BackingField; //Field offset: 0x58

	[Token(Token = "0x17000238")]
	public bool bubbles
	{
		[Address(RVA = "0x1C4C9E0", Offset = "0x1C4BBE0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C89")]
		 get { } //Length: 10
		[Address(RVA = "0x1512E60", Offset = "0x1512060", Length = "0x19")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C8A")]
		 set { } //Length: 25
	}

	[Token(Token = "0x1700023B")]
	internal bool bubblesOrTricklesDown
	{
		[Address(RVA = "0x1C4C9D0", Offset = "0x1C4BBD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C8F")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000241")]
	public internal override IEventHandler currentTarget
	{
		[Address(RVA = "0x19AA880", Offset = "0x19A9A80", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C9B")]
		 get { } //Length: 7
		[Address(RVA = "0x1C4CAD0", Offset = "0x1C4BCD0", Length = "0x161")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointerEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Event), Member = "set_mousePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000C9C")]
		internal set { } //Length: 353
	}

	[Token(Token = "0x17000242")]
	public internal bool dispatch
	{
		[Address(RVA = "0x1C4C9F0", Offset = "0x1C4BBF0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C9D")]
		 get { } //Length: 10
		[Address(RVA = "0x1C4CC40", Offset = "0x1C4BE40", Length = "0x18")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000C9E")]
		internal set { } //Length: 24
	}

	[Token(Token = "0x17000243")]
	private bool dispatched
	{
		[Address(RVA = "0x1C4CA00", Offset = "0x1C4BC00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA0")]
		private get { } //Length: 10
		[Address(RVA = "0x1C4CC60", Offset = "0x1C4BE60", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000CA1")]
		private set { } //Length: 25
	}

	[Token(Token = "0x1700023C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement elementTarget
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C90")]
		internal get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C91")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000232")]
	internal int eventCategories
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C79")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000234")]
	internal ulong eventId
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C7C")]
		internal get { } //Length: 5
		[Address(RVA = "0x1AE9DA0", Offset = "0x1AE8FA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C7D")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000231")]
	public override long eventTypeId
	{
		[Address(RVA = "0x13D70B0", Offset = "0x13D62B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C78")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000248")]
	public Event imguiEvent
	{
		[Address(RVA = "0x1C4CA20", Offset = "0x1C4BC20", Length = "0x10")]
		[CalledBy(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Token(Token = "0x6000CAA")]
		 get { } //Length: 16
		[Address(RVA = "0x1C4CCA0", Offset = "0x1C4BEA0", Length = "0xC7")]
		[CalledBy(Type = typeof(CommandEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
		[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CAB")]
		 set { } //Length: 199
	}

	[Token(Token = "0x17000247")]
	private bool imguiEventIsValid
	{
		[Address(RVA = "0x1C4CA10", Offset = "0x1C4BC10", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA8")]
		private get { } //Length: 10
		[Address(RVA = "0x1C4CC80", Offset = "0x1C4BE80", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000CA9")]
		private set { } //Length: 25
	}

	[Token(Token = "0x1700023F")]
	public private bool isImmediatePropagationStopped
	{
		[Address(RVA = "0x1C4CA30", Offset = "0x1C4BC30", Length = "0xA")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 10
		[Address(RVA = "0x1C4CD70", Offset = "0x1C4BF70", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000C98")]
		private set { } //Length: 25
	}

	[Token(Token = "0x1700023E")]
	public private bool isPropagationStopped
	{
		[Address(RVA = "0x1C4CA40", Offset = "0x1C4BC40", Length = "0xA")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C94")]
		 get { } //Length: 10
		[Address(RVA = "0x1C4CD90", Offset = "0x1C4BF90", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000C95")]
		private set { } //Length: 25
	}

	[Token(Token = "0x17000237")]
	private LifeCycleStatus lifeCycleStatus
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C82")]
		private get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C83")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000249")]
	public private Vector2 originalMousePosition
	{
		[Address(RVA = "0x1C4CA50", Offset = "0x1C4BC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000CAC")]
		 get { } //Length: 19
		[Address(RVA = "0x1C4CDB0", Offset = "0x1C4BFB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CAD")]
		private set { } //Length: 5
	}

	[Token(Token = "0x1700024A")]
	protected bool pooled
	{
		[Address(RVA = "0x1C4CA70", Offset = "0x1C4BC70", Length = "0xA")]
		[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CB2")]
		 get { } //Length: 10
		[Address(RVA = "0x1C4CDC0", Offset = "0x1C4BFC0", Length = "0x19")]
		[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
		[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
		[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Token(Token = "0x6000CB3")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000244")]
	internal bool processed
	{
		[Address(RVA = "0x1C4CA90", Offset = "0x1C4BC90", Length = "0xD")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA2")]
		internal get { } //Length: 13
		[Address(RVA = "0x1C4CE00", Offset = "0x1C4C000", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA3")]
		private set { } //Length: 27
	}

	[Token(Token = "0x17000245")]
	internal bool processedByFocusController
	{
		[Address(RVA = "0x1C4CA80", Offset = "0x1C4BC80", Length = "0xD")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA4")]
		internal get { } //Length: 13
		[Address(RVA = "0x1C4CDE0", Offset = "0x1C4BFE0", Length = "0x1B")]
		[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA5")]
		internal set { } //Length: 27
	}

	[Token(Token = "0x17000246")]
	internal bool propagateToIMGUI
	{
		[Address(RVA = "0x1C4CAA0", Offset = "0x1C4BCA0", Length = "0xA")]
		[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000CA6")]
		internal get { } //Length: 10
		[Address(RVA = "0x1C4CE20", Offset = "0x1C4C020", Length = "0x19")]
		[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000CA7")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x17000236")]
	internal EventPropagation propagation
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C80")]
		internal get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C81")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000240")]
	internal PropagationPhase propagationPhase
	{
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C9A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700023A")]
	internal bool skipDisabledElements
	{
		[Address(RVA = "0x1C4CAB0", Offset = "0x1C4BCB0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C8D")]
		internal get { } //Length: 10
		[Address(RVA = "0x1C4CE40", Offset = "0x1C4C040", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000C8E")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x1700023D")]
	public IEventHandler target
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C92")]
		 get { } //Length: 5
		[Address(RVA = "0x1C4CE60", Offset = "0x1C4C060", Length = "0x83")]
		[CalledBy(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", "UnityEngine.UIElements.PanelEventHandler+PointerEvent"}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000C93")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000233")]
	public private long timestamp
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C7A")]
		 get { } //Length: 5
		[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C7B")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000239")]
	public bool tricklesDown
	{
		[Address(RVA = "0x1C4CAC0", Offset = "0x1C4BCC0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000C8B")]
		 get { } //Length: 10
		[Address(RVA = "0x1512E40", Offset = "0x1512040", Length = "0x19")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C8C")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000235")]
	private ulong triggerEventId
	{
		[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C7E")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x1C4C990", Offset = "0x1C4BB90", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CB0")]
	protected EventBase() { }

	[Address(RVA = "0x1C4C940", Offset = "0x1C4BB40", Length = "0x4D")]
	[CalledBy(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CB1")]
	internal EventBase(EventCategory category) { }

	[Token(Token = "0x6000CB4")]
	internal abstract void Acquire() { }

	[Address(RVA = "0x1C4C6B0", Offset = "0x1C4B8B0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "HandleEventAtTargetAndDefaultPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C48900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C88")]
	internal override void Dispatch(BaseVisualElementPanel panel) { }

	[Token(Token = "0x6000CB5")]
	public abstract void Dispose() { }

	[Address(RVA = "0x1C4C9E0", Offset = "0x1C4BBE0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C89")]
	public bool get_bubbles() { }

	[Address(RVA = "0x1C4C9D0", Offset = "0x1C4BBD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C8F")]
	internal bool get_bubblesOrTricklesDown() { }

	[Address(RVA = "0x19AA880", Offset = "0x19A9A80", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C9B")]
	public override IEventHandler get_currentTarget() { }

	[Address(RVA = "0x1C4C9F0", Offset = "0x1C4BBF0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C9D")]
	public bool get_dispatch() { }

	[Address(RVA = "0x1C4CA00", Offset = "0x1C4BC00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA0")]
	private bool get_dispatched() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C90")]
	internal VisualElement get_elementTarget() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C79")]
	internal int get_eventCategories() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7C")]
	internal ulong get_eventId() { }

	[Address(RVA = "0x13D70B0", Offset = "0x13D62B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C78")]
	public override long get_eventTypeId() { }

	[Address(RVA = "0x1C4CA20", Offset = "0x1C4BC20", Length = "0x10")]
	[CalledBy(Type = typeof(CommandEventBase`1), Member = "get_commandName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Token(Token = "0x6000CAA")]
	public Event get_imguiEvent() { }

	[Address(RVA = "0x1C4CA10", Offset = "0x1C4BC10", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA8")]
	private bool get_imguiEventIsValid() { }

	[Address(RVA = "0x1C4CA30", Offset = "0x1C4BC30", Length = "0xA")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C97")]
	public bool get_isImmediatePropagationStopped() { }

	[Address(RVA = "0x1C4CA40", Offset = "0x1C4BC40", Length = "0xA")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C94")]
	public bool get_isPropagationStopped() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C82")]
	private LifeCycleStatus get_lifeCycleStatus() { }

	[Address(RVA = "0x1C4CA50", Offset = "0x1C4BC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000CAC")]
	public Vector2 get_originalMousePosition() { }

	[Address(RVA = "0x1C4CA70", Offset = "0x1C4BC70", Length = "0xA")]
	[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CB2")]
	protected bool get_pooled() { }

	[Address(RVA = "0x1C4CA90", Offset = "0x1C4BC90", Length = "0xD")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA2")]
	internal bool get_processed() { }

	[Address(RVA = "0x1C4CA80", Offset = "0x1C4BC80", Length = "0xD")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA4")]
	internal bool get_processedByFocusController() { }

	[Address(RVA = "0x1C4CAA0", Offset = "0x1C4BCA0", Length = "0xA")]
	[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA6")]
	internal bool get_propagateToIMGUI() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C80")]
	internal EventPropagation get_propagation() { }

	[Address(RVA = "0x1C4CAB0", Offset = "0x1C4BCB0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C8D")]
	internal bool get_skipDisabledElements() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C92")]
	public IEventHandler get_target() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7A")]
	public long get_timestamp() { }

	[Address(RVA = "0x1C4CAC0", Offset = "0x1C4BCC0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C8B")]
	public bool get_tricklesDown() { }

	[Address(RVA = "0x1C4C700", Offset = "0x1C4B900", Length = "0x7")]
	[CalledBy(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[Token(Token = "0x6000CAE")]
	protected override void Init() { }

	[Address(RVA = "0x1C4C710", Offset = "0x1C4B910", Length = "0x10E")]
	[CalledBy(Type = typeof(EventBase), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CAF")]
	private void LocalInit() { }

	[Address(RVA = "0x1C4C820", Offset = "0x1C4BA20", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C9F")]
	internal void MarkReceivedByDispatcher() { }

	[Address(RVA = "0x1C4C8A0", Offset = "0x1C4BAA0", Length = "0x29")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C87")]
	protected private override void PostDispatch(IPanel panel) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Obsolete("Override PostDispatch(IPanel panel) instead.")]
	[Token(Token = "0x6000C86")]
	protected override void PostDispatch() { }

	[Address(RVA = "0x166F2B0", Offset = "0x166E4B0", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C85")]
	protected private override void PreDispatch(IPanel panel) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Obsolete("Override PreDispatch(IPanel panel) instead.")]
	[Token(Token = "0x6000C84")]
	protected override void PreDispatch() { }

	[Address(RVA = "0x1C4C8D0", Offset = "0x1C4BAD0", Length = "0x43")]
	[CalledBy(Type = typeof(EventBase`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000C77")]
	protected static long RegisterEventType() { }

	[Address(RVA = "0x1512E60", Offset = "0x1512060", Length = "0x19")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C8A")]
	protected void set_bubbles(bool value) { }

	[Address(RVA = "0x1C4CAD0", Offset = "0x1C4BCD0", Length = "0x161")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = "set_mousePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000C9C")]
	internal override void set_currentTarget(IEventHandler value) { }

	[Address(RVA = "0x1C4CC40", Offset = "0x1C4BE40", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C9E")]
	internal void set_dispatch(bool value) { }

	[Address(RVA = "0x1C4CC60", Offset = "0x1C4BE60", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000CA1")]
	private void set_dispatched(bool value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C91")]
	internal void set_elementTarget(VisualElement value) { }

	[Address(RVA = "0x1AE9DA0", Offset = "0x1AE8FA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7D")]
	private void set_eventId(ulong value) { }

	[Address(RVA = "0x1C4CCA0", Offset = "0x1C4BEA0", Length = "0xC7")]
	[CalledBy(Type = typeof(CommandEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(KeyboardEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = "T")]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CAB")]
	protected void set_imguiEvent(Event value) { }

	[Address(RVA = "0x1C4CC80", Offset = "0x1C4BE80", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000CA9")]
	private void set_imguiEventIsValid(bool value) { }

	[Address(RVA = "0x1C4CD70", Offset = "0x1C4BF70", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C98")]
	private void set_isImmediatePropagationStopped(bool value) { }

	[Address(RVA = "0x1C4CD90", Offset = "0x1C4BF90", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C95")]
	private void set_isPropagationStopped(bool value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C83")]
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	[Address(RVA = "0x1C4CDB0", Offset = "0x1C4BFB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CAD")]
	private void set_originalMousePosition(Vector2 value) { }

	[Address(RVA = "0x1C4CDC0", Offset = "0x1C4BFC0", Length = "0x19")]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[CalledBy(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
	[CalledBy(Type = typeof(EventBase`1), Member = "ReleasePooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000CB3")]
	protected void set_pooled(bool value) { }

	[Address(RVA = "0x1C4CE00", Offset = "0x1C4C000", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA3")]
	private void set_processed(bool value) { }

	[Address(RVA = "0x1C4CDE0", Offset = "0x1C4BFE0", Length = "0x1B")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CA5")]
	internal void set_processedByFocusController(bool value) { }

	[Address(RVA = "0x1C4CE20", Offset = "0x1C4C020", Length = "0x19")]
	[CalledBy(Type = typeof(EditorPanelRootElement), Member = "OnEventCompletedAtAnyTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000CA7")]
	internal void set_propagateToIMGUI(bool value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C81")]
	internal void set_propagation(EventPropagation value) { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C9A")]
	internal void set_propagationPhase(PropagationPhase value) { }

	[Address(RVA = "0x1C4CE40", Offset = "0x1C4C040", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C8E")]
	internal void set_skipDisabledElements(bool value) { }

	[Address(RVA = "0x1C4CE60", Offset = "0x1C4C060", Length = "0x83")]
	[CalledBy(Type = typeof(FocusController), Member = "ReleaseFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FocusController), Member = "GrabFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", "UnityEngine.UIElements.PanelEventHandler+PointerEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000C93")]
	public void set_target(IEventHandler value) { }

	[Address(RVA = "0x3785C0", Offset = "0x3777C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7B")]
	private void set_timestamp(long value) { }

	[Address(RVA = "0x1512E40", Offset = "0x1512040", Length = "0x19")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C8C")]
	protected void set_tricklesDown(bool value) { }

	[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7E")]
	private void set_triggerEventId(ulong value) { }

	[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C7F")]
	internal void SetTriggerEventId(ulong id) { }

	[Address(RVA = "0x1C4C920", Offset = "0x1C4BB20", Length = "0xF")]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseField`1), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Tab+<>c", Member = "<.ctor>b__67_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tab), Member = "UpdateTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TabDragger), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitViewResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TooltipEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Token(Token = "0x6000C99")]
	public void StopImmediatePropagation() { }

	[Address(RVA = "0x1C4C930", Offset = "0x1C4BB30", Length = "0x7")]
	[CallerCount(Count = 76)]
	[Token(Token = "0x6000C96")]
	public void StopPropagation() { }

}


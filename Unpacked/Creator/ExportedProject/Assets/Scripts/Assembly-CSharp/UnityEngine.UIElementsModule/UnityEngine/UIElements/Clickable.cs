namespace UnityEngine.UIElements;

[Token(Token = "0x200004E")]
public class Clickable : PointerManipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000177")]
	private Action<EventBase> clickedWithEventInfo; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000178")]
	private Action clicked; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000179")]
	private readonly long m_Delay; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400017A")]
	private readonly long m_Interval; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400017B")]
	private bool <active>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400017C")]
	private Vector2 <lastMousePosition>k__BackingField; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400017D")]
	private int m_ActivePointerId; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400017E")]
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400017F")]
	private IVisualElementScheduledItem m_Repeater; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000180")]
	private IVisualElementScheduledItem m_PendingActivePseudoStateReset; //Field offset: 0x68

	[Token(Token = "0x14000005")]
	public event Action clicked
	{
		[Address(RVA = "0x1AC63F0", Offset = "0x1AC55F0", Length = "0x9E")]
		[CalledBy(Type = typeof(RepeatButton), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000240")]
		 add { } //Length: 158
		[Address(RVA = "0x1AC6570", Offset = "0x1AC5770", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000241")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public event Action<EventBase> clickedWithEventInfo
	{
		[Address(RVA = "0x1AC6340", Offset = "0x1AC5540", Length = "0xAC")]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600023E")]
		 add { } //Length: 172
		[Address(RVA = "0x1AC64C0", Offset = "0x1AC56C0", Length = "0xAC")]
		[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "CleanupColumnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600023F")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x1700004D")]
	internal bool acceptClicksIfDisabled
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000246")]
		internal get { } //Length: 5
		[Address(RVA = "0x1AC6610", Offset = "0x1AC5810", Length = "0x6B")]
		[CalledBy(Type = typeof(RepeatButton), Member = "set_acceptClicksIfDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000247")]
		internal set { } //Length: 107
	}

	[Token(Token = "0x1700004B")]
	protected bool active
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000242")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000243")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004E")]
	private InvokePolicy invokePolicy
	{
		[Address(RVA = "0x1AC6490", Offset = "0x1AC5690", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000248")]
		private get { } //Length: 11
	}

	[Token(Token = "0x1700004C")]
	public private Vector2 lastMousePosition
	{
		[Address(RVA = "0x1AC64A0", Offset = "0x1AC56A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000244")]
		 get { } //Length: 19
		[Address(RVA = "0x1AC6680", Offset = "0x1AC5880", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000245")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x1AC6210", Offset = "0x1AC5410", Length = "0x123")]
	[CalledBy(Type = typeof(Button), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnHeaderColumn), Member = "InitManipulators", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600024B")]
	public Clickable(Action handler) { }

	[Address(RVA = "0x1AC60F0", Offset = "0x1AC52F0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600024A")]
	public Clickable(Action<EventBase> handler) { }

	[Address(RVA = "0x1AC5FB0", Offset = "0x1AC51B0", Length = "0x138")]
	[CalledBy(Type = typeof(ClampedDragger`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseSlider`1<T>", typeof(Action), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RepeatButton), Member = "SetAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000249")]
	public Clickable(Action handler, long delay, long interval) { }

	[Address(RVA = "0x1AC63F0", Offset = "0x1AC55F0", Length = "0x9E")]
	[CalledBy(Type = typeof(RepeatButton), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000240")]
	public void add_clicked(Action value) { }

	[Address(RVA = "0x1AC6340", Offset = "0x1AC5540", Length = "0xAC")]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600023E")]
	public void add_clickedWithEventInfo(Action<EventBase> value) { }

	[Address(RVA = "0x1AC4D40", Offset = "0x1AC3F40", Length = "0x7D")]
	[CalledBy(Type = typeof(Clickable), Member = "OnTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimerState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Clickable), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000255")]
	private bool ContainsPointer(int pointerId) { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000246")]
	internal bool get_acceptClicksIfDisabled() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000242")]
	protected bool get_active() { }

	[Address(RVA = "0x1AC6490", Offset = "0x1AC5690", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000248")]
	private InvokePolicy get_invokePolicy() { }

	[Address(RVA = "0x1AC64A0", Offset = "0x1AC56A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000244")]
	public Vector2 get_lastMousePosition() { }

	[Address(RVA = "0x1AC4DC0", Offset = "0x1AC3FC0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000256")]
	protected void Invoke(EventBase evt) { }

	[Address(RVA = "0x1AC4E10", Offset = "0x1AC4010", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600024D")]
	private bool IsRepeatable() { }

	[Address(RVA = "0x1AC4E30", Offset = "0x1AC4030", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStopManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000253")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x1AC4EB0", Offset = "0x1AC40B0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000254")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x1AC4F20", Offset = "0x1AC4120", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000250")]
	protected void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x1AC4FD0", Offset = "0x1AC41D0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000251")]
	protected void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x1AC5050", Offset = "0x1AC4250", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStopManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000252")]
	protected void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x1AC5100", Offset = "0x1AC4300", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600024C")]
	private void OnTimer(TimerState timerState) { }

	[Address(RVA = "0x1AC5210", Offset = "0x1AC4410", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600025C")]
	protected override void ProcessCancelEvent(EventBase evt, int pointerId) { }

	[Address(RVA = "0x1AC5330", Offset = "0x1AC4530", Length = "0x2DE")]
	[CalledBy(Type = typeof(ClampedDragger`1), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopImmediatePropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000259")]
	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x1AC5610", Offset = "0x1AC4810", Length = "0x89")]
	[CalledBy(Type = typeof(ClampedDragger`1), Member = "ProcessMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600025A")]
	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	[Address(RVA = "0x1AC56A0", Offset = "0x1AC48A0", Length = "0x18F")]
	[CalledBy(Type = typeof(ClampedDragger`1), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_enabledInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600025B")]
	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x1AC5830", Offset = "0x1AC4A30", Length = "0x2C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600024E")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x1AC6570", Offset = "0x1AC5770", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000241")]
	public void remove_clicked(Action value) { }

	[Address(RVA = "0x1AC64C0", Offset = "0x1AC56C0", Length = "0xAC")]
	[CalledBy(Type = typeof(ToggleButtonGroup), Member = "OnButtonGroupContainerElementRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "CleanupColumnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600023F")]
	public void remove_clickedWithEventInfo(Action<EventBase> value) { }

	[Address(RVA = "0x1AC5B00", Offset = "0x1AC4D00", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000258")]
	private void ResetActivePseudoState() { }

	[Address(RVA = "0x1AC6610", Offset = "0x1AC5810", Length = "0x6B")]
	[CalledBy(Type = typeof(RepeatButton), Member = "set_acceptClicksIfDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000247")]
	internal void set_acceptClicksIfDisabled(bool value) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000243")]
	protected void set_active(bool value) { }

	[Address(RVA = "0x1AC6680", Offset = "0x1AC5880", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000245")]
	private void set_lastMousePosition(Vector2 value) { }

	[Address(RVA = "0x1AC5B70", Offset = "0x1AC4D70", Length = "0x173")]
	[CalledBy(Type = typeof(Button), Member = "OnNavigationSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationSubmitEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000257")]
	internal void SimulateSingleClick(EventBase evt, int delayMs = 100) { }

	[Address(RVA = "0x1AC5CF0", Offset = "0x1AC4EF0", Length = "0x2BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "set_pseudoStates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PseudoStates)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Token(Token = "0x600024F")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}


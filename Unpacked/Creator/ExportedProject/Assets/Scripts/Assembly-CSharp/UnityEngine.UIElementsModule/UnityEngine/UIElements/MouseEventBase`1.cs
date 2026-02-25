namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
[Token(Token = "0x20001E6")]
public abstract class MouseEventBase : EventBase<T>, IMouseEvent, IMouseEventInternal, IPointerOrMouseEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000840")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000841")]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000842")]
	private Vector2 <localMousePosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000843")]
	private Vector2 <mouseDelta>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000844")]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000845")]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000846")]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000847")]
	private IPointerEvent <sourcePointerEvent>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000848")]
	private bool <recomputeTopElementUnderMouse>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000271")]
	public override int button
	{
		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA2")]
		 get { } //Length: 7
		[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA3")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000270")]
	public override int clickCount
	{
		[Address(RVA = "0xE0C200", Offset = "0xE0B400", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA0")]
		 get { } //Length: 7
		[Address(RVA = "0xE0C2C0", Offset = "0xE0B4C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA1")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000278")]
	public internal virtual IEventHandler currentTarget
	{
		[Address(RVA = "0xE0C210", Offset = "0xE0B410", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DAF")]
		 get { } //Length: 25
		[Address(RVA = "0xE0C2D0", Offset = "0xE0B4D0", Length = "0x109")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(EventBase), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DB0")]
		internal set { } //Length: 265
	}

	[Token(Token = "0x1700026E")]
	public internal override Vector2 localMousePosition
	{
		[Address(RVA = "0xE0C230", Offset = "0xE0B430", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D9C")]
		 get { } //Length: 19
		[Address(RVA = "0xE0C3E0", Offset = "0xE0B5E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D9D")]
		internal set { } //Length: 5
	}

	[Token(Token = "0x1700026C")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D98")]
		 get { } //Length: 4
		[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D99")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700026F")]
	public override Vector2 mouseDelta
	{
		[Address(RVA = "0xE0C250", Offset = "0xE0B450", Length = "0x16")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D9E")]
		 get { } //Length: 22
		[Address(RVA = "0xE0C3F0", Offset = "0xE0B5F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D9F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700026D")]
	public override Vector2 mousePosition
	{
		[Address(RVA = "0xE0C270", Offset = "0xE0B470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D9A")]
		 get { } //Length: 19
		[Address(RVA = "0xE0C400", Offset = "0xE0B600", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D9B")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000272")]
	public override int pressedButtons
	{
		[Address(RVA = "0xE0C290", Offset = "0xE0B490", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA4")]
		 get { } //Length: 7
		[Address(RVA = "0xE0C410", Offset = "0xE0B610", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA5")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000274")]
	internal bool recomputeTopElementUnderMouse
	{
		[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA8")]
		internal get { } //Length: 8
		[Address(RVA = "0xE0C420", Offset = "0xE0B620", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA9")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000273")]
	internal IPointerEvent sourcePointerEvent
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA6")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DA7")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000275")]
	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DAA")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000277")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.deltaPosition
	{
		[Address(RVA = "0xE0C150", Offset = "0xE0B350", Length = "0x21")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DAC")]
		private set { } //Length: 33
	}

	[Token(Token = "0x17000276")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.position
	{
		[Address(RVA = "0xE0C130", Offset = "0xE0B330", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DAB")]
		private get { } //Length: 29
	}

	[Address(RVA = "0xE0C180", Offset = "0xE0B380", Length = "0x7F")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D8AA0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB8")]
	protected MouseEventBase`1() { }

	[Address(RVA = "0xE0AF00", Offset = "0xE0A100", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToCapturingElementOrElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB3")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA2")]
	public override int get_button() { }

	[Address(RVA = "0xE0C200", Offset = "0xE0B400", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA0")]
	public override int get_clickCount() { }

	[Address(RVA = "0xE0C210", Offset = "0xE0B410", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAF")]
	public virtual IEventHandler get_currentTarget() { }

	[Address(RVA = "0xE0C230", Offset = "0xE0B430", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D9C")]
	public override Vector2 get_localMousePosition() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D98")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xE0C250", Offset = "0xE0B450", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D9E")]
	public override Vector2 get_mouseDelta() { }

	[Address(RVA = "0xE0C270", Offset = "0xE0B470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D9A")]
	public override Vector2 get_mousePosition() { }

	[Address(RVA = "0xE0C290", Offset = "0xE0B490", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA4")]
	public override int get_pressedButtons() { }

	[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA8")]
	internal bool get_recomputeTopElementUnderMouse() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA6")]
	internal IPointerEvent get_sourcePointerEvent() { }

	[Address(RVA = "0xE0AF90", Offset = "0xE0A190", Length = "0x4C2")]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "GetPooledCompatibilityMouseEvent", ReturnType = typeof(IMouseEvent))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "GetPooledCompatibilityMouseEvent", ReturnType = typeof(IMouseEvent))]
	[CalledBy(Type = typeof(PointerMoveEvent), Member = "GetPooledCompatibilityMouseEvent", ReturnType = typeof(IMouseEvent))]
	[CalledBy(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(IPointerEvent)}, ReturnType = typeof(WheelEvent))]
	[CalledBy(Type = typeof(MouseMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(MouseMoveEvent))]
	[CalledBy(Type = typeof(MouseUpEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCancelEvent)}, ReturnType = typeof(MouseUpEvent))]
	[CalledBy(Type = typeof(MouseUpEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(MouseUpEvent))]
	[CalledBy(Type = typeof(PointerDownEvent), Member = "GetPooledCompatibilityMouseEvent", ReturnType = typeof(IMouseEvent))]
	[CalledBy(Type = typeof(MouseUpEvent), Member = "MakeFromPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(MouseUpEvent))]
	[CalledBy(Type = typeof(MouseDownEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(MouseDownEvent))]
	[CalledBy(Type = typeof(MouseDownEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(MouseDownEvent))]
	[CalledBy(Type = typeof(MouseDownEvent), Member = "MakeFromPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(MouseDownEvent))]
	[CalledBy(Type = typeof(MouseUpEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(MouseUpEvent))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(EventBase), Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB7")]
	protected static T GetPooled(IPointerEvent pointerEvent) { }

	[Address(RVA = "0xE0B460", Offset = "0xE0A660", Length = "0x25E")]
	[CalledBy(Type = typeof(WheelEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(WheelEvent))]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(MouseLeaveWindowEvent))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPressedButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Event), Member = "get_button", ReturnType = typeof(int))]
	[Calls(Type = typeof(Event), Member = "get_delta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(Event), Member = "get_clickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB4")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0xE0B800", Offset = "0xE0AA00", Length = "0x2A9")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMouseEvent), typeof(Vector2)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB6")]
	public static T GetPooled(IMouseEvent triggerEvent) { }

	[Address(RVA = "0xE0B6C0", Offset = "0xE0A8C0", Length = "0x131")]
	[CalledBy(Type = typeof(MouseEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IMouseEvent), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEventsHelper), Member = "SendMouseOverMouseOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IMouseEvent), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(MouseEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMouseEvent)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB5")]
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition) { }

	[Address(RVA = "0xE0BAB0", Offset = "0xE0ACB0", Length = "0x4F")]
	[CalledBy(Type = typeof(MouseEnterEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseDownEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseUpEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseMoveEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextClickEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WheelEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseEnterWindowEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D8AA0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAD")]
	protected virtual void Init() { }

	[Address(RVA = "0xE0BB00", Offset = "0xE0AD00", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAE")]
	private void LocalInit() { }

	[Address(RVA = "0xE0BC20", Offset = "0xE0AE20", Length = "0x194")]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuPopulateEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase), Member = "set_processedByFocusController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_processedByFocusController", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopImmediatePropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "get_isImmediatePropagationStopped", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "get_processed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "get_isPropagationStopped", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB2")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xE0BDC0", Offset = "0xE0AFC0", Length = "0x360")]
	[CalledBy(Type = typeof(MouseOverEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseOutEvent), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "SavePointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector3), typeof(IPanel), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB1")]
	protected private virtual void PreDispatch(IPanel panel) { }

	[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA3")]
	protected void set_button(int value) { }

	[Address(RVA = "0xE0C2C0", Offset = "0xE0B4C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA1")]
	protected void set_clickCount(int value) { }

	[Address(RVA = "0xE0C2D0", Offset = "0xE0B4D0", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DB0")]
	internal virtual void set_currentTarget(IEventHandler value) { }

	[Address(RVA = "0xE0C3E0", Offset = "0xE0B5E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D9D")]
	internal void set_localMousePosition(Vector2 value) { }

	[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D99")]
	protected void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0xE0C3F0", Offset = "0xE0B5F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D9F")]
	protected void set_mouseDelta(Vector2 value) { }

	[Address(RVA = "0xE0C400", Offset = "0xE0B600", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D9B")]
	protected void set_mousePosition(Vector2 value) { }

	[Address(RVA = "0xE0C410", Offset = "0xE0B610", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA5")]
	protected void set_pressedButtons(int value) { }

	[Address(RVA = "0xE0C420", Offset = "0xE0B620", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA9")]
	internal void set_recomputeTopElementUnderMouse(bool value) { }

	[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DA7")]
	internal void set_sourcePointerEvent(IPointerEvent value) { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAA")]
	private override IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	[Address(RVA = "0xE0C130", Offset = "0xE0B330", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAB")]
	private override Vector3 UnityEngine.UIElements.IPointerOrMouseEvent.get_position() { }

	[Address(RVA = "0xE0C150", Offset = "0xE0B350", Length = "0x21")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DAC")]
	private override void UnityEngine.UIElements.IPointerOrMouseEvent.set_deltaPosition(Vector3 value) { }

}


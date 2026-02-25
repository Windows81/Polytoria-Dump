namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Navigation (14))]
[Token(Token = "0x2000203")]
public abstract class NavigationEventBase : EventBase<T>, INavigationEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400085D")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400085E")]
	private NavigationDeviceType <deviceType>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000280")]
	public override bool altKey
	{
		[Address(RVA = "0xCE3F50", Offset = "0xCE3150", Length = "0xA")]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E30")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000281")]
	internal NavigationDeviceType deviceType
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E31")]
		internal get { } //Length: 4
		[Address(RVA = "0x96AC70", Offset = "0x969E70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E32")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700027E")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2D")]
		 get { } //Length: 4
		[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700027F")]
	public override bool shiftKey
	{
		[Address(RVA = "0xCE3FB0", Offset = "0xCE31B0", Length = "0xA")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E2F")]
		 get { } //Length: 10
	}

	[Address(RVA = "0xE25EA0", Offset = "0xE250A0", Length = "0x7A")]
	[CalledBy(Type = "UnityEngine.UIElements.NavigationMoveEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigationCancelEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(NavigationCancelEvent))]
	[CalledBy(Type = typeof(NavigationCancelEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.NavigationSubmitEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(NavigationSubmitEvent))]
	[CalledBy(Type = typeof(NavigationSubmitEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E33")]
	protected NavigationEventBase`1() { }

	[Address(RVA = "0x96FF50", Offset = "0x96F150", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E37")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xCE3F50", Offset = "0xCE3150", Length = "0xA")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E30")]
	public override bool get_altKey() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E31")]
	internal NavigationDeviceType get_deviceType() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2D")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xCE3FB0", Offset = "0xCE31B0", Length = "0xA")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2F")]
	public override bool get_shiftKey() { }

	[Address(RVA = "0xE25D50", Offset = "0xE24F50", Length = "0xD1")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Direction), typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = typeof(NavigationMoveEvent))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendInputEvents>b__30_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendInputEvents>b__30_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E36")]
	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[Address(RVA = "0xE25E30", Offset = "0xE25030", Length = "0x3A")]
	[CalledBy(Type = typeof(NavigationMoveEvent), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E34")]
	protected virtual void Init() { }

	[Address(RVA = "0xE25E70", Offset = "0xE25070", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E35")]
	private void LocalInit() { }

	[Address(RVA = "0x96AC70", Offset = "0x969E70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E32")]
	private void set_deviceType(NavigationDeviceType value) { }

	[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E2E")]
	protected void set_modifiers(EventModifiers value) { }

}


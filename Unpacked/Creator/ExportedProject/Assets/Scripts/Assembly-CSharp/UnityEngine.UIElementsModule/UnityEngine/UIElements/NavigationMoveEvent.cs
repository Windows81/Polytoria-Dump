namespace UnityEngine.UIElements;

[Token(Token = "0x2000204")]
public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000206")]
	private sealed class <>c
	{
		[Token(Token = "0x4000869")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1C61E80", Offset = "0x1C61080", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000E44")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E45")]
		public <>c() { }

		[Address(RVA = "0x1C602F0", Offset = "0x1C5F4F0", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NavigationEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000E46")]
		internal NavigationMoveEvent <.cctor>b__0_0() { }

	}

	[Token(Token = "0x2000205")]
	internal enum Direction
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4,
		Next = 5,
		Previous = 6,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400085F")]
	private Direction <direction>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000860")]
	private Vector2 <move>k__BackingField; //Field offset: 0x74

	[Token(Token = "0x17000282")]
	public private Direction direction
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3A")]
		 get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000283")]
	private Vector2 move
	{
		[Address(RVA = "0xE0C3E0", Offset = "0xE0B5E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E3C")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x1C58D00", Offset = "0x1C57F00", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E38")]
	private static NavigationMoveEvent() { }

	[Address(RVA = "0x1C58DE0", Offset = "0x1C57FE0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000E41")]
	public NavigationMoveEvent() { }

	[Address(RVA = "0x1C58890", Offset = "0x1C57A90", Length = "0x7F")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ShouldSendMoveFromInput", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000E39")]
	internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6) { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3A")]
	public Direction get_direction() { }

	[Address(RVA = "0x1C58A60", Offset = "0x1C57C60", Length = "0xF6")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.Vector2, UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendInputEvents>b__30_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LegacyInputProcessor)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E3D")]
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x1C58910", Offset = "0x1C57B10", Length = "0x95")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E3E")]
	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x1C589B0", Offset = "0x1C57BB0", Length = "0xA2")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessNavigationEvent>b__10_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.UIElements.NavigationMoveEvent+Direction, UnityEngine.UIElements.NavigationDeviceType, UnityEngine.EventModifiers>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTabEvent>b__39_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`3<UnityEngine.UIElements.NavigationMoveEvent+Direction, UnityEngine.EventModifiers, UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+IInput>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavigationDeviceType), typeof(EventModifiers)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E3F")]
	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	[Address(RVA = "0x1C58B60", Offset = "0x1C57D60", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavigationEventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Token(Token = "0x6000E40")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C58BE0", Offset = "0x1C57DE0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000E42")]
	private void LocalInit() { }

	[Address(RVA = "0x1C58C40", Offset = "0x1C57E40", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(FocusController), Member = "GetLeafFocusedElement", ReturnType = typeof(Focusable))]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocusOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E43")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3B")]
	private void set_direction(Direction value) { }

	[Address(RVA = "0xE0C3E0", Offset = "0xE0B5E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E3C")]
	private void set_move(Vector2 value) { }

}


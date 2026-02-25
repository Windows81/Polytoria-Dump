namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Keyboard (6))]
[Token(Token = "0x20001DC")]
public abstract class KeyboardEventBase : EventBase<T>, IKeyboardEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000837")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000838")]
	private char <character>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000839")]
	private KeyCode <keyCode>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000260")]
	public override bool actionKey
	{
		[Address(RVA = "0xCE3EC0", Offset = "0xCE30C0", Length = "0x84")]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardNavigationManipulator), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardNavigationManipulator), Member = "<OnKeyDown>g__GetOperation|4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass4_0&)}, ReturnType = typeof(KeyboardNavigationOperation))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D6C")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700025E")]
	public override bool altKey
	{
		[Address(RVA = "0xCE3F50", Offset = "0xCE3150", Length = "0xA")]
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D6A")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000259")]
	public override char character
	{
		[Address(RVA = "0xCE3F60", Offset = "0xCE3160", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D63")]
		 get { } //Length: 5
		[Address(RVA = "0xCE3FC0", Offset = "0xCE31C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D64")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700025D")]
	public override bool commandKey
	{
		[Address(RVA = "0xCE3F70", Offset = "0xCE3170", Length = "0xA")]
		[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D69")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700025C")]
	public override bool ctrlKey
	{
		[Address(RVA = "0xCE3F80", Offset = "0xCE3180", Length = "0xA")]
		[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D68")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700025F")]
	internal bool functionKey
	{
		[Address(RVA = "0xCE3F90", Offset = "0xCE3190", Length = "0xA")]
		[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D6B")]
		internal get { } //Length: 10
	}

	[Token(Token = "0x1700025A")]
	public override KeyCode keyCode
	{
		[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D65")]
		 get { } //Length: 4
		[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D66")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000258")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D61")]
		 get { } //Length: 4
		[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D62")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700025B")]
	public override bool shiftKey
	{
		[Address(RVA = "0xCE3FB0", Offset = "0xCE31B0", Length = "0xA")]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D67")]
		 get { } //Length: 10
	}

	[Address(RVA = "0xCE3E30", Offset = "0xCE3030", Length = "0x80")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(KeyDownEvent))]
	[CalledBy(Type = typeof(KeyDownEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyUpEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(KeyUpEvent))]
	[CalledBy(Type = typeof(KeyUpEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D72")]
	protected KeyboardEventBase`1() { }

	[Address(RVA = "0x96FF50", Offset = "0x96F150", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D71")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xCE3EC0", Offset = "0xCE30C0", Length = "0x84")]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardNavigationManipulator), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardNavigationManipulator), Member = "<OnKeyDown>g__GetOperation|4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass4_0&)}, ReturnType = typeof(KeyboardNavigationOperation))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6C")]
	public override bool get_actionKey() { }

	[Address(RVA = "0xCE3F50", Offset = "0xCE3150", Length = "0xA")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6A")]
	public override bool get_altKey() { }

	[Address(RVA = "0xCE3F60", Offset = "0xCE3160", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D63")]
	public override char get_character() { }

	[Address(RVA = "0xCE3F70", Offset = "0xCE3170", Length = "0xA")]
	[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D69")]
	public override bool get_commandKey() { }

	[Address(RVA = "0xCE3F80", Offset = "0xCE3180", Length = "0xA")]
	[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D68")]
	public override bool get_ctrlKey() { }

	[Address(RVA = "0xCE3F90", Offset = "0xCE3190", Length = "0xA")]
	[CalledBy(Type = typeof(KeyDownEvent), Member = "SendEquivalentNavigationEventIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardEventExtensions), Member = "ShouldSendNavigationMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6B")]
	internal bool get_functionKey() { }

	[Address(RVA = "0xCE3FA0", Offset = "0xCE31A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D65")]
	public override KeyCode get_keyCode() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D61")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xCE3FB0", Offset = "0xCE31B0", Length = "0xA")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D67")]
	public override bool get_shiftKey() { }

	[Address(RVA = "0xCE3B80", Offset = "0xCE2D80", Length = "0xF9")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessKeyEvent>b__11_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.EventModifiers, UnityEngine.KeyCode>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessKeyEvent>b__11_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.EventModifiers, UnityEngine.KeyCode>)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor+<>c", Member = "<ProcessTextInputEvent>b__12_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<UnityEngine.EventModifiers, System.Char>)}, ReturnType = typeof(EventBase))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6F")]
	public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers) { }

	[Address(RVA = "0xCE3C80", Offset = "0xCE2E80", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D70")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0xCE3DB0", Offset = "0xCE2FB0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6D")]
	protected virtual void Init() { }

	[Address(RVA = "0xCE3E00", Offset = "0xCE3000", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6E")]
	private void LocalInit() { }

	[Address(RVA = "0xCE3FC0", Offset = "0xCE31C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D64")]
	protected void set_character(char value) { }

	[Address(RVA = "0xCE3FD0", Offset = "0xCE31D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D66")]
	protected void set_keyCode(KeyCode value) { }

	[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D62")]
	protected void set_modifiers(EventModifiers value) { }

}


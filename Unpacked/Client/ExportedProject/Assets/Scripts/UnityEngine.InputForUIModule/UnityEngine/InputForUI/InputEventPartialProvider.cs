namespace UnityEngine.InputForUI;

[Token(Token = "0x2000023")]
internal class InputEventPartialProvider : IEventProviderImpl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B5")]
	private Event _ev; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B6")]
	private OperatingSystemFamily _operatingSystemFamily; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000B7")]
	private ButtonsState _keyboardButtonsState; //Field offset: 0x1C
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000B8")]
	internal EventModifiers _eventModifiers; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000B9")]
	internal bool _sendNavigationEventOnTabKey; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000BA")]
	private IDictionary<String, Command> _IMGUICommandToInputForUICommandType; //Field offset: 0x50

	[Address(RVA = "0x19D3330", Offset = "0x19D2530", Length = "0x462")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008D")]
	public InputEventPartialProvider() { }

	[Address(RVA = "0x19D2600", Offset = "0x19D1800", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Token(Token = "0x6000087")]
	private DiscreteTime GetTimestamp(in Event ev) { }

	[Address(RVA = "0x19D2630", Offset = "0x19D1830", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	public override void Initialize() { }

	[Address(RVA = "0x19D2660", Offset = "0x19D1860", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000086")]
	public override void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x19D2680", Offset = "0x19D1880", Length = "0x1B0")]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600008B")]
	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in Event ev) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000084")]
	public override void Shutdown() { }

	[Address(RVA = "0x19D2840", Offset = "0x19D1A40", Length = "0x205")]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008C")]
	private CommandEvent ToCommandEvent(in Event ev) { }

	[Address(RVA = "0x19D2A50", Offset = "0x19D1C50", Length = "0x1EF")]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000089")]
	private KeyEvent ToKeyEvent(in Event ev) { }

	[Address(RVA = "0x19D2C40", Offset = "0x19D1E40", Length = "0xA0")]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Time), Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[Calls(Type = typeof(RationalTime), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RationalTime)}, ReturnType = typeof(DiscreteTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600008A")]
	private TextInputEvent ToTextInputEvent(in Event ev) { }

	[Address(RVA = "0x19D2FF0", Offset = "0x19D21F0", Length = "0x333")]
	[CalledBy(Type = typeof(InputManagerProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(TextInputEvent))]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventProvider), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(KeyEvent))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(CommandEvent))]
	[Calls(Type = typeof(InputEventPartialProvider), Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "GetEventAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "GetEventCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Token(Token = "0x6000085")]
	public override void Update() { }

	[Address(RVA = "0x19D2CF0", Offset = "0x19D1EF0", Length = "0x2D0")]
	[CalledBy(Type = typeof(InputEventPartialProvider), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_isKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_command", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_capsLock", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_functionKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_numeric", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_shift", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_control", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_alt", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000088")]
	private void UpdateEventModifiers(in Event ev) { }

}


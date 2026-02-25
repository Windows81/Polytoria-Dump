namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Command (15))]
[Token(Token = "0x20001B4")]
public abstract class CommandEventBase : EventBase<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007D8")]
	private string m_CommandName; //Field offset: 0x0

	[Token(Token = "0x17000230")]
	public override string commandName
	{
		[Address(RVA = "0x9701E0", Offset = "0x96F3E0", Length = "0x49")]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
		[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C5B")]
		 get { } //Length: 73
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C5C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x970150", Offset = "0x96F350", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.UIElements.ValidateCommandEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(ValidateCommandEvent))]
	[CalledBy(Type = typeof(ValidateCommandEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ExecuteCommandEvent+<>c", Member = "<.cctor>b__0_0", ReturnType = typeof(ExecuteCommandEvent))]
	[CalledBy(Type = typeof(ExecuteCommandEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C62")]
	protected CommandEventBase`1() { }

	[Address(RVA = "0x96FF50", Offset = "0x96F150", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "DispatchToFocusedElementOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C61")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x9701E0", Offset = "0x96F3E0", Length = "0x49")]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnValidateCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidateCommandEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingManipulator), Member = "OnExecuteCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecuteCommandEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5B")]
	public override string get_commandName() { }

	[Address(RVA = "0x970020", Offset = "0x96F220", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(EventBase), Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5F")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0x96FF60", Offset = "0x96F160", Length = "0xBE")]
	[CalledBy(Type = typeof(TextElement), Member = "ProcessMenuCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventBase`1), Member = "GetPooled", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C60")]
	public static T GetPooled(string commandName) { }

	[Address(RVA = "0x9700D0", Offset = "0x96F2D0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5D")]
	protected virtual void Init() { }

	[Address(RVA = "0x970120", Offset = "0x96F320", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5E")]
	private void LocalInit() { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C5C")]
	protected void set_commandName(string value) { }

}


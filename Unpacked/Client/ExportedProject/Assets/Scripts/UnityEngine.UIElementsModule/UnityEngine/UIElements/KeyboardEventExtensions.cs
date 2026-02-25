namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20001DF")]
internal static class KeyboardEventExtensions
{

	[Address(RVA = "0x1C54980", Offset = "0x1C53B80", Length = "0xBD")]
	[CalledBy(Type = typeof(KeyboardTextEditorEventHandler), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_ctrlKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_commandKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyboardEventBase`1), Member = "get_functionKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000D7B")]
	internal static bool ShouldSendNavigationMoveEvent(KeyDownEvent e) { }

	[Address(RVA = "0x1C54930", Offset = "0x1C53B30", Length = "0x43")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000D7C")]
	internal static bool ShouldSendNavigationMoveEventRuntime(Event e) { }

}


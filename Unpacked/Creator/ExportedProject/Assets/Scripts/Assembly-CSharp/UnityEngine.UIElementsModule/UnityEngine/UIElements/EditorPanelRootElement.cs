namespace UnityEngine.UIElements;

[Token(Token = "0x20002B6")]
internal class EditorPanelRootElement : PanelRootElement
{

	[Address(RVA = "0x1C81410", Offset = "0x1C80610", Length = "0x1E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60012EB")]
	public EditorPanelRootElement() { }

	[Address(RVA = "0x1C813C0", Offset = "0x1C805C0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase), Member = "get_propagateToIMGUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "set_propagateToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012EC")]
	private void OnEventCompletedAtAnyTarget(EventBase evt) { }

}


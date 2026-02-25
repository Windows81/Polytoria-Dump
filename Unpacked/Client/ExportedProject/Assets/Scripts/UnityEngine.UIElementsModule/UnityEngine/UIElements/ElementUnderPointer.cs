namespace UnityEngine.UIElements;

[Token(Token = "0x20001B9")]
internal class ElementUnderPointer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007DB")]
	private VisualElement[] m_PendingTopElementUnderPointer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007DC")]
	private VisualElement[] m_TopElementUnderPointer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007DD")]
	private IPointerOrMouseEvent[] m_TriggerEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007DE")]
	private Vector2[] m_PickingPointerPositions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007DF")]
	private readonly Boolean[] m_IsPrimaryPointer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007E0")]
	private Boolean[] m_IsPickingPointerTemporaries; //Field offset: 0x38

	[Address(RVA = "0x1C4C2D0", Offset = "0x1C4B4D0", Length = "0x274")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C6D")]
	public ElementUnderPointer() { }

	[Address(RVA = "0x1C4B6C0", Offset = "0x1C4A8C0", Length = "0x50D")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "CommitElementUnderPointers", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PointerEventsHelper), Member = "SendOverOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(EventDispatcher), Member = "OpenGate", ReturnType = typeof(void))]
	[Calls(Type = typeof(MouseEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IMouseEvent), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MouseEventsHelper), Member = "SendMouseOverMouseOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IMouseEvent), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventsHelper), Member = "SendEnterLeave", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TLeaveEvent", "TEnterEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(IPointerEvent), typeof(Vector2), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C76")]
	internal bool CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	[Address(RVA = "0x1C4BBD0", Offset = "0x1C4ADD0", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Token(Token = "0x6000C72")]
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	[Address(RVA = "0x1C4BCD0", Offset = "0x1C4AED0", Length = "0x6E")]
	[CalledBy(Type = typeof(Panel), Member = "Pick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C6E")]
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	[Address(RVA = "0xC33EA0", Offset = "0xC330A0", Length = "0x2B")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C6F")]
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	[Address(RVA = "0x1C4BD40", Offset = "0x1C4AF40", Length = "0xA3")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "RemoveElementFromPointerCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C70")]
	internal void RemoveElementUnderPointer(VisualElement elementToRemove) { }

	[Address(RVA = "0x1C4C130", Offset = "0x1C4B330", Length = "0x171")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "UpdateElementUnderPointers", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000C71")]
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	[Address(RVA = "0x1C4C110", Offset = "0x1C4B310", Length = "0x1C")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "RecomputeTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2), typeof(EventBase)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C74")]
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	[Address(RVA = "0x1C4BDF0", Offset = "0x1C4AFF0", Length = "0x31C")]
	[CalledBy(Type = typeof(ElementUnderPointer), Member = "RemoveElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementUnderPointer), Member = "SetTemporaryElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x6000C75")]
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	[Address(RVA = "0x1C4C2B0", Offset = "0x1C4B4B0", Length = "0x1C")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "ClearCachedElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C73")]
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

}


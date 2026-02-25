namespace UnityEngine.UIElements;

[Token(Token = "0x200006F")]
public class ContextualMenuManipulator : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000213")]
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder; //Field offset: 0x28

	[Address(RVA = "0x1AC7E70", Offset = "0x1AC7070", Length = "0x1B5")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003F5")]
	public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder) { }

	[Address(RVA = "0x1AC7180", Offset = "0x1AC6380", Length = "0xFC")]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerDownEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerUpEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "OnPointerMoveEventOSX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContextualMenuManipulator), Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextualMenuManager), Member = "DisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(IEventHandler), typeof(DropdownMenu)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000400")]
	private void DoDisplayMenu(EventBase evt) { }

	[Address(RVA = "0x1AC7280", Offset = "0x1AC6480", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Token(Token = "0x60003F8")]
	protected bool IsOSXContextualMenuPlatform() { }

	[Address(RVA = "0x195F0C0", Offset = "0x195E2C0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000401")]
	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }

	[Address(RVA = "0x1AC72C0", Offset = "0x1AC64C0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FF")]
	private void OnKeyUpEvent(KeyUpEvent evt) { }

	[Address(RVA = "0x1AC7320", Offset = "0x1AC6520", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003FA")]
	private void OnPointerDownEventOSX(IPointerEvent evt) { }

	[Address(RVA = "0x1AC75A0", Offset = "0x1AC67A0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerMoveEvent), Member = "get_isPointerUp", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003FC")]
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	[Address(RVA = "0x1AC7420", Offset = "0x1AC6620", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerMoveEvent), Member = "get_isPointerUp", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerMoveEvent), Member = "get_isPointerDown", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60003FD")]
	private void OnPointerMoveEventOSX(PointerMoveEvent evt) { }

	[Address(RVA = "0x1AC7750", Offset = "0x1AC6950", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003F9")]
	private void OnPointerUpEvent(IPointerEvent evt) { }

	[Address(RVA = "0x1AC7650", Offset = "0x1AC6850", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003FB")]
	private void OnPointerUpEventOSX(IPointerEvent evt) { }

	[Address(RVA = "0x1AC7750", Offset = "0x1AC6950", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerManipulator), Member = "CanStartManipulation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = "DoDisplayMenu", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60003FE")]
	private void ProcessPointerEvent(IPointerEvent evt) { }

	[Address(RVA = "0x1AC77F0", Offset = "0x1AC69F0", Length = "0x335")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Token(Token = "0x60003F6")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x1AC7B30", Offset = "0x1AC6D30", Length = "0x335")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsUtility), Member = "get_isOSXContextualMenuPlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Token(Token = "0x60003F7")]
	protected virtual void UnregisterCallbacksFromTarget() { }

}


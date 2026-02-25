namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Touch Input Module")]
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
[Token(Token = "0x20000C5")]
public class TouchInputModule : PointerInputModule
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400035E")]
	private Vector2 m_LastMousePosition; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400035F")]
	private Vector2 m_MousePosition; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000360")]
	private PointerEventData m_InputPointerEvent; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	[SerializeField]
	[Token(Token = "0x4000361")]
	private bool m_ForceModuleActive; //Field offset: 0x80

	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	[Token(Token = "0x170001FC")]
	public bool allowActivationOnStandalone
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600076E")]
		 get { } //Length: 8
		[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600076F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001FD")]
	public bool forceModuleActive
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000770")]
		 get { } //Length: 8
		[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000771")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x1CF29D0", Offset = "0x1CF1BD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600076D")]
	protected TouchInputModule() { }

	[Address(RVA = "0x1CEE1B0", Offset = "0x1CED3B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600077A")]
	public virtual void DeactivateModule() { }

	[Address(RVA = "0x1CF1230", Offset = "0x1CF0430", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputButton)}, ReturnType = typeof(ButtonState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000777")]
	private void FakeTouches() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600076E")]
	public bool get_allowActivationOnStandalone() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000770")]
	public bool get_forceModuleActive() { }

	[Address(RVA = "0x1CF13A0", Offset = "0x1CF05A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000773")]
	public virtual bool IsModuleSupported() { }

	[Address(RVA = "0x1CF2290", Offset = "0x1CF1490", Length = "0x1B1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputButton)}, ReturnType = typeof(ButtonState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000776")]
	public virtual void Process() { }

	[Address(RVA = "0x1CF13F0", Offset = "0x1CF05F0", Length = "0x79A")]
	[CalledBy(Type = typeof(TouchInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEB10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3F90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEBB0")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE9D0")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA70")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(PointerEventData))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000778")]
	private void ProcessTouchEvents() { }

	[Address(RVA = "0x1CF1B90", Offset = "0x1CF0D90", Length = "0x6F7")]
	[CalledBy(Type = typeof(TouchInputModule), Member = "Process", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "FakeTouches", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA20")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3F90")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Token(Token = "0x6000779")]
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600076F")]
	public void set_allowActivationOnStandalone(bool value) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000771")]
	public void set_forceModuleActive(bool value) { }

	[Address(RVA = "0x1CF2450", Offset = "0x1CF1650", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000774")]
	public virtual bool ShouldActivateModule() { }

	[Address(RVA = "0x1CF2570", Offset = "0x1CF1770", Length = "0x2AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyValuePair`2), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600077B")]
	public virtual string ToString() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1A20", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3F90")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000772")]
	public virtual void UpdateModule() { }

	[Address(RVA = "0x1CF2990", Offset = "0x1CF1B90", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000775")]
	private bool UseFakeInput() { }

}


namespace UnityEngine.EventSystems;

[Token(Token = "0x20000BF")]
public abstract class PointerInputModule : BaseInputModule
{
	[Token(Token = "0x20000C0")]
	internal class ButtonState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000347")]
		private InputButton m_Button; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000348")]
		private MouseButtonEventData m_EventData; //Field offset: 0x18

		[Token(Token = "0x170001F2")]
		public InputButton button
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x600073D")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x600073E")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170001F1")]
		public MouseButtonEventData eventData
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x600073B")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x600073C")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073F")]
		public ButtonState() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073D")]
		public InputButton get_button() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073B")]
		public MouseButtonEventData get_eventData() { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600073E")]
		public void set_button(InputButton value) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600073C")]
		public void set_eventData(MouseButtonEventData value) { }

	}

	[Token(Token = "0x20000C2")]
	internal class MouseButtonEventData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400034A")]
		public FramePressState buttonState; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400034B")]
		public PointerEventData buttonData; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000747")]
		public MouseButtonEventData() { }

		[Address(RVA = "0x1CE4A60", Offset = "0x1CE3C60", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000745")]
		public bool PressedThisFrame() { }

		[Address(RVA = "0x1CE4A80", Offset = "0x1CE3C80", Length = "0x11")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000746")]
		public bool ReleasedThisFrame() { }

	}

	[Token(Token = "0x20000C1")]
	internal class MouseState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000349")]
		private List<ButtonState> m_TrackedButtons; //Field offset: 0x10

		[Address(RVA = "0x1CE4E30", Offset = "0x1CE4030", Length = "0x77")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000744")]
		public MouseState() { }

		[Address(RVA = "0x1CE4AA0", Offset = "0x1CE3CA0", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000740")]
		public bool AnyPressesThisFrame() { }

		[Address(RVA = "0x1CE4B60", Offset = "0x1CE3D60", Length = "0xB0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000741")]
		public bool AnyReleasesThisFrame() { }

		[Address(RVA = "0x1CE4C20", Offset = "0x1CE3E20", Length = "0x1A9")]
		[CalledBy(Type = typeof(MouseState), Member = "SetButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputButton), typeof(FramePressState), typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MouseState))]
		[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchInputModule), Member = "Process", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchInputModule), Member = "FakeTouches", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6000742")]
		public ButtonState GetButtonState(InputButton button) { }

		[Address(RVA = "0x1CE4DD0", Offset = "0x1CE3FD0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MouseState), Member = "GetButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputButton)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+ButtonState")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000743")]
		public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	}

	[Token(Token = "0x4000341")]
	public const int kMouseLeftId = -1; //Field offset: 0x0
	[Token(Token = "0x4000342")]
	public const int kMouseRightId = -2; //Field offset: 0x0
	[Token(Token = "0x4000343")]
	public const int kMouseMiddleId = -3; //Field offset: 0x0
	[Token(Token = "0x4000344")]
	public const int kFakeTouchesId = -4; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000345")]
	protected Dictionary<Int32, PointerEventData> m_PointerData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000346")]
	private readonly MouseState m_MouseState; //Field offset: 0x60

	[Address(RVA = "0x1CECCE0", Offset = "0x1CEBEE0", Length = "0x166")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600073A")]
	protected PointerInputModule() { }

	[Address(RVA = "0x1CEB3B0", Offset = "0x1CEA5B0", Length = "0x19C")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "DeactivateModule", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "DeactivateModule", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000737")]
	protected void ClearSelection() { }

	[Address(RVA = "0x1CEB550", Offset = "0x1CEA750", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600072E")]
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	[Address(RVA = "0x1CEB6E0", Offset = "0x1CEA8E0", Length = "0xDC")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000739")]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	[Address(RVA = "0x1CEB7C0", Offset = "0x1CEA9C0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000732")]
	protected PointerEventData GetLastPointerEventData(int id) { }

	[Address(RVA = "0x1CEB7F0", Offset = "0x1CEA9F0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000730")]
	protected override MouseState GetMousePointerEventData() { }

	[Address(RVA = "0x1CEB810", Offset = "0x1CEAA10", Length = "0x7A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(RaycastResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerInputModule), Member = "StateForMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FramePressState))]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputButton)}, ReturnType = typeof(ButtonState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000731")]
	protected override MouseState GetMousePointerEventData(int id) { }

	[Address(RVA = "0x1CEBFC0", Offset = "0x1CEB1C0", Length = "0xFC")]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(PointerEventData))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MouseState))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetLastPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PointerEventData))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "IsPointerOverGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600072B")]
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	[Address(RVA = "0x1CEC0C0", Offset = "0x1CEB2C0", Length = "0x47D")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(RaycastResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600072D")]
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	[Address(RVA = "0x1CEC540", Offset = "0x1CEB740", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PointerEventData&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000736")]
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	[Address(RVA = "0x1CEC5D0", Offset = "0x1CEB7D0", Length = "0x2BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEBB0")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000735")]
	protected override void ProcessDrag(PointerEventData pointerEvent) { }

	[Address(RVA = "0x1CEC890", Offset = "0x1CEBA90", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000734")]
	protected override void ProcessMove(PointerEventData pointerEvent) { }

	[Address(RVA = "0x1CEC8F0", Offset = "0x1CEBAF0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600072C")]
	protected void RemovePointerData(PointerEventData data) { }

	[Address(RVA = "0x1CEC950", Offset = "0x1CEBB50", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000733")]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	[Address(RVA = "0x1CEC9A0", Offset = "0x1CEBBA0", Length = "0xBE")]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MouseState))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600072F")]
	protected FramePressState StateForMouseButton(int buttonId) { }

	[Address(RVA = "0x1CECA60", Offset = "0x1CEBC60", Length = "0x27D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000738")]
	public virtual string ToString() { }

}


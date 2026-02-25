namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Standalone Input Module")]
[Token(Token = "0x20000C3")]
public class StandaloneInputModule : PointerInputModule
{
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	[Token(Token = "0x20000C4")]
	internal enum InputMode
	{
		Mouse = 0,
		Buttons = 1,
	}

	[Token(Token = "0x4000353")]
	private const float doubleClickTime = 0.3; //Field offset: 0x0
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400034C")]
	private float m_PrevActionTime; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400034D")]
	private Vector2 m_LastMoveVector; //Field offset: 0x6C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400034E")]
	private int m_ConsecutiveMoveCount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400034F")]
	private Vector2 m_LastMousePosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000350")]
	private Vector2 m_MousePosition; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000351")]
	private GameObject m_CurrentFocusedGameObject; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000352")]
	private readonly Dictionary<Int32, PointerEventData> m_InputPointerEvents; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000354")]
	private string m_HorizontalAxis; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000355")]
	private string m_VerticalAxis; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000356")]
	private string m_SubmitButton; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000357")]
	private string m_CancelButton; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x4000358")]
	private float m_InputActionsPerSecond; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	[Token(Token = "0x4000359")]
	private float m_RepeatDelay; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400035A")]
	private bool m_ForceModuleActive; //Field offset: 0xC0

	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	[Token(Token = "0x170001F4")]
	public bool allowActivationOnMobileDevice
	{
		[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074A")]
		 get { } //Length: 8
		[Address(RVA = "0x530450", Offset = "0x52F650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074B")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001FB")]
	public string cancelButton
	{
		[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000758")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000759")]
		 set { } //Length: 19
	}

	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	[Token(Token = "0x170001F5")]
	public bool forceModuleActive
	{
		[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074C")]
		 get { } //Length: 8
		[Address(RVA = "0x530450", Offset = "0x52F650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170001F8")]
	public string horizontalAxis
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000752")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000753")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001F6")]
	public float inputActionsPerSecond
	{
		[Address(RVA = "0x3B8210", Offset = "0x3B7410", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074E")]
		 get { } //Length: 9
		[Address(RVA = "0x1CF1210", Offset = "0x1CF0410", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600074F")]
		 set { } //Length: 9
	}

	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	[Token(Token = "0x170001F3")]
	public InputMode inputMode
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000749")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001F7")]
	public float repeatDelay
	{
		[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000750")]
		 get { } //Length: 9
		[Address(RVA = "0x1CF1220", Offset = "0x1CF0420", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000751")]
		 set { } //Length: 9
	}

	[Token(Token = "0x170001FA")]
	public string submitButton
	{
		[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000756")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000757")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001F9")]
	public string verticalAxis
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000754")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000755")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x1CF10C0", Offset = "0x1CF02C0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000748")]
	protected StandaloneInputModule() { }

	[Address(RVA = "0x1CEE050", Offset = "0x1CED250", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600075F")]
	public virtual void ActivateModule() { }

	[Address(RVA = "0x1CEE1B0", Offset = "0x1CED3B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000760")]
	public virtual void DeactivateModule() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	[Token(Token = "0x6000768")]
	protected override bool ForceAutoSelect() { }

	[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074A")]
	public bool get_allowActivationOnMobileDevice() { }

	[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000758")]
	public string get_cancelButton() { }

	[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074C")]
	public bool get_forceModuleActive() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000752")]
	public string get_horizontalAxis() { }

	[Address(RVA = "0x3B8210", Offset = "0x3B7410", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074E")]
	public float get_inputActionsPerSecond() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000749")]
	public InputMode get_inputMode() { }

	[Address(RVA = "0x3B8220", Offset = "0x3B7420", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000750")]
	public float get_repeatDelay() { }

	[Address(RVA = "0x2DD250", Offset = "0x2DC450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000756")]
	public string get_submitButton() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000754")]
	public string get_verticalAxis() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600076C")]
	protected GameObject GetCurrentFocusedGameObject() { }

	[Address(RVA = "0x1CEE1C0", Offset = "0x1CED3C0", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000765")]
	private Vector2 GetRawMoveVector() { }

	[Address(RVA = "0x1CEFA00", Offset = "0x1CEEC00", Length = "0x1D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StandaloneInputModule), Member = "SendMoveEventToSelectedObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StandaloneInputModule), Member = "SendSubmitEventToSelectedObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000761")]
	public virtual void Process() { }

	[Address(RVA = "0x1CEE330", Offset = "0x1CED530", Length = "0x2C5")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputButton)}, ReturnType = typeof(ButtonState))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MouseButtonEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000769")]
	protected void ProcessMouseEvent(int id) { }

	[Address(RVA = "0x1CEE600", Offset = "0x1CED800", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000767")]
	protected void ProcessMouseEvent() { }

	[Address(RVA = "0x1CEE610", Offset = "0x1CED810", Length = "0x2C")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600076B")]
	protected void ProcessMousePress(MouseButtonEventData data) { }

	[Address(RVA = "0x1CEEA90", Offset = "0x1CEDC90", Length = "0x805")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEB10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3F90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEBB0")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE9D0")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(PointerEventData))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA70")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000762")]
	private bool ProcessTouchEvents() { }

	[Address(RVA = "0x1CEF2A0", Offset = "0x1CEE4A0", Length = "0x755")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3F90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA20")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Token(Token = "0x6000763")]
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	[Address(RVA = "0x1CEFBE0", Offset = "0x1CEEDE0", Length = "0x3D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600075D")]
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	[Address(RVA = "0x1CEFFC0", Offset = "0x1CEF1C0", Length = "0x710")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "UpdateModule", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805C3F90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDE980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEA20")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181CDEBB0")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x600075C")]
	private void ReleasePointerDrags() { }

	[Address(RVA = "0x1CF06E0", Offset = "0x1CEF8E0", Length = "0x367")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000766")]
	protected bool SendMoveEventToSelectedObject() { }

	[Address(RVA = "0x1CF0A50", Offset = "0x1CEFC50", Length = "0x24E")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000764")]
	protected bool SendSubmitEventToSelectedObject() { }

	[Address(RVA = "0x1CF0CA0", Offset = "0x1CEFEA0", Length = "0x149")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600076A")]
	protected bool SendUpdateEventToSelectedObject() { }

	[Address(RVA = "0x530450", Offset = "0x52F650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074B")]
	public void set_allowActivationOnMobileDevice(bool value) { }

	[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000759")]
	public void set_cancelButton(string value) { }

	[Address(RVA = "0x530450", Offset = "0x52F650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600074D")]
	public void set_forceModuleActive(bool value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000753")]
	public void set_horizontalAxis(string value) { }

	[Address(RVA = "0x1CF1210", Offset = "0x1CF0410", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600074F")]
	public void set_inputActionsPerSecond(float value) { }

	[Address(RVA = "0x1CF1220", Offset = "0x1CF0420", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000751")]
	public void set_repeatDelay(float value) { }

	[Address(RVA = "0x2DD5A0", Offset = "0x2DC7A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000757")]
	public void set_submitButton(string value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000755")]
	public void set_verticalAxis(string value) { }

	[Address(RVA = "0x1CF0DF0", Offset = "0x1CEFFF0", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600075E")]
	public virtual bool ShouldActivateModule() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600075A")]
	private bool ShouldIgnoreEventsOnNoFocus() { }

	[Address(RVA = "0x1CF1030", Offset = "0x1CF0230", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
	[Calls(Type = typeof(StandaloneInputModule), Member = "ReleasePointerDrags", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600075B")]
	public virtual void UpdateModule() { }

}


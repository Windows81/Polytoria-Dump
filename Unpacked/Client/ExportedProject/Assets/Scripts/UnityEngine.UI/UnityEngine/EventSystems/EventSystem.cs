namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
[Token(Token = "0x20000B4")]
public class EventSystem : UIBehaviour
{
	[Token(Token = "0x20000B5")]
	private struct UIToolkitOverrideConfigOld
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030B")]
		public EventSystem activeEventSystem; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400030C")]
		public bool sendEvents; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x400030D")]
		public bool createPanelGameObjectsOnStart; //Field offset: 0x9

	}

	[Token(Token = "0x4000300")]
	private static List<EventSystem> m_EventSystems; //Field offset: 0x0
	[Token(Token = "0x4000308")]
	private static readonly Comparison<RaycastResult> s_RaycastComparer; //Field offset: 0x8
	[Token(Token = "0x400030A")]
	private static Nullable<UIToolkitOverrideConfigOld> s_UIToolkitOverrideConfigOld; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002FE")]
	private List<BaseInputModule> m_SystemInputModules; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002FF")]
	private BaseInputModule m_CurrentInputModule; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Selected")]
	[SerializeField]
	[Token(Token = "0x4000301")]
	private GameObject m_FirstSelected; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000302")]
	private bool m_sendNavigationEvents; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000303")]
	private int m_DragThreshold; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000304")]
	private GameObject m_CurrentSelected; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000305")]
	private bool m_HasFocus; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000306")]
	private bool m_SelectionGuard; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000307")]
	private BaseEventData m_DummyData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000309")]
	private UIToolkitInteroperabilityBridge m_UIToolkitInterop; //Field offset: 0x58

	[Token(Token = "0x170001CC")]
	public bool alreadySelecting
	{
		[Address(RVA = "0x347A20", Offset = "0x346C20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CD")]
	private BaseEventData baseEventDataCache
	{
		[Address(RVA = "0x1CE2920", Offset = "0x1CE1B20", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60006A3")]
		private get { } //Length: 121
	}

	[Token(Token = "0x170001C4")]
	public static EventSystem current
	{
		[Address(RVA = "0x1CE29A0", Offset = "0x1CE1BA0", Length = "0xAB")]
		[CallerCount(Count = 76)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000693")]
		 get { } //Length: 171
		[Address(RVA = "0x1CE2AB0", Offset = "0x1CE1CB0", Length = "0x184")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000694")]
		 set { } //Length: 388
	}

	[Token(Token = "0x170001C7")]
	public BaseInputModule currentInputModule
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000699")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C9")]
	public GameObject currentSelectedGameObject
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600069C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C8")]
	public GameObject firstSelectedGameObject
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600069A")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600069B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001CB")]
	public bool isFocused
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600069E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CF")]
	internal bool isOverridingUIToolkitEvents
	{
		[Address(RVA = "0x1CE2A50", Offset = "0x1CE1C50", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60006AA")]
		internal get { } //Length: 92
	}

	[Obsolete("lastSelectedGameObject is no longer supported")]
	[Token(Token = "0x170001CA")]
	public GameObject lastSelectedGameObject
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x600069D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001C6")]
	public int pixelDragThreshold
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000697")]
		 get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000698")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001C5")]
	public bool sendNavigationEvents
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000695")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000696")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001CE")]
	internal UIToolkitInteroperabilityBridge uiToolkitInterop
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A9")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1CE2750", Offset = "0x1CE1950", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Comparison`1<UnityEngine.EventSystems.RaycastResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B4")]
	private static EventSystem() { }

	[Address(RVA = "0x1CE2860", Offset = "0x1CE1A60", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600069F")]
	protected EventSystem() { }

	[Address(RVA = "0x1CE0AC0", Offset = "0x1CDFCC0", Length = "0x10C")]
	[CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006B2")]
	private void ChangeEventModule(BaseInputModule module) { }

	[Address(RVA = "0x347A20", Offset = "0x346C20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A1")]
	public bool get_alreadySelecting() { }

	[Address(RVA = "0x1CE2920", Offset = "0x1CE1B20", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006A3")]
	private BaseEventData get_baseEventDataCache() { }

	[Address(RVA = "0x1CE29A0", Offset = "0x1CE1BA0", Length = "0xAB")]
	[CallerCount(Count = 76)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000693")]
	public static EventSystem get_current() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000699")]
	public BaseInputModule get_currentInputModule() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069C")]
	public GameObject get_currentSelectedGameObject() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600069A")]
	public GameObject get_firstSelectedGameObject() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069E")]
	public bool get_isFocused() { }

	[Address(RVA = "0x1CE2A50", Offset = "0x1CE1C50", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006AA")]
	internal bool get_isOverridingUIToolkitEvents() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600069D")]
	public GameObject get_lastSelectedGameObject() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000697")]
	public int get_pixelDragThreshold() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000695")]
	public bool get_sendNavigationEvents() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A9")]
	internal UIToolkitInteroperabilityBridge get_uiToolkitInterop() { }

	[Address(RVA = "0x1CE0BD0", Offset = "0x1CDFDD0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A8")]
	public bool IsPointerOverGameObject(int pointerId) { }

	[Address(RVA = "0x1CE0C70", Offset = "0x1CDFE70", Length = "0x8F")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleScrollInput", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "ShouldProcessCameraInput", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A7")]
	public bool IsPointerOverGameObject() { }

	[Address(RVA = "0x1CE0D00", Offset = "0x1CDFF00", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "TickModules", ReturnType = typeof(void))]
	[Token(Token = "0x60006B0")]
	protected override void OnApplicationFocus(bool hasFocus) { }

	[Address(RVA = "0x1CE0D10", Offset = "0x1CDFF10", Length = "0x25E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006AD")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CE0F70", Offset = "0x1CE0170", Length = "0x34D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Token(Token = "0x60006AC")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CE12C0", Offset = "0x1CE04C0", Length = "0x1F8")]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
	[CalledBy(Type = "RLD.RTScene", Member = "GetHoveredUIElements", ReturnType = "System.Collections.Generic.List`1<RaycastResult>")]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "IsCursorOverUi", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "IsPointerOverUIObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(PointerEventData))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60006A6")]
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	[Address(RVA = "0x1CE14C0", Offset = "0x1CE06C0", Length = "0x473")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
	[Calls(Type = typeof(BaseRaycaster), Member = "get_rootRaycaster", ReturnType = typeof(BaseRaycaster))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortingGroup), Member = "get_invalidSortingGroupID", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SortingLayer), Member = "GetLayerValueFromID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006A5")]
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	[Address(RVA = "0x1CE2AB0", Offset = "0x1CE1CB0", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000694")]
	public static void set_current(EventSystem value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600069B")]
	public void set_firstSelectedGameObject(GameObject value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000698")]
	public void set_pixelDragThreshold(int value) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000696")]
	public void set_sendNavigationEvents(bool value) { }

	[Address(RVA = "0x1CE1940", Offset = "0x1CE0B40", Length = "0x92")]
	[CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "OnInputFieldEndEdit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "TryToSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Battlehub.UIControls.VirtualizingItemContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelEventHandler), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "Select", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown+DropdownItem", Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "<Start>b__187_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SendChat", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DropdownItem), Member = "OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60006A4")]
	public void SetSelectedGameObject(GameObject selected) { }

	[Address(RVA = "0x1CE19E0", Offset = "0x1CE0BE0", Length = "0x21E")]
	[CalledBy(Type = typeof(StandaloneInputModule), Member = "ActivateModule", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseEventData), Member = "set_selectedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BaseEventData), "UnityEngine.EventSystems.ExecuteEvents+EventFunction`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A2")]
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	[Address(RVA = "0x1CE1C00", Offset = "0x1CE0E00", Length = "0x4E4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Obsolete("Use PanelInputConfiguration component instead.")]
	[Token(Token = "0x60006AB")]
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true) { }

	[Address(RVA = "0x1CE20F0", Offset = "0x1CE12F0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006AE")]
	protected virtual void Start() { }

	[Address(RVA = "0x1CE2120", Offset = "0x1CE1320", Length = "0xF8")]
	[CalledBy(Type = typeof(EventSystem), Member = "OnApplicationFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006AF")]
	private void TickModules() { }

	[Address(RVA = "0x1CE2220", Offset = "0x1CE1420", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60006B3")]
	public virtual string ToString() { }

	[Address(RVA = "0x1CE24C0", Offset = "0x1CE16C0", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObjects", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "TickModules", ReturnType = typeof(void))]
	[Calls(Type = typeof(EventSystem), Member = "ChangeEventModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInputModule)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60006B1")]
	protected override void Update() { }

	[Address(RVA = "0x1CE2380", Offset = "0x1CE1580", Length = "0x13D")]
	[CalledBy(Type = typeof(BaseInputModule), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseInputModule), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A0")]
	public void UpdateModules() { }

}


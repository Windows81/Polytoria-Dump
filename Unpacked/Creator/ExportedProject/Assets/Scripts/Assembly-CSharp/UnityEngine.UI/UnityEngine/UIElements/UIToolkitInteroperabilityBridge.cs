namespace UnityEngine.UIElements;

[Token(Token = "0x2000096")]
internal class UIToolkitInteroperabilityBridge
{
	[CompilerGenerated]
	[Token(Token = "0x2000098")]
	private sealed class <>c__DisplayClass37_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002C9")]
		public GameObject go; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000623")]
		public <>c__DisplayClass37_0() { }

		[Address(RVA = "0x1CF2A20", Offset = "0x1CF1C20", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "UnityEngine.UIElements.UIRUtility", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000624")]
		internal void <CreatePanelGameObject>b__0() { }

	}

	[Flags]
	[Token(Token = "0x2000097")]
	internal enum EventHandlerTypes
	{
		ScreenOverlay = 1,
		WorldSpace = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B4")]
	private EventSystem m_EventSystem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B5")]
	private bool m_OverrideUIToolkitEvents; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002B6")]
	private EventHandlerTypes m_HandlerTypes; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B7")]
	private LayerMask m_WorldPickingLayers; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002B8")]
	private float m_WorldPickingMaxDistance; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B9")]
	private bool m_CreateDefaultPanelComponents; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40002BA")]
	private bool m_Started; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40002BB")]
	private bool m_Enabled; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x40002BC")]
	private bool m_IsTrackingPanels; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002BD")]
	private GameObject m_WorldSpaceGo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002BE")]
	private readonly HashSet<BaseRuntimePanel> trackedPanels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002BF")]
	private readonly Dictionary<BaseRuntimePanel, Action> destroyedActions; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002C0")]
	private Settings m_InputSettings; //Field offset: 0x48
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002C1")]
	private bool m_OldOverrideUIToolkitEvents; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40002C2")]
	private EventHandlerTypes m_OldHandlerTypes; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002C3")]
	private bool m_OldCreateDefaultPanelComponents; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40002C4")]
	private bool m_OldDefaultEventCameraIsMainCamera; //Field offset: 0x71
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002C5")]
	private long m_OldEventCamerasHash; //Field offset: 0x78

	[Token(Token = "0x17000198")]
	public internal bool createDefaultPanelComponents
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060D")]
		 get { } //Length: 5
		[Address(RVA = "0x1CF43C0", Offset = "0x1CF35C0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[Token(Token = "0x600060E")]
		internal set { } //Length: 72
	}

	[Token(Token = "0x17000193")]
	internal EventSystem eventSystem
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000603")]
		internal get { } //Length: 5
		[Address(RVA = "0x1CF4410", Offset = "0x1CF3610", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000604")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x17000195")]
	public internal EventHandlerTypes handlerTypes
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000607")]
		 get { } //Length: 4
		[Address(RVA = "0x1CF4490", Offset = "0x1CF3690", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[Token(Token = "0x6000608")]
		internal set { } //Length: 73
	}

	[Token(Token = "0x17000194")]
	public internal bool overrideUIToolkitEvents
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000605")]
		 get { } //Length: 5
		[Address(RVA = "0x1CF44E0", Offset = "0x1CF36E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
		[Token(Token = "0x6000606")]
		internal set { } //Length: 10
	}

	[Token(Token = "0x17000199")]
	private bool shouldTrackPanels
	{
		[Address(RVA = "0x1CF4390", Offset = "0x1CF3590", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600060F")]
		private get { } //Length: 26
	}

	[Token(Token = "0x17000196")]
	public internal int worldPickingLayers
	{
		[Address(RVA = "0x1CF43B0", Offset = "0x1CF35B0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000609")]
		 get { } //Length: 10
		[Address(RVA = "0x1CF44F0", Offset = "0x1CF36F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600060A")]
		internal set { } //Length: 29
	}

	[Token(Token = "0x17000197")]
	public internal float worldPickingMaxDistance
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060B")]
		 get { } //Length: 6
		[Address(RVA = "0x1900140", Offset = "0x18FF340", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600060C")]
		internal set { } //Length: 6
	}

	[Address(RVA = "0x1CF4220", Offset = "0x1CF3420", Length = "0x16D")]
	[CalledBy(Type = typeof(EventSystem), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000622")]
	public UIToolkitInteroperabilityBridge() { }

	[Address(RVA = "0x1CF2D80", Offset = "0x1CF1F80", Length = "0x1BC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyCameraProperties", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600061C")]
	private void Apply(PanelInputConfiguration input) { }

	[Address(RVA = "0x1CF2AD0", Offset = "0x1CF1CD0", Length = "0x18C")]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "CreateWorldSpacePanelGameObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.UIElements.UIRUtility", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600061E")]
	private void ApplyCameraProperties() { }

	[Address(RVA = "0x1CF2C60", Offset = "0x1CF1E60", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Token(Token = "0x600061F")]
	private void ApplyOtherProperties() { }

	[Address(RVA = "0x1CF2CB0", Offset = "0x1CF1EB0", Length = "0xC6")]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "set_overrideUIToolkitEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Token(Token = "0x600061D")]
	private void ApplyOverrideUIToolkitEvents() { }

	[Address(RVA = "0x1CF2F40", Offset = "0x1CF2140", Length = "0x2E4")]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObjects", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "set_selectableGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = "UnityEngine.UIElements.Panel", Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000614")]
	private void CreatePanelGameObject(BaseRuntimePanel panel) { }

	[Address(RVA = "0x1CF3230", Offset = "0x1CF2430", Length = "0x1C5")]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObjects", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyCameraProperties", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000616")]
	private void CreateWorldSpacePanelGameObject() { }

	[Address(RVA = "0x1CF3400", Offset = "0x1CF2600", Length = "0xFA")]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObjects", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "set_selectableGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIRUtility", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000615")]
	private void DestroyPanelGameObject(BaseRuntimePanel panel) { }

	[Address(RVA = "0x1CF3500", Offset = "0x1CF2700", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIRUtility", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000617")]
	private void DestroyWorldSpacePanelGameObject() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600060D")]
	public bool get_createDefaultPanelComponents() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000603")]
	internal EventSystem get_eventSystem() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000607")]
	public EventHandlerTypes get_handlerTypes() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000605")]
	public bool get_overrideUIToolkitEvents() { }

	[Address(RVA = "0x1CF4390", Offset = "0x1CF3590", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600060F")]
	private bool get_shouldTrackPanels() { }

	[Address(RVA = "0x1CF43B0", Offset = "0x1CF35B0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000609")]
	public int get_worldPickingLayers() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600060B")]
	public float get_worldPickingMaxDistance() { }

	[Address(RVA = "0x1CF3570", Offset = "0x1CF2770", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600061A")]
	public void OnDisable() { }

	[Address(RVA = "0x1CF36F0", Offset = "0x1CF28F0", Length = "0x435")]
	[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "UnregisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyCameraProperties", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterEventSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000619")]
	public void OnEnable() { }

	[Address(RVA = "0x1CF43C0", Offset = "0x1CF35C0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Token(Token = "0x600060E")]
	internal void set_createDefaultPanelComponents(bool value) { }

	[Address(RVA = "0x1CF4410", Offset = "0x1CF3610", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000604")]
	internal void set_eventSystem(EventSystem value) { }

	[Address(RVA = "0x1CF4490", Offset = "0x1CF3690", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Token(Token = "0x6000608")]
	internal void set_handlerTypes(EventHandlerTypes value) { }

	[Address(RVA = "0x1CF44E0", Offset = "0x1CF36E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[Token(Token = "0x6000606")]
	internal void set_overrideUIToolkitEvents(bool value) { }

	[Address(RVA = "0x1CF44F0", Offset = "0x1CF36F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600060A")]
	internal void set_worldPickingLayers(int value) { }

	[Address(RVA = "0x1900140", Offset = "0x18FF340", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600060C")]
	internal void set_worldPickingMaxDistance(float value) { }

	[Address(RVA = "0x1CF3DA0", Offset = "0x1CF2FA0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Token(Token = "0x6000618")]
	public void Start() { }

	[Address(RVA = "0x1CF3B30", Offset = "0x1CF2D30", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000611")]
	private void StartTrackingPanel(BaseRuntimePanel panel) { }

	[Address(RVA = "0x1CF3B90", Offset = "0x1CF2D90", Length = "0x200")]
	[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelTracking", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOtherProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "set_createDefaultPanelComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "set_handlerTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandlerTypes)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "add_onCreatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000610")]
	private void StartTrackingUIToolkitPanels() { }

	[Address(RVA = "0x1CF3DB0", Offset = "0x1CF2FB0", Length = "0x1F5")]
	[CalledBy(Type = typeof(EventSystem), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "set_handlerTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventHandlerTypes)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "set_createDefaultPanelComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "ApplyOtherProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelTracking", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "remove_onCreatePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.UIElements.UIRUtility", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000612")]
	private void StopTrackingUIToolkitPanels() { }

	[Address(RVA = "0x1CF4210", Offset = "0x1CF3410", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "UpdatePanelGameObjects", ReturnType = typeof(void))]
	[Token(Token = "0x600061B")]
	public void Update() { }

	[Address(RVA = "0x1CF3FB0", Offset = "0x1CF31B0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000613")]
	private void UpdatePanelGameObject(BaseRuntimePanel panel) { }

	[Address(RVA = "0x1CF3FF0", Offset = "0x1CF31F0", Length = "0x1EE")]
	[CalledBy(Type = typeof(UIToolkitInteroperabilityBridge), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventSystem), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "DestroyPanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "CreateWorldSpacePanelGameObject", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.UIElements.UIRUtility", Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000621")]
	private void UpdatePanelGameObjects() { }

	[Address(RVA = "0x1CF41E0", Offset = "0x1CF33E0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIToolkitInteroperabilityBridge), Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[Token(Token = "0x6000620")]
	private void UpdatePanelTracking() { }

}


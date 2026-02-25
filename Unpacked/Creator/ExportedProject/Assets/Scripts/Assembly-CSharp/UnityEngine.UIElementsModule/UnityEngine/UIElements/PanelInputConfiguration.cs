namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Input Configuration", 1)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("UIE-get-started-with-runtime-ui")]
[Token(Token = "0x2000265")]
public sealed class PanelInputConfiguration : MonoBehaviour
{
	[Token(Token = "0x2000266")]
	internal enum PanelInputRedirection
	{
		AutoSwitch = 0,
		Never = 1,
		Always = 2,
	}

	[Token(Token = "0x2000267")]
	public struct Settings
	{
		[Token(Token = "0x4000966")]
		private static Settings s_Default; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000967")]
		[Tooltip("Determines whether world space panels process input events. Disable this if you need UGUI support but do not require world space input to improve performance.")]
		internal bool m_ProcessWorldSpaceInput; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x4000968")]
		[Tooltip("Determines which layers can block input events on world space panels.")]
		internal LayerMask m_InteractionLayers; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000969")]
		[Tooltip("Sets how far away interactions with world-space UI are possible. Defaults to unlimited (infinity), but you can customize it for XR or performance needs. The distance uses GameObject units, consistent with transform positions and Camera clipping planes.")]
		internal float m_MaxInteractionDistance; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Token(Token = "0x400096A")]
		[Tooltip("Defines whether the Main Camera is used as the Event Camera for world space panels. Disable to specify alternative Event Camera(s) for raycasting input.")]
		internal bool m_DefaultEventCameraIsMainCamera; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400096B")]
		[Tooltip("Defines the Event Camera(s) used for world space raycasting input.")]
		internal Camera[] m_EventCameras; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x400096C")]
		[Tooltip("Determines which input event system is used for UI interactions when combining UI Toolkit and UGUI.")]
		internal PanelInputRedirection m_PanelInputRedirection; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Token(Token = "0x400096D")]
		[Tooltip("Automatically adds UI Toolkit components under the EventSystem to handle input redirection between UI Toolkit and UGUI panels. Disable to manually assign these components through code.")]
		internal bool m_AutoCreatePanelComponents; //Field offset: 0x1C

		[Token(Token = "0x17000326")]
		public bool autoCreatePanelComponents
		{
			[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010CC")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700031F")]
		public static Settings Default
		{
			[Address(RVA = "0x1C75020", Offset = "0x1C74220", Length = "0x62")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Token(Token = "0x60010C5")]
			 get { } //Length: 98
		}

		[Token(Token = "0x17000323")]
		public bool defaultEventCameraIsMainCamera
		{
			[Address(RVA = "0x1C75090", Offset = "0x1C74290", Length = "0x5")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60010C9")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000324")]
		public Camera[] eventCameras
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010CA")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000321")]
		public LayerMask interactionLayers
		{
			[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C7")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000322")]
		public float maxInteractionDistance
		{
			[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C8")]
			 get { } //Length: 6
		}

		[Token(Token = "0x17000325")]
		public PanelInputRedirection panelInputRedirection
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010CB")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000320")]
		public bool processWorldSpaceInput
		{
			[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C6")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x1C74F50", Offset = "0x1C74150", Length = "0xC3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60010CD")]
		private static Settings() { }

		[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CC")]
		public bool get_autoCreatePanelComponents() { }

		[Address(RVA = "0x1C75020", Offset = "0x1C74220", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60010C5")]
		public static Settings get_Default() { }

		[Address(RVA = "0x1C75090", Offset = "0x1C74290", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010C9")]
		public bool get_defaultEventCameraIsMainCamera() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CA")]
		public Camera[] get_eventCameras() { }

		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C7")]
		public LayerMask get_interactionLayers() { }

		[Address(RVA = "0x553AE0", Offset = "0x552CE0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C8")]
		public float get_maxInteractionDistance() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CB")]
		public PanelInputRedirection get_panelInputRedirection() { }

		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010C6")]
		public bool get_processWorldSpaceInput() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400095D")]
	private static PanelInputConfiguration <current>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000961")]
	internal const string SettingsProperty = "m_Settings"; //Field offset: 0x0
	[Token(Token = "0x400095E")]
	internal static int s_ActiveInstances; //Field offset: 0x8
	[Token(Token = "0x400095F")]
	internal static Action<PanelInputConfiguration> onApply; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000960")]
	private Settings m_Settings; //Field offset: 0x20

	[Token(Token = "0x1700031E")]
	public bool autoCreatePanelComponents
	{
		[Address(RVA = "0x599160", Offset = "0x598360", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BF")]
		 get { } //Length: 5
		[Address(RVA = "0x1C718E0", Offset = "0x1C70AE0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[Token(Token = "0x60010C0")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000316")]
	internal static PanelInputConfiguration current
	{
		[Address(RVA = "0x1C718A0", Offset = "0x1C70AA0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x60010B0")]
		internal get { } //Length: 54
		[Address(RVA = "0x1C718F0", Offset = "0x1C70AF0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60010B1")]
		internal set { } //Length: 81
	}

	[Token(Token = "0x1700031B")]
	public bool defaultEventCameraIsMainCamera
	{
		[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B9")]
		 get { } //Length: 5
		[Address(RVA = "0x1C71950", Offset = "0x1C70B50", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[Token(Token = "0x60010BA")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700031C")]
	public Camera[] eventCameras
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BB")]
		 get { } //Length: 95
		[Address(RVA = "0x1C71960", Offset = "0x1C70B60", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[Token(Token = "0x60010BC")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000319")]
	public LayerMask interactionLayers
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B5")]
		 get { } //Length: 4
		[Address(RVA = "0x1C719A0", Offset = "0x1C70BA0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60010B6")]
		 set { } //Length: 74
	}

	[Token(Token = "0x1700031A")]
	public float maxInteractionDistance
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B7")]
		 get { } //Length: 6
		[Address(RVA = "0x1C719F0", Offset = "0x1C70BF0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010B8")]
		 set { } //Length: 25
	}

	[Token(Token = "0x1700031D")]
	public PanelInputRedirection panelInputRedirection
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010BD")]
		 get { } //Length: 4
		[Address(RVA = "0x1C71A10", Offset = "0x1C70C10", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[Token(Token = "0x60010BE")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000318")]
	public bool processWorldSpaceInput
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B3")]
		 get { } //Length: 5
		[Address(RVA = "0x1C71A20", Offset = "0x1C70C20", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[Token(Token = "0x60010B4")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000317")]
	internal Settings settings
	{
		[Address(RVA = "0x1C00380", Offset = "0x1BFF580", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010B2")]
		internal get { } //Length: 19
	}

	[Address(RVA = "0x1C717F0", Offset = "0x1C709F0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010C4")]
	public PanelInputConfiguration() { }

	[Address(RVA = "0x1C70FE0", Offset = "0x1C701E0", Length = "0x434")]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_panelInputRedirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputRedirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_processWorldSpaceInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_interactionLayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayerMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_maxInteractionDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_defaultEventCameraIsMainCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_eventCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "set_autoCreatePanelComponents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MainCameraScreenRaycaster), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010C3")]
	private static void Apply(PanelInputConfiguration input) { }

	[Address(RVA = "0x599160", Offset = "0x598360", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BF")]
	public bool get_autoCreatePanelComponents() { }

	[Address(RVA = "0x1C718A0", Offset = "0x1C70AA0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x60010B0")]
	internal static PanelInputConfiguration get_current() { }

	[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B9")]
	public bool get_defaultEventCameraIsMainCamera() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BB")]
	public Camera[] get_eventCameras() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B5")]
	public LayerMask get_interactionLayers() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B7")]
	public float get_maxInteractionDistance() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010BD")]
	public PanelInputRedirection get_panelInputRedirection() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B3")]
	public bool get_processWorldSpaceInput() { }

	[Address(RVA = "0x1C00380", Offset = "0x1BFF580", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B2")]
	internal Settings get_settings() { }

	[Address(RVA = "0x1C71420", Offset = "0x1C70620", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010C2")]
	private void OnDisable() { }

	[Address(RVA = "0x1C71520", Offset = "0x1C70720", Length = "0x2C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60010C1")]
	private void OnEnable() { }

	[Address(RVA = "0x1C718E0", Offset = "0x1C70AE0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010C0")]
	public void set_autoCreatePanelComponents(bool value) { }

	[Address(RVA = "0x1C718F0", Offset = "0x1C70AF0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x60010B1")]
	internal static void set_current(PanelInputConfiguration value) { }

	[Address(RVA = "0x1C71950", Offset = "0x1C70B50", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010BA")]
	public void set_defaultEventCameraIsMainCamera(bool value) { }

	[Address(RVA = "0x1C71960", Offset = "0x1C70B60", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010BC")]
	public void set_eventCameras(Camera[] value) { }

	[Address(RVA = "0x1C719A0", Offset = "0x1C70BA0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60010B6")]
	public void set_interactionLayers(LayerMask value) { }

	[Address(RVA = "0x1C719F0", Offset = "0x1C70BF0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010B8")]
	public void set_maxInteractionDistance(float value) { }

	[Address(RVA = "0x1C71A10", Offset = "0x1C70C10", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010BE")]
	public void set_panelInputRedirection(PanelInputRedirection value) { }

	[Address(RVA = "0x1C71A20", Offset = "0x1C70C20", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010B4")]
	public void set_processWorldSpaceInput(bool value) { }

}


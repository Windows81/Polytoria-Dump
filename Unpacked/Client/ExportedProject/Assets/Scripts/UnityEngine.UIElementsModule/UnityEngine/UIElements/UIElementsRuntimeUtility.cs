namespace UnityEngine.UIElements;

[Token(Token = "0x200049A")]
internal static class UIElementsRuntimeUtility
{
	[CompilerGenerated]
	[Token(Token = "0x200049C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000FA4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000FA5")]
		public static Comparison<BaseRuntimePanel> <>9__58_0; //Field offset: 0x8

		[Address(RVA = "0x1B44820", Offset = "0x1B43A20", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600231D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600231E")]
		public <>c() { }

		[Address(RVA = "0x1B444B0", Offset = "0x1B436B0", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x600231F")]
		internal void <.cctor>b__4_0(int displayIndex, int sortOrder) { }

		[Address(RVA = "0x1B43F10", Offset = "0x1B43110", Length = "0xF5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Token(Token = "0x6002320")]
		internal int <SortPanels>b__58_0(BaseRuntimePanel runtimePanelA, BaseRuntimePanel runtimePanelB) { }

	}

	[Token(Token = "0x200049B")]
	internal sealed class CreateRuntimePanelDelegate : MulticastDelegate
	{

		[Address(RVA = "0xC31020", Offset = "0xC30220", Length = "0x124")]
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600231B")]
		public CreateRuntimePanelDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600231C")]
		public override BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000F96")]
	private static Action<BaseRuntimePanel> onCreatePanel; //Field offset: 0x0
	[Token(Token = "0x4000F97")]
	internal static Func<Boolean> IsEditingPrefab; //Field offset: 0x8
	[Token(Token = "0x4000F98")]
	private static bool s_RegisteredPlayerloopCallback; //Field offset: 0x10
	[Token(Token = "0x4000F99")]
	private static readonly List<BaseRuntimePanel> s_SortedScreenOverlayPanels; //Field offset: 0x18
	[Token(Token = "0x4000F9A")]
	private static readonly List<BaseRuntimePanel> s_CachedWorldSpacePanels; //Field offset: 0x20
	[Token(Token = "0x4000F9B")]
	private static readonly List<BaseRuntimePanel> s_SortedPlayerPanels; //Field offset: 0x28
	[Token(Token = "0x4000F9C")]
	private static bool s_PanelOrderingOrDrawInCameraDirty; //Field offset: 0x30
	[Token(Token = "0x4000F9D")]
	internal static int s_ResolvedSortingIndexMax; //Field offset: 0x34
	[Token(Token = "0x4000F9E")]
	private static int currentOverlayIndex; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000F9F")]
	private static object <activeEventSystem>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000FA0")]
	private static Nullable<Boolean> <overrideUseDefaultEventSystem>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000FA1")]
	private static bool <autoUpdateEventSystem>k__BackingField; //Field offset: 0x4A
	[Token(Token = "0x4000FA2")]
	private static DefaultEventSystem s_DefaultEventSystem; //Field offset: 0x50
	[Token(Token = "0x4000FA3")]
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; //Field offset: 0x58

	[Token(Token = "0x1400002F")]
	public static event Action<BaseRuntimePanel> onCreatePanel
	{
		[Address(RVA = "0x1B49320", Offset = "0x1B48520", Length = "0x101")]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60022EE")]
		 add { } //Length: 257
		[Address(RVA = "0x1B49730", Offset = "0x1B48930", Length = "0x101")]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60022EF")]
		 remove { } //Length: 257
	}

	[Token(Token = "0x17000953")]
	internal static object activeEventSystem
	{
		[Address(RVA = "0x1B49430", Offset = "0x1B48630", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60022FE")]
		internal get { } //Length: 79
		[Address(RVA = "0x1B49840", Offset = "0x1B48A40", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x60022FF")]
		private set { } //Length: 110
	}

	[Token(Token = "0x17000956")]
	internal static bool autoUpdateEventSystem
	{
		[Address(RVA = "0x1B49480", Offset = "0x1B48680", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002303")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000957")]
	internal static DefaultEventSystem defaultEventSystem
	{
		[Address(RVA = "0x1B494D0", Offset = "0x1B486D0", Length = "0xC7")]
		[CalledBy(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.RuntimePanel+<>c", Member = "<.ctor>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent), typeof(RuntimePanel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimePanel), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdateEventSystem", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DefaultEventSystem), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002306")]
		internal get { } //Length: 199
	}

	[Token(Token = "0x17000955")]
	internal static Nullable<Boolean> overrideUseDefaultEventSystem
	{
		[Address(RVA = "0x1B495A0", Offset = "0x1B487A0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002301")]
		internal get { } //Length: 79
		[Address(RVA = "0x1B498B0", Offset = "0x1B48AB0", Length = "0x55")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002302")]
		internal set { } //Length: 85
	}

	[Token(Token = "0x17000954")]
	internal static bool useDefaultEventSystem
	{
		[Address(RVA = "0x1B495F0", Offset = "0x1B487F0", Length = "0x132")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002300")]
		internal get { } //Length: 306
	}

	[Address(RVA = "0x1B48F10", Offset = "0x1B48110", Length = "0x40C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "SetUpdateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60022F0")]
	private static UIElementsRuntimeUtility() { }

	[Address(RVA = "0x1B49320", Offset = "0x1B48520", Length = "0x101")]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60022EE")]
	public static void add_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[Address(RVA = "0x1B460D0", Offset = "0x1B452D0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60022FA")]
	internal static void BeginRenderOverlays(int displayIndex) { }

	[Address(RVA = "0x1B46130", Offset = "0x1B45330", Length = "0x6C")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Event)}, ReturnType = typeof(EventBase))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsUtility), Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventType)}, ReturnType = typeof(EventBase))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022F1")]
	public static EventBase CreateEvent(Event systemEvent) { }

	[Address(RVA = "0x1B461A0", Offset = "0x1B453A0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "UnsetRenderingCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600230C")]
	public static void DisableRenderingAndInputCallbacks() { }

	[Address(RVA = "0x1B46230", Offset = "0x1B45430", Length = "0x11F")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "DisposePanel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "DisposeRelatedPanel", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60022F3")]
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	[Address(RVA = "0x1B46350", Offset = "0x1B45550", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "SetRenderingCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600230B")]
	public static void EnableRenderingAndInputCallbacks() { }

	[Address(RVA = "0x1B46400", Offset = "0x1B45600", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022FC")]
	internal static void EndRenderOverlays(int displayIndex) { }

	[Address(RVA = "0x1B46470", Offset = "0x1B45670", Length = "0x218")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "CreateRelatedRuntimePanel", ReturnType = typeof(BaseRuntimePanel))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RegisterCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60022F2")]
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	[Address(RVA = "0x19D63E0", Offset = "0x19D55E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002319")]
	private static Vector2 FlipDeltaY(Vector2 delta) { }

	[Address(RVA = "0x1B46690", Offset = "0x1B45890", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002318")]
	internal static Vector2 FlipY(Vector2 p, float displayHeight) { }

	[Address(RVA = "0x1B49430", Offset = "0x1B48630", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60022FE")]
	internal static object get_activeEventSystem() { }

	[Address(RVA = "0x1B49480", Offset = "0x1B48680", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002303")]
	internal static bool get_autoUpdateEventSystem() { }

	[Address(RVA = "0x1B494D0", Offset = "0x1B486D0", Length = "0xC7")]
	[CalledBy(Type = typeof(PanelInputConfiguration), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelInputConfiguration)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.RuntimePanel+<>c", Member = "<.ctor>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent), typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdateEventSystem", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DefaultEventSystem), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002306")]
	internal static DefaultEventSystem get_defaultEventSystem() { }

	[Address(RVA = "0x1B495A0", Offset = "0x1B487A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002301")]
	internal static Nullable<Boolean> get_overrideUseDefaultEventSystem() { }

	[Address(RVA = "0x1B495F0", Offset = "0x1B487F0", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002300")]
	internal static bool get_useDefaultEventSystem() { }

	[Address(RVA = "0x1B466B0", Offset = "0x1B458B0", Length = "0x2C1")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "SortPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(UIElementsUtility), Member = "GetAllPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>), typeof(ContextType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60022F4")]
	private static void GetPlayerPanelsByRenderMode(List<BaseRuntimePanel> outScreenSpaceOverlayPanels, List<BaseRuntimePanel> outWorldSpacePanels) { }

	[Address(RVA = "0x1B46980", Offset = "0x1B45B80", Length = "0xBF")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Nullable`1<Int32>&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "PanelToScreenBottomLeftPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600231A")]
	private static float GetRuntimeDisplayHeight(int targetDisplay) { }

	[Address(RVA = "0x1B46A40", Offset = "0x1B45C40", Length = "0x9A")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendFocusBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TArg, EventBase>", "TArg"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RepaintPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "StartTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SortPanels", ReturnType = typeof(void))]
	[Token(Token = "0x6002311")]
	public static List<BaseRuntimePanel> GetSortedPlayerPanels() { }

	[Address(RVA = "0x1B46AE0", Offset = "0x1B45CE0", Length = "0x9A")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SortPanels", ReturnType = typeof(void))]
	[Token(Token = "0x6002310")]
	public static List<BaseRuntimePanel> GetSortedScreenOverlayPlayerPanels() { }

	[Address(RVA = "0x1B46B80", Offset = "0x1B45D80", Length = "0x9A")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SortPanels", ReturnType = typeof(void))]
	[Token(Token = "0x600230F")]
	internal static List<BaseRuntimePanel> GetWorldSpacePlayerPanels() { }

	[Address(RVA = "0x1B46C20", Offset = "0x1B45E20", Length = "0x122")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "MarkPotentiallyEmpty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002309")]
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	[Address(RVA = "0x1B46D50", Offset = "0x1B45F50", Length = "0x23B")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessMouseEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002313")]
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[Address(RVA = "0x1B46F90", Offset = "0x1B46190", Length = "0x1AC")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002314")]
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[Address(RVA = "0x1B47140", Offset = "0x1B46340", Length = "0x61")]
	[CalledBy(Type = typeof(CameraScreenRaycaster), Member = "MakeRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2), typeof(Ray&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x6002317")]
	internal static Vector2 PanelToScreenBottomLeftPosition(Vector2 panelPosition, int targetDisplay) { }

	[Address(RVA = "0x1B471B0", Offset = "0x1B463B0", Length = "0x219")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "SetRenderingCallbacks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "SetExternalCanvasEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60022F5")]
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	[Address(RVA = "0x1B473D0", Offset = "0x1B465D0", Length = "0x247")]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.EventSystem", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002304")]
	public static void RegisterEventSystem(object eventSystem) { }

	[Address(RVA = "0x1B49730", Offset = "0x1B48930", Length = "0x101")]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "StopTrackingUIToolkitPanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60022EF")]
	public static void remove_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[Address(RVA = "0x1B47620", Offset = "0x1B46820", Length = "0x295")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "SetExternalCanvasEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtilityNative), Member = "UnsetRenderingCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "SortPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIElementsUtility), Member = "GetAllPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Panel>), typeof(ContextType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60022F6")]
	private static void RemoveCachedPanelInternal(int instanceID) { }

	[Address(RVA = "0x1B478C0", Offset = "0x1B46AC0", Length = "0x1D1")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600230A")]
	internal static void RemoveUnusedPanels() { }

	[Address(RVA = "0x1B47AA0", Offset = "0x1B46CA0", Length = "0x1DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedScreenOverlayPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60022F7")]
	public static void RenderOffscreenPanels() { }

	[Address(RVA = "0x1B47C80", Offset = "0x1B46E80", Length = "0x1E3")]
	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "EndRenderOverlays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedScreenOverlayPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60022FB")]
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	[Address(RVA = "0x1B47E70", Offset = "0x1B47070", Length = "0xDA")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RenderOverlaysBeforePriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F9")]
	public static void RenderPanel(BaseRuntimePanel panel, bool restoreState = true) { }

	[Address(RVA = "0x1B47F50", Offset = "0x1B47150", Length = "0x74")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RepaintPanels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Camera), Member = "SetupCurrent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60022F8")]
	public static void RepaintPanel(BaseRuntimePanel panel) { }

	[Address(RVA = "0x1B47FD0", Offset = "0x1B471D0", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RepaintPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60022FD")]
	public static void RepaintPanels(bool onlyOffscreen) { }

	[Address(RVA = "0x1B48170", Offset = "0x1B47370", Length = "0x5A")]
	[CalledBy(Type = typeof(LegacyInputProcessor), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002316")]
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	[Address(RVA = "0x1B481D0", Offset = "0x1B473D0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x6002315")]
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[Address(RVA = "0x1B49840", Offset = "0x1B48A40", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x60022FF")]
	private static void set_activeEventSystem(object value) { }

	[Address(RVA = "0x1B498B0", Offset = "0x1B48AB0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002302")]
	internal static void set_overrideUseDefaultEventSystem(Nullable<Boolean> value) { }

	[Address(RVA = "0x1B48240", Offset = "0x1B47440", Length = "0x4F")]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600230D")]
	internal static void SetPanelOrderingDirty() { }

	[Address(RVA = "0x1B48290", Offset = "0x1B47490", Length = "0x4F")]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "set_drawsInCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600230E")]
	internal static void SetPanelsDrawInCameraDirty() { }

	[Address(RVA = "0x1B482E0", Offset = "0x1B474E0", Length = "0x65B")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetWorldSpacePlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedScreenOverlayPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetPlayerPanelsByRenderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6002312")]
	private static void SortPanels() { }

	[Address(RVA = "0x1B48940", Offset = "0x1B47B40", Length = "0x134")]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "ApplyOverrideUIToolkitEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "SetUITookitEventSystemOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.EventSystem", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002305")]
	public static void UnregisterEventSystem(object eventSystem) { }

	[Address(RVA = "0x1B48A80", Offset = "0x1B47C80", Length = "0x279")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UpdatePanels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "set_isInputReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "get_defaultEventSystem", ReturnType = typeof(DefaultEventSystem))]
	[Calls(Type = typeof(DefaultEventSystem), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UpdateMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002308")]
	internal static void UpdateEventSystem() { }

	[Address(RVA = "0x1B48D00", Offset = "0x1B47F00", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveUnusedPanels", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "ProcessDeviceFreeQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "get_IsSharedManagerCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutManager), Member = "Collect", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "GetSortedPlayerPanels", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.BaseRuntimePanel>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "UpdateEventSystem", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002307")]
	public static void UpdatePanels() { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x20002B1")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Panel : BaseVisualElementPanel
{
	[Token(Token = "0x4000AC7")]
	internal const int k_DefaultPixelsPerUnit = 100; //Field offset: 0x0
	[Token(Token = "0x4000AD7")]
	private static ProfilerMarker s_MarkerPickAll; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000AE0")]
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000AE3")]
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000AE8")]
	private static Action<Panel> beforeAnyRepaint; //Field offset: 0x18
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000AC8")]
	private VisualElement m_RootContainer; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000AC9")]
	private VisualTreeUpdater m_VisualTreeUpdater; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000ACA")]
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000ACB")]
	private string m_PanelName; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000ACC")]
	private uint m_Version; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000ACD")]
	private uint m_RepaintVersion; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000ACE")]
	private uint m_HierarchyVersion; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000ACF")]
	private uint m_LastTickedHierarchyVersion; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000AD0")]
	private ProfilerMarker m_MarkerPrepareRepaint; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000AD1")]
	private ProfilerMarker m_MarkerRender; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000AD2")]
	private ProfilerMarker m_MarkerValidateLayout; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000AD3")]
	private ProfilerMarker m_MarkerTickScheduledActions; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000AD4")]
	protected ProfilerMarker m_MarkerTickScheduledActionsPreLayout; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000AD5")]
	protected ProfilerMarker m_MarkerTickScheduledActionsPostLayout; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000AD6")]
	private ProfilerMarker m_MarkerPanelChangeReceiver; //Field offset: 0x140
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000AD8")]
	private EventDispatcher <dispatcher>k__BackingField; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000AD9")]
	private TimerEventScheduler m_Scheduler; //Field offset: 0x150
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000ADA")]
	private ScriptableObject <ownerObject>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000ADB")]
	private readonly ContextType <contextType>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000ADC")]
	private SavePersistentViewData <saveViewData>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000ADD")]
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000ADE")]
	private FocusController <focusController>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000ADF")]
	private EventInterests <IMGUIEventInterests>k__BackingField; //Field offset: 0x180
	[FieldOffset(Offset = "0x183")]
	[Token(Token = "0x4000AE1")]
	private bool m_JustReceivedFocus; //Field offset: 0x183
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000AE2")]
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0x188
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000AE4")]
	private int <IMGUIContainersCount>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000AE5")]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000AE6")]
	private AtlasBase m_Atlas; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000AE7")]
	private bool m_ValidatingLayout; //Field offset: 0x1A8

	[Token(Token = "0x1700039F")]
	public virtual AtlasBase atlas
	{
		[Address(RVA = "0x1C8BF30", Offset = "0x1C8B130", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60012AF")]
		 get { } //Length: 10
		[Address(RVA = "0x1C8C060", Offset = "0x1C8B260", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60012B0")]
		 set { } //Length: 130
	}

	[Token(Token = "0x17000392")]
	public virtual ContextType contextType
	{
		[Address(RVA = "0x189D640", Offset = "0x189C840", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001298")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700038D")]
	public virtual EventDispatcher dispatcher
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001290")]
		 get { } //Length: 8
		[Address(RVA = "0x189D950", Offset = "0x189CB50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001291")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000395")]
	public virtual FocusController focusController
	{
		[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600129B")]
		 get { } //Length: 8
		[Address(RVA = "0x538A60", Offset = "0x537C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600129C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000394")]
	public virtual GetViewDataDictionary getViewDataDictionary
	{
		[Address(RVA = "0x3D66F0", Offset = "0x3D58F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600129A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700039E")]
	internal virtual uint hierarchyVersion
	{
		[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012AE")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x1700039B")]
	public virtual int IMGUIContainersCount
	{
		[Address(RVA = "0x1C8BEB0", Offset = "0x1C8B0B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60012AA")]
		 get { } //Length: 7
		[Address(RVA = "0x1C8C030", Offset = "0x1C8B230", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60012AB")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000396")]
	public virtual EventInterests IMGUIEventInterests
	{
		[Address(RVA = "0x1C8BEC0", Offset = "0x1C8B0C0", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600129D")]
		 get { } //Length: 24
		[Address(RVA = "0x1C8C040", Offset = "0x1C8B240", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600129E")]
		 set { } //Length: 21
	}

	[Token(Token = "0x17000397")]
	private static LoadResourceFunction loadResourceFunc
	{
		[Address(RVA = "0x1C8BF40", Offset = "0x1C8B140", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600129F")]
		private get { } //Length: 79
	}

	[Token(Token = "0x17000398")]
	internal string name
	{
		[Address(RVA = "0x1C8BF90", Offset = "0x1C8B190", Length = "0xA")]
		[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingResult&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60012A4")]
		internal get { } //Length: 10
		[Address(RVA = "0x1C8C0F0", Offset = "0x1C8B2F0", Length = "0x2B")]
		[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Panel), Member = "CreateMarkers", ReturnType = typeof(void))]
		[Token(Token = "0x60012A5")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x17000391")]
	public virtual ScriptableObject ownerObject
	{
		[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001296")]
		 get { } //Length: 8
		[Address(RVA = "0x1A94230", Offset = "0x1A93430", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001297")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000399")]
	public IDebugPanelChangeReceiver panelChangeReceiver
	{
		[Address(RVA = "0x3D6850", Offset = "0x3D5A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012A6")]
		 get { } //Length: 8
		[Address(RVA = "0x1C8C120", Offset = "0x1C8B320", Length = "0xA9")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "SetPanelChangeReceiver", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "SetPanelChangeReceiver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugPanelChangeReceiver)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Token(Token = "0x60012A7")]
		 set { } //Length: 169
	}

	[Token(Token = "0x1700039C")]
	public virtual IMGUIContainer rootIMGUIContainer
	{
		[Address(RVA = "0x3D6500", Offset = "0x3D5700", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60012AC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000393")]
	public virtual SavePersistentViewData saveViewData
	{
		[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001299")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700038F")]
	internal virtual IScheduler scheduler
	{
		[Address(RVA = "0x1C8BFA0", Offset = "0x1C8B1A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "get_timerEventScheduler", ReturnType = typeof(TimerEventScheduler))]
		[Token(Token = "0x6001293")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000390")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal virtual IStylePropertyAnimationSystem styleAnimationSystem
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001294")]
		internal get { } //Length: 8
		[Address(RVA = "0x1C8C1D0", Offset = "0x1C8B3D0", Length = "0xDA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6001295")]
		internal set { } //Length: 218
	}

	[Token(Token = "0x1700038E")]
	public TimerEventScheduler timerEventScheduler
	{
		[Address(RVA = "0x1C8BFB0", Offset = "0x1C8B1B0", Length = "0x73")]
		[CalledBy(Type = typeof(Panel), Member = "get_scheduler", ReturnType = typeof(IScheduler))]
		[CalledBy(Type = typeof(Panel), Member = "TickSchedulingUpdaters", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TimerEventScheduler), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001292")]
		 get { } //Length: 115
	}

	[Token(Token = "0x1700039A")]
	internal static TimeMsFunction TimeSinceStartup
	{
		[Address(RVA = "0x1C8BEE0", Offset = "0x1C8B0E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60012A9")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700039D")]
	internal virtual uint version
	{
		[Address(RVA = "0x42DB00", Offset = "0x42CD00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012AD")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x1700038C")]
	public virtual VisualElement visualTree
	{
		[Address(RVA = "0x19AA860", Offset = "0x19A9A60", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600128F")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x1C8B890", Offset = "0x1C8AA90", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x60012C5")]
	private static Panel() { }

	[Address(RVA = "0x1C8B8F0", Offset = "0x1C8AAF0", Length = "0x5BE")]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutConfig), Member = "set_Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFocusRing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelRootElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeUpdater), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutMeasureFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "CreateMarkers", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "CreateConfig", ReturnType = typeof(LayoutConfig))]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ElementUnderPointer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynamicAtlas), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B1")]
	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	[Address(RVA = "0x1957060", Offset = "0x1956260", Length = "0xB2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60012C6")]
	internal static Vector2Int <Pick>g__PixelOf|105_0(Vector2 p) { }

	[Address(RVA = "0x1C8A460", Offset = "0x1C89660", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012BE")]
	public virtual void ApplyStyles() { }

	[Address(RVA = "0x1C8A490", Offset = "0x1C89690", Length = "0x2F")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_focusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "OnFocusEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel), typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.RuntimePanel+<>c", Member = "<.ctor>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent), typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(FocusController), Member = "BlurLastFocusedElement", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012A2")]
	internal void Blur() { }

	[Address(RVA = "0x1C8A4C0", Offset = "0x1C896C0", Length = "0x20B")]
	[CalledBy(Type = typeof(Panel), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x60012A8")]
	private void CreateMarkers() { }

	[Address(RVA = "0x1C8A6D0", Offset = "0x1C898D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B4")]
	internal static long DefaultTimeSinceStartupMs() { }

	[Address(RVA = "0x1C8A6F0", Offset = "0x1C898F0", Length = "0x1D4")]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIElementsUtility), Member = "RemoveCachedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "RemovePanelData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "DestroyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60012B2")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1C8A8D0", Offset = "0x1C89AD0", Length = "0x8")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "set_focusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "OnFocusEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel), typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateFocusedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.RuntimePanel+<>c", Member = "<.ctor>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent), typeof(RuntimePanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimePanel), Member = "OnElementFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x60012A1")]
	internal void Focus() { }

	[Address(RVA = "0x1C8BF30", Offset = "0x1C8B130", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60012AF")]
	public virtual AtlasBase get_atlas() { }

	[Address(RVA = "0x189D640", Offset = "0x189C840", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001298")]
	public virtual ContextType get_contextType() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001290")]
	public virtual EventDispatcher get_dispatcher() { }

	[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600129B")]
	public virtual FocusController get_focusController() { }

	[Address(RVA = "0x3D66F0", Offset = "0x3D58F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600129A")]
	public virtual GetViewDataDictionary get_getViewDataDictionary() { }

	[Address(RVA = "0x4234B0", Offset = "0x4226B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012AE")]
	internal virtual uint get_hierarchyVersion() { }

	[Address(RVA = "0x1C8BEB0", Offset = "0x1C8B0B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60012AA")]
	public virtual int get_IMGUIContainersCount() { }

	[Address(RVA = "0x1C8BEC0", Offset = "0x1C8B0C0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600129D")]
	public virtual EventInterests get_IMGUIEventInterests() { }

	[Address(RVA = "0x1C8BF40", Offset = "0x1C8B140", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600129F")]
	private static LoadResourceFunction get_loadResourceFunc() { }

	[Address(RVA = "0x1C8BF90", Offset = "0x1C8B190", Length = "0xA")]
	[CalledBy(Type = typeof(DataBindingManager), Member = "ProcessBindingRequests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "LogResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingResult&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIToolkitInteroperabilityBridge", Member = "CreatePanelGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseRuntimePanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60012A4")]
	internal string get_name() { }

	[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001296")]
	public virtual ScriptableObject get_ownerObject() { }

	[Address(RVA = "0x3D6850", Offset = "0x3D5A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A6")]
	public IDebugPanelChangeReceiver get_panelChangeReceiver() { }

	[Address(RVA = "0x3D6500", Offset = "0x3D5700", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60012AC")]
	public virtual IMGUIContainer get_rootIMGUIContainer() { }

	[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001299")]
	public virtual SavePersistentViewData get_saveViewData() { }

	[Address(RVA = "0x1C8BFA0", Offset = "0x1C8B1A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel), Member = "get_timerEventScheduler", ReturnType = typeof(TimerEventScheduler))]
	[Token(Token = "0x6001293")]
	internal virtual IScheduler get_scheduler() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001294")]
	internal virtual IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	[Address(RVA = "0x1C8BFB0", Offset = "0x1C8B1B0", Length = "0x73")]
	[CalledBy(Type = typeof(Panel), Member = "get_scheduler", ReturnType = typeof(IScheduler))]
	[CalledBy(Type = typeof(Panel), Member = "TickSchedulingUpdaters", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TimerEventScheduler), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001292")]
	public TimerEventScheduler get_timerEventScheduler() { }

	[Address(RVA = "0x1C8BEE0", Offset = "0x1C8B0E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60012A9")]
	internal static TimeMsFunction get_TimeSinceStartup() { }

	[Address(RVA = "0x42DB00", Offset = "0x42CD00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60012AD")]
	internal virtual uint get_version() { }

	[Address(RVA = "0x19AA860", Offset = "0x19A9A60", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600128F")]
	public virtual VisualElement get_visualTree() { }

	[Address(RVA = "0x1C8A8E0", Offset = "0x1C89AE0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "GetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(IVisualTreeUpdater))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012C4")]
	internal virtual IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x1C8A910", Offset = "0x1C89B10", Length = "0x13B")]
	[CalledBy(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_stylesheets>d__31", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+<get_templateDependencies>d__27", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFontDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontDefinition))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Font))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012A0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	[Address(RVA = "0x1C8AA50", Offset = "0x1C89C50", Length = "0x185")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "OnVersionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C2")]
	internal virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1C8ABE0", Offset = "0x1C89DE0", Length = "0x2A7")]
	[CalledBy(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBoundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B6")]
	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	[Address(RVA = "0x1C8B000", Offset = "0x1C8A200", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ElementUnderPointer), Member = "GetTopElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2&), typeof(Boolean&)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60012B8")]
	public virtual VisualElement Pick(Vector2 point, int pointerId) { }

	[Address(RVA = "0x1C8AF70", Offset = "0x1C8A170", Length = "0x85")]
	[CalledBy(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Panel), Member = "Pick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(VisualElement))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "PerformPick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[Token(Token = "0x60012B5")]
	internal static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	[Address(RVA = "0x1C8AE90", Offset = "0x1C8A090", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "PickAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>), typeof(bool)}, ReturnType = typeof(VisualElement))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60012B7")]
	public virtual VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	[Address(RVA = "0x1C8B150", Offset = "0x1C8A350", Length = "0x99")]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "Render", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(UITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60012C1")]
	public virtual void Render() { }

	[Address(RVA = "0x1C8B1F0", Offset = "0x1C8A3F0", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60012C0")]
	public virtual void Repaint(Event e) { }

	[Address(RVA = "0x1C8C060", Offset = "0x1C8B260", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B0")]
	public virtual void set_atlas(AtlasBase value) { }

	[Address(RVA = "0x189D950", Offset = "0x189CB50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001291")]
	public virtual void set_dispatcher(EventDispatcher value) { }

	[Address(RVA = "0x538A60", Offset = "0x537C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600129C")]
	public virtual void set_focusController(FocusController value) { }

	[Address(RVA = "0x1C8C030", Offset = "0x1C8B230", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60012AB")]
	public virtual void set_IMGUIContainersCount(int value) { }

	[Address(RVA = "0x1C8C040", Offset = "0x1C8B240", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600129E")]
	public virtual void set_IMGUIEventInterests(EventInterests value) { }

	[Address(RVA = "0x1C8C0F0", Offset = "0x1C8B2F0", Length = "0x2B")]
	[CalledBy(Type = typeof(RuntimePanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Panel), Member = "CreateMarkers", ReturnType = typeof(void))]
	[Token(Token = "0x60012A5")]
	internal void set_name(string value) { }

	[Address(RVA = "0x1A94230", Offset = "0x1A93430", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001297")]
	protected virtual void set_ownerObject(ScriptableObject value) { }

	[Address(RVA = "0x1C8C120", Offset = "0x1C8B320", Length = "0xA9")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "SetPanelChangeReceiver", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelSettings), Member = "SetPanelChangeReceiver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugPanelChangeReceiver)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60012A7")]
	public void set_panelChangeReceiver(IDebugPanelChangeReceiver value) { }

	[Address(RVA = "0x1C8C1D0", Offset = "0x1C8B3D0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6001295")]
	internal virtual void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[Address(RVA = "0x1C8B3B0", Offset = "0x1C8A5B0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "SetUpdater", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IVisualTreeUpdater), typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012C3")]
	internal virtual void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x1C8B3E0", Offset = "0x1C8A5E0", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Panel), Member = "get_timerEventScheduler", ReturnType = typeof(TimerEventScheduler))]
	[Calls(Type = typeof(TimerEventScheduler), Member = "UpdateScheduledEvents", ReturnType = typeof(void))]
	[Calls(Type = typeof(FocusController), Member = "SetFocusToLastFocusedElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60012BD")]
	public virtual void TickSchedulingUpdaters() { }

	[Address(RVA = "0x1C8B560", Offset = "0x1C8A760", Length = "0xBE")]
	[CalledBy(Type = typeof(TimerEventScheduler), Member = "UpdateScheduledEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueAnimation`1), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElementAnimationSystem), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScheduledItem), Member = "ResetStartTime", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScheduledItem), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventBase), Member = "LocalInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "HandleAutoExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "ShouldProcessBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualTreeBindingsUpdater), Member = "CurrentTime", ReturnType = typeof(long))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B3")]
	public static long TimeSinceStartupMs() { }

	[Address(RVA = "0x1C8B620", Offset = "0x1C8A820", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012BA")]
	public virtual void UpdateAnimations() { }

	[Address(RVA = "0x1C8B650", Offset = "0x1C8A850", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012BB")]
	public virtual void UpdateBindings() { }

	[Address(RVA = "0x1C8B680", Offset = "0x1C8A880", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012BC")]
	public virtual void UpdateDataBinding() { }

	[Address(RVA = "0x1C8B6B0", Offset = "0x1C8A8B0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BF")]
	public virtual void UpdateForRepaint() { }

	[Address(RVA = "0x1C8B770", Offset = "0x1C8A970", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "SetFocusToLastFocusedElement", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012A3")]
	public void ValidateFocus() { }

	[Address(RVA = "0x1C8B7B0", Offset = "0x1C8A9B0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeUpdater), Member = "UpdateVisualTreePhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeUpdatePhase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012B9")]
	public virtual void ValidateLayout() { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x20002AC")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	[Token(Token = "0x4000AC6")]
	internal static readonly Vector2 s_OutsidePanelCoordinates; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AB2")]
	private Action<BaseVisualElementPanel> panelDisposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AB3")]
	private UIElementsBridge m_UIElementsBridge; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AB4")]
	private float m_Scale; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AB5")]
	internal LayoutConfig layoutConfig; //Field offset: 0x28
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AB6")]
	private float m_PixelsPerPoint; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000AB7")]
	private float <referenceSpritePixelsPerUnit>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AB8")]
	private PanelClearSettings <clearSettings>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AB9")]
	internal IPanelRenderer panelRenderer; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000ABA")]
	private bool <duringLayoutPhase>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000ABB")]
	private RepaintData <repaintData>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000ABC")]
	private ICursorManager <cursorManager>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000ABD")]
	private ContextualMenuManager <contextualMenuManager>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000ABE")]
	private DataBindingManager <dataBindingManager>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000ABF")]
	private bool <disposed>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000AC0")]
	internal ElementUnderPointer m_TopElementUnderPointers; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000AC1")]
	private Action isFlatChanged; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000AC2")]
	private bool m_IsFlat; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000AC3")]
	private Action atlasChanged; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000AC4")]
	private HierarchyEvent hierarchyChanged; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000AC5")]
	private Action<IPanel> beforeUpdate; //Field offset: 0xD8

	[Token(Token = "0x14000029")]
	internal event Action atlasChanged
	{
		[Address(RVA = "0x1C7F8C0", Offset = "0x1C7EAC0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001278")]
		internal add { } //Length: 162
		[Address(RVA = "0x1C7FC30", Offset = "0x1C7EE30", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001279")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x1400002A")]
	internal event HierarchyEvent hierarchyChanged
	{
		[Address(RVA = "0x1C7F970", Offset = "0x1C7EB70", Length = "0xA2")]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600127D")]
		internal add { } //Length: 162
		[Address(RVA = "0x1C7FCE0", Offset = "0x1C7EEE0", Length = "0xA2")]
		[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600127E")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x14000028")]
	internal event Action isFlatChanged
	{
		[Address(RVA = "0x1C7FA20", Offset = "0x1C7EC20", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001273")]
		internal add { } //Length: 162
		[Address(RVA = "0x1C7FD90", Offset = "0x1C7EF90", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6001274")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x14000027")]
	internal event Action<BaseVisualElementPanel> panelDisposed
	{
		[Address(RVA = "0x1C7FAD0", Offset = "0x1C7ECD0", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600123B")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C7FE40", Offset = "0x1C7F040", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600123C")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1700038B")]
	public abstract AtlasBase atlas
	{
		[Token(Token = "0x600127B")]
		 get { } //Length: 0
		[Token(Token = "0x600127C")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700037C")]
	internal PanelClearSettings clearSettings
	{
		[Address(RVA = "0x1C7FB80", Offset = "0x1C7ED80", Length = "0x11")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600124E")]
		internal get { } //Length: 17
		[Address(RVA = "0x1C7FEF0", Offset = "0x1C7F0F0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600124F")]
		internal set { } //Length: 14
	}

	[Token(Token = "0x17000388")]
	public abstract ContextType contextType
	{
		[Token(Token = "0x6001265")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000382")]
	public internal override ContextualMenuManager contextualMenuManager
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600125A")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600125B")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000381")]
	internal override ICursorManager cursorManager
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001258")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001259")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000383")]
	internal override DataBindingManager dataBindingManager
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600125C")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600125D")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000385")]
	public abstract EventDispatcher dispatcher
	{
		[Token(Token = "0x600125F")]
		 get { } //Length: 0
		[Token(Token = "0x6001260")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000389")]
	internal bool disposed
	{
		[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001269")]
		internal get { } //Length: 8
		[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600126A")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700037D")]
	internal bool duringLayoutPhase
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001250")]
		internal get { } //Length: 8
		[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001251")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000376")]
	public abstract FocusController focusController
	{
		[Token(Token = "0x6001238")]
		 get { } //Length: 0
		[Token(Token = "0x6001239")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000374")]
	public abstract GetViewDataDictionary getViewDataDictionary
	{
		[Token(Token = "0x6001235")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700037F")]
	internal abstract uint hierarchyVersion
	{
		[Token(Token = "0x6001253")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000375")]
	public abstract int IMGUIContainersCount
	{
		[Token(Token = "0x6001236")]
		 get { } //Length: 0
		[Token(Token = "0x6001237")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000371")]
	public abstract EventInterests IMGUIEventInterests
	{
		[Token(Token = "0x6001230")]
		 get { } //Length: 0
		[Token(Token = "0x6001231")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700038A")]
	public bool isFlat
	{
		[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001275")]
		 get { } //Length: 8
		[Address(RVA = "0x1C7FF00", Offset = "0x1C7F100", Length = "0x44")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001276")]
		 set { } //Length: 68
	}

	[Token(Token = "0x17000372")]
	public abstract ScriptableObject ownerObject
	{
		[Token(Token = "0x6001232")]
		 get { } //Length: 0
		[Token(Token = "0x6001233")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700037B")]
	public float referenceSpritePixelsPerUnit
	{
		[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600124C")]
		 get { } //Length: 6
		[Address(RVA = "0x1818520", Offset = "0x1817720", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600124D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000380")]
	internal override RepaintData repaintData
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001256")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001257")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000377")]
	public abstract IMGUIContainer rootIMGUIContainer
	{
		[Token(Token = "0x600123A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000373")]
	public abstract SavePersistentViewData saveViewData
	{
		[Token(Token = "0x6001234")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000379")]
	internal float scale
	{
		[Address(RVA = "0x1C7FBA0", Offset = "0x1C7EDA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001249")]
		internal get { } //Length: 8
		[Address(RVA = "0x1C7FF50", Offset = "0x1C7F150", Length = "0xA6")]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LayoutConfig), Member = "get_PointScaleFactor", ReturnType = typeof(Single&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600124A")]
		internal set { } //Length: 166
	}

	[Token(Token = "0x1700037A")]
	public override float scaledPixelsPerPoint
	{
		[Address(RVA = "0x1C7FBB0", Offset = "0x1C7EDB0", Length = "0xD")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "ApplyStyles", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Token(Token = "0x600124B")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000386")]
	internal abstract IScheduler scheduler
	{
		[Token(Token = "0x6001262")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000387")]
	internal abstract IStylePropertyAnimationSystem styleAnimationSystem
	{
		[Token(Token = "0x6001263")]
		internal get { } //Length: 0
		[Token(Token = "0x6001264")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 0
	}

	[Token(Token = "0x17000378")]
	internal UIElementsBridge uiElementsBridge
	{
		[Address(RVA = "0x1C7FBC0", Offset = "0x1C7EDC0", Length = "0x66")]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600123D")]
		internal get { } //Length: 102
	}

	[Token(Token = "0x1700037E")]
	internal abstract uint version
	{
		[Token(Token = "0x6001252")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000384")]
	public abstract VisualElement visualTree
	{
		[Token(Token = "0x600125E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1C7F6F0", Offset = "0x1C7E8F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001286")]
	private static BaseVisualElementPanel() { }

	[Address(RVA = "0x1C7F730", Offset = "0x1C7E930", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ElementUnderPointer), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "CreateConfig", ReturnType = typeof(LayoutConfig))]
	[Calls(Type = typeof(LayoutMeasureFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutConfig), Member = "set_Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutMeasureFunction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600123E")]
	protected BaseVisualElementPanel() { }

	[Address(RVA = "0x1C7F8C0", Offset = "0x1C7EAC0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001278")]
	internal void add_atlasChanged(Action value) { }

	[Address(RVA = "0x1C7F970", Offset = "0x1C7EB70", Length = "0xA2")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600127D")]
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	[Address(RVA = "0x1C7FA20", Offset = "0x1C7EC20", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001273")]
	internal void add_isFlatChanged(Action value) { }

	[Address(RVA = "0x1C7FAD0", Offset = "0x1C7ECD0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600123B")]
	internal void add_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[Token(Token = "0x6001248")]
	public abstract void ApplyStyles() { }

	[Address(RVA = "0x1C7EB70", Offset = "0x1C7DD70", Length = "0x30")]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerUpEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerCancelEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetTemporaryElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001271")]
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	[Address(RVA = "0x1C7EBB0", Offset = "0x1C7DDB0", Length = "0x70")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MouseLeaveWindowEvent), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "PostDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseRuntimePanel), Member = "PointerLeavesPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001272")]
	internal bool CommitElementUnderPointers() { }

	[Address(RVA = "0x1C7EC30", Offset = "0x1C7DE30", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001285")]
	internal override IGenericMenu CreateMenu() { }

	[Address(RVA = "0x1C7ECF0", Offset = "0x1C7DEF0", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIElementsUtility), Member = "RemoveCachedPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDeviceState), Member = "RemovePanelData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutManager), Member = "get_SharedManager", ReturnType = typeof(LayoutManager))]
	[Calls(Type = typeof(LayoutManager), Member = "DestroyConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutConfig&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001240")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1C7EC80", Offset = "0x1C7DE80", Length = "0x61")]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600123F")]
	public override void Dispose() { }

	[Token(Token = "0x600127B")]
	public abstract AtlasBase get_atlas() { }

	[Address(RVA = "0x1C7FB80", Offset = "0x1C7ED80", Length = "0x11")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600124E")]
	internal PanelClearSettings get_clearSettings() { }

	[Token(Token = "0x6001265")]
	public abstract ContextType get_contextType() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600125A")]
	public override ContextualMenuManager get_contextualMenuManager() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001258")]
	internal override ICursorManager get_cursorManager() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600125C")]
	internal override DataBindingManager get_dataBindingManager() { }

	[Token(Token = "0x600125F")]
	public abstract EventDispatcher get_dispatcher() { }

	[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001269")]
	internal bool get_disposed() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001250")]
	internal bool get_duringLayoutPhase() { }

	[Token(Token = "0x6001238")]
	public abstract FocusController get_focusController() { }

	[Token(Token = "0x6001235")]
	public abstract GetViewDataDictionary get_getViewDataDictionary() { }

	[Token(Token = "0x6001253")]
	internal abstract uint get_hierarchyVersion() { }

	[Token(Token = "0x6001236")]
	public abstract int get_IMGUIContainersCount() { }

	[Token(Token = "0x6001230")]
	public abstract EventInterests get_IMGUIEventInterests() { }

	[Address(RVA = "0x532450", Offset = "0x531650", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001275")]
	public bool get_isFlat() { }

	[Token(Token = "0x6001232")]
	public abstract ScriptableObject get_ownerObject() { }

	[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600124C")]
	public float get_referenceSpritePixelsPerUnit() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001256")]
	internal override RepaintData get_repaintData() { }

	[Token(Token = "0x600123A")]
	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	[Token(Token = "0x6001234")]
	public abstract SavePersistentViewData get_saveViewData() { }

	[Address(RVA = "0x1C7FBA0", Offset = "0x1C7EDA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001249")]
	internal float get_scale() { }

	[Address(RVA = "0x1C7FBB0", Offset = "0x1C7EDB0", Length = "0xD")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VisualElement), Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(LayoutNode&), typeof(float), typeof(LayoutMeasureMode), typeof(float), typeof(LayoutMeasureMode), typeof(LayoutSize&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeStyleUpdater), Member = "ApplyStyles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x600124B")]
	public override float get_scaledPixelsPerPoint() { }

	[Token(Token = "0x6001262")]
	internal abstract IScheduler get_scheduler() { }

	[Token(Token = "0x6001263")]
	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	[Address(RVA = "0x1C7FBC0", Offset = "0x1C7EDC0", Length = "0x66")]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "ProcessUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600123D")]
	internal UIElementsBridge get_uiElementsBridge() { }

	[Token(Token = "0x6001252")]
	internal abstract uint get_version() { }

	[Token(Token = "0x600125E")]
	public abstract VisualElement get_visualTree() { }

	[Address(RVA = "0x1C7EE60", Offset = "0x1C7E060", Length = "0x21")]
	[CalledBy(Type = typeof(Clickable), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClickDetector), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IPointerEvent)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BasePopupField`2), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EnumField), Member = "ContainsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "DispatchToElementUnderPointerOrPanelRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "ApplyStyleCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateHoverPseudoStateAfterCaptureChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SetComputedStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "UpdateCursorStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600126C")]
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	[Token(Token = "0x600126B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[Address(RVA = "0x1C7EE90", Offset = "0x1C7E090", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600127A")]
	protected void InvokeAtlasChanged() { }

	[Address(RVA = "0x1C7EEB0", Offset = "0x1C7E0B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001280")]
	internal void InvokeBeforeUpdate() { }

	[Address(RVA = "0x1C7EED0", Offset = "0x1C7E0D0", Length = "0x26")]
	[CalledBy(Type = typeof(VisualElement), Member = "SetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "InvokeHierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyChangeType), typeof(System.Collections.Generic.IReadOnlyList`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600127F")]
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Token(Token = "0x6001254")]
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	[Address(RVA = "0x1C7EF00", Offset = "0x1C7E100", Length = "0x80")]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "GetDropTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(DragEventsProcessor))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001266")]
	public override VisualElement Pick(Vector2 point) { }

	[Token(Token = "0x6001267")]
	public abstract VisualElement Pick(Vector2 point, int pointerId) { }

	[Token(Token = "0x6001268")]
	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	[Address(RVA = "0x1C7EF80", Offset = "0x1C7E180", Length = "0x15D")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "HasLocationFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType), typeof(LocationFlag)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001270")]
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	[Address(RVA = "0x1C7FC30", Offset = "0x1C7EE30", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001279")]
	internal void remove_atlasChanged(Action value) { }

	[Address(RVA = "0x1C7FCE0", Offset = "0x1C7EEE0", Length = "0xA2")]
	[CalledBy(Type = typeof(VisualTreeDataBindingsUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600127E")]
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	[Address(RVA = "0x1C7FD90", Offset = "0x1C7EF90", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6001274")]
	internal void remove_isFlatChanged(Action value) { }

	[Address(RVA = "0x1C7FE40", Offset = "0x1C7F040", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600123C")]
	internal void remove_panelDisposed(Action<BaseVisualElementPanel> value) { }

	[Address(RVA = "0x1C7F0E0", Offset = "0x1C7E2E0", Length = "0x21")]
	[CalledBy(Type = typeof(VisualElement), Member = "WillChangePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "RemoveElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126D")]
	internal void RemoveElementFromPointerCache(VisualElement e) { }

	[Address(RVA = "0x1C7F110", Offset = "0x1C7E310", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001284")]
	public override void Render() { }

	[Token(Token = "0x6001241")]
	public abstract void Repaint(Event e) { }

	[Address(RVA = "0x1C7F160", Offset = "0x1C7E360", Length = "0x122")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendKeyUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Direction), typeof(Focusable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.AxisEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualElement), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualElement), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(UITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventDispatcher), Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(BaseVisualElementPanel), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001261")]
	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	[Token(Token = "0x600127C")]
	public abstract void set_atlas(AtlasBase value) { }

	[Address(RVA = "0x1C7FEF0", Offset = "0x1C7F0F0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600124F")]
	internal void set_clearSettings(PanelClearSettings value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600125B")]
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	[Address(RVA = "0x2DD510", Offset = "0x2DC710", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001259")]
	internal override void set_cursorManager(ICursorManager value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600125D")]
	internal override void set_dataBindingManager(DataBindingManager value) { }

	[Token(Token = "0x6001260")]
	public abstract void set_dispatcher(EventDispatcher value) { }

	[Address(RVA = "0x2F5BD0", Offset = "0x2F4DD0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600126A")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x52F680", Offset = "0x52E880", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001251")]
	internal void set_duringLayoutPhase(bool value) { }

	[Token(Token = "0x6001239")]
	public abstract void set_focusController(FocusController value) { }

	[Token(Token = "0x6001237")]
	public abstract void set_IMGUIContainersCount(int value) { }

	[Token(Token = "0x6001231")]
	public abstract void set_IMGUIEventInterests(EventInterests value) { }

	[Address(RVA = "0x1C7FF00", Offset = "0x1C7F100", Length = "0x44")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "SetSpecializedHierarchyFlagsUpdater", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001276")]
	public void set_isFlat(bool value) { }

	[Token(Token = "0x6001233")]
	protected abstract void set_ownerObject(ScriptableObject value) { }

	[Address(RVA = "0x1818520", Offset = "0x1817720", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600124D")]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001257")]
	internal override void set_repaintData(RepaintData value) { }

	[Address(RVA = "0x1C7FF50", Offset = "0x1C7F150", Length = "0xA6")]
	[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutConfig), Member = "get_PointScaleFactor", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600124A")]
	internal void set_scale(float value) { }

	[Token(Token = "0x6001264")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	[Address(RVA = "0x1C7F290", Offset = "0x1C7E490", Length = "0x102")]
	[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "set_isFlat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualTreeWorldSpaceHierarchyFlagsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001277")]
	internal void SetSpecializedHierarchyFlagsUpdater() { }

	[Address(RVA = "0x1C7F3A0", Offset = "0x1C7E5A0", Length = "0x30")]
	[CalledBy(Type = typeof(MouseEventBase`1), Member = "PreDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UpdateWorldSpacePointers", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126F")]
	internal void SetTopElementUnderPointer(int pointerId, VisualElement element, Vector2 position) { }

	[Address(RVA = "0x1C7F3E0", Offset = "0x1C7E5E0", Length = "0x30")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendPositionBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(int), typeof(System.Nullable`1<System.Int32>), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "SendRayBasedEvent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "System.Func`3<Vector3, TArg, EventBase>", "TArg", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "UpdatePointerEventTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TPointerEvent", "UnityEngine.UIElements.PanelEventHandler+PointerEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126E")]
	internal void SetTopElementUnderPointer(int pointerId, VisualElement element, EventBase triggerEvent) { }

	[Token(Token = "0x6001255")]
	internal abstract void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	[Token(Token = "0x6001243")]
	public abstract void TickSchedulingUpdaters() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001282")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001283")]
	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	[Token(Token = "0x6001245")]
	public abstract void UpdateAnimations() { }

	[Token(Token = "0x6001246")]
	public abstract void UpdateBindings() { }

	[Token(Token = "0x6001247")]
	public abstract void UpdateDataBinding() { }

	[Address(RVA = "0x1C7F420", Offset = "0x1C7E620", Length = "0x2CB")]
	[CalledBy(Type = typeof(VisualTreeHierarchyFlagsUpdater), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "HasLocationFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType), typeof(LocationFlag)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPointerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ContextType)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "SetElementUnderPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementUnderPointer), Member = "CommitElementUnderPointers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher), typeof(ContextType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6001281")]
	internal bool UpdateElementUnderPointers() { }

	[Token(Token = "0x6001244")]
	public abstract void UpdateForRepaint() { }

	[Token(Token = "0x6001242")]
	public abstract void ValidateLayout() { }

}


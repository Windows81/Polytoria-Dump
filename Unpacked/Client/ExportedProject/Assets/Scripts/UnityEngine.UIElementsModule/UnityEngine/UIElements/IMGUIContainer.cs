namespace UnityEngine.UIElements;

[Token(Token = "0x2000286")]
public class IMGUIContainer : VisualElement, IDisposable
{
	[Token(Token = "0x200028B")]
	private struct GUIGlobals
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A17")]
		public Matrix4x4 matrix; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A18")]
		public Color color; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A19")]
		public Color contentColor; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A1A")]
		public Color backgroundColor; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A1B")]
		public bool enabled; //Field offset: 0x70
		[FieldOffset(Offset = "0x71")]
		[Token(Token = "0x4000A1C")]
		public bool changed; //Field offset: 0x71
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000A1D")]
		public int displayIndex; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A1E")]
		public float pixelsPerPoint; //Field offset: 0x78

	}

	[Token(Token = "0x200028A")]
	public struct NotUITKScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A16")]
		private bool wasUITK; //Field offset: 0x0

		[Address(RVA = "0x1C89570", Offset = "0x1C88770", Length = "0xCB")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60011D5")]
		public NotUITKScope() { }

		[Address(RVA = "0x1C894D0", Offset = "0x1C886D0", Length = "0x92")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60011D6")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000289")]
	public struct UITKScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A15")]
		private bool wasUITK; //Field offset: 0x0

		[Address(RVA = "0x1C93FC0", Offset = "0x1C931C0", Length = "0xCB")]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "ValidateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "TickSchedulingUpdaters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "Repaint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "Render", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "UnityEngine.UIElements.IUIElementsUtility.ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60011D3")]
		public UITKScope() { }

		[Address(RVA = "0x1C93F20", Offset = "0x1C93120", Length = "0x92")]
		[CalledBy(Type = typeof(BaseVisualElementPanel), Member = "SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(DispatchMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "ValidateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "TickSchedulingUpdaters", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "Repaint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "Render", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "UnityEngine.UIElements.IUIElementsUtility.ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60011D4")]
		public override void Dispose() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000287")]
	internal class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
	{

		[Address(RVA = "0x1C94440", Offset = "0x1C93640", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60011D1")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000288")]
	internal class UxmlTraits : UxmlTraits
	{

		[Address(RVA = "0x1C94480", Offset = "0x1C93680", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60011D2")]
		public UxmlTraits() { }

	}

	[Token(Token = "0x40009F9")]
	internal static readonly BindingId cullingEnabledProperty; //Field offset: 0x0
	[Token(Token = "0x40009FA")]
	internal static readonly BindingId contextTypeProperty; //Field offset: 0x98
	[Token(Token = "0x4000A0C")]
	public static readonly string ussClassName; //Field offset: 0x130
	[Token(Token = "0x4000A0D")]
	internal static readonly string ussFoldoutChildDepthClassName; //Field offset: 0x138
	[Token(Token = "0x4000A0E")]
	internal static readonly List<String> ussFoldoutChildDepthClassNames; //Field offset: 0x140
	[Token(Token = "0x4000A10")]
	private static readonly ProfilerMarker k_OnGUIMarker; //Field offset: 0x148
	[Token(Token = "0x4000A11")]
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; //Field offset: 0x150
	[Token(Token = "0x4000A12")]
	private static Event s_DefaultMeasureEvent; //Field offset: 0x158
	[Token(Token = "0x4000A13")]
	private static Event s_MeasureEvent; //Field offset: 0x160
	[Token(Token = "0x4000A14")]
	private static Event s_CurrentEvent; //Field offset: 0x168
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x40009FB")]
	private Action m_OnGUIHandler; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x40009FC")]
	private ObjectGUIState m_ObjectGUIState; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x40009FD")]
	internal bool useOwnerObjectGUIState; //Field offset: 0x2E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x40009FE")]
	private Rect <lastWorldClip>k__BackingField; //Field offset: 0x2E4
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x40009FF")]
	private bool m_CullingEnabled; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F5")]
	[Token(Token = "0x4000A00")]
	private bool m_IsFocusDelegated; //Field offset: 0x2F5
	[FieldOffset(Offset = "0x2F6")]
	[Token(Token = "0x4000A01")]
	private bool m_RefreshCachedLayout; //Field offset: 0x2F6
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000A02")]
	private LayoutCache m_Cache; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000A03")]
	private Rect m_CachedClippingRect; //Field offset: 0x300
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000A04")]
	private Matrix4x4 m_CachedTransform; //Field offset: 0x310
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000A05")]
	private ContextType m_ContextType; //Field offset: 0x350
	[FieldOffset(Offset = "0x354")]
	[Token(Token = "0x4000A06")]
	private bool lostFocus; //Field offset: 0x354
	[FieldOffset(Offset = "0x355")]
	[Token(Token = "0x4000A07")]
	private bool receivedFocus; //Field offset: 0x355
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000A08")]
	private FocusChangeDirection focusChangeDirection; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000A09")]
	private bool hasFocusableControls; //Field offset: 0x360
	[FieldOffset(Offset = "0x364")]
	[Token(Token = "0x4000A0A")]
	private int newKeyboardFocusControlID; //Field offset: 0x364
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000A0B")]
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; //Field offset: 0x368
	[FieldOffset(Offset = "0x36C")]
	[Token(Token = "0x4000A0F")]
	private GUIGlobals m_GUIGlobals; //Field offset: 0x36C

	[Token(Token = "0x1700035D")]
	private LayoutCache cache
	{
		[Address(RVA = "0x1C865D0", Offset = "0x1C857D0", Length = "0x7B")]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60011AE")]
		private get { } //Length: 123
	}

	[Token(Token = "0x17000362")]
	public virtual bool canGrabFocus
	{
		[Address(RVA = "0x1C86650", Offset = "0x1C85850", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
		[Token(Token = "0x60011B4")]
		 get { } //Length: 41
	}

	[CreateProperty]
	[Token(Token = "0x17000360")]
	public ContextType contextType
	{
		[Address(RVA = "0x18CF220", Offset = "0x18CE420", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B1")]
		 get { } //Length: 7
		[Address(RVA = "0x1C867D0", Offset = "0x1C859D0", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60011B2")]
		 set { } //Length: 124
	}

	[CreateProperty]
	[Token(Token = "0x1700035C")]
	public bool cullingEnabled
	{
		[Address(RVA = "0x1C86680", Offset = "0x1C85880", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60011AC")]
		 get { } //Length: 10
		[Address(RVA = "0x1C86850", Offset = "0x1C85A50", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60011AD")]
		 set { } //Length: 136
	}

	[Token(Token = "0x17000361")]
	internal bool focusOnlyIfHasFocusableControls
	{
		[Address(RVA = "0x1BDC3B0", Offset = "0x1BDB5B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60011B3")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700035A")]
	internal ObjectGUIState guiState
	{
		[Address(RVA = "0x1C86690", Offset = "0x1C85890", Length = "0xBC")]
		[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "UnityEngine.ObjectGUIState", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60011A9")]
		internal get { } //Length: 188
	}

	[Token(Token = "0x1700035B")]
	internal Rect lastWorldClip
	{
		[Address(RVA = "0x1C86750", Offset = "0x1C85950", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60011AA")]
		internal get { } //Length: 14
		[Address(RVA = "0x1C868E0", Offset = "0x1C85AE0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60011AB")]
		internal set { } //Length: 11
	}

	[Token(Token = "0x1700035F")]
	private float layoutMeasuredHeight
	{
		[Address(RVA = "0x1C86760", Offset = "0x1C85960", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60011B0")]
		private get { } //Length: 44
	}

	[Token(Token = "0x1700035E")]
	private float layoutMeasuredWidth
	{
		[Address(RVA = "0x1C86790", Offset = "0x1C85990", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60011AF")]
		private get { } //Length: 44
	}

	[Token(Token = "0x17000359")]
	public Action onGUIHandler
	{
		[Address(RVA = "0x1C867C0", Offset = "0x1C859C0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60011A7")]
		 get { } //Length: 10
		[Address(RVA = "0x1C868F0", Offset = "0x1C85AF0", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
		[Token(Token = "0x60011A8")]
		 set { } //Length: 100
	}

	[Address(RVA = "0x1C85B90", Offset = "0x1C84D90", Length = "0x6E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x60011B5")]
	private static IMGUIContainer() { }

	[Address(RVA = "0x1C86280", Offset = "0x1C85480", Length = "0x33C")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "set_requireMeasureFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011B7")]
	public IMGUIContainer(Action onGUIHandler) { }

	[Address(RVA = "0x1C865C0", Offset = "0x1C857C0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMGUIContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011B6")]
	public IMGUIContainer() { }

	[Address(RVA = "0x1C85980", Offset = "0x1C84B80", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x60011D0")]
	private void <DoOnGUI>b__61_0() { }

	[Address(RVA = "0x1C81EC0", Offset = "0x1C810C0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011CE")]
	public override void Dispose() { }

	[Address(RVA = "0x1C81F30", Offset = "0x1C81130", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.ObjectGUIState", Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x60011CF")]
	protected override void Dispose(bool disposeManaged) { }

	[Address(RVA = "0x1C81F50", Offset = "0x1C81150", Length = "0x31A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "ComputeAAAlignedBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Matrix4x4)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60011BD")]
	private void DoIMGUIRepaint() { }

	[Address(RVA = "0x1C82270", Offset = "0x1C81470", Length = "0x3BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotUITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(NotUITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011CB")]
	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x1C82640", Offset = "0x1C81840", Length = "0x101D")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GUIUtility), Member = "get_keyboardControl", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180C3CD30")]
	[Calls(Type = typeof(Event), Member = "get_character", ReturnType = typeof(char))]
	[Calls(Type = typeof(Event), Member = "Use", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C920")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B5C970")]
	[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToFirstControlId", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "SetKeyboardControlToLastControlId", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "UnityEngine.GUIClip+ParentClipScope", Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_keyboardControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "IsExitGUIException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181C7C550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "OwnsId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIUtility), Member = "set_pixelsPerPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.GUIClip", Member = "Internal_GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "get_guiDepth", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUI), Member = "get_matrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_contentColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_displayIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUI), Member = "get_changed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011BB")]
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true) { }

	[Address(RVA = "0x1C865D0", Offset = "0x1C857D0", Length = "0x7B")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "get_layoutMeasuredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(MeasureMode), typeof(float), typeof(MeasureMode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60011AE")]
	private LayoutCache get_cache() { }

	[Address(RVA = "0x1C86650", Offset = "0x1C85850", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_canGrabFocus", ReturnType = typeof(bool))]
	[Token(Token = "0x60011B4")]
	public virtual bool get_canGrabFocus() { }

	[Address(RVA = "0x18CF220", Offset = "0x18CE420", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B1")]
	public ContextType get_contextType() { }

	[Address(RVA = "0x1C86680", Offset = "0x1C85880", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60011AC")]
	public bool get_cullingEnabled() { }

	[Address(RVA = "0x1BDC3B0", Offset = "0x1BDB5B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B3")]
	internal bool get_focusOnlyIfHasFocusableControls() { }

	[Address(RVA = "0x1C86690", Offset = "0x1C85890", Length = "0xBC")]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.GUILayoutUtility+LayoutCache", typeof(Event), typeof(IMGUIContainer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "UnityEngine.ObjectGUIState", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011A9")]
	internal ObjectGUIState get_guiState() { }

	[Address(RVA = "0x1C86750", Offset = "0x1C85950", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60011AA")]
	internal Rect get_lastWorldClip() { }

	[Address(RVA = "0x1C86760", Offset = "0x1C85960", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011B0")]
	private float get_layoutMeasuredHeight() { }

	[Address(RVA = "0x1C86790", Offset = "0x1C85990", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011AF")]
	private float get_layoutMeasuredWidth() { }

	[Address(RVA = "0x1C867C0", Offset = "0x1C859C0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60011A7")]
	public Action get_onGUIHandler() { }

	[Address(RVA = "0x1C83660", Offset = "0x1C82860", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011CC")]
	private Rect GetCurrentClipRect() { }

	[Address(RVA = "0x1C836E0", Offset = "0x1C828E0", Length = "0x21A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011CD")]
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	[Address(RVA = "0x1C83900", Offset = "0x1C82B00", Length = "0x5BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FocusController), Member = "IgnoreEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElementUtils), Member = "GetFoldoutDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)})]
	[Token(Token = "0x60011C9")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x166E740", Offset = "0x166D940", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(DetachFromPanelEvent), typeof(AttachToPanelEvent)})]
	[EventInterest(EventInterestOptionsInternal::TriggeredByOS (426094))]
	[Token(Token = "0x60011C8")]
	internal virtual void HandleEventBubbleUpDisabled(EventBase evt) { }

	[Address(RVA = "0x1C84190", Offset = "0x1C83390", Length = "0x2C7")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C5")]
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	[Address(RVA = "0x1C84460", Offset = "0x1C83660", Length = "0x5A0")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(GUIUtility), Member = "ExitGUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_hotControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "set_commandName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IMGUIContainer), Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = "ResetCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotUITKScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUIContainer), Member = "get_cache", ReturnType = "UnityEngine.GUILayoutUtility+LayoutCache")]
	[Calls(Type = "UnityEngine.EventInterests", Member = "WantsLayoutPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotUITKScope), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.EventInterests", Member = "WantsEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C7")]
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	[Address(RVA = "0x1C83EC0", Offset = "0x1C830C0", Length = "0x2CC")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C6")]
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	[Address(RVA = "0x1C84A10", Offset = "0x1C83C10", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C1")]
	private bool IsContainerCapturingTheMouse() { }

	[Address(RVA = "0x1C84AF0", Offset = "0x1C83CF0", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C4")]
	private static bool IsDockAreaMouseUp(EventBase evt) { }

	[Address(RVA = "0x1C84BE0", Offset = "0x1C83DE0", Length = "0x255")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "VerifyBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C3")]
	private bool IsEventInsideLocalWindow(EventBase evt) { }

	[Address(RVA = "0x1C84E40", Offset = "0x1C84040", Length = "0x1D8")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "VerifyBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C2")]
	private bool IsLocalEvent(EventBase evt) { }

	[Address(RVA = "0x1C85020", Offset = "0x1C84220", Length = "0x14")]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011BC")]
	public void MarkDirtyLayout() { }

	[Address(RVA = "0x1C85040", Offset = "0x1C84240", Length = "0x172")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EntryRecorder), Member = "DrawImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011B8")]
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1C851C0", Offset = "0x1C843C0", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "set_matrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_contentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_backgroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "set_displayIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIUtility), Member = "set_pixelsPerPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011BA")]
	private void RestoreGlobals() { }

	[Address(RVA = "0x1C85340", Offset = "0x1C84540", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_matrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GUI), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_contentColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_backgroundColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GUI), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUI), Member = "get_changed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_displayIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUIUtility), Member = "get_pixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011B9")]
	private void SaveGlobals() { }

	[Address(RVA = "0x1C85560", Offset = "0x1C84760", Length = "0x293")]
	[CalledBy(Type = typeof(EventDispatchUtilities), Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_isDirectManipulationDevice", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60011BE")]
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true) { }

	[Address(RVA = "0x1C85480", Offset = "0x1C84680", Length = "0xDB")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IMGUIContainer), Member = "VerifyBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventBase), Member = "get_imguiEvent", ReturnType = typeof(Event))]
	[Calls(Type = typeof(IMGUIContainer), Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60011BF")]
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	[Address(RVA = "0x1C867D0", Offset = "0x1C859D0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011B2")]
	public void set_contextType(ContextType value) { }

	[Address(RVA = "0x1C86850", Offset = "0x1C85A50", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011AD")]
	public void set_cullingEnabled(bool value) { }

	[Address(RVA = "0x1C868E0", Offset = "0x1C85AE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60011AB")]
	internal void set_lastWorldClip(Rect value) { }

	[Address(RVA = "0x1C868F0", Offset = "0x1C85AF0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011A8")]
	public void set_onGUIHandler(Action value) { }

	[Address(RVA = "0x1C85800", Offset = "0x1C84A00", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementUtils), Member = "GetFoldoutDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60011CA")]
	private void SetFoldoutDepthClass() { }

	[Address(RVA = "0x1C85990", Offset = "0x1C84B90", Length = "0x1F8")]
	[CalledBy(Type = typeof(IMGUIContainer), Member = "SendEventToIMGUIRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IMGUIContainer), Member = "IsLocalEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IMGUIContainer), Member = "IsEventInsideLocalWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011C0")]
	private bool VerifyBounds(EventBase evt) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x200013E")]
public class ScrollView : VisualElement
{
	[Token(Token = "0x2000142")]
	internal enum NestedInteractionKind
	{
		Default = 0,
		StopScrolling = 1,
		ForwardScrolling = 2,
	}

	[Token(Token = "0x2000141")]
	internal enum TouchScrollBehavior
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	[Token(Token = "0x2000143")]
	public enum TouchScrollingResult
	{
		Apply = 0,
		Forward = 1,
		Block = 2,
	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200013F")]
	internal class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{

		[Address(RVA = "0x1C2C450", Offset = "0x1C2B650", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60009F0")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000140")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000656")]
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000657")]
		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000658")]
		private UxmlBoolAttributeDescription m_ShowHorizontal; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000659")]
		private UxmlBoolAttributeDescription m_ShowVertical; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400065A")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400065B")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400065C")]
		private UxmlFloatAttributeDescription m_HorizontalPageSize; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400065D")]
		private UxmlFloatAttributeDescription m_VerticalPageSize; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400065E")]
		private UxmlFloatAttributeDescription m_MouseWheelScrollSize; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400065F")]
		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000660")]
		private UxmlFloatAttributeDescription m_ScrollDecelerationRate; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000661")]
		private UxmlFloatAttributeDescription m_Elasticity; //Field offset: 0xE0

		[Address(RVA = "0x1C2EDB0", Offset = "0x1C2DFB0", Length = "0x593")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlFloatAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009F2")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2DA70", Offset = "0x1C2CC70", Length = "0xA46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = "TryGetValueFromBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_horizontalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_verticalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "set_touchScrollBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScrollBehavior)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009F1")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x400060D")]
	internal static readonly BindingId horizontalScrollerVisibilityProperty; //Field offset: 0x0
	[Token(Token = "0x400060E")]
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x98
	[Token(Token = "0x400060F")]
	internal static readonly BindingId scrollOffsetProperty; //Field offset: 0x130
	[Token(Token = "0x4000610")]
	internal static readonly BindingId horizontalPageSizeProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000611")]
	internal static readonly BindingId verticalPageSizeProperty; //Field offset: 0x260
	[Token(Token = "0x4000612")]
	internal static readonly BindingId mouseWheelScrollSizeProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000613")]
	internal static readonly BindingId scrollDecelerationRateProperty; //Field offset: 0x390
	[Token(Token = "0x4000614")]
	internal static readonly BindingId elasticityProperty; //Field offset: 0x428
	[Token(Token = "0x4000615")]
	internal static readonly BindingId touchScrollBehaviorProperty; //Field offset: 0x4C0
	[Token(Token = "0x4000616")]
	internal static readonly BindingId nestedInteractionKindProperty; //Field offset: 0x558
	[Token(Token = "0x4000617")]
	internal static readonly BindingId modeProperty; //Field offset: 0x5F0
	[Token(Token = "0x4000618")]
	internal static readonly BindingId elasticAnimationIntervalMsProperty; //Field offset: 0x688
	[Token(Token = "0x4000625")]
	private static readonly float k_DefaultScrollDecelerationRate; //Field offset: 0x720
	[Token(Token = "0x4000629")]
	private static readonly float k_DefaultElasticity; //Field offset: 0x724
	[Token(Token = "0x4000636")]
	public static readonly string ussClassName; //Field offset: 0x728
	[Token(Token = "0x4000637")]
	public static readonly string viewportUssClassName; //Field offset: 0x730
	[Token(Token = "0x4000638")]
	public static readonly string horizontalVariantViewportUssClassName; //Field offset: 0x738
	[Token(Token = "0x4000639")]
	public static readonly string verticalVariantViewportUssClassName; //Field offset: 0x740
	[Token(Token = "0x400063A")]
	public static readonly string verticalHorizontalVariantViewportUssClassName; //Field offset: 0x748
	[Token(Token = "0x400063B")]
	public static readonly string contentAndVerticalScrollUssClassName; //Field offset: 0x750
	[Token(Token = "0x400063C")]
	public static readonly string contentUssClassName; //Field offset: 0x758
	[Token(Token = "0x400063D")]
	public static readonly string horizontalVariantContentUssClassName; //Field offset: 0x760
	[Token(Token = "0x400063E")]
	public static readonly string verticalVariantContentUssClassName; //Field offset: 0x768
	[Token(Token = "0x400063F")]
	public static readonly string verticalHorizontalVariantContentUssClassName; //Field offset: 0x770
	[Token(Token = "0x4000640")]
	public static readonly string hScrollerUssClassName; //Field offset: 0x778
	[Token(Token = "0x4000641")]
	public static readonly string vScrollerUssClassName; //Field offset: 0x780
	[Token(Token = "0x4000642")]
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x788
	[Token(Token = "0x4000643")]
	public static readonly string verticalVariantUssClassName; //Field offset: 0x790
	[Token(Token = "0x4000644")]
	public static readonly string verticalHorizontalVariantUssClassName; //Field offset: 0x798
	[Token(Token = "0x4000645")]
	public static readonly string scrollVariantUssClassName; //Field offset: 0x7A0
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000619")]
	private int m_FirstLayoutPass; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D4")]
	[Token(Token = "0x400061A")]
	private ScrollerVisibility m_HorizontalScrollerVisibility; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400061B")]
	private ScrollerVisibility m_VerticalScrollerVisibility; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400061C")]
	private long m_ElasticAnimationIntervalMs; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400061D")]
	private VisualElement m_AttachedRootVisualContainer; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400061E")]
	private float m_SingleLineHeight; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F4")]
	[Token(Token = "0x400061F")]
	private bool m_SingleLineHeightDirtyFlag; //Field offset: 0x2F4
	[FieldOffset(Offset = "0x2F5")]
	[Token(Token = "0x4000620")]
	internal bool m_MouseWheelScrollSizeIsInline; //Field offset: 0x2F5
	[DontCreateProperty]
	[FieldOffset(Offset = "0x2F8")]
	[SerializeField]
	[Token(Token = "0x4000621")]
	private Vector2 m_ScrollOffset; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000622")]
	private float m_HorizontalPageSize; //Field offset: 0x300
	[FieldOffset(Offset = "0x304")]
	[Token(Token = "0x4000623")]
	private float m_VerticalPageSize; //Field offset: 0x304
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000624")]
	private float m_MouseWheelScrollSize; //Field offset: 0x308
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000626")]
	private float m_ScrollDecelerationRate; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000627")]
	private float k_ScaledPixelsPerPointMultiplier; //Field offset: 0x310
	[FieldOffset(Offset = "0x314")]
	[Token(Token = "0x4000628")]
	private float k_TouchScrollInertiaBaseTimeInterval; //Field offset: 0x314
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x400062A")]
	private float m_Elasticity; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x400062B")]
	private TouchScrollBehavior m_TouchScrollBehavior; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x400062C")]
	private NestedInteractionKind m_NestedInteractionKind; //Field offset: 0x320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x400062D")]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x400062E")]
	private readonly Scroller <horizontalScroller>k__BackingField; //Field offset: 0x330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x400062F")]
	private readonly Scroller <verticalScroller>k__BackingField; //Field offset: 0x338
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x4000630")]
	private VisualElement m_ContentContainer; //Field offset: 0x340
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x4000631")]
	private VisualElement m_ContentAndVerticalScrollContainer; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x4000632")]
	private float previousVerticalTouchScrollTimeStamp; //Field offset: 0x350
	[FieldOffset(Offset = "0x354")]
	[Token(Token = "0x4000633")]
	private float previousHorizontalTouchScrollTimeStamp; //Field offset: 0x354
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x4000634")]
	private float elapsedTimeSinceLastVerticalTouchScroll; //Field offset: 0x358
	[FieldOffset(Offset = "0x35C")]
	[Token(Token = "0x4000635")]
	private float elapsedTimeSinceLastHorizontalTouchScroll; //Field offset: 0x35C
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x4000646")]
	private ScrollViewMode m_Mode; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x4000647")]
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000648")]
	private Vector2 m_StartPosition; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000649")]
	private Vector2 m_PointerStartPosition; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x400064A")]
	private Vector2 m_Velocity; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x400064B")]
	private Vector2 m_SpringBackVelocity; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x400064C")]
	private Vector2 m_LowBounds; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x400064D")]
	private Vector2 m_HighBounds; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x400064E")]
	private float m_LastVelocityLerpTime; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A4")]
	[Token(Token = "0x400064F")]
	private bool m_StartedMoving; //Field offset: 0x3A4
	[FieldOffset(Offset = "0x3A5")]
	[Token(Token = "0x4000650")]
	private bool m_TouchPointerMoveAllowed; //Field offset: 0x3A5
	[FieldOffset(Offset = "0x3A6")]
	[Token(Token = "0x4000651")]
	private bool m_TouchStoppedVelocity; //Field offset: 0x3A6
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000652")]
	private VisualElement m_CapturedTarget; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x4000653")]
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000654")]
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x4000655")]
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; //Field offset: 0x3C0

	[Token(Token = "0x170001B4")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x1C23DC0", Offset = "0x1C22FC0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60009C3")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170001B1")]
	public VisualElement contentViewport
	{
		[Address(RVA = "0x833AB0", Offset = "0x832CB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C0")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x1700019F")]
	public long elasticAnimationIntervalMs
	{
		[Address(RVA = "0x1C23DD0", Offset = "0x1C22FD0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600099C")]
		 get { } //Length: 10
		[Address(RVA = "0x1C240F0", Offset = "0x1C232F0", Length = "0x148")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600099D")]
		 set { } //Length: 328
	}

	[CreateProperty]
	[Token(Token = "0x170001AE")]
	public float elasticity
	{
		[Address(RVA = "0x1C23DE0", Offset = "0x1C22FE0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60009B1")]
		 get { } //Length: 11
		[Address(RVA = "0x1C24240", Offset = "0x1C23440", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009B2")]
		 set { } //Length: 264
	}

	[Token(Token = "0x170001AC")]
	private bool hasInertia
	{
		[Address(RVA = "0x1C23DF0", Offset = "0x1C22FF0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009AE")]
		private get { } //Length: 20
	}

	[CreateProperty]
	[Token(Token = "0x170001A7")]
	public float horizontalPageSize
	{
		[Address(RVA = "0x1C17AC0", Offset = "0x1C16CC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009A6")]
		 get { } //Length: 11
		[Address(RVA = "0x1C24350", Offset = "0x1C23550", Length = "0xAB")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScrollView), Member = "UpdateHorizontalSliderPageSize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60009A7")]
		 set { } //Length: 171
	}

	[Token(Token = "0x170001B2")]
	public Scroller horizontalScroller
	{
		[Address(RVA = "0xF52590", Offset = "0xF51790", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C1")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x1700019D")]
	public ScrollerVisibility horizontalScrollerVisibility
	{
		[Address(RVA = "0x1C23E10", Offset = "0x1C23010", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000998")]
		 get { } //Length: 9
		[Address(RVA = "0x1C24400", Offset = "0x1C23600", Length = "0x107")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000999")]
		 set { } //Length: 263
	}

	[Token(Token = "0x170001A5")]
	internal bool isHorizontalScrollDisplayed
	{
		[Address(RVA = "0x1C23E20", Offset = "0x1C23020", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009A3")]
		internal get { } //Length: 97
	}

	[Token(Token = "0x170001A4")]
	internal bool isVerticalScrollDisplayed
	{
		[Address(RVA = "0x1C23E90", Offset = "0x1C23090", Length = "0x61")]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009A2")]
		internal get { } //Length: 97
	}

	[CreateProperty]
	[Token(Token = "0x170001B5")]
	public ScrollViewMode mode
	{
		[Address(RVA = "0x1C23F00", Offset = "0x1C23100", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60009C6")]
		 get { } //Length: 7
		[Address(RVA = "0x1C24510", Offset = "0x1C23710", Length = "0x93")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60009C7")]
		 set { } //Length: 147
	}

	[CreateProperty]
	[Token(Token = "0x170001A9")]
	public float mouseWheelScrollSize
	{
		[Address(RVA = "0x834CF0", Offset = "0x833EF0", Length = "0xB")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009AA")]
		 get { } //Length: 11
		[Address(RVA = "0x1C245B0", Offset = "0x1C237B0", Length = "0xC6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60009AB")]
		 set { } //Length: 198
	}

	[Token(Token = "0x170001A2")]
	internal bool needsHorizontal
	{
		[Address(RVA = "0x1C23F10", Offset = "0x1C23110", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009A0")]
		internal get { } //Length: 70
	}

	[Token(Token = "0x170001A3")]
	internal bool needsVertical
	{
		[Address(RVA = "0x1C23F60", Offset = "0x1C23160", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009A1")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 70
	}

	[CreateProperty]
	[Token(Token = "0x170001B0")]
	public NestedInteractionKind nestedInteractionKind
	{
		[Address(RVA = "0x833A90", Offset = "0x832C90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60009B5")]
		 get { } //Length: 7
		[Address(RVA = "0x1C24680", Offset = "0x1C23880", Length = "0x7E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60009B6")]
		 set { } //Length: 126
	}

	[Token(Token = "0x170001AB")]
	internal float scrollableHeight
	{
		[Address(RVA = "0x1C23FE0", Offset = "0x1C231E0", Length = "0x6E")]
		[CalledBy(Type = typeof(ScrollView), Member = "GetYDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "get_needsVertical", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009AD")]
		internal get { } //Length: 110
	}

	[Token(Token = "0x170001AA")]
	internal float scrollableWidth
	{
		[Address(RVA = "0x1C24050", Offset = "0x1C23250", Length = "0x6E")]
		[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnScrollersGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "GetXDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(ScrollView), Member = "get_needsHorizontal", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009AC")]
		internal get { } //Length: 110
	}

	[CreateProperty]
	[Token(Token = "0x170001AD")]
	public float scrollDecelerationRate
	{
		[Address(RVA = "0x1C23FB0", Offset = "0x1C231B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60009AF")]
		 get { } //Length: 11
		[Address(RVA = "0x1C24700", Offset = "0x1C23900", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009B0")]
		 set { } //Length: 264
	}

	[CreateProperty]
	[Token(Token = "0x170001A6")]
	public Vector2 scrollOffset
	{
		[Address(RVA = "0x1C23FC0", Offset = "0x1C231C0", Length = "0x19")]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateAnchor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateScrollViewContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_viewportMaxOffset", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 36)]
		[Token(Token = "0x60009A4")]
		 get { } //Length: 25
		[Address(RVA = "0x1C24810", Offset = "0x1C23A10", Length = "0x225")]
		[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "ApplyTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60009A5")]
		 set { } //Length: 549
	}

	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	[Token(Token = "0x170001A0")]
	public bool showHorizontal
	{
		[Address(RVA = "0x1C24A40", Offset = "0x1C23C40", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600099E")]
		 set { } //Length: 28
	}

	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	[Token(Token = "0x170001A1")]
	public bool showVertical
	{
		[Address(RVA = "0x1C24A60", Offset = "0x1C23C60", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600099F")]
		 set { } //Length: 28
	}

	[CreateProperty]
	[Token(Token = "0x170001AF")]
	public TouchScrollBehavior touchScrollBehavior
	{
		[Address(RVA = "0x1C240C0", Offset = "0x1C232C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60009B3")]
		 get { } //Length: 9
		[Address(RVA = "0x1C24A80", Offset = "0x1C23C80", Length = "0x10F")]
		[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60009B4")]
		 set { } //Length: 271
	}

	[CreateProperty]
	[Token(Token = "0x170001A8")]
	public float verticalPageSize
	{
		[Address(RVA = "0x1C240D0", Offset = "0x1C232D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60009A8")]
		 get { } //Length: 11
		[Address(RVA = "0x1C24B90", Offset = "0x1C23D90", Length = "0xAB")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScrollView), Member = "UpdateVerticalSliderPageSize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60009A9")]
		 set { } //Length: 171
	}

	[Token(Token = "0x170001B3")]
	public Scroller verticalScroller
	{
		[Address(RVA = "0x18CE640", Offset = "0x18CD840", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009C2")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x1700019E")]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[Address(RVA = "0x1C240E0", Offset = "0x1C232E0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600099A")]
		 get { } //Length: 9
		[Address(RVA = "0x1C24C40", Offset = "0x1C23E40", Length = "0x117")]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
		[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600099B")]
		 set { } //Length: 279
	}

	[Address(RVA = "0x1C21F00", Offset = "0x1C21100", Length = "0xF73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60009ED")]
	private static ScrollView() { }

	[Address(RVA = "0x1C22E80", Offset = "0x1C22080", Length = "0xF21")]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseField`1<System.Single>), Member = "add_viewDataRestored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseSlider`1), Member = "add_onSetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<TValueType>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Clickable), Member = "add_clicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_touchScrollBehavior", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScrollBehavior)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(InvokePolicy), typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_horizontalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_verticalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.ClampedDragger`1<System.Single>), Member = "add_draggingEnded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(System.Action`1<System.Single>), typeof(SliderDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_usageHints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UsageHints)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_disableClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "set_receivesHierarchyGeometryChangedEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 23)]
	[Token(Token = "0x60009C5")]
	public ScrollView(ScrollViewMode scrollViewMode) { }

	[Address(RVA = "0x1C23DB0", Offset = "0x1C22FB0", Length = "0xA")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009C4")]
	public ScrollView() { }

	[Address(RVA = "0x1C20F90", Offset = "0x1C20190", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x60009EE")]
	private void <.ctor>b__140_0(float value) { }

	[Address(RVA = "0x1C20FC0", Offset = "0x1C201C0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60009EF")]
	private void <.ctor>b__140_1(float value) { }

	[Address(RVA = "0x1C1C790", Offset = "0x1C1B990", Length = "0x185")]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollersGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Scroller), Member = "Adjust", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60009E2")]
	private void AdjustScrollers() { }

	[Address(RVA = "0x1C1C920", Offset = "0x1C1BB20", Length = "0x355")]
	[CalledBy(Type = typeof(ScrollView), Member = "PostPointerUpAnimation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009D7")]
	internal void ApplyScrollInertia() { }

	[Address(RVA = "0x1C1CC80", Offset = "0x1C1BE80", Length = "0x2E9")]
	[CalledBy(Type = typeof(ScrollView), Member = "ComputeTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TouchScrollingResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DF")]
	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	[Address(RVA = "0x1C1CF70", Offset = "0x1C1C170", Length = "0x174")]
	[CalledBy(Type = typeof(ScrollView), Member = "ComputeTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TouchScrollingResult))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009D4")]
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	[Address(RVA = "0x1C1D0F0", Offset = "0x1C1C2F0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009D5")]
	private void ComputeInitialSpringBackVelocity() { }

	[Address(RVA = "0x1C1D1F0", Offset = "0x1C1C3F0", Length = "0x3D1")]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ScrollView), Member = "ComputeElasticOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ApplyTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DE")]
	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	[Address(RVA = "0x1C1D5D0", Offset = "0x1C1C7D0", Length = "0x1ED")]
	[CalledBy(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateElasticBehaviour", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009E1")]
	private void ExecuteElasticSpringAnimation() { }

	[Address(RVA = "0x1C23DC0", Offset = "0x1C22FC0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009C3")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x833AB0", Offset = "0x832CB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C0")]
	public VisualElement get_contentViewport() { }

	[Address(RVA = "0x1C23DD0", Offset = "0x1C22FD0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600099C")]
	public long get_elasticAnimationIntervalMs() { }

	[Address(RVA = "0x1C23DE0", Offset = "0x1C22FE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009B1")]
	public float get_elasticity() { }

	[Address(RVA = "0x1C23DF0", Offset = "0x1C22FF0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009AE")]
	private bool get_hasInertia() { }

	[Address(RVA = "0x1C17AC0", Offset = "0x1C16CC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A6")]
	public float get_horizontalPageSize() { }

	[Address(RVA = "0xF52590", Offset = "0xF51790", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C1")]
	public Scroller get_horizontalScroller() { }

	[Address(RVA = "0x1C23E10", Offset = "0x1C23010", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000998")]
	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	[Address(RVA = "0x1C23E20", Offset = "0x1C23020", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009A3")]
	internal bool get_isHorizontalScrollDisplayed() { }

	[Address(RVA = "0x1C23E90", Offset = "0x1C23090", Length = "0x61")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "EnsureVisibilityInParent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009A2")]
	internal bool get_isVerticalScrollDisplayed() { }

	[Address(RVA = "0x1C23F00", Offset = "0x1C23100", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009C6")]
	public ScrollViewMode get_mode() { }

	[Address(RVA = "0x834CF0", Offset = "0x833EF0", Length = "0xB")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009AA")]
	public float get_mouseWheelScrollSize() { }

	[Address(RVA = "0x1C23F10", Offset = "0x1C23110", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009A0")]
	internal bool get_needsHorizontal() { }

	[Address(RVA = "0x1C23F60", Offset = "0x1C23160", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009A1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool get_needsVertical() { }

	[Address(RVA = "0x833A90", Offset = "0x832C90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B5")]
	public NestedInteractionKind get_nestedInteractionKind() { }

	[Address(RVA = "0x1C23FE0", Offset = "0x1C231E0", Length = "0x6E")]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "get_needsVertical", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "GetYDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009AD")]
	internal float get_scrollableHeight() { }

	[Address(RVA = "0x1C24050", Offset = "0x1C23250", Length = "0x6E")]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "get_needsHorizontal", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "GetXDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollersGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009AC")]
	internal float get_scrollableWidth() { }

	[Address(RVA = "0x1C23FB0", Offset = "0x1C231B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009AF")]
	public float get_scrollDecelerationRate() { }

	[Address(RVA = "0x1C23FC0", Offset = "0x1C231C0", Length = "0x19")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "GetScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_viewportMaxOffset", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateScrollViewContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "TryGetDragPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateAnchor", ReturnType = typeof(void))]
	[CallerCount(Count = 36)]
	[Token(Token = "0x60009A4")]
	public Vector2 get_scrollOffset() { }

	[Address(RVA = "0x1C240C0", Offset = "0x1C232C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009B3")]
	public TouchScrollBehavior get_touchScrollBehavior() { }

	[Address(RVA = "0x1C240D0", Offset = "0x1C232D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009A8")]
	public float get_verticalPageSize() { }

	[Address(RVA = "0x18CE640", Offset = "0x18CD840", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009C2")]
	public Scroller get_verticalScroller() { }

	[Address(RVA = "0x1C240E0", Offset = "0x1C232E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600099A")]
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	[Address(RVA = "0x1C1D7C0", Offset = "0x1C1C9C0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009BF")]
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	[Address(RVA = "0x1C1D830", Offset = "0x1C1CA30", Length = "0x2D2")]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009BD")]
	private float GetXDeltaOffset(VisualElement child) { }

	[Address(RVA = "0x1C1DB10", Offset = "0x1C1CD10", Length = "0x2E1")]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009BE")]
	private float GetYDeltaOffset(VisualElement child) { }

	[Address(RVA = "0x1C1DE00", Offset = "0x1C1D000", Length = "0x34E")]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60009DD")]
	internal void InitTouchScrolling(Vector2 position) { }

	[Address(RVA = "0x1C1E150", Offset = "0x1C1D350", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E7")]
	private void MarkSingleLineHeightDirty() { }

	[Address(RVA = "0x1C1E160", Offset = "0x1C1D360", Length = "0x47F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetRootVisualContainer", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60009C9")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x1C1E5E0", Offset = "0x1C1D7E0", Length = "0x4A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60009CA")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1C1EA90", Offset = "0x1C1DC90", Length = "0x2FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009CD")]
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C1ED90", Offset = "0x1C1DF90", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateHorizontalSliderPageSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009B7")]
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C1EDF0", Offset = "0x1C1DFF0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Token(Token = "0x60009D1")]
	private void OnHorizontalScrollerSetValueWithoutNotify(float value) { }

	[Address(RVA = "0x1C1EE10", Offset = "0x1C1E010", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009CF")]
	private void OnHorizontalSliderViewDataRestored() { }

	[Address(RVA = "0x1C1EF20", Offset = "0x1C1E120", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009DB")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x1C1F080", Offset = "0x1C1E280", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009CB")]
	private void OnPointerCapture(PointerCaptureEvent evt) { }

	[Address(RVA = "0x1C1EF90", Offset = "0x1C1E190", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60009CC")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x1C1F140", Offset = "0x1C1E340", Length = "0x22B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ScrollView), Member = "InitTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009D9")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x1C1F370", Offset = "0x1C1E570", Length = "0x25A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ScrollView), Member = "ComputeTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TouchScrollingResult))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009DA")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x1C1F5D0", Offset = "0x1C1E7D0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "ReleaseScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IEventHandler)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "PreventCompatibilityMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009DC")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x1C1E150", Offset = "0x1C1D350", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E6")]
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	[Address(RVA = "0x1C1F680", Offset = "0x1C1E880", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009E8")]
	private void OnRootPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x1C1FC80", Offset = "0x1C1EE80", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ScrollView), Member = "AdjustScrollers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009E4")]
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C1F690", Offset = "0x1C1E890", Length = "0x5EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(EventBase), Member = "StopPropagation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScrollView), Member = "UpdateElasticBehaviour", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009E5")]
	private void OnScrollWheel(WheelEvent evt) { }

	[Address(RVA = "0x1C1FE60", Offset = "0x1C1F060", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateVerticalSliderPageSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009B8")]
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C1FEC0", Offset = "0x1C1F0C0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Token(Token = "0x60009D0")]
	private void OnVerticalScrollerSetValueWithoutNotify(float value) { }

	[Address(RVA = "0x1C1FEE0", Offset = "0x1C1F0E0", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009CE")]
	private void OnVerticalSliderViewDataRestored() { }

	[Address(RVA = "0x1C1FFF0", Offset = "0x1C1F1F0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009EC")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1C200D0", Offset = "0x1C1F2D0", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009D8")]
	private void PostPointerUpAnimation() { }

	[Address(RVA = "0x1C20280", Offset = "0x1C1F480", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009E9")]
	private void ReadSingleLineHeight() { }

	[Address(RVA = "0x1C203D0", Offset = "0x1C1F5D0", Length = "0xF9")]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerCaptureOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCaptureOutEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerCancelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "HasPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ExecuteElasticSpringAnimation", ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "ReleasePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009E0")]
	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	[Address(RVA = "0x1C204D0", Offset = "0x1C1F6D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60009D3")]
	private void ResetLayoutPass() { }

	[Address(RVA = "0x1C204E0", Offset = "0x1C1F6E0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60009D2")]
	private void ScheduleResetLayoutPass() { }

	[Address(RVA = "0x1C20600", Offset = "0x1C1F800", Length = "0x1FC")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "ChangeSelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "GetXDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "GetYDeltaOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009BC")]
	public void ScrollTo(VisualElement child) { }

	[Address(RVA = "0x1C240F0", Offset = "0x1C232F0", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600099D")]
	public void set_elasticAnimationIntervalMs(long value) { }

	[Address(RVA = "0x1C24240", Offset = "0x1C23440", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009B2")]
	public void set_elasticity(float value) { }

	[Address(RVA = "0x1C24350", Offset = "0x1C23550", Length = "0xAB")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "UpdateHorizontalSliderPageSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009A7")]
	public void set_horizontalPageSize(float value) { }

	[Address(RVA = "0x1C24400", Offset = "0x1C23600", Length = "0x107")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000999")]
	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	[Address(RVA = "0x1C24510", Offset = "0x1C23710", Length = "0x93")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "set_horizontalScrollingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetScrollViewMode", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollViewMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009C7")]
	public void set_mode(ScrollViewMode value) { }

	[Address(RVA = "0x1C245B0", Offset = "0x1C237B0", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009AB")]
	public void set_mouseWheelScrollSize(float value) { }

	[Address(RVA = "0x1C24680", Offset = "0x1C23880", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009B6")]
	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	[Address(RVA = "0x1C24700", Offset = "0x1C23900", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009B0")]
	public void set_scrollDecelerationRate(float value) { }

	[Address(RVA = "0x1C24810", Offset = "0x1C23A10", Length = "0x225")]
	[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ApplyTouchScrolling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ScrollView), Member = "ApplyScrollInertia", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "SpringBack", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "UpdateScrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009A5")]
	public void set_scrollOffset(Vector2 value) { }

	[Address(RVA = "0x1C24A40", Offset = "0x1C23C40", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600099E")]
	public void set_showHorizontal(bool value) { }

	[Address(RVA = "0x1C24A60", Offset = "0x1C23C60", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600099F")]
	public void set_showVertical(bool value) { }

	[Address(RVA = "0x1C24A80", Offset = "0x1C23C80", Length = "0x10F")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009B4")]
	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	[Address(RVA = "0x1C24B90", Offset = "0x1C23D90", Length = "0xAB")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "UpdateVerticalSliderPageSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009A9")]
	public void set_verticalPageSize(float value) { }

	[Address(RVA = "0x1C24C40", Offset = "0x1C23E40", Length = "0x117")]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetMultiline", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInputBase), Member = "SetVerticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateScrollers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600099B")]
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	[Address(RVA = "0x1C20800", Offset = "0x1C1FA00", Length = "0x107")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateScrollViewContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60009EB")]
	internal void SetScrollOffsetWithoutNotify(Vector2 value) { }

	[Address(RVA = "0x1C20910", Offset = "0x1C1FB10", Length = "0x48F")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_mode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollViewMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60009C8")]
	private void SetScrollViewMode(ScrollViewMode mode) { }

	[Address(RVA = "0x1C20DA0", Offset = "0x1C1FFA0", Length = "0x1E4")]
	[CalledBy(Type = typeof(ScrollView), Member = "PostPointerUpAnimation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Single&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VisualElement), Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60009D6")]
	private void SpringBack() { }

	[Address(RVA = "0x1C20FF0", Offset = "0x1C201F0", Length = "0x33C")]
	[CalledBy(Type = typeof(ScrollView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "<.ctor>b__140_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "ScrollTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalSliderViewDataRestored", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ResetScroll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "IncrementVersion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VersionChangeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009BB")]
	internal void UpdateContentViewTransform() { }

	[Address(RVA = "0x1C21330", Offset = "0x1C20530", Length = "0x2BD")]
	[CalledBy(Type = typeof(ScrollView), Member = "OnScrollWheel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WheelEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "ExecuteElasticSpringAnimation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60009EA")]
	private void UpdateElasticBehaviour() { }

	[Address(RVA = "0x1C215F0", Offset = "0x1C207F0", Length = "0x13C")]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnHorizontalScrollDragElementChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009B9")]
	private void UpdateHorizontalSliderPageSize() { }

	[Address(RVA = "0x1C21730", Offset = "0x1C20930", Length = "0x684")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_horizontalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalScrollerVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScrollerVisibility)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "set_lowValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_boundingBox", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "AdjustScrollers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollableWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(Clickable), Member = "set_acceptClicksIfDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scroller), Member = "set_highValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009E3")]
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	[Address(RVA = "0x1C21DC0", Offset = "0x1C20FC0", Length = "0x13C")]
	[CalledBy(Type = typeof(ScrollView), Member = "set_verticalPageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScrollView), Member = "OnVerticalScrollDragElementChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009BA")]
	private void UpdateVerticalSliderPageSize() { }

}


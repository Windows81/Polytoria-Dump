namespace UnityEngine.UIElements;

[Token(Token = "0x2000167")]
public class TwoPaneSplitView : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000168")]
	internal class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
	{

		[Address(RVA = "0x1C46DB0", Offset = "0x1C45FB0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000B02")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000169")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400072F")]
		private UxmlIntAttributeDescription m_FixedPaneIndex; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000730")]
		private UxmlIntAttributeDescription m_FixedPaneInitialDimension; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000731")]
		private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; //Field offset: 0x98

		[Address(RVA = "0x1C476F0", Offset = "0x1C468F0", Length = "0x190")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B04")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C46FC0", Offset = "0x1C461C0", Length = "0x209")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000B03")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000713")]
	internal static readonly BindingId fixedPaneIndexProperty; //Field offset: 0x0
	[Token(Token = "0x4000714")]
	internal static readonly BindingId fixedPaneInitialDimensionProperty; //Field offset: 0x98
	[Token(Token = "0x4000715")]
	internal static readonly BindingId orientationProperty; //Field offset: 0x130
	[Token(Token = "0x4000716")]
	private static readonly string s_UssClassName; //Field offset: 0x1C8
	[Token(Token = "0x4000717")]
	private static readonly string s_ContentContainerClassName; //Field offset: 0x1D0
	[Token(Token = "0x4000718")]
	private static readonly string s_HandleDragLineClassName; //Field offset: 0x1D8
	[Token(Token = "0x4000719")]
	private static readonly string s_HandleDragLineVerticalClassName; //Field offset: 0x1E0
	[Token(Token = "0x400071A")]
	private static readonly string s_HandleDragLineHorizontalClassName; //Field offset: 0x1E8
	[Token(Token = "0x400071B")]
	private static readonly string s_HandleDragLineAnchorClassName; //Field offset: 0x1F0
	[Token(Token = "0x400071C")]
	private static readonly string s_HandleDragLineAnchorVerticalClassName; //Field offset: 0x1F8
	[Token(Token = "0x400071D")]
	private static readonly string s_HandleDragLineAnchorHorizontalClassName; //Field offset: 0x200
	[Token(Token = "0x400071E")]
	private static readonly string s_VerticalClassName; //Field offset: 0x208
	[Token(Token = "0x400071F")]
	private static readonly string s_HorizontalClassName; //Field offset: 0x210
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x4000720")]
	private VisualElement m_LeftPane; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000721")]
	private VisualElement m_RightPane; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000722")]
	private VisualElement m_FixedPane; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4000723")]
	private VisualElement m_FlexedPane; //Field offset: 0x2E8
	[DontCreateProperty]
	[FieldOffset(Offset = "0x2F0")]
	[SerializeField]
	[Token(Token = "0x4000724")]
	private float m_FixedPaneDimension; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000725")]
	private VisualElement m_DragLine; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000726")]
	private VisualElement m_DragLineAnchor; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000727")]
	private bool m_CollapseMode; //Field offset: 0x308
	[FieldOffset(Offset = "0x309")]
	[Token(Token = "0x4000728")]
	private bool m_PendingCollapseToExecute; //Field offset: 0x309
	[FieldOffset(Offset = "0x30C")]
	[Token(Token = "0x4000729")]
	private int m_CollapsedChildIndex; //Field offset: 0x30C
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x400072A")]
	private VisualElement m_Content; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x400072B")]
	private TwoPaneSplitViewOrientation m_Orientation; //Field offset: 0x318
	[FieldOffset(Offset = "0x31C")]
	[Token(Token = "0x400072C")]
	private int m_FixedPaneIndex; //Field offset: 0x31C
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x400072D")]
	private float m_FixedPaneInitialDimension; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x400072E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TwoPaneSplitViewResizer m_Resizer; //Field offset: 0x328

	[Token(Token = "0x170001E8")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x1C450F0", Offset = "0x1C442F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AFD")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170001E3")]
	internal VisualElement dragLine
	{
		[Address(RVA = "0x1BF7FF0", Offset = "0x1BF71F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEA")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001E1")]
	public VisualElement fixedPane
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001E7")]
	internal float fixedPaneDimension
	{
		[Address(RVA = "0x1C45100", Offset = "0x1C44300", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000AF1")]
		internal get { } //Length: 52
		[Address(RVA = "0x1C45150", Offset = "0x1C44350", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AF2")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 27
	}

	[CreateProperty]
	[Token(Token = "0x170001E4")]
	public int fixedPaneIndex
	{
		[Address(RVA = "0x18CE600", Offset = "0x18CD800", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEB")]
		 get { } //Length: 7
		[Address(RVA = "0x1C45170", Offset = "0x1C44370", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AEC")]
		 set { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x170001E5")]
	public float fixedPaneInitialDimension
	{
		[Address(RVA = "0x1C45140", Offset = "0x1C44340", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000AED")]
		 get { } //Length: 9
		[Address(RVA = "0x1C45210", Offset = "0x1C44410", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000AEE")]
		 set { } //Length: 167
	}

	[Token(Token = "0x170001E2")]
	public VisualElement flexedPane
	{
		[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AE9")]
		 get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170001E6")]
	public TwoPaneSplitViewOrientation orientation
	{
		[Address(RVA = "0x833A80", Offset = "0x832C80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000AEF")]
		 get { } //Length: 7
		[Address(RVA = "0x1C452C0", Offset = "0x1C444C0", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AF0")]
		 set { } //Length: 163
	}

	[Address(RVA = "0x1C44A70", Offset = "0x1C43C70", Length = "0x5CF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B01")]
	private static TwoPaneSplitView() { }

	[Address(RVA = "0x1C45040", Offset = "0x1C44240", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "SetupSplitView", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF3")]
	public TwoPaneSplitView() { }

	[Address(RVA = "0x1C41DF0", Offset = "0x1C40FF0", Length = "0x3C7")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000AF5")]
	public void CollapseChild(int index) { }

	[Address(RVA = "0x1C450F0", Offset = "0x1C442F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AFD")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x1BF7FF0", Offset = "0x1BF71F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEA")]
	internal VisualElement get_dragLine() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE8")]
	public VisualElement get_fixedPane() { }

	[Address(RVA = "0x1C45100", Offset = "0x1C44300", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000AF1")]
	internal float get_fixedPaneDimension() { }

	[Address(RVA = "0x18CE600", Offset = "0x18CD800", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEB")]
	public int get_fixedPaneIndex() { }

	[Address(RVA = "0x1C45140", Offset = "0x1C44340", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000AED")]
	public float get_fixedPaneInitialDimension() { }

	[Address(RVA = "0x4387C0", Offset = "0x4379C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AE9")]
	public VisualElement get_flexedPane() { }

	[Address(RVA = "0x833A80", Offset = "0x832C80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AEF")]
	public TwoPaneSplitViewOrientation get_orientation() { }

	[Address(RVA = "0x1C421C0", Offset = "0x1C413C0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF9")]
	private void IdentifyLeftAndRightPane() { }

	[Address(RVA = "0x1C422B0", Offset = "0x1C414B0", Length = "0x408")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000AF6")]
	internal override void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	[Address(RVA = "0x1C426C0", Offset = "0x1C418C0", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "PostDisplaySetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "CollapseChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "ReplacePanesBasedOnAnchor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000AF7")]
	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C427F0", Offset = "0x1C419F0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000AFB")]
	private void OnSizeChange(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1C42800", Offset = "0x1C41A00", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000AFE")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1C42840", Offset = "0x1C41A40", Length = "0x1289")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(TwoPaneSplitViewOrientation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElementExtensions), Member = "RemoveManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AFA")]
	private void PostDisplaySetup() { }

	[Address(RVA = "0x1C43AD0", Offset = "0x1C42CD0", Length = "0x1D7")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnPostDisplaySetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF8")]
	private void ReplacePanesBasedOnAnchor() { }

	[Address(RVA = "0x1C45150", Offset = "0x1C44350", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AF2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_fixedPaneDimension(float value) { }

	[Address(RVA = "0x1C45170", Offset = "0x1C44370", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AEC")]
	public void set_fixedPaneIndex(int value) { }

	[Address(RVA = "0x1C45210", Offset = "0x1C44410", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AEE")]
	public void set_fixedPaneInitialDimension(float value) { }

	[Address(RVA = "0x1C452C0", Offset = "0x1C444C0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF0")]
	public void set_orientation(TwoPaneSplitViewOrientation value) { }

	[Address(RVA = "0x1C43CB0", Offset = "0x1C42EB0", Length = "0x18B")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFF")]
	private void SetDragLineOffset(float offset) { }

	[Address(RVA = "0x1C43E40", Offset = "0x1C43040", Length = "0x18D")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "UpdateLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B00")]
	private void SetFixedPaneDimension(float dimension) { }

	[Address(RVA = "0x1C43FD0", Offset = "0x1C431D0", Length = "0x265")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000AF4")]
	private void SetupSplitView() { }

	[Address(RVA = "0x1C44240", Offset = "0x1C43440", Length = "0x82D")]
	[CalledBy(Type = typeof(TwoPaneSplitView), Member = "OnSizeChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "SetFixedPaneDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TwoPaneSplitView), Member = "SetDragLineOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000AFC")]
	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

}


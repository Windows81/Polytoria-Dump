namespace UnityEngine.UIElements;

[Token(Token = "0x2000076")]
public abstract class BaseListView : BaseVerticalCollectionView
{
	[CompilerGenerated]
	[Token(Token = "0x2000078")]
	private sealed class <>c__DisplayClass81_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000280")]
		public BaseListView <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000281")]
		public int itemsCountPreCallback; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000461")]
		public <>c__DisplayClass81_0() { }

		[Address(RVA = "0x1BE4A60", Offset = "0x1BE3C60", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListView), Member = "OnAfterAddClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000462")]
		internal void <OnAddClicked>b__0() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000077")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000278")]
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; //Field offset: 0xC8
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000279")]
		private readonly UxmlStringAttributeDescription m_HeaderTitle; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400027A")]
		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x400027B")]
		private readonly UxmlBoolAttributeDescription m_AllowAdd; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x400027C")]
		private readonly UxmlBoolAttributeDescription m_AllowRemove; //Field offset: 0xE8
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x400027D")]
		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; //Field offset: 0xF0
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400027E")]
		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; //Field offset: 0xF8
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x400027F")]
		private readonly UxmlEnumAttributeDescription<BindingSourceSelectionMode> m_BindingSourceSelectionMode; //Field offset: 0x100

		[Address(RVA = "0x1BE8580", Offset = "0x1BE7780", Length = "0x3D5")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000460")]
		protected UxmlTraits() { }

		[Address(RVA = "0x1BE59B0", Offset = "0x1BE4BB0", Length = "0x3AA")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_reorderMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ListViewReorderMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(BaseListView), Member = "set_headerTitle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_showAddRemoveFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_allowAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_allowRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_showBoundCollectionSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x600045F")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000232")]
	private static readonly string k_SizeFieldLabel; //Field offset: 0x0
	[Token(Token = "0x4000233")]
	internal static readonly BindingId showBoundCollectionSizeProperty; //Field offset: 0x8
	[Token(Token = "0x4000234")]
	internal static readonly BindingId showFoldoutHeaderProperty; //Field offset: 0xA0
	[Token(Token = "0x4000235")]
	internal static readonly BindingId headerTitleProperty; //Field offset: 0x138
	[Token(Token = "0x4000236")]
	internal static readonly BindingId makeHeaderProperty; //Field offset: 0x1D0
	[Token(Token = "0x4000237")]
	internal static readonly BindingId makeFooterProperty; //Field offset: 0x268
	[Token(Token = "0x4000238")]
	internal static readonly BindingId showAddRemoveFooterProperty; //Field offset: 0x300
	[Token(Token = "0x4000239")]
	internal static readonly BindingId bindingSourceSelectionModeProperty; //Field offset: 0x398
	[Token(Token = "0x400023A")]
	internal static readonly BindingId reorderModeProperty; //Field offset: 0x430
	[Token(Token = "0x400023B")]
	internal static readonly BindingId makeNoneElementProperty; //Field offset: 0x4C8
	[Token(Token = "0x400023C")]
	internal static readonly BindingId allowAddProperty; //Field offset: 0x560
	[Token(Token = "0x400023D")]
	internal static readonly BindingId overridingAddButtonBehaviorProperty; //Field offset: 0x5F8
	[Token(Token = "0x400023E")]
	internal static readonly BindingId onAddProperty; //Field offset: 0x690
	[Token(Token = "0x400023F")]
	internal static readonly BindingId allowRemoveProperty; //Field offset: 0x728
	[Token(Token = "0x4000240")]
	internal static readonly BindingId onRemoveProperty; //Field offset: 0x7C0
	[Token(Token = "0x4000263")]
	public static readonly string ussClassName; //Field offset: 0x858
	[Token(Token = "0x4000264")]
	public static readonly string itemUssClassName; //Field offset: 0x860
	[Token(Token = "0x4000265")]
	public static readonly string emptyLabelUssClassName; //Field offset: 0x868
	[Token(Token = "0x4000266")]
	public static readonly string overMaxMultiEditLimitClassName; //Field offset: 0x870
	[Token(Token = "0x4000267")]
	public static readonly string reorderableUssClassName; //Field offset: 0x878
	[Token(Token = "0x4000268")]
	public static readonly string reorderableItemUssClassName; //Field offset: 0x880
	[Token(Token = "0x4000269")]
	public static readonly string reorderableItemContainerUssClassName; //Field offset: 0x888
	[Token(Token = "0x400026A")]
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x890
	[Token(Token = "0x400026B")]
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x898
	[Token(Token = "0x400026C")]
	public static readonly string footerUssClassName; //Field offset: 0x8A0
	[Token(Token = "0x400026D")]
	public static readonly string foldoutHeaderUssClassName; //Field offset: 0x8A8
	[Token(Token = "0x400026E")]
	public static readonly string arraySizeFieldUssClassName; //Field offset: 0x8B0
	[Token(Token = "0x400026F")]
	public static readonly string arraySizeFieldWithHeaderUssClassName; //Field offset: 0x8B8
	[Token(Token = "0x4000270")]
	public static readonly string arraySizeFieldWithFooterUssClassName; //Field offset: 0x8C0
	[Token(Token = "0x4000271")]
	public static readonly string listViewWithHeaderUssClassName; //Field offset: 0x8C8
	[Token(Token = "0x4000272")]
	public static readonly string listViewWithFooterUssClassName; //Field offset: 0x8D0
	[Token(Token = "0x4000273")]
	public static readonly string scrollViewWithFooterUssClassName; //Field offset: 0x8D8
	[Token(Token = "0x4000274")]
	public static readonly string footerAddButtonName; //Field offset: 0x8E0
	[Token(Token = "0x4000275")]
	public static readonly string footerRemoveButtonName; //Field offset: 0x8E8
	[Token(Token = "0x4000277")]
	private static readonly string k_EmptyListStr; //Field offset: 0x8F0
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x4000241")]
	private bool m_ShowBoundCollectionSize; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3C9")]
	[Token(Token = "0x4000242")]
	private bool m_ShowFoldoutHeader; //Field offset: 0x3C9
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x4000243")]
	private string m_HeaderTitle; //Field offset: 0x3D0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x4000244")]
	private VisualElement drawnHeader; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x4000245")]
	private Func<VisualElement> m_MakeHeader; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x4000246")]
	private VisualElement drawnFooter; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x4000247")]
	private Func<VisualElement> m_MakeFooter; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x4000248")]
	private bool m_ShowAddRemoveFooter; //Field offset: 0x3F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x4000249")]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x400024A")]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x400024B")]
	private Action itemsSourceSizeChanged; //Field offset: 0x410
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x400024C")]
	private IVisualElementScheduledItem m_TrackedItem; //Field offset: 0x418
	[FieldOffset(Offset = "0x420")]
	[Token(Token = "0x400024D")]
	private Action m_TrackCount; //Field offset: 0x420
	[FieldOffset(Offset = "0x428")]
	[Token(Token = "0x400024E")]
	private Func<Boolean> m_WhileAutoAssign; //Field offset: 0x428
	[FieldOffset(Offset = "0x430")]
	[Token(Token = "0x400024F")]
	private BindingSourceSelectionMode m_BindingSourceSelectionMode; //Field offset: 0x430
	[FieldOffset(Offset = "0x438")]
	[Token(Token = "0x4000250")]
	private Label m_ListViewLabel; //Field offset: 0x438
	[FieldOffset(Offset = "0x440")]
	[Token(Token = "0x4000251")]
	private Foldout m_Foldout; //Field offset: 0x440
	[FieldOffset(Offset = "0x448")]
	[Token(Token = "0x4000252")]
	private TextField m_ArraySizeField; //Field offset: 0x448
	[FieldOffset(Offset = "0x450")]
	[Token(Token = "0x4000253")]
	private bool m_IsOverMultiEditLimit; //Field offset: 0x450
	[FieldOffset(Offset = "0x458")]
	[Token(Token = "0x4000254")]
	private VisualElement m_Footer; //Field offset: 0x458
	[FieldOffset(Offset = "0x460")]
	[Token(Token = "0x4000255")]
	private Button m_AddButton; //Field offset: 0x460
	[FieldOffset(Offset = "0x468")]
	[Token(Token = "0x4000256")]
	private Button m_RemoveButton; //Field offset: 0x468
	[FieldOffset(Offset = "0x470")]
	[Token(Token = "0x4000257")]
	private Action<IEnumerable`1<Int32>> m_ItemAddedCallback; //Field offset: 0x470
	[FieldOffset(Offset = "0x478")]
	[Token(Token = "0x4000258")]
	private Action<IEnumerable`1<Int32>> m_ItemRemovedCallback; //Field offset: 0x478
	[FieldOffset(Offset = "0x480")]
	[Token(Token = "0x4000259")]
	private Action m_ItemsSourceSizeChangedCallback; //Field offset: 0x480
	[FieldOffset(Offset = "0x488")]
	[Token(Token = "0x400025A")]
	private ListViewReorderMode m_ReorderMode; //Field offset: 0x488
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x490")]
	[Token(Token = "0x400025B")]
	private Action reorderModeChanged; //Field offset: 0x490
	[FieldOffset(Offset = "0x498")]
	[Token(Token = "0x400025C")]
	private VisualElement m_NoneElement; //Field offset: 0x498
	[FieldOffset(Offset = "0x4A0")]
	[Token(Token = "0x400025D")]
	private Func<VisualElement> m_MakeNoneElement; //Field offset: 0x4A0
	[FieldOffset(Offset = "0x4A8")]
	[Token(Token = "0x400025E")]
	private bool m_AllowAdd; //Field offset: 0x4A8
	[FieldOffset(Offset = "0x4B0")]
	[Token(Token = "0x400025F")]
	private Action<BaseListView, Button> m_OverridingAddButtonBehavior; //Field offset: 0x4B0
	[FieldOffset(Offset = "0x4B8")]
	[Token(Token = "0x4000260")]
	private Action<BaseListView> m_OnAdd; //Field offset: 0x4B8
	[FieldOffset(Offset = "0x4C0")]
	[Token(Token = "0x4000261")]
	private bool m_AllowRemove; //Field offset: 0x4C0
	[FieldOffset(Offset = "0x4C8")]
	[Token(Token = "0x4000262")]
	private Action<BaseListView> m_OnRemove; //Field offset: 0x4C8
	[FieldOffset(Offset = "0x4D0")]
	[Token(Token = "0x4000276")]
	private string m_MaxMultiEditStr; //Field offset: 0x4D0

	[Token(Token = "0x14000010")]
	internal event Action reorderModeChanged
	{
		[Address(RVA = "0x1ABE9F0", Offset = "0x1ABDBF0", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000446")]
		internal add { } //Length: 162
		[Address(RVA = "0x1ABEF40", Offset = "0x1ABE140", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000447")]
		internal remove { } //Length: 162
	}

	[CreateProperty]
	[Token(Token = "0x1700009D")]
	public bool allowAdd
	{
		[Address(RVA = "0x1ABEAA0", Offset = "0x1ABDCA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600044C")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABEFF0", Offset = "0x1ABE1F0", Length = "0x97")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600044D")]
		 set { } //Length: 151
	}

	[CreateProperty]
	[Token(Token = "0x170000A0")]
	public bool allowRemove
	{
		[Address(RVA = "0x1ABEAB0", Offset = "0x1ABDCB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000452")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF090", Offset = "0x1ABE290", Length = "0x97")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000453")]
		 set { } //Length: 151
	}

	[Token(Token = "0x17000098")]
	internal bool autoAssignSource
	{
		[Address(RVA = "0x1ABEAC0", Offset = "0x1ABDCC0", Length = "0xB")]
		[CalledBy(Type = typeof(ListView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000437")]
		internal get { } //Length: 11
	}

	[CreateProperty]
	[Token(Token = "0x17000097")]
	public BindingSourceSelectionMode bindingSourceSelectionMode
	{
		[Address(RVA = "0x1ABEAD0", Offset = "0x1ABDCD0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000435")]
		 get { } //Length: 7
		[Address(RVA = "0x1ABF130", Offset = "0x1ABE330", Length = "0xC3")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "get_trackItemCount", ReturnType = typeof(IVisualElementScheduledItem))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000436")]
		 set { } //Length: 195
	}

	[Token(Token = "0x17000099")]
	internal VisualElement footer
	{
		[Address(RVA = "0x1ABEAE0", Offset = "0x1ABDCE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600043F")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x17000090")]
	public string headerTitle
	{
		[Address(RVA = "0x1ABEAF0", Offset = "0x1ABDCF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000429")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF200", Offset = "0x1ABE400", Length = "0xCC")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600042A")]
		 set { } //Length: 204
	}

	[CreateProperty]
	[Token(Token = "0x17000092")]
	public Func<VisualElement> makeFooter
	{
		[Address(RVA = "0x1ABEB00", Offset = "0x1ABDD00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600042D")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF2D0", Offset = "0x1ABE4D0", Length = "0x24B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600042E")]
		 set { } //Length: 587
	}

	[CreateProperty]
	[Token(Token = "0x17000091")]
	public Func<VisualElement> makeHeader
	{
		[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042B")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF520", Offset = "0x1ABE720", Length = "0x2B5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600042C")]
		 set { } //Length: 693
	}

	[CreateProperty]
	[Token(Token = "0x1700009C")]
	public Func<VisualElement> makeNoneElement
	{
		[Address(RVA = "0x1ABEB10", Offset = "0x1ABDD10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600044A")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF7E0", Offset = "0x1ABE9E0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600044B")]
		 set { } //Length: 213
	}

	[CreateProperty]
	[Token(Token = "0x1700009F")]
	public Action<BaseListView> onAdd
	{
		[Address(RVA = "0x1ABEB20", Offset = "0x1ABDD20", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000450")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF8C0", Offset = "0x1ABEAC0", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000451")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x170000A1")]
	public Action<BaseListView> onRemove
	{
		[Address(RVA = "0x1ABEB30", Offset = "0x1ABDD30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000454")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABF970", Offset = "0x1ABEB70", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000455")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x1700009E")]
	public Action<BaseListView, Button> overridingAddButtonBehavior
	{
		[Address(RVA = "0x1ABEB40", Offset = "0x1ABDD40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600044E")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABFA20", Offset = "0x1ABEC20", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x600044F")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x1700009B")]
	public ListViewReorderMode reorderMode
	{
		[Address(RVA = "0x1ABEB50", Offset = "0x1ABDD50", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000448")]
		 get { } //Length: 7
		[Address(RVA = "0x1ABFAD0", Offset = "0x1ABECD0", Length = "0xB8")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "InitializeDragAndDropController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000449")]
		 set { } //Length: 184
	}

	[CreateProperty]
	[Token(Token = "0x17000093")]
	public bool showAddRemoveFooter
	{
		[Address(RVA = "0x1ABEB60", Offset = "0x1ABDD60", Length = "0xC")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600042F")]
		 get { } //Length: 12
		[Address(RVA = "0x1ABFB90", Offset = "0x1ABED90", Length = "0x10B")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000430")]
		 set { } //Length: 267
	}

	[CreateProperty]
	[Token(Token = "0x1700008E")]
	public bool showBoundCollectionSize
	{
		[Address(RVA = "0x1ABEB70", Offset = "0x1ABDD70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000422")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABFCA0", Offset = "0x1ABEEA0", Length = "0x86")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000423")]
		 set { } //Length: 134
	}

	[CreateProperty]
	[Token(Token = "0x1700008F")]
	public bool showFoldoutHeader
	{
		[Address(RVA = "0x1ABEB80", Offset = "0x1ABDD80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000424")]
		 get { } //Length: 8
		[Address(RVA = "0x1ABFD30", Offset = "0x1ABEF30", Length = "0x225")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseListView), Member = "RemoveFoldout", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AB7830")]
		[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
		[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000425")]
		 set { } //Length: 549
	}

	[Token(Token = "0x17000095")]
	private Action trackCount
	{
		[Address(RVA = "0x1ABEB90", Offset = "0x1ABDD90", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000433")]
		private get { } //Length: 138
	}

	[Token(Token = "0x17000094")]
	private IVisualElementScheduledItem trackItemCount
	{
		[Address(RVA = "0x1ABEC20", Offset = "0x1ABDE20", Length = "0x206")]
		[CalledBy(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000432")]
		private get { } //Length: 518
	}

	[Token(Token = "0x17000096")]
	private Func<Boolean> untilManualBindingSourceSelectionMode
	{
		[Address(RVA = "0x1ABEE30", Offset = "0x1ABE030", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000434")]
		private get { } //Length: 138
	}

	[Token(Token = "0x1700009A")]
	public BaseListViewController viewController
	{
		[Address(RVA = "0x1ABEEC0", Offset = "0x1ABE0C0", Length = "0x75")]
		[CalledBy(Type = typeof(BaseListView), Member = "OnArraySizeFieldChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.String>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000440")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x1ABD390", Offset = "0x1ABC590", Length = "0x12A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600045C")]
	private static BaseListView() { }

	[Address(RVA = "0x1ABE810", Offset = "0x1ABDA10", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000459")]
	public BaseListView(IList itemsSource, float itemHeight = -1) { }

	[Address(RVA = "0x1ABE640", Offset = "0x1ABD840", Length = "0x1C1")]
	[CalledBy(Type = typeof(ListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000458")]
	public BaseListView() { }

	[Address(RVA = "0x1ABCE00", Offset = "0x1ABC000", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600045D")]
	private void <get_trackCount>b__65_0() { }

	[Address(RVA = "0x1ABCEC0", Offset = "0x1ABC0C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600045E")]
	private bool <get_untilManualBindingSourceSelectionMode>b__68_0() { }

	[Address(RVA = "0x1ABE9F0", Offset = "0x1ABDBF0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000446")]
	internal void add_reorderModeChanged(Action value) { }

	[Address(RVA = "0x1ABB010", Offset = "0x1ABA210", Length = "0x1EB")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Foldout), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000426")]
	private void AddFoldout() { }

	[Address(RVA = "0x1ABB200", Offset = "0x1ABA400", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000438")]
	private void AddItems(int itemCount) { }

	[Address(RVA = "0x1ABB290", Offset = "0x1ABA490", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListViewReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseListView)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000457")]
	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	[Address(RVA = "0x1ABB2F0", Offset = "0x1ABA4F0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ListViewDraggerAnimated), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000456")]
	internal virtual ListViewDragger CreateDragger() { }

	[Address(RVA = "0x1ABB390", Offset = "0x1ABA590", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000441")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x1ABB3D0", Offset = "0x1ABA5D0", Length = "0x46A")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showAddRemoveFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Button), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000431")]
	private void EnableFooter(bool enabled) { }

	[Address(RVA = "0x1ABEAA0", Offset = "0x1ABDCA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600044C")]
	public bool get_allowAdd() { }

	[Address(RVA = "0x1ABEAB0", Offset = "0x1ABDCB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000452")]
	public bool get_allowRemove() { }

	[Address(RVA = "0x1ABEAC0", Offset = "0x1ABDCC0", Length = "0xB")]
	[CalledBy(Type = typeof(ListView), Member = "HasValidDataAndBindings", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000437")]
	internal bool get_autoAssignSource() { }

	[Address(RVA = "0x1ABEAD0", Offset = "0x1ABDCD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000435")]
	public BindingSourceSelectionMode get_bindingSourceSelectionMode() { }

	[Address(RVA = "0x1ABEAE0", Offset = "0x1ABDCE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600043F")]
	internal VisualElement get_footer() { }

	[Address(RVA = "0x1ABEAF0", Offset = "0x1ABDCF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000429")]
	public string get_headerTitle() { }

	[Address(RVA = "0x1ABEB00", Offset = "0x1ABDD00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600042D")]
	public Func<VisualElement> get_makeFooter() { }

	[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042B")]
	public Func<VisualElement> get_makeHeader() { }

	[Address(RVA = "0x1ABEB10", Offset = "0x1ABDD10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600044A")]
	public Func<VisualElement> get_makeNoneElement() { }

	[Address(RVA = "0x1ABEB20", Offset = "0x1ABDD20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000450")]
	public Action<BaseListView> get_onAdd() { }

	[Address(RVA = "0x1ABEB30", Offset = "0x1ABDD30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000454")]
	public Action<BaseListView> get_onRemove() { }

	[Address(RVA = "0x1ABEB40", Offset = "0x1ABDD40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600044E")]
	public Action<BaseListView, Button> get_overridingAddButtonBehavior() { }

	[Address(RVA = "0x1ABEB50", Offset = "0x1ABDD50", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000448")]
	public ListViewReorderMode get_reorderMode() { }

	[Address(RVA = "0x1ABEB60", Offset = "0x1ABDD60", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042F")]
	public bool get_showAddRemoveFooter() { }

	[Address(RVA = "0x1ABEB70", Offset = "0x1ABDD70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000422")]
	public bool get_showBoundCollectionSize() { }

	[Address(RVA = "0x1ABEB80", Offset = "0x1ABDD80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000424")]
	public bool get_showFoldoutHeader() { }

	[Address(RVA = "0x1ABEB90", Offset = "0x1ABDD90", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000433")]
	private Action get_trackCount() { }

	[Address(RVA = "0x1ABEC20", Offset = "0x1ABDE20", Length = "0x206")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_bindingSourceSelectionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingSourceSelectionMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000432")]
	private IVisualElementScheduledItem get_trackItemCount() { }

	[Address(RVA = "0x1ABEE30", Offset = "0x1ABE030", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000434")]
	private Func<Boolean> get_untilManualBindingSourceSelectionMode() { }

	[Address(RVA = "0x1ABEEC0", Offset = "0x1ABE0C0", Length = "0x75")]
	[CalledBy(Type = typeof(BaseListView), Member = "OnArraySizeFieldChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnRemoveClicked", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000440")]
	public BaseListViewController get_viewController() { }

	[Address(RVA = "0x1ABB840", Offset = "0x1ABAA40", Length = "0x32E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndices", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Foldout), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600045B")]
	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	[Address(RVA = "0x1ABBB70", Offset = "0x1ABAD70", Length = "0x3A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600043C")]
	private void OnAddClicked() { }

	[Address(RVA = "0x1ABBF20", Offset = "0x1ABB120", Length = "0x11E")]
	[CalledBy(Type = typeof(<>c__DisplayClass81_0), Member = "<OnAddClicked>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600043D")]
	private void OnAfterAddClicked(int itemsCountPreCallback) { }

	[Address(RVA = "0x1ABC040", Offset = "0x1ABB240", Length = "0x242")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000439")]
	private void OnArraySizeFieldChanged(ChangeEvent<String> evt) { }

	[Address(RVA = "0x1ABC290", Offset = "0x1ABB490", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000443")]
	private void OnItemAdded(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x1ABC2B0", Offset = "0x1ABB4B0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000444")]
	private void OnItemsRemoved(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x1ABC2D0", Offset = "0x1ABB4D0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000445")]
	private void OnItemsSourceSizeChanged() { }

	[Address(RVA = "0x1ABC350", Offset = "0x1ABB550", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndices", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_showMixedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600043E")]
	private void OnRemoveClicked() { }

	[Address(RVA = "0x1ABC510", Offset = "0x1ABB710", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "PostRefresh", ReturnType = typeof(void))]
	[Token(Token = "0x600045A")]
	virtual void PostRefresh() { }

	[Address(RVA = "0x1ABEF40", Offset = "0x1ABE140", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000447")]
	internal void remove_reorderModeChanged(Action value) { }

	[Address(RVA = "0x1ABC540", Offset = "0x1ABB740", Length = "0x5B")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000427")]
	private void RemoveFoldout() { }

	[Address(RVA = "0x1ABEFF0", Offset = "0x1ABE1F0", Length = "0x97")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600044D")]
	public void set_allowAdd(bool value) { }

	[Address(RVA = "0x1ABF090", Offset = "0x1ABE290", Length = "0x97")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000453")]
	public void set_allowRemove(bool value) { }

	[Address(RVA = "0x1ABF130", Offset = "0x1ABE330", Length = "0xC3")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "get_trackItemCount", ReturnType = typeof(IVisualElementScheduledItem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000436")]
	public void set_bindingSourceSelectionMode(BindingSourceSelectionMode value) { }

	[Address(RVA = "0x1ABF200", Offset = "0x1ABE400", Length = "0xCC")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Foldout), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600042A")]
	public void set_headerTitle(string value) { }

	[Address(RVA = "0x1ABF2D0", Offset = "0x1ABE4D0", Length = "0x24B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600042E")]
	public void set_makeFooter(Func<VisualElement> value) { }

	[Address(RVA = "0x1ABF520", Offset = "0x1ABE720", Length = "0x2B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "SendToBack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042C")]
	public void set_makeHeader(Func<VisualElement> value) { }

	[Address(RVA = "0x1ABF7E0", Offset = "0x1ABE9E0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600044B")]
	public void set_makeNoneElement(Func<VisualElement> value) { }

	[Address(RVA = "0x1ABF8C0", Offset = "0x1ABEAC0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000451")]
	public void set_onAdd(Action<BaseListView> value) { }

	[Address(RVA = "0x1ABF970", Offset = "0x1ABEB70", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000455")]
	public void set_onRemove(Action<BaseListView> value) { }

	[Address(RVA = "0x1ABFA20", Offset = "0x1ABEC20", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x600044F")]
	public void set_overridingAddButtonBehavior(Action<BaseListView, Button> value) { }

	[Address(RVA = "0x1ABFAD0", Offset = "0x1ABECD0", Length = "0xB8")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "InitializeDragAndDropController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "Rebuild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000449")]
	public void set_reorderMode(ListViewReorderMode value) { }

	[Address(RVA = "0x1ABFB90", Offset = "0x1ABED90", Length = "0x10B")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000430")]
	public void set_showAddRemoveFooter(bool value) { }

	[Address(RVA = "0x1ABFCA0", Offset = "0x1ABEEA0", Length = "0x86")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000423")]
	public void set_showBoundCollectionSize(bool value) { }

	[Address(RVA = "0x1ABFD30", Offset = "0x1ABEF30", Length = "0x225")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181AB7830")]
	[Calls(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "UpdateListViewLabel", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "BringToFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "EnableFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "AddFoldout", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "RemoveFoldout", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000425")]
	public void set_showFoldoutHeader(bool value) { }

	[Address(RVA = "0x1ABCA70", Offset = "0x1ABBC70", Length = "0x383")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showBoundCollectionSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseField`1), Member = "set_label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.TextInputBaseField`1<System.Object>), Member = "set_isDelayed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(INotifyValueChangedExtensions), Member = "RegisterValueChangedCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.INotifyValueChanged`1<T>", "UnityEngine.UIElements.EventCallback`1<ChangeEvent`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseListView), Member = "UpdateArraySizeField", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextField), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyName)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(PropertyName), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000428")]
	internal void SetupArraySizeField() { }

	[Address(RVA = "0x1ABC5A0", Offset = "0x1ABB7A0", Length = "0x4C2")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(BaseListViewController), Member = "add_itemsSourceSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000442")]
	public virtual void SetViewController(CollectionViewController controller) { }

	[Address(RVA = "0x1ABCED0", Offset = "0x1ABC0D0", Length = "0xEF")]
	[CalledBy(Type = typeof(BaseListView), Member = "SetupArraySizeField", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600043A")]
	internal void UpdateArraySizeField() { }

	[Address(RVA = "0x1ABCFC0", Offset = "0x1ABC1C0", Length = "0x3CD")]
	[CalledBy(Type = typeof(BaseListView), Member = "set_showFoldoutHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "set_makeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "OnArraySizeFieldChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ChangeEvent`1<System.String>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseListView), Member = "PostRefresh", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600043B")]
	internal void UpdateListViewLabel() { }

}


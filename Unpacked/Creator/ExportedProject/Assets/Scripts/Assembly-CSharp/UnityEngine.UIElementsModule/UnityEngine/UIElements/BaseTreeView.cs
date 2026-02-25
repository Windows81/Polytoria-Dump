namespace UnityEngine.UIElements;

[Token(Token = "0x2000081")]
public abstract class BaseTreeView : BaseVerticalCollectionView
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000082")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40002D6")]
		private readonly UxmlBoolAttributeDescription m_AutoExpand; //Field offset: 0xC8

		[Address(RVA = "0x1BE9660", Offset = "0x1BE8860", Length = "0xA6")]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004EE")]
		public UxmlTraits() { }

		[Address(RVA = "0x1BE7180", Offset = "0x1BE6380", Length = "0x1A8")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004ED")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40002C9")]
	internal static readonly BindingId autoExpandProperty; //Field offset: 0x0
	[Token(Token = "0x40002CA")]
	internal static CustomStyleProperty<Single> s_TreeViewIndentProperty; //Field offset: 0x98
	[Token(Token = "0x40002CB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static readonly int invalidId; //Field offset: 0xA0
	[Token(Token = "0x40002CC")]
	public static readonly string ussClassName; //Field offset: 0xA8
	[Token(Token = "0x40002CD")]
	public static readonly string itemUssClassName; //Field offset: 0xB0
	[Token(Token = "0x40002CE")]
	public static readonly string itemToggleUssClassName; //Field offset: 0xB8
	[Obsolete("Individual item indents are no longer used, see itemIndentUssClassName instead", False)]
	[Token(Token = "0x40002CF")]
	public static readonly string itemIndentsContainerUssClassName; //Field offset: 0xC0
	[Token(Token = "0x40002D0")]
	public static readonly string itemIndentUssClassName; //Field offset: 0xC8
	[Token(Token = "0x40002D1")]
	public static readonly string itemContentContainerUssClassName; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x40002D2")]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x40002D3")]
	private bool m_AutoExpand; //Field offset: 0x3D0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x3D8")]
	[SerializeField]
	[Token(Token = "0x40002D4")]
	private List<Int32> m_ExpandedItemIds; //Field offset: 0x3D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x40002D5")]
	private Nullable<Single> <customIdent>k__BackingField; //Field offset: 0x3E0

	[CreateProperty]
	[Token(Token = "0x170000BC")]
	public bool autoExpand
	{
		[Address(RVA = "0x1BCF850", Offset = "0x1BCEA50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60004D6")]
		 get { } //Length: 8
		[Address(RVA = "0x1BCF920", Offset = "0x1BCEB20", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Token(Token = "0x60004D7")]
		 set { } //Length: 130
	}

	[Token(Token = "0x170000BE")]
	internal Nullable<Single> customIdent
	{
		[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DA")]
		internal get { } //Length: 8
		[Address(RVA = "0x1BCF9B0", Offset = "0x1BCEBB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60004DB")]
		private set { } //Length: 8
	}

	[Token(Token = "0x170000BD")]
	internal List<Int32> expandedItemIds
	{
		[Address(RVA = "0x1BCF860", Offset = "0x1BCEA60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60004D8")]
		internal get { } //Length: 8
		[Address(RVA = "0x1BCF9C0", Offset = "0x1BCEBC0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60004D9")]
		internal set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000BA")]
	public internal IList itemsSource
	{
		[Address(RVA = "0x1BCF870", Offset = "0x1BCEA70", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004CE")]
		 get { } //Length: 48
		[Address(RVA = "0x1BCF9E0", Offset = "0x1BCEBE0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60004CF")]
		internal set { } //Length: 121
	}

	[Token(Token = "0x170000BB")]
	public BaseTreeViewController viewController
	{
		[Address(RVA = "0x1BCF8A0", Offset = "0x1BCEAA0", Length = "0x75")]
		[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "CompareId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ListViewDragger), Member = "HandleTreePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BaseTreeView), Member = "get_itemsSource", ReturnType = typeof(IList))]
		[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "RestoreExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004D0")]
		 get { } //Length: 117
	}

	[Address(RVA = "0x1BCF110", Offset = "0x1BCE310", Length = "0x3E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnityEngine.UIElements.CustomStyleProperty`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60004EB")]
	private static BaseTreeView() { }

	[Address(RVA = "0x1BCF500", Offset = "0x1BCE700", Length = "0x1AD")]
	[CalledBy(Type = typeof(TreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<UnityEngine.UIElements.VisualElement>), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004DD")]
	public BaseTreeView(int itemHeight) { }

	[Address(RVA = "0x1BCF6B0", Offset = "0x1BCE8B0", Length = "0x194")]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004DC")]
	public BaseTreeView() { }

	[Address(RVA = "0x1BCF100", Offset = "0x1BCE300", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CompilerGenerated]
	[Token(Token = "0x60004EC")]
	private int <SetSelectionInternalById>b__60_0(int id) { }

	[Address(RVA = "0x1BCDD60", Offset = "0x1BCCF60", Length = "0x54")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "RestoreExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E6")]
	public void CollapseItem(int id, bool collapseAllChildren = false, bool refresh = true) { }

	[Address(RVA = "0x1BCDCD0", Offset = "0x1BCCED0", Length = "0x87")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "HasChildrenByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E9")]
	private void CollapseItemByIndex(int index, bool collapseAll) { }

	[Address(RVA = "0x1BCDDC0", Offset = "0x1BCCFC0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TreeViewReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseTreeView)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004D5")]
	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	[Address(RVA = "0x1BCDE20", Offset = "0x1BCD020", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60004D1")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x1BCDEF0", Offset = "0x1BCD0F0", Length = "0x54")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E7")]
	public void ExpandItem(int id, bool expandAllChildren = false, bool refresh = true) { }

	[Address(RVA = "0x1BCDE60", Offset = "0x1BCD060", Length = "0x87")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "HasChildrenByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004EA")]
	private void ExpandItemByIndex(int index, bool expandAll) { }

	[Address(RVA = "0x1BCF850", Offset = "0x1BCEA50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004D6")]
	public bool get_autoExpand() { }

	[Address(RVA = "0x187F4E0", Offset = "0x187E6E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DA")]
	internal Nullable<Single> get_customIdent() { }

	[Address(RVA = "0x1BCF860", Offset = "0x1BCEA60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004D8")]
	internal List<Int32> get_expandedItemIds() { }

	[Address(RVA = "0x1BCF870", Offset = "0x1BCEA70", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CE")]
	public IList get_itemsSource() { }

	[Address(RVA = "0x1BCF8A0", Offset = "0x1BCEAA0", Length = "0x75")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "RestoreExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "OnViewDataReady", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "HandleItemNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "GetItemIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleTreePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragPosition&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "CompareId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IListDragAndDropArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BaseTreeView), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004D0")]
	public BaseTreeViewController get_viewController() { }

	[Address(RVA = "0x1BCDF50", Offset = "0x1BCD150", Length = "0x207")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "<SetSelectionInternalById>b__60_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004E4")]
	private int GetItemIndex(int id, bool expand = false) { }

	[Address(RVA = "0x1BCE160", Offset = "0x1BCD360", Length = "0x587")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseTreeView), Member = "ExpandItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeView), Member = "CollapseItemByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "HasChildrenByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x60004E0")]
	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	[Address(RVA = "0x1BCE720", Offset = "0x1BCD920", Length = "0x2B")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition&), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "ExpandDropItem", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E5")]
	public bool IsExpanded(int id) { }

	[Address(RVA = "0x1BCE6F0", Offset = "0x1BCD8F0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsExpandedByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E8")]
	private bool IsExpandedByIndex(int index) { }

	[Address(RVA = "0x1BCE750", Offset = "0x1BCD950", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CustomStyleResolvedEvent), Member = "get_customStyle", ReturnType = typeof(ICustomStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Nullable`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004DE")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	[Address(RVA = "0x1BCE900", Offset = "0x1BCDB00", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004D4")]
	private void OnItemExpandedChanged(TreeViewExpansionChangedArgs arg) { }

	[Address(RVA = "0x1BCE920", Offset = "0x1BCDB20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Token(Token = "0x60004D3")]
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	[Address(RVA = "0x1BCE930", Offset = "0x1BCDB30", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "OverwriteFromViewData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004DF")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1BCF920", Offset = "0x1BCEB20", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004D7")]
	public void set_autoExpand(bool value) { }

	[Address(RVA = "0x1BCF9B0", Offset = "0x1BCEBB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60004DB")]
	private void set_customIdent(Nullable<Single> value) { }

	[Address(RVA = "0x1BCF9C0", Offset = "0x1BCEBC0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004D9")]
	internal void set_expandedItemIds(List<Int32> value) { }

	[Address(RVA = "0x1BCF9E0", Offset = "0x1BCEBE0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004CF")]
	internal void set_itemsSource(IList value) { }

	[Address(RVA = "0x1BCE9C0", Offset = "0x1BCDBC0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004E2")]
	public void SetSelectionById(IEnumerable<Int32> ids) { }

	[Address(RVA = "0x1BCEA80", Offset = "0x1BCDC80", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004E1")]
	public void SetSelectionById(int id) { }

	[Address(RVA = "0x1BCEB90", Offset = "0x1BCDD90", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004E3")]
	internal void SetSelectionInternalById(IEnumerable<Int32> ids, bool sendNotification) { }

	[Address(RVA = "0x1BCEC60", Offset = "0x1BCDE60", Length = "0x492")]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "remove_itemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.TreeViewExpansionChangedArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "add_itemsSourceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "add_itemIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "SetView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CollectionViewController), Member = "remove_itemsSourceChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionViewController), Member = "remove_itemIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "add_itemExpandedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.TreeViewExpansionChangedArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004D2")]
	public virtual void SetViewController(CollectionViewController controller) { }

}


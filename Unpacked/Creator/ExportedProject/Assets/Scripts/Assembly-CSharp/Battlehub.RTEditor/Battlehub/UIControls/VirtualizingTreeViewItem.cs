namespace Battlehub.UIControls;

[Token(Token = "0x2000052")]
public class VirtualizingTreeViewItem : VirtualizingItemContainer
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000174")]
	private TreeViewExpander m_expander; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000175")]
	private HorizontalLayoutGroup m_itemLayout; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000176")]
	private Toggle m_toggle; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000177")]
	private TreeViewItemContainerData m_treeViewItemData; //Field offset: 0x88

	[Token(Token = "0x170000B6")]
	public bool CanExpand
	{
		[Address(RVA = "0x5F34C0", Offset = "0x5F26C0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600038D")]
		 get { } //Length: 25
		[Address(RVA = "0x5F3610", Offset = "0x5F2810", Length = "0xC1")]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DataBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TreeViewExpander), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600038E")]
		 set { } //Length: 193
	}

	[Token(Token = "0x170000B8")]
	public bool HasChildren
	{
		[Address(RVA = "0x5F34E0", Offset = "0x5F26E0", Length = "0x3F")]
		[CalledBy(Type = typeof(VirtualizingTreeViewDropMarker), Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
		[Calls(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000391")]
		 get { } //Length: 63
	}

	[Token(Token = "0x170000B1")]
	public float Indent
	{
		[Address(RVA = "0x5F3520", Offset = "0x5F2720", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000382")]
		 get { } //Length: 34
	}

	[Token(Token = "0x170000B7")]
	public bool IsExpanded
	{
		[Address(RVA = "0x5F3550", Offset = "0x5F2750", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600038F")]
		 get { } //Length: 25
		[Address(RVA = "0x5F36E0", Offset = "0x5F28E0", Length = "0x180")]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "StartOverride", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
		[Calls(Type = typeof(TreeViewExpander), Member = "set_IsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VirtualizingTreeView), Member = "Internal_Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000390")]
		 set { } //Length: 384
	}

	[Token(Token = "0x170000B5")]
	public virtual bool IsSelected
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600038B")]
		 get { } //Length: 5
		[Address(RVA = "0x5F3870", Offset = "0x5F2A70", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingItemContainer), Member = "set_IsSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600038C")]
		 set { } //Length: 160
	}

	[Token(Token = "0x170000B2")]
	public virtual object Item
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000383")]
		 get { } //Length: 5
		[Address(RVA = "0x5F3920", Offset = "0x5F2B20", Length = "0x28D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(TreeViewExpander), Member = "set_IsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TreeViewExpander), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
		[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
		[Calls(Type = typeof(VirtualizingItemContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000384")]
		 set { } //Length: 653
	}

	[Token(Token = "0x170000B4")]
	public TreeViewItemContainerData Parent
	{
		[Address(RVA = "0x5F3570", Offset = "0x5F2770", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000386")]
		 get { } //Length: 25
		[Address(RVA = "0x5F3BB0", Offset = "0x5F2DB0", Length = "0x40")]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TreeViewItemContainerData), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
		[Token(Token = "0x6000387")]
		 set { } //Length: 64
	}

	[Token(Token = "0x170000B0")]
	private VirtualizingTreeView TreeView
	{
		[Address(RVA = "0x5F3590", Offset = "0x5F2790", Length = "0x7B")]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "get_HasChildren", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "FirstChild", ReturnType = typeof(TreeViewItemContainerData))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "NextChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(TreeViewItemContainerData))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "LastChild", ReturnType = typeof(TreeViewItemContainerData))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "LastDescendant", ReturnType = typeof(TreeViewItemContainerData))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "StartOverride", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VirtualizingItemContainer), Member = "get_ItemsControl", ReturnType = typeof(VirtualizingItemsControl))]
		[Token(Token = "0x6000381")]
		private get { } //Length: 123
	}

	[Token(Token = "0x170000B3")]
	public TreeViewItemContainerData TreeViewItemData
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000385")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x5F34B0", Offset = "0x5F26B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000399")]
	public VirtualizingTreeViewItem() { }

	[Address(RVA = "0x5F2600", Offset = "0x5F1800", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TreeViewExpander), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000396")]
	protected virtual void AwakeOverride() { }

	[Address(RVA = "0x5F2740", Offset = "0x5F1940", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "FirstChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000392")]
	public TreeViewItemContainerData FirstChild() { }

	[Address(RVA = "0x5F34C0", Offset = "0x5F26C0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600038D")]
	public bool get_CanExpand() { }

	[Address(RVA = "0x5F34E0", Offset = "0x5F26E0", Length = "0x3F")]
	[CalledBy(Type = typeof(VirtualizingTreeViewDropMarker), Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000391")]
	public bool get_HasChildren() { }

	[Address(RVA = "0x5F3520", Offset = "0x5F2720", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000382")]
	public float get_Indent() { }

	[Address(RVA = "0x5F3550", Offset = "0x5F2750", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600038F")]
	public bool get_IsExpanded() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038B")]
	public virtual bool get_IsSelected() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000383")]
	public virtual object get_Item() { }

	[Address(RVA = "0x5F3570", Offset = "0x5F2770", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000386")]
	public TreeViewItemContainerData get_Parent() { }

	[Address(RVA = "0x5F3590", Offset = "0x5F2790", Length = "0x7B")]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "get_HasChildren", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "FirstChild", ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "NextChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "LastChild", ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "LastDescendant", ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "StartOverride", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "get_ItemsControl", ReturnType = typeof(VirtualizingItemsControl))]
	[Token(Token = "0x6000381")]
	private VirtualizingTreeView get_TreeView() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000385")]
	public TreeViewItemContainerData get_TreeViewItemData() { }

	[Address(RVA = "0x5F2780", Offset = "0x5F1980", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "LastChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000394")]
	public TreeViewItemContainerData LastChild() { }

	[Address(RVA = "0x5F27C0", Offset = "0x5F19C0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "LastDescendant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000395")]
	public TreeViewItemContainerData LastDescendant() { }

	[Address(RVA = "0x5F2800", Offset = "0x5F1A00", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000398")]
	private void LateUpdate() { }

	[Address(RVA = "0x5F2860", Offset = "0x5F1A60", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000393")]
	public TreeViewItemContainerData NextChild(TreeViewItemContainerData currentChild) { }

	[Address(RVA = "0x5F3610", Offset = "0x5F2810", Length = "0xC1")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DataBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TreeViewExpander), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600038E")]
	public void set_CanExpand(bool value) { }

	[Address(RVA = "0x5F36E0", Offset = "0x5F28E0", Length = "0x180")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "StartOverride", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Internal_Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(TreeViewExpander), Member = "set_IsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000390")]
	public void set_IsExpanded(bool value) { }

	[Address(RVA = "0x5F3870", Offset = "0x5F2A70", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "set_IsSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600038C")]
	public virtual void set_IsSelected(bool value) { }

	[Address(RVA = "0x5F3920", Offset = "0x5F2B20", Length = "0x28D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TreeViewExpander), Member = "set_CanExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeViewExpander), Member = "set_IsOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000384")]
	public virtual void set_Item(object value) { }

	[Address(RVA = "0x5F3BB0", Offset = "0x5F2DB0", Length = "0x40")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
	[Token(Token = "0x6000387")]
	public void set_Parent(TreeViewItemContainerData value) { }

	[Address(RVA = "0x5F2A00", Offset = "0x5F1C00", Length = "0x319")]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "SetIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeViewItem), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemContainer), Member = "get_ItemsControl", ReturnType = typeof(VirtualizingItemsControl))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "set_left", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "SetIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeViewItem), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038A")]
	private void SetIndent(VirtualizingTreeViewItem parent, ref int itemIndex) { }

	[Address(RVA = "0x5F2D20", Offset = "0x5F1F20", Length = "0x253")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Toggle), Member = "set_isOn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "IsItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "set_padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "set_IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000397")]
	protected virtual void StartOverride() { }

	[Address(RVA = "0x5F2F80", Offset = "0x5F2180", Length = "0x3D8")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DataBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingItemContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "MoveSubtree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetNextSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetPrevSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "UpdateIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "get_TreeView", ReturnType = typeof(VirtualizingTreeView))]
	[Calls(Type = typeof(VirtualizingTreeViewItem), Member = "SetIndent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeViewItem), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "set_padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000388")]
	public void UpdateIndent() { }

	[Address(RVA = "0x5F3360", Offset = "0x5F2560", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "set_padding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000389")]
	private void ZeroIndent() { }

}


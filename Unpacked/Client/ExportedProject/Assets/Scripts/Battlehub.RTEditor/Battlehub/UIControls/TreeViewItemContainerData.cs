namespace Battlehub.UIControls;

[Token(Token = "0x200004D")]
public class TreeViewItemContainerData : ItemContainerData
{
	[CompilerGenerated]
	[Token(Token = "0x400015E")]
	private static EventHandler<VirtualizingParentChangedEventArgs> ParentChanging; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x400015F")]
	private static EventHandler<VirtualizingParentChangedEventArgs> ParentChanged; //Field offset: 0x8
	[Token(Token = "0x4000160")]
	public static bool Internal_RaiseEvents; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000161")]
	private TreeViewItemContainerData m_parent; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000162")]
	private int <Indent>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000163")]
	private bool <CanExpand>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000164")]
	private bool <IsExpanded>k__BackingField; //Field offset: 0x2D

	[Token(Token = "0x14000044")]
	public static event EventHandler<VirtualizingParentChangedEventArgs> ParentChanged
	{
		[Address(RVA = "0x5ED430", Offset = "0x5EC630", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000339")]
		 add { } //Length: 261
		[Address(RVA = "0x5ED670", Offset = "0x5EC870", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600033A")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000043")]
	public static event EventHandler<VirtualizingParentChangedEventArgs> ParentChanging
	{
		[Address(RVA = "0x5ED540", Offset = "0x5EC740", Length = "0x101")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000337")]
		 add { } //Length: 257
		[Address(RVA = "0x5ED780", Offset = "0x5EC980", Length = "0x101")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000338")]
		 remove { } //Length: 257
	}

	[Token(Token = "0x170000AC")]
	public bool CanExpand
	{
		[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000340")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000341")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000AB")]
	public int Indent
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033E")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600033F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000AD")]
	public bool IsExpanded
	{
		[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000342")]
		 get { } //Length: 5
		[Address(RVA = "0x3BAA30", Offset = "0x3B9C30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000343")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A9")]
	public TreeViewItemContainerData Parent
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600033B")]
		 get { } //Length: 5
		[Address(RVA = "0x5ED890", Offset = "0x5ECA90", Length = "0x1E2")]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(VirtualizingParentChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600033C")]
		 set { } //Length: 482
	}

	[Token(Token = "0x170000AA")]
	public object ParentItem
	{
		[Address(RVA = "0x5ED650", Offset = "0x5EC850", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600033D")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x5ED3F0", Offset = "0x5EC5F0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600034C")]
	private static TreeViewItemContainerData() { }

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034B")]
	public TreeViewItemContainerData() { }

	[Address(RVA = "0x5ED430", Offset = "0x5EC630", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000339")]
	public static void add_ParentChanged(EventHandler<VirtualizingParentChangedEventArgs> value) { }

	[Address(RVA = "0x5ED540", Offset = "0x5EC740", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000337")]
	public static void add_ParentChanging(EventHandler<VirtualizingParentChangedEventArgs> value) { }

	[Address(RVA = "0x5ECDE0", Offset = "0x5EBFE0", Length = "0xB1")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetNextSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetPrevSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "FirstChild", ReturnType = typeof(TreeViewItemContainerData))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000346")]
	public TreeViewItemContainerData FirstChild(VirtualizingTreeView treeView) { }

	[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000340")]
	public bool get_CanExpand() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033E")]
	public int get_Indent() { }

	[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000342")]
	public bool get_IsExpanded() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600033B")]
	public TreeViewItemContainerData get_Parent() { }

	[Address(RVA = "0x5ED650", Offset = "0x5EC850", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600033D")]
	public object get_ParentItem() { }

	[Address(RVA = "0x5ECEA0", Offset = "0x5EC0A0", Length = "0xE1")]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "UpdateIndent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "FirstChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "LastChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(TreeViewItemContainerData), Member = "LastDescendant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(TreeViewItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "get_HasChildren", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ItemContainerData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000345")]
	public bool HasChildren(VirtualizingTreeView treeView) { }

	[Address(RVA = "0x5ECF90", Offset = "0x5EC190", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000344")]
	public bool IsDescendantOf(TreeViewItemContainerData ancestor) { }

	[Address(RVA = "0x5ECFD0", Offset = "0x5EC1D0", Length = "0x10A")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "LastChild", ReturnType = typeof(TreeViewItemContainerData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000348")]
	public TreeViewItemContainerData LastChild(VirtualizingTreeView treeView) { }

	[Address(RVA = "0x5ED0E0", Offset = "0x5EC2E0", Length = "0x105")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "OnTreeViewItemParentChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(VirtualizingParentChangedEventArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetNextSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "LastDescendant", ReturnType = typeof(TreeViewItemContainerData))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TreeViewItemContainerData), Member = "HasChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VirtualizingTreeView)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000349")]
	public TreeViewItemContainerData LastDescendant(VirtualizingTreeView treeView) { }

	[Address(RVA = "0x5ED1F0", Offset = "0x5EC3F0", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainerData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ItemContainerData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000347")]
	public TreeViewItemContainerData NextChild(VirtualizingTreeView treeView, TreeViewItemContainerData currentChild) { }

	[Address(RVA = "0x5ED670", Offset = "0x5EC870", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600033A")]
	public static void remove_ParentChanged(EventHandler<VirtualizingParentChangedEventArgs> value) { }

	[Address(RVA = "0x5ED780", Offset = "0x5EC980", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000338")]
	public static void remove_ParentChanging(EventHandler<VirtualizingParentChangedEventArgs> value) { }

	[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000341")]
	public void set_CanExpand(bool value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600033F")]
	public void set_Indent(int value) { }

	[Address(RVA = "0x3BAA30", Offset = "0x3B9C30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000343")]
	public void set_IsExpanded(bool value) { }

	[Address(RVA = "0x5ED890", Offset = "0x5ECA90", Length = "0x1E2")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "Internal_Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeViewItem), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingParentChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeViewItemContainerData), typeof(TreeViewItemContainerData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600033C")]
	public void set_Parent(TreeViewItemContainerData value) { }

	[Address(RVA = "0x5ED390", Offset = "0x5EC590", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034A")]
	public virtual string ToString() { }

}


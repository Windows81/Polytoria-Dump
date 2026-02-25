namespace UnityEngine.UIElements;

[Token(Token = "0x200005A")]
public class DefaultTreeViewController : TreeViewController
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001BC")]
	private TreeDataController<T> m_TreeDataController; //Field offset: 0x0

	[Token(Token = "0x17000065")]
	public virtual IList itemsSource
	{
		[Address(RVA = "0x9E6220", Offset = "0x9E5420", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600030D")]
		 get { } //Length: 25
		[Address(RVA = "0x9E6CE0", Offset = "0x9E5EE0", Length = "0x113")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600030E")]
		 set { } //Length: 275
	}

	[Token(Token = "0x17000064")]
	private TreeDataController<T> treeDataController
	{
		[Address(RVA = "0x9E6B30", Offset = "0x9E5D30", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TreeDataController`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600030C")]
		private get { } //Length: 131
	}

	[Address(RVA = "0x9E6A90", Offset = "0x9E5C90", Length = "0x7")]
	[CalledBy(Type = typeof(TreeView), Member = "CreateViewController", ReturnType = typeof(CollectionViewController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000311")]
	public DefaultTreeViewController`1() { }

	[Address(RVA = "0x9E61B0", Offset = "0x9E53B0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "CreateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000312")]
	private HierarchyNode <SetRootItems>b__6_0(HierarchyNode node) { }

	[Address(RVA = "0x9E61E0", Offset = "0x9E53E0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateIdToNodeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HierarchyNode&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000313")]
	private void <SetRootItems>b__6_1(int id, HierarchyNode node) { }

	[Address(RVA = "0x9E6220", Offset = "0x9E5420", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030D")]
	public virtual IList get_itemsSource() { }

	[Address(RVA = "0x9E6B30", Offset = "0x9E5D30", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TreeDataController`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600030C")]
	private TreeDataController<T> get_treeDataController() { }

	[Address(RVA = "0x9E65A0", Offset = "0x9E57A0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052000")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetHierarchyNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode))]
	[Calls(Type = typeof(TreeDataController`1), Member = "GetDataForNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000310")]
	public virtual object GetItemForIndex(int index) { }

	[Address(RVA = "0x9E6CE0", Offset = "0x9E5EE0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600030E")]
	public virtual void set_itemsSource(IList value) { }

	[Address(RVA = "0x9E6620", Offset = "0x9E5820", Length = "0x228")]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "set_itemsSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "get_baseTreeView", ReturnType = typeof(BaseTreeView))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeDataController`1), Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", typeof(System.Func`2<Unity.Hierarchy.HierarchyNode, Unity.Hierarchy.HierarchyNode>), typeof(System.Action`2<System.Int32, Unity.Hierarchy.HierarchyNode>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "IsViewDataKeyEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TreeDataController`1), Member = "ClearNodeToDataDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180052000")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ClearIdToNodeDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionViewController), Member = "SetHierarchyViewModelWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyViewModel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030F")]
	public override void SetRootItems(IList<TreeViewItemData`1<T>> items) { }

}


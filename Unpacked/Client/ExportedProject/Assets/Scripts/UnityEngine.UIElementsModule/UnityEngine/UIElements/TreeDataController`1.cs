namespace UnityEngine.UIElements;

[Token(Token = "0x200005E")]
internal sealed class TreeDataController
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001BF")]
	private Dictionary<HierarchyNode, TreeViewItemData`1<T>> m_NodeToItemDataDictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C0")]
	private Stack<IEnumerator`1<TreeViewItemData`1<T>>> m_ItemStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C1")]
	private Stack<HierarchyNode> m_NodeStack; //Field offset: 0x0

	[Address(RVA = "0x100AAE0", Offset = "0x1009CE0", Length = "0x12E")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "get_treeDataController", ReturnType = "UnityEngine.UIElements.TreeDataController`1<T>")]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "get_treeDataController", ReturnType = "UnityEngine.UIElements.TreeDataController`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000338")]
	public TreeDataController`1() { }

	[Address(RVA = "0x1009C80", Offset = "0x1008E80", Length = "0x2D")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000337")]
	internal void ClearNodeToDataDictionary() { }

	[Address(RVA = "0x100A210", Offset = "0x1009410", Length = "0x429")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "SetRootItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<TreeViewItemData`1<T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HierarchyNode), Member = "get_Null", ReturnType = typeof(HierarchyNode&))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode), typeof(UnityEngine.UIElements.TreeViewItemData`1<System.Object>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B8E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Stack`1), Member = "Pop", ReturnType = "T")]
	[Calls(Type = typeof(Stack`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000335")]
	internal void ConvertTreeViewItemDataToHierarchy(IEnumerable<TreeViewItemData`1<T>> list, Func<HierarchyNode, HierarchyNode> createNode, Action<Int32, HierarchyNode> updateDictionary) { }

	[Address(RVA = "0x100A830", Offset = "0x1009A30", Length = "0x4F")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = "GetItemForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode), typeof(TreeViewItemData`1<Object>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000334")]
	public T GetDataForNode(HierarchyNode node) { }

	[Address(RVA = "0x100A880", Offset = "0x1009A80", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<Unity.Hierarchy.HierarchyNode, UnityEngine.UIElements.TreeViewItemData`1<System.Object>>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode), typeof(UnityEngine.UIElements.TreeViewItemData`1<System.Object>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000336")]
	internal void UpdateNodeToDataDictionary(HierarchyNode node, TreeViewItemData<T> item) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x200005C")]
public class MultiColumnListViewController : BaseListViewController
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BD")]
	private MultiColumnController m_ColumnController; //Field offset: 0x48

	[Token(Token = "0x17000067")]
	public MultiColumnController columnController
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1AC92C0", Offset = "0x1AC84C0", Length = "0x178")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "CreateViewController", ReturnType = typeof(CollectionViewController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseListViewController), Member = "add_itemsSourceSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600031B")]
	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x1AC8910", Offset = "0x1AC7B10", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000324")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x1AC89B0", Offset = "0x1AC7BB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000326")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x1AC89D0", Offset = "0x1AC7BD0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000328")]
	public virtual void Dispose() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600031A")]
	public MultiColumnController get_columnController() { }

	[Address(RVA = "0x1AC8B40", Offset = "0x1AC7D40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000322")]
	public virtual int GetIdForIndex(int index) { }

	[Address(RVA = "0x1AC8B60", Offset = "0x1AC7D60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSortedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000321")]
	public virtual int GetIndexForId(int id) { }

	[Address(RVA = "0x1AC8B80", Offset = "0x1AC7D80", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "GetSourceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000320")]
	public virtual object GetItemForIndex(int index) { }

	[Address(RVA = "0x1AC8C30", Offset = "0x1AC7E30", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListViewController), Member = "InvokeBindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "set_tooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600031F")]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x1AC8DA0", Offset = "0x1AC7FA0", Length = "0x26D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReusableListViewItem), Member = "UpdateHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListViewController), Member = "PostInitRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableListViewItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600031E")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x1AC9010", Offset = "0x1AC8210", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000323")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x1AC9050", Offset = "0x1AC8250", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000327")]
	protected virtual void PrepareView() { }

	[Address(RVA = "0x1AC9030", Offset = "0x1AC8230", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "SortIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600031C")]
	internal virtual void PreRefresh() { }

	[Address(RVA = "0x1AC9180", Offset = "0x1AC8380", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "UpdateDragger", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600031D")]
	private void SortIfNeeded() { }

	[Address(RVA = "0x1AC91D0", Offset = "0x1AC83D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000325")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

	[Address(RVA = "0x1AC91F0", Offset = "0x1AC83F0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseListViewController), Member = "get_baseListView", ReturnType = typeof(BaseListView))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000329")]
	private void UpdateReorderClassList() { }

}


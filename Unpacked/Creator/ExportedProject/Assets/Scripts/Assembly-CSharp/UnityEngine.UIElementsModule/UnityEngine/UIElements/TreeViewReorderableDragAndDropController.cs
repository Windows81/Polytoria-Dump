namespace UnityEngine.UIElements;

[Token(Token = "0x2000198")]
internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	[Token(Token = "0x2000199")]
	internal class DropData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400079C")]
		public Int32[] expandedIdsBeforeDrag; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400079D")]
		public Int32[] draggedIds; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400079E")]
		public int lastItemId; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400079F")]
		public float expandItemBeginTimerMs; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007A0")]
		public Vector2 expandItemBeginPosition; //Field offset: 0x28

		[Address(RVA = "0x1079D50", Offset = "0x1078F50", Length = "0xE")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C03")]
		public DropData() { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000798")]
	protected DropData m_DropData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000799")]
	protected readonly BaseTreeView m_TreeView; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400079A")]
	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400079B")]
	private Action m_ExpandDropItemCallback; //Field offset: 0x40

	[Address(RVA = "0x1C5FA60", Offset = "0x1C5EC60", Length = "0xDA")]
	[CalledBy(Type = typeof(BaseTreeView), Member = "CreateDragAndDropController", ReturnType = typeof(ICollectionDragAndDropController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000BF9")]
	public TreeViewReorderableDragAndDropController(BaseTreeView view) { }

	[Address(RVA = "0x1C5E2C0", Offset = "0x1C5D4C0", Length = "0x68F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000BFA")]
	protected virtual int CompareId(int id1, int id2) { }

	[Address(RVA = "0x1C5E950", Offset = "0x1C5DB50", Length = "0x1D1")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "HandleAutoExpand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000C01")]
	private void DelayExpandDropItem() { }

	[Address(RVA = "0x1C5EB30", Offset = "0x1C5DD30", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreeViewReorderableDragAndDropController), Member = "RestoreExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BFE")]
	public virtual void DragCleanup() { }

	[Address(RVA = "0x1C5EC40", Offset = "0x1C5DE40", Length = "0x278")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseTreeView), Member = "IsExpanded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetExpandedItemIds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseTreeView), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C02")]
	private void ExpandDropItem() { }

	[Address(RVA = "0x1C5EEC0", Offset = "0x1C5E0C0", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(TreeViewReorderableDragAndDropController), Member = "DelayExpandDropItem", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C00")]
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	[Address(RVA = "0x1C5F040", Offset = "0x1C5E240", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BFC")]
	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x1C5F0C0", Offset = "0x1C5E2C0", Length = "0x5F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "GetChildIndexForId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "RefreshItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "ExpandItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801E3770")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BFD")]
	public virtual void OnDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x1C5F6C0", Offset = "0x1C5E8C0", Length = "0x23B")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "DragCleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseTreeView), Member = "CollapseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000BFF")]
	private void RestoreExpanded(List<Int32> ids) { }

	[Address(RVA = "0x1C5F900", Offset = "0x1C5EB00", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StartDragArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DragVisualMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000BFB")]
	public virtual StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x2000197")]
internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000797")]
	protected readonly BaseListView m_ListView; //Field offset: 0x28

	[Address(RVA = "0x1C56B50", Offset = "0x1C55D50", Length = "0x32")]
	[CalledBy(Type = typeof(BaseListView), Member = "CreateDragAndDropController", ReturnType = typeof(ICollectionDragAndDropController))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BF6")]
	public ListViewReorderableDragAndDropController(BaseListView view) { }

	[Address(RVA = "0x1C567F0", Offset = "0x1C559F0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BF7")]
	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x1C56890", Offset = "0x1C55A90", Length = "0x2B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectionType", ReturnType = typeof(SelectionType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelectionWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000BF8")]
	public virtual void OnDrop(IListDragAndDropArgs args) { }

}


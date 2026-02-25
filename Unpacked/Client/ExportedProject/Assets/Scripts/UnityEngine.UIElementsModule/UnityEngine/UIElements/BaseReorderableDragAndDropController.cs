namespace UnityEngine.UIElements;

[Token(Token = "0x2000181")]
internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000752")]
	protected readonly BaseVerticalCollectionView m_View; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000753")]
	protected List<Int32> m_SortedSelectedIds; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000754")]
	private bool <enableReordering>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000201")]
	public override bool enableReordering
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B70")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B71")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1C30E50", Offset = "0x1C30050", Length = "0x98")]
	[CalledBy(Type = typeof(ListViewReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseListView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseTreeView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000B6F")]
	protected BaseReorderableDragAndDropController(BaseVerticalCollectionView view) { }

	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B72")]
	public override bool CanStartDrag(IEnumerable<Int32> itemIds) { }

	[Address(RVA = "0x1C30940", Offset = "0x1C2FB40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B74")]
	protected override int CompareId(int id1, int id2) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B77")]
	public override void DragCleanup() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B70")]
	public override bool get_enableReordering() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6E")]
	public override IEnumerable<Int32> GetSortedSelectedIds() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B78")]
	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	[Token(Token = "0x6000B75")]
	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[Token(Token = "0x6000B76")]
	public abstract void OnDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B71")]
	public override void set_enableReordering(bool value) { }

	[Address(RVA = "0x1C30960", Offset = "0x1C2FB60", Length = "0x4EC")]
	[CalledBy(Type = typeof(TreeViewReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UQueryExtensions), Member = "Q", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(string), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_reorderable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000B73")]
	public override StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}


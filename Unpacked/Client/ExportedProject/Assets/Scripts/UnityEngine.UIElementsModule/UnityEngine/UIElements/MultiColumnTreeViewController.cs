namespace UnityEngine.UIElements;

[Token(Token = "0x200005D")]
public abstract class MultiColumnTreeViewController : BaseTreeViewController
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001BE")]
	private MultiColumnController m_ColumnController; //Field offset: 0x68

	[Token(Token = "0x17000068")]
	public MultiColumnController columnController
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600032A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1AC9760", Offset = "0x1AC8960", Length = "0xC0")]
	[CalledBy(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600032B")]
	protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x1AC9440", Offset = "0x1AC8640", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600032F")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x1AC94E0", Offset = "0x1AC86E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000331")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x1AC9500", Offset = "0x1AC8700", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000333")]
	public virtual void Dispose() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600032A")]
	public MultiColumnController get_columnController() { }

	[Address(RVA = "0x1AC9570", Offset = "0x1AC8770", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeViewController), Member = "PostInitRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableTreeViewItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600032D")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x1AC96B0", Offset = "0x1AC88B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600032E")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x1AC9710", Offset = "0x1AC8910", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "PrepareView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000332")]
	protected virtual void PrepareView() { }

	[Address(RVA = "0x1AC96D0", Offset = "0x1AC88D0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseTreeViewController), Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "SortIfNeeded", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600032C")]
	internal virtual void PreRefresh() { }

	[Address(RVA = "0x1AC9740", Offset = "0x1AC8940", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000330")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x2000119")]
public class MultiColumnTreeView : BaseTreeView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200011A")]
	internal class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits>
	{

		[Address(RVA = "0x1C2C610", Offset = "0x1C2B810", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60008F6")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200011B")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400059D")]
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400059E")]
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x400059F")]
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; //Field offset: 0xE0

		[Address(RVA = "0x1C2F730", Offset = "0x1C2E930", Length = "0x1B4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "set_obsoleteNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.String>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60008F8")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2E4C0", Offset = "0x1C2D6C0", Length = "0x35A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiColumnTreeView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008F7")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000594")]
	private static readonly BindingId columnsProperty; //Field offset: 0x0
	[Token(Token = "0x4000595")]
	private static readonly BindingId sortColumnDescriptionsProperty; //Field offset: 0x98
	[Token(Token = "0x4000596")]
	private static readonly BindingId sortingModeProperty; //Field offset: 0x130
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x4000597")]
	private Columns m_Columns; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x4000598")]
	private ColumnSortingMode m_SortingMode; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x4000599")]
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x400059A")]
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x400059B")]
	private Action columnSortingChanged; //Field offset: 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x400059C")]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x410

	[CreateProperty]
	[Token(Token = "0x1700017F")]
	public private Columns columns
	{
		[Address(RVA = "0x1C19670", Offset = "0x1C18870", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008E7")]
		 get { } //Length: 8
		[Address(RVA = "0x1C19720", Offset = "0x1C18920", Length = "0x173")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Columns), Member = "remove_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
		[Calls(Type = typeof(Columns), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(Columns), Member = "add_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Columns), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60008E8")]
		private set { } //Length: 371
	}

	[CreateProperty]
	[Token(Token = "0x17000180")]
	public private SortColumnDescriptions sortColumnDescriptions
	{
		[Address(RVA = "0x1C19680", Offset = "0x1C18880", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008E9")]
		 get { } //Length: 8
		[Address(RVA = "0x1C198A0", Offset = "0x1C18AA0", Length = "0x111")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60008EA")]
		private set { } //Length: 273
	}

	[CreateProperty]
	[Token(Token = "0x17000181")]
	public ColumnSortingMode sortingMode
	{
		[Address(RVA = "0x1C19690", Offset = "0x1C18890", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60008EB")]
		 get { } //Length: 7
		[Address(RVA = "0x1C199C0", Offset = "0x1C18BC0", Length = "0xB2")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
		[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60008EC")]
		 set { } //Length: 178
	}

	[Token(Token = "0x1700017E")]
	public MultiColumnTreeViewController viewController
	{
		[Address(RVA = "0x1C196A0", Offset = "0x1C188A0", Length = "0x7B")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
		[Token(Token = "0x60008E6")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x1C190F0", Offset = "0x1C182F0", Length = "0x2A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60008F5")]
	private static MultiColumnTreeView() { }

	[Address(RVA = "0x1C194F0", Offset = "0x1C186F0", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Columns), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60008ED")]
	public MultiColumnTreeView() { }

	[Address(RVA = "0x1C193A0", Offset = "0x1C185A0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortColumnDescriptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008EE")]
	public MultiColumnTreeView(Columns columns) { }

	[Address(RVA = "0x1C18080", Offset = "0x1C17280", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F3")]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C17FB0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DefaultMultiColumnTreeViewController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008EF")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x1C18E50", Offset = "0x1C18050", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60008F1")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x1C19670", Offset = "0x1C18870", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E7")]
	public Columns get_columns() { }

	[Address(RVA = "0x1C19680", Offset = "0x1C18880", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E9")]
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	[Address(RVA = "0x1C19690", Offset = "0x1C18890", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60008EB")]
	public ColumnSortingMode get_sortingMode() { }

	[Address(RVA = "0x1C196A0", Offset = "0x1C188A0", Length = "0x7B")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseTreeView), Member = "get_viewController", ReturnType = typeof(BaseTreeViewController))]
	[Token(Token = "0x60008E6")]
	public MultiColumnTreeViewController get_viewController() { }

	[Address(RVA = "0x1C18E90", Offset = "0x1C18090", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008F2")]
	private void RaiseColumnSortingChanged() { }

	[Address(RVA = "0x1C18EB0", Offset = "0x1C180B0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008F4")]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	[Address(RVA = "0x1C19720", Offset = "0x1C18920", Length = "0x173")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Columns), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "GetOrCreateViewController", ReturnType = typeof(CollectionViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "remove_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_propertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<UnityEngine.UIElements.BindablePropertyChangedEventArgs>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008E8")]
	private void set_columns(Columns value) { }

	[Address(RVA = "0x1C198A0", Offset = "0x1C18AA0", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008EA")]
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	[Address(RVA = "0x1C199C0", Offset = "0x1C18BC0", Length = "0xB2")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
	[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008EC")]
	public void set_sortingMode(ColumnSortingMode value) { }

	[Address(RVA = "0x1C18ED0", Offset = "0x1C180D0", Length = "0x212")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnTreeView), Member = "get_viewController", ReturnType = typeof(MultiColumnTreeViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MultiColumnController), Member = "remove_columnSortingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "remove_headerContextMenuPopulateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent, UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseTreeView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "add_columnSortingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "add_headerContextMenuPopulateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent, UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60008F0")]
	public virtual void SetViewController(CollectionViewController controller) { }

}


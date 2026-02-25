namespace UnityEngine.UIElements;

[Token(Token = "0x2000116")]
public class MultiColumnListView : BaseListView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000117")]
	internal class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits>
	{

		[Address(RVA = "0x1C2C4D0", Offset = "0x1C2B6D0", Length = "0x39")]
		[CalledBy(Type = typeof(VisualElementFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60008E3")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000118")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4000591")]
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode; //Field offset: 0x108
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4000592")]
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns; //Field offset: 0x110
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4000593")]
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; //Field offset: 0x118

		[Address(RVA = "0x1C2F570", Offset = "0x1C2E770", Length = "0x1B4")]
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
		[Token(Token = "0x60008E5")]
		public UxmlTraits() { }

		[Address(RVA = "0x1C2D330", Offset = "0x1C2C530", Length = "0x35A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MultiColumnListView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008E4")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000588")]
	private static readonly BindingId columnsProperty; //Field offset: 0x0
	[Token(Token = "0x4000589")]
	private static readonly BindingId sortColumnDescriptionsProperty; //Field offset: 0x98
	[Token(Token = "0x400058A")]
	private static readonly BindingId sortingModeProperty; //Field offset: 0x130
	[FieldOffset(Offset = "0x4D8")]
	[Token(Token = "0x400058B")]
	private Columns m_Columns; //Field offset: 0x4D8
	[FieldOffset(Offset = "0x4E0")]
	[Token(Token = "0x400058C")]
	private ColumnSortingMode m_SortingMode; //Field offset: 0x4E0
	[FieldOffset(Offset = "0x4E8")]
	[Token(Token = "0x400058D")]
	private SortColumnDescriptions m_SortColumnDescriptions; //Field offset: 0x4E8
	[FieldOffset(Offset = "0x4F0")]
	[Token(Token = "0x400058E")]
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x4F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4F8")]
	[Token(Token = "0x400058F")]
	private Action columnSortingChanged; //Field offset: 0x4F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x500")]
	[Token(Token = "0x4000590")]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0x500

	[CreateProperty]
	[Token(Token = "0x1700017B")]
	public private Columns columns
	{
		[Address(RVA = "0x1C0AFE0", Offset = "0x1C0A1E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D4")]
		 get { } //Length: 8
		[Address(RVA = "0x1C18A50", Offset = "0x1C17C50", Length = "0x173")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
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
		[Token(Token = "0x60008D5")]
		private set { } //Length: 371
	}

	[CreateProperty]
	[Token(Token = "0x1700017C")]
	public private SortColumnDescriptions sortColumnDescriptions
	{
		[Address(RVA = "0x1C0AFD0", Offset = "0x1C0A1D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D6")]
		 get { } //Length: 8
		[Address(RVA = "0x1C18BD0", Offset = "0x1C17DD0", Length = "0x111")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60008D7")]
		private set { } //Length: 273
	}

	[CreateProperty]
	[Token(Token = "0x1700017D")]
	public ColumnSortingMode sortingMode
	{
		[Address(RVA = "0x1C189C0", Offset = "0x1C17BC0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60008D8")]
		 get { } //Length: 7
		[Address(RVA = "0x1C18CF0", Offset = "0x1C17EF0", Length = "0xB2")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
		[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60008D9")]
		 set { } //Length: 178
	}

	[Token(Token = "0x1700017A")]
	public MultiColumnListViewController viewController
	{
		[Address(RVA = "0x1C189D0", Offset = "0x1C17BD0", Length = "0x7B")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
		[Token(Token = "0x60008D3")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x1C18440", Offset = "0x1C17640", Length = "0x2A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60008E2")]
	private static MultiColumnListView() { }

	[Address(RVA = "0x1C18840", Offset = "0x1C17A40", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Columns), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60008DA")]
	public MultiColumnListView() { }

	[Address(RVA = "0x1C186F0", Offset = "0x1C178F0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortColumnDescriptions), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseListView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_viewDataKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008DB")]
	public MultiColumnListView(Columns columns) { }

	[Address(RVA = "0x1C18080", Offset = "0x1C17280", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E0")]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[Address(RVA = "0x1C18110", Offset = "0x1C17310", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MultiColumnListViewController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008DC")]
	protected virtual CollectionViewController CreateViewController() { }

	[Address(RVA = "0x1C181A0", Offset = "0x1C173A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x60008DE")]
	virtual void CreateVirtualizationController() { }

	[Address(RVA = "0x1C0AFE0", Offset = "0x1C0A1E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D4")]
	public Columns get_columns() { }

	[Address(RVA = "0x1C0AFD0", Offset = "0x1C0A1D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D6")]
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	[Address(RVA = "0x1C189C0", Offset = "0x1C17BC0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60008D8")]
	public ColumnSortingMode get_sortingMode() { }

	[Address(RVA = "0x1C189D0", Offset = "0x1C17BD0", Length = "0x7B")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseListView), Member = "get_viewController", ReturnType = typeof(BaseListViewController))]
	[Token(Token = "0x60008D3")]
	public MultiColumnListViewController get_viewController() { }

	[Address(RVA = "0x1C181E0", Offset = "0x1C173E0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008DF")]
	private void RaiseColumnSortingChanged() { }

	[Address(RVA = "0x1C18200", Offset = "0x1C17400", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008E1")]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

	[Address(RVA = "0x1C18A50", Offset = "0x1C17C50", Length = "0x173")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
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
	[Token(Token = "0x60008D5")]
	private void set_columns(Columns value) { }

	[Address(RVA = "0x1C18BD0", Offset = "0x1C17DD0", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008D7")]
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	[Address(RVA = "0x1C18CF0", Offset = "0x1C17EF0", Length = "0xB2")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008D9")]
	public void set_sortingMode(ColumnSortingMode value) { }

	[Address(RVA = "0x1C18220", Offset = "0x1C17420", Length = "0x212")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnListView), Member = "get_viewController", ReturnType = typeof(MultiColumnListViewController))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MultiColumnController), Member = "remove_columnSortingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "remove_headerContextMenuPopulateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent, UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseListView), Member = "SetViewController", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionViewController)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "add_columnSortingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnController), Member = "add_headerContextMenuPopulateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent, UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60008DD")]
	public virtual void SetViewController(CollectionViewController controller) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x200011D")]
[UxmlObject]
public class SortColumnDescription : INotifyBindablePropertyChanged
{
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200011F")]
	public class UxmlObjectFactory : UxmlObjectFactory<SortColumnDescription>
	{

		[Address(RVA = "0x1C2C750", Offset = "0x1C2B950", Length = "0x39")]
		[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600090B")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200011E")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x849EA0", Offset = "0x8490A0", Length = "0x22")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600090A")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000120")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005AC")]
		private readonly UxmlStringAttributeDescription m_ColumnName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005AD")]
		private readonly UxmlIntAttributeDescription m_ColumnIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005AE")]
		private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription; //Field offset: 0x0

		[Address(RVA = "0x84C070", Offset = "0x84B270", Length = "0x183")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlIntAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600090D")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x84B610", Offset = "0x84A810", Length = "0x19A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SortColumnDescription), Member = "set_columnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescription), Member = "set_columnIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SortColumnDescription), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortDirection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600090C")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40005A3")]
	private static readonly BindingId columnNameProperty; //Field offset: 0x0
	[Token(Token = "0x40005A4")]
	private static readonly BindingId columnIndexProperty; //Field offset: 0x98
	[Token(Token = "0x40005A5")]
	private static readonly BindingId directionProperty; //Field offset: 0x130
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40005A6")]
	private int m_ColumnIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40005A7")]
	private string m_ColumnName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005A8")]
	private SortDirection m_SortDirection; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005A9")]
	private EventHandler<BindablePropertyChangedEventArgs> propertyChanged; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005AA")]
	private Column <column>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005AB")]
	private Action<SortColumnDescription> changed; //Field offset: 0x38

	[Token(Token = "0x14000022")]
	internal event Action<SortColumnDescription> changed
	{
		[Address(RVA = "0x1C28460", Offset = "0x1C27660", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000903")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C285C0", Offset = "0x1C277C0", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000904")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x14000021")]
	public override event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Address(RVA = "0x1C28510", Offset = "0x1C27710", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60008F9")]
		 add { } //Length: 172
		[Address(RVA = "0x1C28670", Offset = "0x1C27870", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60008FA")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000184")]
	public internal Column column
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000900")]
		internal set { } //Length: 13
	}

	[CreateProperty]
	[Token(Token = "0x17000183")]
	public int columnIndex
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FD")]
		 get { } //Length: 4
		[Address(RVA = "0x1C28720", Offset = "0x1C27920", Length = "0x90")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60008FE")]
		 set { } //Length: 144
	}

	[CreateProperty]
	[Token(Token = "0x17000182")]
	public string columnName
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008FB")]
		 get { } //Length: 5
		[Address(RVA = "0x1C287B0", Offset = "0x1C279B0", Length = "0xA5")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60008FC")]
		 set { } //Length: 165
	}

	[CreateProperty]
	[Token(Token = "0x17000185")]
	public SortDirection direction
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000901")]
		 get { } //Length: 4
		[Address(RVA = "0x1C28860", Offset = "0x1C27A60", Length = "0x90")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000902")]
		 set { } //Length: 144
	}

	[Address(RVA = "0x1C27F40", Offset = "0x1C27140", Length = "0x2A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000909")]
	private static SortColumnDescription() { }

	[Address(RVA = "0x1C281F0", Offset = "0x1C273F0", Length = "0x136")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000907")]
	public SortColumnDescription(string columnName, SortDirection direction) { }

	[Address(RVA = "0x1C28330", Offset = "0x1C27530", Length = "0x121")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000906")]
	public SortColumnDescription(int columnIndex, SortDirection direction) { }

	[Address(RVA = "0x10787E0", Offset = "0x10779E0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000905")]
	public SortColumnDescription() { }

	[Address(RVA = "0x1C28460", Offset = "0x1C27660", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000903")]
	internal void add_changed(Action<SortColumnDescription> value) { }

	[Address(RVA = "0x1C28510", Offset = "0x1C27710", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60008F9")]
	public override void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FF")]
	public Column get_column() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FD")]
	public int get_columnIndex() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FB")]
	public string get_columnName() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000901")]
	public SortDirection get_direction() { }

	[Address(RVA = "0x1C27E50", Offset = "0x1C27050", Length = "0xE9")]
	[CalledBy(Type = typeof(SortColumnDescription), Member = "set_columnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortColumnDescription), Member = "set_columnIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortColumnDescription), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortColumnDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SortDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortColumnDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SortDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BindablePropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000908")]
	private void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x1C285C0", Offset = "0x1C277C0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000904")]
	internal void remove_changed(Action<SortColumnDescription> value) { }

	[Address(RVA = "0x1C28670", Offset = "0x1C27870", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60008FA")]
	public override void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000900")]
	internal void set_column(Column value) { }

	[Address(RVA = "0x1C28720", Offset = "0x1C27920", Length = "0x90")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008FE")]
	public void set_columnIndex(int value) { }

	[Address(RVA = "0x1C287B0", Offset = "0x1C279B0", Length = "0xA5")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008FC")]
	public void set_columnName(string value) { }

	[Address(RVA = "0x1C28860", Offset = "0x1C27A60", Length = "0x90")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortColumnDescription), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000902")]
	public void set_direction(SortDirection value) { }

}


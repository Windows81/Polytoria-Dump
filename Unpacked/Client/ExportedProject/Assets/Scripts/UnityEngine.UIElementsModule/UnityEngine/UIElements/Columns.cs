namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x200010E")]
[UxmlObject]
public class Columns : ICollection<Column>, IEnumerable<Column>, IEnumerable, INotifyBindablePropertyChanged
{
	[CompilerGenerated]
	[Token(Token = "0x2000113")]
	private sealed class <>c
	{
		[Token(Token = "0x4000571")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000572")]
		public static Predicate<Column> <>9__87_0; //Field offset: 0x8

		[Address(RVA = "0x1C15740", Offset = "0x1C14940", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008AA")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AB")]
		public <>c() { }

		[Address(RVA = "0x1C15650", Offset = "0x1C14850", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60008AC")]
		internal bool <UpdateVisibleColumns>b__87_0(Column c) { }

	}

	[Token(Token = "0x200010F")]
	internal enum StretchMode
	{
		Grow = 0,
		GrowAndFill = 1,
	}

	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000111")]
	public class UxmlObjectFactory : UxmlObjectFactory<Columns>
	{

		[Address(RVA = "0x1C15A30", Offset = "0x1C14C30", Length = "0x39")]
		[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60008A7")]
		public UxmlObjectFactory() { }

	}

	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000110")]
	public class UxmlObjectFactory : UxmlObjectFactory<T, UxmlObjectTraits`1<T>>
	{

		[Address(RVA = "0x849EA0", Offset = "0x8490A0", Length = "0x22")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A6")]
		public UxmlObjectFactory`1() { }

	}

	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000112")]
	public class UxmlObjectTraits : UxmlObjectTraits<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056B")]
		private readonly UxmlStringAttributeDescription m_PrimaryColumnName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056C")]
		private readonly UxmlEnumAttributeDescription<StretchMode> m_StretchMode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056D")]
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056E")]
		private readonly UxmlBoolAttributeDescription m_Resizable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056F")]
		private readonly UxmlBoolAttributeDescription m_ResizePreview; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000570")]
		private readonly UxmlObjectListAttributeDescription<Column> m_Columns; //Field offset: 0x0

		[Address(RVA = "0x84BE00", Offset = "0x84B000", Length = "0x26D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UxmlEnumAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlBoolAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A9")]
		public UxmlObjectTraits`1() { }

		[Address(RVA = "0x84A840", Offset = "0x849A40", Length = "0x3DB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Columns), Member = "set_resizable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Columns), Member = "set_primaryColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "set_stretchMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StretchMode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "set_resizePreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Columns), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A8")]
		public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x4000553")]
	private static readonly BindingId primaryColumnNameProperty; //Field offset: 0x0
	[Token(Token = "0x4000554")]
	private static readonly BindingId reorderableProperty; //Field offset: 0x98
	[Token(Token = "0x4000555")]
	private static readonly BindingId resizableProperty; //Field offset: 0x130
	[Token(Token = "0x4000556")]
	private static readonly BindingId resizePreviewProperty; //Field offset: 0x1C8
	[Token(Token = "0x4000557")]
	private static readonly BindingId stretchModeProperty; //Field offset: 0x260
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000558")]
	private IList<Column> m_Columns; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000559")]
	private List<Column> m_DisplayColumns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400055A")]
	private List<Column> m_VisibleColumns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400055B")]
	private bool m_VisibleColumnsDirty; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400055C")]
	private StretchMode m_StretchMode; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400055D")]
	private bool m_Reorderable; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400055E")]
	private bool m_Resizable; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400055F")]
	private bool m_ResizePreview; //Field offset: 0x32
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000560")]
	private string m_PrimaryColumnName; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000561")]
	private EventHandler<BindablePropertyChangedEventArgs> propertyChanged; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000562")]
	private Action<ColumnsDataType> changed; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000563")]
	private Action<Column, Int32> columnAdded; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000564")]
	private Action<Column> columnRemoved; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000565")]
	private Action<Column, ColumnDataType> columnChanged; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000566")]
	private Action<Column> columnResized; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000567")]
	private Action<Column, Int32, Int32> columnReordered; //Field offset: 0x70

	[Token(Token = "0x14000019")]
	internal event Action<ColumnsDataType> changed
	{
		[Address(RVA = "0x1C02B80", Offset = "0x1C01D80", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600087E")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C03310", Offset = "0x1C02510", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600087F")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001A")]
	internal event Action<Column, Int32> columnAdded
	{
		[Address(RVA = "0x1C02C30", Offset = "0x1C01E30", Length = "0xAC")]
		[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000882")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C033C0", Offset = "0x1C025C0", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000883")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001C")]
	internal event Action<Column, ColumnDataType> columnChanged
	{
		[Address(RVA = "0x1C02CE0", Offset = "0x1C01EE0", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000886")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C03470", Offset = "0x1C02670", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000887")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001B")]
	internal event Action<Column> columnRemoved
	{
		[Address(RVA = "0x1C02D90", Offset = "0x1C01F90", Length = "0xAC")]
		[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000884")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C03520", Offset = "0x1C02720", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000885")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001E")]
	internal event Action<Column, Int32, Int32> columnReordered
	{
		[Address(RVA = "0x1C02E40", Offset = "0x1C02040", Length = "0xAC")]
		[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600088A")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C035D0", Offset = "0x1C027D0", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600088B")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x1400001D")]
	internal event Action<Column> columnResized
	{
		[Address(RVA = "0x1C02EF0", Offset = "0x1C020F0", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000888")]
		internal add { } //Length: 172
		[Address(RVA = "0x1C03680", Offset = "0x1C02880", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000889")]
		internal remove { } //Length: 172
	}

	[Token(Token = "0x14000018")]
	public override event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Address(RVA = "0x1C02FA0", Offset = "0x1C021A0", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000872")]
		 add { } //Length: 172
		[Address(RVA = "0x1C03730", Offset = "0x1C02930", Length = "0xAC")]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000873")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000174")]
	public override int Count
	{
		[Address(RVA = "0x1C03050", Offset = "0x1C02250", Length = "0x46")]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000898")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000171")]
	internal IEnumerable<Column> displayList
	{
		[Address(RVA = "0x1C032D0", Offset = "0x1C024D0", Length = "0x1A")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Columns), Member = "InitOrderColumns", ReturnType = typeof(void))]
		[Token(Token = "0x600087C")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000175")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x1C030A0", Offset = "0x1C022A0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000899")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000176")]
	public Column Item
	{
		[Address(RVA = "0x1C030F0", Offset = "0x1C022F0", Length = "0x54")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600089C")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000177")]
	public Column Item
	{
		[Address(RVA = "0x1C03150", Offset = "0x1C02350", Length = "0x174")]
		[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600089D")]
		 get { } //Length: 372
	}

	[CreateProperty]
	[Token(Token = "0x1700016D")]
	public string primaryColumnName
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000874")]
		 get { } //Length: 5
		[Address(RVA = "0x1C037E0", Offset = "0x1C029E0", Length = "0xA4")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000875")]
		 set { } //Length: 164
	}

	[CreateProperty]
	[Token(Token = "0x1700016E")]
	public bool reorderable
	{
		[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000876")]
		 get { } //Length: 5
		[Address(RVA = "0x1C03890", Offset = "0x1C02A90", Length = "0x95")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000877")]
		 set { } //Length: 149
	}

	[CreateProperty]
	[Token(Token = "0x1700016F")]
	public bool resizable
	{
		[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000878")]
		 get { } //Length: 5
		[Address(RVA = "0x1C03930", Offset = "0x1C02B30", Length = "0x95")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000879")]
		 set { } //Length: 149
	}

	[CreateProperty]
	[Token(Token = "0x17000170")]
	public bool resizePreview
	{
		[Address(RVA = "0x35C810", Offset = "0x35BA10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600087A")]
		 get { } //Length: 5
		[Address(RVA = "0x1C039D0", Offset = "0x1C02BD0", Length = "0x95")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600087B")]
		 set { } //Length: 149
	}

	[CreateProperty]
	[Token(Token = "0x17000173")]
	public StretchMode stretchMode
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000880")]
		 get { } //Length: 4
		[Address(RVA = "0x1C03A70", Offset = "0x1C02C70", Length = "0x92")]
		[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000881")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000172")]
	internal IEnumerable<Column> visibleList
	{
		[Address(RVA = "0x1C032F0", Offset = "0x1C024F0", Length = "0x1A")]
		[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnMover), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnMover), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortingStatus", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
		[Token(Token = "0x600087D")]
		internal get { } //Length: 26
	}

	[Address(RVA = "0x1C026C0", Offset = "0x1C018C0", Length = "0x42B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60008A5")]
	private static Columns() { }

	[Address(RVA = "0x1C02AF0", Offset = "0x1C01CF0", Length = "0x88")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008A4")]
	public Columns() { }

	[Address(RVA = "0x1C011F0", Offset = "0x1C003F0", Length = "0x62")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600088F")]
	public override void Add(Column item) { }

	[Address(RVA = "0x1C02B80", Offset = "0x1C01D80", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600087E")]
	internal void add_changed(Action<ColumnsDataType> value) { }

	[Address(RVA = "0x1C02C30", Offset = "0x1C01E30", Length = "0xAC")]
	[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000882")]
	internal void add_columnAdded(Action<Column, Int32> value) { }

	[Address(RVA = "0x1C02CE0", Offset = "0x1C01EE0", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000886")]
	internal void add_columnChanged(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x1C02D90", Offset = "0x1C01F90", Length = "0xAC")]
	[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000884")]
	internal void add_columnRemoved(Action<Column> value) { }

	[Address(RVA = "0x1C02E40", Offset = "0x1C02040", Length = "0xAC")]
	[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600088A")]
	internal void add_columnReordered(Action<Column, Int32, Int32> value) { }

	[Address(RVA = "0x1C02EF0", Offset = "0x1C020F0", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000888")]
	internal void add_columnResized(Action<Column> value) { }

	[Address(RVA = "0x1C02FA0", Offset = "0x1C021A0", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000872")]
	public override void add_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x1C01260", Offset = "0x1C00460", Length = "0x21D")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Columns), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000890")]
	public override void Clear() { }

	[Address(RVA = "0x1C01480", Offset = "0x1C00680", Length = "0x171")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000892")]
	public bool Contains(string name) { }

	[Address(RVA = "0x1C01600", Offset = "0x1C00800", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000891")]
	public override bool Contains(Column item) { }

	[Address(RVA = "0x1C01660", Offset = "0x1C00860", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000893")]
	public override void CopyTo(Column[] array, int arrayIndex) { }

	[Address(RVA = "0x1C01730", Offset = "0x1C00930", Length = "0x60")]
	[CalledBy(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A0")]
	private void DirtyVisibleColumns() { }

	[Address(RVA = "0x1C03050", Offset = "0x1C02250", Length = "0x46")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000898")]
	public override int get_Count() { }

	[Address(RVA = "0x1C032D0", Offset = "0x1C024D0", Length = "0x1A")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Columns), Member = "InitOrderColumns", ReturnType = typeof(void))]
	[Token(Token = "0x600087C")]
	internal IEnumerable<Column> get_displayList() { }

	[Address(RVA = "0x1C030A0", Offset = "0x1C022A0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000899")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x1C030F0", Offset = "0x1C022F0", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600089C")]
	public Column get_Item(int index) { }

	[Address(RVA = "0x1C03150", Offset = "0x1C02350", Length = "0x174")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600089D")]
	public Column get_Item(string name) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000874")]
	public string get_primaryColumnName() { }

	[Address(RVA = "0x3351B0", Offset = "0x3343B0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000876")]
	public bool get_reorderable() { }

	[Address(RVA = "0x35C800", Offset = "0x35BA00", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000878")]
	public bool get_resizable() { }

	[Address(RVA = "0x35C810", Offset = "0x35BA10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600087A")]
	public bool get_resizePreview() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000880")]
	public StretchMode get_stretchMode() { }

	[Address(RVA = "0x1C032F0", Offset = "0x1C024F0", Length = "0x1A")]
	[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnController), Member = "BindItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnContextualMenuManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextualMenuPopulateEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortingStatus", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Token(Token = "0x600087D")]
	internal IEnumerable<Column> get_visibleList() { }

	[Address(RVA = "0x1C01790", Offset = "0x1C00990", Length = "0x46")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600088D")]
	public override IEnumerator<Column> GetEnumerator() { }

	[Address(RVA = "0x1C017E0", Offset = "0x1C009E0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600089A")]
	public int IndexOf(Column column) { }

	[Address(RVA = "0x1C01840", Offset = "0x1C00A40", Length = "0x79")]
	[CalledBy(Type = typeof(Column), Member = "get_displayIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Columns), Member = "get_displayList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[CalledBy(Type = typeof(Columns), Member = "ReorderDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600089F")]
	private void InitOrderColumns() { }

	[Address(RVA = "0x1C018C0", Offset = "0x1C00AC0", Length = "0x37A")]
	[CalledBy(Type = typeof(Columns), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Column), Member = "add_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Columns), Member = "DirtyVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Columns), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600089B")]
	public void Insert(int index, Column column) { }

	[Address(RVA = "0x1C01C40", Offset = "0x1C00E40", Length = "0x7D")]
	[CalledBy(Type = typeof(ReusableMultiColumnListViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReusableMultiColumnTreeViewItem), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Column), Member = "get_visibleIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600088C")]
	public bool IsPrimary(Column column) { }

	[Address(RVA = "0x1C01CC0", Offset = "0x1C00EC0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008A2")]
	private void NotifyChange(ColumnsDataType type) { }

	[Address(RVA = "0x1C01CE0", Offset = "0x1C00EE0", Length = "0xE9")]
	[CalledBy(Type = typeof(Columns), Member = "set_primaryColumnName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "set_reorderable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "set_resizable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "set_resizePreview", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "set_stretchMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StretchMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "OnColumnsPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindablePropertyChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BindablePropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008A3")]
	private void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x1C01DD0", Offset = "0x1C00FD0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000896")]
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x1C01E70", Offset = "0x1C01070", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000897")]
	private void OnColumnResized(Column column) { }

	[Address(RVA = "0x1C01E90", Offset = "0x1C01090", Length = "0x24F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BindingId), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingId))]
	[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000895")]
	private void OnColumnsPropertyChanged(object sender, BindablePropertyChangedEventArgs args) { }

	[Address(RVA = "0x1C020E0", Offset = "0x1C012E0", Length = "0x2AD")]
	[CalledBy(Type = typeof(Columns), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Column)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Column), Member = "remove_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "remove_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(EventHandler`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000894")]
	public override bool Remove(Column column) { }

	[Address(RVA = "0x1C03310", Offset = "0x1C02510", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600087F")]
	internal void remove_changed(Action<ColumnsDataType> value) { }

	[Address(RVA = "0x1C033C0", Offset = "0x1C025C0", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000883")]
	internal void remove_columnAdded(Action<Column, Int32> value) { }

	[Address(RVA = "0x1C03470", Offset = "0x1C02670", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000887")]
	internal void remove_columnChanged(Action<Column, ColumnDataType> value) { }

	[Address(RVA = "0x1C03520", Offset = "0x1C02720", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000885")]
	internal void remove_columnRemoved(Action<Column> value) { }

	[Address(RVA = "0x1C035D0", Offset = "0x1C027D0", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600088B")]
	internal void remove_columnReordered(Action<Column, Int32, Int32> value) { }

	[Address(RVA = "0x1C03680", Offset = "0x1C02880", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000889")]
	internal void remove_columnResized(Action<Column> value) { }

	[Address(RVA = "0x1C03730", Offset = "0x1C02930", Length = "0xAC")]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000873")]
	public override void remove_propertyChanged(EventHandler<BindablePropertyChangedEventArgs> value) { }

	[Address(RVA = "0x1C02390", Offset = "0x1C01590", Length = "0x13D")]
	[CalledBy(Type = typeof(ColumnMover), Member = "EndDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+ViewState", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "InitOrderColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600089E")]
	public void ReorderDisplay(int from, int to) { }

	[Address(RVA = "0x1C037E0", Offset = "0x1C029E0", Length = "0xA4")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000875")]
	public void set_primaryColumnName(string value) { }

	[Address(RVA = "0x1C03890", Offset = "0x1C02A90", Length = "0x95")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000877")]
	public void set_reorderable(bool value) { }

	[Address(RVA = "0x1C03930", Offset = "0x1C02B30", Length = "0x95")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000879")]
	public void set_resizable(bool value) { }

	[Address(RVA = "0x1C039D0", Offset = "0x1C02BD0", Length = "0x95")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600087B")]
	public void set_resizePreview(bool value) { }

	[Address(RVA = "0x1C03A70", Offset = "0x1C02C70", Length = "0x92")]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Columns), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000881")]
	public void set_stretchMode(StretchMode value) { }

	[Address(RVA = "0x1C01790", Offset = "0x1C00990", Length = "0x46")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600088E")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1C024D0", Offset = "0x1C016D0", Length = "0x1E8")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(Column), Member = "get_visibleIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "get_columnsWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "GetDesiredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "UpdateCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "UpdateMinAndMaxColumnsWidth", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "InitOrderColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008A1")]
	private void UpdateVisibleColumns() { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x200010A")]
internal class ColumnLayout
{
	[CompilerGenerated]
	[Token(Token = "0x200010B")]
	private sealed class <>c__DisplayClass53_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000549")]
		public float totalColumnWidth; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400054A")]
		public ColumnLayout <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086E")]
		public <>c__DisplayClass53_0() { }

		[Address(RVA = "0x1C15670", Offset = "0x1C14870", Length = "0xC3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600086F")]
		internal void <RecomputeToMaxWidthProportionally>b__1(Column c) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200010C")]
	private sealed class <>c__DisplayClass54_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400054B")]
		public float totalColumnsWidth; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400054C")]
		public ColumnLayout <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000870")]
		public <>c__DisplayClass54_0() { }

		[Address(RVA = "0x1C15670", Offset = "0x1C14870", Length = "0xC3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000871")]
		internal void <RecomputeToMinWidthProportionally>b__1(Column c) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000533")]
	private List<Column> m_StretchableColumns; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000534")]
	private List<Column> m_FixedColumns; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000535")]
	private List<Column> m_RelativeWidthColumns; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000536")]
	private List<Column> m_MixedWidthColumns; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000537")]
	private Columns m_Columns; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000538")]
	private float m_ColumnsWidth; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000539")]
	private bool m_ColumnsWidthDirty; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400053A")]
	private float m_MaxColumnsWidth; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400053B")]
	private float m_MinColumnsWidth; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400053C")]
	private bool m_IsDirty; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400053D")]
	private float m_PreviousWidth; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400053E")]
	private float m_LayoutWidth; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400053F")]
	private bool m_DragResizeInPreviewMode; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x4000540")]
	private bool m_DragResizing; //Field offset: 0x55
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000541")]
	private float m_DragStartPos; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000542")]
	private float m_DragLastPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000543")]
	private float m_DragInitialColumnWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000544")]
	private List<Column> m_DragStretchableColumns; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000545")]
	private List<Column> m_DragRelativeColumns; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000546")]
	private List<Column> m_DragFixedColumns; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000547")]
	private Dictionary<Column, Single> m_PreviewDesiredWidths; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000548")]
	private Action layoutRequested; //Field offset: 0x88

	[Token(Token = "0x14000017")]
	public event Action layoutRequested
	{
		[Address(RVA = "0x1BFF010", Offset = "0x1BFE210", Length = "0xA2")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600084B")]
		 add { } //Length: 162
		[Address(RVA = "0x1BFF370", Offset = "0x1BFE570", Length = "0xA2")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600084C")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x17000166")]
	public Columns columns
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000844")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000167")]
	public float columnsWidth
	{
		[Address(RVA = "0x1BFF0C0", Offset = "0x1BFE2C0", Length = "0x1F0")]
		[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000845")]
		 get { } //Length: 496
	}

	[Token(Token = "0x1700016C")]
	public bool hasRelativeWidthColumns
	{
		[Address(RVA = "0x1BFF2C0", Offset = "0x1BFE4C0", Length = "0x5B")]
		[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600084A")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700016B")]
	public bool hasStretchableColumns
	{
		[Address(RVA = "0x1BFF320", Offset = "0x1BFE520", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000849")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000168")]
	public float layoutWidth
	{
		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000846")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700016A")]
	public float maxColumnsWidth
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000848")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000169")]
	public float minColumnsWidth
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000847")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1BFEBD0", Offset = "0x1BFDDD0", Length = "0x435")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Column), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "add_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`3<UnityEngine.UIElements.Column, System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600084D")]
	public ColumnLayout(Columns columns) { }

	[Address(RVA = "0x1BFE550", Offset = "0x1BFD750", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600086A")]
	private int <DoLayout>b__49_0(Column c1, Column c2) { }

	[Address(RVA = "0x1BFE550", Offset = "0x1BFD750", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600086B")]
	private int <DoLayout>b__49_1(Column c1, Column c2) { }

	[Address(RVA = "0x1BFE550", Offset = "0x1BFD750", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600086C")]
	private int <RecomputeToMaxWidthProportionally>b__53_0(Column c1, Column c2) { }

	[Address(RVA = "0x1BFE5D0", Offset = "0x1BFD7D0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[Token(Token = "0x600086D")]
	private int <RecomputeToMinWidthProportionally>b__54_0(Column c1, Column c2) { }

	[Address(RVA = "0x1BFF010", Offset = "0x1BFE210", Length = "0xA2")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600084B")]
	public void add_layoutRequested(Action value) { }

	[Address(RVA = "0x1BF9F20", Offset = "0x1BF9120", Length = "0x2E8")]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "BeginDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "get_visibleIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000862")]
	internal void BeginDragResize(Column column, float pos, bool previewMode) { }

	[Address(RVA = "0x1BFA210", Offset = "0x1BF9410", Length = "0xB6")]
	[CalledBy(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "Dirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "UpdateCache", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000869")]
	private void ClearCache() { }

	[Address(RVA = "0x1BFA2D0", Offset = "0x1BF94D0", Length = "0x40")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600084E")]
	public void Dirty() { }

	[Address(RVA = "0x1BFA310", Offset = "0x1BF9510", Length = "0x396")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "StretchResizeColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000859")]
	private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	[Address(RVA = "0x1BFA6B0", Offset = "0x1BF98B0", Length = "0x302")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "StretchResizeColumns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToMinWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToMinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000858")]
	private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	[Address(RVA = "0x1BFA9C0", Offset = "0x1BF9BC0", Length = "0x10CE")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "DoLayout", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Column), Member = "set_desiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "get_columnsWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Column), Member = "GetWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Column), Member = "GetMaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Column), Member = "GetMinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ColumnLayout), Member = "UpdateMinAndMaxColumnsWidth", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "get_hasRelativeWidthColumns", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ColumnLayout), Member = "UpdateCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000856")]
	public void DoLayout(float width) { }

	[Address(RVA = "0x1BFBA90", Offset = "0x1BFAC90", Length = "0x4F2")]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "DistributeExcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "get_columnsWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000865")]
	public void DragResize(Column column, float pos) { }

	[Address(RVA = "0x1BFBF90", Offset = "0x1BFB190", Length = "0x24F")]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnKeyDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "EndDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Single>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000866")]
	internal void EndDragResize(Column column, bool cancelled) { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000844")]
	public Columns get_columns() { }

	[Address(RVA = "0x1BFF0C0", Offset = "0x1BFE2C0", Length = "0x1F0")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000845")]
	public float get_columnsWidth() { }

	[Address(RVA = "0x1BFF2C0", Offset = "0x1BFE4C0", Length = "0x5B")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600084A")]
	public bool get_hasRelativeWidthColumns() { }

	[Address(RVA = "0x1BFF320", Offset = "0x1BFE520", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000849")]
	public bool get_hasStretchableColumns() { }

	[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000846")]
	public float get_layoutWidth() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000848")]
	public float get_maxColumnsWidth() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000847")]
	public float get_minColumnsWidth() { }

	[Address(RVA = "0x1BFC1E0", Offset = "0x1BFB3E0", Length = "0x14B")]
	[CalledBy(Type = typeof(ColumnMover), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Column), Member = "get_visibleIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000863")]
	public float GetDesiredPosition(Column column) { }

	[Address(RVA = "0x1BFC330", Offset = "0x1BFB530", Length = "0x9C")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMinWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "BeginDragMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnMover), Member = "UpdateMoveLocation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "UpdatePreviewPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000864")]
	public float GetDesiredWidth(Column c) { }

	[Address(RVA = "0x1BFC3D0", Offset = "0x1BFB5D0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000855")]
	private static bool IsClamped(float value, float min, float max) { }

	[Address(RVA = "0x1BFC3E0", Offset = "0x1BFB5E0", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Column), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "add_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600084F")]
	private void OnColumnAdded(Column column, int index) { }

	[Address(RVA = "0x1BFC4F0", Offset = "0x1BFB6F0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000853")]
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x1BFC550", Offset = "0x1BFB750", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Column), Member = "remove_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "remove_resized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000850")]
	private void OnColumnRemoved(Column column) { }

	[Address(RVA = "0x1BFA2D0", Offset = "0x1BF94D0", Length = "0x40")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000851")]
	private void OnColumnReordered(Column column, int from, int to) { }

	[Address(RVA = "0x1BFC660", Offset = "0x1BFB860", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000854")]
	private void OnColumnResized(Column column) { }

	[Address(RVA = "0x1BFC990", Offset = "0x1BFBB90", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600085C")]
	private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	[Address(RVA = "0x1BFC670", Offset = "0x1BFB870", Length = "0x318")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DistributeExcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600085D")]
	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	[Address(RVA = "0x1BFD010", Offset = "0x1BFC210", Length = "0x295")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DistributeExcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600085F")]
	private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x1BFCAF0", Offset = "0x1BFBCF0", Length = "0x519")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DistributeExcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600085A")]
	private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x1BFD780", Offset = "0x1BFC980", Length = "0x27C")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600085E")]
	private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x1BFD2B0", Offset = "0x1BFC4B0", Length = "0x4CC")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600085B")]
	private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x1BFF370", Offset = "0x1BFE570", Length = "0xA2")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600084C")]
	public void remove_layoutRequested(Action value) { }

	[Address(RVA = "0x1BFDA00", Offset = "0x1BFCC00", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000852")]
	private bool RequiresLayoutUpdate(ColumnDataType type) { }

	[Address(RVA = "0x1BFDA20", Offset = "0x1BFCC20", Length = "0x1D4")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "EndDragResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMinWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMinWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "RecomputeToDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Column), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000861")]
	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false) { }

	[Address(RVA = "0x1BFDC00", Offset = "0x1BFCE00", Length = "0x87F")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "ResizeToFit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "<OnContextualMenuManipulator>b__67_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DropdownMenuAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ColumnLayout), Member = "RecomputeToMaxWidthProportionally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(float), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColumnLayout), Member = "GetDesiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "UpdateCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ColumnLayout), Member = "get_columnsWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000860")]
	public void ResizeToFit(float width) { }

	[Address(RVA = "0x1BFE480", Offset = "0x1BFD680", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ColumnLayout), Member = "DistributeExcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "DistributeOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Column>), typeof(Single&), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000857")]
	public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	[Address(RVA = "0x1BFE650", Offset = "0x1BFD850", Length = "0x32A")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ColumnLayout), Member = "ClearCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000867")]
	private void UpdateCache() { }

	[Address(RVA = "0x1BFE980", Offset = "0x1BFDB80", Length = "0x248")]
	[CalledBy(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "UpdateVisibleColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000868")]
	private void UpdateMinAndMaxColumnsWidth() { }

}


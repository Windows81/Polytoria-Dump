namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000639")]
internal class MultiColumnCollectionHeader : VisualElement, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200063E")]
	private sealed class <>c__DisplayClass67_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400174B")]
		public Column column; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400174C")]
		public MultiColumnCollectionHeader <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C08")]
		public <>c__DisplayClass67_0() { }

		[Address(RVA = "0x1BF8730", Offset = "0x1BF7930", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Column), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002C09")]
		internal void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

		[Address(RVA = "0x1BF8760", Offset = "0x1BF7960", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002C0A")]
		internal Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200063F")]
	private sealed class <>c__DisplayClass73_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400174D")]
		public Column column; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C0B")]
		public <>c__DisplayClass73_0() { }

		[Address(RVA = "0x1BF87F0", Offset = "0x1BF79F0", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Column), Member = "get_index", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002C0C")]
		internal bool <UpdateSortColumnDescriptionsOnClick>b__0(SortColumnDescription d) { }

	}

	[Token(Token = "0x200063C")]
	public class ColumnData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001747")]
		private MultiColumnHeaderColumn <control>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001748")]
		private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x17000B39")]
		public MultiColumnHeaderColumn control
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C02")]
			 get { } //Length: 5
			[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C03")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000B3A")]
		public MultiColumnHeaderColumnResizeHandle resizeHandle
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C04")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C05")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C06")]
		public ColumnData() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C02")]
		public MultiColumnHeaderColumn get_control() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C04")]
		public MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C03")]
		public void set_control(MultiColumnHeaderColumn value) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C05")]
		public void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	}

	[Token(Token = "0x200063D")]
	private struct SortedColumnState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001749")]
		public SortColumnDescription columnDesc; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400174A")]
		public SortDirection direction; //Field offset: 0x8

		[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C07")]
		public SortedColumnState(SortColumnDescription desc, SortDirection dir) { }

	}

	[Token(Token = "0x200063A")]
	private class ViewState
	{
		[Token(Token = "0x200063B")]
		private struct ColumnState
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001742")]
			public int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4001743")]
			public string name; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4001744")]
			public float actualWidth; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4001745")]
			public Length width; //Field offset: 0x14
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4001746")]
			public bool visible; //Field offset: 0x1C

		}

		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400173F")]
		private bool m_HasPersistedData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4001740")]
		private List<SortColumnDescription> m_SortDescriptions; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Token(Token = "0x4001741")]
		private List<ColumnState> m_OrderedColumnStates; //Field offset: 0x20

		[Address(RVA = "0x1BF9230", Offset = "0x1BF8430", Length = "0xBD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6002C01")]
		public ViewState() { }

		[Address(RVA = "0x1BF8880", Offset = "0x1BF7A80", Length = "0x35C")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnViewDataReady", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Columns), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_desiredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "set_visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Columns), Member = "ReorderDisplay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "get_displayIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(Columns), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Column))]
		[Calls(Type = typeof(Columns), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Column))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Columns), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002C00")]
		internal void Apply(MultiColumnCollectionHeader header) { }

		[Address(RVA = "0x1BF8BE0", Offset = "0x1BF7DE0", Length = "0x641")]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "SaveViewState", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Column), Member = "get_index", ReturnType = typeof(int))]
		[Calls(Type = typeof(Columns), Member = "get_displayList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6002BFF")]
		internal void Save(MultiColumnCollectionHeader header) { }

	}

	[Token(Token = "0x400172A")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x400172B")]
	public static readonly string columnContainerUssClassName; //Field offset: 0x8
	[Token(Token = "0x400172C")]
	public static readonly string handleContainerUssClassName; //Field offset: 0x10
	[Token(Token = "0x400172D")]
	public static readonly string reorderableUssClassName; //Field offset: 0x18
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400172E")]
	private bool m_SortingEnabled; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400172F")]
	private List<SortColumnDescription> m_SortedColumns; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4001730")]
	private SortColumnDescriptions m_SortDescriptions; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x4001731")]
	private List<SortedColumnState> m_OldSortedColumnStates; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4001732")]
	private bool m_SortingUpdatesTemporarilyDisabled; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4001733")]
	private ViewState m_ViewState; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4001734")]
	private bool m_ApplyingViewState; //Field offset: 0x300
	[FieldOffset(Offset = "0x301")]
	[Token(Token = "0x4001735")]
	private bool m_DoLayoutScheduled; //Field offset: 0x301
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4001736")]
	private readonly Dictionary<Column, ColumnData> <columnDataMap>k__BackingField; //Field offset: 0x308
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4001737")]
	private readonly ColumnLayout <columnLayout>k__BackingField; //Field offset: 0x310
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4001738")]
	private readonly VisualElement <columnContainer>k__BackingField; //Field offset: 0x318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4001739")]
	private readonly VisualElement <resizeHandleContainer>k__BackingField; //Field offset: 0x320
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x400173A")]
	private readonly Columns <columns>k__BackingField; //Field offset: 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x400173B")]
	private Action<Int32, Single> columnResized; //Field offset: 0x330
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x400173C")]
	private Action columnSortingChanged; //Field offset: 0x338
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x400173D")]
	private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; //Field offset: 0x340
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x400173E")]
	private Action viewDataRestored; //Field offset: 0x348

	[Token(Token = "0x14000036")]
	public event Action<Int32, Single> columnResized
	{
		[Address(RVA = "0x1BF44A0", Offset = "0x1BF36A0", Length = "0xBA")]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BDA")]
		 add { } //Length: 186
		[Address(RVA = "0x1BF47B0", Offset = "0x1BF39B0", Length = "0xBA")]
		[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BDB")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000037")]
	public event Action columnSortingChanged
	{
		[Address(RVA = "0x1BF4560", Offset = "0x1BF3760", Length = "0xA2")]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BDC")]
		 add { } //Length: 162
		[Address(RVA = "0x1BF4870", Offset = "0x1BF3A70", Length = "0xA2")]
		[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BDD")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000038")]
	public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent
	{
		[Address(RVA = "0x1BF4610", Offset = "0x1BF3810", Length = "0xBA")]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BDE")]
		 add { } //Length: 186
		[Address(RVA = "0x1BF4920", Offset = "0x1BF3B20", Length = "0xBA")]
		[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BDF")]
		 remove { } //Length: 186
	}

	[Token(Token = "0x14000039")]
	internal event Action viewDataRestored
	{
		[Address(RVA = "0x1BF46D0", Offset = "0x1BF38D0", Length = "0xA2")]
		[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BE0")]
		internal add { } //Length: 162
		[Address(RVA = "0x1BF49E0", Offset = "0x1BF3BE0", Length = "0xA2")]
		[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6002BE1")]
		internal remove { } //Length: 162
	}

	[Token(Token = "0x17000B32")]
	public VisualElement columnContainer
	{
		[Address(RVA = "0x1BF4780", Offset = "0x1BF3980", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B30")]
	public Dictionary<Column, ColumnData> columnDataMap
	{
		[Address(RVA = "0xFF7CD0", Offset = "0xFF6ED0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BCF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B31")]
	public ColumnLayout columnLayout
	{
		[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B37")]
	public Columns columns
	{
		[Address(RVA = "0x833AB0", Offset = "0x832CB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B2F")]
	internal bool isApplyingViewState
	{
		[Address(RVA = "0x1BF4790", Offset = "0x1BF3990", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002BCE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000B33")]
	public VisualElement resizeHandleContainer
	{
		[Address(RVA = "0x833AA0", Offset = "0x832CA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B36")]
	public private SortColumnDescriptions sortDescriptions
	{
		[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD5")]
		 get { } //Length: 8
		[Address(RVA = "0x1BF4A90", Offset = "0x1BF3C90", Length = "0xAF")]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(SortColumnDescriptions), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002BD6")]
		private set { } //Length: 175
	}

	[Token(Token = "0x17000B35")]
	internal IReadOnlyList<SortColumnDescription> sortedColumnReadonly
	{
		[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD4")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000B34")]
	public IEnumerable<SortColumnDescription> sortedColumns
	{
		[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000B38")]
	public bool sortingEnabled
	{
		[Address(RVA = "0x18B18B0", Offset = "0x18B0AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BD8")]
		 get { } //Length: 8
		[Address(RVA = "0x1BF4B40", Offset = "0x1BF3D40", Length = "0x33")]
		[CalledBy(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortingStatus", ReturnType = typeof(void))]
		[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
		[Token(Token = "0x6002BD9")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x1BF3B50", Offset = "0x1BF2D50", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002BFD")]
	private static MultiColumnCollectionHeader() { }

	[Address(RVA = "0x1BF3CC0", Offset = "0x1BF2EC0", Length = "0x7D4")]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColumnLayout), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`3<UnityEngine.UIElements.Column, System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(Columns), Member = "add_columnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContextualMenuManipulator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ContextualMenuPopulateEvent>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "add_columnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "add_layoutRequested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "StretchToParentSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BE2")]
	public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x1BF24C0", Offset = "0x1BF16C0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFE")]
	private void <OnContextualMenuManipulator>b__67_0(DropdownMenuAction a) { }

	[Address(RVA = "0x1BF44A0", Offset = "0x1BF36A0", Length = "0xBA")]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BDA")]
	public void add_columnResized(Action<Int32, Single> value) { }

	[Address(RVA = "0x1BF4560", Offset = "0x1BF3760", Length = "0xA2")]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BDC")]
	public void add_columnSortingChanged(Action value) { }

	[Address(RVA = "0x1BF4610", Offset = "0x1BF3810", Length = "0xBA")]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BDE")]
	public void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[Address(RVA = "0x1BF46D0", Offset = "0x1BF38D0", Length = "0xA2")]
	[CalledBy(Type = typeof(MultiColumnController), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BE0")]
	internal void add_viewDataRestored(Action value) { }

	[Address(RVA = "0x1BEFA90", Offset = "0x1BEEC90", Length = "0x716")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "RaiseColumnSortingChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "set_sortOrderLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002BF7")]
	private void ApplyColumnSorting() { }

	[Address(RVA = "0x1BF01B0", Offset = "0x1BEF3B0", Length = "0x236")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Clickable), Member = "remove_clickedWithEventInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.EventBase>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002BFB")]
	private void CleanupColumnData(ColumnData data) { }

	[Address(RVA = "0x1BF03F0", Offset = "0x1BEF5F0", Length = "0x3C1")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Columns), Member = "remove_columnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "CleanupColumnData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Columns), Member = "remove_columnResized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.Column>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "remove_columnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`3<UnityEngine.UIElements.Column, System.Int32, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "remove_columnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, UnityEngine.UIElements.ColumnDataType>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "remove_columnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<UnityEngine.UIElements.Column, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColumnLayout), Member = "remove_layoutRequested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "remove_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x6002BFC")]
	public override void Dispose() { }

	[Address(RVA = "0x1BF07C0", Offset = "0x1BEF9C0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002BF0")]
	private void DoLayout() { }

	[Address(RVA = "0x1BF4780", Offset = "0x1BF3980", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD1")]
	public VisualElement get_columnContainer() { }

	[Address(RVA = "0xFF7CD0", Offset = "0xFF6ED0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BCF")]
	public Dictionary<Column, ColumnData> get_columnDataMap() { }

	[Address(RVA = "0x1551C50", Offset = "0x1550E50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD0")]
	public ColumnLayout get_columnLayout() { }

	[Address(RVA = "0x833AB0", Offset = "0x832CB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD7")]
	public Columns get_columns() { }

	[Address(RVA = "0x1BF4790", Offset = "0x1BF3990", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002BCE")]
	internal bool get_isApplyingViewState() { }

	[Address(RVA = "0x833AA0", Offset = "0x832CA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD2")]
	public VisualElement get_resizeHandleContainer() { }

	[Address(RVA = "0x18B1880", Offset = "0x18B0A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD5")]
	public SortColumnDescriptions get_sortDescriptions() { }

	[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD4")]
	internal IReadOnlyList<SortColumnDescription> get_sortedColumnReadonly() { }

	[Address(RVA = "0x1BF47A0", Offset = "0x1BF39A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD3")]
	public IEnumerable<SortColumnDescription> get_sortedColumns() { }

	[Address(RVA = "0x18B18B0", Offset = "0x18B0AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BD8")]
	public bool get_sortingEnabled() { }

	[Address(RVA = "0x1BF0830", Offset = "0x1BEFA30", Length = "0x5E6")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "AddManipulator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IManipulator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Column), Member = "get_visibleIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Focusable), Member = "set_tabIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Clickable), Member = "add_clickedWithEventInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.EventBase>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BE8")]
	private void OnColumnAdded(Column column) { }

	[Address(RVA = "0x1BF0820", Offset = "0x1BEFA20", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002BE7")]
	private void OnColumnAdded(Column column, int index) { }

	[Address(RVA = "0x1BF0E20", Offset = "0x1BF0020", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002BEA")]
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	[Address(RVA = "0x1BF0EB0", Offset = "0x1BF00B0", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortColumnDescriptionsOnClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002BF2")]
	private void OnColumnClicked(EventBase evt) { }

	[Address(RVA = "0x1BF1060", Offset = "0x1BF0260", Length = "0x332")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002BF1")]
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1BF13A0", Offset = "0x1BF05A0", Length = "0x312")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultiColumnHeaderColumn), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Clickable), Member = "remove_clickedWithEventInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.EventBase>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002BE9")]
	private void OnColumnRemoved(Column column) { }

	[Address(RVA = "0x1BF16C0", Offset = "0x1BF08C0", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Column), Member = "get_visibleIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002BEB")]
	private void OnColumnReordered(Column column, int from, int to) { }

	[Address(RVA = "0x1BF1890", Offset = "0x1BF0A90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BEC")]
	private void OnColumnResized(Column column) { }

	[Address(RVA = "0x1BF18D0", Offset = "0x1BF0AD0", Length = "0x787")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(Status)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Column), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(DropdownMenu), Member = "AppendAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<UnityEngine.UIElements.DropdownMenuAction>), typeof(System.Func`2<UnityEngine.UIElements.DropdownMenuAction, UnityEngine.UIElements.DropdownMenuAction+Status>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002BED")]
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	[Address(RVA = "0x1BF2060", Offset = "0x1BF1260", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ColumnLayout), Member = "DoLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002BEF")]
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	[Address(RVA = "0x1BF21B0", Offset = "0x1BF13B0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002BEE")]
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	[Address(RVA = "0x1BF2250", Offset = "0x1BF1450", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetFullHierarchicalViewDataKey", ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualElement), Member = "GetOrCreateViewData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ViewState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BF9")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x1BF2360", Offset = "0x1BF1560", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002BF5")]
	private void RaiseColumnResized(int columnIndex) { }

	[Address(RVA = "0x1BF2480", Offset = "0x1BF1680", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002BF6")]
	private void RaiseColumnSortingChanged() { }

	[Address(RVA = "0x1BF47B0", Offset = "0x1BF39B0", Length = "0xBA")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BDB")]
	public void remove_columnResized(Action<Int32, Single> value) { }

	[Address(RVA = "0x1BF4870", Offset = "0x1BF3A70", Length = "0xA2")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BDD")]
	public void remove_columnSortingChanged(Action value) { }

	[Address(RVA = "0x1BF4920", Offset = "0x1BF3B20", Length = "0xBA")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BDF")]
	public void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[Address(RVA = "0x1BF49E0", Offset = "0x1BF3BE0", Length = "0xA2")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6002BE1")]
	internal void remove_viewDataRestored(Action value) { }

	[Address(RVA = "0x1BF24C0", Offset = "0x1BF16C0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ColumnLayout), Member = "ResizeToFit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BE4")]
	private void ResizeToFit() { }

	[Address(RVA = "0x1BF1890", Offset = "0x1BF0A90", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFA")]
	private void SaveViewState() { }

	[Address(RVA = "0x1BF2500", Offset = "0x1BF1700", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002BE3")]
	private void ScheduleDoLayout() { }

	[Address(RVA = "0x1BF25C0", Offset = "0x1BF17C0", Length = "0x2BA")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "OnHorizontalScrollerValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StyleTranslate), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StyleTranslate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002BF4")]
	public void ScrollHorizontally(float horizontalOffset) { }

	[Address(RVA = "0x1BF4A90", Offset = "0x1BF3C90", Length = "0xAF")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnListView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnTreeView), Member = "set_sortColumnDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "add_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002BD6")]
	protected private void set_sortDescriptions(SortColumnDescriptions value) { }

	[Address(RVA = "0x1BF4B40", Offset = "0x1BF3D40", Length = "0x33")]
	[CalledBy(Type = typeof(MultiColumnController), Member = "set_sortingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColumnSortingMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortingStatus", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortedColumns", ReturnType = typeof(void))]
	[Token(Token = "0x6002BD9")]
	public void set_sortingEnabled(bool value) { }

	[Address(RVA = "0x1BF2880", Offset = "0x1BF1A80", Length = "0x520")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(ColumnDataType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Column), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateSortingStatus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002BE6")]
	private void UpdateColumnControls() { }

	[Address(RVA = "0x1BF2DB0", Offset = "0x1BF1FB0", Length = "0x250")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Column), Member = "get_index", ReturnType = typeof(int))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortColumnDescription), Member = "set_direction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SortDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortColumnDescription), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SortDirection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SortColumnDescriptions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescription)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002BF3")]
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	[Address(RVA = "0x1BF3010", Offset = "0x1BF2210", Length = "0x60D")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortDescriptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortColumnDescriptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Columns), typeof(SortColumnDescriptions), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "OnColumnClicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleValueExtensions), Member = "CopyFrom", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortedColumnState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+SortedColumnState>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+SortedColumnState>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MultiColumnCollectionHeader), Member = "ApplyColumnSorting", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ViewState), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MultiColumnCollectionHeader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Columns), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Column))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Columns), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Column))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SortedColumnState)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+SortedColumnState>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader+SortedColumnState>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002BE5")]
	private void UpdateSortedColumns() { }

	[Address(RVA = "0x1BF3620", Offset = "0x1BF2820", Length = "0x521")]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "set_sortingEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MultiColumnCollectionHeader), Member = "UpdateColumnControls", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Columns), Member = "get_visibleList", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.Column>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "AddToClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002BF8")]
	private void UpdateSortingStatus() { }

}


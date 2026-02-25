namespace Battlehub.UIControls;

[Token(Token = "0x2000046")]
public class VirtualizingScrollRect : ScrollRect
{
	[CompilerGenerated]
	[Token(Token = "0x2000047")]
	private sealed class <>c
	{
		[Token(Token = "0x4000153")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000154")]
		public static Func<Int32, Int32> <>9__59_0; //Field offset: 0x8

		[Address(RVA = "0x5EE2F0", Offset = "0x5ED4F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600031E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031F")]
		public <>c() { }

		[Address(RVA = "0x32B1B0", Offset = "0x32A3B0", Length = "0x3")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000320")]
		internal int <RemoveItems>b__59_0(int i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000048")]
	private sealed class <CoRectTransformDimensionsChange>d__52 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000155")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000156")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000157")]
		public VirtualizingScrollRect <>4__this; //Field offset: 0x20

		[Token(Token = "0x170000A1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000324")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000A2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000326")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000321")]
		public <CoRectTransformDimensionsChange>d__52(int <>1__state) { }

		[Address(RVA = "0x5EDA80", Offset = "0x5ECC80", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000323")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000324")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000326")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5EDB70", Offset = "0x5ECD70", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000325")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000322")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000147")]
	private DataBindAction ItemDataBinding; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000148")]
	public RectTransform ContainerPrefab; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000149")]
	private RectTransform m_virtualContent; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400014A")]
	private HorizontalOrVerticalLayoutGroup m_layoutGroup; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400014B")]
	private RectTransformChangeListener m_virtualContentTransformChangeListener; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x400014C")]
	private VirtualizingMode m_mode; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	[Token(Token = "0x400014D")]
	private bool m_useGrid; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x400014E")]
	private Vector2 m_gridSpacing; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400014F")]
	private GridLayoutGroup m_gridLayoutGroup; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000150")]
	private LinkedList<RectTransform> m_containers; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000151")]
	private IList m_items; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000152")]
	private float m_normalizedIndex; //Field offset: 0x180

	[Token(Token = "0x14000042")]
	public event DataBindAction ItemDataBinding
	{
		[Address(RVA = "0x5F1430", Offset = "0x5F0630", Length = "0xA2")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60002F3")]
		 add { } //Length: 162
		[Address(RVA = "0x5F1BC0", Offset = "0x5F0DC0", Length = "0xA2")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDestroy", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60002F4")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1700009F")]
	private float ContainerSize
	{
		[Address(RVA = "0x5F14E0", Offset = "0x5F06E0", Length = "0x132")]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_ContainersPerGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000306")]
		private get { } //Length: 306
	}

	[Token(Token = "0x17000095")]
	public int ContainersPerGroup
	{
		[Address(RVA = "0x5F1620", Offset = "0x5F0820", Length = "0x30")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 48
		[Address(RVA = "0x5F1C70", Offset = "0x5F0E70", Length = "0x4F")]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GridLayoutGroup), Member = "set_constraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainerSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60002F7")]
		 set { } //Length: 79
	}

	[Token(Token = "0x1700009A")]
	public int Index
	{
		[Address(RVA = "0x5F1660", Offset = "0x5F0860", Length = "0xCB")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60002FE")]
		 get { } //Length: 203
		[Address(RVA = "0x5F1CC0", Offset = "0x5F0EC0", Length = "0x8D")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FF")]
		 set { } //Length: 141
	}

	[Token(Token = "0x17000096")]
	public IList Items
	{
		[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F8")]
		 get { } //Length: 8
		[Address(RVA = "0x5F1D50", Offset = "0x5F0F50", Length = "0x51")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
		[Token(Token = "0x60002F9")]
		 set { } //Length: 81
	}

	[Token(Token = "0x17000097")]
	public int ItemsCount
	{
		[Address(RVA = "0x5F1730", Offset = "0x5F0930", Length = "0x54")]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "get_ItemsCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "UnityEngine.EventSystems.IDropHandler.OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindVisible", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnScrollRectItemDataBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "LastItemContainerData", ReturnType = typeof(ItemContainerData))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60002FA")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700009B")]
	private int LocalGroupIndex
	{
		[Address(RVA = "0x5F1790", Offset = "0x5F0990", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000300")]
		private get { } //Length: 169
	}

	[Token(Token = "0x17000099")]
	private float NormalizedIndex
	{
		[Address(RVA = "0x5F1840", Offset = "0x5F0A40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002FC")]
		private get { } //Length: 9
		[Address(RVA = "0x5F1DB0", Offset = "0x5F0FB0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60002FD")]
		private set { } //Length: 20
	}

	[Token(Token = "0x1700009E")]
	private int PossibleItemsCount
	{
		[Address(RVA = "0x5F1850", Offset = "0x5F0A50", Length = "0xBE")]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainerSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000305")]
		private get { } //Length: 190
	}

	[Token(Token = "0x1700009C")]
	public int RoundedIndex
	{
		[Address(RVA = "0x5F1910", Offset = "0x5F0B10", Length = "0xDF")]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "get_VisibleItemIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindVisible", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<CoRectTransformDimensionsChange>d__52), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RectTransform))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000301")]
		 get { } //Length: 223
		[Address(RVA = "0x5F1CC0", Offset = "0x5F0EC0", Length = "0x8D")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000302")]
		 set { } //Length: 141
	}

	[Token(Token = "0x17000098")]
	private int RoundedItemsCount
	{
		[Address(RVA = "0x5F19F0", Offset = "0x5F0BF0", Length = "0xF6")]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_LocalGroupIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_RoundedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingTreeView), Member = "ScrollIntoView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002FB")]
		private get { } //Length: 246
	}

	[Token(Token = "0x170000A0")]
	private float Size
	{
		[Address(RVA = "0x5F1AF0", Offset = "0x5F0CF0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000307")]
		private get { } //Length: 74
	}

	[Token(Token = "0x17000094")]
	public bool UseGrid
	{
		[Address(RVA = "0x5F1B40", Offset = "0x5F0D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002F5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700009D")]
	public int VisibleItemsCount
	{
		[Address(RVA = "0x5F1B50", Offset = "0x5F0D50", Length = "0x6B")]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindVisible", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<CoRectTransformDimensionsChange>d__52), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_LocalGroupIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RectTransform))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6000304")]
		 get { } //Length: 107
	}

	[Address(RVA = "0x5F1360", Offset = "0x5F0560", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScrollRect), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600031D")]
	public VirtualizingScrollRect() { }

	[Address(RVA = "0x5F1430", Offset = "0x5F0630", Length = "0xA2")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60002F3")]
	public void add_ItemDataBinding(DataBindAction value) { }

	[Address(RVA = "0x5EE620", Offset = "0x5ED820", Length = "0x622")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_spacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_startCorner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Corner)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutGroup), Member = "set_childAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_cellSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childForceExpandHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "set_childControlWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateVirtualContentPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransformChangeListener), Member = "add_RectTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransformChanged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainerSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_startAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_constraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Constraint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000308")]
	protected virtual void Awake() { }

	[Address(RVA = "0x5EEC50", Offset = "0x5EDE50", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CoRectTransformDimensionsChange>d__52))]
	[Token(Token = "0x600030E")]
	private IEnumerator CoRectTransformDimensionsChange() { }

	[Address(RVA = "0x5EECC0", Offset = "0x5EDEC0", Length = "0x394")]
	[CalledBy(Type = typeof(<CoRectTransformDimensionsChange>d__52), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000312")]
	private void DataBind(int firstItemIndex) { }

	[Address(RVA = "0x5EF060", Offset = "0x5EE260", Length = "0xA7")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_RoundedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "UpdateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "ScrollIntoView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
	[Token(Token = "0x6000303")]
	private float EvalNormalizedIndex(int index) { }

	[Address(RVA = "0x5EF110", Offset = "0x5EE310", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000319")]
	public RectTransform FirstContainer() { }

	[Address(RVA = "0x5EF180", Offset = "0x5EE380", Length = "0x125")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetContainersSize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnCanDragChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600031A")]
	public void ForEachContainer(Action<RectTransform> action) { }

	[Address(RVA = "0x5F14E0", Offset = "0x5F06E0", Length = "0x132")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_ContainersPerGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000306")]
	private float get_ContainerSize() { }

	[Address(RVA = "0x5F1620", Offset = "0x5F0820", Length = "0x30")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F6")]
	public int get_ContainersPerGroup() { }

	[Address(RVA = "0x5F1660", Offset = "0x5F0860", Length = "0xCB")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002FE")]
	public int get_Index() { }

	[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002F8")]
	public IList get_Items() { }

	[Address(RVA = "0x5F1730", Offset = "0x5F0930", Length = "0x54")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_IsFocused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "set_SelectedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "get_ItemsCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "UnityEngine.EventSystems.IDropHandler.OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnScrollRectItemDataBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "LastItemContainerData", ReturnType = typeof(ItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ItemContainerData))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x60002FA")]
	public int get_ItemsCount() { }

	[Address(RVA = "0x5F1790", Offset = "0x5F0990", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000300")]
	private int get_LocalGroupIndex() { }

	[Address(RVA = "0x5F1840", Offset = "0x5F0A40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002FC")]
	private float get_NormalizedIndex() { }

	[Address(RVA = "0x5F1850", Offset = "0x5F0A50", Length = "0xBE")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainerSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000305")]
	private int get_PossibleItemsCount() { }

	[Address(RVA = "0x5F1910", Offset = "0x5F0B10", Length = "0xDF")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CoRectTransformDimensionsChange>d__52), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "get_VisibleItemIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000301")]
	public int get_RoundedIndex() { }

	[Address(RVA = "0x5F19F0", Offset = "0x5F0BF0", Length = "0xF6")]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "ScrollIntoView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_RoundedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_LocalGroupIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Token(Token = "0x60002FB")]
	private int get_RoundedItemsCount() { }

	[Address(RVA = "0x5F1AF0", Offset = "0x5F0CF0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000307")]
	private float get_Size() { }

	[Address(RVA = "0x5F1B40", Offset = "0x5F0D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002F5")]
	public bool get_UseGrid() { }

	[Address(RVA = "0x5F1B50", Offset = "0x5F0D50", Length = "0x6B")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_LocalGroupIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_Index", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_1", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "<Update>b__141_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DataBindVisible", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(<CoRectTransformDimensionsChange>d__52), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
	[Token(Token = "0x6000304")]
	public int get_VisibleItemsCount() { }

	[Address(RVA = "0x5EF2B0", Offset = "0x5EE4B0", Length = "0xE7")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000318")]
	public RectTransform GetContainer(object obj) { }

	[Address(RVA = "0x5EF3A0", Offset = "0x5EE5A0", Length = "0x402")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(ItemContainerData))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.LinkedListNode`1<System.Object>), typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000314")]
	public void InsertItem(int index, object item, bool raiseItemDataBindingEvent = true) { }

	[Address(RVA = "0x5EF7B0", Offset = "0x5EE9B0", Length = "0x9B")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "CanHandleEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "IsChildOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000313")]
	public bool IsParentOf(Transform child) { }

	[Address(RVA = "0x5EF850", Offset = "0x5EEA50", Length = "0x7A")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "UnityEngine.EventSystems.IDropHandler.OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600031B")]
	public RectTransform LastContainer() { }

	[Address(RVA = "0x5EF8D0", Offset = "0x5EEAD0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectTransformChangeListener), Member = "remove_RectTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransformChanged)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000309")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x5EF9B0", Offset = "0x5EEBB0", Length = "0x569")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_NormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_RoundedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingTreeView), Member = "ScrollIntoView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveFirst", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000311")]
	private void OnNormalizedIndexChanged(float newValue) { }

	[Address(RVA = "0x5EFF20", Offset = "0x5EF120", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600030D")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x5EFFB0", Offset = "0x5EF1B0", Length = "0x37F")]
	[CalledBy(Type = typeof(<CoRectTransformDimensionsChange>d__52), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RectTransform), Member = "SetSizeWithCurrentAnchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "set_ContainersPerGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600030A")]
	private void OnVirtualContentTransformChaged() { }

	[Address(RVA = "0x5F1BC0", Offset = "0x5F0DC0", Length = "0xA2")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60002F4")]
	public void remove_ItemDataBinding(DataBindAction value) { }

	[Address(RVA = "0x5F0330", Offset = "0x5EF530", Length = "0x348")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "DestroyItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_PossibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000315")]
	public void RemoveItems(Int32[] indices, bool raiseItemDataBindingEvent = true) { }

	[Address(RVA = "0x5F1C70", Offset = "0x5F0E70", Length = "0x4F")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GridLayoutGroup), Member = "set_constraintCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainerSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60002F7")]
	public void set_ContainersPerGroup(int value) { }

	[Address(RVA = "0x5F1CC0", Offset = "0x5F0EC0", Length = "0x8D")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60002FF")]
	public void set_Index(int value) { }

	[Address(RVA = "0x5F1D50", Offset = "0x5F0F50", Length = "0x51")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "DataBind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateContentSize", ReturnType = typeof(void))]
	[Token(Token = "0x60002F9")]
	public void set_Items(IList value) { }

	[Address(RVA = "0x5F1DB0", Offset = "0x5F0FB0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002FD")]
	private void set_NormalizedIndex(float value) { }

	[Address(RVA = "0x5F1CC0", Offset = "0x5F0EC0", Length = "0x8D")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000302")]
	public void set_RoundedIndex(int value) { }

	[Address(RVA = "0x5F0680", Offset = "0x5EF880", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateVirtualContentPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600030C")]
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	[Address(RVA = "0x5F0710", Offset = "0x5EF910", Length = "0x58C")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetNextSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetPrevSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddAfter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.LinkedListNode`1<System.Object>), typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000316")]
	public void SetNextSibling(object sibling, object nextSibling) { }

	[Address(RVA = "0x5F0CA0", Offset = "0x5EFEA0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollRect), Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "UpdateVirtualContentPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "OnNormalizedIndexChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600030B")]
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	[Address(RVA = "0x5F0D30", Offset = "0x5EFF30", Length = "0x2F3")]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingItemsControl), Member = "SetPrevSiblingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ItemContainerData), typeof(ItemContainerData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "AddFirst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Collections.Generic.LinkedListNode`1<System.Object>))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveLast", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "get_Last", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
	[Calls(Type = typeof(System.Collections.Generic.LinkedList`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerable), Member = "ElementAtOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "TSource")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_VisibleItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000317")]
	public void SetPrevSibling(object sibling, object prevSibling) { }

	[Address(RVA = "0x5F1030", Offset = "0x5F0230", Length = "0x1D9")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_ContainersPerGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "OnVirtualContentTransformChaged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "RemoveItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_RoundedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "get_ContainerSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000310")]
	private void UpdateContentSize() { }

	[Address(RVA = "0x5F1210", Offset = "0x5F0410", Length = "0x60")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNextSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingScrollRect), Member = "EvalNormalizedIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600031C")]
	private void UpdateScrollbar(int index) { }

	[Address(RVA = "0x5F1270", Offset = "0x5F0470", Length = "0xE1")]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VirtualizingScrollRect), Member = "SetContentAnchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600030F")]
	private void UpdateVirtualContentPosition() { }

}


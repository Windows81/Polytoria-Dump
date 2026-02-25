namespace UnityEngine.UIElements;

[Token(Token = "0x200006C")]
internal abstract class VerticalVirtualizationController : CollectionVirtualizationController
{
	[CompilerGenerated]
	[Token(Token = "0x200006D")]
	private sealed class <>c
	{
		[Token(Token = "0x400020E")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x400020F")]
		public static Func<T> <>9__35_0; //Field offset: 0x0
		[Token(Token = "0x4000210")]
		public static Action<T> <>9__35_1; //Field offset: 0x0
		[Token(Token = "0x4000211")]
		public static Action<T> <>9__35_2; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E8")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E9")]
		public <>c() { }

		[Address(RVA = "0x7F9CD0", Offset = "0x7F8ED0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EA")]
		internal T <.ctor>b__35_0() { }

		[Address(RVA = "0x7FBEC0", Offset = "0x7FB0C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EB")]
		internal void <.ctor>b__35_1(T i) { }

		[Address(RVA = "0x7FBEF0", Offset = "0x7FB0F0", Length = "0x2C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EC")]
		internal void <.ctor>b__35_2(T i) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000200")]
	private readonly ObjectPool<T> m_Pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000201")]
	protected BaseVerticalCollectionView m_CollectionView; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000202")]
	protected List<T> m_ActiveItems; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000203")]
	protected T m_DraggedItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000204")]
	private Nullable<Int32> m_DeferredScrollToItemIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000205")]
	private readonly Action m_PerformDeferredScrollToItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000206")]
	private IVisualElementScheduledItem m_ScheduleDeferredScrollToItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000207")]
	private IVisualElementScheduledItem m_ScrollScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000208")]
	private Action m_ScrollCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000209")]
	private int m_LastFocusedElementIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020A")]
	private List<Int32> m_LastFocusedElementTreeChildIndexes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020B")]
	protected readonly Func<T, Boolean> m_VisibleItemPredicateDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020C")]
	protected List<T> m_ScrollInsertionList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400020D")]
	private VisualElement m_EmptyRows; //Field offset: 0x0

	[Token(Token = "0x17000080")]
	public virtual IEnumerable<ReusableCollectionItem> activeItems
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000088")]
	protected override bool alwaysRebindOnRefresh
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000086")]
	public virtual int firstVisibleIndex
	{
		[Address(RVA = "0x92E870", Offset = "0x92DA70", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D0")]
		 get { } //Length: 118
		[Address(RVA = "0x92ECE0", Offset = "0x92DEE0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D1")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000082")]
	internal T firstVisibleItem
	{
		[Address(RVA = "0x92E8F0", Offset = "0x92DAF0", Length = "0x159")]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CC")]
		internal get { } //Length: 345
	}

	[Token(Token = "0x17000081")]
	internal int itemsCount
	{
		[Address(RVA = "0x92EA50", Offset = "0x92DC50", Length = "0x58")]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "GetExpectedContentHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "IsIndexOutOfBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetExpectedContentHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CA")]
		internal get { } //Length: 88
	}

	[Token(Token = "0x17000087")]
	protected float lastHeight
	{
		[Address(RVA = "0x92EAB0", Offset = "0x92DCB0", Length = "0x1F")]
		[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D2")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000083")]
	internal T lastVisibleItem
	{
		[Address(RVA = "0x92EAD0", Offset = "0x92DCD0", Length = "0x95")]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CD")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x17000085")]
	protected SerializedVirtualizationData serializedData
	{
		[Address(RVA = "0x92EB70", Offset = "0x92DD70", Length = "0x1E")]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_anchorOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_anchoredIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_anchoredIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_contentHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_contentHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_contentPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_contentPadding", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_anchorOffset", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateAnchor", ReturnType = typeof(void))]
		[CallerCount(Count = 43)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CF")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000084")]
	public virtual int visibleItemCount
	{
		[Address(RVA = "0x92EB90", Offset = "0x92DD90", Length = "0x146")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CE")]
		 get { } //Length: 326
	}

	[Address(RVA = "0x92E070", Offset = "0x92D270", Length = "0x7FA")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_disableClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D4")]
	protected VerticalVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0x92BB30", Offset = "0x92AD30", Length = "0x397")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D200")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E1")]
	internal virtual void EndDrag(int dropIndex) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C9")]
	public virtual IEnumerable<ReusableCollectionItem> get_activeItems() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D3")]
	protected override bool get_alwaysRebindOnRefresh() { }

	[Address(RVA = "0x92E870", Offset = "0x92DA70", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D0")]
	public virtual int get_firstVisibleIndex() { }

	[Address(RVA = "0x92E8F0", Offset = "0x92DAF0", Length = "0x159")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CC")]
	internal T get_firstVisibleItem() { }

	[Address(RVA = "0x92EA50", Offset = "0x92DC50", Length = "0x58")]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "IsIndexOutOfBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "GetExpectedContentHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetExpectedContentHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CA")]
	internal int get_itemsCount() { }

	[Address(RVA = "0x92EAB0", Offset = "0x92DCB0", Length = "0x1F")]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D2")]
	protected float get_lastHeight() { }

	[Address(RVA = "0x92EAD0", Offset = "0x92DCD0", Length = "0x95")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CD")]
	internal T get_lastVisibleItem() { }

	[Address(RVA = "0x92EB70", Offset = "0x92DD70", Length = "0x1E")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateAnchor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_anchorOffset", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_contentPadding", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_contentPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_contentHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_contentHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "get_anchoredIndex", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_anchorOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "set_anchoredIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 43)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CF")]
	protected SerializedVirtualizationData get_serializedData() { }

	[Address(RVA = "0x92EB90", Offset = "0x92DD90", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CE")]
	public virtual int get_visibleItemCount() { }

	[Address(RVA = "0x92BED0", Offset = "0x92B0D0", Length = "0x94")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "GetExpectedItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "GetContentHeightForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E6")]
	protected int GetDraggedIndex() { }

	[Address(RVA = "0x92BF70", Offset = "0x92B170", Length = "0x273")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "add_onDestroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(VisualElement), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E2")]
	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[Address(RVA = "0x92C1F0", Offset = "0x92B3F0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "ElementAtTreePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DE")]
	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	[Address(RVA = "0x92C2F0", Offset = "0x92B4F0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "remove_onDestroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E4")]
	private void OnDestroyItem(ReusableCollectionItem item) { }

	[Address(RVA = "0x92C3B0", Offset = "0x92B5B0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DB")]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x92C430", Offset = "0x92B630", Length = "0x319")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "FindElementInTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DC")]
	public virtual void OnFocusIn(VisualElement leafTarget) { }

	[Address(RVA = "0x92C750", Offset = "0x92B950", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DD")]
	public virtual void OnFocusOut(VisualElement willFocus) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E5")]
	protected override void OnScrollUpdate() { }

	[Address(RVA = "0x92C7D0", Offset = "0x92B9D0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DA")]
	private void PerformDeferredScrollToItem() { }

	[Address(RVA = "0x92C850", Offset = "0x92BA50", Length = "0x40F")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D0C0")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D1A0")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D5")]
	public virtual void Refresh(bool rebuild) { }

	[Address(RVA = "0x92CC60", Offset = "0x92BE60", Length = "0xD1")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ReleaseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D0C0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E3")]
	internal override void ReleaseItem(int activeItemsIndex) { }

	[Address(RVA = "0x92CD40", Offset = "0x92BF40", Length = "0xCB")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D9")]
	protected void ScheduleDeferredScrollToItem() { }

	[Address(RVA = "0x92CE10", Offset = "0x92C010", Length = "0xB4")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E7")]
	protected void ScheduleScroll() { }

	[Address(RVA = "0x92ECE0", Offset = "0x92DEE0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D1")]
	protected virtual void set_firstVisibleIndex(int value) { }

	[Address(RVA = "0x92CED0", Offset = "0x92C0D0", Length = "0x6BC")]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "StartDragItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_showAlternatingRowBackgrounds", ReturnType = typeof(AlternatingRowBackground))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VisualElement), Member = "PlaceBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "ElementAtTreePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D1A0")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D7")]
	protected void Setup(T recycledItem, int newIndex) { }

	[Address(RVA = "0x92D590", Offset = "0x92C790", Length = "0xA6")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "OnGeometryChangedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GeometryChangedEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedHeightVirtualizationController`1), Member = "ScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_layoutNode", ReturnType = typeof(LayoutNode&))]
	[Calls(Type = typeof(LayoutNode), Member = "get_IsDirty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D8")]
	protected bool ShouldDeferScrollToItem(int index) { }

	[Address(RVA = "0x92D640", Offset = "0x92C840", Length = "0x124")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "StartDragItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003E0")]
	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	[Address(RVA = "0x92D770", Offset = "0x92C970", Length = "0x174")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003D6")]
	public virtual void UnbindAll() { }

	[Address(RVA = "0x92D8F0", Offset = "0x92CAF0", Length = "0x6CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_classList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[Calls(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004D200")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_showAlternatingRowBackgrounds", ReturnType = typeof(AlternatingRowBackground))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60003DF")]
	public virtual void UpdateBackground() { }

	[Address(RVA = "0x92DFC0", Offset = "0x92D1C0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003CB")]
	protected override bool VisibleItemPredicate(T i) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x2000061")]
internal class DynamicHeightVirtualizationController : VerticalVirtualizationController<T>
{
	[CompilerGenerated]
	[Token(Token = "0x2000065")]
	private struct <>c__DisplayClass66_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E3")]
		public int draggedIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E4")]
		public DynamicHeightVirtualizationController<T> <>4__this; //Field offset: 0x0

	}

	[IsReadOnly]
	[Token(Token = "0x2000062")]
	private struct ContentHeightCacheInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D8")]
		public readonly float sum; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D9")]
		public readonly int count; //Field offset: 0x0

		[Address(RVA = "0x9DF730", Offset = "0x9DE930", Length = "0x9")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000380")]
		public ContentHeightCacheInfo(float sum, int count) { }

	}

	[Token(Token = "0x2000064")]
	private enum ScrollDirection
	{
		Idle = 0,
		Up = 1,
		Down = 2,
	}

	[Token(Token = "0x2000063")]
	private enum VirtualizationChange
	{
		None = 0,
		Resize = 1,
		Scroll = 2,
		ForcedScroll = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C3")]
	private int m_HighestCachedIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D5")]
	private Predicate<Int32> m_IndexOutOfBoundsPredicate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D4")]
	private IVisualElementScheduledItem m_ScrollResetScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D3")]
	private IVisualElementScheduledItem m_ScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D2")]
	private Action<ReusableCollectionItem> m_GeometryChangedCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D1")]
	private Action m_ScrollResetCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D0")]
	private Action m_FillCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CF")]
	private float m_MinimumItemHeight; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CE")]
	private float m_AccumulatedHeight; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D6")]
	private bool m_FillExecuted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CD")]
	private Vector2 m_DelayedScrollOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CB")]
	private VirtualizationChange<T> m_LastChange; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CA")]
	private bool m_StickToBottom; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C9")]
	private int m_ForcedLastVisibleItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C8")]
	private int m_ForcedFirstVisibleItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C7")]
	private Nullable<Int32> m_ScrolledToItemIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C6")]
	private readonly HashSet<Int32> m_WaitingCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C5")]
	private readonly Dictionary<Int32, ContentHeightCacheInfo<T>> m_ContentHeightCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001C4")]
	private readonly Dictionary<Int32, Single> m_ItemHeightCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CC")]
	private ScrollDirection<T> m_ScrollDirection; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D7")]
	private long m_TimeSinceFillScheduledMs; //Field offset: 0x0

	[Token(Token = "0x17000073")]
	protected virtual bool alwaysRebindOnRefresh
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600035B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000070")]
	private int anchoredIndex
	{
		[Address(RVA = "0xADFB80", Offset = "0xADED80", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000356")]
		private get { } //Length: 47
		[Address(RVA = "0xADFD40", Offset = "0xADEF40", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000357")]
		private set { } //Length: 79
	}

	[Token(Token = "0x17000071")]
	private float anchorOffset
	{
		[Address(RVA = "0xADFB40", Offset = "0xADED40", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000358")]
		private get { } //Length: 49
		[Address(RVA = "0xADFCE0", Offset = "0xADEEE0", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000359")]
		private set { } //Length: 83
	}

	[Token(Token = "0x1700006F")]
	private float contentHeight
	{
		[Address(RVA = "0xADFBB0", Offset = "0xADEDB0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000354")]
		private get { } //Length: 49
		[Address(RVA = "0xADFD90", Offset = "0xADEF90", Length = "0x189")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000355")]
		private set { } //Length: 393
	}

	[Token(Token = "0x1700006E")]
	private float contentPadding
	{
		[Address(RVA = "0xADFBF0", Offset = "0xADEDF0", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000352")]
		private get { } //Length: 49
		[Address(RVA = "0xADFF20", Offset = "0xADF120", Length = "0x189")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
		[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
		[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000353")]
		private set { } //Length: 393
	}

	[Token(Token = "0x1700006D")]
	private float defaultExpectedHeight
	{
		[Address(RVA = "0xADFC30", Offset = "0xADEE30", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000351")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000072")]
	private float viewportMaxOffset
	{
		[Address(RVA = "0xADFC80", Offset = "0xADEE80", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600035A")]
		private get { } //Length: 86
	}

	[Address(RVA = "0xADF790", Offset = "0xADE990", Length = "0x3A9")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UIElements.DynamicHeightVirtualizationController`1+ContentHeightCacheInfo<System.Object>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035C")]
	public DynamicHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0xADEA60", Offset = "0xADDC60", Length = "0x131")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "GetContentHeightForIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600037F")]
	private float <GetContentHeightForIndex>g__GetContentHeightFromCachedHeight|66_0(int index, in ContentHeightCacheInfo<T> heightInfo, ref <>c__DisplayClass66_0<T> unnamed_param_2) { }

	[Address(RVA = "0xADA260", Offset = "0xAD9460", Length = "0x9A1")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnRecycledItemGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "NeedsFill", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800788A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078250")]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078720")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078650")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(AlignmentUtils), Member = "RoundToPanelPixelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078A90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800780B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078580")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleDeferredScrollToItem", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000368")]
	private void ApplyScrollViewUpdate(bool dimensionsOnly = false) { }

	[Address(RVA = "0xADAC10", Offset = "0xAD9E10", Length = "0x3C7")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UnregisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800783D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180ADA220")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000375")]
	private void CleanItemHeightCache() { }

	[Address(RVA = "0xADAFE0", Offset = "0xADA1E0", Length = "0x7F2")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800788A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078450")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078720")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078580")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078A90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800780B0")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_firstVisibleItem", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000364")]
	private void CycleItems(int firstIndex) { }

	[Address(RVA = "0xADB7E0", Offset = "0xADA9E0", Length = "0x2D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RegisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078720")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "add_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600037B")]
	internal virtual void EndDrag(int dropIndex) { }

	[Address(RVA = "0xADBAC0", Offset = "0xADACC0", Length = "0x7E0")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnScrollUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078450")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078A90")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078720")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800788A0")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078510")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000366")]
	private void Fill() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600035B")]
	protected virtual bool get_alwaysRebindOnRefresh() { }

	[Address(RVA = "0xADFB80", Offset = "0xADED80", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000356")]
	private int get_anchoredIndex() { }

	[Address(RVA = "0xADFB40", Offset = "0xADED40", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000358")]
	private float get_anchorOffset() { }

	[Address(RVA = "0xADFBB0", Offset = "0xADEDB0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000354")]
	private float get_contentHeight() { }

	[Address(RVA = "0xADFBF0", Offset = "0xADEDF0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000352")]
	private float get_contentPadding() { }

	[Address(RVA = "0xADFC30", Offset = "0xADEE30", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000351")]
	private float get_defaultExpectedHeight() { }

	[Address(RVA = "0xADFC80", Offset = "0xADEE80", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600035A")]
	private float get_viewportMaxOffset() { }

	[Address(RVA = "0xADC2B0", Offset = "0xADB4B0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000372")]
	private ContentHeightCacheInfo<T> GetCachedContentHeight(int index) { }

	[Address(RVA = "0xADC340", Offset = "0xADB540", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetDraggedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "<GetContentHeightForIndex>g__GetContentHeightFromCachedHeight|66_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "ContentHeightCacheInfo<T>&", "<>c__DisplayClass66_0<T>&"}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078850")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000371")]
	private float GetContentHeightForIndex(int lastIndex) { }

	[Address(RVA = "0xADC4E0", Offset = "0xADB6E0", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000370")]
	public virtual float GetExpectedContentHeight() { }

	[Address(RVA = "0xADC5C0", Offset = "0xADB7C0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetDraggedIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600036E")]
	public virtual float GetExpectedItemHeight(int index) { }

	[Address(RVA = "0xADC6C0", Offset = "0xADB8C0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600036F")]
	private int GetFirstVisibleItem(float offset) { }

	[Address(RVA = "0xADC740", Offset = "0xADB940", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036D")]
	public virtual int GetIndexFromPosition(Vector2 position) { }

	[Address(RVA = "0xADC7C0", Offset = "0xADB9C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "add_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000378")]
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[Address(RVA = "0xADC820", Offset = "0xADBA20", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600037C")]
	private void HideItem(int activeItemsIndex) { }

	[Address(RVA = "0xADC9A0", Offset = "0xADBBA0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600037E")]
	private bool IsIndexOutOfBounds(int i) { }

	[Address(RVA = "0xADCA20", Offset = "0xADBC20", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600037D")]
	private void MarkWaitingForLayout(T item) { }

	[Address(RVA = "0xADCAE0", Offset = "0xADBCE0", Length = "0x1EC")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_lastVisibleItem", ReturnType = "T")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800788A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000365")]
	private bool NeedsFill() { }

	[Address(RVA = "0xADCCD0", Offset = "0xADBED0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000362")]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt) { }

	[Address(RVA = "0xADCDC0", Offset = "0xADBFC0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleDeferredScrollToItem", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600035D")]
	private void OnGeometryChangedEvent(GeometryChangedEvent _) { }

	[Address(RVA = "0xADCE60", Offset = "0xADC060", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ApplyScrollViewUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000376")]
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	[Address(RVA = "0xADD420", Offset = "0xADC620", Length = "0x21B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleScroll", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000361")]
	public virtual void OnScroll(Vector2 scrollOffset) { }

	[Address(RVA = "0xADCF60", Offset = "0xADC160", Length = "0x4B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scroller), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800780B0")]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollOffsetWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078900")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CycleItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078650")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078A90")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000363")]
	protected virtual void OnScrollUpdate() { }

	[Address(RVA = "0xADD640", Offset = "0xADC840", Length = "0x2DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Refresh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078580")]
	[Calls(Type = typeof(Scroller), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "RemoveWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078900")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600035E")]
	public virtual void Refresh(bool rebuild) { }

	[Address(RVA = "0xADD920", Offset = "0xADCB20", Length = "0x3E3")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UpdateRegisteredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Single>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UIElements.DynamicHeightVirtualizationController`1+ContentHeightCacheInfo<System.Object>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.DynamicHeightVirtualizationController`1<Object>+ContentHeightCacheInfo<Object>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, System.Single>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000373")]
	private void RegisterItemHeight(int index, float height) { }

	[Address(RVA = "0xADDD10", Offset = "0xADCF10", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "remove_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "UnregisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ReleaseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000379")]
	internal virtual void ReleaseItem(int activeItemsIndex) { }

	[Address(RVA = "0xADDE00", Offset = "0xADD000", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078720")]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600036C")]
	private void ResetScroll() { }

	[Address(RVA = "0xADDE70", Offset = "0xADD070", Length = "0x6B1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ScrollView), Member = "UpdateContentViewTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "Fill", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078450")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Scroller), Member = "get_value", ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078900")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078580")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078650")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180078720")]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000360")]
	public virtual void Resize(Vector2 size) { }

	[Address(RVA = "0xADE530", Offset = "0xADD730", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036A")]
	private void ScheduleFill() { }

	[Address(RVA = "0xADE600", Offset = "0xADD800", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036B")]
	private void ScheduleScrollDirectionReset() { }

	[Address(RVA = "0xADE6D0", Offset = "0xADD8D0", Length = "0x2E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800780B0")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600035F")]
	public virtual void ScrollToItem(int index) { }

	[Address(RVA = "0xADFD40", Offset = "0xADEF40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000357")]
	private void set_anchoredIndex(int value) { }

	[Address(RVA = "0xADFCE0", Offset = "0xADEEE0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000359")]
	private void set_anchorOffset(float value) { }

	[Address(RVA = "0xADFD90", Offset = "0xADEF90", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000355")]
	private void set_contentHeight(float value) { }

	[Address(RVA = "0xADFF20", Offset = "0xADF120", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000353")]
	private void set_contentPadding(float value) { }

	[Address(RVA = "0xADE9C0", Offset = "0xADDBC0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "StartDragItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReusableCollectionItem), Member = "remove_onGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.ReusableCollectionItem>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600037A")]
	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	[Address(RVA = "0xADEBA0", Offset = "0xADDDA0", Length = "0x2C4")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "CleanItemHeightCache", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "ReleaseItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, System.Single>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.UIElements.DynamicHeightVirtualizationController`1+ContentHeightCacheInfo<System.Object>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.DynamicHeightVirtualizationController`1<Object>+ContentHeightCacheInfo<Object>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000374")]
	private void UnregisterItemHeight(int index) { }

	[Address(RVA = "0xADEE70", Offset = "0xADE070", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(VisualElement), Member = "SaveViewData", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000369")]
	private void UpdateAnchor() { }

	[Address(RVA = "0xADEFA0", Offset = "0xADE1A0", Length = "0x6B9")]
	[CalledBy(Type = typeof(DynamicHeightVirtualizationController`1), Member = "OnRecycledItemGeometryChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(Scroller), Member = "get_highValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_serializedData", ReturnType = typeof(SerializedVirtualizationData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(DynamicHeightVirtualizationController`1), Member = "RegisterItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollOffsetWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800780B0")]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000377")]
	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	[Address(RVA = "0xADF660", Offset = "0xADE860", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800780B0")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "SetScrollOffsetWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000367")]
	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

}


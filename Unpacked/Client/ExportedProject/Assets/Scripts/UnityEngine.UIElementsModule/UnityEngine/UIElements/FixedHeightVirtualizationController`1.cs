namespace UnityEngine.UIElements;

[Token(Token = "0x2000066")]
internal class FixedHeightVirtualizationController : VerticalVirtualizationController<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E5")]
	private Nullable<Int32> m_ScrolledToItemIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E6")]
	private bool m_ForcedScroll; //Field offset: 0x0

	[Token(Token = "0x17000074")]
	private float resolvedItemHeight
	{
		[Address(RVA = "0xC3FCB0", Offset = "0xC3EEB0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000381")]
		private get { } //Length: 38
	}

	[Address(RVA = "0xC40E20", Offset = "0xC40020", Length = "0xBE")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "CreateVirtualizationController", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackEventHandler), Member = "RegisterCallback", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TEventType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventCallback`1<TEventType>", typeof(TrickleDown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000383")]
	public FixedHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0xC3FA60", Offset = "0xC3EC60", Length = "0x1EB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Scroller), Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038D")]
	internal virtual void EndDrag(int dropIndex) { }

	[Address(RVA = "0xC3FCB0", Offset = "0xC3EEB0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000381")]
	private float get_resolvedItemHeight() { }

	[Address(RVA = "0xC3FC50", Offset = "0xC3EE50", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000387")]
	public virtual float GetExpectedContentHeight() { }

	[Address(RVA = "0xC3FCB0", Offset = "0xC3EEB0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000386")]
	public virtual float GetExpectedItemHeight(int index) { }

	[Address(RVA = "0xC3FCE0", Offset = "0xC3EEE0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000385")]
	public virtual int GetIndexFromPosition(Vector2 position) { }

	[Address(RVA = "0xC3FD20", Offset = "0xC3EF20", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "GetOrMakeItemAtIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038C")]
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[Address(RVA = "0xC3FEB0", Offset = "0xC3F0B0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleDeferredScrollToItem", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000384")]
	private void OnGeometryChangedEvent(GeometryChangedEvent evt) { }

	[Address(RVA = "0xC40700", Offset = "0xC3F900", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleScroll", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600038A")]
	public virtual void OnScroll(Vector2 scrollOffset) { }

	[Address(RVA = "0xC3FF50", Offset = "0xC3F150", Length = "0x7AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "SendToBack", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600038B")]
	protected virtual void OnScrollUpdate() { }

	[Address(RVA = "0xC40740", Offset = "0xC3F940", Length = "0x41A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UnityEngine.UIElements.BaseSlider`1<System.Single>), Member = "SetHighValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000389")]
	public virtual void Resize(Vector2 size) { }

	[Address(RVA = "0xC40B60", Offset = "0xC3FD60", Length = "0x2BF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ShouldDeferScrollToItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "ScheduleDeferredScrollToItem", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_lastHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(ScrollView), Member = "get_scrollOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(VerticalVirtualizationController`1), Member = "get_itemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ScrollView), Member = "set_scrollOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000388")]
	public virtual void ScrollToItem(int index) { }

	[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000382")]
	protected virtual bool VisibleItemPredicate(T i) { }

}


namespace UnityEngine.UIElements;

[Token(Token = "0x2000196")]
internal class ListViewDraggerAnimated : ListViewDragger
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400078F")]
	private int m_DragStartIndex; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000790")]
	private int m_CurrentIndex; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000791")]
	private float m_SelectionHeight; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000792")]
	private float m_LocalOffsetOnStart; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000793")]
	private Vector3 m_CurrentPointerPosition; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000794")]
	private ReusableCollectionItem m_Item; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000795")]
	private ReusableCollectionItem m_OffsetItem; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000796")]
	private bool <isDragging>k__BackingField; //Field offset: 0xB0

	[Token(Token = "0x17000221")]
	public ReusableCollectionItem draggedItem
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BED")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000220")]
	public private bool isDragging
	{
		[Address(RVA = "0x532440", Offset = "0x531640", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEB")]
		 get { } //Length: 8
		[Address(RVA = "0x530330", Offset = "0x52F530", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEC")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000222")]
	protected virtual bool supportsDragEvents
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BEE")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1C564C0", Offset = "0x1C556C0", Length = "0x8")]
	[CalledBy(Type = typeof(BaseListView), Member = "CreateDragger", ReturnType = typeof(ListViewDragger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ListViewDragger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000BEF")]
	public ListViewDraggerAnimated(BaseVerticalCollectionView listView) { }

	[Address(RVA = "0x1C54A40", Offset = "0x1C53C40", Length = "0x3C6")]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StyleLength), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength), typeof(StyleLength)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(StyleValues), Member = "set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(StyleValues), Member = "set_paddingTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleValues), Member = "get_paddingTop", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ValueAnimation`1), Member = "KeepAlive", ReturnType = "UnityEngine.UIElements.Experimental.ValueAnimation`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BF2")]
	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BF4")]
	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BED")]
	public ReusableCollectionItem get_draggedItem() { }

	[Address(RVA = "0x532440", Offset = "0x531640", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BEB")]
	public bool get_isDragging() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BEE")]
	protected virtual bool get_supportsDragEvents() { }

	[Address(RVA = "0x1C54E10", Offset = "0x1C54010", Length = "0x468")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(DragEventsProcessor), Member = "get_dragAndDrop", ReturnType = typeof(IDragAndDrop))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ResolveItemHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(ListViewDragger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Recycle", ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueAnimation`1), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(VisualElement), Member = "ClearManualLayout", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000BF3")]
	protected private virtual void OnDrop(Vector3 pointerPosition) { }

	[Address(RVA = "0x530330", Offset = "0x52F530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BEC")]
	private void set_isDragging(bool value) { }

	[Address(RVA = "0x1C55280", Offset = "0x1C54480", Length = "0x9DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ListViewDragger), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[Calls(Type = typeof(StartDragArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DragVisualMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDraggerExtension), Member = "GetRecycledItemFromIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVerticalCollectionView), typeof(int)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetScrollView", ReturnType = typeof(ScrollView))]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "SetSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_selectionType", ReturnType = typeof(SelectionType))]
	[Calls(Type = typeof(ListViewDragger), Member = "GetRecycledItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(ReusableCollectionItem))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "ClearSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x6000BF0")]
	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition) { }

	[Address(RVA = "0x1C55C60", Offset = "0x1C54E60", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BF5")]
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[Address(RVA = "0x1C55CA0", Offset = "0x1C54EA0", Length = "0x817")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(VisualElement), Member = "BringToFront", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_layout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ListViewDraggerAnimated), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_itemsSource", ReturnType = typeof(IList))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleEnum`1<T>", "UnityEngine.UIElements.StyleEnum`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetView", ReturnType = typeof(BaseVerticalCollectionView))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(ListViewDragger), Member = "get_targetScrollView", ReturnType = typeof(ScrollView))]
	[Calls(Type = typeof(ListViewDragger), Member = "HandleDragAndScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000BF1")]
	protected private virtual void UpdateDrag(Vector3 pointerPosition) { }

}


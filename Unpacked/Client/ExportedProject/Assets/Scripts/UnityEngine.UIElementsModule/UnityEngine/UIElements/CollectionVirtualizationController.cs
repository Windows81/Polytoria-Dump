namespace UnityEngine.UIElements;

[Token(Token = "0x2000060")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal abstract class CollectionVirtualizationController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C2")]
	protected readonly ScrollView m_ScrollView; //Field offset: 0x10

	[Token(Token = "0x1700006C")]
	public abstract IEnumerable<ReusableCollectionItem> activeItems
	{
		[Token(Token = "0x600034D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700006A")]
	public abstract int firstVisibleIndex
	{
		[Token(Token = "0x600033F")]
		 get { } //Length: 0
		[Token(Token = "0x6000340")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700006B")]
	public abstract int visibleItemCount
	{
		[Token(Token = "0x6000341")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000342")]
	protected CollectionVirtualizationController(ScrollView scrollView) { }

	[Token(Token = "0x600034F")]
	internal abstract void EndDrag(int dropIndex) { }

	[Token(Token = "0x600034D")]
	public abstract IEnumerable<ReusableCollectionItem> get_activeItems() { }

	[Token(Token = "0x600033F")]
	public abstract int get_firstVisibleIndex() { }

	[Token(Token = "0x6000341")]
	public abstract int get_visibleItemCount() { }

	[Token(Token = "0x6000349")]
	public abstract float GetExpectedContentHeight() { }

	[Token(Token = "0x6000348")]
	public abstract float GetExpectedItemHeight(int index) { }

	[Token(Token = "0x6000347")]
	public abstract int GetIndexFromPosition(Vector2 position) { }

	[Token(Token = "0x600034A")]
	public abstract void OnFocusIn(VisualElement leafTarget) { }

	[Token(Token = "0x600034B")]
	public abstract void OnFocusOut(VisualElement willFocus) { }

	[Token(Token = "0x6000346")]
	public abstract void OnScroll(Vector2 offset) { }

	[Token(Token = "0x6000343")]
	public abstract void Refresh(bool rebuild) { }

	[Token(Token = "0x6000345")]
	public abstract void Resize(Vector2 size) { }

	[Token(Token = "0x6000344")]
	public abstract void ScrollToItem(int id) { }

	[Token(Token = "0x6000340")]
	protected abstract void set_firstVisibleIndex(int value) { }

	[Token(Token = "0x600034E")]
	internal abstract void StartDragItem(ReusableCollectionItem item) { }

	[Token(Token = "0x6000350")]
	public abstract void UnbindAll() { }

	[Token(Token = "0x600034C")]
	public abstract void UpdateBackground() { }

}


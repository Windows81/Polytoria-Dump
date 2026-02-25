namespace UnityEngine.UIElements;

[Token(Token = "0x200018C")]
internal interface IDragAndDropController
{

	[Token(Token = "0x6000BB5")]
	public bool CanStartDrag(IEnumerable<Int32> itemIds) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB9")]
	public void DragCleanup() { }

	[Address(RVA = "0xC87B50", Offset = "0xC86D50", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBB")]
	public IEnumerable<Int32> GetSortedSelectedIds() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBA")]
	public void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	[Token(Token = "0x6000BB7")]
	public DragVisualMode HandleDragAndDrop(TArgs args) { }

	[Token(Token = "0x6000BB8")]
	public void OnDrop(TArgs args) { }

	[Token(Token = "0x6000BB6")]
	public StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}


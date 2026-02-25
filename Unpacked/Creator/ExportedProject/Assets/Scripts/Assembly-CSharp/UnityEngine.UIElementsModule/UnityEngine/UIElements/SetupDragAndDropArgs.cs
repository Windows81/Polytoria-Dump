namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200018F")]
public struct SetupDragAndDropArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000778")]
	public readonly VisualElement draggedElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000779")]
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400077A")]
	public readonly StartDragArgs startDragArgs; //Field offset: 0x10

	[Address(RVA = "0x1C37F10", Offset = "0x1C37110", Length = "0x63")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseSetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(StartDragArgs)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BBD")]
	internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<Int32> selectedIds, StartDragArgs startDragArgs) { }

}


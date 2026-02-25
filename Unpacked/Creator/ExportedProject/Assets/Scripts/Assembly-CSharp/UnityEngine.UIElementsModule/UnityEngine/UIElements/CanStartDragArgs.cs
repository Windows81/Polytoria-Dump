namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200018E")]
public struct CanStartDragArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000775")]
	public readonly VisualElement draggedElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000776")]
	public readonly int id; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000777")]
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x10

	[Address(RVA = "0x1C30EF0", Offset = "0x1C300F0", Length = "0x42")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseCanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BBC")]
	internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<Int32> selectedIds) { }

}


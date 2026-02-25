namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000190")]
public struct HandleDragAndDropArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400077B")]
	private readonly DragAndDropArgs m_DragAndDropArgs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400077C")]
	private readonly Vector2 <position>k__BackingField; //Field offset: 0x20

	[Address(RVA = "0x1C33A60", Offset = "0x1C32C60", Length = "0x1B")]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseHandleDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BBE")]
	internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs) { }

}


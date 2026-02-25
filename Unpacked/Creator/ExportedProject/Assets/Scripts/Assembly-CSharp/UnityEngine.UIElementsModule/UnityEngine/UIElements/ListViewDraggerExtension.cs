namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000195")]
internal static class ListViewDraggerExtension
{

	[Address(RVA = "0x1C564D0", Offset = "0x1C556D0", Length = "0x18C")]
	[CalledBy(Type = typeof(BaseReorderableDragAndDropController), Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(bool)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000BE9")]
	public static ReusableCollectionItem GetRecycledItemFromId(BaseVerticalCollectionView listView, int id) { }

	[Address(RVA = "0x1C56660", Offset = "0x1C55860", Length = "0x18C")]
	[CalledBy(Type = typeof(VerticalVirtualizationController`1), Member = "EndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "ApplyDragAndDropUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDraggerAnimated), Member = "StartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseVerticalCollectionView), Member = "get_activeItems", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.ReusableCollectionItem>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000BEA")]
	public static ReusableCollectionItem GetRecycledItemFromIndex(BaseVerticalCollectionView listView, int index) { }

}


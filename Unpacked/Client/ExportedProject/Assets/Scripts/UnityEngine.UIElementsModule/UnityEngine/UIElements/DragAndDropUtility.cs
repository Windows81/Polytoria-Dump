namespace UnityEngine.UIElements;

[Token(Token = "0x2000182")]
internal static class DragAndDropUtility
{
	[Token(Token = "0x4000755")]
	private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; //Field offset: 0x0
	[Token(Token = "0x4000756")]
	private static IDragAndDrop s_DragAndDropEditor; //Field offset: 0x8
	[Token(Token = "0x4000757")]
	private static IDragAndDrop s_DragAndDropPlayMode; //Field offset: 0x10

	[Address(RVA = "0x1C32280", Offset = "0x1C31480", Length = "0x150")]
	[CalledBy(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "get_dragAndDrop", ReturnType = typeof(IDragAndDrop))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerUpEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerUpEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "CancelDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DragEventsProcessor), Member = "OnPointerMoveEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerMoveEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "OnDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ListViewDragger), Member = "IsDraggingDisabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DefaultDragAndDropClient), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B79")]
	internal static IDragAndDrop GetDragAndDrop(IPanel panel) { }

}


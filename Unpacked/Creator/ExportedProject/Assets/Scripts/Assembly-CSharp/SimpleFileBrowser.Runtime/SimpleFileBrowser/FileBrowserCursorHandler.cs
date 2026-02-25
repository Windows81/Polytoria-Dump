namespace SimpleFileBrowser;

[Token(Token = "0x2000014")]
public class FileBrowserCursorHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IBeginDragHandler, IEndDragHandler
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000A7")]
	private Texture2D resizeCursor; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A8")]
	private bool isHovering; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40000A9")]
	private bool isResizing; //Field offset: 0x29

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BA")]
	public FileBrowserCursorHandler() { }

	[Address(RVA = "0x153FB80", Offset = "0x153ED80", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000B8")]
	private void ShowDefaultCursor() { }

	[Address(RVA = "0x153FBD0", Offset = "0x153EDD0", Length = "0x95")]
	[CalledBy(Type = typeof(FileBrowserCursorHandler), Member = "UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileBrowserCursorHandler), Member = "UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000B9")]
	private void ShowResizeCursor() { }

	[Address(RVA = "0x153FC70", Offset = "0x153EE70", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowserCursorHandler), Member = "ShowResizeCursor", ReturnType = typeof(void))]
	[Token(Token = "0x60000B6")]
	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x153FC80", Offset = "0x153EE80", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000B7")]
	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x153FCE0", Offset = "0x153EEE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileBrowserCursorHandler), Member = "ShowResizeCursor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B4")]
	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x153FD10", Offset = "0x153EF10", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000B5")]
	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}


namespace Battlehub.UIControls;

[Token(Token = "0x200002D")]
public class LayoutElementResizer : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IDropHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A4")]
	public LayoutElement Target; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A5")]
	public RectTransform Parent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000A6")]
	public LayoutElement SecondaryTarget; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000A7")]
	public Texture2D CursorTexture; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000A8")]
	public float XSign; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000A9")]
	public float YSign; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AA")]
	public float MaxSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40000AB")]
	public bool HasMaxSize; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x40000AC")]
	private bool m_pointerInside; //Field offset: 0x4D
	[FieldOffset(Offset = "0x4E")]
	[Token(Token = "0x40000AD")]
	private bool m_pointerDown; //Field offset: 0x4E
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000AE")]
	private float m_midX; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000AF")]
	private float m_midY; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000B0")]
	private CursorHelper m_cursorHelper; //Field offset: 0x58

	[Address(RVA = "0x5D04B0", Offset = "0x5CF6B0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000190")]
	public LayoutElementResizer() { }

	[Address(RVA = "0x5CF7B0", Offset = "0x5CE9B0", Length = "0x44D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000188")]
	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	[Address(RVA = "0x5CFC00", Offset = "0x5CEE00", Length = "0x66D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000189")]
	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018A")]
	private override void UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData eventData) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018B")]
	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	[Address(RVA = "0x5D0270", Offset = "0x5CF470", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x600018E")]
	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x5D0360", Offset = "0x5CF560", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018C")]
	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x5D03B0", Offset = "0x5CF5B0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018D")]
	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x5D0430", Offset = "0x5CF630", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018F")]
	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}


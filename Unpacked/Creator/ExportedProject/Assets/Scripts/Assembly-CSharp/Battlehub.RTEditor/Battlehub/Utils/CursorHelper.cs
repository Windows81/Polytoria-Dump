namespace Battlehub.Utils;

[Token(Token = "0x200000C")]
public class CursorHelper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001A")]
	private object m_locker; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001B")]
	private Texture2D m_texture; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001C")]
	private readonly Dictionary<KnownCursor, Texture2D> m_knownCursorToTexture; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001D")]
	private Texture2D m_defaultCursorTexture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001E")]
	private Vector2 m_defaultCursorHotspot; //Field offset: 0x30

	[Token(Token = "0x17000004")]
	public Vector2 DefaultCursorHotspot
	{
		[Address(RVA = "0x58DEF0", Offset = "0x58D0F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000003")]
	public Texture2D DefaultCursorTexture
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5C45C0", Offset = "0x5C37C0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	public CursorHelper() { }

	[Address(RVA = "0x58DEF0", Offset = "0x58D0F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public Vector2 get_DefaultCursorHotspot() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public Texture2D get_DefaultCursorTexture() { }

	[Address(RVA = "0x5C4040", Offset = "0x5C3240", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600002C")]
	public void Map(KnownCursor cursorType, Texture2D texture) { }

	[Address(RVA = "0x5C4110", Offset = "0x5C3310", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000030")]
	public void Reset() { }

	[Address(RVA = "0x5C40B0", Offset = "0x5C32B0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000035")]
	public void ResetCursor(object locker) { }

	[Address(RVA = "0x5C4250", Offset = "0x5C3450", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000031")]
	public void SetCursor(object locker, KnownCursor cursorType) { }

	[Address(RVA = "0x5C4160", Offset = "0x5C3360", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000032")]
	public void SetCursor(object locker, KnownCursor cursorType, Vector2 hotspot, CursorMode mode) { }

	[Address(RVA = "0x5C4220", Offset = "0x5C3420", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000033")]
	public void SetCursor(object locker, Texture2D texture) { }

	[Address(RVA = "0x5C4310", Offset = "0x5C3510", Length = "0x224")]
	[CalledBy(Type = typeof(LayoutElementResizer), Member = "UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CursorHelper), Member = "SetDefaultCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(KnownCursor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(KnownCursor), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CursorHelper), Member = "ResetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElementResizer), Member = "UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElementResizer), Member = "UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000034")]
	public void SetCursor(object locker, Texture2D texture, Vector2 hotspot, CursorMode mode) { }

	[Address(RVA = "0x5C4540", Offset = "0x5C3740", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CursorHelper), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600002F")]
	public void SetDefaultCursor(Texture2D texture, Vector2 hotspot) { }

}


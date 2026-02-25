namespace UnityEngine;

[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
[Token(Token = "0x20000ED")]
public class Cursor
{

	[Token(Token = "0x17000127")]
	public static CursorLockMode lockState
	{
		[Address(RVA = "0x1945160", Offset = "0x1944360", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCameraRotation", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_CursorLocked", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006B6")]
		 get { } //Length: 42
		[Address(RVA = "0x19451C0", Offset = "0x19443C0", Length = "0x31")]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCursorLocking", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFree", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFreeLookToggle", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StartLooking", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StopLooking", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "set_CursorLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006B7")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000126")]
	public static bool visible
	{
		[Address(RVA = "0x1945190", Offset = "0x1944390", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_CursorVisible", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006B4")]
		 get { } //Length: 42
		[Address(RVA = "0x1945200", Offset = "0x1944400", Length = "0x33")]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCursorLocking", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFree", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFreeLookToggle", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StartLooking", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StopLooking", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "set_CursorVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006B5")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x1945160", Offset = "0x1944360", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCameraRotation", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_CursorLocked", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetMousePointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.EventSystems.PointerInputModule+MouseState")]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "ProcessDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B6")]
	public static CursorLockMode get_lockState() { }

	[Address(RVA = "0x1945190", Offset = "0x1944390", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_CursorVisible", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B4")]
	public static bool get_visible() { }

	[Address(RVA = "0x19451C0", Offset = "0x19443C0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCursorLocking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFree", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFreeLookToggle", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StartLooking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StopLooking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "set_CursorLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B7")]
	public static void set_lockState(CursorLockMode value) { }

	[Address(RVA = "0x1945200", Offset = "0x1944400", Length = "0x33")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCursorLocking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFree", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFreeLookToggle", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StartLooking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "StopLooking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "set_CursorVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetPaused", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B5")]
	public static void set_visible(bool value) { }

	[Address(RVA = "0x19450D0", Offset = "0x19442D0", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.UIElements.CursorManager", Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Cursor"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.CursorManager", Member = "ResetCursor", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.Utils.CursorHelper", Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "UnityEngine.EventSystems.IEndDragHandler.OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "ShowDefaultCursor", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserCursorHandler", Member = "ShowResizeCursor", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B3")]
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	[Address(RVA = "0x1945070", Offset = "0x1944270", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B8")]
	private static void SetCursor_Injected(IntPtr texture, in Vector2 hotspot, CursorMode cursorMode) { }

}


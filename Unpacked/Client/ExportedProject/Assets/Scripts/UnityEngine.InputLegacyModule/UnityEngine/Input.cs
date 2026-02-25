namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
[Token(Token = "0x200000A")]
public class Input
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400002E")]
	private static bool <simulateTouchEnabled>k__BackingField; //Field offset: 0x0

	[NativeThrows]
	[Token(Token = "0x1700000F")]
	public static bool anyKey
	{
		[Address(RVA = "0x19DA1C0", Offset = "0x19D93C0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_anyKey", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_AnyKey", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000027")]
		 get { } //Length: 42
	}

	[NativeThrows]
	[Token(Token = "0x17000010")]
	public static bool anyKeyDown
	{
		[Address(RVA = "0x19DA190", Offset = "0x19D9390", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_AnyKeyDown", ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_IsAnyKeyDown", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000015")]
	public static Vector2 compositionCursorPos
	{
		[Address(RVA = "0x19DA230", Offset = "0x19D9430", Length = "0x3B")]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002E")]
		 get { } //Length: 59
		[Address(RVA = "0x19DA770", Offset = "0x19D9970", Length = "0x34")]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002F")]
		 set { } //Length: 52
	}

	[Token(Token = "0x17000014")]
	public static string compositionString
	{
		[Address(RVA = "0x19DA2B0", Offset = "0x19D94B0", Length = "0xA4")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_compositionString", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002D")]
		 get { } //Length: 164
	}

	[Token(Token = "0x17000013")]
	public static IMECompositionMode imeCompositionMode
	{
		[Address(RVA = "0x19DA360", Offset = "0x19D9560", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002B")]
		 get { } //Length: 42
		[Address(RVA = "0x19DA7B0", Offset = "0x19D99B0", Length = "0x31")]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002C")]
		 set { } //Length: 49
	}

	[NativeThrows]
	[Token(Token = "0x17000011")]
	public static Vector3 mousePosition
	{
		[Address(RVA = "0x19DA3D0", Offset = "0x19D95D0", Length = "0x3E")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000029")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000017")]
	public static bool mousePresent
	{
		[Address(RVA = "0x19DA410", Offset = "0x19D9610", Length = "0x6D")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.MouseInputDevice", Member = "HasPointer", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mousePresent", ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_IsMousePresent", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000033")]
		 get { } //Length: 109
	}

	[NativeThrows]
	[Token(Token = "0x17000012")]
	public static Vector2 mouseScrollDelta
	{
		[Address(RVA = "0x19DA4C0", Offset = "0x19D96C0", Length = "0x3B")]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002A")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000016")]
	internal static bool simulateTouchEnabled
	{
		[Address(RVA = "0x19DA500", Offset = "0x19D9700", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000030")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x17000019")]
	public static int touchCount
	{
		[Address(RVA = "0x19DA540", Offset = "0x19D9740", Length = "0x2A")]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonPressedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "LTGUI", Member = "firstTouch", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "LTGUI", Member = "pressedWithinRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasMoved", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonReleasedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "IsButtonPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "HasPointer", ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetPositionYAxisUp", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Ray))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetFrameDelta", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.TouchInputDevice", Member = "get_TouchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_touchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_TouchCount", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchCount", ReturnType = typeof(int))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetTouchCount")]
		[Token(Token = "0x6000035")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700001A")]
	public static Touch[] touches
	{
		[Address(RVA = "0x19DA5E0", Offset = "0x19D97E0", Length = "0x14B")]
		[CalledBy(Type = "LTGUI", Member = "pressedWithinRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "LTGUI", Member = "firstTouch", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000036")]
		 get { } //Length: 331
	}

	[Token(Token = "0x17000018")]
	public static bool touchSupported
	{
		[Address(RVA = "0x19DA570", Offset = "0x19D9770", Length = "0x70")]
		[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchSupported", ReturnType = typeof(bool))]
		[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_IsTouchSupported", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchSupported", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000034")]
		 get { } //Length: 112
	}

	[Address(RVA = "0x19D9DD0", Offset = "0x19D8FD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	internal static bool CheckDisabled() { }

	[Address(RVA = "0x19D9E00", Offset = "0x19D9000", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "ClearLastPenContactEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000023")]
	public static void ClearLastPenContactEvent() { }

	[Address(RVA = "0x19DA1C0", Offset = "0x19D93C0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_anyKey", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_AnyKey", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public static bool get_anyKey() { }

	[Address(RVA = "0x19DA190", Offset = "0x19D9390", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "get_AnyKeyDown", ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_IsAnyKeyDown", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	public static bool get_anyKeyDown() { }

	[Address(RVA = "0x19DA230", Offset = "0x19D9430", Length = "0x3B")]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	public static Vector2 get_compositionCursorPos() { }

	[Address(RVA = "0x19DA1F0", Offset = "0x19D93F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	[Address(RVA = "0x19DA2B0", Offset = "0x19D94B0", Length = "0xA4")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_compositionString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_compositionString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	public static string get_compositionString() { }

	[Address(RVA = "0x19DA270", Offset = "0x19D9470", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x19DA360", Offset = "0x19D9560", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	public static IMECompositionMode get_imeCompositionMode() { }

	[Address(RVA = "0x19DA3D0", Offset = "0x19D95D0", Length = "0x3E")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	public static Vector3 get_mousePosition() { }

	[Address(RVA = "0x19DA390", Offset = "0x19D9590", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	[Address(RVA = "0x19DA410", Offset = "0x19D9610", Length = "0x6D")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.MouseInputDevice", Member = "HasPointer", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mousePresent", ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_IsMousePresent", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mousePresent", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000033")]
	public static bool get_mousePresent() { }

	[Address(RVA = "0x19DA4C0", Offset = "0x19D96C0", Length = "0x3B")]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserRenamedItem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	public static Vector2 get_mouseScrollDelta() { }

	[Address(RVA = "0x19DA480", Offset = "0x19D9680", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	[Address(RVA = "0x19DA500", Offset = "0x19D9700", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000030")]
	internal static bool get_simulateTouchEnabled() { }

	[Address(RVA = "0x19DA540", Offset = "0x19D9740", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_TouchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_touchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "get_TouchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetFrameDelta", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetPositionYAxisUp", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "HasPointer", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonReleasedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasMoved", ReturnType = typeof(bool))]
	[CalledBy(Type = "LTGUI", Member = "pressedWithinRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "LTGUI", Member = "firstTouch", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchCount", ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonPressedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "IsButtonPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetTouchCount")]
	[Token(Token = "0x6000035")]
	public static int get_touchCount() { }

	[Address(RVA = "0x19DA5E0", Offset = "0x19D97E0", Length = "0x14B")]
	[CalledBy(Type = "LTGUI", Member = "pressedWithinRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "LTGUI", Member = "firstTouch", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000036")]
	public static Touch[] get_touches() { }

	[Address(RVA = "0x19DA570", Offset = "0x19D9770", Length = "0x70")]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "get_touchSupported", ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "get_IsTouchSupported", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "get_touchSupported", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000034")]
	public static bool get_touchSupported() { }

	[Address(RVA = "0x19D9E40", Offset = "0x19D9040", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.RTFocusCamera", Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.MouseInputDevice", Member = "WasMoved", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleScrollInput", ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCameraRotation", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFree", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFreeLook", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleFreeZoom", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000016")]
	public static float GetAxis(string axisName) { }

	[Address(RVA = "0x19D9E30", Offset = "0x19D9030", Length = "0x7")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "PressingMovementKeys", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "Polytoria.Controllers.HotbarController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000017")]
	public static float GetAxisRaw(string axisName) { }

	[Address(RVA = "0x19D9E70", Offset = "0x19D9070", Length = "0x7")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000018")]
	public static bool GetButton(string buttonName) { }

	[Address(RVA = "0x19D9E50", Offset = "0x19D9050", Length = "0x7")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.HotbarController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000019")]
	public static bool GetButtonDown(string buttonName) { }

	[Address(RVA = "0x19D9E60", Offset = "0x19D9060", Length = "0x7")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputUnsafeUtility), Member = "GetButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600001A")]
	public static bool GetButtonUp(string buttonName) { }

	[Address(RVA = "0x19D9EC0", Offset = "0x19D90C0", Length = "0x31")]
	[CallerCount(Count = 84)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000024")]
	public static bool GetKey(KeyCode key) { }

	[Address(RVA = "0x19D9E80", Offset = "0x19D9080", Length = "0x31")]
	[CallerCount(Count = 69)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000026")]
	public static bool GetKeyDown(KeyCode key) { }

	[Address(RVA = "0x19D9E80", Offset = "0x19D9080", Length = "0x31")]
	[CallerCount(Count = 69)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x600001D")]
	private static bool GetKeyDownInt(KeyCode key) { }

	[Address(RVA = "0x19D9EC0", Offset = "0x19D90C0", Length = "0x31")]
	[CallerCount(Count = 84)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x600001B")]
	private static bool GetKeyInt(KeyCode key) { }

	[Address(RVA = "0x19D9F00", Offset = "0x19D9100", Length = "0x31")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000025")]
	public static bool GetKeyUp(KeyCode key) { }

	[Address(RVA = "0x19D9F00", Offset = "0x19D9100", Length = "0x31")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeThrows]
	[Token(Token = "0x600001C")]
	private static bool GetKeyUpInt(KeyCode key) { }

	[Address(RVA = "0x19D9F80", Offset = "0x19D9180", Length = "0x46")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetLastPenContactEvent", ReturnType = typeof(PenData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000022")]
	public static PenData GetLastPenContactEvent() { }

	[Address(RVA = "0x19D9F40", Offset = "0x19D9140", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	[Address(RVA = "0x19DA050", Offset = "0x19D9250", Length = "0x31")]
	[CalledBy(Type = "RLD.Hotkeys", Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.Hotkeys", Member = "IsAnyMouseButtonPressed", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.MouseInputDevice", Member = "IsButtonPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCameraRotation", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "LTGUI", Member = "pressedWithinRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "LTGUI", Member = "firstTouch", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600001E")]
	public static bool GetMouseButton(int button) { }

	[Address(RVA = "0x19D9FD0", Offset = "0x19D91D0", Length = "0x31")]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCursorLocking", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.Hotkeys", Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.MouseInputDevice", Member = "WasButtonPressedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "IsMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.Menu", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x600001F")]
	public static bool GetMouseButtonDown(int button) { }

	[Address(RVA = "0x19DA010", Offset = "0x19D9210", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.MouseInputDevice", Member = "WasButtonReleasedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Helpers.CloseOnClickOutside", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "UpdateFollowMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "HandleCursorLocking", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.ContextMenuTrigger", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000020")]
	public static bool GetMouseButtonUp(int button) { }

	[Address(RVA = "0x19DA090", Offset = "0x19D9290", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetMousePresent")]
	[Token(Token = "0x6000031")]
	private static bool GetMousePresentInternal() { }

	[Address(RVA = "0x19DA130", Offset = "0x19D9330", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetFrameDelta", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "GetPositionYAxisUp", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonPressedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasButtonReleasedInCurrentFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TouchInputDevice", Member = "WasMoved", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CalledBy(Type = "Battlehub.UIControls.InputProvider", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Input", Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeThrows]
	[Token(Token = "0x6000021")]
	public static Touch GetTouch(int index) { }

	[Address(RVA = "0x19DA0F0", Offset = "0x19D92F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	private static void GetTouch_Injected(int index, out Touch ret) { }

	[Address(RVA = "0x19DA0C0", Offset = "0x19D92C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("IsTouchSupported")]
	[Token(Token = "0x6000032")]
	private static bool GetTouchSupportedInternal() { }

	[Address(RVA = "0x19DA770", Offset = "0x19D9970", Length = "0x34")]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002F")]
	public static void set_compositionCursorPos(Vector2 value) { }

	[Address(RVA = "0x19DA730", Offset = "0x19D9930", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	[Address(RVA = "0x19DA7B0", Offset = "0x19D99B0", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.EventSystems.BaseInput", Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	public static void set_imeCompositionMode(IMECompositionMode value) { }

}


namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000297")]
public static class MouseCaptureController
{

	[Address(RVA = "0x1C89120", Offset = "0x1C88320", Length = "0x1B0")]
	[CalledBy(Type = typeof(FieldMouseDragger`1), Member = "UpdateValueOnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsUtility), Member = "UnityEngine.UIElements.IUIElementsUtility.TakeCapture", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ColumnResizer), Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerDownEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(PointerDispatchState), Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEventHandler), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerDispatchState), Member = "ProcessPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60011F8")]
	public static void CaptureMouse(IEventHandler handler) { }

	[Address(RVA = "0x1C892E0", Offset = "0x1C884E0", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60011F7")]
	public static bool HasMouseCapture(IEventHandler handler) { }

}


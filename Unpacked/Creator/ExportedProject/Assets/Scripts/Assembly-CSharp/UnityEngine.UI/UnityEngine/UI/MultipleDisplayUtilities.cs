namespace UnityEngine.UI;

[Token(Token = "0x200005B")]
internal static class MultipleDisplayUtilities
{

	[Address(RVA = "0x1CC8A20", Offset = "0x1CC7C20", Length = "0xE2")]
	[CalledBy(Type = "UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Scrollbar), Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "UpdateDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036C")]
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	[Address(RVA = "0x1CC8B10", Offset = "0x1CC7D10", Length = "0x112")]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelEventHandler), typeof(PointerEventData), "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PanelRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldDocumentRaycaster), Member = "GetWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Ray&), typeof(Single&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600036D")]
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	[Address(RVA = "0x1CC8C30", Offset = "0x1CC7E30", Length = "0x45F")]
	[CalledBy(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Vector2&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(PhysicsRaycaster), Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Display), Member = "get_main", ReturnType = typeof(Display))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_fullScreen", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Display), Member = "get_systemWidth", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036E")]
	public static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex) { }

}


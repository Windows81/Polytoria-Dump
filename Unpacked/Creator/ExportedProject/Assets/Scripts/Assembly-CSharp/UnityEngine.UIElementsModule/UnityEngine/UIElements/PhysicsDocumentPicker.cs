namespace UnityEngine.UIElements;

[Token(Token = "0x200025F")]
internal class PhysicsDocumentPicker
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600108E")]
	public PhysicsDocumentPicker() { }

	[Address(RVA = "0x1C73740", Offset = "0x1C72940", Length = "0x1E2")]
	[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIDocument), Member = "FindRootUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(UIDocument))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(PointerDeviceState), Member = "GetWorldSpaceDocumentWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UIDocument))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600108D")]
	private bool GetCapturingDocument(int pointerId, out UIDocument capturingDocument) { }

	[Address(RVA = "0x1C73930", Offset = "0x1C72B30", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldSpaceInput), Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(PickResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600108B")]
	private void Pick(Ray worldRay, float maxDistance, int layerMask, out Collider collider, out UIDocument document, out VisualElement pickedElement, out float distance) { }

	[Address(RVA = "0x1C739E0", Offset = "0x1C72BE0", Length = "0x533")]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WorldSpaceInput), Member = "PerformPick2D_LocalPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Vector3), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "IntersectLocalRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WorldSpaceInput), Member = "PerformPick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(VisualElement), Member = "get_needs3DBounds", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Ray)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(VisualElementExtensions), Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PhysicsDocumentPicker), Member = "GetCapturingDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UIDocument&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WorldSpaceInput), Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(PickResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600108C")]
	public bool TryPickWithCapture(int pointerId, Ray worldRay, float maxDistance, int layerMask, out Collider collider, out UIDocument document, out VisualElement elementUnderPointer, out float distance, out bool captured) { }

}


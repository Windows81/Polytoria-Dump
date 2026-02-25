namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/World Document Raycaster (UI Toolkit)")]
[Token(Token = "0x2000099")]
public class WorldDocumentRaycaster : BaseRaycaster
{
	[Token(Token = "0x40002CB")]
	private static PhysicsDocumentPicker worldPicker; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40002CA")]
	private Camera m_EventCamera; //Field offset: 0x28

	[Token(Token = "0x1700019B")]
	public Camera camera
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000626")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000627")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700019A")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000625")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1CF4BE0", Offset = "0x1CF3DE0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600062B")]
	private static WorldDocumentRaycaster() { }

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600062A")]
	public WorldDocumentRaycaster() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000626")]
	public Camera get_camera() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000625")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x1CF4510", Offset = "0x1CF3710", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000629")]
	protected override bool GetWorldRay(PointerEventData eventData, out Ray worldRay, out float maxDistance, out int layerMask) { }

	[Address(RVA = "0x1CF46A0", Offset = "0x1CF38A0", Length = "0x53A")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "GetCameraWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = "UnityEngine.UIElements.PhysicsDocumentPicker", Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = "UnityEngine.UIElements.RuntimePanel")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D4600")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000628")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000627")]
	public void set_camera(Camera value) { }

}


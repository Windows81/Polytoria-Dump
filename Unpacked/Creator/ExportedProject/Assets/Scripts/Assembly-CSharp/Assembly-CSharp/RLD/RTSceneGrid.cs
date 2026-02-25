namespace RLD;

[Token(Token = "0x2000204")]
public class RTSceneGrid : MonoSingleton<RTSceneGrid>, IXZGrid
{
	[Token(Token = "0x2000205")]
	private enum SnapToPointMode
	{
		Exact = 0,
		ClosestExtremity = 1,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40007CC")]
	private SceneGridHotkeys _hotkeys; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40007CD")]
	private XZGridSettings _settings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40007CE")]
	private XZGridLookAndFeel _lookAndFeel; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007CF")]
	private List<Camera> _renderIgnoreCameras; //Field offset: 0x38

	[Token(Token = "0x17000641")]
	public SceneGridHotkeys Hotkeys
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013C7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700063C")]
	public Vector3 Look
	{
		[Address(RVA = "0x59E020", Offset = "0x59D220", Length = "0xE7")]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C1")]
		 get { } //Length: 231
	}

	[Token(Token = "0x17000643")]
	public XZGridLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013C9")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700063D")]
	public Vector3 Normal
	{
		[Address(RVA = "0x59E110", Offset = "0x59D310", Length = "0xE7")]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "get_WorldPlane", ReturnType = typeof(Plane))]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "get_WorldMatrix", ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "SnapToObjectHitPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit), typeof(SnapToPointMode)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C2")]
		 get { } //Length: 231
	}

	[Token(Token = "0x1700063B")]
	public Vector3 Right
	{
		[Address(RVA = "0x59E200", Offset = "0x59D400", Length = "0xE7")]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C0")]
		 get { } //Length: 231
	}

	[Token(Token = "0x1700063A")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x59E2F0", Offset = "0x59D4F0", Length = "0x75")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013BF")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000642")]
	public XZGridSettings Settings
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013C8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700063F")]
	public override Matrix4x4 WorldMatrix
	{
		[Address(RVA = "0x59E370", Offset = "0x59D570", Length = "0x187")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTSceneGrid), Member = "get_Normal", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C4")]
		 get { } //Length: 391
	}

	[Token(Token = "0x1700063E")]
	public override Plane WorldPlane
	{
		[Address(RVA = "0x59E500", Offset = "0x59D700", Length = "0x105")]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "CalculateCellFadeZoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(RTScene), Member = "RaycastSceneGridIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(XZGridRayHit))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(RTSceneGrid), Member = "get_Normal", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C3")]
		 get { } //Length: 261
	}

	[Token(Token = "0x17000640")]
	public float YOffset
	{
		[Address(RVA = "0x59E610", Offset = "0x59D810", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C5")]
		 get { } //Length: 28
		[Address(RVA = "0x59E630", Offset = "0x59D830", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C6")]
		 set { } //Length: 28
	}

	[Address(RVA = "0x59DD20", Offset = "0x59CF20", Length = "0x2F2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60013D8")]
	public RTSceneGrid() { }

	[Address(RVA = "0x59C3E0", Offset = "0x59B5E0", Length = "0x8C")]
	[CalledBy(Type = typeof(RTSceneGizmoCamera), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CC")]
	public void AddRenderIgnoreCamera(Camera camera) { }

	[Address(RVA = "0x59C470", Offset = "0x59B670", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_WorldPlane", ReturnType = typeof(Plane))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "GetAbsDistanceToPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013D4")]
	private float CalculateCellFadeZoom(Camera camera) { }

	[Address(RVA = "0x59C4F0", Offset = "0x59B6F0", Length = "0x4A")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XZGridCell), Member = "FromPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(IXZGrid)}, ReturnType = typeof(XZGridCell))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CE")]
	public override XZGridCell CellFromWorldPoint(Vector3 worldPoint) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013C7")]
	public SceneGridHotkeys get_Hotkeys() { }

	[Address(RVA = "0x59E020", Offset = "0x59D220", Length = "0xE7")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C1")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013C9")]
	public XZGridLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x59E110", Offset = "0x59D310", Length = "0xE7")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "get_WorldPlane", ReturnType = typeof(Plane))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "get_WorldMatrix", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "SnapToObjectHitPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit), typeof(SnapToPointMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C2")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x59E200", Offset = "0x59D400", Length = "0xE7")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C0")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x59E2F0", Offset = "0x59D4F0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013BF")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013C8")]
	public XZGridSettings get_Settings() { }

	[Address(RVA = "0x59E370", Offset = "0x59D570", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_Normal", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C4")]
	public override Matrix4x4 get_WorldMatrix() { }

	[Address(RVA = "0x59E500", Offset = "0x59D700", Length = "0x105")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "CalculateCellFadeZoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(RTScene), Member = "RaycastSceneGridIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(XZGridRayHit))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_Normal", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C3")]
	public override Plane get_WorldPlane() { }

	[Address(RVA = "0x59E610", Offset = "0x59D810", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C5")]
	public float get_YOffset() { }

	[Address(RVA = "0x59C540", Offset = "0x59B740", Length = "0x210")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "OnInputDeviceDoubleTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputDevice), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001AA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SceneRaycastFilter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTScene), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(SceneRaycastFilter)}, ReturnType = typeof(SceneRaycastHit))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60013D5")]
	private SceneRaycastHit GetSceneHitForGridSnap() { }

	[Address(RVA = "0x59C760", Offset = "0x59B960", Length = "0x140")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013CA")]
	public void Initialize_SystemCall() { }

	[Address(RVA = "0x59C8B0", Offset = "0x59BAB0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CB")]
	public bool IsRenderIgnoreCamera(Camera camera) { }

	[Address(RVA = "0x59C910", Offset = "0x59BB10", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013D3")]
	private void MoveDown() { }

	[Address(RVA = "0x59C940", Offset = "0x59BB40", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013D2")]
	private void MoveUp() { }

	[Address(RVA = "0x59C970", Offset = "0x59BB70", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTSceneGrid), Member = "GetSceneHitForGridSnap", ReturnType = typeof(SceneRaycastHit))]
	[Calls(Type = typeof(RTSceneGrid), Member = "SnapToObjectHitPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit), typeof(SnapToPointMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013D6")]
	private void OnInputDeviceDoubleTap(IInputDevice inputDevice, Vector2 position) { }

	[Address(RVA = "0x59C9E0", Offset = "0x59BBE0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_WorldPlane", ReturnType = typeof(Plane))]
	[Calls(Type = typeof(Plane), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60013CF")]
	public override bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x59CA40", Offset = "0x59BC40", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CD")]
	public void RemoveRenderIgnoreCamera(Camera camera) { }

	[Address(RVA = "0x59CAA0", Offset = "0x59BCA0", Length = "0xC05")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnRenderObject", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitQuadXZ", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_Look", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_Right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MaterialPool), Member = "get_XZGrid_Plane", ReturnType = typeof(Material))]
	[Calls(Type = typeof(PlaneEx), Member = "GetAbsDistanceToPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_WorldPlane", ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CameraEx), Member = "CalculateVolumeAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289930")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(MathEx), Member = "GetNumDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D1")]
	public void Render_SystemCall(Camera renderCamera) { }

	[Address(RVA = "0x59E630", Offset = "0x59D830", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C6")]
	public void set_YOffset(float value) { }

	[Address(RVA = "0x59D6B0", Offset = "0x59C8B0", Length = "0x489")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "OnInputDeviceDoubleTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputDevice), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(RTSceneGrid), Member = "get_Normal", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(PlaneEx), Member = "GetFurthestPtBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlaneEx), Member = "GetFurthestPtInFront", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D7")]
	private void SnapToObjectHitPoint(GameObjectRayHit objectHit, SnapToPointMode snapMode) { }

	[Address(RVA = "0x59DB40", Offset = "0x59CD40", Length = "0x1D4")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTSceneGrid), Member = "GetSceneHitForGridSnap", ReturnType = typeof(SceneRaycastHit))]
	[Calls(Type = typeof(RTSceneGrid), Member = "SnapToObjectHitPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit), typeof(SnapToPointMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013D0")]
	public void Update_SystemCall() { }

}


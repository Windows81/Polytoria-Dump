namespace RLD;

[Token(Token = "0x2000093")]
public class RTSceneGizmoCamera : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000200")]
	private Camera _camera; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000201")]
	private Transform _transform; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000202")]
	private Vector3 _lookAtPoint; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000203")]
	private float _fieldOfView; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000204")]
	private float _orthoSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000205")]
	private float _offsetFromFocusPt; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000206")]
	private Camera _sceneCamera; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000207")]
	private ISceneGizmoCamViewportUpdater _viewportUpdater; //Field offset: 0x50

	[Token(Token = "0x17000190")]
	public Camera Camera
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000197")]
	public Vector3 Look
	{
		[Address(RVA = "0x3E0090", Offset = "0x3DF290", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000537")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000198")]
	public Vector3 LookAtPoint
	{
		[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000538")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000195")]
	public Vector3 Right
	{
		[Address(RVA = "0x3E00D0", Offset = "0x3DF2D0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000535")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000191")]
	public Camera SceneCamera
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052D")]
		 get { } //Length: 5
		[Address(RVA = "0x3E01D0", Offset = "0x3DF3D0", Length = "0xD5")]
		[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(ISceneGizmoCamViewportUpdater)}, ReturnType = typeof(RTSceneGizmoCamera))]
		[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
		[Calls(Type = typeof(Camera), Member = "set_depth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600052E")]
		 set { } //Length: 213
	}

	[Token(Token = "0x17000196")]
	public Vector3 Up
	{
		[Address(RVA = "0x3E0110", Offset = "0x3DF310", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000536")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000192")]
	public ISceneGizmoCamViewportUpdater ViewportUpdater
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052F")]
		 get { } //Length: 5
		[Address(RVA = "0x3E02B0", Offset = "0x3DF4B0", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000530")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000193")]
	public Vector3 WorldPosition
	{
		[Address(RVA = "0x3E0150", Offset = "0x3DF350", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000531")]
		 get { } //Length: 59
		[Address(RVA = "0x3E02D0", Offset = "0x3DF4D0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000532")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000194")]
	public Quaternion WorldRotation
	{
		[Address(RVA = "0x3E0190", Offset = "0x3DF390", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000533")]
		 get { } //Length: 51
		[Address(RVA = "0x3E0310", Offset = "0x3DF510", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000534")]
		 set { } //Length: 44
	}

	[Address(RVA = "0x3E0020", Offset = "0x3DF220", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600053C")]
	public RTSceneGizmoCamera() { }

	[Address(RVA = "0x3DFB50", Offset = "0x3DED50", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600053A")]
	private void Awake() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052C")]
	public Camera get_Camera() { }

	[Address(RVA = "0x3E0090", Offset = "0x3DF290", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000537")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000538")]
	public Vector3 get_LookAtPoint() { }

	[Address(RVA = "0x3E00D0", Offset = "0x3DF2D0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000535")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052D")]
	public Camera get_SceneCamera() { }

	[Address(RVA = "0x3E0110", Offset = "0x3DF310", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000536")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052F")]
	public ISceneGizmoCamViewportUpdater get_ViewportUpdater() { }

	[Address(RVA = "0x3E0150", Offset = "0x3DF350", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000531")]
	public Vector3 get_WorldPosition() { }

	[Address(RVA = "0x3E0190", Offset = "0x3DF390", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000533")]
	public Quaternion get_WorldRotation() { }

	[Address(RVA = "0x3E01D0", Offset = "0x3DF3D0", Length = "0xD5")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(ISceneGizmoCamViewportUpdater)}, ReturnType = typeof(RTSceneGizmoCamera))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "set_depth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052E")]
	public void set_SceneCamera(Camera value) { }

	[Address(RVA = "0x3E02B0", Offset = "0x3DF4B0", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000530")]
	public void set_ViewportUpdater(ISceneGizmoCamViewportUpdater value) { }

	[Address(RVA = "0x3E02D0", Offset = "0x3DF4D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000532")]
	public void set_WorldPosition(Vector3 value) { }

	[Address(RVA = "0x3E0310", Offset = "0x3DF510", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000534")]
	public void set_WorldRotation(Quaternion value) { }

	[Address(RVA = "0x3DFBD0", Offset = "0x3DEDD0", Length = "0x253")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSceneGrid), Member = "AddRenderIgnoreCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTCameraBackground), Member = "AddRenderIgnoreCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "set_allowHDR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingPath)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraClearFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelection), Member = "AddRenderIgnoreCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Token(Token = "0x600053B")]
	private void Start() { }

	[Address(RVA = "0x3DFE30", Offset = "0x3DF030", Length = "0x1EE")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "set_orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000539")]
	public void Update_SystemCall() { }

}


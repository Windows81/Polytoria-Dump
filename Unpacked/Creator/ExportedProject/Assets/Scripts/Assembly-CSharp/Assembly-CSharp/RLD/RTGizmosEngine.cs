namespace RLD;

[Token(Token = "0x200008A")]
public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>, IHoverableSceneEntityContainer
{
	[CompilerGenerated]
	[Token(Token = "0x200008B")]
	private sealed class <>c__DisplayClass56_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001F2")]
		public Gizmo gizmo; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001F3")]
		public Vector3 screenRayOrigin; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600050F")]
		public <>c__DisplayClass56_0() { }

		[Address(RVA = "0x3E4F60", Offset = "0x3E4160", Length = "0x35F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Priority), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority), typeof(Priority)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Priority), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000510")]
		internal int <GetGizmoHandleHoverData>b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008C")]
	private sealed class <>c__DisplayClass57_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001F4")]
		public Vector3 camPos; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000511")]
		public <>c__DisplayClass57_0() { }

		[Address(RVA = "0x3E52C0", Offset = "0x3E44C0", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000512")]
		internal int <Render_SystemCall>b__0(Gizmo g0, Gizmo g1) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200008D")]
	private sealed class <>c__DisplayClass58_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001F5")]
		public Vector3 inputDevicePos; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001F6")]
		public Ray hoverRay; //Field offset: 0x1C

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000513")]
		public <>c__DisplayClass58_0() { }

		[Address(RVA = "0x3E5390", Offset = "0x3E4590", Length = "0x33C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Priority), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority), typeof(Priority)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Priority), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000514")]
		internal int <SortHandleHoverDataCollection>b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E5")]
	private GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001E6")]
	private EditorToolbar _mainToolbar; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	private GizmoEngineSettings _settings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E8")]
	private GizmosEnginePipelineStage _pipelineStage; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E9")]
	private Gizmo _draggedGizmo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001EA")]
	private bool _justReleasedDrag; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EB")]
	private Gizmo _hoveredGizmo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001EC")]
	private GizmoHoverInfo _gizmoHoverInfo; //Field offset: 0x58
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001ED")]
	private List<Gizmo> _gizmos; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001EE")]
	private List<ISceneGizmo> _sceneGizmos; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001EF")]
	private List<RTSceneGizmoCamera> _sceneGizmoCameras; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001F0")]
	private List<Camera> _renderCameras; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x40001F1")]
	private SceneGizmoLookAndFeel _sharedSceneGizmoLookAndFeel; //Field offset: 0x90

	[Token(Token = "0x14000015")]
	public event GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
	{
		[Address(RVA = "0x3DF950", Offset = "0x3DEB50", Length = "0x9E")]
		[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60004E5")]
		 add { } //Length: 158
		[Address(RVA = "0x3DFAB0", Offset = "0x3DECB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60004E6")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000181")]
	public Gizmo DraggedGizmo
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004ED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017E")]
	public override bool HasHoveredSceneEntity
	{
		[Address(RVA = "0x3DF9F0", Offset = "0x3DEBF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EA")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000180")]
	public Gizmo HoveredGizmo
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017F")]
	public bool IsAnyGizmoHovered
	{
		[Address(RVA = "0x3DF9F0", Offset = "0x3DEBF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EB")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000182")]
	public bool JustReleasedDrag
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004EE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000183")]
	public int NumRenderCameras
	{
		[Address(RVA = "0x3DFA00", Offset = "0x3DEC00", Length = "0x3F")]
		[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004EF")]
		 get { } //Length: 63
	}

	[Token(Token = "0x1700017C")]
	public GizmosEnginePipelineStage PipelineStage
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700017D")]
	public Camera RenderStageCamera
	{
		[Address(RVA = "0x3DFA40", Offset = "0x3DEC40", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004E9")]
		 get { } //Length: 96
	}

	[Token(Token = "0x1700017B")]
	public GizmoEngineSettings Settings
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E7")]
		 get { } //Length: 95
	}

	[Token(Token = "0x17000184")]
	public SceneGizmoLookAndFeel SharedSceneGizmoLookAndFeel
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004F0")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3DF590", Offset = "0x3DE790", Length = "0x3B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EditorToolbarTab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(EditorToolbar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EditorToolbarTab[]), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SceneGizmoLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600050E")]
	public RTGizmosEngine() { }

	[Address(RVA = "0x3DF950", Offset = "0x3DEB50", Length = "0x9E")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60004E5")]
	public void add_CanDoHoverUpdate(GizmoEngineCanDoHoverUpdateHandler value) { }

	[Address(RVA = "0x3DCC50", Offset = "0x3DBE50", Length = "0xFE")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnViewportsCameraAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "IsSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004F1")]
	public void AddRenderCamera(Camera camera) { }

	[Address(RVA = "0x3DCD50", Offset = "0x3DBF50", Length = "0x221")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectBoxScaleGizmo", ReturnType = typeof(BoxGizmo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoCap2DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000502")]
	public BoxGizmo CreateBoxGizmo() { }

	[Address(RVA = "0x3DCF80", Offset = "0x3DC180", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004F7")]
	public Gizmo CreateGizmo() { }

	[Address(RVA = "0x3DCFE0", Offset = "0x3DC1E0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FA")]
	public MoveGizmo CreateMoveGizmo() { }

	[Address(RVA = "0x3DD090", Offset = "0x3DC290", Length = "0x43")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000503")]
	public BoxGizmo CreateObjectBoxScaleGizmo() { }

	[Address(RVA = "0x3DD0E0", Offset = "0x3DC2E0", Length = "0xAB")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectExtrudeGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000504")]
	public ObjectExtrudeGizmo CreateObjectExtrudeGizmo() { }

	[Address(RVA = "0x3DD190", Offset = "0x3DC390", Length = "0xF9")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformChannelFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Channels)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FB")]
	public ObjectTransformGizmo CreateObjectMoveGizmo() { }

	[Address(RVA = "0x3DD290", Offset = "0x3DC490", Length = "0xF9")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformChannelFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Channels)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FD")]
	public ObjectTransformGizmo CreateObjectRotationGizmo() { }

	[Address(RVA = "0x3DD390", Offset = "0x3DC590", Length = "0x113")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformChannelFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Channels)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoSpace)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004FF")]
	public ObjectTransformGizmo CreateObjectScaleGizmo() { }

	[Address(RVA = "0x3DD4B0", Offset = "0x3DC6B0", Length = "0xF9")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Initialize_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(ObjectTransformGizmo), Member = "SetTransformChannelFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Channels)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000501")]
	public ObjectTransformGizmo CreateObjectUniversalGizmo() { }

	[Address(RVA = "0x3DD5B0", Offset = "0x3DC7B0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RotationGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FC")]
	public RotationGizmo CreateRotationGizmo() { }

	[Address(RVA = "0x3DD660", Offset = "0x3DC860", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004FE")]
	public ScaleGizmo CreateScaleGizmo() { }

	[Address(RVA = "0x3DD920", Offset = "0x3DCB20", Length = "0x177")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "GetSceneGizmoByCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(ISceneGizmo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"BehaviourType"}, ReturnType = "BehaviourType")]
	[Calls(Type = typeof(RTSceneGizmoCamera), Member = "set_SceneCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004F9")]
	public SceneGizmo CreateSceneGizmo(Camera sceneCamera) { }

	[Address(RVA = "0x3DD710", Offset = "0x3DC910", Length = "0x20C")]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RTSceneGizmoCamera), Member = "set_SceneCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F4")]
	public RTSceneGizmoCamera CreateSceneGizmoCamera(Camera sceneCamera, ISceneGizmoCamViewportUpdater viewportUpdater) { }

	[Address(RVA = "0x3DDAA0", Offset = "0x3DCCA0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "AddBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoBehaviour)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000500")]
	public UniversalGizmo CreateUniversalGizmo() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004ED")]
	public Gizmo get_DraggedGizmo() { }

	[Address(RVA = "0x3DF9F0", Offset = "0x3DEBF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EA")]
	public override bool get_HasHoveredSceneEntity() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EC")]
	public Gizmo get_HoveredGizmo() { }

	[Address(RVA = "0x3DF9F0", Offset = "0x3DEBF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EB")]
	public bool get_IsAnyGizmoHovered() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004EE")]
	public bool get_JustReleasedDrag() { }

	[Address(RVA = "0x3DFA00", Offset = "0x3DEC00", Length = "0x3F")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004EF")]
	public int get_NumRenderCameras() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E8")]
	public GizmosEnginePipelineStage get_PipelineStage() { }

	[Address(RVA = "0x3DFA40", Offset = "0x3DEC40", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004E9")]
	public Camera get_RenderStageCamera() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E7")]
	public GizmoEngineSettings get_Settings() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F0")]
	public SceneGizmoLookAndFeel get_SharedSceneGizmoLookAndFeel() { }

	[Address(RVA = "0x3DDB50", Offset = "0x3DCD50", Length = "0x2A7")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(GizmoHandleCollection), Member = "GetAllHandlesHoverData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoHandleHoverData>))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000506")]
	public GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo) { }

	[Address(RVA = "0x3DDE00", Offset = "0x3DD000", Length = "0x207")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F6")]
	public ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera) { }

	[Address(RVA = "0x3DE010", Offset = "0x3DD210", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004F2")]
	public bool IsRenderCamera(Camera camera) { }

	[Address(RVA = "0x3DE070", Offset = "0x3DD270", Length = "0xE6")]
	[CalledBy(Type = typeof(Gizmo), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Plane[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "AddRenderCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RLDApp), Member = "OnSceneCanRenderCameraIcon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(YesNoAnswer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RLDApp), Member = "OnRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTScene), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F5")]
	public bool IsSceneGizmoCamera(Camera camera) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600050C")]
	private void OnGizmoDragBegin(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3DE280", Offset = "0x3DD480", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600050D")]
	private void OnGizmoDragEnd(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3DE160", Offset = "0x3DD360", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "OnGUI_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600050B")]
	private void OnGUI() { }

	[Address(RVA = "0x3DE2B0", Offset = "0x3DD4B0", Length = "0x23D")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectExtrudeGizmo", ReturnType = typeof(ObjectExtrudeGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateUniversalGizmo", ReturnType = typeof(UniversalGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectScaleGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateScaleGizmo", ReturnType = typeof(ScaleGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectRotationGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectUniversalGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateMoveGizmo", ReturnType = typeof(MoveGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateSceneGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(SceneGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateGizmo", ReturnType = typeof(Gizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateRotationGizmo", ReturnType = typeof(RotationGizmo))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000509")]
	private void RegisterGizmo(Gizmo gizmo) { }

	[Address(RVA = "0x3DFAB0", Offset = "0x3DECB0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60004E6")]
	public void remove_CanDoHoverUpdate(GizmoEngineCanDoHoverUpdateHandler value) { }

	[Address(RVA = "0x3DE4F0", Offset = "0x3DD6F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTGizmosEngine), Member = "UnregisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004F8")]
	public void RemoveGizmo(Gizmo gizmo) { }

	[Address(RVA = "0x3DE500", Offset = "0x3DD700", Length = "0x56")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnViewportCameraRemoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004F3")]
	public void RemoveRenderCamera(Camera camera) { }

	[Address(RVA = "0x3DE560", Offset = "0x3DD760", Length = "0x3AD")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnRenderObject", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CameraViewVolume), Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Plane[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Gizmo), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Plane[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "IsSceneGizmoCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000507")]
	public void Render_SystemCall(Camera renderCamera) { }

	[Address(RVA = "0x3DE910", Offset = "0x3DDB10", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000508")]
	private void SortHandleHoverDataCollection(List<GizmoHandleHoverData> hoverDataCollection, Vector3 inputDevicePos) { }

	[Address(RVA = "0x3DEA30", Offset = "0x3DDC30", Length = "0x1E7")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "RemoveGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600050A")]
	private void UnregisterGizmo(Gizmo gizmo) { }

	[Address(RVA = "0x3DEC20", Offset = "0x3DDE20", Length = "0x963")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTFocusCamera), Member = "IsViewportHoveredByDevice", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "OnInputDeviceMoved", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "EndDragSession", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(Gizmo), Member = "UpdateHandleHoverInfo_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoHoverInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTGizmosEngine), Member = "GetGizmoHandleHoverData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(GizmoHandleHoverData))]
	[Calls(Type = typeof(Gizmo), Member = "OnUpdateBegin_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Gizmo), Member = "OnUpdateEnd_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTScene), Member = "IsAnyUIElementHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RTSceneGizmoCamera), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(GizmoHoverInfo), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000505")]
	public void Update_SystemCall() { }

}


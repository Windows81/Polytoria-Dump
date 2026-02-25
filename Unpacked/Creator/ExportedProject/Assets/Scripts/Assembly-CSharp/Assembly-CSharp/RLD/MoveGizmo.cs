namespace RLD;

[Token(Token = "0x2000101")]
public class MoveGizmo : GizmoBehaviour
{
	[Token(Token = "0x2000102")]
	internal enum VertexSnapState
	{
		SelectingPivot = 0,
		Snapping = 1,
		Inactive = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400042B")]
	private GizmoLineSlider3D _pXSlider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400042C")]
	private GizmoLineSlider3D _pYSlider; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400042D")]
	private GizmoLineSlider3D _pZSlider; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400042E")]
	private GizmoLineSlider3D _nXSlider; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400042F")]
	private GizmoLineSlider3D _nYSlider; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000430")]
	private GizmoLineSlider3D _nZSlider; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000431")]
	private GizmoLineSlider3DCollection _axesSliders; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000432")]
	private GizmoPlaneSlider3D _xySlider; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000433")]
	private GizmoPlaneSlider3D _yzSlider; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000434")]
	private GizmoPlaneSlider3D _zxSlider; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000435")]
	private GizmoPlaneSlider3DCollection _dblSliders; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000436")]
	private GizmoCap3D _midCap; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000437")]
	private bool _isVertexSnapEnabled; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000438")]
	private GizmoCap2D _vertSnapCap; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000439")]
	private GizmoObjectVertexSnapDrag3D _vertexSnapDrag; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400043A")]
	private Vector3 _postVSnapPosRestore; //Field offset: 0x98
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x400043B")]
	private bool _is2DModeEnabled; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400043C")]
	private GizmoLineSlider2D _p2DModeXSlider; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400043D")]
	private GizmoLineSlider2D _p2DModeYSlider; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400043E")]
	private GizmoLineSlider2D _n2DModeXSlider; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400043F")]
	private GizmoLineSlider2D _n2DModeYSlider; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000440")]
	private GizmoLineSlider2DCollection _2DModeSliders; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000441")]
	private GizmoPlaneSlider2D _2DModeDblSlider; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000442")]
	private bool _useSnapEnableHotkey; //Field offset: 0xD8
	[FieldOffset(Offset = "0xD9")]
	[SerializeField]
	[Token(Token = "0x4000443")]
	private bool _useVertSnapEnableHotkey; //Field offset: 0xD9
	[FieldOffset(Offset = "0xDA")]
	[SerializeField]
	[Token(Token = "0x4000444")]
	private bool _use2DModeEnableHotkey; //Field offset: 0xDA
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000445")]
	private MoveGizmoHotkeys _hotkeys; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000446")]
	private MoveGizmoSettings2D _settings2D; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000447")]
	private MoveGizmoSettings3D _settings3D; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000448")]
	private MoveGizmoLookAndFeel2D _lookAndFeel2D; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000449")]
	private MoveGizmoLookAndFeel3D _lookAndFeel3D; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400044A")]
	private MoveGizmoHotkeys _sharedHotkeys; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400044B")]
	private MoveGizmoSettings2D _sharedSettings2D; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400044C")]
	private MoveGizmoSettings3D _sharedSettings3D; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400044D")]
	private MoveGizmoLookAndFeel2D _sharedLookAndFeel2D; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400044E")]
	private MoveGizmoLookAndFeel3D _sharedLookAndFeel3D; //Field offset: 0x128

	[Token(Token = "0x170002ED")]
	public MoveGizmoHotkeys Hotkeys
	{
		[Address(RVA = "0x51DA40", Offset = "0x51CC40", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000944")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170002EB")]
	public MoveGizmoLookAndFeel2D LookAndFeel2D
	{
		[Address(RVA = "0x51DA60", Offset = "0x51CC60", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000942")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170002EC")]
	public MoveGizmoLookAndFeel3D LookAndFeel3D
	{
		[Address(RVA = "0x51DA80", Offset = "0x51CC80", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000943")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170002E9")]
	public MoveGizmoSettings2D Settings2D
	{
		[Address(RVA = "0x51DAA0", Offset = "0x51CCA0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000940")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170002EA")]
	public MoveGizmoSettings3D Settings3D
	{
		[Address(RVA = "0x51DAC0", Offset = "0x51CCC0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000941")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170002F2")]
	public MoveGizmoHotkeys SharedHotkeys
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094D")]
		 get { } //Length: 8
		[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600094E")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170002F0")]
	public MoveGizmoLookAndFeel2D SharedLookAndFeel2D
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000949")]
		 get { } //Length: 8
		[Address(RVA = "0x51DB10", Offset = "0x51CD10", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x600094A")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170002F1")]
	public MoveGizmoLookAndFeel3D SharedLookAndFeel3D
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094B")]
		 get { } //Length: 8
		[Address(RVA = "0x51DB40", Offset = "0x51CD40", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[Token(Token = "0x600094C")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170002EE")]
	public MoveGizmoSettings2D SharedSettings2D
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000945")]
		 get { } //Length: 8
		[Address(RVA = "0x51DB70", Offset = "0x51CD70", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[Token(Token = "0x6000946")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170002EF")]
	public MoveGizmoSettings3D SharedSettings3D
	{
		[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000947")]
		 get { } //Length: 8
		[Address(RVA = "0x51DBA0", Offset = "0x51CDA0", Length = "0x2B")]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
		[Token(Token = "0x6000948")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170002F5")]
	public bool Use2DModeEnableHotkey
	{
		[Address(RVA = "0x51DAE0", Offset = "0x51CCE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000953")]
		 get { } //Length: 8
		[Address(RVA = "0x51DBD0", Offset = "0x51CDD0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000954")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002F3")]
	public bool UseSnapEnableHotkey
	{
		[Address(RVA = "0x51DAF0", Offset = "0x51CCF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600094F")]
		 get { } //Length: 8
		[Address(RVA = "0x51DBE0", Offset = "0x51CDE0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000950")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170002F4")]
	public bool UseVertSnapEnableHotkey
	{
		[Address(RVA = "0x51DB00", Offset = "0x51CD00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000951")]
		 get { } //Length: 8
		[Address(RVA = "0x51DBF0", Offset = "0x51CDF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000952")]
		 set { } //Length: 7
	}

	[Address(RVA = "0x51D570", Offset = "0x51C770", Length = "0x4C1")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateMoveGizmo", ReturnType = typeof(MoveGizmo))]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateObjectMoveGizmo", ReturnType = typeof(ObjectTransformGizmo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoLookAndFeel2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoLineSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GizmoPlaneSlider2DSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600096D")]
	public MoveGizmo() { }

	[Address(RVA = "0x51DA40", Offset = "0x51CC40", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000944")]
	public MoveGizmoHotkeys get_Hotkeys() { }

	[Address(RVA = "0x51DA60", Offset = "0x51CC60", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000942")]
	public MoveGizmoLookAndFeel2D get_LookAndFeel2D() { }

	[Address(RVA = "0x51DA80", Offset = "0x51CC80", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000943")]
	public MoveGizmoLookAndFeel3D get_LookAndFeel3D() { }

	[Address(RVA = "0x51DAA0", Offset = "0x51CCA0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000940")]
	public MoveGizmoSettings2D get_Settings2D() { }

	[Address(RVA = "0x51DAC0", Offset = "0x51CCC0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000941")]
	public MoveGizmoSettings3D get_Settings3D() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094D")]
	public MoveGizmoHotkeys get_SharedHotkeys() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000949")]
	public MoveGizmoLookAndFeel2D get_SharedLookAndFeel2D() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094B")]
	public MoveGizmoLookAndFeel3D get_SharedLookAndFeel3D() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000945")]
	public MoveGizmoSettings2D get_SharedSettings2D() { }

	[Address(RVA = "0x3F5860", Offset = "0x3F4A60", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000947")]
	public MoveGizmoSettings3D get_SharedSettings3D() { }

	[Address(RVA = "0x51DAE0", Offset = "0x51CCE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000953")]
	public bool get_Use2DModeEnableHotkey() { }

	[Address(RVA = "0x51DAF0", Offset = "0x51CCF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094F")]
	public bool get_UseSnapEnableHotkey() { }

	[Address(RVA = "0x51DB00", Offset = "0x51CD00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000951")]
	public bool get_UseVertSnapEnableHotkey() { }

	[Address(RVA = "0x51A220", Offset = "0x519420", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000955")]
	public VertexSnapState GetVertexSnapState() { }

	[Address(RVA = "0x51A270", Offset = "0x519470", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000957")]
	public float GetZoomFactor(Vector3 position, Camera camera) { }

	[Address(RVA = "0x51A340", Offset = "0x519540", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000956")]
	public float GetZoomFactor(Vector3 position) { }

	[Address(RVA = "0x51A410", Offset = "0x519610", Length = "0x78")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Set2DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600096C")]
	private void Hide2DModeHandles() { }

	[Address(RVA = "0x51A490", Offset = "0x519690", Length = "0xB60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandleId), Member = "get_VertSnap", ReturnType = typeof(int))]
	[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "Hide2DModeHandles", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Priority), Member = "MakeLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "SetDragChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoHandleId), Member = "get_MidDisplayCap", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600095E")]
	public virtual void OnAttached() { }

	[Address(RVA = "0x51B000", Offset = "0x51A200", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095F")]
	public virtual void OnDetached() { }

	[Address(RVA = "0x51B0A0", Offset = "0x51A2A0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "remove_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000961")]
	public virtual void OnDisabled() { }

	[Address(RVA = "0x51B140", Offset = "0x51A340", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000960")]
	public virtual void OnEnabled() { }

	[Address(RVA = "0x51B1E0", Offset = "0x51A3E0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "get_RelativeDragOffset", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000965")]
	public virtual void OnGizmoDragUpdate(int handleId) { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000962")]
	public virtual void OnGizmoEnabled() { }

	[Address(RVA = "0x51B270", Offset = "0x51A470", Length = "0x31F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "GetRenderSortedSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoLineSlider3D>))]
	[Calls(Type = typeof(MoveGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTGizmosEngine), Member = "get_NumRenderCameras", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000964")]
	public virtual void OnGizmoRender(Camera camera) { }

	[Address(RVA = "0x51B590", Offset = "0x51A790", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600096B")]
	private void OnGizmoTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x51B5A0", Offset = "0x51A7A0", Length = "0xCF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "SelectSnapPivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000963")]
	public virtual void OnGizmoUpdateBegin() { }

	[Address(RVA = "0x51C2A0", Offset = "0x51B4A0", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "ContainsCapId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000958")]
	public bool OwnsHandle(int handleId) { }

	[Address(RVA = "0x51C390", Offset = "0x51B590", Length = "0x108")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000966")]
	private void PlaceDblSlidersInSliderPlanes(Camera camera) { }

	[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600094E")]
	public void set_SharedHotkeys(MoveGizmoHotkeys value) { }

	[Address(RVA = "0x51DB10", Offset = "0x51CD10", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x600094A")]
	public void set_SharedLookAndFeel2D(MoveGizmoLookAndFeel2D value) { }

	[Address(RVA = "0x51DB40", Offset = "0x51CD40", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[Token(Token = "0x600094C")]
	public void set_SharedLookAndFeel3D(MoveGizmoLookAndFeel3D value) { }

	[Address(RVA = "0x51DB70", Offset = "0x51CD70", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Token(Token = "0x6000946")]
	public void set_SharedSettings2D(MoveGizmoSettings2D value) { }

	[Address(RVA = "0x51DBA0", Offset = "0x51CDA0", Length = "0x2B")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MoveGizmo), Member = "SetupSharedSettings", ReturnType = typeof(void))]
	[Token(Token = "0x6000948")]
	public void set_SharedSettings3D(MoveGizmoSettings3D value) { }

	[Address(RVA = "0x51DBD0", Offset = "0x51CDD0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000954")]
	public void set_Use2DModeEnableHotkey(bool value) { }

	[Address(RVA = "0x51DBE0", Offset = "0x51CDE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000950")]
	public void set_UseSnapEnableHotkey(bool value) { }

	[Address(RVA = "0x51DBF0", Offset = "0x51CDF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000952")]
	public void set_UseVertSnapEnableHotkey(bool value) { }

	[Address(RVA = "0x51C4A0", Offset = "0x51B6A0", Length = "0x1EE")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "Hide2DModeHandles", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "Set2DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "Set3DCapsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetOffsetDragOrigin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600095C")]
	public void Set2DModeEnabled(bool isEnabled) { }

	[Address(RVA = "0x51C690", Offset = "0x51B890", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000959")]
	public void SetAxesLinesHoverable(bool hoverable) { }

	[Address(RVA = "0x51C780", Offset = "0x51B980", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider2DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600095A")]
	public void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x51C900", Offset = "0x51BB00", Length = "0x4D3")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "set_SharedLookAndFeel2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "set_SharedLookAndFeel3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoLookAndFeel3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "set_SharedLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000967")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x51CDE0", Offset = "0x51BFE0", Length = "0x51C")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "set_SharedSettings2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "set_SharedSettings3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MoveGizmoSettings3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "set_Settings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoObjectVertexSnapSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000968")]
	private void SetupSharedSettings() { }

	[Address(RVA = "0x51C810", Offset = "0x51BA10", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600095B")]
	public void SetVertexSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x51C8D0", Offset = "0x51BAD0", Length = "0x21")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "RegisterGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Gizmo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "SetTargetObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600095D")]
	public void SetVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects) { }

	[Address(RVA = "0x51D300", Offset = "0x51C500", Length = "0x9A")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000969")]
	private void Update2DGizmoPosition() { }

	[Address(RVA = "0x51D3A0", Offset = "0x51C5A0", Length = "0x1C5")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "set_StartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600096A")]
	private void Update2DModeHandlePositions() { }

}


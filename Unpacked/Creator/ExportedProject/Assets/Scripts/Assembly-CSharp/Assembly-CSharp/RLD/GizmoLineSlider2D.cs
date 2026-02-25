namespace RLD;

[Token(Token = "0x20000A3")]
public class GizmoLineSlider2D : GizmoSlider
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024D")]
	private SegmentShape2D _segment; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024E")]
	private QuadShape2D _quad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400024F")]
	private int _segmentIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000250")]
	private int _quadIndex; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000251")]
	private GizmoDragChannel _dragChannel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000252")]
	private GizmoSglAxisOffsetDrag3D _offsetDrag; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000253")]
	private Vector3 _offsetDragOrigin; //Field offset: 0x50
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000254")]
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000255")]
	private GizmoRotationArc2D _rotationArc; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000256")]
	private GizmoSglAxisScaleDrag3D _scaleDrag; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000257")]
	private Vector3 _scaleDragOrigin; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000258")]
	private Vector3 _scaleAxis; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000259")]
	private int _scaleDragAxisIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400025A")]
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400025B")]
	private GizmoCap2D _cap2D; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400025C")]
	private GizmoTransform _transform; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400025D")]
	private GizmoTransformAxisMap2D _directionAxisMap; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400025E")]
	private GizmoOverrideColor _overrideFillColor; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400025F")]
	private GizmoOverrideColor _overrideBorderColor; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000260")]
	private GizmoLineSlider2DControllerData _controllerData; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000261")]
	private IGizmoLineSlider2DController[] _controllers; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000262")]
	private GizmoLineSlider2DSettings _settings; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000263")]
	private GizmoLineSlider2DSettings _sharedSettings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000264")]
	private GizmoLineSlider2DLookAndFeel _lookAndFeel; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000265")]
	private GizmoLineSlider2DLookAndFeel _sharedLookAndFeel; //Field offset: 0xF0

	[Token(Token = "0x170001DE")]
	public int Cap2DHandleId
	{
		[Address(RVA = "0x4FF0D0", Offset = "0x4FE2D0", Length = "0x20")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F6")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170001DA")]
	public Vector2 Direction
	{
		[Address(RVA = "0x4FF100", Offset = "0x4FE300", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "get_Axis", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005EF")]
		 get { } //Length: 32
	}

	[Token(Token = "0x170001E4")]
	public bool Is2DCapHoverable
	{
		[Address(RVA = "0x4FF130", Offset = "0x4FE330", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005FC")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170001E3")]
	public bool Is2DCapVisible
	{
		[Address(RVA = "0x4FF150", Offset = "0x4FE350", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005FB")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170001DF")]
	public bool IsDragged
	{
		[Address(RVA = "0x4FF170", Offset = "0x4FE370", Length = "0x93")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F7")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170001E0")]
	public bool IsMoving
	{
		[Address(RVA = "0x4FF210", Offset = "0x4FE410", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001E1")]
	public bool IsRotating
	{
		[Address(RVA = "0x4FF240", Offset = "0x4FE440", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60005F9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001E2")]
	public bool IsScaling
	{
		[Address(RVA = "0x4FF270", Offset = "0x4FE470", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005FA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001EF")]
	public GizmoLineSlider2DLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x4FF2A0", Offset = "0x4FE4A0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000608")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170001DB")]
	public Vector3 OffsetDragOrigin
	{
		[Address(RVA = "0x4FF2C0", Offset = "0x4FE4C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005F0")]
		 get { } //Length: 19
		[Address(RVA = "0x4FF480", Offset = "0x4FE680", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005F1")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170001EC")]
	public GizmoOverrideColor OverrideBorderColor
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000604")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001EB")]
	public GizmoOverrideColor OverrideFillColor
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000603")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001E6")]
	public Vector3 RelativeDragOffset
	{
		[Address(RVA = "0x4FF2E0", Offset = "0x4FE4E0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005FE")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170001E8")]
	public float RelativeDragRotation
	{
		[Address(RVA = "0x4FF310", Offset = "0x4FE510", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000600")]
		 get { } //Length: 31
	}

	[Token(Token = "0x170001EA")]
	public float RelativeDragScale
	{
		[Address(RVA = "0x4FF330", Offset = "0x4FE530", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000602")]
		 get { } //Length: 31
	}

	[Token(Token = "0x170001D7")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x4FF370", Offset = "0x4FE570", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005EB")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170001D8")]
	public float RotationDegrees
	{
		[Address(RVA = "0x4FF350", Offset = "0x4FE550", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005EC")]
		 get { } //Length: 31
	}

	[Token(Token = "0x170001DD")]
	public int ScaleDragAxisIndex
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005F4")]
		 get { } //Length: 7
		[Address(RVA = "0x4FF490", Offset = "0x4FE690", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005F5")]
		 set { } //Length: 38
	}

	[Token(Token = "0x170001DC")]
	public Vector3 ScaleDragOrigin
	{
		[Address(RVA = "0x4FF3A0", Offset = "0x4FE5A0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005F2")]
		 get { } //Length: 22
		[Address(RVA = "0x4FF4C0", Offset = "0x4FE6C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60005F3")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001ED")]
	public GizmoLineSlider2DSettings Settings
	{
		[Address(RVA = "0x4FF3C0", Offset = "0x4FE5C0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000605")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170001F0")]
	public GizmoLineSlider2DLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000609")]
		 get { } //Length: 8
		[Address(RVA = "0x4FF4E0", Offset = "0x4FE6E0", Length = "0x67")]
		[CalledBy(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "ConnectMvSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600060A")]
		 set { } //Length: 103
	}

	[Token(Token = "0x170001EE")]
	public GizmoLineSlider2DSettings SharedSettings
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000606")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000607")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170001D9")]
	public Vector2 StartPosition
	{
		[Address(RVA = "0x4FF3E0", Offset = "0x4FE5E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005ED")]
		 get { } //Length: 44
		[Address(RVA = "0x4FF550", Offset = "0x4FE750", Length = "0x21")]
		[CalledBy(Type = typeof(MoveGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005EE")]
		 set { } //Length: 33
	}

	[Token(Token = "0x170001E5")]
	public Vector3 TotalDragOffset
	{
		[Address(RVA = "0x4FF410", Offset = "0x4FE610", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005FD")]
		 get { } //Length: 41
	}

	[Token(Token = "0x170001E7")]
	public float TotalDragRotation
	{
		[Address(RVA = "0x4FF440", Offset = "0x4FE640", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60005FF")]
		 get { } //Length: 31
	}

	[Token(Token = "0x170001E9")]
	public float TotalDragScale
	{
		[Address(RVA = "0x4FF460", Offset = "0x4FE660", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000601")]
		 get { } //Length: 31
	}

	[Address(RVA = "0x4FE570", Offset = "0x4FD770", Length = "0xB51")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GizmoCap2DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap2D), Member = "RegisterTransformAsDragTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoDragSession)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreDragBeginAttempt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreDragBeginAttemptHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreDragUpdateHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add2DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHoverEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHoverEnterHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHoverExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHoverExitHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(QuadShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SegmentShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Token(Token = "0x600060B")]
	public GizmoLineSlider2D(Gizmo gizmo, int handleId, int capHandleId) { }

	[Address(RVA = "0x4FCBF0", Offset = "0x4FBDF0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000616")]
	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x4FCB90", Offset = "0x4FBD90", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000615")]
	public void AddTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x4FF0D0", Offset = "0x4FE2D0", Length = "0x20")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F6")]
	public int get_Cap2DHandleId() { }

	[Address(RVA = "0x4FF100", Offset = "0x4FE300", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "get_Axis", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005EF")]
	public Vector2 get_Direction() { }

	[Address(RVA = "0x4FF130", Offset = "0x4FE330", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005FC")]
	public bool get_Is2DCapHoverable() { }

	[Address(RVA = "0x4FF150", Offset = "0x4FE350", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005FB")]
	public bool get_Is2DCapVisible() { }

	[Address(RVA = "0x4FF170", Offset = "0x4FE370", Length = "0x93")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F7")]
	public bool get_IsDragged() { }

	[Address(RVA = "0x4FF210", Offset = "0x4FE410", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F8")]
	public bool get_IsMoving() { }

	[Address(RVA = "0x4FF240", Offset = "0x4FE440", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60005F9")]
	public bool get_IsRotating() { }

	[Address(RVA = "0x4FF270", Offset = "0x4FE470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005FA")]
	public bool get_IsScaling() { }

	[Address(RVA = "0x4FF2A0", Offset = "0x4FE4A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000608")]
	public GizmoLineSlider2DLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x4FF2C0", Offset = "0x4FE4C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005F0")]
	public Vector3 get_OffsetDragOrigin() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000604")]
	public GizmoOverrideColor get_OverrideBorderColor() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000603")]
	public GizmoOverrideColor get_OverrideFillColor() { }

	[Address(RVA = "0x4FF2E0", Offset = "0x4FE4E0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FE")]
	public Vector3 get_RelativeDragOffset() { }

	[Address(RVA = "0x4FF310", Offset = "0x4FE510", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000600")]
	public float get_RelativeDragRotation() { }

	[Address(RVA = "0x4FF330", Offset = "0x4FE530", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000602")]
	public float get_RelativeDragScale() { }

	[Address(RVA = "0x4FF370", Offset = "0x4FE570", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005EB")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x4FF350", Offset = "0x4FE550", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005EC")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005F4")]
	public int get_ScaleDragAxisIndex() { }

	[Address(RVA = "0x4FF3A0", Offset = "0x4FE5A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005F2")]
	public Vector3 get_ScaleDragOrigin() { }

	[Address(RVA = "0x4FF3C0", Offset = "0x4FE5C0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000605")]
	public GizmoLineSlider2DSettings get_Settings() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000609")]
	public GizmoLineSlider2DLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000606")]
	public GizmoLineSlider2DSettings get_SharedSettings() { }

	[Address(RVA = "0x4FF3E0", Offset = "0x4FE5E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005ED")]
	public Vector2 get_StartPosition() { }

	[Address(RVA = "0x4FF410", Offset = "0x4FE610", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FD")]
	public Vector3 get_TotalDragOffset() { }

	[Address(RVA = "0x4FF440", Offset = "0x4FE640", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005FF")]
	public float get_TotalDragRotation() { }

	[Address(RVA = "0x4FF460", Offset = "0x4FE660", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000601")]
	public float get_TotalDragScale() { }

	[Address(RVA = "0x4FCC40", Offset = "0x4FBE40", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000612")]
	public float GetRealBoxThickness() { }

	[Address(RVA = "0x4FCC90", Offset = "0x4FBE90", Length = "0xA1")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnVisibilityStateChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "get_Axis", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600060F")]
	public Vector2 GetRealDirection() { }

	[Address(RVA = "0x4FCD40", Offset = "0x4FBF40", Length = "0x84")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnVisibilityStateChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "get_Axis", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealLength", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000611")]
	public Vector2 GetRealEndPosition() { }

	[Address(RVA = "0x4FCDD0", Offset = "0x4FBFD0", Length = "0x21E")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Vector3Ex), Member = "ConvertDirTo2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000610")]
	public float GetRealLength() { }

	[Address(RVA = "0x4FCFF0", Offset = "0x4FC1F0", Length = "0x63")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "Map", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000613")]
	public void MapDirection(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x4FD060", Offset = "0x4FC260", Length = "0x4C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Vector2Ex), Member = "ConvertDirTo3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealLength", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisOffsetDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600061F")]
	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x4FD530", Offset = "0x4FC730", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmo), Member = "get_RelativeDragRotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "Rotate2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000623")]
	private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x4FD5C0", Offset = "0x4FC7C0", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000621")]
	private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x4FD770", Offset = "0x4FC970", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000622")]
	private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x4FD800", Offset = "0x4FCA00", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoCap2D), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000625")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x4FD990", Offset = "0x4FCB90", Length = "0x277")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GizmoSlider), Member = "get_HoverPriority3D", ReturnType = typeof(Priority))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoCap2D), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600061E")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x4FDC10", Offset = "0x4FCE10", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600061D")]
	protected virtual void OnHoverableStateChanged() { }

	[Address(RVA = "0x4FDC40", Offset = "0x4FCE40", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoCap2D), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000620")]
	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x4FDD30", Offset = "0x4FCF30", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoCap2D), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600061C")]
	protected virtual void OnVisibilityStateChanged() { }

	[Address(RVA = "0x4FD800", Offset = "0x4FCA00", Length = "0x181")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoCap2D), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x600061B")]
	public void Refresh() { }

	[Address(RVA = "0x4FDEC0", Offset = "0x4FD0C0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000617")]
	public void RemoveTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x4FDF20", Offset = "0x4FD120", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000618")]
	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x4FDF70", Offset = "0x4FD170", Length = "0x425")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DSolid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc2DLookAndFeel), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600061A")]
	public virtual void Render(Camera camera) { }

	[Address(RVA = "0x4FF480", Offset = "0x4FE680", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005F1")]
	public void set_OffsetDragOrigin(Vector3 value) { }

	[Address(RVA = "0x4FF490", Offset = "0x4FE690", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005F5")]
	public void set_ScaleDragAxisIndex(int value) { }

	[Address(RVA = "0x4FF4C0", Offset = "0x4FE6C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60005F3")]
	public void set_ScaleDragOrigin(Vector3 value) { }

	[Address(RVA = "0x4FF4E0", Offset = "0x4FE6E0", Length = "0x67")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel2D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel2D), Member = "ConnectMvSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider2D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600060A")]
	public void set_SharedLookAndFeel(GizmoLineSlider2DLookAndFeel value) { }

	[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000607")]
	public void set_SharedSettings(GizmoLineSlider2DSettings value) { }

	[Address(RVA = "0x4FF550", Offset = "0x4FE750", Length = "0x21")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005EE")]
	public void set_StartPosition(Vector2 value) { }

	[Address(RVA = "0x4FE3A0", Offset = "0x4FD5A0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600060E")]
	public void Set2DCapHoverable(bool isHoverable) { }

	[Address(RVA = "0x4FE3D0", Offset = "0x4FD5D0", Length = "0x21")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600060D")]
	public void Set2DCapVisible(bool isVisible) { }

	[Address(RVA = "0x4FE400", Offset = "0x4FD600", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000614")]
	public void SetDirection(Vector2 directionAxis) { }

	[Address(RVA = "0x4FE450", Offset = "0x4FD650", Length = "0x80")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000619")]
	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x4FE4E0", Offset = "0x4FD6E0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600060C")]
	public virtual void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x4FE520", Offset = "0x4FD720", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000624")]
	private void SetupSharedLookAndFeel() { }

}


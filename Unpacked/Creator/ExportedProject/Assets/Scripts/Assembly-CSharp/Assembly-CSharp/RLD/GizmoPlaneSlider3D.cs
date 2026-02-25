namespace RLD;

[Token(Token = "0x20000C9")]
public class GizmoPlaneSlider3D : GizmoSlider
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031C")]
	private int _quadIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400031D")]
	private int _raTriangleIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400031E")]
	private int _circleIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400031F")]
	private QuadShape3D _quad; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000320")]
	private RightAngTriangle3D _raTriangle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000321")]
	private CircleShape3D _circle; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000322")]
	private GizmoQuad3DBorder _quadBorder; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000323")]
	private GizmoRATriangle3DBorder _raTriangleBorder; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000324")]
	private GizmoCircle3DBorder _circleBorder; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000325")]
	private bool _isBorderHoverable; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000326")]
	private bool _isBorderVisible; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000327")]
	private GizmoTransform _transform; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000328")]
	private GizmoDragChannel _dragChannel; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000329")]
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400032A")]
	private GizmoDblAxisOffsetDrag3D _dblAxisOffsetDrag; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400032B")]
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400032C")]
	private GizmoRotationArc3D _rotationArc; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400032D")]
	private GizmoDblAxisScaleDrag3D _scaleDrag; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400032E")]
	private int _scaleDragAxisIndexRight; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400032F")]
	private int _scaleDragAxisIndexUp; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000330")]
	private GizmoPlaneSlider3DControllerData _controllerData; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000331")]
	private IGizmoPlaneSlider3DController[] _controllers; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000332")]
	private GizmoPlaneSlider3DSettings _settings; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000333")]
	private GizmoPlaneSlider3DSettings _sharedSettings; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000334")]
	private GizmoPlaneSlider3DLookAndFeel _lookAndFeel; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000335")]
	private GizmoPlaneSlider3DLookAndFeel _sharedLookAndFeel; //Field offset: 0xD8

	[Token(Token = "0x17000280")]
	public GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007BF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700028C")]
	public bool IsBorderHoverable
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700028B")]
	public bool IsBorderVisible
	{
		[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700028D")]
	public bool IsDragged
	{
		[Address(RVA = "0x5073F0", Offset = "0x5065F0", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CE")]
		 get { } //Length: 89
	}

	[Token(Token = "0x1700028E")]
	public bool IsMoving
	{
		[Address(RVA = "0x507450", Offset = "0x506650", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CF")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700028F")]
	public bool IsRotating
	{
		[Address(RVA = "0x50C190", Offset = "0x50B390", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007D0")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000290")]
	public bool IsScaling
	{
		[Address(RVA = "0x507480", Offset = "0x506680", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007D1")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700027B")]
	public Quaternion LocalRotation
	{
		[Address(RVA = "0x50C1C0", Offset = "0x50B3C0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007B9")]
		 get { } //Length: 33
		[Address(RVA = "0x50C540", Offset = "0x50B740", Length = "0x2C")]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_LocalRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007BA")]
		 set { } //Length: 44
	}

	[Token(Token = "0x1700027E")]
	public Vector3 Look
	{
		[Address(RVA = "0x50C210", Offset = "0x50B410", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007BD")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000276")]
	public GizmoPlaneSlider3DLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x50C1F0", Offset = "0x50B3F0", Length = "0x1A")]
		[CallerCount(Count = 60)]
		[Token(Token = "0x60007B1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700027F")]
	public Vector3 Normal
	{
		[Address(RVA = "0x50C210", Offset = "0x50B410", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007BE")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000278")]
	public Plane Plane
	{
		[Address(RVA = "0x50C260", Offset = "0x50B460", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007B4")]
		 get { } //Length: 213
	}

	[Token(Token = "0x17000279")]
	public Vector3 Position
	{
		[Address(RVA = "0x50C340", Offset = "0x50B540", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007B5")]
		 get { } //Length: 41
		[Address(RVA = "0x50C570", Offset = "0x50B770", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007B6")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000284")]
	public Vector3 RelativeDragOffset
	{
		[Address(RVA = "0x5075C0", Offset = "0x5067C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007C5")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000286")]
	public float RelativeDragRotation
	{
		[Address(RVA = "0x50C370", Offset = "0x50B570", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007C7")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000288")]
	public float RelativeDragScaleRight
	{
		[Address(RVA = "0x50C3A0", Offset = "0x50B5A0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007C9")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700028A")]
	public float RelativeDragScaleUp
	{
		[Address(RVA = "0x5075F0", Offset = "0x5067F0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007CB")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700027C")]
	public Vector3 Right
	{
		[Address(RVA = "0x50C3D0", Offset = "0x50B5D0", Length = "0x47")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007BB")]
		 get { } //Length: 71
	}

	[Token(Token = "0x1700027A")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x50C420", Offset = "0x50B620", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 33
		[Address(RVA = "0x50C5B0", Offset = "0x50B7B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007B8")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000281")]
	public int ScaleDragAxisIndexRight
	{
		[Address(RVA = "0x50C450", Offset = "0x50B650", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007C0")]
		 get { } //Length: 7
		[Address(RVA = "0x50C5E0", Offset = "0x50B7E0", Length = "0x26")]
		[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60007C1")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000282")]
	public int ScaleDragAxisIndexUp
	{
		[Address(RVA = "0x50C460", Offset = "0x50B660", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007C2")]
		 get { } //Length: 7
		[Address(RVA = "0x50C610", Offset = "0x50B810", Length = "0x26")]
		[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60007C3")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000274")]
	public GizmoPlaneSlider3DSettings Settings
	{
		[Address(RVA = "0x50C470", Offset = "0x50B670", Length = "0x1A")]
		[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinRATriangle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Token(Token = "0x60007AE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000277")]
	public GizmoPlaneSlider3DLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B2")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD560", Offset = "0x2DC760", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B3")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000275")]
	public GizmoPlaneSlider3DSettings SharedSettings
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007AF")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007B0")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000283")]
	public Vector3 TotalDragOffset
	{
		[Address(RVA = "0x507760", Offset = "0x506960", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007C4")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000285")]
	public float TotalDragRotation
	{
		[Address(RVA = "0x50C490", Offset = "0x50B690", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007C6")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000287")]
	public float TotalDragScaleRight
	{
		[Address(RVA = "0x507790", Offset = "0x506990", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007C8")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000289")]
	public float TotalDragScaleUp
	{
		[Address(RVA = "0x50C4C0", Offset = "0x50B6C0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007CA")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700027D")]
	public Vector3 Up
	{
		[Address(RVA = "0x50C4F0", Offset = "0x50B6F0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60007BC")]
		 get { } //Length: 74
	}

	[Address(RVA = "0x50B540", Offset = "0x50A740", Length = "0xC49")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(RightAngTriangle3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreDragBeginAttempt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreDragBeginAttemptHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandleCanHoverHandler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(QuadShape3D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add3DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape3D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoDblAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CircleShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RightAngTriangle3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(QuadShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Token(Token = "0x60007D2")]
	public GizmoPlaneSlider3D(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x509030", Offset = "0x508230", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E6")]
	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x509080", Offset = "0x508280", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E5")]
	public void AddTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x5090F0", Offset = "0x5082F0", Length = "0x1B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoTransform), Member = "GetPlane3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlaneIdHelper), Member = "GetFirstAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(AxisDescriptor))]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisDescriptor)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneIdHelper), Member = "GetSecondAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(AxisDescriptor))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007DF")]
	public void AlignToQuadrant(GizmoTransform transform, PlaneId planeId, PlaneQuadrantId quadrantId, bool alignXToFirstAxis) { }

	[Address(RVA = "0x5092B0", Offset = "0x5084B0", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007E3")]
	public void ApplyZoomFactor(Camera camera) { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BF")]
	public GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CD")]
	public bool get_IsBorderHoverable() { }

	[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CC")]
	public bool get_IsBorderVisible() { }

	[Address(RVA = "0x5073F0", Offset = "0x5065F0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CE")]
	public bool get_IsDragged() { }

	[Address(RVA = "0x507450", Offset = "0x506650", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CF")]
	public bool get_IsMoving() { }

	[Address(RVA = "0x50C190", Offset = "0x50B390", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007D0")]
	public bool get_IsRotating() { }

	[Address(RVA = "0x507480", Offset = "0x506680", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D1")]
	public bool get_IsScaling() { }

	[Address(RVA = "0x50C1C0", Offset = "0x50B3C0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B9")]
	public Quaternion get_LocalRotation() { }

	[Address(RVA = "0x50C210", Offset = "0x50B410", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BD")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x50C1F0", Offset = "0x50B3F0", Length = "0x1A")]
	[CallerCount(Count = 60)]
	[Token(Token = "0x60007B1")]
	public GizmoPlaneSlider3DLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x50C210", Offset = "0x50B410", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BE")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x50C260", Offset = "0x50B460", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B4")]
	public Plane get_Plane() { }

	[Address(RVA = "0x50C340", Offset = "0x50B540", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B5")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x5075C0", Offset = "0x5067C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C5")]
	public Vector3 get_RelativeDragOffset() { }

	[Address(RVA = "0x50C370", Offset = "0x50B570", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007C7")]
	public float get_RelativeDragRotation() { }

	[Address(RVA = "0x50C3A0", Offset = "0x50B5A0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007C9")]
	public float get_RelativeDragScaleRight() { }

	[Address(RVA = "0x5075F0", Offset = "0x5067F0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007CB")]
	public float get_RelativeDragScaleUp() { }

	[Address(RVA = "0x50C3D0", Offset = "0x50B5D0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007BB")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x50C420", Offset = "0x50B620", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B7")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x50C450", Offset = "0x50B650", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C0")]
	public int get_ScaleDragAxisIndexRight() { }

	[Address(RVA = "0x50C460", Offset = "0x50B660", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C2")]
	public int get_ScaleDragAxisIndexUp() { }

	[Address(RVA = "0x50C470", Offset = "0x50B670", Length = "0x1A")]
	[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinRATriangle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x60007AE")]
	public GizmoPlaneSlider3DSettings get_Settings() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B2")]
	public GizmoPlaneSlider3DLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AF")]
	public GizmoPlaneSlider3DSettings get_SharedSettings() { }

	[Address(RVA = "0x507760", Offset = "0x506960", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C4")]
	public Vector3 get_TotalDragOffset() { }

	[Address(RVA = "0x50C490", Offset = "0x50B690", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007C6")]
	public float get_TotalDragRotation() { }

	[Address(RVA = "0x507790", Offset = "0x506990", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007C8")]
	public float get_TotalDragScaleRight() { }

	[Address(RVA = "0x50C4C0", Offset = "0x50B6C0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007CA")]
	public float get_TotalDragScaleUp() { }

	[Address(RVA = "0x50C4F0", Offset = "0x50B6F0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007BC")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x509390", Offset = "0x508590", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape3D), Member = "GetCornerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuadCorner)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E1")]
	public Vector3 GetQuadCornerPosition(QuadCorner corner) { }

	[Address(RVA = "0x5093D0", Offset = "0x5085D0", Length = "0x112")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DB")]
	public float GetRealCircleRadius(float zoomFactor) { }

	[Address(RVA = "0x5094F0", Offset = "0x5086F0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007D9")]
	public float GetRealQuadHeight(float zoomFactor) { }

	[Address(RVA = "0x5095E0", Offset = "0x5087E0", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DA")]
	public Vector2 GetRealQuadSize(float zoomFactor) { }

	[Address(RVA = "0x509720", Offset = "0x508920", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007D8")]
	public float GetRealQuadWidth(float zoomFactor) { }

	[Address(RVA = "0x509810", Offset = "0x508A10", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DE")]
	public Vector2 GetRealRATriSize(float zoomFactor) { }

	[Address(RVA = "0x509950", Offset = "0x508B50", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DC")]
	public float GetRealRATriXLength(float zoomFactor) { }

	[Address(RVA = "0x509A40", Offset = "0x508C40", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007DD")]
	public float GetRealRATriYLength(float zoomFactor) { }

	[Address(RVA = "0x509B30", Offset = "0x508D30", Length = "0x52")]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = "OnQuadShapeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = "OnTriangleShapeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "OnCircleShapeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Token(Token = "0x60007D7")]
	public float GetZoomFactor(Camera camera) { }

	[Address(RVA = "0x509B90", Offset = "0x508D90", Length = "0x3DB")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "PlaceDblSlidersInSliderPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "PlaceDblSlidersInSliderPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "PlaceMvDblSlidersInSliderPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetPlane3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(Plane))]
	[Calls(Type = typeof(QuadShape3D), Member = "GetCornerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuadCorner)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(PlaneIdHelper), Member = "GetFirstAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(AxisDescriptor))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AxisDescriptor)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "Get3DQuadrantFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(Camera)}, ReturnType = typeof(PlaneQuadrantId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PlaneIdHelper), Member = "GetSecondAxisDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(AxisDescriptor))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007E0")]
	public void MakeSliderPlane(GizmoTransform sliderPlaneTransform, PlaneId planeId, GizmoLineSlider3D firstAxisSlider, GizmoLineSlider3D secondAxisSlider, Camera camera) { }

	[Address(RVA = "0x509F70", Offset = "0x509170", Length = "0x1EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "IsPointFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60007F0")]
	private void OnCanHoverHandle(int handleId, Gizmo gizmo, GizmoHandleHoverData hoverData, YesNoAnswer answer) { }

	[Address(RVA = "0x50A160", Offset = "0x509360", Length = "0x57A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoDblAxisScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetRealCircleRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoDblAxisOffsetDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007EF")]
	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x50A6E0", Offset = "0x5098E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "Refresh", ReturnType = typeof(void))]
	[Token(Token = "0x60007F1")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x50A6F0", Offset = "0x5098F0", Length = "0x226")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60007ED")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x50A920", Offset = "0x509B20", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007EC")]
	protected virtual void OnHoverableStateChanged() { }

	[Address(RVA = "0x50A980", Offset = "0x509B80", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007EE")]
	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x50AA90", Offset = "0x509C90", Length = "0x1A7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007EB")]
	protected virtual void OnVisibilityStateChanged() { }

	[Address(RVA = "0x50AC40", Offset = "0x509E40", Length = "0x1AA")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007EA")]
	public void Refresh() { }

	[Address(RVA = "0x50ADF0", Offset = "0x509FF0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E7")]
	public void RemoveTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x50AE60", Offset = "0x50A060", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E8")]
	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x50AEB0", Offset = "0x50A0B0", Length = "0x3F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetCullModeOff", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DSolid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLightDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "get_IsLit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoSlider), Member = "get_IsHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetRealCircleRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007E9")]
	public virtual void Render(Camera camera) { }

	[Address(RVA = "0x50C540", Offset = "0x50B740", Length = "0x2C")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_LocalRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007BA")]
	public void set_LocalRotation(Quaternion value) { }

	[Address(RVA = "0x50C570", Offset = "0x50B770", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B6")]
	public void set_Position(Vector3 value) { }

	[Address(RVA = "0x50C5B0", Offset = "0x50B7B0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007B8")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x50C5E0", Offset = "0x50B7E0", Length = "0x26")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60007C1")]
	public void set_ScaleDragAxisIndexRight(int value) { }

	[Address(RVA = "0x50C610", Offset = "0x50B810", Length = "0x26")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60007C3")]
	public void set_ScaleDragAxisIndexUp(int value) { }

	[Address(RVA = "0x2DD560", Offset = "0x2DC760", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B3")]
	public void set_SharedLookAndFeel(GizmoPlaneSlider3DLookAndFeel value) { }

	[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B0")]
	public void set_SharedSettings(GizmoPlaneSlider3DSettings value) { }

	[Address(RVA = "0x50B2B0", Offset = "0x50A4B0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007D4")]
	public void SetBorderHoverable(bool isHoverable) { }

	[Address(RVA = "0x50B310", Offset = "0x50A510", Length = "0x97")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetBorderVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007D3")]
	public void SetBorderVisible(bool isVisible) { }

	[Address(RVA = "0x50B3B0", Offset = "0x50A5B0", Length = "0x6B")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E4")]
	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x50B420", Offset = "0x50A620", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape3D), Member = "GetCornerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuadCorner)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007E2")]
	public void SetQuadCornerPosition(QuadCorner corner, Vector3 cornerPosition) { }

	[Address(RVA = "0x50B500", Offset = "0x50A700", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007D5")]
	public virtual void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x503480", Offset = "0x502680", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetZoomFactorTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D6")]
	public void SetZoomFactorTransform(GizmoTransform transform) { }

}


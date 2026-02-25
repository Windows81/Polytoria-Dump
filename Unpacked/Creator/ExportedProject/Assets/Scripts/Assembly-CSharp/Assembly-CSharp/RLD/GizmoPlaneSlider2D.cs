namespace RLD;

[Token(Token = "0x20000AE")]
public class GizmoPlaneSlider2D : GizmoSlider
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000288")]
	private int _quadIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000289")]
	private int _circleIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400028A")]
	private int _polygonIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400028B")]
	private QuadShape2D _quad; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400028C")]
	private CircleShape2D _circle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400028D")]
	private PolygonShape2D _polygon; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400028E")]
	private GizmoQuad2DBorder _quadBorder; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400028F")]
	private GizmoCircle2DBorder _circleBorder; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000290")]
	private GizmoPolygon2DBorder _polygonBorder; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000291")]
	private bool _isBorderVisible; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000292")]
	private bool _isBorderHoverable; //Field offset: 0x69
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000293")]
	private GizmoTransform _transform; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000294")]
	private GizmoDragChannel _dragChannel; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000295")]
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000296")]
	private GizmoDblAxisOffsetDrag3D _offsetDrag; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000297")]
	private Vector3 _offsetDragOrigin; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000298")]
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000299")]
	private GizmoRotationArc2D _rotationArc; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400029A")]
	private GizmoDblAxisScaleDrag3D _scaleDrag; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400029B")]
	private Vector3 _scaleDragOrigin; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400029C")]
	private Vector3 _scaleAxisRight; //Field offset: 0xC4
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400029D")]
	private Vector3 _scaleAxisUp; //Field offset: 0xD0
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x400029E")]
	private int _scaleDragAxisIndexRight; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400029F")]
	private int _scaleDragAxisIndexUp; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40002A0")]
	private GizmoPlaneSlider2DControllerData _controllerData; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40002A1")]
	private IGizmoPlaneSlider2DController[] _controllers; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40002A2")]
	private GizmoPlaneSlider2DSettings _settings; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40002A3")]
	private GizmoPlaneSlider2DSettings _sharedSettings; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40002A4")]
	private GizmoPlaneSlider2DLookAndFeel _lookAndFeel; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40002A5")]
	private GizmoPlaneSlider2DLookAndFeel _sharedLookAndFeel; //Field offset: 0x110

	[Token(Token = "0x17000213")]
	public GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000682")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000220")]
	public bool IsBorderHoverable
	{
		[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000692")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700021F")]
	public bool IsBorderVisible
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000691")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000221")]
	public bool IsDragged
	{
		[Address(RVA = "0x5073F0", Offset = "0x5065F0", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000693")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000222")]
	public bool IsMoving
	{
		[Address(RVA = "0x507450", Offset = "0x506650", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000694")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000223")]
	public bool IsRotating
	{
		[Address(RVA = "0x507480", Offset = "0x506680", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000695")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000224")]
	public bool IsScaling
	{
		[Address(RVA = "0x5074B0", Offset = "0x5066B0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000696")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700020A")]
	public GizmoPlaneSlider2DLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x5074E0", Offset = "0x5066E0", Length = "0x1A")]
		[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "OnPolygonShapeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "OnQuadShapeChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Token(Token = "0x6000675")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000212")]
	public Vector3 OffsetDragOrigin
	{
		[Address(RVA = "0x507500", Offset = "0x506700", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000680")]
		 get { } //Length: 25
		[Address(RVA = "0x507850", Offset = "0x506A50", Length = "0x16")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000681")]
		 set { } //Length: 22
	}

	[Token(Token = "0x1700020D")]
	public Vector2 PolyCenter
	{
		[Address(RVA = "0x507520", Offset = "0x506720", Length = "0x64")]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600067A")]
		 get { } //Length: 100
	}

	[Token(Token = "0x1700020C")]
	public Vector2 Position
	{
		[Address(RVA = "0x507590", Offset = "0x506790", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000678")]
		 get { } //Length: 41
		[Address(RVA = "0x507870", Offset = "0x506A70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000679")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000218")]
	public Vector3 RelativeDragOffset
	{
		[Address(RVA = "0x5075C0", Offset = "0x5067C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600068A")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700021A")]
	public float RelativeDragRotation
	{
		[Address(RVA = "0x5075F0", Offset = "0x5067F0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600068C")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700021C")]
	public float RelativeDragScaleRight
	{
		[Address(RVA = "0x507620", Offset = "0x506820", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600068E")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700021E")]
	public float RelativeDragScaleUp
	{
		[Address(RVA = "0x507650", Offset = "0x506850", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000690")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000210")]
	public Vector2 Right
	{
		[Address(RVA = "0x507680", Offset = "0x506880", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600067E")]
		 get { } //Length: 35
	}

	[Token(Token = "0x1700020E")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x5076D0", Offset = "0x5068D0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600067B")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700020F")]
	public float RotationDegrees
	{
		[Address(RVA = "0x5076B0", Offset = "0x5068B0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600067C")]
		 get { } //Length: 28
		[Address(RVA = "0x507890", Offset = "0x506A90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation2DDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600067D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000215")]
	public int ScaleDragAxisIndexRight
	{
		[Address(RVA = "0x507700", Offset = "0x506900", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000685")]
		 get { } //Length: 7
		[Address(RVA = "0x5078B0", Offset = "0x506AB0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000686")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000216")]
	public int ScaleDragAxisIndexUp
	{
		[Address(RVA = "0x507710", Offset = "0x506910", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000687")]
		 get { } //Length: 7
		[Address(RVA = "0x5078E0", Offset = "0x506AE0", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000688")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000214")]
	public Vector3 ScaleDragOrigin
	{
		[Address(RVA = "0x507720", Offset = "0x506920", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000683")]
		 get { } //Length: 25
		[Address(RVA = "0x507910", Offset = "0x506B10", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000684")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000208")]
	public GizmoPlaneSlider2DSettings Settings
	{
		[Address(RVA = "0x507740", Offset = "0x506940", Length = "0x1A")]
		[CalledBy(Type = typeof(GizmoThinCircle2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinPolygon2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Token(Token = "0x6000672")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700020B")]
	public GizmoPlaneSlider2DLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000676")]
		 get { } //Length: 8
		[Address(RVA = "0x507930", Offset = "0x506B30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000677")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000209")]
	public GizmoPlaneSlider2DSettings SharedSettings
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000673")]
		 get { } //Length: 8
		[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000674")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000217")]
	public Vector3 TotalDragOffset
	{
		[Address(RVA = "0x507760", Offset = "0x506960", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000689")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000219")]
	public float TotalDragRotation
	{
		[Address(RVA = "0x507790", Offset = "0x506990", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600068B")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700021B")]
	public float TotalDragScaleRight
	{
		[Address(RVA = "0x5077C0", Offset = "0x5069C0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600068D")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700021D")]
	public float TotalDragScaleUp
	{
		[Address(RVA = "0x5077F0", Offset = "0x5069F0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600068F")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000211")]
	public Vector2 Up
	{
		[Address(RVA = "0x507820", Offset = "0x506A20", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "GetAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600067F")]
		 get { } //Length: 38
	}

	[Address(RVA = "0x506830", Offset = "0x505A30", Length = "0xBA6")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GizmoQuad2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(QuadShape2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(CircleShape2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(PolygonShape2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreDragUpdateHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add2DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreDragBeginAttempt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreDragBeginAttemptHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoDblAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PolygonShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CircleShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(QuadShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Token(Token = "0x6000697")]
	public GizmoPlaneSlider2D(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x5048A0", Offset = "0x503AA0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A4")]
	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x504830", Offset = "0x503A30", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A3")]
	public void AddTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x3B8640", Offset = "0x3B7840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000682")]
	public GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x5073E0", Offset = "0x5065E0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000692")]
	public bool get_IsBorderHoverable() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000691")]
	public bool get_IsBorderVisible() { }

	[Address(RVA = "0x5073F0", Offset = "0x5065F0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000693")]
	public bool get_IsDragged() { }

	[Address(RVA = "0x507450", Offset = "0x506650", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000694")]
	public bool get_IsMoving() { }

	[Address(RVA = "0x507480", Offset = "0x506680", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000695")]
	public bool get_IsRotating() { }

	[Address(RVA = "0x5074B0", Offset = "0x5066B0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000696")]
	public bool get_IsScaling() { }

	[Address(RVA = "0x5074E0", Offset = "0x5066E0", Length = "0x1A")]
	[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "OnPolygonShapeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygon2DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "OnQuadShapeChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Token(Token = "0x6000675")]
	public GizmoPlaneSlider2DLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x507500", Offset = "0x506700", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000680")]
	public Vector3 get_OffsetDragOrigin() { }

	[Address(RVA = "0x507520", Offset = "0x506720", Length = "0x64")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600067A")]
	public Vector2 get_PolyCenter() { }

	[Address(RVA = "0x507590", Offset = "0x506790", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000678")]
	public Vector2 get_Position() { }

	[Address(RVA = "0x5075C0", Offset = "0x5067C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600068A")]
	public Vector3 get_RelativeDragOffset() { }

	[Address(RVA = "0x5075F0", Offset = "0x5067F0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600068C")]
	public float get_RelativeDragRotation() { }

	[Address(RVA = "0x507620", Offset = "0x506820", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600068E")]
	public float get_RelativeDragScaleRight() { }

	[Address(RVA = "0x507650", Offset = "0x506850", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000690")]
	public float get_RelativeDragScaleUp() { }

	[Address(RVA = "0x507680", Offset = "0x506880", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067E")]
	public Vector2 get_Right() { }

	[Address(RVA = "0x5076D0", Offset = "0x5068D0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067B")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5076B0", Offset = "0x5068B0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067C")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x507700", Offset = "0x506900", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000685")]
	public int get_ScaleDragAxisIndexRight() { }

	[Address(RVA = "0x507710", Offset = "0x506910", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000687")]
	public int get_ScaleDragAxisIndexUp() { }

	[Address(RVA = "0x507720", Offset = "0x506920", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000683")]
	public Vector3 get_ScaleDragOrigin() { }

	[Address(RVA = "0x507740", Offset = "0x506940", Length = "0x1A")]
	[CalledBy(Type = typeof(GizmoThinCircle2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThickPolygon2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinPolygon2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000672")]
	public GizmoPlaneSlider2DSettings get_Settings() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000676")]
	public GizmoPlaneSlider2DLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000673")]
	public GizmoPlaneSlider2DSettings get_SharedSettings() { }

	[Address(RVA = "0x507760", Offset = "0x506960", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000689")]
	public Vector3 get_TotalDragOffset() { }

	[Address(RVA = "0x507790", Offset = "0x506990", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600068B")]
	public float get_TotalDragRotation() { }

	[Address(RVA = "0x5077C0", Offset = "0x5069C0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600068D")]
	public float get_TotalDragScaleRight() { }

	[Address(RVA = "0x5077F0", Offset = "0x5069F0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600068F")]
	public float get_TotalDragScaleUp() { }

	[Address(RVA = "0x507820", Offset = "0x506A20", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "GetAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067F")]
	public Vector2 get_Up() { }

	[Address(RVA = "0x5048F0", Offset = "0x503AF0", Length = "0x248")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Vector3Ex), Member = "ConvertDirTo2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A0")]
	public float GetRealCircleRadius() { }

	[Address(RVA = "0x504B40", Offset = "0x503D40", Length = "0x108")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Update2DModeHandlePositions", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A1")]
	public Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x504C50", Offset = "0x503E50", Length = "0x232")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadSize", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Vector3Ex), Member = "ConvertDirTo2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600069E")]
	public float GetRealQuadHeight() { }

	[Address(RVA = "0x504E90", Offset = "0x504090", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadHeight", ReturnType = typeof(float))]
	[Token(Token = "0x600069F")]
	public Vector2 GetRealQuadSize() { }

	[Address(RVA = "0x504ED0", Offset = "0x5040D0", Length = "0x232")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadSize", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Vector3Ex), Member = "ConvertDirTo2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600069D")]
	public float GetRealQuadWidth() { }

	[Address(RVA = "0x505110", Offset = "0x504310", Length = "0xF1")]
	[CalledBy(Type = typeof(RotationGizmo), Member = "UpdateCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "UpdateRtCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PolygonShape2D), Member = "MakeSphereBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(int), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600069C")]
	public void MakePolySphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera) { }

	[Address(RVA = "0x505210", Offset = "0x504410", Length = "0x853")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Ex), Member = "ConvertDirTo3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "get_Right2D", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealCircleRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "set_NumProjectedPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_PolyCenter", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "get_Up2D", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoDblAxisScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Ex), Member = "ConvertDirTo3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoDblAxisOffsetDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006AD")]
	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x505A70", Offset = "0x504C70", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "Rotate2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006AE")]
	private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x505AD0", Offset = "0x504CD0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AF")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x505C10", Offset = "0x504E10", Length = "0x1AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60006AB")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x505DC0", Offset = "0x504FC0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006AA")]
	protected virtual void OnHoverableStateChanged() { }

	[Address(RVA = "0x505E10", Offset = "0x505010", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006AC")]
	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x505EC0", Offset = "0x5050C0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006A9")]
	protected virtual void OnVisibilityStateChanged() { }

	[Address(RVA = "0x505AD0", Offset = "0x504CD0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A8")]
	public void Refresh() { }

	[Address(RVA = "0x506000", Offset = "0x505200", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A6")]
	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x506050", Offset = "0x505250", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A5")]
	public void RemoveTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x5060C0", Offset = "0x5052C0", Length = "0x4E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DSolid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc2DLookAndFeel), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc2D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoQuad2DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006A7")]
	public virtual void Render(Camera camera) { }

	[Address(RVA = "0x507850", Offset = "0x506A50", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000681")]
	public void set_OffsetDragOrigin(Vector3 value) { }

	[Address(RVA = "0x507870", Offset = "0x506A70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000679")]
	public void set_Position(Vector2 value) { }

	[Address(RVA = "0x507890", Offset = "0x506A90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation2DDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600067D")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x5078B0", Offset = "0x506AB0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000686")]
	public void set_ScaleDragAxisIndexRight(int value) { }

	[Address(RVA = "0x5078E0", Offset = "0x506AE0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000688")]
	public void set_ScaleDragAxisIndexUp(int value) { }

	[Address(RVA = "0x507910", Offset = "0x506B10", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000684")]
	public void set_ScaleDragOrigin(Vector3 value) { }

	[Address(RVA = "0x507930", Offset = "0x506B30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000677")]
	public void set_SharedLookAndFeel(GizmoPlaneSlider2DLookAndFeel value) { }

	[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000674")]
	public void set_SharedSettings(GizmoPlaneSlider2DSettings value) { }

	[Address(RVA = "0x5065B0", Offset = "0x5057B0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000699")]
	public void SetBorderHoverable(bool isHoverable) { }

	[Address(RVA = "0x506620", Offset = "0x505820", Length = "0x97")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Hide2DModeHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Hide2DModeHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetRotationHandlesVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000698")]
	public void SetBorderVisible(bool isVisible) { }

	[Address(RVA = "0x5066C0", Offset = "0x5058C0", Length = "0x6B")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A2")]
	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x506730", Offset = "0x505930", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PolygonShape2D), Member = "SetClockwisePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600069B")]
	public void SetPolyCwPoints(List<Vector2> cwPoints, bool isClosed) { }

	[Address(RVA = "0x5067F0", Offset = "0x5059F0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600069A")]
	public virtual void SetSnapEnabled(bool isEnabled) { }

}


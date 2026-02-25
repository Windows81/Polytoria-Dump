namespace RLD;

[Token(Token = "0x20000BA")]
public class GizmoLineSlider3D : GizmoSlider
{
	[CompilerGenerated]
	[Token(Token = "0x20000BB")]
	private sealed class <>c__DisplayClass78_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002EE")]
		public int handleId; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600074F")]
		public <>c__DisplayClass78_0() { }

		[Address(RVA = "0x3FF6C0", Offset = "0x3FE8C0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000750")]
		internal bool <IsScalerHandleRegistered>b__0(GizmoScalerHandle item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BC")]
	private sealed class <>c__DisplayClass79_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002EF")]
		public int handleId; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000751")]
		public <>c__DisplayClass79_0() { }

		[Address(RVA = "0x3FF6C0", Offset = "0x3FE8C0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000752")]
		internal bool <IsScalerHandleRegistered>b__0(GizmoScalerHandle item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000BD")]
	private sealed class <>c__DisplayClass81_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002F0")]
		public int handleId; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000753")]
		public <>c__DisplayClass81_0() { }

		[Address(RVA = "0x3FF6C0", Offset = "0x3FE8C0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000754")]
		internal bool <UnregisterScalerHandle>b__0(GizmoScalerHandle item) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D5")]
	private SegmentShape3D _segment; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D6")]
	private BoxShape3D _box; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D7")]
	private CylinderShape3D _cylinder; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D8")]
	private int _segmentIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002D9")]
	private int _boxIndex; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002DA")]
	private int _cylinderIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002DB")]
	private IGizmoLineSlider3DController[] _controllers; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002DC")]
	private GizmoLineSlider3DControllerData _controllerData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002DD")]
	private GizmoDragChannel _dragChannel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002DE")]
	private GizmoSglAxisOffsetDrag3D _offsetDrag; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002DF")]
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002E0")]
	private GizmoRotationArc3D _rotationArc; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002E1")]
	private GizmoSglAxisScaleDrag3D _scaleDrag; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002E2")]
	private int _scaleDragAxisIndex; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002E3")]
	private List<GizmoScalerHandle> _scalerHandles; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002E4")]
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002E5")]
	private GizmoCap3D _cap3D; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40002E6")]
	private GizmoTransform _transform; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40002E7")]
	private GizmoTransformAxisMap3D _directionAxisMap; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40002E8")]
	private GizmoTransformAxisMap3D _dragRotationAxisMap; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40002E9")]
	private GizmoOverrideColor _overrideColor; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40002EA")]
	private GizmoLineSlider3DSettings _settings; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40002EB")]
	private GizmoLineSlider3DSettings _sharedSettings; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40002EC")]
	private GizmoLineSlider3DLookAndFeel _lookAndFeel; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40002ED")]
	private GizmoLineSlider3DLookAndFeel _sharedLookAndFeel; //Field offset: 0xE0

	[Token(Token = "0x1700024D")]
	public int Cap3DHandleId
	{
		[Address(RVA = "0x4FF0D0", Offset = "0x4FE2D0", Length = "0x20")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000716")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000255")]
	public GizmoOverrideColor Cap3DOverrideColor
	{
		[Address(RVA = "0x5042F0", Offset = "0x5034F0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600071E")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000242")]
	public Vector3 Direction
	{
		[Address(RVA = "0x504320", Offset = "0x503520", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000709")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000246")]
	public GizmoDragChannel DragChannel
	{
		[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600070F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000243")]
	public Vector3 DragRotationAxis
	{
		[Address(RVA = "0x504370", Offset = "0x503570", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700024C")]
	public bool Is3DCapHoverable
	{
		[Address(RVA = "0x4FF130", Offset = "0x4FE330", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000715")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700024B")]
	public bool Is3DCapVisible
	{
		[Address(RVA = "0x4FF150", Offset = "0x4FE350", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000714")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000247")]
	public bool IsDragged
	{
		[Address(RVA = "0x4FF170", Offset = "0x4FE370", Length = "0x93")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000710")]
		 get { } //Length: 147
	}

	[Token(Token = "0x17000248")]
	public bool IsMoving
	{
		[Address(RVA = "0x5043B0", Offset = "0x5035B0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000711")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000249")]
	public bool IsRotating
	{
		[Address(RVA = "0x4FF270", Offset = "0x4FE470", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000712")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700024A")]
	public bool IsScaling
	{
		[Address(RVA = "0x5043E0", Offset = "0x5035E0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000713")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000258")]
	public GizmoLineSlider3DLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x4FF3C0", Offset = "0x4FE5C0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000722")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000254")]
	public GizmoOverrideColor OverrideColor
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600071D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700024F")]
	public Vector3 RelativeDragOffset
	{
		[Address(RVA = "0x504410", Offset = "0x503610", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000718")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000251")]
	public float RelativeDragRotation
	{
		[Address(RVA = "0x504440", Offset = "0x503640", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600071A")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000253")]
	public float RelativeDragScale
	{
		[Address(RVA = "0x504460", Offset = "0x503660", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600071C")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000244")]
	public int ScaleDragAxisIndex
	{
		[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600070B")]
		 get { } //Length: 7
		[Address(RVA = "0x504550", Offset = "0x503750", Length = "0x26")]
		[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Token(Token = "0x600070C")]
		 set { } //Length: 38
	}

	[Token(Token = "0x17000256")]
	public GizmoLineSlider3DSettings Settings
	{
		[Address(RVA = "0x3DCA80", Offset = "0x3DBC80", Length = "0x1A")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600071F")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000259")]
	public GizmoLineSlider3DLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000723")]
		 get { } //Length: 8
		[Address(RVA = "0x504580", Offset = "0x503780", Length = "0x67")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "ConnectMvSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "ConnectScSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
		[CallerCount(Count = 29)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000724")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000257")]
	public GizmoLineSlider3DSettings SharedSettings
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000720")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000721")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000245")]
	public Vector3 StartPosition
	{
		[Address(RVA = "0x5044A0", Offset = "0x5036A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600070D")]
		 get { } //Length: 44
		[Address(RVA = "0x5045F0", Offset = "0x5037F0", Length = "0x38")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateExtrudeSliderTransforms", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600070E")]
		 set { } //Length: 56
	}

	[Token(Token = "0x1700024E")]
	public Vector3 TotalDragOffset
	{
		[Address(RVA = "0x5044D0", Offset = "0x5036D0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000717")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000250")]
	public float TotalDragRotation
	{
		[Address(RVA = "0x504500", Offset = "0x503700", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000719")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000252")]
	public float TotalDragScale
	{
		[Address(RVA = "0x504520", Offset = "0x503720", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600071B")]
		 get { } //Length: 34
	}

	[Address(RVA = "0x503600", Offset = "0x502800", Length = "0xCE3")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "Map", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreDragBeginAttempt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreDragBeginAttemptHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHoverEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHoverEnterHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostDisabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add3DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape3D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "RegisterTransformAsDragTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IGizmoDragSession)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreHoverExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreHoverExitHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSlider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SegmentShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BoxShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CylinderShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GizmoCap3DLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 21)]
	[Token(Token = "0x6000725")]
	public GizmoLineSlider3D(Gizmo gizmo, int handleId, int capHandleId) { }

	[Address(RVA = "0x500C50", Offset = "0x4FFE50", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600073D")]
	public void AddTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x500CB0", Offset = "0x4FFEB0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600073E")]
	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x500D00", Offset = "0x4FFF00", Length = "0x18B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(GizmoCap3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap3D), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000742")]
	public void ApplyZoomFactor(Camera camera) { }

	[Address(RVA = "0x4FF0D0", Offset = "0x4FE2D0", Length = "0x20")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000716")]
	public int get_Cap3DHandleId() { }

	[Address(RVA = "0x5042F0", Offset = "0x5034F0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071E")]
	public GizmoOverrideColor get_Cap3DOverrideColor() { }

	[Address(RVA = "0x504320", Offset = "0x503520", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000709")]
	public Vector3 get_Direction() { }

	[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600070F")]
	public GizmoDragChannel get_DragChannel() { }

	[Address(RVA = "0x504370", Offset = "0x503570", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600070A")]
	public Vector3 get_DragRotationAxis() { }

	[Address(RVA = "0x4FF130", Offset = "0x4FE330", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000715")]
	public bool get_Is3DCapHoverable() { }

	[Address(RVA = "0x4FF150", Offset = "0x4FE350", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000714")]
	public bool get_Is3DCapVisible() { }

	[Address(RVA = "0x4FF170", Offset = "0x4FE370", Length = "0x93")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000710")]
	public bool get_IsDragged() { }

	[Address(RVA = "0x5043B0", Offset = "0x5035B0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000711")]
	public bool get_IsMoving() { }

	[Address(RVA = "0x4FF270", Offset = "0x4FE470", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000712")]
	public bool get_IsRotating() { }

	[Address(RVA = "0x5043E0", Offset = "0x5035E0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000713")]
	public bool get_IsScaling() { }

	[Address(RVA = "0x4FF3C0", Offset = "0x4FE5C0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000722")]
	public GizmoLineSlider3DLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600071D")]
	public GizmoOverrideColor get_OverrideColor() { }

	[Address(RVA = "0x504410", Offset = "0x503610", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000718")]
	public Vector3 get_RelativeDragOffset() { }

	[Address(RVA = "0x504440", Offset = "0x503640", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071A")]
	public float get_RelativeDragRotation() { }

	[Address(RVA = "0x504460", Offset = "0x503660", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071C")]
	public float get_RelativeDragScale() { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600070B")]
	public int get_ScaleDragAxisIndex() { }

	[Address(RVA = "0x3DCA80", Offset = "0x3DBC80", Length = "0x1A")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600071F")]
	public GizmoLineSlider3DSettings get_Settings() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000723")]
	public GizmoLineSlider3DLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000720")]
	public GizmoLineSlider3DSettings get_SharedSettings() { }

	[Address(RVA = "0x5044A0", Offset = "0x5036A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600070D")]
	public Vector3 get_StartPosition() { }

	[Address(RVA = "0x5044D0", Offset = "0x5036D0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000717")]
	public Vector3 get_TotalDragOffset() { }

	[Address(RVA = "0x504500", Offset = "0x503700", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000719")]
	public float get_TotalDragRotation() { }

	[Address(RVA = "0x504520", Offset = "0x503720", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600071B")]
	public float get_TotalDragScale() { }

	[Address(RVA = "0x500E90", Offset = "0x500090", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000736")]
	public float GetRealBoxDepth(float zoomFactor) { }

	[Address(RVA = "0x500F30", Offset = "0x500130", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000735")]
	public float GetRealBoxHeight(float zoomFactor) { }

	[Address(RVA = "0x500FD0", Offset = "0x5001D0", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoCylinderLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCylinderLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000737")]
	public float GetRealCylinderRadius(float zoomFactor) { }

	[Address(RVA = "0x501070", Offset = "0x500270", Length = "0x1A9")]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnVisibilityStateChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCylinderLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "IsScalerHandleRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "get_TotalDragScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600072F")]
	public Vector3 GetRealDirection() { }

	[Address(RVA = "0x501330", Offset = "0x500530", Length = "0xDB")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnVisibilityStateChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoLineSlider3DCollection+<>c__DisplayClass20_0", Member = "<GetRenderSortedSliders>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000733")]
	public Vector3 GetRealEndPosition(float zoomFactor) { }

	[Address(RVA = "0x501220", Offset = "0x500420", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetSliderAlignedRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000734")]
	public Vector3 GetRealEndPositionWith3DCap(float zoomFactor) { }

	[Address(RVA = "0x501470", Offset = "0x500670", Length = "0x1F6")]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPositionWith3DCap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCylinderLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoCylinderLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealLengthWith3DCap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "IsScalerHandleRegistered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Gizmo), Member = "get_TotalDragScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000731")]
	public float GetRealLength(float zoomFactor) { }

	[Address(RVA = "0x501410", Offset = "0x500610", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetSliderAlignedRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000732")]
	public float GetRealLengthWith3DCap(float zoomFactor) { }

	[Address(RVA = "0x501670", Offset = "0x500870", Length = "0x1A6")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000730")]
	public float GetRealSizeAlongDirection(Camera camera, Vector3 direction) { }

	[Address(RVA = "0x501820", Offset = "0x500A20", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600072E")]
	public float GetZoomFactor(Camera camera) { }

	[Address(RVA = "0x501970", Offset = "0x500B70", Length = "0x127")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(GizmoScalerHandle), Member = "ContainsScaleDragAxisIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000727")]
	public bool IsScalerHandleRegistered(int handleId, int scaleDragAxisIndex) { }

	[Address(RVA = "0x501880", Offset = "0x500A80", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000726")]
	public bool IsScalerHandleRegistered(int handleId) { }

	[Address(RVA = "0x501AA0", Offset = "0x500CA0", Length = "0x5E")]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "Map", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000738")]
	public void MapDirection(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x501B00", Offset = "0x500D00", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "Map", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000739")]
	public void MapDragRotationAxis(GizmoTransform mapTransform, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x501B70", Offset = "0x500D70", Length = "0x47D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoSglAxisScaleDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSglAxisOffsetDrag3D), Member = "SetWorkData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorkData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000748")]
	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x501FF0", Offset = "0x5011F0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600074A")]
	private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x5020F0", Offset = "0x5012F0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600074D")]
	private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x502160", Offset = "0x501360", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600074C")]
	private void OnGizmoPostDisabled(Gizmo gizmo) { }

	[Address(RVA = "0x5021A0", Offset = "0x5013A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "Refresh", ReturnType = typeof(void))]
	[Token(Token = "0x600074B")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x5021B0", Offset = "0x5013B0", Length = "0x35A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(GizmoSlider), Member = "get_HoverPriority3D", ReturnType = typeof(Priority))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap3D), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000747")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x4FDC10", Offset = "0x4FCE10", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000746")]
	protected virtual void OnHoverableStateChanged() { }

	[Address(RVA = "0x502510", Offset = "0x501710", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap3D), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000749")]
	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x5026B0", Offset = "0x5018B0", Length = "0x223")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap3D), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000745")]
	protected virtual void OnVisibilityStateChanged() { }

	[Address(RVA = "0x5028E0", Offset = "0x501AE0", Length = "0x226")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoCap3D), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000744")]
	public void Refresh() { }

	[Address(RVA = "0x502B10", Offset = "0x501D10", Length = "0x1B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(GizmoScalerHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000728")]
	public void RegisterScalerHandle(int handleId, IEnumerable<Int32> scaleDragAxisIndices) { }

	[Address(RVA = "0x502CD0", Offset = "0x501ED0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600073F")]
	public void RemoveTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x502D30", Offset = "0x501F30", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000740")]
	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x502D80", Offset = "0x501F80", Length = "0x55A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLightDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DWire", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraEx), Member = "IsPointFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoRotationArc3DLookAndFeel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoRotationArc3D), Member = "set_RotationAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DSolid", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000743")]
	public virtual void Render(Camera camera) { }

	[Address(RVA = "0x504550", Offset = "0x503750", Length = "0x26")]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Token(Token = "0x600070C")]
	public void set_ScaleDragAxisIndex(int value) { }

	[Address(RVA = "0x504580", Offset = "0x503780", Length = "0x67")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoLookAndFeel3D), Member = "ConnectSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetupSharedLookAndFeel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "ConnectMvSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoLookAndFeel3D), Member = "ConnectScSliderLookAndFeel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoLineSlider3D), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000724")]
	public void set_SharedLookAndFeel(GizmoLineSlider3DLookAndFeel value) { }

	[Address(RVA = "0x2DD470", Offset = "0x2DC670", Length = "0x13")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000721")]
	public void set_SharedSettings(GizmoLineSlider3DSettings value) { }

	[Address(RVA = "0x5045F0", Offset = "0x5037F0", Length = "0x38")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateExtrudeSliderTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600070E")]
	public void set_StartPosition(Vector3 value) { }

	[Address(RVA = "0x4FE3A0", Offset = "0x4FD5A0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600072C")]
	public void Set3DCapHoverable(bool isHoverable) { }

	[Address(RVA = "0x4FE3D0", Offset = "0x4FD5D0", Length = "0x21")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(GizmoCap), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600072B")]
	public void Set3DCapVisible(bool isVisible) { }

	[Address(RVA = "0x5032E0", Offset = "0x5024E0", Length = "0x55")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "UpdateExtrudeSliderTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600073B")]
	public void SetDirection(Vector3 directionAxis) { }

	[Address(RVA = "0x503340", Offset = "0x502540", Length = "0x83")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000741")]
	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	[Address(RVA = "0x5033D0", Offset = "0x5025D0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600073C")]
	public void SetDragRotationAxis(Vector3 rotationAxis) { }

	[Address(RVA = "0x503440", Offset = "0x502640", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600072A")]
	public virtual void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x5034A0", Offset = "0x5026A0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600074E")]
	private void SetupSharedLookAndFeel() { }

	[Address(RVA = "0x503480", Offset = "0x502680", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetZoomFactorTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600072D")]
	public void SetZoomFactorTransform(GizmoTransform transform) { }

	[Address(RVA = "0x5034F0", Offset = "0x5026F0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600073A")]
	public void UnmapDragRotationAxis() { }

	[Address(RVA = "0x503530", Offset = "0x502730", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000729")]
	public void UnregisterScalerHandle(int handleId) { }

}


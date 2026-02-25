namespace RLD;

[Token(Token = "0x2000013")]
public class GizmoCap2D : GizmoCap
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000039")]
	private int _quadIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003A")]
	private QuadShape2D _quad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003B")]
	private int _circleIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003C")]
	private CircleShape2D _circle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003D")]
	private int _arrowIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400003E")]
	private ConeShape2D _arrow; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400003F")]
	private GizmoTransform _transform; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000040")]
	private GizmoOverrideColor _overrideFillColor; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000041")]
	private GizmoOverrideColor _overrideBorderColor; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000042")]
	private GizmoCap2DControllerData _controllerData; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000043")]
	private IGizmoCap2DController[] _controllers; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000044")]
	private GizmoCap2DLookAndFeel _lookAndFeel; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000045")]
	private GizmoCap2DLookAndFeel _sharedLookAndFeel; //Field offset: 0x88

	[Token(Token = "0x17000010")]
	public IGizmoDragSession DragSession
	{
		[Address(RVA = "0x3B3450", Offset = "0x3B2650", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600005F")]
		 get { } //Length: 27
		[Address(RVA = "0x3B3520", Offset = "0x3B2720", Length = "0x23")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000060")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000011")]
	public GizmoCap2DLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x3B3470", Offset = "0x3B2670", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000061")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700000F")]
	public GizmoOverrideColor OverrideBorderColor
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000E")]
	public GizmoOverrideColor OverrideFillColor
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000B")]
	public Vector2 Position
	{
		[Address(RVA = "0x3B34A0", Offset = "0x3B26A0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000058")]
		 get { } //Length: 41
		[Address(RVA = "0x3B3550", Offset = "0x3B2750", Length = "0x1E")]
		[CalledBy(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000059")]
		 set { } //Length: 30
	}

	[Token(Token = "0x1700000C")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B34F0", Offset = "0x3B26F0", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600005A")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700000D")]
	public float RotationDegrees
	{
		[Address(RVA = "0x3B34D0", Offset = "0x3B26D0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 28
		[Address(RVA = "0x3B3570", Offset = "0x3B2770", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600005C")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000012")]
	public GizmoCap2DLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000062")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x3B2D00", Offset = "0x3B1F00", Length = "0x740")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Gizmo), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GizmoHandle))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add2DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConeShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CircleShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(QuadShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6000064")]
	public GizmoCap2D(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3B2260", Offset = "0x3B1460", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000067")]
	public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector2 axis) { }

	[Address(RVA = "0x3B23C0", Offset = "0x3B15C0", Length = "0xAA")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnVisibilityStateChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A8B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006D")]
	public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Address(RVA = "0x3B2310", Offset = "0x3B1510", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A8B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006E")]
	public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Address(RVA = "0x3B3450", Offset = "0x3B2650", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public IGizmoDragSession get_DragSession() { }

	[Address(RVA = "0x3B3470", Offset = "0x3B2670", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000061")]
	public GizmoCap2DLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public GizmoOverrideColor get_OverrideBorderColor() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public GizmoOverrideColor get_OverrideFillColor() { }

	[Address(RVA = "0x3B34A0", Offset = "0x3B26A0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000058")]
	public Vector2 get_Position() { }

	[Address(RVA = "0x3B34F0", Offset = "0x3B26F0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005A")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x3B34D0", Offset = "0x3B26D0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005B")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public GizmoCap2DLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x3B2470", Offset = "0x3B1670", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006C")]
	public float GetRealArrowBaseRadius() { }

	[Address(RVA = "0x3B24C0", Offset = "0x3B16C0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006B")]
	public float GetRealArrowHeight() { }

	[Address(RVA = "0x3B2510", Offset = "0x3B1710", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006A")]
	public float GetRealCircleRadius() { }

	[Address(RVA = "0x3B2560", Offset = "0x3B1760", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000069")]
	public float GetRealQuadHeight() { }

	[Address(RVA = "0x3B25B0", Offset = "0x3B17B0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000068")]
	public float GetRealQuadWidth() { }

	[Address(RVA = "0x3B2600", Offset = "0x3B1800", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x3B26E0", Offset = "0x3B18E0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000073")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x3B2790", Offset = "0x3B1990", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	protected virtual void OnHoverableStateChanged() { }

	[Address(RVA = "0x3B27C0", Offset = "0x3B19C0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000074")]
	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x3B2860", Offset = "0x3B1A60", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000071")]
	protected virtual void OnVisibilityStateChanged() { }

	[Address(RVA = "0x3B2600", Offset = "0x3B1800", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000070")]
	public void Refresh() { }

	[Address(RVA = "0x3B2940", Offset = "0x3B1B40", Length = "0x58")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000065")]
	public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

	[Address(RVA = "0x3B29A0", Offset = "0x3B1BA0", Length = "0x2F8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DSolid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600006F")]
	public virtual void Render(Camera camera) { }

	[Address(RVA = "0x3B3520", Offset = "0x3B2720", Length = "0x23")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public void set_DragSession(IGizmoDragSession value) { }

	[Address(RVA = "0x3B3550", Offset = "0x3B2750", Length = "0x1E")]
	[CalledBy(Type = typeof(BoxGizmo), Member = "UpdateTickPositions", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000059")]
	public void set_Position(Vector2 value) { }

	[Address(RVA = "0x3B3570", Offset = "0x3B2770", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005C")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public void set_SharedLookAndFeel(GizmoCap2DLookAndFeel value) { }

	[Address(RVA = "0x3B2CA0", Offset = "0x3B1EA0", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000066")]
	public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

}


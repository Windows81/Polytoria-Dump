namespace RLD;

[Token(Token = "0x200001D")]
public class GizmoCap3D : GizmoCap
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000062")]
	private int _coneIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000063")]
	private ConeShape3D _cone; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000064")]
	private int _pyramidIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000065")]
	private PyramidShape3D _pyramid; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000066")]
	private int _boxIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000067")]
	private BoxShape3D _box; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000068")]
	private int _sphereIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000069")]
	private SphereShape3D _sphere; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400006A")]
	private int _trPrismIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400006B")]
	private TriangPrismShape3D _trPrism; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400006C")]
	private GizmoCap3DControllerData _controllerData; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400006D")]
	private IGizmoCap3DController[] _controllers; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400006E")]
	private GizmoTransform _transform; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400006F")]
	private GizmoOverrideColor _overrideColor; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000070")]
	private GizmoCap3DLookAndFeel _lookAndFeel; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000071")]
	private GizmoCap3DLookAndFeel _sharedLookAndFeel; //Field offset: 0xA0

	[Token(Token = "0x17000024")]
	public IGizmoDragSession DragSession
	{
		[Address(RVA = "0x3B3450", Offset = "0x3B2650", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BF")]
		 get { } //Length: 27
		[Address(RVA = "0x3B3520", Offset = "0x3B2720", Length = "0x23")]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C0")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000025")]
	public GizmoCap3DLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x3B6910", Offset = "0x3B5B10", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000023")]
	public GizmoOverrideColor OverrideColor
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000BE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000021")]
	public Vector3 Position
	{
		[Address(RVA = "0x3B6930", Offset = "0x3B5B30", Length = "0x2C")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoCap), Member = "get_Position", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.SceneGizmo+<>c__DisplayClass20_0", Member = "<OnGizmoRender>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmoCap), typeof(SceneGizmoCap)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 44
		[Address(RVA = "0x3B6990", Offset = "0x3B5B90", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BB")]
		 set { } //Length: 56
	}

	[Token(Token = "0x17000022")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B6960", Offset = "0x3B5B60", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 36
		[Address(RVA = "0x3B69D0", Offset = "0x3B5BD0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000BD")]
		 set { } //Length: 47
	}

	[Token(Token = "0x17000026")]
	public GizmoCap3DLookAndFeel SharedLookAndFeel
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C2")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C3")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x3B5F10", Offset = "0x3B5110", Length = "0x9F4")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoMidCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GizmoHandle), Member = "Add3DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape3D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GizmoHandle), Member = "SetZoomFactorTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoTransform), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoEntityTransformChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostEnabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmo), Member = "add_PostDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostDisabledHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GizmoHandle))]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(SphereShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConeShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Token(Token = "0x60000C4")]
	public GizmoCap3D(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3B45D0", Offset = "0x3B37D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C7")]
	public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector3 axis) { }

	[Address(RVA = "0x3B4620", Offset = "0x3B3820", Length = "0xFD")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000DA")]
	public void ApplyZoomFactor(Camera camera) { }

	[Address(RVA = "0x3B48F0", Offset = "0x3B3AF0", Length = "0x1CD")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Refresh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnVisibilityStateChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(ChangeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "ApplyZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C9")]
	public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt) { }

	[Address(RVA = "0x3B4720", Offset = "0x3B3920", Length = "0x1CD")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CA")]
	public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt) { }

	[Address(RVA = "0x3B3450", Offset = "0x3B2650", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BF")]
	public IGizmoDragSession get_DragSession() { }

	[Address(RVA = "0x3B6910", Offset = "0x3B5B10", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000C1")]
	public GizmoCap3DLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BE")]
	public GizmoOverrideColor get_OverrideColor() { }

	[Address(RVA = "0x3B6930", Offset = "0x3B5B30", Length = "0x2C")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCap), Member = "get_Position", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.SceneGizmo+<>c__DisplayClass20_0", Member = "<OnGizmoRender>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmoCap), typeof(SceneGizmoCap)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BA")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x3B6960", Offset = "0x3B5B60", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BC")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	public GizmoCap3DLookAndFeel get_SharedLookAndFeel() { }

	[Address(RVA = "0x3B4AC0", Offset = "0x3B3CC0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D4")]
	public float GetRealBoxDepth(float zoomFactor) { }

	[Address(RVA = "0x3B4B60", Offset = "0x3B3D60", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D3")]
	public float GetRealBoxHeight(float zoomFactor) { }

	[Address(RVA = "0x3B4C00", Offset = "0x3B3E00", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D5")]
	public Vector3 GetRealBoxSize(float zoomFactor) { }

	[Address(RVA = "0x3B4D00", Offset = "0x3B3F00", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D2")]
	public float GetRealBoxWidth(float zoomFactor) { }

	[Address(RVA = "0x3B4DA0", Offset = "0x3B3FA0", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "GetSliderAlignedRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CD")]
	public float GetRealConeHeight(float zoomFactor) { }

	[Address(RVA = "0x3B4E40", Offset = "0x3B4040", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CE")]
	public float GetRealConeRadius(float zoomFactor) { }

	[Address(RVA = "0x3B4EE0", Offset = "0x3B40E0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D0")]
	public float GetRealPyramidDepth(float zoomFactor) { }

	[Address(RVA = "0x3B4F80", Offset = "0x3B4180", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoPyramidCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPyramidCap3DController), Member = "GetSliderAlignedRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D1")]
	public float GetRealPyramidHeight(float zoomFactor) { }

	[Address(RVA = "0x3B5020", Offset = "0x3B4220", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CF")]
	public float GetRealPyramidWidth(float zoomFactor) { }

	[Address(RVA = "0x3B50C0", Offset = "0x3B42C0", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoCap3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSphereCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSphereCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSphereCap3DController), Member = "GetSliderAlignedRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "UpdateCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "UpdateRtCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D6")]
	public float GetRealSphereRadius(float zoomFactor) { }

	[Address(RVA = "0x3B5160", Offset = "0x3B4360", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "GetSliderAlignedRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D9")]
	public float GetRealTriPrismDepth(float zoomFactor) { }

	[Address(RVA = "0x3B5200", Offset = "0x3B4400", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D8")]
	public float GetRealTriPrismHeight(float zoomFactor) { }

	[Address(RVA = "0x3B52A0", Offset = "0x3B44A0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D7")]
	public float GetRealTriPrismWidth(float zoomFactor) { }

	[Address(RVA = "0x3B5340", Offset = "0x3B4540", Length = "0x109")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealLengthWith3DCap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPositionWith3DCap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	public float GetSliderAlignedRealLength(float zoomFactor) { }

	[Address(RVA = "0x3B5450", Offset = "0x3B4650", Length = "0x52")]
	[CalledBy(Type = typeof(GizmoCap3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "UpdateCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "UpdateRtCamLookSlider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CC")]
	public float GetZoomFactor(Camera camera) { }

	[Address(RVA = "0x3B54B0", Offset = "0x3B46B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E2")]
	private void OnGizmoPostDisabled(Gizmo gizmo) { }

	[Address(RVA = "0x3B54D0", Offset = "0x3B46D0", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000E1")]
	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	[Address(RVA = "0x3B5620", Offset = "0x3B4820", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000DF")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x3B2790", Offset = "0x3B1990", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DE")]
	protected virtual void OnHoverableStateChanged() { }

	[Address(RVA = "0x3B5760", Offset = "0x3B4960", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000E0")]
	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	[Address(RVA = "0x3B5880", Offset = "0x3B4A80", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000DD")]
	protected virtual void OnVisibilityStateChanged() { }

	[Address(RVA = "0x3B54D0", Offset = "0x3B46D0", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoHandle), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DC")]
	public void Refresh() { }

	[Address(RVA = "0x3B59D0", Offset = "0x3B4BD0", Length = "0x5B")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C5")]
	public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

	[Address(RVA = "0x3B5A30", Offset = "0x3B4C30", Length = "0x451")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DSolid", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLightDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DWire", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawSphereBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DB")]
	public virtual void Render(Camera camera) { }

	[Address(RVA = "0x3B3520", Offset = "0x3B2720", Length = "0x23")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C0")]
	public void set_DragSession(IGizmoDragSession value) { }

	[Address(RVA = "0x3B6990", Offset = "0x3B5B90", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BB")]
	public void set_Position(Vector3 value) { }

	[Address(RVA = "0x3B69D0", Offset = "0x3B5BD0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000BD")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x2DD5C0", Offset = "0x2DC7C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	public void set_SharedLookAndFeel(GizmoCap3DLookAndFeel value) { }

	[Address(RVA = "0x3B5E90", Offset = "0x3B5090", Length = "0x1E")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoHandle), Member = "SetZoomFactorTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C8")]
	public void SetZoomFactorTransform(GizmoTransform transform) { }

	[Address(RVA = "0x3B5EB0", Offset = "0x3B50B0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C6")]
	public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

}


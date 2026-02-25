namespace RLD;

[Token(Token = "0x20000E5")]
public class GizmoCircle3DBorder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003AD")]
	private GizmoPlaneSlider3D _planeSlider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003AE")]
	private GizmoHandle _targetHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003AF")]
	private CircleShape3D _targetCircle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003B0")]
	private bool _isVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40003B1")]
	private bool _isHoverable; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003B2")]
	private int _borderCircleIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003B3")]
	private int _borderTorusIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40003B4")]
	private int _borderCylTorusIndex; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003B5")]
	private CircleShape3D _borderCircle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003B6")]
	private TorusShape3D _borderTorus; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003B7")]
	private CylTorusShape3D _borderCylTorus; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003B8")]
	private GizmoCircle3DBorderControllerData _controllerData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003B9")]
	private IGizmoCircle3DBorderController[] _controllers; //Field offset: 0x58

	[Token(Token = "0x170002C6")]
	public Gizmo Gizmo
	{
		[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AE")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170002C5")]
	public bool IsHoverable
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002C4")]
	public bool IsVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x50F610", Offset = "0x50E810", Length = "0x5BB")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(WireRenderDescriptor), Member = "set_NumTubeSlices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add3DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape3D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CylTorusShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TorusShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CircleShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60008AF")]
	public GizmoCircle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, CircleShape3D targetCircle) { }

	[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AE")]
	public Gizmo get_Gizmo() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AD")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AC")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x50E850", Offset = "0x50DA50", Length = "0x66")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008B5")]
	public float GetRealCylTorusHeight(float zoomFactor) { }

	[Address(RVA = "0x50E8C0", Offset = "0x50DAC0", Length = "0x66")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008B4")]
	public float GetRealCylTorusWidth(float zoomFactor) { }

	[Address(RVA = "0x50E930", Offset = "0x50DB30", Length = "0x66")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008B3")]
	public float GetRealTorusThickness(float zoomFactor) { }

	[Address(RVA = "0x50E9A0", Offset = "0x50DBA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B2")]
	public float GetZoomFactor(Camera camera) { }

	[Address(RVA = "0x50E9C0", Offset = "0x50DBC0", Length = "0xC1")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008B6")]
	public void OnCircleShapeChanged() { }

	[Address(RVA = "0x50EA90", Offset = "0x50DC90", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008B8")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x50EBB0", Offset = "0x50DDB0", Length = "0x809")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "GetTorusCoreRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTorusCircle3DBorderController), Member = "GetTorusCoreRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "GetRealTorusThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetLightDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "get_IsLit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetCylindricalTorusRadii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetTorusCoreRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetCullAlphaScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetTorusTubeRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetShapeCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "GetRealCylTorusHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "GetRealCylTorusWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoCircularMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DSolid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008B7")]
	public void Render(Camera camera) { }

	[Address(RVA = "0x50F3C0", Offset = "0x50E5C0", Length = "0x6A")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetBorderHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008B1")]
	public void SetHoverable(bool isHoverable) { }

	[Address(RVA = "0x50F430", Offset = "0x50E630", Length = "0x1DC")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider3DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoRATrianglePlaneSlider3DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008B0")]
	public void SetVisible(bool isVisible) { }

}


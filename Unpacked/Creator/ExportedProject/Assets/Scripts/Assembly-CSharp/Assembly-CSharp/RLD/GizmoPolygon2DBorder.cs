namespace RLD;

[Token(Token = "0x20000DA")]
public class GizmoPolygon2DBorder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000387")]
	private GizmoPlaneSlider2D _planeSlider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000388")]
	private GizmoHandle _targetHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000389")]
	private PolygonShape2D _targetPolygon; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400038A")]
	private bool _isVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400038B")]
	private bool _isHoverable; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400038C")]
	private int _borderPolygonIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400038D")]
	private int _thickBorderPolygonIndex; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400038E")]
	private PolygonShape2D _borderPolygon; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400038F")]
	private PolygonShape2D _thickBorderPolygon; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000390")]
	private GizmoPolygon2DBorderControllerData _controllerData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000391")]
	private IGizmoPolygon2DBorderController[] _controllers; //Field offset: 0x50

	[Token(Token = "0x170002C1")]
	public bool IsHoverable
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000881")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002C0")]
	public bool IsVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000880")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x510560", Offset = "0x50F760", Length = "0x4CE")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(GizmoHandle), Member = "Add2DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PolygonShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000882")]
	public GizmoPolygon2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, PolygonShape2D targetPolygon) { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000881")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000880")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x5100A0", Offset = "0x50F2A0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000887")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x510170", Offset = "0x50F370", Length = "0x83")]
	[CalledBy(Type = typeof(GizmoPolygonPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000885")]
	public void OnPolygonShapeChanged() { }

	[Address(RVA = "0x510200", Offset = "0x50F400", Length = "0x19B")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000886")]
	public void Render(Camera camera) { }

	[Address(RVA = "0x5103A0", Offset = "0x50F5A0", Length = "0x52")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "SetBorderHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000884")]
	public void SetHoverable(bool isHoverable) { }

	[Address(RVA = "0x510400", Offset = "0x50F600", Length = "0x15C")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygonPlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000883")]
	public void SetVisible(bool isVisible) { }

}


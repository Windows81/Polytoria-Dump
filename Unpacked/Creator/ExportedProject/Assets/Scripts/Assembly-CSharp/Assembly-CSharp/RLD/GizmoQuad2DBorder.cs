namespace RLD;

[Token(Token = "0x20000E0")]
public class GizmoQuad2DBorder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400039C")]
	private GizmoPlaneSlider2D _planeSlider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400039D")]
	private GizmoHandle _targetHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400039E")]
	private QuadShape2D _targetQuad; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400039F")]
	private bool _isVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40003A0")]
	private bool _isHoverable; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003A1")]
	private int _borderQuadIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003A2")]
	private QuadShape2D _borderQuad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003A3")]
	private GizmoQuad2DBorderControllerData _controllerData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003A4")]
	private IGizmoQuad2DBorderController[] _controllers; //Field offset: 0x40

	[Token(Token = "0x170002C3")]
	public bool IsHoverable
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000899")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002C2")]
	public bool IsVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000898")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x510E30", Offset = "0x510030", Length = "0x375")]
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
	[Calls(Type = typeof(QuadShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600089A")]
	public GizmoQuad2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, QuadShape2D targetQuad) { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000899")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000898")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x510A30", Offset = "0x50FC30", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600089F")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x510AF0", Offset = "0x50FCF0", Length = "0x80")]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600089D")]
	public void OnQuadShapeChanged() { }

	[Address(RVA = "0x510B80", Offset = "0x50FD80", Length = "0x149")]
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
	[Token(Token = "0x600089E")]
	public void Render(Camera camera) { }

	[Address(RVA = "0x4FAFE0", Offset = "0x4FA1E0", Length = "0x2B")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600089C")]
	public void SetHoverable(bool isHoverable) { }

	[Address(RVA = "0x510CD0", Offset = "0x50FED0", Length = "0x153")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygonPlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600089B")]
	public void SetVisible(bool isVisible) { }

}


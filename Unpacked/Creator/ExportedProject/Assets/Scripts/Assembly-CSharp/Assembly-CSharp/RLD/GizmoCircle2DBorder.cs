namespace RLD;

[Token(Token = "0x20000D5")]
public class GizmoCircle2DBorder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000376")]
	private GizmoPlaneSlider2D _planeSlider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000377")]
	private GizmoHandle _targetHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000378")]
	private CircleShape2D _targetCircle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000379")]
	private bool _isVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400037A")]
	private bool _isHoverable; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400037B")]
	private int _borderCircleIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400037C")]
	private CircleShape2D _borderCircle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400037D")]
	private GizmoCircle2DBorderControllerData _controllerData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400037E")]
	private IGizmoCircle2DBorderController[] _controllers; //Field offset: 0x40

	[Token(Token = "0x170002BF")]
	public bool IsHoverable
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002BE")]
	public bool IsVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600086C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x4FB120", Offset = "0x4FA320", Length = "0x36D")]
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
	[Calls(Type = typeof(CircleShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600086E")]
	public GizmoCircle2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, CircleShape2D targetCircle) { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086D")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086C")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x4FACF0", Offset = "0x4F9EF0", Length = "0x89")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000871")]
	public void OnCircleShapeChanged() { }

	[Address(RVA = "0x4FAD80", Offset = "0x4F9F80", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000873")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x4FAE70", Offset = "0x4FA070", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render2DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000872")]
	public void Render(Camera camera) { }

	[Address(RVA = "0x4FAFE0", Offset = "0x4FA1E0", Length = "0x2B")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000870")]
	public void SetHoverable(bool isHoverable) { }

	[Address(RVA = "0x4FB010", Offset = "0x4FA210", Length = "0x10D")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPolygonPlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(GizmoCircle2DBorder), Member = "OnCircleShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600086F")]
	public void SetVisible(bool isVisible) { }

}


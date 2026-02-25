namespace RLD;

[Token(Token = "0x20000ED")]
public class GizmoQuad3DBorder
{
	[CompilerGenerated]
	[Token(Token = "0x20000EE")]
	private sealed class <>c__DisplayClass39_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40003E0")]
		public GizmoQuad3DBorder <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003E1")]
		public Vector3 camPos; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008DF")]
		public <>c__DisplayClass39_0() { }

		[Address(RVA = "0x522A20", Offset = "0x521C20", Length = "0x1DF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GizmoHandle), Member = "Get3DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Shape3D))]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60008E0")]
		internal int <Render>b__0(int i0, int i1) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C6")]
	private GizmoPlaneSlider3D _planeSlider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003C7")]
	private GizmoHandle _targetHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003C8")]
	private QuadShape3D _targetQuad; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003C9")]
	private bool _isVisible; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40003CA")]
	private bool _isHoverable; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003CB")]
	private int _borderQuadIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003CC")]
	private QuadShape3D _borderQuad; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003CD")]
	private int _topBoxIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003CE")]
	private BoxShape3D _topBox; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003CF")]
	private int _rightBoxIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003D0")]
	private BoxShape3D _rightBox; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003D1")]
	private int _bottomBoxIndex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003D2")]
	private BoxShape3D _bottomBox; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003D3")]
	private int _leftBoxIndex; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003D4")]
	private BoxShape3D _leftBox; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003D5")]
	private int _topLeftBoxIndex; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003D6")]
	private BoxShape3D _topLeftBox; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003D7")]
	private int _topRightBoxIndex; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003D8")]
	private BoxShape3D _topRightBox; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003D9")]
	private int _bottomRightBoxIndex; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40003DA")]
	private BoxShape3D _bottomRightBox; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40003DB")]
	private int _bottomLeftBoxIndex; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40003DC")]
	private BoxShape3D _bottomLeftBox; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40003DD")]
	private List<Int32> _sortedBoxIndices; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40003DE")]
	private GizmoQuad3DBorderControllerData _controllerData; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40003DF")]
	private IGizmoQuad3DBorderController[] _controllers; //Field offset: 0xC8

	[Token(Token = "0x170002C9")]
	public Gizmo Gizmo
	{
		[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D5")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170002C8")]
	public bool IsHoverable
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002C7")]
	public bool IsVisible
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008D3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x511CB0", Offset = "0x510EB0", Length = "0xBE2")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Gizmo), Member = "add_PreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPreUpdateBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Add3DShape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape3D)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(BoxShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(QuadShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60008D6")]
	public GizmoQuad3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, QuadShape3D targetQuad) { }

	[Address(RVA = "0x50FBD0", Offset = "0x50EDD0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D5")]
	public Gizmo get_Gizmo() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D4")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D3")]
	public bool get_IsVisible() { }

	[Address(RVA = "0x5111B0", Offset = "0x5103B0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008DB")]
	public float GetRealBoxDepth(float zoomFactor) { }

	[Address(RVA = "0x511220", Offset = "0x510420", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008DA")]
	public float GetRealBoxHeight(float zoomFactor) { }

	[Address(RVA = "0x50E9A0", Offset = "0x50DBA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008D9")]
	public float GetZoomFactor(Camera camera) { }

	[Address(RVA = "0x511290", Offset = "0x510490", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "get_FocusCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008DE")]
	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	[Address(RVA = "0x5113B0", Offset = "0x5105B0", Length = "0xC8")]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Gizmo), Member = "GetWorkCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetZoomFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60008DC")]
	public void OnQuadShapeChanged() { }

	[Address(RVA = "0x511480", Offset = "0x510680", Length = "0x4FA")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Render3DSolid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLightDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "get_IsLit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60008DD")]
	public void Render(Camera camera) { }

	[Address(RVA = "0x511980", Offset = "0x510B80", Length = "0x13D")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "SetBorderHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetBorderHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008D8")]
	public void SetHoverable(bool isHoverable) { }

	[Address(RVA = "0x511AC0", Offset = "0x510CC0", Length = "0x1E9")]
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
	[Token(Token = "0x60008D7")]
	public void SetVisible(bool isVisible) { }

}


namespace RLD;

[Token(Token = "0x20001FC")]
public class MeshPool : Singleton<MeshPool>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400079B")]
	private Mesh _unitTorus; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400079C")]
	private Mesh _unitCylindricalTorus; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400079D")]
	private Mesh _unitBox; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400079E")]
	private Mesh _unitWireBox; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400079F")]
	private Mesh _unitPyramid; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007A0")]
	private Mesh _unitWirePyramid; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007A1")]
	private Mesh _unitTriangularPrism; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007A2")]
	private Mesh _unitWireTriangularPrism; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007A3")]
	private Mesh _unitCone; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007A4")]
	private Mesh _unitCylinder; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007A5")]
	private Mesh _unitSphere; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40007A6")]
	private Mesh _unitCoordSystem; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40007A7")]
	private Mesh _unitSegmentX; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40007A8")]
	private Mesh _unitQuadXY; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40007A9")]
	private Mesh _unitQuadXZ; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40007AA")]
	private Mesh _unitWireQuadXY; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40007AB")]
	private Mesh _unitCircleXY; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40007AC")]
	private Mesh _unitWireCircleXY; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40007AD")]
	private Mesh _unitRightAngledTriangleXY; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40007AE")]
	private Mesh _unitWireRightAngledTriangleXY; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40007AF")]
	private Mesh _unitEqTriangleXY; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40007B0")]
	private Mesh _unitWireEqTriangleXY; //Field offset: 0xB8

	[Token(Token = "0x17000605")]
	public Mesh UnitBox
	{
		[Address(RVA = "0x596310", Offset = "0x595510", Length = "0xA0")]
		[CalledBy(Type = typeof(BoxShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BoxMesh), Member = "CreateBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600137C")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000611")]
	public Mesh UnitCircleXY
	{
		[Address(RVA = "0x5963B0", Offset = "0x5955B0", Length = "0xA5")]
		[CalledBy(Type = typeof(CircleShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CircleMesh), Member = "CreateCircleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001388")]
		 get { } //Length: 165
	}

	[Token(Token = "0x1700060B")]
	public Mesh UnitCone
	{
		[Address(RVA = "0x596460", Offset = "0x595660", Length = "0xC3")]
		[CalledBy(Type = typeof(ConeShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CylinderMesh), Member = "CreateCylinder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001382")]
		 get { } //Length: 195
	}

	[Token(Token = "0x1700060E")]
	public Mesh UnitCoordSystem
	{
		[Address(RVA = "0x596530", Offset = "0x595730", Length = "0x94")]
		[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LineMesh), Member = "CreateCoordSystemAxesLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001385")]
		 get { } //Length: 148
	}

	[Token(Token = "0x1700060C")]
	public Mesh UnitCylinder
	{
		[Address(RVA = "0x5965D0", Offset = "0x5957D0", Length = "0xC3")]
		[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CylinderMesh), Member = "CreateCylinder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001383")]
		 get { } //Length: 195
	}

	[Token(Token = "0x17000602")]
	public Mesh UnitCylindricalTorus
	{
		[Address(RVA = "0x5966A0", Offset = "0x5958A0", Length = "0xF1")]
		[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TorusMesh), Member = "CreateCylindricalTorus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001379")]
		 get { } //Length: 241
	}

	[Token(Token = "0x17000615")]
	public Mesh UnitEqTriangleXY
	{
		[Address(RVA = "0x5967A0", Offset = "0x5959A0", Length = "0xE0")]
		[CalledBy(Type = typeof(EqTriangle3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TriangleMesh), Member = "CreateEqXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600138C")]
		 get { } //Length: 224
	}

	[Token(Token = "0x17000607")]
	public Mesh UnitPyramid
	{
		[Address(RVA = "0x596880", Offset = "0x595A80", Length = "0xE9")]
		[CalledBy(Type = typeof(PyramidShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PyramidMesh), Member = "CreatePyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600137E")]
		 get { } //Length: 233
	}

	[Token(Token = "0x17000603")]
	public Mesh UnitQuadXY
	{
		[Address(RVA = "0x596970", Offset = "0x595B70", Length = "0x97")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(QuadShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(EditorPrefabPreviewGen), Member = "BeginGenSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabPreviewLookAndFeel)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EditorPrefabPreviewGen), Member = "CreateNonMeshPreviewObject", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(QuadMesh), Member = "CreateQuadXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600137A")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000604")]
	public Mesh UnitQuadXZ
	{
		[Address(RVA = "0x596A10", Offset = "0x595C10", Length = "0xA3")]
		[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(QuadMesh), Member = "CreateQuadXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600137B")]
		 get { } //Length: 163
	}

	[Token(Token = "0x17000613")]
	public Mesh UnitRightAngledTriangleXY
	{
		[Address(RVA = "0x596AC0", Offset = "0x595CC0", Length = "0xED")]
		[CalledBy(Type = typeof(RightAngTriangle3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TriangleMesh), Member = "CreateRightAngledTriangleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600138A")]
		 get { } //Length: 237
	}

	[Token(Token = "0x1700060F")]
	public Mesh UnitSegmentX
	{
		[Address(RVA = "0x596BB0", Offset = "0x595DB0", Length = "0xEF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LineMesh), Member = "CreateLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001386")]
		 get { } //Length: 239
	}

	[Token(Token = "0x1700060D")]
	public Mesh UnitSphere
	{
		[Address(RVA = "0x596CA0", Offset = "0x595EA0", Length = "0xA2")]
		[CalledBy(Type = typeof(SphereTreeNode`1), Member = "DebugDraw", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SphereShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SphereMesh), Member = "CreateSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001384")]
		 get { } //Length: 162
	}

	[Token(Token = "0x17000601")]
	public Mesh UnitTorus
	{
		[Address(RVA = "0x596D50", Offset = "0x595F50", Length = "0xF4")]
		[CalledBy(Type = typeof(TorusShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TorusMesh), Member = "CreateTorus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001378")]
		 get { } //Length: 244
	}

	[Token(Token = "0x17000609")]
	public Mesh UnitTriangularPrism
	{
		[Address(RVA = "0x596E50", Offset = "0x596050", Length = "0xF5")]
		[CalledBy(Type = typeof(TriangPrismShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PrismMesh), Member = "CreateTriangularPrism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001380")]
		 get { } //Length: 245
	}

	[Token(Token = "0x17000606")]
	public Mesh UnitWireBox
	{
		[Address(RVA = "0x596F50", Offset = "0x596150", Length = "0xA0")]
		[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BoxMesh), Member = "CreateWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600137D")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000612")]
	public Mesh UnitWireCircleXY
	{
		[Address(RVA = "0x596FF0", Offset = "0x5961F0", Length = "0xA5")]
		[CalledBy(Type = typeof(CircleShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConeShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SphereShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CircleMesh), Member = "CreateWireCircleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001389")]
		 get { } //Length: 165
	}

	[Token(Token = "0x17000616")]
	public Mesh UnitWireEqTriangleXY
	{
		[Address(RVA = "0x5970A0", Offset = "0x5962A0", Length = "0xE0")]
		[CalledBy(Type = typeof(EqTriangle3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TriangleMesh), Member = "CreateWireEqXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600138D")]
		 get { } //Length: 224
	}

	[Token(Token = "0x17000608")]
	public Mesh UnitWirePyramid
	{
		[Address(RVA = "0x597180", Offset = "0x596380", Length = "0xE9")]
		[CalledBy(Type = typeof(PyramidShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PyramidMesh), Member = "CreateWirePyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600137F")]
		 get { } //Length: 233
	}

	[Token(Token = "0x17000610")]
	public Mesh UnitWireQuadXY
	{
		[Address(RVA = "0x597270", Offset = "0x596470", Length = "0xEF")]
		[CalledBy(Type = typeof(QuadShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(QuadMesh), Member = "CreateWireQuadXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001387")]
		 get { } //Length: 239
	}

	[Token(Token = "0x17000614")]
	public Mesh UnitWireRightAngledTriangleXY
	{
		[Address(RVA = "0x597360", Offset = "0x596560", Length = "0xED")]
		[CalledBy(Type = typeof(RightAngTriangle3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TriangleMesh), Member = "CreateWireRightAngledTriangleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600138B")]
		 get { } //Length: 237
	}

	[Token(Token = "0x1700060A")]
	public Mesh UnitWireTriangularPrism
	{
		[Address(RVA = "0x597450", Offset = "0x596650", Length = "0xF5")]
		[CalledBy(Type = typeof(TriangPrismShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PrismMesh), Member = "CreateWireTriangularPrism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001381")]
		 get { } //Length: 245
	}

	[Address(RVA = "0x5962B0", Offset = "0x5954B0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600138E")]
	public MeshPool() { }

	[Address(RVA = "0x596310", Offset = "0x595510", Length = "0xA0")]
	[CalledBy(Type = typeof(BoxShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxMesh), Member = "CreateBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600137C")]
	public Mesh get_UnitBox() { }

	[Address(RVA = "0x5963B0", Offset = "0x5955B0", Length = "0xA5")]
	[CalledBy(Type = typeof(CircleShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CircleMesh), Member = "CreateCircleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001388")]
	public Mesh get_UnitCircleXY() { }

	[Address(RVA = "0x596460", Offset = "0x595660", Length = "0xC3")]
	[CalledBy(Type = typeof(ConeShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CylinderMesh), Member = "CreateCylinder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001382")]
	public Mesh get_UnitCone() { }

	[Address(RVA = "0x596530", Offset = "0x595730", Length = "0x94")]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LineMesh), Member = "CreateCoordSystemAxesLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001385")]
	public Mesh get_UnitCoordSystem() { }

	[Address(RVA = "0x5965D0", Offset = "0x5957D0", Length = "0xC3")]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CylinderMesh), Member = "CreateCylinder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001383")]
	public Mesh get_UnitCylinder() { }

	[Address(RVA = "0x5966A0", Offset = "0x5958A0", Length = "0xF1")]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TorusMesh), Member = "CreateCylindricalTorus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001379")]
	public Mesh get_UnitCylindricalTorus() { }

	[Address(RVA = "0x5967A0", Offset = "0x5959A0", Length = "0xE0")]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriangleMesh), Member = "CreateEqXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600138C")]
	public Mesh get_UnitEqTriangleXY() { }

	[Address(RVA = "0x596880", Offset = "0x595A80", Length = "0xE9")]
	[CalledBy(Type = typeof(PyramidShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PyramidMesh), Member = "CreatePyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600137E")]
	public Mesh get_UnitPyramid() { }

	[Address(RVA = "0x596970", Offset = "0x595B70", Length = "0x97")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuadShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EditorPrefabPreviewGen), Member = "BeginGenSession", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrefabPreviewLookAndFeel)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EditorPrefabPreviewGen), Member = "CreateNonMeshPreviewObject", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QuadMesh), Member = "CreateQuadXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600137A")]
	public Mesh get_UnitQuadXY() { }

	[Address(RVA = "0x596A10", Offset = "0x595C10", Length = "0xA3")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QuadMesh), Member = "CreateQuadXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600137B")]
	public Mesh get_UnitQuadXZ() { }

	[Address(RVA = "0x596AC0", Offset = "0x595CC0", Length = "0xED")]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriangleMesh), Member = "CreateRightAngledTriangleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600138A")]
	public Mesh get_UnitRightAngledTriangleXY() { }

	[Address(RVA = "0x596BB0", Offset = "0x595DB0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LineMesh), Member = "CreateLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001386")]
	public Mesh get_UnitSegmentX() { }

	[Address(RVA = "0x596CA0", Offset = "0x595EA0", Length = "0xA2")]
	[CalledBy(Type = typeof(SphereTreeNode`1), Member = "DebugDraw", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SphereMesh), Member = "CreateSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001384")]
	public Mesh get_UnitSphere() { }

	[Address(RVA = "0x596D50", Offset = "0x595F50", Length = "0xF4")]
	[CalledBy(Type = typeof(TorusShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TorusMesh), Member = "CreateTorus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001378")]
	public Mesh get_UnitTorus() { }

	[Address(RVA = "0x596E50", Offset = "0x596050", Length = "0xF5")]
	[CalledBy(Type = typeof(TriangPrismShape3D), Member = "RenderSolid", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrismMesh), Member = "CreateTriangularPrism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001380")]
	public Mesh get_UnitTriangularPrism() { }

	[Address(RVA = "0x596F50", Offset = "0x596150", Length = "0xA0")]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BoxMesh), Member = "CreateWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600137D")]
	public Mesh get_UnitWireBox() { }

	[Address(RVA = "0x596FF0", Offset = "0x5961F0", Length = "0xA5")]
	[CalledBy(Type = typeof(CircleShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SphereShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CircleMesh), Member = "CreateWireCircleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001389")]
	public Mesh get_UnitWireCircleXY() { }

	[Address(RVA = "0x5970A0", Offset = "0x5962A0", Length = "0xE0")]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriangleMesh), Member = "CreateWireEqXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600138D")]
	public Mesh get_UnitWireEqTriangleXY() { }

	[Address(RVA = "0x597180", Offset = "0x596380", Length = "0xE9")]
	[CalledBy(Type = typeof(PyramidShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PyramidMesh), Member = "CreateWirePyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600137F")]
	public Mesh get_UnitWirePyramid() { }

	[Address(RVA = "0x597270", Offset = "0x596470", Length = "0xEF")]
	[CalledBy(Type = typeof(QuadShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QuadMesh), Member = "CreateWireQuadXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001387")]
	public Mesh get_UnitWireQuadXY() { }

	[Address(RVA = "0x597360", Offset = "0x596560", Length = "0xED")]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriangleMesh), Member = "CreateWireRightAngledTriangleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600138B")]
	public Mesh get_UnitWireRightAngledTriangleXY() { }

	[Address(RVA = "0x597450", Offset = "0x596650", Length = "0xF5")]
	[CalledBy(Type = typeof(TriangPrismShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PrismMesh), Member = "CreateWireTriangularPrism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001381")]
	public Mesh get_UnitWireTriangularPrism() { }

}


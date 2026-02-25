namespace RLD;

[Token(Token = "0x2000247")]
public class CylTorusShape3D : Shape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000901")]
	private float _coreRadius; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000902")]
	private float _hrzRadius; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000903")]
	private float _vertRadius; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000904")]
	private Vector3 _center; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000905")]
	private Quaternion _rotation; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000906")]
	private TorusEpsilon _epsilon; //Field offset: 0x38

	[Token(Token = "0x1700074B")]
	public Vector3 Bottom
	{
		[Address(RVA = "0x5ADBA0", Offset = "0x5ACDA0", Length = "0xEA")]
		[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001667")]
		 get { } //Length: 234
		[Address(RVA = "0x5ADF30", Offset = "0x5AD130", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001668")]
		 set { } //Length: 202
	}

	[Token(Token = "0x1700074D")]
	public Vector3 Center
	{
		[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600166B")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8860", Offset = "0x3B7A60", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600166C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000748")]
	public float CoreRadius
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001661")]
		 get { } //Length: 6
		[Address(RVA = "0x5AE000", Offset = "0x5AD200", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001662")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000753")]
	public float CylHrzRadiusEps
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001674")]
		 get { } //Length: 6
		[Address(RVA = "0x5AE010", Offset = "0x5AD210", Length = "0x13")]
		[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001675")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000754")]
	public float CylVertRadiusEps
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001676")]
		 get { } //Length: 6
		[Address(RVA = "0x5AE030", Offset = "0x5AD230", Length = "0x13")]
		[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001677")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000752")]
	public TorusEpsilon Epsilon
	{
		[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001672")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001673")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000749")]
	public float HrzRadius
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001663")]
		 get { } //Length: 6
		[Address(RVA = "0x5A7850", Offset = "0x5A6A50", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001664")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000751")]
	public Vector3 Look
	{
		[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001671")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000758")]
	public static Vector3 ModelCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600167B")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000757")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600167A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000755")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001678")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000756")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001679")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700074F")]
	public Vector3 Right
	{
		[Address(RVA = "0x5ADD20", Offset = "0x5ACF20", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600166F")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700074E")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600166D")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600166E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700074C")]
	public Vector3 Top
	{
		[Address(RVA = "0x5ADDB0", Offset = "0x5ACFB0", Length = "0xE2")]
		[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001669")]
		 get { } //Length: 226
		[Address(RVA = "0x5AE050", Offset = "0x5AD250", Length = "0xCC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600166A")]
		 set { } //Length: 204
	}

	[Token(Token = "0x17000750")]
	public Vector3 Up
	{
		[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001670")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700074A")]
	public float VertRadius
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001665")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001666")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5ADB00", Offset = "0x5ACD00", Length = "0x97")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001681")]
	public CylTorusShape3D() { }

	[Address(RVA = "0x5ADBA0", Offset = "0x5ACDA0", Length = "0xEA")]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001667")]
	public Vector3 get_Bottom() { }

	[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600166B")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001661")]
	public float get_CoreRadius() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001674")]
	public float get_CylHrzRadiusEps() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001676")]
	public float get_CylVertRadiusEps() { }

	[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001672")]
	public TorusEpsilon get_Epsilon() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001663")]
	public float get_HrzRadius() { }

	[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001671")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600167B")]
	public static Vector3 get_ModelCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600167A")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001678")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001679")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5ADD20", Offset = "0x5ACF20", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600166F")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600166D")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5ADDB0", Offset = "0x5ACFB0", Length = "0xE2")]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001669")]
	public Vector3 get_Top() { }

	[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001670")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001665")]
	public float get_VertRadius() { }

	[Address(RVA = "0x5ACFE0", Offset = "0x5AC1E0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorusMath), Member = "CalcCylAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(AABB))]
	[Token(Token = "0x6001680")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5AD060", Offset = "0x5AC260", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorusMath), Member = "Calc3DHrzExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x600167F")]
	public List<Vector3> GetHrzExtents() { }

	[Address(RVA = "0x5AD0B0", Offset = "0x5AC2B0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorusMath), Member = "RaycastCylindrical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600167C")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5AD150", Offset = "0x5AC350", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitCylindricalTorus", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600167D")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5AD310", Offset = "0x5AC510", Length = "0x7E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireCircleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CylTorusShape3D), Member = "get_Bottom", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CylTorusShape3D), Member = "get_Top", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600167E")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5ADF30", Offset = "0x5AD130", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001668")]
	public void set_Bottom(Vector3 value) { }

	[Address(RVA = "0x3B8860", Offset = "0x3B7A60", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600166C")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x5AE000", Offset = "0x5AD200", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001662")]
	public void set_CoreRadius(float value) { }

	[Address(RVA = "0x5AE010", Offset = "0x5AD210", Length = "0x13")]
	[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001675")]
	public void set_CylHrzRadiusEps(float value) { }

	[Address(RVA = "0x5AE030", Offset = "0x5AD230", Length = "0x13")]
	[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001677")]
	public void set_CylVertRadiusEps(float value) { }

	[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001673")]
	public void set_Epsilon(TorusEpsilon value) { }

	[Address(RVA = "0x5A7850", Offset = "0x5A6A50", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001664")]
	public void set_HrzRadius(float value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600166E")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5AE050", Offset = "0x5AD250", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600166A")]
	public void set_Top(Vector3 value) { }

	[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001666")]
	public void set_VertRadius(float value) { }

}


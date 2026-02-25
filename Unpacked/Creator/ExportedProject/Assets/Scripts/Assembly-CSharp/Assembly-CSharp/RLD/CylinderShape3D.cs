namespace RLD;

[Token(Token = "0x2000246")]
public class CylinderShape3D : Shape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008FC")]
	private Vector3 _baseCenter; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40008FD")]
	private float _radius; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008FE")]
	private float _height; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008FF")]
	private Quaternion _rotation; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000900")]
	private CylinderEpsilon _epsilon; //Field offset: 0x34

	[Token(Token = "0x17000737")]
	public Vector3 BaseCenter
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600163D")]
		 get { } //Length: 19
		[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600163E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000739")]
	public Vector3 Center
	{
		[Address(RVA = "0x5AF210", Offset = "0x5AE410", Length = "0xF6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001641")]
		 get { } //Length: 246
		[Address(RVA = "0x5AF420", Offset = "0x5AE620", Length = "0xED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001642")]
		 set { } //Length: 237
	}

	[Token(Token = "0x17000740")]
	public Vector3 CentralAxis
	{
		[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600164F")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700073D")]
	public CylinderEpsilon Epsilon
	{
		[Address(RVA = "0x5AF310", Offset = "0x5AE510", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001649")]
		 get { } //Length: 19
		[Address(RVA = "0x5AF510", Offset = "0x5AE710", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600164A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700073B")]
	public float Height
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001645")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001646")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000743")]
	public Vector3 Look
	{
		[Address(RVA = "0x5ACCC0", Offset = "0x5ABEC0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001652")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000747")]
	public static Vector3 ModelBaseCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001656")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000746")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001655")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000744")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001653")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000745")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001654")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700073A")]
	public float Radius
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001643")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001644")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700073E")]
	public float RadiusEps
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600164B")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9930", Offset = "0x5A8B30", Length = "0xC")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600164C")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000741")]
	public Vector3 Right
	{
		[Address(RVA = "0x5ACD50", Offset = "0x5ABF50", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001650")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700073C")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001647")]
		 get { } //Length: 11
		[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001648")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000738")]
	public Vector3 TopCenter
	{
		[Address(RVA = "0x5AF330", Offset = "0x5AE530", Length = "0xE2")]
		[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CylinderShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CylinderShape3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CylinderShape3D), Member = "GetTopCapExtentPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600163F")]
		 get { } //Length: 226
		[Address(RVA = "0x5AF520", Offset = "0x5AE720", Length = "0xCC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001640")]
		 set { } //Length: 204
	}

	[Token(Token = "0x17000742")]
	public Vector3 Up
	{
		[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001651")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700073F")]
	public float VertEps
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600164D")]
		 get { } //Length: 6
		[Address(RVA = "0x5AF5F0", Offset = "0x5AE7F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600164E")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x5AF180", Offset = "0x5AE380", Length = "0x90")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001660")]
	public CylinderShape3D() { }

	[Address(RVA = "0x5AB7E0", Offset = "0x5AA9E0", Length = "0x287")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001657")]
	public void AlignCentralAxis(Vector3 axis) { }

	[Address(RVA = "0x5AE120", Offset = "0x5AD320", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CylinderShape3D), Member = "get_TopCenter", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CylinderMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600165B")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600163D")]
	public Vector3 get_BaseCenter() { }

	[Address(RVA = "0x5AF210", Offset = "0x5AE410", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001641")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600164F")]
	public Vector3 get_CentralAxis() { }

	[Address(RVA = "0x5AF310", Offset = "0x5AE510", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001649")]
	public CylinderEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001645")]
	public float get_Height() { }

	[Address(RVA = "0x5ACCC0", Offset = "0x5ABEC0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001652")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001656")]
	public static Vector3 get_ModelBaseCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001655")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001653")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001654")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001643")]
	public float get_Radius() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600164B")]
	public float get_RadiusEps() { }

	[Address(RVA = "0x5ACD50", Offset = "0x5ABF50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001650")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001647")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5AF330", Offset = "0x5AE530", Length = "0xE2")]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "GetTopCapExtentPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600163F")]
	public Vector3 get_TopCenter() { }

	[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001651")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600164D")]
	public float get_VertEps() { }

	[Address(RVA = "0x5AE1E0", Offset = "0x5AD3E0", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(AABB), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Token(Token = "0x600165F")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5AE410", Offset = "0x5AD610", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CylinderMath), Member = "CalcExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x600165C")]
	public List<Vector3> GetBottomCapExtentPoints() { }

	[Address(RVA = "0x5AE450", Offset = "0x5AD650", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x600165E")]
	public AABB GetModelAABB() { }

	[Address(RVA = "0x5AE580", Offset = "0x5AD780", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CylinderShape3D), Member = "get_TopCenter", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CylinderMath), Member = "CalcExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x600165D")]
	public List<Vector3> GetTopCapExtentPoints() { }

	[Address(RVA = "0x5AE5D0", Offset = "0x5AD7D0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CylinderShape3D), Member = "get_TopCenter", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600165A")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5AE6A0", Offset = "0x5AD8A0", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitCylinder", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001658")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5AE830", Offset = "0x5ADA30", Length = "0x944")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireCircleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CylinderShape3D), Member = "get_TopCenter", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CylinderMath), Member = "CalcExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLinePairs3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001659")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600163E")]
	public void set_BaseCenter(Vector3 value) { }

	[Address(RVA = "0x5AF420", Offset = "0x5AE620", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001642")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x5AF510", Offset = "0x5AE710", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600164A")]
	public void set_Epsilon(CylinderEpsilon value) { }

	[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001646")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001644")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x5A9930", Offset = "0x5A8B30", Length = "0xC")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600164C")]
	public void set_RadiusEps(float value) { }

	[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001648")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5AF520", Offset = "0x5AE720", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001640")]
	public void set_TopCenter(Vector3 value) { }

	[Address(RVA = "0x5AF5F0", Offset = "0x5AE7F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600164E")]
	public void set_VertEps(float value) { }

}


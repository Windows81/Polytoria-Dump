namespace RLD;

[Token(Token = "0x200025D")]
public class SphereShape3D : Shape3D
{
	[Token(Token = "0x200025F")]
	internal class WireRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400096C")]
		private WireRenderMode _wireMode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400096D")]
		private int _numDetailAxialRings; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400096E")]
		private int _numDetailSliceRings; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400096F")]
		private float _radiusAdd; //Field offset: 0x1C

		[Token(Token = "0x170007FC")]
		public int NumDetailAxialRings
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F3")]
			 get { } //Length: 4
			[Address(RVA = "0x5C3C80", Offset = "0x5C2E80", Length = "0x10")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F4")]
			 set { } //Length: 16
		}

		[Token(Token = "0x170007FD")]
		public int NumDetailSliceRings
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F5")]
			 get { } //Length: 4
			[Address(RVA = "0x5C3C90", Offset = "0x5C2E90", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60017F6")]
			 set { } //Length: 13
		}

		[Token(Token = "0x170007FE")]
		public float RadiusAdd
		{
			[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F7")]
			 get { } //Length: 6
			[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F8")]
			 set { } //Length: 6
		}

		[Token(Token = "0x170007FB")]
		public WireRenderMode WireMode
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F1")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F2")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5C3C10", Offset = "0x5C2E10", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F9")]
		public WireRenderDescriptor() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F3")]
		public int get_NumDetailAxialRings() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F5")]
		public int get_NumDetailSliceRings() { }

		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F7")]
		public float get_RadiusAdd() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F1")]
		public WireRenderMode get_WireMode() { }

		[Address(RVA = "0x5C3C80", Offset = "0x5C2E80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F4")]
		public void set_NumDetailAxialRings(int value) { }

		[Address(RVA = "0x5C3C90", Offset = "0x5C2E90", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60017F6")]
		public void set_NumDetailSliceRings(int value) { }

		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F8")]
		public void set_RadiusAdd(float value) { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F2")]
		public void set_WireMode(WireRenderMode value) { }

	}

	[Token(Token = "0x200025E")]
	internal enum WireRenderMode
	{
		Basic = 0,
		Detailed = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000964")]
	private float _radius; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000965")]
	private Vector3 _center; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000966")]
	private Quaternion _rotation; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000967")]
	private SphereEpsilon _epsilon; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000968")]
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x38

	[Token(Token = "0x170007EE")]
	public Vector3 Center
	{
		[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DA")]
		 get { } //Length: 19
		[Address(RVA = "0x5BD490", Offset = "0x5BC690", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DB")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170007F3")]
	public Vector3 CentralAxis
	{
		[Address(RVA = "0x5AAB30", Offset = "0x5A9D30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E3")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007F0")]
	public SphereEpsilon Epsilon
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DE")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170007F6")]
	public Vector3 Look
	{
		[Address(RVA = "0x5AAA00", Offset = "0x5A9C00", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E6")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007FA")]
	public static Vector3 ModelCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60017EA")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170007F9")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E9")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007F7")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E7")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007F8")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E8")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007EC")]
	public float Radius
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017D7")]
		 get { } //Length: 6
		[Address(RVA = "0x5AE000", Offset = "0x5AD200", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017D8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007F1")]
	public float RadiusEps
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E0")]
		 get { } //Length: 6
		[Address(RVA = "0x5AABE0", Offset = "0x5A9DE0", Length = "0xC")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E1")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007F4")]
	public Vector3 Right
	{
		[Address(RVA = "0x5AAA90", Offset = "0x5A9C90", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E4")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007EF")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DC")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170007F5")]
	public Vector3 Up
	{
		[Address(RVA = "0x5AAB30", Offset = "0x5A9D30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E5")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007ED")]
	public float WireRadius
	{
		[Address(RVA = "0x5C1D70", Offset = "0x5C0F70", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017D9")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170007F2")]
	public WireRenderDescriptor WireRenderDesc
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5C1C80", Offset = "0x5C0E80", Length = "0xE5")]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60017F0")]
	public SphereShape3D() { }

	[Address(RVA = "0x5C0CF0", Offset = "0x5BFEF0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphereMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60017EE")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017DA")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x5AAB30", Offset = "0x5A9D30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E3")]
	public Vector3 get_CentralAxis() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60017DE")]
	public SphereEpsilon get_Epsilon() { }

	[Address(RVA = "0x5AAA00", Offset = "0x5A9C00", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E6")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60017EA")]
	public static Vector3 get_ModelCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E9")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E7")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E8")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017D7")]
	public float get_Radius() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E0")]
	public float get_RadiusEps() { }

	[Address(RVA = "0x5AAA90", Offset = "0x5A9C90", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E4")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017DC")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5AAB30", Offset = "0x5A9D30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E5")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x5C1D70", Offset = "0x5C0F70", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60017D9")]
	public float get_WireRadius() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E2")]
	public WireRenderDescriptor get_WireRenderDesc() { }

	[Address(RVA = "0x5C0D40", Offset = "0x5BFF40", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017EF")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5C0DD0", Offset = "0x5BFFD0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SphereMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60017ED")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5C0E30", Offset = "0x5C0030", Length = "0x1C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitSphere", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60017EB")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5C1000", Offset = "0x5C0200", Length = "0xC78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireCircleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60017EC")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5BD490", Offset = "0x5BC690", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017DB")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017DF")]
	public void set_Epsilon(SphereEpsilon value) { }

	[Address(RVA = "0x5AE000", Offset = "0x5AD200", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017D8")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x5AABE0", Offset = "0x5A9DE0", Length = "0xC")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017E1")]
	public void set_RadiusEps(float value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017DD")]
	public void set_Rotation(Quaternion value) { }

}


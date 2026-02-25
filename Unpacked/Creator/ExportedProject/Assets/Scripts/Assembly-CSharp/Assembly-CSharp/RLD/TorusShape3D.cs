namespace RLD;

[Token(Token = "0x2000260")]
public class TorusShape3D : Shape3D
{
	[Token(Token = "0x2000262")]
	internal class WireRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400097B")]
		private WireRenderFlags _wireFlags; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400097C")]
		private int _numTubeSlices; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400097D")]
		private int _numAxialSlices; //Field offset: 0x18

		[Token(Token = "0x1700080E")]
		public int NumAxialSlices
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001816")]
			 get { } //Length: 4
			[Address(RVA = "0x5C3C70", Offset = "0x5C2E70", Length = "0x10")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001817")]
			 set { } //Length: 16
		}

		[Token(Token = "0x1700080D")]
		public int NumTubeSlices
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001814")]
			 get { } //Length: 4
			[Address(RVA = "0x5C3CA0", Offset = "0x5C2EA0", Length = "0xD")]
			[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x6001815")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700080F")]
		public WireRenderFlags WireFlags
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001818")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001819")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5C3BF0", Offset = "0x5C2DF0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600181A")]
		public WireRenderDescriptor() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001816")]
		public int get_NumAxialSlices() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001814")]
		public int get_NumTubeSlices() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001818")]
		public WireRenderFlags get_WireFlags() { }

		[Address(RVA = "0x5C3C70", Offset = "0x5C2E70", Length = "0x10")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001817")]
		public void set_NumAxialSlices(int value) { }

		[Address(RVA = "0x5C3CA0", Offset = "0x5C2EA0", Length = "0xD")]
		[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6001815")]
		public void set_NumTubeSlices(int value) { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001819")]
		public void set_WireFlags(WireRenderFlags value) { }

	}

	[Token(Token = "0x2000261")]
	internal enum WireRenderFlags
	{
		None = 0,
		TubeSlices = 1,
		AxialSlices = 2,
		All = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000970")]
	private float _coreRadius; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000971")]
	private float _tubeRadius; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000972")]
	private Vector3 _center; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000973")]
	private Quaternion _rotation; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000974")]
	private TorusEpsilon _epsilon; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000975")]
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x40

	[Token(Token = "0x17000801")]
	public Vector3 Center
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FE")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FF")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170007FF")]
	public float CoreRadius
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FA")]
		 get { } //Length: 6
		[Address(RVA = "0x5AE000", Offset = "0x5AD200", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000806")]
	public TorusEpsilon Epsilon
	{
		[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001805")]
		 get { } //Length: 19
		[Address(RVA = "0x5A9900", Offset = "0x5A8B00", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001806")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000805")]
	public Vector3 Look
	{
		[Address(RVA = "0x5ACCC0", Offset = "0x5ABEC0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001804")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700080C")]
	public static Vector3 ModelCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600180D")]
		 get { } //Length: 74
	}

	[Token(Token = "0x1700080B")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600180C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000809")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600180A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700080A")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600180B")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000803")]
	public Vector3 Right
	{
		[Address(RVA = "0x5ACD50", Offset = "0x5ABF50", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001802")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000802")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001800")]
		 get { } //Length: 11
		[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001801")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000800")]
	public float TubeRadius
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FC")]
		 get { } //Length: 6
		[Address(RVA = "0x5A7850", Offset = "0x5A6A50", Length = "0xD")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000807")]
	public float TubeRadiusEps
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001807")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9930", Offset = "0x5A8B30", Length = "0xC")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001808")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000804")]
	public Vector3 Up
	{
		[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001803")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000808")]
	public WireRenderDescriptor WireRenderDesc
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001809")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5C29B0", Offset = "0x5C1BB0", Length = "0xF3")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(CircleShape3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001813")]
	public TorusShape3D() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017FE")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017FA")]
	public float get_CoreRadius() { }

	[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001805")]
	public TorusEpsilon get_Epsilon() { }

	[Address(RVA = "0x5ACCC0", Offset = "0x5ABEC0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001804")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600180D")]
	public static Vector3 get_ModelCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600180C")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600180A")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600180B")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5ACD50", Offset = "0x5ABF50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001802")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001800")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017FC")]
	public float get_TubeRadius() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001807")]
	public float get_TubeRadiusEps() { }

	[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001803")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001809")]
	public WireRenderDescriptor get_WireRenderDesc() { }

	[Address(RVA = "0x5C1DA0", Offset = "0x5C0FA0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorusMath), Member = "CalcSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001812")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5C1E40", Offset = "0x5C1040", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorusMath), Member = "Calc3DHrzExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x6001811")]
	public List<Vector3> GetHrzExtents() { }

	[Address(RVA = "0x5C1E90", Offset = "0x5C1090", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TorusMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600180E")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5C1F20", Offset = "0x5C1120", Length = "0x1B5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitTorus", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600180F")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5C20E0", Offset = "0x5C12E0", Length = "0x8CB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireCircleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802895C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AB60")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001810")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017FF")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x5AE000", Offset = "0x5AD200", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017FB")]
	public void set_CoreRadius(float value) { }

	[Address(RVA = "0x5A9900", Offset = "0x5A8B00", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001806")]
	public void set_Epsilon(TorusEpsilon value) { }

	[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001801")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5A7850", Offset = "0x5A6A50", Length = "0xD")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017FD")]
	public void set_TubeRadius(float value) { }

	[Address(RVA = "0x5A9930", Offset = "0x5A8B30", Length = "0xC")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001808")]
	public void set_TubeRadiusEps(float value) { }

}


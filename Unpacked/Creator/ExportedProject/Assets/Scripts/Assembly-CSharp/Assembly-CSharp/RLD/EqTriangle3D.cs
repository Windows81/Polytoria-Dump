namespace RLD;

[Token(Token = "0x2000249")]
public class EqTriangle3D : Shape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400090D")]
	private float _sideLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400090E")]
	private Quaternion _rotation; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400090F")]
	private TriangleEpsilon _epsilon; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000910")]
	private Vector3[] _points; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000911")]
	private Vector3 _centroid; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000912")]
	private bool _arePointsDirty; //Field offset: 0x44

	[Token(Token = "0x17000768")]
	public float Altitude
	{
		[Address(RVA = "0x5B2550", Offset = "0x5B1750", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60016A2")]
		 get { } //Length: 149
	}

	[Token(Token = "0x1700076C")]
	public float AreaEps
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A8")]
		 get { } //Length: 6
		[Address(RVA = "0x5B2840", Offset = "0x5B1A40", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A9")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000767")]
	public Vector3 Centroid
	{
		[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A0")]
		 get { } //Length: 19
		[Address(RVA = "0x5B2850", Offset = "0x5B1A50", Length = "0x104")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60016A1")]
		 set { } //Length: 260
	}

	[Token(Token = "0x17000769")]
	public float CentroidAltitude
	{
		[Address(RVA = "0x5B25F0", Offset = "0x5B17F0", Length = "0x9D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60016A3")]
		 get { } //Length: 157
	}

	[Token(Token = "0x1700076B")]
	public TriangleEpsilon Epsilon
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A6")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A7")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700076D")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AA")]
		 get { } //Length: 6
		[Address(RVA = "0x5B2960", Offset = "0x5B1B60", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AB")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000772")]
	public Vector3 Look
	{
		[Address(RVA = "0x5B2690", Offset = "0x5B1890", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B1")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000776")]
	public static Vector3 ModelCentroid
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B5")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000775")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B4")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000773")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B2")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000774")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B3")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700076F")]
	public Vector3 Normal
	{
		[Address(RVA = "0x5B2690", Offset = "0x5B1890", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AE")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000770")]
	public Vector3 Right
	{
		[Address(RVA = "0x5B2720", Offset = "0x5B1920", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60016AF")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700076A")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3BAA40", Offset = "0x3B9C40", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A4")]
		 get { } //Length: 11
		[Address(RVA = "0x3BAA50", Offset = "0x3B9C50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A5")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000766")]
	public float SideLength
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600169E")]
		 get { } //Length: 6
		[Address(RVA = "0x5B2970", Offset = "0x5B1B70", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600169F")]
		 set { } //Length: 17
	}

	[Token(Token = "0x17000771")]
	public Vector3 Up
	{
		[Address(RVA = "0x5B27B0", Offset = "0x5B19B0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60016B0")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700076E")]
	public float WireEps
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AC")]
		 get { } //Length: 6
		[Address(RVA = "0x5B2990", Offset = "0x5B1B90", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60016AD")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x5B2480", Offset = "0x5B1680", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016C3")]
	public EqTriangle3D() { }

	[Address(RVA = "0x5B0EF0", Offset = "0x5B00F0", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60016B6")]
	public void AlignNormal(Vector3 axis) { }

	[Address(RVA = "0x5B1180", Offset = "0x5B0380", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60016B7")]
	public void AlignRight(Vector3 axis) { }

	[Address(RVA = "0x5B1410", Offset = "0x5B0610", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60016B8")]
	public void AlignUp(Vector3 axis) { }

	[Address(RVA = "0x5B2550", Offset = "0x5B1750", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60016A2")]
	public float get_Altitude() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A8")]
	public float get_AreaEps() { }

	[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A0")]
	public Vector3 get_Centroid() { }

	[Address(RVA = "0x5B25F0", Offset = "0x5B17F0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60016A3")]
	public float get_CentroidAltitude() { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A6")]
	public TriangleEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016AA")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x5B2690", Offset = "0x5B1890", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60016B1")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60016B5")]
	public static Vector3 get_ModelCentroid() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60016B4")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60016B2")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60016B3")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5B2690", Offset = "0x5B1890", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60016AE")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x5B2720", Offset = "0x5B1920", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60016AF")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3BAA40", Offset = "0x3B9C40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A4")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600169E")]
	public float get_SideLength() { }

	[Address(RVA = "0x5B27B0", Offset = "0x5B19B0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60016B0")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016AC")]
	public float get_WireEps() { }

	[Address(RVA = "0x5B16A0", Offset = "0x5B08A0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60016C1")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5B1860", Offset = "0x5B0A60", Length = "0x1D9")]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "GetEdgeMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016BC")]
	public Vector3 GetEdge(EqTriangleEdge edge) { }

	[Address(RVA = "0x5B16F0", Offset = "0x5B08F0", Length = "0x16F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(EqTriangle3D), Member = "GetEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016BB")]
	public Vector3 GetEdgeMidPoint(EqTriangleEdge edge) { }

	[Address(RVA = "0x5B1A40", Offset = "0x5B0C40", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016B9")]
	public Vector3 GetPoint(EqTrianglePoint point) { }

	[Address(RVA = "0x5B1AB0", Offset = "0x5B0CB0", Length = "0x189")]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTrianglePoint)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "SetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTrianglePoint), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "GetEdgeMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "GetEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "CalcEqTriangle3DPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016C2")]
	private void OnPointsFoundDirty() { }

	[Address(RVA = "0x5B1E20", Offset = "0x5B1020", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016BF")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5B1C40", Offset = "0x5B0E40", Length = "0x1DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016C0")]
	public virtual bool RaycastWire(Ray ray, out float t) { }

	[Address(RVA = "0x5B2000", Offset = "0x5B1200", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitEqTriangleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016BD")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5B2190", Offset = "0x5B1390", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireEqTriangleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016BE")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5B2840", Offset = "0x5B1A40", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A9")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x5B2850", Offset = "0x5B1A50", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016A1")]
	public void set_Centroid(Vector3 value) { }

	[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A7")]
	public void set_Epsilon(TriangleEpsilon value) { }

	[Address(RVA = "0x5B2960", Offset = "0x5B1B60", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016AB")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x3BAA50", Offset = "0x3B9C50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60016A5")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5B2970", Offset = "0x5B1B70", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600169F")]
	public void set_SideLength(float value) { }

	[Address(RVA = "0x5B2990", Offset = "0x5B1B90", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016AD")]
	public void set_WireEps(float value) { }

	[Address(RVA = "0x5B2320", Offset = "0x5B1520", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60016BA")]
	public void SetPoint(EqTrianglePoint point, Vector3 pointValue) { }

}


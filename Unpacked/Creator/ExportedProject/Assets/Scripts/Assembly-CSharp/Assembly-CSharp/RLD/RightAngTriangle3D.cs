namespace RLD;

[Token(Token = "0x2000253")]
public class RightAngTriangle3D : Shape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000941")]
	private Vector3 _rightAngleCorner; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000942")]
	private float _XLength; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000943")]
	private float _YLength; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000944")]
	private AxisSign _XLengthSign; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000945")]
	private AxisSign _YLengthSign; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000946")]
	private Quaternion _rotation; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000947")]
	private TriangleEpsilon _epsilon; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000948")]
	private Shape3DRaycastMode _raycastMode; //Field offset: 0x48

	[Token(Token = "0x170007D5")]
	public float AreaEps
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178A")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC0F0", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178B")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007D4")]
	public TriangleEpsilon Epsilon
	{
		[Address(RVA = "0x3CDF90", Offset = "0x3CD190", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001788")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0040", Offset = "0x5BF240", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001789")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170007D6")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178C")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACFD0", Offset = "0x5AC1D0", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178D")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007D1")]
	public Vector3 Look
	{
		[Address(RVA = "0x5BFD30", Offset = "0x5BEF30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001785")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007DB")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001794")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007DD")]
	public static Vector3 ModelNormal
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001796")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007D9")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001792")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007DC")]
	public static Vector3 ModelRightAngleCorner
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001795")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170007DA")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001793")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007D2")]
	public Vector3 Normal
	{
		[Address(RVA = "0x5BFD30", Offset = "0x5BEF30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001786")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007D3")]
	public Plane Plane
	{
		[Address(RVA = "0x5BFDC0", Offset = "0x5BEFC0", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001787")]
		 get { } //Length: 247
	}

	[Token(Token = "0x170007D8")]
	public Shape3DRaycastMode RaycastMode
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001790")]
		 get { } //Length: 4
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001791")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170007CA")]
	public float RealXLength
	{
		[Address(RVA = "0x5BFEC0", Offset = "0x5BF0C0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600177B")]
		 get { } //Length: 34
	}

	[Token(Token = "0x170007CB")]
	public float RealYLength
	{
		[Address(RVA = "0x5BFEF0", Offset = "0x5BF0F0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600177C")]
		 get { } //Length: 34
	}

	[Token(Token = "0x170007CF")]
	public Vector3 Right
	{
		[Address(RVA = "0x5BFF20", Offset = "0x5BF120", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001783")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007C7")]
	public Vector3 RightAngleCorner
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001775")]
		 get { } //Length: 19
		[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001776")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170007CE")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001781")]
		 get { } //Length: 11
		[Address(RVA = "0x599170", Offset = "0x598370", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001782")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170007D0")]
	public Vector3 Up
	{
		[Address(RVA = "0x5BFFB0", Offset = "0x5BF1B0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001784")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007D7")]
	public float WireEps
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178E")]
		 get { } //Length: 6
		[Address(RVA = "0x5B9B60", Offset = "0x5B8D60", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178F")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007C8")]
	public float XLength
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001777")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001778")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007CC")]
	public AxisSign XLengthSign
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600177D")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600177E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170007C9")]
	public float YLength
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001779")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x600177A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007CD")]
	public AxisSign YLengthSign
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600177F")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001780")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5BFCA0", Offset = "0x5BEEA0", Length = "0x90")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoRATriangle3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(RightAngTriangle3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017A1")]
	public RightAngTriangle3D() { }

	[Address(RVA = "0x5BEB30", Offset = "0x5BDD30", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001797")]
	public void AlignNormal(Vector3 axis) { }

	[Address(RVA = "0x5BEDC0", Offset = "0x5BDFC0", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001798")]
	public void AlignRight(Vector3 axis) { }

	[Address(RVA = "0x5BF050", Offset = "0x5BE250", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001799")]
	public void AlignUp(Vector3 axis) { }

	[Address(RVA = "0x5BF2E0", Offset = "0x5BE4E0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RightAngTriangle3D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60017A0")]
	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600178A")]
	public float get_AreaEps() { }

	[Address(RVA = "0x3CDF90", Offset = "0x3CD190", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001788")]
	public TriangleEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600178C")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x5BFD30", Offset = "0x5BEF30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001785")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001794")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001796")]
	public static Vector3 get_ModelNormal() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001792")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001795")]
	public static Vector3 get_ModelRightAngleCorner() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001793")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5BFD30", Offset = "0x5BEF30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001786")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x5BFDC0", Offset = "0x5BEFC0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001787")]
	public Plane get_Plane() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001790")]
	public Shape3DRaycastMode get_RaycastMode() { }

	[Address(RVA = "0x5BFEC0", Offset = "0x5BF0C0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600177B")]
	public float get_RealXLength() { }

	[Address(RVA = "0x5BFEF0", Offset = "0x5BF0F0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600177C")]
	public float get_RealYLength() { }

	[Address(RVA = "0x5BFF20", Offset = "0x5BF120", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001783")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001775")]
	public Vector3 get_RightAngleCorner() { }

	[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001781")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5BFFB0", Offset = "0x5BF1B0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001784")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600178E")]
	public float get_WireEps() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001777")]
	public float get_XLength() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600177D")]
	public AxisSign get_XLengthSign() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001779")]
	public float get_YLength() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600177F")]
	public AxisSign get_YLengthSign() { }

	[Address(RVA = "0x5BF450", Offset = "0x5BE650", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RightAngTriangle3D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600179F")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5BF490", Offset = "0x5BE690", Length = "0xE9")]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "CalcRATriangle3DPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x600179E")]
	public List<Vector3> GetPoints() { }

	[Address(RVA = "0x5BF6F0", Offset = "0x5BE8F0", Length = "0x24A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RightAngTriangle3D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriangleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600179A")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5BF580", Offset = "0x5BE780", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RightAngTriangle3D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600179B")]
	public virtual bool RaycastWire(Ray ray, out float t) { }

	[Address(RVA = "0x5BF940", Offset = "0x5BEB40", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitRightAngledTriangleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600179C")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5BFAF0", Offset = "0x5BECF0", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireRightAngledTriangleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600179D")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC0F0", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600178B")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x5C0040", Offset = "0x5BF240", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001789")]
	public void set_Epsilon(TriangleEpsilon value) { }

	[Address(RVA = "0x5ACFD0", Offset = "0x5AC1D0", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600178D")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001791")]
	public void set_RaycastMode(Shape3DRaycastMode value) { }

	[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001776")]
	public void set_RightAngleCorner(Vector3 value) { }

	[Address(RVA = "0x599170", Offset = "0x598370", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001782")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5B9B60", Offset = "0x5B8D60", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600178F")]
	public void set_WireEps(float value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001778")]
	public void set_XLength(float value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600177E")]
	public void set_XLengthSign(AxisSign value) { }

	[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x600177A")]
	public void set_YLength(float value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001780")]
	public void set_YLengthSign(AxisSign value) { }

}


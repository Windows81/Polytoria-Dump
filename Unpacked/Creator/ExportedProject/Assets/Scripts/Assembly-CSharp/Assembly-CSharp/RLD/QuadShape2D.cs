namespace RLD;

[Token(Token = "0x200024E")]
public class QuadShape2D : Shape2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000929")]
	private Vector2 _center; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400092A")]
	private Vector2 _size; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400092B")]
	private float _rotationDegrees; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400092C")]
	private QuadEpsilon _epsilon; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400092D")]
	private Shape2DPtContainMode _ptContainMode; //Field offset: 0x34

	[Token(Token = "0x17000795")]
	public Vector2 Center
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001709")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600170A")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700079A")]
	public QuadEpsilon Epsilon
	{
		[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001712")]
		 get { } //Length: 11
		[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001713")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000797")]
	public Vector2 Extents
	{
		[Address(RVA = "0x5BBB20", Offset = "0x5BAD20", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600170D")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000799")]
	public float Height
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001710")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001711")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700079E")]
	public float HeightEps
	{
		[Address(RVA = "0x5BBB50", Offset = "0x5BAD50", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600171A")]
		 get { } //Length: 11
		[Address(RVA = "0x5B2960", Offset = "0x5B1B60", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600171B")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007A4")]
	public static Vector2 ModelCenter
	{
		[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001722")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170007A2")]
	public static Vector2 ModelRight
	{
		[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001720")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170007A3")]
	public static Vector2 ModelUp
	{
		[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001721")]
		 get { } //Length: 69
	}

	[Token(Token = "0x1700079B")]
	public Shape2DPtContainMode PtContainMode
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001714")]
		 get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001715")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170007A0")]
	public Vector2 Right
	{
		[Address(RVA = "0x5BBB60", Offset = "0x5BAD60", Length = "0xE2")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600171E")]
		 get { } //Length: 226
	}

	[Token(Token = "0x17000794")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x5BBC50", Offset = "0x5BAE50", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Token(Token = "0x6001708")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000793")]
	public float RotationDegrees
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001706")]
		 get { } //Length: 6
		[Address(RVA = "0x5BBDF0", Offset = "0x5BAFF0", Length = "0x24")]
		[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
		[Token(Token = "0x6001707")]
		 set { } //Length: 36
	}

	[Token(Token = "0x17000796")]
	public Vector2 Size
	{
		[Address(RVA = "0x5956B0", Offset = "0x5948B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600170B")]
		 get { } //Length: 19
		[Address(RVA = "0x5BBE30", Offset = "0x5BB030", Length = "0x3B")]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "UpdateTransform", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Vector2Ex), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Token(Token = "0x600170C")]
		 set { } //Length: 59
	}

	[Token(Token = "0x1700079C")]
	public Vector2 SizeEps
	{
		[Address(RVA = "0x5BBCD0", Offset = "0x5BAED0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001716")]
		 get { } //Length: 19
		[Address(RVA = "0x5BBE20", Offset = "0x5BB020", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoBoxLineSlider2DController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(QuadEpsilon), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001717")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007A1")]
	public Vector2 Up
	{
		[Address(RVA = "0x5BBCF0", Offset = "0x5BAEF0", Length = "0xE2")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600171F")]
		 get { } //Length: 226
	}

	[Token(Token = "0x17000798")]
	public float Width
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600170E")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x600170F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700079D")]
	public float WidthEps
	{
		[Address(RVA = "0x5BBDE0", Offset = "0x5BAFE0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001718")]
		 get { } //Length: 11
		[Address(RVA = "0x5B2840", Offset = "0x5B1A40", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001719")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700079F")]
	public float WireEps
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600171C")]
		 get { } //Length: 6
		[Address(RVA = "0x5BBE70", Offset = "0x5BB070", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600171D")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x5BBA80", Offset = "0x5BAC80", Length = "0x93")]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(QuadShape2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600172A")]
	public QuadShape2D() { }

	[Address(RVA = "0x5BB340", Offset = "0x5BA540", Length = "0x20A")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001724")]
	public void AlignWidth(Vector2 axis) { }

	[Address(RVA = "0x5BB550", Offset = "0x5BA750", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadMath), Member = "Is2DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(float), typeof(Vector2), typeof(Vector2), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QuadMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(float), typeof(Vector2), typeof(Vector2), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001728")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001709")]
	public Vector2 get_Center() { }

	[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001712")]
	public QuadEpsilon get_Epsilon() { }

	[Address(RVA = "0x5BBB20", Offset = "0x5BAD20", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600170D")]
	public Vector2 get_Extents() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001710")]
	public float get_Height() { }

	[Address(RVA = "0x5BBB50", Offset = "0x5BAD50", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600171A")]
	public float get_HeightEps() { }

	[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001722")]
	public static Vector2 get_ModelCenter() { }

	[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001720")]
	public static Vector2 get_ModelRight() { }

	[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001721")]
	public static Vector2 get_ModelUp() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001714")]
	public Shape2DPtContainMode get_PtContainMode() { }

	[Address(RVA = "0x5BBB60", Offset = "0x5BAD60", Length = "0xE2")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600171E")]
	public Vector2 get_Right() { }

	[Address(RVA = "0x5BBC50", Offset = "0x5BAE50", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001708")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001706")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x5956B0", Offset = "0x5948B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600170B")]
	public Vector2 get_Size() { }

	[Address(RVA = "0x5BBCD0", Offset = "0x5BAED0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001716")]
	public Vector2 get_SizeEps() { }

	[Address(RVA = "0x5BBCF0", Offset = "0x5BAEF0", Length = "0xE2")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600171F")]
	public Vector2 get_Up() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600170E")]
	public float get_Width() { }

	[Address(RVA = "0x5BBDE0", Offset = "0x5BAFE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001718")]
	public float get_WidthEps() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600171C")]
	public float get_WireEps() { }

	[Address(RVA = "0x5BB690", Offset = "0x5BA890", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadMath), Member = "Calc2DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x6001729")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5BB6F0", Offset = "0x5BA8F0", Length = "0x187")]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "GetRealExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001723")]
	public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x5BB880", Offset = "0x5BAA80", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(float))]
	[Token(Token = "0x6001725")]
	public float GetSizeAlongDirection(Vector2 direction) { }

	[Address(RVA = "0x5BB960", Offset = "0x5BAB60", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(QuadMath), Member = "Calc2DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001726")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5BBA30", Offset = "0x5BAC30", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadMath), Member = "Calc2DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001727")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600170A")]
	public void set_Center(Vector2 value) { }

	[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001713")]
	public void set_Epsilon(QuadEpsilon value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001711")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5B2960", Offset = "0x5B1B60", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600171B")]
	public void set_HeightEps(float value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001715")]
	public void set_PtContainMode(Shape2DPtContainMode value) { }

	[Address(RVA = "0x5BBDF0", Offset = "0x5BAFF0", Length = "0x24")]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Token(Token = "0x6001707")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x5BBE30", Offset = "0x5BB030", Length = "0x3B")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "UpdateTransform", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector2Ex), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Token(Token = "0x600170C")]
	public void set_Size(Vector2 value) { }

	[Address(RVA = "0x5BBE20", Offset = "0x5BB020", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider2DController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider2DController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QuadEpsilon), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001717")]
	public void set_SizeEps(Vector2 value) { }

	[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x600170F")]
	public void set_Width(float value) { }

	[Address(RVA = "0x5B2840", Offset = "0x5B1A40", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001719")]
	public void set_WidthEps(float value) { }

	[Address(RVA = "0x5BBE70", Offset = "0x5BB070", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoThinQuad2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600171D")]
	public void set_WireEps(float value) { }

}


namespace RLD;

[Token(Token = "0x2000248")]
public class EqTriangle2D : Shape2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000907")]
	private float _sideLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000908")]
	private float _rotationDegrees; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000909")]
	private TriangleEpsilon _epsilon; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400090A")]
	private Vector2[] _points; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400090B")]
	private Vector2 _centroid; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400090C")]
	private bool _arePointsDirty; //Field offset: 0x38

	[Token(Token = "0x1700075B")]
	public float Altitude
	{
		[Address(RVA = "0x5B0A70", Offset = "0x5AFC70", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001686")]
		 get { } //Length: 149
	}

	[Token(Token = "0x17000760")]
	public float AreaEps
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600168D")]
		 get { } //Length: 6
		[Address(RVA = "0x5B0E10", Offset = "0x5B0010", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600168E")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700075A")]
	public Vector2 Centroid
	{
		[Address(RVA = "0x58DEF0", Offset = "0x58D0F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001684")]
		 get { } //Length: 19
		[Address(RVA = "0x5B0E20", Offset = "0x5B0020", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001685")]
		 set { } //Length: 165
	}

	[Token(Token = "0x1700075C")]
	public float CentroidAltitude
	{
		[Address(RVA = "0x5B0B10", Offset = "0x5AFD10", Length = "0x9D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001687")]
		 get { } //Length: 157
	}

	[Token(Token = "0x1700075F")]
	public TriangleEpsilon Epsilon
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600168B")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600168C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000765")]
	public static Vector2 ModelCentroid
	{
		[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001693")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000763")]
	public static Vector2 ModelRight
	{
		[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001691")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000764")]
	public static Vector2 ModelUp
	{
		[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001692")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000761")]
	public Vector2 Right
	{
		[Address(RVA = "0x5B0BB0", Offset = "0x5AFDB0", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600168F")]
		 get { } //Length: 226
	}

	[Token(Token = "0x1700075E")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x5B0CA0", Offset = "0x5AFEA0", Length = "0x78")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Token(Token = "0x600168A")]
		 get { } //Length: 120
	}

	[Token(Token = "0x1700075D")]
	public float RotationDegrees
	{
		[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001688")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1240", Offset = "0x2C0440", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001689")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000759")]
	public float SideLength
	{
		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001682")]
		 get { } //Length: 6
		[Address(RVA = "0x5B0ED0", Offset = "0x5B00D0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001683")]
		 set { } //Length: 17
	}

	[Token(Token = "0x17000762")]
	public Vector2 Up
	{
		[Address(RVA = "0x5B0D20", Offset = "0x5AFF20", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001690")]
		 get { } //Length: 226
	}

	[Address(RVA = "0x5B09D0", Offset = "0x5AFBD0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600169D")]
	public EqTriangle2D() { }

	[Address(RVA = "0x5AFF10", Offset = "0x5AF110", Length = "0x1AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600169A")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x5B0A70", Offset = "0x5AFC70", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001686")]
	public float get_Altitude() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600168D")]
	public float get_AreaEps() { }

	[Address(RVA = "0x58DEF0", Offset = "0x58D0F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001684")]
	public Vector2 get_Centroid() { }

	[Address(RVA = "0x5B0B10", Offset = "0x5AFD10", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001687")]
	public float get_CentroidAltitude() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600168B")]
	public TriangleEpsilon get_Epsilon() { }

	[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001693")]
	public static Vector2 get_ModelCentroid() { }

	[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001691")]
	public static Vector2 get_ModelRight() { }

	[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001692")]
	public static Vector2 get_ModelUp() { }

	[Address(RVA = "0x5B0BB0", Offset = "0x5AFDB0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600168F")]
	public Vector2 get_Right() { }

	[Address(RVA = "0x5B0CA0", Offset = "0x5AFEA0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x600168A")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x4FCAF0", Offset = "0x4FBCF0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001688")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001682")]
	public float get_SideLength() { }

	[Address(RVA = "0x5B0D20", Offset = "0x5AFF20", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001690")]
	public Vector2 get_Up() { }

	[Address(RVA = "0x5B01F0", Offset = "0x5AF3F0", Length = "0x14D")]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "GetEdgeMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001697")]
	public Vector2 GetEdge(EqTriangleEdge edge) { }

	[Address(RVA = "0x5B00C0", Offset = "0x5AF2C0", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(EqTriangle2D), Member = "GetEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001696")]
	public Vector2 GetEdgeMidPoint(EqTriangleEdge edge) { }

	[Address(RVA = "0x5B0340", Offset = "0x5AF540", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x600169B")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5B0390", Offset = "0x5AF590", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001694")]
	public Vector2 GetPoint(EqTrianglePoint point) { }

	[Address(RVA = "0x5B03F0", Offset = "0x5AF5F0", Length = "0x21A")]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTrianglePoint)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "SetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTrianglePoint), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "GetEdgeMidPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "GetEdge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EqTriangleEdge)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "RenderArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "RenderBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TriangleMath), Member = "CalcEqTriangle2DPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x600169C")]
	private void OnPointsFoundDirty() { }

	[Address(RVA = "0x5B0610", Offset = "0x5AF810", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001698")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5B0780", Offset = "0x5AF980", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001699")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5B0E10", Offset = "0x5B0010", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600168E")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x5B0E20", Offset = "0x5B0020", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001685")]
	public void set_Centroid(Vector2 value) { }

	[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600168C")]
	public void set_Epsilon(TriangleEpsilon value) { }

	[Address(RVA = "0x2C1240", Offset = "0x2C0440", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001689")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x5B0ED0", Offset = "0x5B00D0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001683")]
	public void set_SideLength(float value) { }

	[Address(RVA = "0x5B08F0", Offset = "0x5AFAF0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001695")]
	public void SetPoint(EqTrianglePoint point, Vector2 pointValue) { }

}


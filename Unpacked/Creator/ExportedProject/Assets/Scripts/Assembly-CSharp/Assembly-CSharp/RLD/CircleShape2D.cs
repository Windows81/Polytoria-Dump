namespace RLD;

[Token(Token = "0x2000240")]
public class CircleShape2D : Shape2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008DF")]
	private Vector2 _center; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008E0")]
	private float _radius; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40008E1")]
	private float _rotationDegrees; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008E2")]
	private int _numBorderPoints; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008E3")]
	private List<Vector2> _modelBorderPoints; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008E4")]
	private bool _areModelBorderPointsDirty; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008E5")]
	private CircleEpsilon _epsilon; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008E6")]
	private Shape2DPtContainMode _ptContainMode; //Field offset: 0x40

	[Token(Token = "0x170006F7")]
	public Vector2 Center
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015BA")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015BB")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170006FC")]
	public CircleEpsilon Epsilon
	{
		[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015C2")]
		 get { } //Length: 19
		[Address(RVA = "0x5A9900", Offset = "0x5A8B00", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015C3")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000703")]
	public static Vector2 ModelCenter
	{
		[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015CE")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000701")]
	public static Vector2 ModelRight
	{
		[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015CC")]
		 get { } //Length: 69
	}

	[Token(Token = "0x17000702")]
	public static Vector2 ModelUp
	{
		[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015CD")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170006FF")]
	public int NumBorderPoints
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015C8")]
		 get { } //Length: 4
		[Address(RVA = "0x5A9910", Offset = "0x5A8B10", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60015C9")]
		 set { } //Length: 20
	}

	[Token(Token = "0x17000700")]
	public Shape2DPtContainMode PtContainMode
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015CA")]
		 get { } //Length: 4
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015CB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170006F8")]
	public float Radius
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015BC")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015BD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170006FD")]
	public float RadiusEps
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015C4")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9930", Offset = "0x5A8B30", Length = "0xC")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015C5")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170006FA")]
	public Vector2 Right
	{
		[Address(RVA = "0x5A9710", Offset = "0x5A8910", Length = "0xE2")]
		[CalledBy(Type = typeof(CircleShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60015C0")]
		 get { } //Length: 226
	}

	[Token(Token = "0x170006F9")]
	public float RotationDegrees
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015BE")]
		 get { } //Length: 6
		[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015BF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170006FB")]
	public Vector2 Up
	{
		[Address(RVA = "0x5A9800", Offset = "0x5A8A00", Length = "0xE2")]
		[CalledBy(Type = typeof(CircleShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60015C1")]
		 get { } //Length: 226
	}

	[Token(Token = "0x170006FE")]
	public float WireEps
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015C6")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9940", Offset = "0x5A8B40", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoThinCircle2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015C7")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x5A95A0", Offset = "0x5A87A0", Length = "0xC6")]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircle2DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider2D), typeof(GizmoHandle), typeof(CircleShape2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60015D6")]
	public CircleShape2D() { }

	[Address(RVA = "0x5A91A0", Offset = "0x5A83A0", Length = "0x72")]
	[CalledBy(Type = typeof(CircleShape2D), Member = "RenderBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CircleShape2D), Member = "RenderArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate2DCircleBorderPointsCW", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60015D5")]
	private void CalcModelBorderPoints() { }

	[Address(RVA = "0x5A9220", Offset = "0x5A8420", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleMath), Member = "Is2DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(CircleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CircleMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(CircleEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60015D2")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015BA")]
	public Vector2 get_Center() { }

	[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015C2")]
	public CircleEpsilon get_Epsilon() { }

	[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015CE")]
	public static Vector2 get_ModelCenter() { }

	[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015CC")]
	public static Vector2 get_ModelRight() { }

	[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015CD")]
	public static Vector2 get_ModelUp() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015C8")]
	public int get_NumBorderPoints() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015CA")]
	public Shape2DPtContainMode get_PtContainMode() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015BC")]
	public float get_Radius() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015C4")]
	public float get_RadiusEps() { }

	[Address(RVA = "0x5A9710", Offset = "0x5A8910", Length = "0xE2")]
	[CalledBy(Type = typeof(CircleShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60015C0")]
	public Vector2 get_Right() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015BE")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x5A9800", Offset = "0x5A8A00", Length = "0xE2")]
	[CalledBy(Type = typeof(CircleShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60015C1")]
	public Vector2 get_Up() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015C6")]
	public float get_WireEps() { }

	[Address(RVA = "0x5A9290", Offset = "0x5A8490", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleMath), Member = "Calc2DExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x60015D4")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5A92E0", Offset = "0x5A84E0", Length = "0x12F")]
	[CalledBy(Type = typeof(GizmoCirclePlaneSlider2DController), Member = "GetRealExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CircleShape2D), Member = "get_Up", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CircleShape2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[Token(Token = "0x60015CF")]
	public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x5A9410", Offset = "0x5A8610", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleMath), Member = "Calc2DExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Token(Token = "0x60015D3")]
	public List<Vector2> GetExtentPoints() { }

	[Address(RVA = "0x5A9440", Offset = "0x5A8640", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleShape2D), Member = "CalcModelBorderPoints", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015D1")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5A9520", Offset = "0x5A8720", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleShape2D), Member = "CalcModelBorderPoints", ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015D0")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015BB")]
	public void set_Center(Vector2 value) { }

	[Address(RVA = "0x5A9900", Offset = "0x5A8B00", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015C3")]
	public void set_Epsilon(CircleEpsilon value) { }

	[Address(RVA = "0x5A9910", Offset = "0x5A8B10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60015C9")]
	public void set_NumBorderPoints(int value) { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015CB")]
	public void set_PtContainMode(Shape2DPtContainMode value) { }

	[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015BD")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x5A9930", Offset = "0x5A8B30", Length = "0xC")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015C5")]
	public void set_RadiusEps(float value) { }

	[Address(RVA = "0x2C1200", Offset = "0x2C0400", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015BF")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x5A9940", Offset = "0x5A8B40", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoThinCircle2DBorderController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015C7")]
	public void set_WireEps(float value) { }

}


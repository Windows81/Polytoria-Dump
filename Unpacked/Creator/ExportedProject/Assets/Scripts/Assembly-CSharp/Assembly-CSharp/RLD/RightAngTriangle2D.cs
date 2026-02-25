namespace RLD;

[Token(Token = "0x2000252")]
public class RightAngTriangle2D : Shape2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400093C")]
	private Vector2 _rightAngleCorner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400093D")]
	private float _XLength; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400093E")]
	private float _YLength; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400093F")]
	private float _rotationDegrees; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000940")]
	private TriangleEpsilon _epsilon; //Field offset: 0x24

	[Token(Token = "0x170007C3")]
	public float AreaEps
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600176A")]
		 get { } //Length: 6
		[Address(RVA = "0x5B2840", Offset = "0x5B1A40", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600176B")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007C2")]
	public TriangleEpsilon Epsilon
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001768")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001769")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170007C4")]
	public static Vector2 ModelRight
	{
		[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600176C")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170007C6")]
	public static Vector2 ModelRightAngleCorner
	{
		[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600176E")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170007C5")]
	public static Vector2 ModelUp
	{
		[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600176D")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170007C0")]
	public Vector2 Right
	{
		[Address(RVA = "0x5BBB60", Offset = "0x5BAD60", Length = "0xE2")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001766")]
		 get { } //Length: 226
	}

	[Token(Token = "0x170007BC")]
	public Vector2 RightAngleCorner
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600175E")]
		 get { } //Length: 19
		[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600175F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170007BF")]
	public float RotationDegrees
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001764")]
		 get { } //Length: 6
		[Address(RVA = "0x41BDA0", Offset = "0x41AFA0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001765")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170007C1")]
	public Vector2 Up
	{
		[Address(RVA = "0x5BBCF0", Offset = "0x5BAEF0", Length = "0xE2")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001767")]
		 get { } //Length: 226
	}

	[Token(Token = "0x170007BD")]
	public float XLength
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001760")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001761")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007BE")]
	public float YLength
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001762")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001763")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5BEAC0", Offset = "0x5BDCC0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001774")]
	public RightAngTriangle2D() { }

	[Address(RVA = "0x5BE7A0", Offset = "0x5BD9A0", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RightAngTriangle2D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001772")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600176A")]
	public float get_AreaEps() { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001768")]
	public TriangleEpsilon get_Epsilon() { }

	[Address(RVA = "0x5A9670", Offset = "0x5A8870", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600176C")]
	public static Vector2 get_ModelRight() { }

	[Address(RVA = "0x2BC1C0", Offset = "0x2BB3C0", Length = "0x44")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600176E")]
	public static Vector2 get_ModelRightAngleCorner() { }

	[Address(RVA = "0x5A96C0", Offset = "0x5A88C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600176D")]
	public static Vector2 get_ModelUp() { }

	[Address(RVA = "0x5BBB60", Offset = "0x5BAD60", Length = "0xE2")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001766")]
	public Vector2 get_Right() { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600175E")]
	public Vector2 get_RightAngleCorner() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001764")]
	public float get_RotationDegrees() { }

	[Address(RVA = "0x5BBCF0", Offset = "0x5BAEF0", Length = "0xE2")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001767")]
	public Vector2 get_Up() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001760")]
	public float get_XLength() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001762")]
	public float get_YLength() { }

	[Address(RVA = "0x5BE8F0", Offset = "0x5BDAF0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RightAngTriangle2D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x6001773")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5BE930", Offset = "0x5BDB30", Length = "0xBC")]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "RenderArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "RenderBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "GetEncapsulatingRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "CalcRATriangle2DPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Token(Token = "0x6001771")]
	public List<Vector2> GetPoints() { }

	[Address(RVA = "0x5BE9F0", Offset = "0x5BDBF0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RightAngTriangle2D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600176F")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5BEA90", Offset = "0x5BDC90", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RightAngTriangle2D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLineLoop2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001770")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5B2840", Offset = "0x5B1A40", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600176B")]
	public void set_AreaEps(float value) { }

	[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001769")]
	public void set_Epsilon(TriangleEpsilon value) { }

	[Address(RVA = "0x5A98F0", Offset = "0x5A8AF0", Length = "0x5")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600175F")]
	public void set_RightAngleCorner(Vector2 value) { }

	[Address(RVA = "0x41BDA0", Offset = "0x41AFA0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001765")]
	public void set_RotationDegrees(float value) { }

	[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001761")]
	public void set_XLength(float value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001763")]
	public void set_YLength(float value) { }

}


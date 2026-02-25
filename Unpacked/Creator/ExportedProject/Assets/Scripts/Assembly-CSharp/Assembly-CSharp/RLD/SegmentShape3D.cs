namespace RLD;

[Token(Token = "0x2000255")]
public class SegmentShape3D : Shape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400094E")]
	private Vector3 _startPoint; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400094F")]
	private Vector3 _endPoint; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000950")]
	private Vector3 _direction; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000951")]
	private float _length; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000952")]
	private SegmentEpsilon _epsilon; //Field offset: 0x38

	[Token(Token = "0x170007E8")]
	public Vector3 Direction
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017BC")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0840", Offset = "0x5BFA40", Length = "0x8C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60017BD")]
		 set { } //Length: 140
	}

	[Token(Token = "0x170007E7")]
	public Vector3 EndPoint
	{
		[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017BA")]
		 get { } //Length: 19
		[Address(RVA = "0x5C08D0", Offset = "0x5BFAD0", Length = "0x171")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60017BB")]
		 set { } //Length: 369
	}

	[Token(Token = "0x170007E9")]
	public SegmentEpsilon Epsilon
	{
		[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017BE")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0A50", Offset = "0x5BFC50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017BF")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170007E5")]
	public float Length
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017B6")]
		 get { } //Length: 6
		[Address(RVA = "0x5C0A60", Offset = "0x5BFC60", Length = "0x5C")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60017B7")]
		 set { } //Length: 92
	}

	[Token(Token = "0x170007EB")]
	public float PtOnSegmentEps
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C2")]
		 get { } //Length: 6
		[Address(RVA = "0x5BD4B0", Offset = "0x5BC6B0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C3")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007EA")]
	public float RaycastEps
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C0")]
		 get { } //Length: 6
		[Address(RVA = "0x5BB260", Offset = "0x5BA460", Length = "0xC")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C1")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007E6")]
	public Vector3 StartPoint
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017B8")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0AC0", Offset = "0x5BFCC0", Length = "0x60")]
		[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60017B9")]
		 set { } //Length: 96
	}

	[Address(RVA = "0x5C0770", Offset = "0x5BF970", Length = "0xCC")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017C9")]
	public SegmentShape3D() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017BC")]
	public Vector3 get_Direction() { }

	[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017BA")]
	public Vector3 get_EndPoint() { }

	[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017BE")]
	public SegmentEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017B6")]
	public float get_Length() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C2")]
	public float get_PtOnSegmentEps() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C0")]
	public float get_RaycastEps() { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017B8")]
	public Vector3 get_StartPoint() { }

	[Address(RVA = "0x5C0460", Offset = "0x5BF660", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60017C8")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5C0510", Offset = "0x5BF710", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SegmentMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(SegmentEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60017C7")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5C0590", Offset = "0x5BF790", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLine3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C5")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5C0590", Offset = "0x5BF790", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLine3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C6")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5C0840", Offset = "0x5BFA40", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60017BD")]
	public void set_Direction(Vector3 value) { }

	[Address(RVA = "0x5C08D0", Offset = "0x5BFAD0", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60017BB")]
	public void set_EndPoint(Vector3 value) { }

	[Address(RVA = "0x5C0A50", Offset = "0x5BFC50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017BF")]
	public void set_Epsilon(SegmentEpsilon value) { }

	[Address(RVA = "0x5C0A60", Offset = "0x5BFC60", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60017B7")]
	public void set_Length(float value) { }

	[Address(RVA = "0x5BD4B0", Offset = "0x5BC6B0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C3")]
	public void set_PtOnSegmentEps(float value) { }

	[Address(RVA = "0x5BB260", Offset = "0x5BA460", Length = "0xC")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C1")]
	public void set_RaycastEps(float value) { }

	[Address(RVA = "0x5C0AC0", Offset = "0x5BFCC0", Length = "0x60")]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60017B9")]
	public void set_StartPoint(Vector3 value) { }

	[Address(RVA = "0x5C05D0", Offset = "0x5BF7D0", Length = "0x19C")]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60017C4")]
	public void SetEndPtFromStart(Vector3 dirDromStart, float offset) { }

}


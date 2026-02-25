namespace RLD;

[Token(Token = "0x2000254")]
public class SegmentShape2D : Shape2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000949")]
	private Vector2 _startPoint; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400094A")]
	private Vector2 _endPoint; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400094B")]
	private Vector2 _direction; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400094C")]
	private float _length; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400094D")]
	private SegmentEpsilon _epsilon; //Field offset: 0x2C

	[Token(Token = "0x170007E1")]
	public Vector2 Direction
	{
		[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017A8")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0300", Offset = "0x5BF500", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
		[Token(Token = "0x60017A9")]
		 set { } //Length: 95
	}

	[Token(Token = "0x170007E0")]
	public Vector2 EndPoint
	{
		[Address(RVA = "0x5956B0", Offset = "0x5948B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017A6")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0360", Offset = "0x5BF560", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFAF0")]
		[Token(Token = "0x60017A7")]
		 set { } //Length: 88
	}

	[Token(Token = "0x170007E2")]
	public SegmentEpsilon Epsilon
	{
		[Address(RVA = "0x5C02E0", Offset = "0x5BF4E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017AA")]
		 get { } //Length: 19
		[Address(RVA = "0x5C03C0", Offset = "0x5BF5C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60017AB")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170007DE")]
	public float Length
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017A2")]
		 get { } //Length: 6
		[Address(RVA = "0x5C03D0", Offset = "0x5BF5D0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60017A3")]
		 set { } //Length: 46
	}

	[Token(Token = "0x170007E4")]
	public float PtOnSegmentEps
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017AE")]
		 get { } //Length: 6
		[Address(RVA = "0x5C0400", Offset = "0x5BF600", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60017AF")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007E3")]
	public float RaycastEps
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017AC")]
		 get { } //Length: 6
		[Address(RVA = "0x5C0410", Offset = "0x5BF610", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60017AD")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007DF")]
	public Vector2 StartPoint
	{
		[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017A4")]
		 get { } //Length: 19
		[Address(RVA = "0x5C0420", Offset = "0x5BF620", Length = "0x40")]
		[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60017A5")]
		 set { } //Length: 64
	}

	[Address(RVA = "0x5C0200", Offset = "0x5BF400", Length = "0xD8")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017B5")]
	public SegmentShape2D() { }

	[Address(RVA = "0x5C0050", Offset = "0x5BF250", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SegmentMath), Member = "Is2DPointOnSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(SegmentEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60017B3")]
	public virtual bool ContainsPoint(Vector2 point) { }

	[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017A8")]
	public Vector2 get_Direction() { }

	[Address(RVA = "0x5956B0", Offset = "0x5948B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017A6")]
	public Vector2 get_EndPoint() { }

	[Address(RVA = "0x5C02E0", Offset = "0x5BF4E0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017AA")]
	public SegmentEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017A2")]
	public float get_Length() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017AE")]
	public float get_PtOnSegmentEps() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017AC")]
	public float get_RaycastEps() { }

	[Address(RVA = "0x563200", Offset = "0x562400", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017A4")]
	public Vector2 get_StartPoint() { }

	[Address(RVA = "0x5C00B0", Offset = "0x5BF2B0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RectEx), Member = "FromPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60017B4")]
	public virtual Rect GetEncapsulatingRect() { }

	[Address(RVA = "0x5C0160", Offset = "0x5BF360", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLine2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017B2")]
	public virtual void RenderArea(Camera camera) { }

	[Address(RVA = "0x5C0160", Offset = "0x5BF360", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLine2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Camera)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60017B1")]
	public virtual void RenderBorder(Camera camera) { }

	[Address(RVA = "0x5C0300", Offset = "0x5BF500", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Token(Token = "0x60017A9")]
	public void set_Direction(Vector2 value) { }

	[Address(RVA = "0x5C0360", Offset = "0x5BF560", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFAF0")]
	[Token(Token = "0x60017A7")]
	public void set_EndPoint(Vector2 value) { }

	[Address(RVA = "0x5C03C0", Offset = "0x5BF5C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60017AB")]
	public void set_Epsilon(SegmentEpsilon value) { }

	[Address(RVA = "0x5C03D0", Offset = "0x5BF5D0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60017A3")]
	public void set_Length(float value) { }

	[Address(RVA = "0x5C0400", Offset = "0x5BF600", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateEpsilons", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017AF")]
	public void set_PtOnSegmentEps(float value) { }

	[Address(RVA = "0x5C0410", Offset = "0x5BF610", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017AD")]
	public void set_RaycastEps(float value) { }

	[Address(RVA = "0x5C0420", Offset = "0x5BF620", Length = "0x40")]
	[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60017A5")]
	public void set_StartPoint(Vector2 value) { }

	[Address(RVA = "0x5C0190", Offset = "0x5BF390", Length = "0x6A")]
	[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFAF0")]
	[Token(Token = "0x60017B0")]
	public void SetEndPtFromStart(Vector2 dirDromStart, float offset) { }

}


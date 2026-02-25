namespace RLD;

[Token(Token = "0x2000209")]
public class XZGridRayHit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007DD")]
	private XZGridCell _hitCell; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007DE")]
	private Vector3 _hitPoint; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007DF")]
	private float _hitEnter; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007E0")]
	private Vector3 _hitNormal; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40007E1")]
	private Plane _hitPlane; //Field offset: 0x34

	[Token(Token = "0x1700064F")]
	public XZGridCell HitCell
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000651")]
	public float HitEnter
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013ED")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000652")]
	public Vector3 HitNormal
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EE")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000653")]
	public Plane HitPlane
	{
		[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EF")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000650")]
	public Vector3 HitPoint
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013EC")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x5A6590", Offset = "0x5A5790", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013F0")]
	public XZGridRayHit(Ray ray, XZGridCell hitCell, float hitEnter) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EB")]
	public XZGridCell get_HitCell() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013ED")]
	public float get_HitEnter() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EE")]
	public Vector3 get_HitNormal() { }

	[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EF")]
	public Plane get_HitPlane() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EC")]
	public Vector3 get_HitPoint() { }

}


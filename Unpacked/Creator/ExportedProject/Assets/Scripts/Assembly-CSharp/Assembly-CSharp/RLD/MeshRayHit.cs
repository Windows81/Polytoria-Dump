namespace RLD;

[Token(Token = "0x200020C")]
public class MeshRayHit
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007E8")]
	private int _hitTriangleIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40007E9")]
	private Vector3 _hitPoint; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007EA")]
	private float _hitEnter; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007EB")]
	private Vector3 _hitNormal; //Field offset: 0x24

	[Token(Token = "0x1700065D")]
	public float HitEnter
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001401")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700065E")]
	public Vector3 HitNormal
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001402")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700065C")]
	public Vector3 HitPoint
	{
		[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001400")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700065B")]
	public int HitTriangleIndex
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013FF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x597550", Offset = "0x596750", Length = "0xA0")]
	[CalledBy(Type = typeof(MeshTree), Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(MeshRayHit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001403")]
	public MeshRayHit(Ray ray, int hitTriangleIndex, float hitEnter, Vector3 hitNormal) { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001401")]
	public float get_HitEnter() { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001402")]
	public Vector3 get_HitNormal() { }

	[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001400")]
	public Vector3 get_HitPoint() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FF")]
	public int get_HitTriangleIndex() { }

}


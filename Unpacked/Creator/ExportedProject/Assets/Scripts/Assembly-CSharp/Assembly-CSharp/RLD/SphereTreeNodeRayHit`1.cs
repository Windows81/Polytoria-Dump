namespace RLD;

[Token(Token = "0x2000123")]
public class SphereTreeNodeRayHit
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053C")]
	private SphereTreeNode<T> _hitNode; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053D")]
	private Vector3 _hitPoint; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053E")]
	private float _hitEnter; //Field offset: 0x0

	[Token(Token = "0x170004B1")]
	public float HitEnter
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DFA")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004AF")]
	public SphereTreeNode<T> HitNode
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF8")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004B0")]
	public Vector3 HitPoint
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF9")]
		 get { } //Length: 19
	}

	[Address(RVA = "0xF5DBE0", Offset = "0xF5CDE0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFB")]
	public SphereTreeNodeRayHit`1(Ray ray, SphereTreeNode<T> hitNode, float hitEnter) { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DFA")]
	public float get_HitEnter() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF8")]
	public SphereTreeNode<T> get_HitNode() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF9")]
	public Vector3 get_HitPoint() { }

}


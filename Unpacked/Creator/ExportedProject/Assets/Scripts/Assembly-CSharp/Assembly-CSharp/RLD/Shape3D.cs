namespace RLD;

[Token(Token = "0x200025B")]
public abstract class Shape3D
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017D6")]
	protected Shape3D() { }

	[Token(Token = "0x60017D5")]
	public abstract AABB GetAABB() { }

	[Address(RVA = "0x5C0BB0", Offset = "0x5BFDB0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60017CF")]
	public bool Raycast(Ray ray) { }

	[Token(Token = "0x60017D4")]
	public abstract bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5C0B60", Offset = "0x5BFD60", Length = "0x41")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60017D0")]
	public bool RaycastWire(Ray ray) { }

	[Address(RVA = "0x5C0B20", Offset = "0x5BFD20", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60017D1")]
	public override bool RaycastWire(Ray ray, out float t) { }

	[Token(Token = "0x60017D2")]
	public abstract void RenderSolid() { }

	[Token(Token = "0x60017D3")]
	public abstract void RenderWire() { }

}


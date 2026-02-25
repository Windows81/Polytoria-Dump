namespace RLD;

[Token(Token = "0x2000256")]
public abstract class Shape2D
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017CE")]
	protected Shape2D() { }

	[Token(Token = "0x60017CC")]
	public abstract bool ContainsPoint(Vector2 point) { }

	[Token(Token = "0x60017CD")]
	public abstract Rect GetEncapsulatingRect() { }

	[Token(Token = "0x60017CA")]
	public abstract void RenderArea(Camera camera) { }

	[Token(Token = "0x60017CB")]
	public abstract void RenderBorder(Camera camera) { }

}


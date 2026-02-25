//Type is in global namespace

[ModifierID("Round")]
[Token(Token = "0x2000007")]
public class RoundModifier : ProceduralImageModifier
{

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public RoundModifier() { }

	[Address(RVA = "0x3C6D80", Offset = "0x3C5F80", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000011")]
	public virtual Vector4 CalculateRadius(Rect imageRect) { }

}


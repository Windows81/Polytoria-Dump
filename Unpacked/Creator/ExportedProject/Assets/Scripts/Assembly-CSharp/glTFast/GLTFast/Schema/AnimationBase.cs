namespace GLTFast.Schema;

[Token(Token = "0x2000090")]
public abstract class AnimationBase : NamedObject
{

	[Token(Token = "0x1700003D")]
	public abstract IReadOnlyList<AnimationChannelBase> Channels
	{
		[Token(Token = "0x60001D2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700003E")]
	public abstract IReadOnlyList<AnimationSampler> Samplers
	{
		[Token(Token = "0x60001D3")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D4")]
	protected AnimationBase() { }

	[Token(Token = "0x60001D2")]
	public abstract IReadOnlyList<AnimationChannelBase> get_Channels() { }

	[Token(Token = "0x60001D3")]
	public abstract IReadOnlyList<AnimationSampler> get_Samplers() { }

}


namespace GLTFast.Schema;

[Token(Token = "0x2000084")]
public abstract class AnimationChannelBase
{
	[Token(Token = "0x2000085")]
	internal enum Path
	{
		Unknown = 0,
		Invalid = 1,
		Translation = 2,
		Rotation = 3,
		Scale = 4,
		Weights = 5,
		Pointer = 6,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000226")]
	public int sampler; //Field offset: 0x10

	[Token(Token = "0x17000037")]
	public abstract AnimationChannelTarget Target
	{
		[Token(Token = "0x60001BF")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C0")]
	protected AnimationChannelBase() { }

	[Token(Token = "0x60001BF")]
	public abstract AnimationChannelTarget get_Target() { }

}


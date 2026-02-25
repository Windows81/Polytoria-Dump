namespace GLTFast.Schema;

[Token(Token = "0x2000083")]
public abstract class AnimationChannelBase : AnimationChannelBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000225")]
	public TTarget target; //Field offset: 0x0

	[Token(Token = "0x17000036")]
	public virtual AnimationChannelTarget Target
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BE")]
	protected AnimationChannelBase`1() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	public virtual AnimationChannelTarget get_Target() { }

}


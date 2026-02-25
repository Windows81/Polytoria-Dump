namespace GLTFast.Schema;

[Token(Token = "0x200008F")]
public abstract class AnimationBase : AnimationBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023B")]
	public TChannel[] channels; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023C")]
	public TSampler[] samplers; //Field offset: 0x0

	[Token(Token = "0x1700003B")]
	public virtual IReadOnlyList<AnimationChannelBase> Channels
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003C")]
	public virtual IReadOnlyList<AnimationSampler> Samplers
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D1")]
	protected AnimationBase`2() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001CF")]
	public virtual IReadOnlyList<AnimationChannelBase> get_Channels() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D0")]
	public virtual IReadOnlyList<AnimationSampler> get_Samplers() { }

}


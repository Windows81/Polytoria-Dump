namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000061")]
public abstract class PostProcessEffectRenderer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400018D")]
	protected bool m_ResetHistory; //Field offset: 0x10

	[Address(RVA = "0x5775A0", Offset = "0x5767A0", Length = "0xB")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000112")]
	protected PostProcessEffectRenderer() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	public override DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010C")]
	public override void Init() { }

	[Address(RVA = "0x166F2B0", Offset = "0x166E4B0", Length = "0x14")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010F")]
	public override void Release() { }

	[Token(Token = "0x6000110")]
	public abstract void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x551C10", Offset = "0x550E10", Length = "0x5")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010E")]
	public override void ResetHistory() { }

	[Token(Token = "0x6000111")]
	internal abstract void SetSettings(PostProcessEffectSettings settings) { }

}


namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000029")]
public sealed class FastApproximateAntialiasing
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("mobileOptimized")]
	[Token(Token = "0x40000AD")]
	[Tooltip("Boost performances by lowering the effect quality. This setting is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public bool fastMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000AE")]
	[Tooltip("Keep alpha channel. This will slightly lower the effect quality but allows rendering against a transparent background.\nThis setting has no effect if the camera render target has no alpha channel.")]
	public bool keepAlpha; //Field offset: 0x11

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	public FastApproximateAntialiasing() { }

}


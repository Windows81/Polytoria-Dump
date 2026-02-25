namespace RLD;

[Token(Token = "0x2000015")]
public abstract class GizmoCap2DController : IGizmoCap2DController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000048")]
	protected GizmoCap2DControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000083")]
	public GizmoCap2DController(GizmoCap2DControllerData controllerData) { }

	[Token(Token = "0x6000086")]
	public abstract void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Token(Token = "0x6000087")]
	public abstract void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Token(Token = "0x6000088")]
	public abstract float GetSliderAlignedRealLength() { }

	[Token(Token = "0x6000084")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x6000085")]
	public abstract void UpdateTransforms() { }

}


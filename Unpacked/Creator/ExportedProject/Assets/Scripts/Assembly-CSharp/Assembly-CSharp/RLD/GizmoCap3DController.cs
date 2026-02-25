namespace RLD;

[Token(Token = "0x2000020")]
public abstract class GizmoCap3DController : IGizmoCap3DController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000075")]
	protected GizmoCap3DControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000F2")]
	public GizmoCap3DController(GizmoCap3DControllerData controllerData) { }

	[Token(Token = "0x60000F5")]
	public abstract void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Token(Token = "0x60000F6")]
	public abstract void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Token(Token = "0x60000F7")]
	public abstract float GetSliderAlignedRealLength(float zoomFactor) { }

	[Token(Token = "0x60000F3")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x60000F4")]
	public abstract void UpdateTransforms(float zoomFactor) { }

}


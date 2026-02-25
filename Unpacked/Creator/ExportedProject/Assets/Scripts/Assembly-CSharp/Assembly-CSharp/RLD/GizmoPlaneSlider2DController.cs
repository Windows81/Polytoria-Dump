namespace RLD;

[Token(Token = "0x20000AF")]
public abstract class GizmoPlaneSlider2DController : IGizmoPlaneSlider2DController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A6")]
	protected GizmoPlaneSlider2DControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B0")]
	public GizmoPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) { }

	[Token(Token = "0x60006B4")]
	public abstract Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	[Token(Token = "0x60006B3")]
	public abstract void UpdateEpsilons() { }

	[Token(Token = "0x60006B1")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x60006B2")]
	public abstract void UpdateTransforms() { }

}


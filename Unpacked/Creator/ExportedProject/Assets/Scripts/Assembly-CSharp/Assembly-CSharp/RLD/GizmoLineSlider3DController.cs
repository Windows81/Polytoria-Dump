namespace RLD;

[Token(Token = "0x20000C1")]
public abstract class GizmoLineSlider3DController : IGizmoLineSlider3DController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002F6")]
	protected GizmoLineSlider3DControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600076B")]
	public GizmoLineSlider3DController(GizmoLineSlider3DControllerData controllerData) { }

	[Token(Token = "0x600076F")]
	public abstract float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	[Token(Token = "0x600076E")]
	public abstract void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x600076C")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x600076D")]
	public abstract void UpdateTransforms(float zoomFactor) { }

}


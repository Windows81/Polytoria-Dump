namespace RLD;

[Token(Token = "0x20000CC")]
public abstract class GizmoPlaneSlider3DController : IGizmoPlaneSlider3DController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000339")]
	protected GizmoPlaneSlider3DControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000805")]
	public GizmoPlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	[Token(Token = "0x6000808")]
	public abstract void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x6000806")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x6000807")]
	public abstract void UpdateTransforms(float zoomFactor) { }

}


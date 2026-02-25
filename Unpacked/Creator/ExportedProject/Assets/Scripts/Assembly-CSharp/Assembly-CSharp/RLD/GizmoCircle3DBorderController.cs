namespace RLD;

[Token(Token = "0x20000E6")]
public abstract class GizmoCircle3DBorderController : IGizmoCircle3DBorderController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003BA")]
	protected GizmoCircle3DBorderControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B9")]
	public GizmoCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) { }

	[Token(Token = "0x60008BB")]
	public abstract void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x60008BA")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x60008BC")]
	public abstract void UpdateTransforms(float zoomFactor) { }

}


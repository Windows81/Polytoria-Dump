namespace RLD;

[Token(Token = "0x20000EF")]
public abstract class GizmoQuad3DBorderController : IGizmoQuad3DBorderController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E2")]
	protected GizmoQuad3DBorderControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E1")]
	public GizmoQuad3DBorderController(GizmoQuad3DBorderControllerData data) { }

	[Token(Token = "0x60008E3")]
	public abstract void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x60008E2")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x60008E4")]
	public abstract void UpdateTransforms(float zoomFactor) { }

}


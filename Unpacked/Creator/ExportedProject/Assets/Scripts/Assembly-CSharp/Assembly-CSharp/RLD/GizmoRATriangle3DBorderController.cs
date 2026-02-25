namespace RLD;

[Token(Token = "0x20000F4")]
public abstract class GizmoRATriangle3DBorderController : IGizmoRATriangle3DBorderController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000403")]
	protected GizmoRATriangle3DBorderControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008F7")]
	public GizmoRATriangle3DBorderController(GizmoRATriangle3DBorderControllerData controllerData) { }

	[Token(Token = "0x60008F9")]
	public abstract void UpdateEpsilons(float zoomFactor) { }

	[Token(Token = "0x60008F8")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x60008FA")]
	public abstract void UpdateTransforms(float zoomFactor) { }

}


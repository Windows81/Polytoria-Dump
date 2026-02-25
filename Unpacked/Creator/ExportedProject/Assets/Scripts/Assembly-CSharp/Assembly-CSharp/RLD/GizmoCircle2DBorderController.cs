namespace RLD;

[Token(Token = "0x20000D6")]
public abstract class GizmoCircle2DBorderController : IGizmoCircle2DBorderController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037F")]
	protected GizmoCircle2DBorderControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000874")]
	public GizmoCircle2DBorderController(GizmoCircle2DBorderControllerData data) { }

	[Token(Token = "0x6000876")]
	public abstract void UpdateEpsilons() { }

	[Token(Token = "0x6000875")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x6000877")]
	public abstract void UpdateTransforms() { }

}


namespace RLD;

[Token(Token = "0x20000A6")]
public abstract class GizmoLineSlider2DController : IGizmoLineSlider2DController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000269")]
	protected GizmoLineSlider2DControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000637")]
	public GizmoLineSlider2DController(GizmoLineSlider2DControllerData controllerData) { }

	[Token(Token = "0x600063A")]
	public abstract void UpdateEpsilons() { }

	[Token(Token = "0x6000638")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x6000639")]
	public abstract void UpdateTransforms() { }

}


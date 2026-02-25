namespace RLD;

[Token(Token = "0x20000DB")]
public abstract class GizmoPolygon2DBorderController : IGizmoPolygon2DBorderController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000392")]
	protected GizmoPolygon2DBorderControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000888")]
	public GizmoPolygon2DBorderController(GizmoPolygon2DBorderControllerData data) { }

	[Token(Token = "0x600088A")]
	public abstract void UpdateEpsilons() { }

	[Token(Token = "0x6000889")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x600088B")]
	public abstract void UpdateTransforms() { }

}


namespace RLD;

[Token(Token = "0x20000E1")]
public abstract class GizmoQuad2DBorderController : IGizmoQuad2DBorderController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A5")]
	protected GizmoQuad2DBorderControllerData _data; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A0")]
	public GizmoQuad2DBorderController(GizmoQuad2DBorderControllerData data) { }

	[Token(Token = "0x60008A2")]
	public abstract void UpdateEpsilons() { }

	[Token(Token = "0x60008A1")]
	public abstract void UpdateHandles() { }

	[Token(Token = "0x60008A3")]
	public abstract void UpdateTransforms() { }

}


namespace RLD;

[Token(Token = "0x20000B4")]
public class GizmoPolygonPlaneSlider2DController : GizmoPlaneSlider2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F1")]
	public GizmoPolygonPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) { }

	[Address(RVA = "0x50C640", Offset = "0x50B840", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PolygonShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F5")]
	public virtual Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x50C670", Offset = "0x50B870", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F3")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x50C6D0", Offset = "0x50B8D0", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCircle2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F2")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50C7D0", Offset = "0x50B9D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = "OnPolygonShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F4")]
	public virtual void UpdateTransforms() { }

}


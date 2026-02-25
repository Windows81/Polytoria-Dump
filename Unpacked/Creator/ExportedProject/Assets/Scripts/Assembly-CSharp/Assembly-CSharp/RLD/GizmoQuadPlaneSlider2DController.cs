namespace RLD;

[Token(Token = "0x20000B6")]
public class GizmoQuadPlaneSlider2DController : GizmoPlaneSlider2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F6")]
	public GizmoQuadPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) { }

	[Address(RVA = "0x50C800", Offset = "0x50BA00", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006FA")]
	public virtual Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x50C830", Offset = "0x50BA30", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape2D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006F8")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x50C8A0", Offset = "0x50BAA0", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCircle2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F7")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50C9A0", Offset = "0x50BBA0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape2D), Member = "set_RotationDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadWidth", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadHeight", ReturnType = typeof(float))]
	[Calls(Type = typeof(QuadShape2D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad2DBorder), Member = "OnQuadShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F9")]
	public virtual void UpdateTransforms() { }

}


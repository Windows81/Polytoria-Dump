namespace RLD;

[Token(Token = "0x20000AD")]
public class GizmoCirclePlaneSlider2DController : GizmoPlaneSlider2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600066D")]
	public GizmoCirclePlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData) { }

	[Address(RVA = "0x4FB490", Offset = "0x4FA690", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleShape2D), Member = "GetExtentPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shape2DExtentPoint)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000671")]
	public virtual Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	[Address(RVA = "0x4FB4C0", Offset = "0x4FA6C0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600066F")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x4FB520", Offset = "0x4FA720", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoQuad2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoPolygon2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle2DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600066E")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x4FB620", Offset = "0x4FA820", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealCircleRadius", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCircle2DBorder), Member = "OnCircleShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000670")]
	public virtual void UpdateTransforms() { }

}


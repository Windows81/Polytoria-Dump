namespace RLD;

[Token(Token = "0x20000C8")]
public class GizmoCirclePlaneSlider3DController : GizmoPlaneSlider3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AA")]
	public GizmoCirclePlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	[Address(RVA = "0x4FB6C0", Offset = "0x4FA8C0", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CircleShape3D), Member = "set_ExtrudeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007AC")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x4FB790", Offset = "0x4FA990", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007AB")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x4FB890", Offset = "0x4FAA90", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "GetRealCircleRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "OnCircleShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007AD")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


namespace RLD;

[Token(Token = "0x20000D1")]
public class GizmoQuadPlaneSlider3DController : GizmoPlaneSlider3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000861")]
	public GizmoQuadPlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	[Address(RVA = "0x50CA80", Offset = "0x50BC80", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QuadShape3D), Member = "set_ExtrudeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000863")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x50CB60", Offset = "0x50BD60", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000862")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50CC60", Offset = "0x50BE60", Length = "0x1CC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape3D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "OnQuadShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000864")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


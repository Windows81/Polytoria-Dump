namespace RLD;

[Token(Token = "0x20000D3")]
public class GizmoRATrianglePlaneSlider3DController : GizmoPlaneSlider3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000865")]
	public GizmoRATrianglePlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData) { }

	[Address(RVA = "0x50CE30", Offset = "0x50C030", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000867")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x50CF00", Offset = "0x50C100", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoQuad3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCircle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000866")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50D000", Offset = "0x50C200", Length = "0x1FF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoRATriangle3DBorder), Member = "OnTriangleShapeChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000868")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


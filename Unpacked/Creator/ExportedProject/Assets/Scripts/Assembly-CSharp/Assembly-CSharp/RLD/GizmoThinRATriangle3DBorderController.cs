namespace RLD;

[Token(Token = "0x20000F6")]
public class GizmoThinRATriangle3DBorderController : GizmoRATriangle3DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008FC")]
	public GizmoThinRATriangle3DBorderController(GizmoRATriangle3DBorderControllerData controllerData) { }

	[Address(RVA = "0x514560", Offset = "0x513760", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider3DSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60008FE")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x5145F0", Offset = "0x5137F0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008FD")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x514630", Offset = "0x513830", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008FF")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


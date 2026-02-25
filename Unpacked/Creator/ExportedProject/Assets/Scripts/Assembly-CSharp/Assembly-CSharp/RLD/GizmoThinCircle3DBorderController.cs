namespace RLD;

[Token(Token = "0x20000E9")]
public class GizmoThinCircle3DBorderController : GizmoCircle3DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C3")]
	public GizmoThinCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) { }

	[Address(RVA = "0x513FF0", Offset = "0x5131F0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider3DSettings))]
	[Calls(Type = typeof(CircleShape3D), Member = "set_WireEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CircleShape3D), Member = "set_ExtrudeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C5")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x514080", Offset = "0x513280", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008C4")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x514110", Offset = "0x513310", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C6")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


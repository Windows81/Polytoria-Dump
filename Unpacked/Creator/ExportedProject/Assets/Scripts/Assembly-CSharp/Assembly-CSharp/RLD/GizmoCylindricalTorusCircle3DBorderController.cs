namespace RLD;

[Token(Token = "0x20000E8")]
public class GizmoCylindricalTorusCircle3DBorderController : GizmoCircle3DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BE")]
	public GizmoCylindricalTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) { }

	[Address(RVA = "0x50FBF0", Offset = "0x50EDF0", Length = "0xA1")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008C2")]
	public float GetTorusCoreRadius(float zoomFactor) { }

	[Address(RVA = "0x50FCA0", Offset = "0x50EEA0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider3DSettings))]
	[Calls(Type = typeof(CylTorusShape3D), Member = "set_CylHrzRadiusEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CylTorusShape3D), Member = "set_CylVertRadiusEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C0")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x50FD30", Offset = "0x50EF30", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008BF")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50FDC0", Offset = "0x50EFC0", Length = "0x2DE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoCylindricalTorusCircle3DBorderController), Member = "GetTorusCoreRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60008C1")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


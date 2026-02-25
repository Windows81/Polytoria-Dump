namespace RLD;

[Token(Token = "0x20000EA")]
public class GizmoTorusCircle3DBorderController : GizmoCircle3DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008C7")]
	public GizmoTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) { }

	[Address(RVA = "0x5146B0", Offset = "0x5138B0", Length = "0xA1")]
	[CalledBy(Type = typeof(GizmoCircle3DBorder), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTorusCircle3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008CB")]
	public float GetTorusCoreRadius(float zoomFactor) { }

	[Address(RVA = "0x514760", Offset = "0x513960", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider3DSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008C9")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x5147C0", Offset = "0x5139C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008C8")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x514850", Offset = "0x513A50", Length = "0x2A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTorusCircle3DBorderController), Member = "GetTorusCoreRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60008CA")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


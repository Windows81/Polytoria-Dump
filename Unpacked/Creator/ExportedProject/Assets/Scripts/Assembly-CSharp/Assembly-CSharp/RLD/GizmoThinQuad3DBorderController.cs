namespace RLD;

[Token(Token = "0x20000F1")]
public class GizmoThinQuad3DBorderController : GizmoQuad3DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008E6")]
	public GizmoThinQuad3DBorderController(GizmoQuad3DBorderControllerData data) { }

	[Address(RVA = "0x514320", Offset = "0x513520", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider3DSettings))]
	[Calls(Type = typeof(QuadShape3D), Member = "set_WireEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QuadShape3D), Member = "set_ExtrudeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008E8")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x5143A0", Offset = "0x5135A0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008E7")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x514500", Offset = "0x513700", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape3D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008E9")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


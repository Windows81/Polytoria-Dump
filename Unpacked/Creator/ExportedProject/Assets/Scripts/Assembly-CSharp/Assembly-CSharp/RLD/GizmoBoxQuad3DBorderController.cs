namespace RLD;

[Token(Token = "0x20000EC")]
public class GizmoBoxQuad3DBorderController : GizmoQuad3DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008CF")]
	public GizmoBoxQuad3DBorderController(GizmoQuad3DBorderControllerData data) { }

	[Address(RVA = "0x50D920", Offset = "0x50CB20", Length = "0x1D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider3DSettings))]
	[Calls(Type = typeof(BoxShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008D1")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x50DB00", Offset = "0x50CD00", Length = "0x240")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008D0")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50DD50", Offset = "0x50CF50", Length = "0xAFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoPlaneSlider3D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider3DLookAndFeel))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(BoxShape3D), Member = "AlignHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxShape3D), Member = "AlignWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxShape3D), Member = "GetSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BoxShape3D), Member = "SetFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxShape3D), Member = "GetFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 30)]
	[Token(Token = "0x60008D2")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


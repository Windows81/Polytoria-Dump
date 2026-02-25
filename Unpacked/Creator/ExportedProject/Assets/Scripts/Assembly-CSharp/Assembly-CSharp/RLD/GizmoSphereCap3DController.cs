namespace RLD;

[Token(Token = "0x2000026")]
public class GizmoSphereCap3DController : GizmoCap3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000137")]
	public GizmoSphereCap3DController(GizmoCap3DControllerData controllerData) { }

	[Address(RVA = "0x3BC8F0", Offset = "0x3BBAF0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013A")]
	public virtual void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3BC790", Offset = "0x3BB990", Length = "0x156")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013B")]
	public virtual void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3BCA10", Offset = "0x3BBC10", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013C")]
	public virtual float GetSliderAlignedRealLength(float zoomFactor) { }

	[Address(RVA = "0x3BCA40", Offset = "0x3BBC40", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000138")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x3BCB20", Offset = "0x3BBD20", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealSphereRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000139")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


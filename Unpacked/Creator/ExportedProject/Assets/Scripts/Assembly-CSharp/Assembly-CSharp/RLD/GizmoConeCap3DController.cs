namespace RLD;

[Token(Token = "0x2000024")]
public class GizmoConeCap3DController : GizmoCap3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012B")]
	public GizmoConeCap3DController(GizmoCap3DControllerData controllerData) { }

	[Address(RVA = "0x3B71A0", Offset = "0x3B63A0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600012E")]
	public virtual void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3B7030", Offset = "0x3B6230", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	public virtual void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3B7250", Offset = "0x3B6450", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000130")]
	public virtual float GetSliderAlignedRealLength(float zoomFactor) { }

	[Address(RVA = "0x3B7280", Offset = "0x3B6480", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600012C")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x3B7360", Offset = "0x3B6560", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeShape3D), Member = "set_BaseRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealConeHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ConeShape3D), Member = "set_Height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600012D")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


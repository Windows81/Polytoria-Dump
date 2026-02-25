namespace RLD;

[Token(Token = "0x2000025")]
public class GizmoPyramidCap3DController : GizmoCap3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000131")]
	public GizmoPyramidCap3DController(GizmoCap3DControllerData controllerData) { }

	[Address(RVA = "0x3B71A0", Offset = "0x3B63A0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000134")]
	public virtual void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3B7030", Offset = "0x3B6230", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000135")]
	public virtual void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3BAC90", Offset = "0x3B9E90", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealPyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000136")]
	public virtual float GetSliderAlignedRealLength(float zoomFactor) { }

	[Address(RVA = "0x3BACC0", Offset = "0x3B9EC0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000132")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x3BADA0", Offset = "0x3B9FA0", Length = "0x21D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoCap3D), Member = "GetRealPyramidHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000133")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


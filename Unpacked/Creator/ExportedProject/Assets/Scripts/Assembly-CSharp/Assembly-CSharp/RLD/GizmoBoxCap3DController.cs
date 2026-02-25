namespace RLD;

[Token(Token = "0x200001C")]
public class GizmoBoxCap3DController : GizmoCap3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B4")]
	public GizmoBoxCap3DController(GizmoCap3DControllerData controllerData) { }

	[Address(RVA = "0x3B10D0", Offset = "0x3B02D0", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B7")]
	public virtual void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3B0F50", Offset = "0x3B0150", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B8")]
	public virtual void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor) { }

	[Address(RVA = "0x3B1210", Offset = "0x3B0410", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B9")]
	public virtual float GetSliderAlignedRealLength(float zoomFactor) { }

	[Address(RVA = "0x3B12C0", Offset = "0x3B04C0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B5")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x3B13A0", Offset = "0x3B05A0", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxShape3D), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxShape3D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B6")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


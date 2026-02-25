namespace RLD;

[Token(Token = "0x20000C5")]
public class GizmoThinLineSlider3DController : GizmoLineSlider3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007A1")]
	public GizmoThinLineSlider3DController(GizmoLineSlider3DControllerData controllerData) { }

	[Address(RVA = "0x50D380", Offset = "0x50C580", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector3Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A5")]
	public virtual float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	[Address(RVA = "0x50D460", Offset = "0x50C660", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007A4")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x50D4C0", Offset = "0x50C6C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A2")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50D550", Offset = "0x50C750", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SegmentShape3D), Member = "set_StartPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransformAxisMap3D), Member = "get_Axis", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(SegmentShape3D), Member = "SetEndPtFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007A3")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


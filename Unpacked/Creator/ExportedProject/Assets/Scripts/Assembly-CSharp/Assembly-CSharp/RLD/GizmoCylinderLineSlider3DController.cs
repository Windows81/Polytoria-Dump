namespace RLD;

[Token(Token = "0x20000B9")]
public class GizmoCylinderLineSlider3DController : GizmoLineSlider3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000704")]
	public GizmoCylinderLineSlider3DController(GizmoLineSlider3DControllerData controllerData) { }

	[Address(RVA = "0x4FB930", Offset = "0x4FAB30", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealCylinderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000708")]
	public virtual float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	[Address(RVA = "0x4FBA40", Offset = "0x4FAC40", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000707")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x4FBAA0", Offset = "0x4FACA0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000705")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x4FBB30", Offset = "0x4FAD30", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealCylinderRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000706")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


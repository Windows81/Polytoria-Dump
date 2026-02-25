namespace RLD;

[Token(Token = "0x20000B8")]
public class GizmoBoxLineSlider3DController : GizmoLineSlider3DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006FF")]
	public GizmoBoxLineSlider3DController(GizmoLineSlider3DControllerData controllerData) { }

	[Address(RVA = "0x4FA860", Offset = "0x4F9A60", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000703")]
	public virtual float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor) { }

	[Address(RVA = "0x4FAA80", Offset = "0x4F9C80", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoxShape3D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000702")]
	public virtual void UpdateEpsilons(float zoomFactor) { }

	[Address(RVA = "0x4FAB00", Offset = "0x4F9D00", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set3DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000700")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x4FAB90", Offset = "0x4F9D90", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxShape3D), Member = "AlignWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealBoxHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider3D), Member = "GetRealBoxDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BoxShape3D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxShape3D), Member = "SetFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000701")]
	public virtual void UpdateTransforms(float zoomFactor) { }

}


namespace RLD;

[Token(Token = "0x20000D8")]
public class GizmoThinCircle2DBorderController : GizmoCircle2DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000879")]
	public GizmoThinCircle2DBorderController(GizmoCircle2DBorderControllerData data) { }

	[Address(RVA = "0x513F00", Offset = "0x513100", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider2DSettings))]
	[Calls(Type = typeof(CircleShape2D), Member = "set_WireEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600087B")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x513F50", Offset = "0x513150", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600087A")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x513F90", Offset = "0x513190", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600087C")]
	public virtual void UpdateTransforms() { }

}


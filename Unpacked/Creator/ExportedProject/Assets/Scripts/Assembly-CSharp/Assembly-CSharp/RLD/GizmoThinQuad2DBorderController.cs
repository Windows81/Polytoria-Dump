namespace RLD;

[Token(Token = "0x20000E3")]
public class GizmoThinQuad2DBorderController : GizmoQuad2DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A5")]
	public GizmoThinQuad2DBorderController(GizmoQuad2DBorderControllerData data) { }

	[Address(RVA = "0x514250", Offset = "0x513450", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider2DSettings))]
	[Calls(Type = typeof(QuadShape2D), Member = "set_WireEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008A7")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x513F50", Offset = "0x513150", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A6")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x5142A0", Offset = "0x5134A0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape2D), Member = "set_RotationDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QuadShape2D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008A8")]
	public virtual void UpdateTransforms() { }

}


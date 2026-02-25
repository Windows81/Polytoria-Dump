namespace RLD;

[Token(Token = "0x20000DD")]
public class GizmoThickPolygon2DBorderController : GizmoPolygon2DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088D")]
	public GizmoThickPolygon2DBorderController(GizmoPolygon2DBorderControllerData data) { }

	[Address(RVA = "0x513DB0", Offset = "0x512FB0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider2DSettings))]
	[Calls(Type = typeof(PolygonShape2D), Member = "set_ThickWireEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600088F")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x513E00", Offset = "0x513000", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600088E")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x513E70", Offset = "0x513070", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_LookAndFeel", ReturnType = typeof(GizmoPlaneSlider2DLookAndFeel))]
	[Calls(Type = typeof(PolygonShape2D), Member = "CopyPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PolygonShape2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000890")]
	public virtual void UpdateTransforms() { }

}


namespace RLD;

[Token(Token = "0x20000DE")]
public class GizmoThinPolygon2DBorderController : GizmoPolygon2DBorderController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000891")]
	public GizmoThinPolygon2DBorderController(GizmoPolygon2DBorderControllerData data) { }

	[Address(RVA = "0x514160", Offset = "0x513360", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoPlaneSlider2D), Member = "get_Settings", ReturnType = typeof(GizmoPlaneSlider2DSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000893")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x5141B0", Offset = "0x5133B0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000892")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x514220", Offset = "0x513420", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PolygonShape2D), Member = "CopyPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PolygonShape2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000894")]
	public virtual void UpdateTransforms() { }

}


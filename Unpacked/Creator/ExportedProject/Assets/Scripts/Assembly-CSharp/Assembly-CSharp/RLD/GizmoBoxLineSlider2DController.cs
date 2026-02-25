namespace RLD;

[Token(Token = "0x20000A2")]
public class GizmoBoxLineSlider2DController : GizmoLineSlider2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005E7")]
	public GizmoBoxLineSlider2DController(GizmoLineSlider2DControllerData controllerData) { }

	[Address(RVA = "0x4FA650", Offset = "0x4F9850", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape2D), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60005E9")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x4FA6C0", Offset = "0x4F98C0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005E8")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x4FA730", Offset = "0x4F9930", Length = "0x128")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealLength", ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(QuadShape2D), Member = "AlignWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60005EA")]
	public virtual void UpdateTransforms() { }

}


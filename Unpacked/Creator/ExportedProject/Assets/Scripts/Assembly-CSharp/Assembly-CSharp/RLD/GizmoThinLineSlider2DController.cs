namespace RLD;

[Token(Token = "0x20000AA")]
public class GizmoThinLineSlider2DController : GizmoLineSlider2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000666")]
	public GizmoThinLineSlider2DController(GizmoLineSlider2DControllerData controllerData) { }

	[Address(RVA = "0x50D200", Offset = "0x50C400", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SegmentShape2D), Member = "set_PtOnSegmentEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000668")]
	public virtual void UpdateEpsilons() { }

	[Address(RVA = "0x50D260", Offset = "0x50C460", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000667")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x50D2D0", Offset = "0x50C4D0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SegmentShape2D), Member = "set_StartPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransformAxisMap2D), Member = "get_Axis", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoLineSlider2D), Member = "GetRealLength", ReturnType = typeof(float))]
	[Calls(Type = typeof(SegmentShape2D), Member = "SetEndPtFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000669")]
	public virtual void UpdateTransforms() { }

}


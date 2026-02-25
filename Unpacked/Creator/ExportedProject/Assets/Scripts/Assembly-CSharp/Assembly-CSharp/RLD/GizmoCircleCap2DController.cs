namespace RLD;

[Token(Token = "0x2000019")]
public class GizmoCircleCap2DController : GizmoCap2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A3")]
	public GizmoCircleCap2DController(GizmoCap2DControllerData controllerData) { }

	[Address(RVA = "0x3B6D00", Offset = "0x3B5F00", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000A6")]
	public virtual void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Address(RVA = "0x3B6B70", Offset = "0x3B5D70", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000A7")]
	public virtual void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Address(RVA = "0x3B6E70", Offset = "0x3B6070", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A8")]
	public virtual float GetSliderAlignedRealLength() { }

	[Address(RVA = "0x3B6EE0", Offset = "0x3B60E0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A4")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x3B6F70", Offset = "0x3B6170", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A5")]
	public virtual void UpdateTransforms() { }

}


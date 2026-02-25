namespace RLD;

[Token(Token = "0x200001A")]
public class GizmoQuadCap2DController : GizmoCap2DController
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A9")]
	public GizmoQuadCap2DController(GizmoCap2DControllerData controllerData) { }

	[Address(RVA = "0x3BB140", Offset = "0x3BA340", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000AC")]
	public virtual void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Address(RVA = "0x3BAFC0", Offset = "0x3BA1C0", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000AD")]
	public virtual void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	[Address(RVA = "0x3BB2C0", Offset = "0x3BA4C0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000AE")]
	public virtual float GetSliderAlignedRealLength() { }

	[Address(RVA = "0x3BB320", Offset = "0x3BA520", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoHandle), Member = "Set2DShapeVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000AA")]
	public virtual void UpdateHandles() { }

	[Address(RVA = "0x3BB3B0", Offset = "0x3BA5B0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadShape2D), Member = "set_RotationDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000AB")]
	public virtual void UpdateTransforms() { }

}


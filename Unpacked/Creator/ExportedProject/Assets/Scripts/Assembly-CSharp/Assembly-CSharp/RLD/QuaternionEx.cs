namespace RLD;

[Extension]
[Token(Token = "0x2000168")]
public static class QuaternionEx
{

	[Address(RVA = "0x56A420", Offset = "0x569620", Length = "0xCA")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Rotate2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnRotation2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "AlignAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuadShape2D), Member = "AlignWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = "AlignTransformAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "SetMappedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToAxisAngleRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6001020")]
	public static float ConvertTo2DRotation(Quaternion quat) { }

	[Address(RVA = "0x56A4F0", Offset = "0x5696F0", Length = "0x1F3")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "AlignAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = "AlignTransformAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "SetMappedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuadShape2D), Member = "AlignWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MathEx), Member = "SafeAcos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Token(Token = "0x600101F")]
	public static Quaternion FromToRotation2D(Vector2 from, Vector2 to) { }

	[Address(RVA = "0x56A6F0", Offset = "0x5698F0", Length = "0x241")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MathEx), Member = "SafeAcos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600101E")]
	public static Quaternion FromToRotation3D(Vector3 from, Vector3 to, Vector3 perp180) { }

	[Address(RVA = "0x56A940", Offset = "0x569B40", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x600101B")]
	public static Quaternion GetRelativeRotation(Quaternion from, Quaternion to) { }

	[Address(RVA = "0x56AAD0", Offset = "0x569CD0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600101C")]
	public static float Length(Quaternion quat) { }

	[Address(RVA = "0x56AB20", Offset = "0x569D20", Length = "0xA2")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600101D")]
	public static Quaternion Normalize(Quaternion quat) { }

	[Address(RVA = "0x56ABD0", Offset = "0x569DD0", Length = "0x15F")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600101A")]
	public static void RotatePoints(Quaternion quat, List<Vector3> points, Vector3 pivot) { }

}


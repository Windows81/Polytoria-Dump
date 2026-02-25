namespace RLD;

[Token(Token = "0x20001C0")]
public static class SnapMath
{

	[Address(RVA = "0x586940", Offset = "0x585B40", Length = "0xB8")]
	[CalledBy(Type = typeof(GizmoDblAxisRotationDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001205")]
	public static NumSnapSteps CalculateNumSnapSteps(float snapStep, float total) { }

	[Address(RVA = "0x586A00", Offset = "0x585C00", Length = "0xE")]
	[CalledBy(Type = typeof(GizmoDblAxisOffsetDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisRotationDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisScaleDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisOffsetDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisScaleDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoUniformScaleDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001206")]
	public static bool CanExtractSnap(float snapStep, float accumulated) { }

	[Address(RVA = "0x586A10", Offset = "0x585C10", Length = "0x27")]
	[CalledBy(Type = typeof(GizmoDblAxisOffsetDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisRotationDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisScaleDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisOffsetDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisScaleDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoUniformScaleDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001207")]
	public static float ExtractSnap(float snapStep, ref float accumulated) { }

	[Address(RVA = "0x586A40", Offset = "0x585C40", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001208")]
	public static float ExtractSnap(float snapStep, float accumulated) { }

}


namespace RLD;

[Token(Token = "0x20000FB")]
public class GizmoRotationArc3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000416")]
	private ArcShape3D _arc; //Field offset: 0x10

	[Token(Token = "0x170002D6")]
	public float Radius
	{
		[Address(RVA = "0x513C00", Offset = "0x512E00", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000919")]
		 get { } //Length: 28
		[Address(RVA = "0x513C40", Offset = "0x512E40", Length = "0x1E")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArcShape3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600091A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170002D5")]
	public float RotationAngle
	{
		[Address(RVA = "0x513C20", Offset = "0x512E20", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000917")]
		 get { } //Length: 28
		[Address(RVA = "0x513C60", Offset = "0x512E60", Length = "0x1E")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArcShape3D), Member = "set_DegreeAngleFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000918")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x513B90", Offset = "0x512D90", Length = "0x66")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArcShape3D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091D")]
	public GizmoRotationArc3D() { }

	[Address(RVA = "0x513C00", Offset = "0x512E00", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000919")]
	public float get_Radius() { }

	[Address(RVA = "0x513C20", Offset = "0x512E20", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000917")]
	public float get_RotationAngle() { }

	[Address(RVA = "0x513800", Offset = "0x512A00", Length = "0x19F")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetCullModeOff", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArcShape3D), Member = "set_ForceShortestArc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600091C")]
	public void Render(GizmoRotationArc3DLookAndFeel lookAndFeel) { }

	[Address(RVA = "0x513C40", Offset = "0x512E40", Length = "0x1E")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArcShape3D), Member = "set_Radius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600091A")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x513C60", Offset = "0x512E60", Length = "0x1E")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArcShape3D), Member = "set_DegreeAngleFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000918")]
	public void set_RotationAngle(float value) { }

	[Address(RVA = "0x5139A0", Offset = "0x512BA0", Length = "0x1E5")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(ArcShape3D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600091B")]
	public void SetArcData(Vector3 rotationAxis, Vector3 arcOrigin, Vector3 arcStart, float radius) { }

}


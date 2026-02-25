namespace RLD;

[Token(Token = "0x20000F8")]
public class GizmoRotationArc2D
{
	[Token(Token = "0x20000F9")]
	internal enum ArcType
	{
		Standard = 0,
		PolyProjected = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400040B")]
	private ArcShape2D _arc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400040C")]
	private ArcType _type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400040D")]
	private PolygonShape2D _projectionPoly; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400040E")]
	private int _numProjectedPoints; //Field offset: 0x28

	[Token(Token = "0x170002D0")]
	public int NumProjectedPoints
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000909")]
		 get { } //Length: 4
		[Address(RVA = "0x5137D0", Offset = "0x5129D0", Length = "0x10")]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600090A")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170002CF")]
	public PolygonShape2D ProjectionPoly
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000907")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000908")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002CD")]
	public float RotationAngle
	{
		[Address(RVA = "0x5137B0", Offset = "0x5129B0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000903")]
		 get { } //Length: 28
		[Address(RVA = "0x5137E0", Offset = "0x5129E0", Length = "0x1E")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArcShape2D), Member = "set_DegreeAngleFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000904")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170002CE")]
	public ArcType Type
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000905")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000906")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x513740", Offset = "0x512940", Length = "0x6D")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArcShape2D), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600090D")]
	public GizmoRotationArc2D() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000909")]
	public int get_NumProjectedPoints() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000907")]
	public PolygonShape2D get_ProjectionPoly() { }

	[Address(RVA = "0x5137B0", Offset = "0x5129B0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000903")]
	public float get_RotationAngle() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000905")]
	public ArcType get_Type() { }

	[Address(RVA = "0x5131F0", Offset = "0x5123F0", Length = "0x4E7")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLines2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoLineMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawTriangleFan2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetLit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArcShape2D), Member = "set_ForceShortestArc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "SetCullModeOff", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoSolidMaterial), Member = "ResetValuesToSensibleDefaults", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PrimitiveFactory), Member = "ProjectArcPointsOnPoly2DBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(PolygonShape2D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(PrimitiveFactory), Member = "Generate2DArcBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600090C")]
	public void Render(GizmoRotationArc2DLookAndFeel lookAndFeel, Camera camera) { }

	[Address(RVA = "0x5137D0", Offset = "0x5129D0", Length = "0x10")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600090A")]
	public void set_NumProjectedPoints(int value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000908")]
	public void set_ProjectionPoly(PolygonShape2D value) { }

	[Address(RVA = "0x5137E0", Offset = "0x5129E0", Length = "0x1E")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArcShape2D), Member = "set_DegreeAngleFromStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000904")]
	public void set_RotationAngle(float value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000906")]
	public void set_Type(ArcType value) { }

	[Address(RVA = "0x5136E0", Offset = "0x5128E0", Length = "0x59")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArcShape2D), Member = "set_Origin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArcShape2D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600090B")]
	public void SetArcData(Vector2 arcOrigin, Vector2 arcStart, float radius) { }

}


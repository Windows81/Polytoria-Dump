//Type is in global namespace

[Token(Token = "0x2000017")]
public class LTSpline
{
	[Token(Token = "0x40000CA")]
	public static int DISTANCE_COUNT; //Field offset: 0x0
	[Token(Token = "0x40000CB")]
	public static int SUBLINE_COUNT; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CC")]
	public float distance; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000CD")]
	public bool constantSpeed; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000CE")]
	public Vector3[] pts; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000CF")]
	public Vector3[] ptsAdj; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D0")]
	public int ptsAdjLength; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000D1")]
	public bool orientToPath; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40000D2")]
	public bool orientToPath2d; //Field offset: 0x2D
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D3")]
	private int numSections; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000D4")]
	private int currPt; //Field offset: 0x34

	[Address(RVA = "0x2C1250", Offset = "0x2C0450", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600014C")]
	private static LTSpline() { }

	[Address(RVA = "0x2C12F0", Offset = "0x2C04F0", Length = "0x36")]
	[CalledBy(Type = typeof(LTDescr), Member = "setDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(LTDescr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LTSpline), Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000139")]
	public LTSpline(Vector3[] pts) { }

	[Address(RVA = "0x2C12A0", Offset = "0x2C04A0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTSpline), Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600013A")]
	public LTSpline(Vector3[] pts, bool constantSpeed) { }

	[Address(RVA = "0x2C1460", Offset = "0x2C0660", Length = "0x22D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LTSpline), Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000148")]
	public static void drawGizmo(Transform[] arr, Color color) { }

	[Address(RVA = "0x2C1330", Offset = "0x2C0530", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmos), Member = "get_color", ReturnType = typeof(Color))]
	[Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000147")]
	public void drawGizmo(Color color) { }

	[Address(RVA = "0x2C1690", Offset = "0x2C0890", Length = "0x13")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000149")]
	public static void drawLine(Transform[] arr, float width, Color color) { }

	[Address(RVA = "0x2C16B0", Offset = "0x2C08B0", Length = "0x204")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GL), Member = "PushMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GL), Member = "LoadPixelMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LTSpline), Member = "interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GL), Member = "Vertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(GL), Member = "PopMatrix", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600014A")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width) { }

	[Address(RVA = "0x2C18C0", Offset = "0x2C0AC0", Length = "0x226")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LTSpline), Member = "interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600014B")]
	public Vector3[] generateVectors() { }

	[Address(RVA = "0x2C1AF0", Offset = "0x2C0CF0", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000146")]
	public void gizmoDraw(float t = -1) { }

	[Address(RVA = "0x2C1BC0", Offset = "0x2C0DC0", Length = "0x508")]
	[CalledBy(Type = typeof(LeanTween), Member = "moveSpline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[CalledBy(Type = typeof(LeanTween), Member = "moveSplineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[CalledBy(Type = typeof(LTSpline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "drawGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform[]), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LeanTween), Member = "logError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(LTSpline), Member = "interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013B")]
	private void init(Vector3[] pts, bool constantSpeed) { }

	[Address(RVA = "0x2C20D0", Offset = "0x2C12D0", Length = "0x486")]
	[CalledBy(Type = typeof(LTSpline), Member = "init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(LTSpline), Member = "drawLinesGLLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "generateVectors", ReturnType = typeof(Vector3[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600013D")]
	public Vector3 interp(float t) { }

	[Address(RVA = "0x2C2560", Offset = "0x2C1760", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013C")]
	public Vector3 map(float u) { }

	[Address(RVA = "0x2C2CC0", Offset = "0x2C1EC0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000143")]
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	[Address(RVA = "0x2C2DA0", Offset = "0x2C1FA0", Length = "0x10C")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveSpline>b__83_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000142")]
	public void place(Transform transform, float ratio) { }

	[Address(RVA = "0x2C26D0", Offset = "0x2C18D0", Length = "0x11A")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveSpline>b__83_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000140")]
	public void place2d(Transform transform, float ratio) { }

	[Address(RVA = "0x2C2B60", Offset = "0x2C1D60", Length = "0x154")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveSplineLocal>b__84_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000144")]
	public void placeLocal(Transform transform, float ratio) { }

	[Address(RVA = "0x2C2A40", Offset = "0x2C1C40", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000145")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	[Address(RVA = "0x2C27F0", Offset = "0x2C19F0", Length = "0x241")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveSplineLocal>b__84_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LTSpline), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000141")]
	public void placeLocal2d(Transform transform, float ratio) { }

	[Address(RVA = "0x2C2EB0", Offset = "0x2C20B0", Length = "0x1A9")]
	[CalledBy(Type = typeof(LTSpline), Member = "placeLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "place2d", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "placeLocal2d", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "place", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "place", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTSpline), Member = "placeLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveSpline>b__83_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveSplineLocal>b__84_0", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(LTSpline), Member = "interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180289280")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013F")]
	public Vector3 point(float ratio) { }

	[Address(RVA = "0x2C3060", Offset = "0x2C2260", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600013E")]
	public float ratioAtPoint(Vector3 pt) { }

}


//Type is in global namespace

[Token(Token = "0x2000016")]
public class LTBezierPath
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C2")]
	public Vector3[] pts; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C3")]
	public float length; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000C4")]
	public bool orientToPath; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x40000C5")]
	public bool orientToPath2d; //Field offset: 0x1D
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C6")]
	private LTBezier[] beziers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C7")]
	private Single[] lengthRatio; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C8")]
	private int currentBezier; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000C9")]
	private int previousBezier; //Field offset: 0x34

	[Token(Token = "0x1700000B")]
	public float distance
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012C")]
	public LTBezierPath() { }

	[Address(RVA = "0x2BC7C0", Offset = "0x2BB9C0", Length = "0x2F")]
	[CalledBy(Type = typeof(LTDescr), Member = "setDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(LTDescr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LTBezierPath), Member = "setPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600012D")]
	public LTBezierPath(Vector3[] pts_) { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	public float get_distance() { }

	[Address(RVA = "0x2BC800", Offset = "0x2BBA00", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmos), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000137")]
	public void gizmoDraw(float t = -1) { }

	[Address(RVA = "0x2BCE70", Offset = "0x2BC070", Length = "0x10C")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveCurved>b__81_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000133")]
	public void place(Transform transform, float ratio) { }

	[Address(RVA = "0x2BCF80", Offset = "0x2BC180", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000134")]
	public void place(Transform transform, float ratio, Vector3 worldUp) { }

	[Address(RVA = "0x2BC920", Offset = "0x2BBB20", Length = "0x11A")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveCurved>b__81_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000131")]
	public void place2d(Transform transform, float ratio) { }

	[Address(RVA = "0x2BCB60", Offset = "0x2BBD60", Length = "0x19D")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveCurvedLocal>b__82_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000135")]
	public void placeLocal(Transform transform, float ratio) { }

	[Address(RVA = "0x2BCD00", Offset = "0x2BBF00", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000136")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp) { }

	[Address(RVA = "0x2BCA40", Offset = "0x2BBC40", Length = "0x11A")]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveCurvedLocal>b__82_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_localPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288D90")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000132")]
	public void placeLocal2d(Transform transform, float ratio) { }

	[Address(RVA = "0x2BD060", Offset = "0x2BC260", Length = "0xF9")]
	[CalledBy(Type = typeof(LTBezierPath), Member = "place2d", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "placeLocal2d", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "place", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "place", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "placeLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "placeLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "gizmoDraw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTBezierPath), Member = "ratioAtPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveCurved>b__81_0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LTDescr), Member = "<setMoveCurvedLocal>b__82_0", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(LTBezier), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000130")]
	public Vector3 point(float ratio) { }

	[Address(RVA = "0x2BD160", Offset = "0x2BC360", Length = "0x2B2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
	[Calls(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000138")]
	public float ratioAtPoint(Vector3 pt, float precision = 0.01) { }

	[Address(RVA = "0x2BD420", Offset = "0x2BC620", Length = "0x485")]
	[CalledBy(Type = typeof(LeanTween), Member = "move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[CalledBy(Type = typeof(LeanTween), Member = "moveLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3[]), typeof(float)}, ReturnType = typeof(LTDescr))]
	[CalledBy(Type = typeof(LTBezierPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(LeanTween), Member = "logError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(LTBezier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x600012E")]
	public void setPoints(Vector3[] pts_) { }

}


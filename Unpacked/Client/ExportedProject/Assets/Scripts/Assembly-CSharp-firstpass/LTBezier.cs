//Type is in global namespace

[Token(Token = "0x2000015")]
public class LTBezier
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BB")]
	public float length; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000BC")]
	private Vector3 a; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BD")]
	private Vector3 aa; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000BE")]
	private Vector3 bb; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000BF")]
	private Vector3 cc; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000C0")]
	private float len; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000C1")]
	private Single[] arcLengths; //Field offset: 0x48

	[Address(RVA = "0x2BD8B0", Offset = "0x2BCAB0", Length = "0x46B")]
	[CalledBy(Type = typeof(LTBezierPath), Member = "setPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000128")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision) { }

	[Address(RVA = "0x2BDD20", Offset = "0x2BCF20", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600012A")]
	private Vector3 bezierPoint(float t) { }

	[Address(RVA = "0x2BDDD0", Offset = "0x2BCFD0", Length = "0x118")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000129")]
	private float map(float u) { }

	[Address(RVA = "0x2BDEF0", Offset = "0x2BD0F0", Length = "0x1F3")]
	[CalledBy(Type = typeof(LTBezierPath), Member = "point", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600012B")]
	public Vector3 point(float t) { }

}


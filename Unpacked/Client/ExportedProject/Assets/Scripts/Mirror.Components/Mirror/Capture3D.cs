namespace Mirror;

[Token(Token = "0x200001E")]
public struct Capture3D : Capture
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008A")]
	private double <timestamp>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400008B")]
	public Vector3 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400008C")]
	public Vector3 size; //Field offset: 0x14

	[Token(Token = "0x17000006")]
	public override double timestamp
	{
		[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600008B")]
		 get { } //Length: 5
		[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x120B2D0", Offset = "0x120A4D0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600008D")]
	public Capture3D(double timestamp, Vector3 position, Vector3 size) { }

	[Address(RVA = "0x120B0D0", Offset = "0x120A2D0", Length = "0x3F")]
	[CalledBy(Type = typeof(LagCompensation), Member = "DrawGizmos", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Queue`1<KeyValuePair`2<Double, T>>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Gizmos), Member = "DrawWireCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x600008E")]
	public override void DrawGizmo() { }

	[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600008B")]
	public override double get_timestamp() { }

	[Address(RVA = "0x120B110", Offset = "0x120A310", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008F")]
	public static Capture3D Interpolate(Capture3D from, Capture3D to, double t) { }

	[Address(RVA = "0x120B300", Offset = "0x120A500", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public override void set_timestamp(double value) { }

	[Address(RVA = "0x120B200", Offset = "0x120A400", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000090")]
	public virtual string ToString() { }

}


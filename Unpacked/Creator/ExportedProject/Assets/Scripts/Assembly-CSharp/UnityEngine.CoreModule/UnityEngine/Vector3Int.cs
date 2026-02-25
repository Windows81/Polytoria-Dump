namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000101")]
[UsedByNativeCode]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
{
	[Token(Token = "0x40004D5")]
	private static readonly Vector3Int s_Zero; //Field offset: 0x0
	[Token(Token = "0x40004D6")]
	private static readonly Vector3Int s_One; //Field offset: 0xC
	[Token(Token = "0x40004D7")]
	private static readonly Vector3Int s_Up; //Field offset: 0x18
	[Token(Token = "0x40004D8")]
	private static readonly Vector3Int s_Down; //Field offset: 0x24
	[Token(Token = "0x40004D9")]
	private static readonly Vector3Int s_Left; //Field offset: 0x30
	[Token(Token = "0x40004DA")]
	private static readonly Vector3Int s_Right; //Field offset: 0x3C
	[Token(Token = "0x40004DB")]
	private static readonly Vector3Int s_Forward; //Field offset: 0x48
	[Token(Token = "0x40004DC")]
	private static readonly Vector3Int s_Back; //Field offset: 0x54
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D2")]
	private int m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004D3")]
	private int m_Y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004D4")]
	private int m_Z; //Field offset: 0x8

	[Token(Token = "0x1700016C")]
	public int sqrMagnitude
	{
		[Address(RVA = "0x1958410", Offset = "0x1957610", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600082A")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000169")]
	public int x
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000823")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000824")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700016A")]
	public int y
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000825")]
		 get { } //Length: 6
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000826")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700016B")]
	public int z
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000827")]
		 get { } //Length: 6
		[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000828")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x19582C0", Offset = "0x19574C0", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000834")]
	private static Vector3Int() { }

	[Address(RVA = "0x58D8C0", Offset = "0x58CAC0", Length = "0xB")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000829")]
	public Vector3Int(int x, int y, int z) { }

	[Address(RVA = "0x1958020", Offset = "0x1957220", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000830")]
	public override bool Equals(Vector3Int other) { }

	[Address(RVA = "0x1957F50", Offset = "0x1957150", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600082F")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x1958410", Offset = "0x1957610", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600082A")]
	public int get_sqrMagnitude() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000823")]
	public int get_x() { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000825")]
	public int get_y() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000827")]
	public int get_z() { }

	[Address(RVA = "0xAADCB0", Offset = "0xAACEB0", Length = "0x74")]
	[CalledBy(Type = typeof(BoundsInt), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000831")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1958430", Offset = "0x1957630", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600082C")]
	public static Vector3Int op_Addition(Vector3Int a, Vector3Int b) { }

	[Address(RVA = "0x1958470", Offset = "0x1957670", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600082E")]
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	[Address(RVA = "0x1958490", Offset = "0x1957690", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600082D")]
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	[Address(RVA = "0x1958070", Offset = "0x1957270", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Token(Token = "0x600082B")]
	public static Vector3Int RoundToInt(Vector3 v) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000824")]
	public void set_x(int value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000826")]
	public void set_y(int value) { }

	[Address(RVA = "0x3B9460", Offset = "0x3B8660", Length = "0x4")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000828")]
	public void set_z(int value) { }

	[Address(RVA = "0x19581A0", Offset = "0x19573A0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000833")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1958190", Offset = "0x1957390", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2ACE0")]
	[Token(Token = "0x6000832")]
	public virtual string ToString() { }

}


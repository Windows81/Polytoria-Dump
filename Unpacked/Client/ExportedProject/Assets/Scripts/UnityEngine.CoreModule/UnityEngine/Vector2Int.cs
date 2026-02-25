namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeType("Runtime/Math/Vector2Int.h")]
[Token(Token = "0x2000100")]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	[Token(Token = "0x40004CC")]
	private static readonly Vector2Int s_Zero; //Field offset: 0x0
	[Token(Token = "0x40004CD")]
	private static readonly Vector2Int s_One; //Field offset: 0x8
	[Token(Token = "0x40004CE")]
	private static readonly Vector2Int s_Up; //Field offset: 0x10
	[Token(Token = "0x40004CF")]
	private static readonly Vector2Int s_Down; //Field offset: 0x18
	[Token(Token = "0x40004D0")]
	private static readonly Vector2Int s_Left; //Field offset: 0x20
	[Token(Token = "0x40004D1")]
	private static readonly Vector2Int s_Right; //Field offset: 0x28
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004CA")]
	private int m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004CB")]
	private int m_Y; //Field offset: 0x4

	[Token(Token = "0x17000166")]
	public static Vector2Int down
	{
		[Address(RVA = "0x1957340", Offset = "0x1956540", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600081F")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000167")]
	public static Vector2Int left
	{
		[Address(RVA = "0x1957380", Offset = "0x1956580", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000820")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000168")]
	public static Vector2Int right
	{
		[Address(RVA = "0x19573C0", Offset = "0x19565C0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000821")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000163")]
	public int sqrMagnitude
	{
		[Address(RVA = "0x1957400", Offset = "0x1956600", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000811")]
		 get { } //Length: 16
	}

	[Token(Token = "0x17000165")]
	public static Vector2Int up
	{
		[Address(RVA = "0x1957410", Offset = "0x1956610", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600081E")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000161")]
	public int x
	{
		[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
		[CallerCount(Count = 230)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080C")]
		 get { } //Length: 5
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080D")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000162")]
	public int y
	{
		[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
		[CallerCount(Count = 54)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080E")]
		 get { } //Length: 6
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600080F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000164")]
	public static Vector2Int zero
	{
		[Address(RVA = "0x1957450", Offset = "0x1956650", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600081D")]
		 get { } //Length: 54
	}

	[Address(RVA = "0x1957250", Offset = "0x1956450", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000822")]
	private static Vector2Int() { }

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000810")]
	public Vector2Int(int x, int y) { }

	[Address(RVA = "0x1956F90", Offset = "0x1956190", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000819")]
	public override bool Equals(Vector2Int other) { }

	[Address(RVA = "0x1956FB0", Offset = "0x19561B0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000818")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x1957060", Offset = "0x1956260", Length = "0xB2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000813")]
	public static Vector2Int FloorToInt(Vector2 v) { }

	[Address(RVA = "0x1957340", Offset = "0x1956540", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600081F")]
	public static Vector2Int get_down() { }

	[Address(RVA = "0x1957380", Offset = "0x1956580", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000820")]
	public static Vector2Int get_left() { }

	[Address(RVA = "0x19573C0", Offset = "0x19565C0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000821")]
	public static Vector2Int get_right() { }

	[Address(RVA = "0x1957400", Offset = "0x1956600", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000811")]
	public int get_sqrMagnitude() { }

	[Address(RVA = "0x1957410", Offset = "0x1956610", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600081E")]
	public static Vector2Int get_up() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080C")]
	public int get_x() { }

	[Address(RVA = "0xF698A0", Offset = "0xF68AA0", Length = "0x6")]
	[CallerCount(Count = 54)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080E")]
	public int get_y() { }

	[Address(RVA = "0x1957450", Offset = "0x1956650", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600081D")]
	public static Vector2Int get_zero() { }

	[Address(RVA = "0x1957120", Offset = "0x1956320", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600081A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1957490", Offset = "0x1956690", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000815")]
	public static Vector2Int op_Addition(Vector2Int a, Vector2Int b) { }

	[Address(RVA = "0x19574B0", Offset = "0x19566B0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000817")]
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	[Address(RVA = "0x19574D0", Offset = "0x19566D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000812")]
	public static Vector2 op_Implicit(Vector2Int v) { }

	[Address(RVA = "0x19574F0", Offset = "0x19566F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000816")]
	public static Vector2Int op_Subtraction(Vector2Int a, Vector2Int b) { }

	[Address(RVA = "0x120AF70", Offset = "0x120A170", Length = "0x15B")]
	[CalledBy(Type = "Mirror.SpatialHashingInterestManagement", Member = "ProjectToGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector2Int))]
	[CalledBy(Type = "Mirror.SpatialHashingInterestManagement", Member = "OnCheckObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SpatialHashingInterestManagement", Member = "OnRebuildObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", "System.Collections.Generic.HashSet`1<NetworkConnectionToClient>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SpatialHashingInterestManagement", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000814")]
	public static Vector2Int RoundToInt(Vector2 v) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080D")]
	public void set_x(int value) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080F")]
	public void set_y(int value) { }

	[Address(RVA = "0x1957240", Offset = "0x1956440", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2ABE0")]
	[Token(Token = "0x600081B")]
	public virtual string ToString() { }

	[Address(RVA = "0x1957140", Offset = "0x1956340", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600081C")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


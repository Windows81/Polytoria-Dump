namespace Polytoria.Lua;

[Token(Token = "0x2000306")]
public class LuaQuaternion
{

	[Token(Token = "0x170008DC")]
	public static Quaternion Identity
	{
		[Address(RVA = "0x40EC50", Offset = "0x40DE50", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BD6")]
		 get { } //Length: 66
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BD7")]
	public LuaQuaternion() { }

	[Address(RVA = "0x40E5B0", Offset = "0x40D7B0", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Token(Token = "0x6001BC7")]
	public static float Angle(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x40E570", Offset = "0x40D770", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BC8")]
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[Address(RVA = "0x40E640", Offset = "0x40D840", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BC9")]
	public float Dot(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x40E700", Offset = "0x40D900", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BCA")]
	public static Quaternion Euler(float x, float y, float z) { }

	[Address(RVA = "0x40E690", Offset = "0x40D890", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BCB")]
	public static Quaternion Euler(Vector3 euler) { }

	[Address(RVA = "0x40E750", Offset = "0x40D950", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BCC")]
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[Address(RVA = "0x40EC50", Offset = "0x40DE50", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001BD6")]
	public static Quaternion get_Identity() { }

	[Address(RVA = "0x40E7B0", Offset = "0x40D9B0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BCD")]
	public static Quaternion Inverse(Quaternion rotation) { }

	[Address(RVA = "0x40E840", Offset = "0x40DA40", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BCE")]
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x40E7F0", Offset = "0x40D9F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "LerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BCF")]
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x40E8F0", Offset = "0x40DAF0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BD0")]
	public static Quaternion LookRotation(Vector3 forward) { }

	[Address(RVA = "0x40E890", Offset = "0x40DA90", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BD1")]
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[Address(RVA = "0x40E940", Offset = "0x40DB40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC5")]
	public static Quaternion New(float d) { }

	[Address(RVA = "0x40E010", Offset = "0x40D210", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC6")]
	public static Quaternion New(float x, float y, float z, float w) { }

	[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC4")]
	public static Quaternion New() { }

	[Address(RVA = "0x40E950", Offset = "0x40DB50", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001BD2")]
	public static Quaternion Normalize(Quaternion q) { }

	[Address(RVA = "0x40EA90", Offset = "0x40DC90", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Calls(Type = typeof(Quaternion), Member = "SlerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001BD3")]
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	[Address(RVA = "0x40EC00", Offset = "0x40DE00", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BD4")]
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x40EBB0", Offset = "0x40DDB0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "SlerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x6001BD5")]
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

}


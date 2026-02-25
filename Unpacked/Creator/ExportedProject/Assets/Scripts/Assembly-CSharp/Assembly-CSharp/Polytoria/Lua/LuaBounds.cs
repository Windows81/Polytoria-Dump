namespace Polytoria.Lua;

[Token(Token = "0x2000302")]
public class LuaBounds
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB4")]
	public LuaBounds() { }

	[Address(RVA = "0x40DB20", Offset = "0x40CD20", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "ClosestPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001BAC")]
	public static Vector3 ClosestPoint(Bounds bounds, Vector3 point) { }

	[Address(RVA = "0x40DB70", Offset = "0x40CD70", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001BAD")]
	public static bool Contains(Bounds bounds, Vector3 point) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BAE")]
	public static void Encapsulate(Bounds bounds, Vector3 point) { }

	[Address(RVA = "0x40DBA0", Offset = "0x40CDA0", Length = "0x3")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BAF")]
	public static void Encapsulate(Bounds bounds, Bounds other) { }

	[Address(RVA = "0x40DBB0", Offset = "0x40CDB0", Length = "0x135")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Bounds), Member = "IntersectRayAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Bounds), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Tuple`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001BB3")]
	public static Tuple<Boolean, Single> IntersectRay(Bounds bounds, Vector3 origin, Vector3 direction) { }

	[Address(RVA = "0x40DCF0", Offset = "0x40CEF0", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001BB0")]
	public static bool Intersects(Bounds bounds, Bounds other) { }

	[Address(RVA = "0x40DE20", Offset = "0x40D020", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001BAA")]
	public static Bounds New() { }

	[Address(RVA = "0x40DDD0", Offset = "0x40CFD0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BAB")]
	public static Bounds New(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x40DBA0", Offset = "0x40CDA0", Length = "0x3")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BB1")]
	public static void SetMinMax(Bounds bounds, Vector3 min, Vector3 max) { }

	[Address(RVA = "0x40DEE0", Offset = "0x40D0E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bounds), Member = "SqrDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(float))]
	[Token(Token = "0x6001BB2")]
	public static float SqrDistance(Bounds bounds, Vector3 point) { }

}


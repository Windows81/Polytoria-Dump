namespace Polytoria.Lua;

[Token(Token = "0x2000308")]
public class LuaVector3
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BF5")]
	public LuaVector3() { }

	[Address(RVA = "0x40ED40", Offset = "0x40DF40", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400380")]
	[Token(Token = "0x6001BE2")]
	public static float Angle(Vector3 from, Vector3 to) { }

	[Address(RVA = "0x40ED80", Offset = "0x40DF80", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001BE3")]
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	[Address(RVA = "0x40EEC0", Offset = "0x40E0C0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BE4")]
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x40EF50", Offset = "0x40E150", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001BE5")]
	public static float Distance(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x40F040", Offset = "0x40E240", Length = "0x39")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BE6")]
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x40F080", Offset = "0x40E280", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BE7")]
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x40F110", Offset = "0x40E310", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BE8")]
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x40F150", Offset = "0x40E350", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BE9")]
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x40F190", Offset = "0x40E390", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001BEA")]
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[Address(RVA = "0x40F390", Offset = "0x40E590", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BE0")]
	public static Vector3 New(float x, float y, float z) { }

	[Address(RVA = "0x40F3B0", Offset = "0x40E5B0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BDF")]
	public static Vector3 New(float x, float y) { }

	[Address(RVA = "0x40F340", Offset = "0x40E540", Length = "0x12")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BDE")]
	public static Vector3 New(float d) { }

	[Address(RVA = "0x40F360", Offset = "0x40E560", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BE1")]
	public static Vector3 New(Vector2 v) { }

	[Address(RVA = "0x40F330", Offset = "0x40E530", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BDD")]
	public static Vector3 New() { }

	[Address(RVA = "0x40F3D0", Offset = "0x40E5D0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001BEB")]
	public static Vector3 Normalize(Vector3 value) { }

	[Address(RVA = "0x40F560", Offset = "0x40E760", Length = "0x128")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001BEC")]
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	[Address(RVA = "0x40F420", Offset = "0x40E620", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001BED")]
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	[Address(RVA = "0x40F690", Offset = "0x40E890", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BEE")]
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	[Address(RVA = "0x40F720", Offset = "0x40E920", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "RotateTowards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001BEF")]
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	[Address(RVA = "0x40F790", Offset = "0x40E990", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001BF0")]
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x40F7E0", Offset = "0x40E9E0", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400380")]
	[Token(Token = "0x6001BF1")]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	[Address(RVA = "0x40F990", Offset = "0x40EB90", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001BF2")]
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x40F920", Offset = "0x40EB20", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "SlerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001BF3")]
	public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x40FA00", Offset = "0x40EC00", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "SmoothDamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001BF4")]
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

}


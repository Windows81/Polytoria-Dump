namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector3f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20000FC")]
public struct Vector3 : IEquatable<Vector3>, IFormattable
{
	[Token(Token = "0x40004A8")]
	public const float kEpsilon = 1E-05; //Field offset: 0x0
	[Token(Token = "0x40004A9")]
	public const float kEpsilonNormalSqrt = 1E-15; //Field offset: 0x0
	[Token(Token = "0x40004AD")]
	private static readonly Vector3 zeroVector; //Field offset: 0x0
	[Token(Token = "0x40004AE")]
	private static readonly Vector3 oneVector; //Field offset: 0xC
	[Token(Token = "0x40004AF")]
	private static readonly Vector3 upVector; //Field offset: 0x18
	[Token(Token = "0x40004B0")]
	private static readonly Vector3 downVector; //Field offset: 0x24
	[Token(Token = "0x40004B1")]
	private static readonly Vector3 leftVector; //Field offset: 0x30
	[Token(Token = "0x40004B2")]
	private static readonly Vector3 rightVector; //Field offset: 0x3C
	[Token(Token = "0x40004B3")]
	private static readonly Vector3 forwardVector; //Field offset: 0x48
	[Token(Token = "0x40004B4")]
	private static readonly Vector3 backVector; //Field offset: 0x54
	[Token(Token = "0x40004B5")]
	private static readonly Vector3 positiveInfinityVector; //Field offset: 0x60
	[Token(Token = "0x40004B6")]
	private static readonly Vector3 negativeInfinityVector; //Field offset: 0x6C
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AA")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004AB")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004AC")]
	public float z; //Field offset: 0x8

	[Token(Token = "0x1700014C")]
	public static Vector3 back
	{
		[Address(RVA = "0x1959A20", Offset = "0x1958C20", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600076D")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700014E")]
	public static Vector3 down
	{
		[Address(RVA = "0x1959A70", Offset = "0x1958C70", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600076F")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700014B")]
	public static Vector3 forward
	{
		[Address(RVA = "0x1959AC0", Offset = "0x1958CC0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600076C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000145")]
	public float Item
	{
		[Address(RVA = "0x2BC430", Offset = "0x2BB630", Length = "0x29B")]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ObjectExtrudeGizmo", Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.BoxGizmo", Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.BoxMath", Member = "CalcBoxPtClosestToPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.ObjectVertexCollect", Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), "RLD.BoxFace", typeof(float), typeof(float)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000750")]
		 get { } //Length: 667
		[Address(RVA = "0x3AFDE0", Offset = "0x3AEFE0", Length = "0x81")]
		[CalledBy(Type = "RLD.GizmoDblAxisScaleDrag3D", Member = "CalculateDragValues", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.GizmoSglAxisScaleDrag3D", Member = "CalculateDragValues", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ObjectVertexCollect", Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), "RLD.BoxFace", typeof(float), typeof(float)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000751")]
		 set { } //Length: 129
	}

	[Token(Token = "0x1700014F")]
	public static Vector3 left
	{
		[Address(RVA = "0x1959B10", Offset = "0x1958D10", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000770")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000147")]
	public float magnitude
	{
		[Address(RVA = "0x1959B60", Offset = "0x1958D60", Length = "0xE1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000765")]
		 get { } //Length: 225
	}

	[Token(Token = "0x17000146")]
	public Vector3 normalized
	{
		[Address(RVA = "0x1959C50", Offset = "0x1958E50", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600075C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700014A")]
	public static Vector3 one
	{
		[Address(RVA = "0x1959CA0", Offset = "0x1958EA0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600076B")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000151")]
	public static Vector3 positiveInfinity
	{
		[Address(RVA = "0x1959CF0", Offset = "0x1958EF0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000772")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000150")]
	public static Vector3 right
	{
		[Address(RVA = "0x1959D40", Offset = "0x1958F40", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000771")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000148")]
	public float sqrMagnitude
	{
		[Address(RVA = "0x1959710", Offset = "0x1958910", Length = "0x25")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000767")]
		 get { } //Length: 37
	}

	[Token(Token = "0x1700014D")]
	public static Vector3 up
	{
		[Address(RVA = "0x1959D90", Offset = "0x1958F90", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600076E")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000149")]
	public static Vector3 zero
	{
		[Address(RVA = "0x1959DE0", Offset = "0x1958FE0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600076A")]
		 get { } //Length: 74
	}

	[Address(RVA = "0x1959880", Offset = "0x1958A80", Length = "0x173")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600077D")]
	private static Vector3() { }

	[Address(RVA = "0x1959A00", Offset = "0x1958C00", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000753")]
	public Vector3(float x, float y) { }

	[Address(RVA = "0x18246A0", Offset = "0x18238A0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000752")]
	public Vector3(float x, float y, float z) { }

	[Address(RVA = "0x19584D0", Offset = "0x19576D0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B010")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000760")]
	public static float Angle(Vector3 from, Vector3 to) { }

	[Address(RVA = "0x1958640", Offset = "0x1957840", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000763")]
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	[Address(RVA = "0x1958740", Offset = "0x1957940", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000755")]
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x19587A0", Offset = "0x19579A0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000762")]
	public static float Distance(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x1958870", Offset = "0x1957A70", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600075D")]
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x19588A0", Offset = "0x1957AA0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000757")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x18243C0", Offset = "0x18235C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000758")]
	public override bool Equals(Vector3 other) { }

	[Address(RVA = "0x1959A20", Offset = "0x1958C20", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600076D")]
	public static Vector3 get_back() { }

	[Address(RVA = "0x1959A70", Offset = "0x1958C70", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600076F")]
	public static Vector3 get_down() { }

	[Address(RVA = "0x1959AC0", Offset = "0x1958CC0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600076C")]
	public static Vector3 get_forward() { }

	[Address(RVA = "0x2BC430", Offset = "0x2BB630", Length = "0x29B")]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ObjectExtrudeGizmo", Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.BoxGizmo", Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.BoxMath", Member = "CalcBoxPtClosestToPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.ObjectVertexCollect", Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), "RLD.BoxFace", typeof(float), typeof(float)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000750")]
	public float get_Item(int index) { }

	[Address(RVA = "0x1959B10", Offset = "0x1958D10", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000770")]
	public static Vector3 get_left() { }

	[Address(RVA = "0x1959B60", Offset = "0x1958D60", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000765")]
	public float get_magnitude() { }

	[Address(RVA = "0x1959C50", Offset = "0x1958E50", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600075C")]
	public Vector3 get_normalized() { }

	[Address(RVA = "0x1959CA0", Offset = "0x1958EA0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600076B")]
	public static Vector3 get_one() { }

	[Address(RVA = "0x1959CF0", Offset = "0x1958EF0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000772")]
	public static Vector3 get_positiveInfinity() { }

	[Address(RVA = "0x1959D40", Offset = "0x1958F40", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000771")]
	public static Vector3 get_right() { }

	[Address(RVA = "0x1959710", Offset = "0x1958910", Length = "0x25")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000767")]
	public float get_sqrMagnitude() { }

	[Address(RVA = "0x1959D90", Offset = "0x1958F90", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600076E")]
	public static Vector3 get_up() { }

	[Address(RVA = "0x1959DE0", Offset = "0x1958FE0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600076A")]
	public static Vector3 get_zero() { }

	[Address(RVA = "0x1958950", Offset = "0x1957B50", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000756")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1958A00", Offset = "0x1957C00", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600074C")]
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x19589B0", Offset = "0x1957BB0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600074D")]
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x1958A70", Offset = "0x1957C70", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000764")]
	public static float Magnitude(Vector3 vector) { }

	[Address(RVA = "0x1958B20", Offset = "0x1957D20", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000769")]
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x1958B60", Offset = "0x1957D60", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000768")]
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x1958BA0", Offset = "0x1957DA0", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600074E")]
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[Address(RVA = "0x2BC310", Offset = "0x2BB510", Length = "0x11B")]
	[CallerCount(Count = 210)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600075A")]
	public static Vector3 Normalize(Vector3 value) { }

	[Address(RVA = "0x4F9800", Offset = "0x4F8A00", Length = "0x10D")]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "RotationMatrixFromRightUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "RLD.Vector3Ex", Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.PrimitiveFactory", Member = "Generate3DArcBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Plane), typeof(float), typeof(bool), typeof(int)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600075B")]
	public void Normalize() { }

	[Address(RVA = "0x2BC720", Offset = "0x2BB920", Length = "0x2F")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Token(Token = "0x6000773")]
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x2BC750", Offset = "0x2BB950", Length = "0x2A")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000778")]
	public static Vector3 op_Division(Vector3 a, float d) { }

	[Address(RVA = "0x1959E30", Offset = "0x1959030", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000779")]
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x1959E70", Offset = "0x1959070", Length = "0x51")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600077A")]
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	[Address(RVA = "0x1959F00", Offset = "0x1959100", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000776")]
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	[Address(RVA = "0x1959ED0", Offset = "0x19590D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000777")]
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	[Address(RVA = "0x2BC780", Offset = "0x2BB980", Length = "0x2F")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000774")]
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x1959F30", Offset = "0x1959130", Length = "0x57A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(Awaitable), Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AwaiterCompletionThreadAffinity), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18195A110")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000775")]
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	[Address(RVA = "0x1958E30", Offset = "0x1958030", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600075E")]
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	[Address(RVA = "0x1958D10", Offset = "0x1957F10", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600075F")]
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	[Address(RVA = "0x1958F70", Offset = "0x1958170", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000759")]
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	[Address(RVA = "0x1959060", Offset = "0x1958260", Length = "0x75")]
	[CalledBy(Type = "Polytoria.Lua.LuaVector3", Member = "RotateTowards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x600074B")]
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	[Address(RVA = "0x1958FF0", Offset = "0x19581F0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000780")]
	private static void RotateTowards_Injected(in Vector3 current, in Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }

	[Address(RVA = "0x19590E0", Offset = "0x19582E0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000754")]
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x3AFDE0", Offset = "0x3AEFE0", Length = "0x81")]
	[CalledBy(Type = "RLD.GizmoDblAxisScaleDrag3D", Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoSglAxisScaleDrag3D", Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ObjectVertexCollect", Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), "RLD.BoxFace", typeof(float), typeof(float)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000751")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x1959110", Offset = "0x1958310", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400380")]
	[Token(Token = "0x6000761")]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	[Address(RVA = "0x1959340", Offset = "0x1958540", Length = "0x6D")]
	[CalledBy(Type = "Polytoria.Lua.LuaVector3", Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	[Token(Token = "0x6000749")]
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x19592D0", Offset = "0x19584D0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600077E")]
	private static void Slerp_Injected(in Vector3 a, in Vector3 b, float t, out Vector3 ret) { }

	[Address(RVA = "0x1959260", Offset = "0x1958460", Length = "0x6D")]
	[CalledBy(Type = "Polytoria.Lua.LuaVector3", Member = "SlerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("VectorScripting::SlerpUnclamped", IsThreadSafe = True)]
	[Token(Token = "0x600074A")]
	public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t) { }

	[Address(RVA = "0x19591F0", Offset = "0x19583F0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600077F")]
	private static void SlerpUnclamped_Injected(in Vector3 a, in Vector3 b, float t, out Vector3 ret) { }

	[Address(RVA = "0x19593B0", Offset = "0x19585B0", Length = "0x35D")]
	[CalledBy(Type = "Polytoria.Lua.LuaVector3", Member = "SmoothDamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3&), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600074F")]
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	[Address(RVA = "0x1959710", Offset = "0x1958910", Length = "0x25")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000766")]
	public static float SqrMagnitude(Vector3 vector) { }

	[Address(RVA = "0x1959740", Offset = "0x1958940", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D86A0")]
	[Token(Token = "0x600077B")]
	public virtual string ToString() { }

	[Address(RVA = "0x1959750", Offset = "0x1958950", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600077C")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


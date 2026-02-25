namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[Token(Token = "0x20000FD")]
[UsedByNativeCode]
public struct Quaternion : IEquatable<Quaternion>, IFormattable
{
	[Token(Token = "0x40004BB")]
	private static readonly Quaternion identityQuaternion; //Field offset: 0x0
	[Token(Token = "0x40004BC")]
	public const float kEpsilon = 1E-06; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B7")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004B8")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004B9")]
	public float z; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004BA")]
	public float w; //Field offset: 0xC

	[Token(Token = "0x17000154")]
	public Vector3 eulerAngles
	{
		[Address(RVA = "0x194B320", Offset = "0x194A520", Length = "0x107")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000798")]
		 get { } //Length: 263
	}

	[Token(Token = "0x17000153")]
	public static Quaternion identity
	{
		[Address(RVA = "0x194B430", Offset = "0x194A630", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600078F")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000152")]
	public float Item
	{
		[Address(RVA = "0x194B290", Offset = "0x194A490", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600078D")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000155")]
	public Quaternion normalized
	{
		[Address(RVA = "0x194B480", Offset = "0x194A680", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400180")]
		[Token(Token = "0x600079E")]
		 get { } //Length: 56
	}

	[Address(RVA = "0x194B250", Offset = "0x194A450", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60007A4")]
	private static Quaternion() { }

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x600078E")]
	public Quaternion(float x, float y, float z, float w) { }

	[Address(RVA = "0x194A130", Offset = "0x1949330", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Token(Token = "0x6000796")]
	public static float Angle(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x194A0D0", Offset = "0x19492D0", Length = "0x5B")]
	[CallerCount(Count = 75)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	[Token(Token = "0x600078A")]
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[Address(RVA = "0x194A070", Offset = "0x1949270", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AE")]
	private static void AngleAxis_Injected(float angle, in Vector3 axis, out Quaternion ret) { }

	[Address(RVA = "0x194A1C0", Offset = "0x19493C0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000795")]
	public static float Dot(Quaternion a, Quaternion b) { }

	[Address(RVA = "0x1942D90", Offset = "0x1941F90", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60007A1")]
	public override bool Equals(Quaternion other) { }

	[Address(RVA = "0x194A200", Offset = "0x1949400", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60007A0")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x194A300", Offset = "0x1949500", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600079A")]
	public static Quaternion Euler(Vector3 euler) { }

	[Address(RVA = "0x194A390", Offset = "0x1949590", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000799")]
	public static Quaternion Euler(float x, float y, float z) { }

	[Address(RVA = "0x194A470", Offset = "0x1949670", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), "UnityEngine.UIElements.VisualElement&", "UnityEngine.UIElements.RuntimePanel&", typeof(Vector3&), "UnityEngine.UIElements.VisualElement&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "FromToRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	[Token(Token = "0x6000781")]
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[Address(RVA = "0x194A410", Offset = "0x1949610", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A5")]
	private static void FromToRotation_Injected(in Vector3 fromDirection, in Vector3 toDirection, out Quaternion ret) { }

	[Address(RVA = "0x194B320", Offset = "0x194A520", Length = "0x107")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000798")]
	public Vector3 get_eulerAngles() { }

	[Address(RVA = "0x194B430", Offset = "0x194A630", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600078F")]
	public static Quaternion get_identity() { }

	[Address(RVA = "0x194B290", Offset = "0x194A490", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600078D")]
	public float get_Item(int index) { }

	[Address(RVA = "0x194B480", Offset = "0x194A680", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400180")]
	[Token(Token = "0x600079E")]
	public Quaternion get_normalized() { }

	[Address(RVA = "0x698380", Offset = "0x697580", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600079F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x194A520", Offset = "0x1949720", Length = "0x4B")]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	[Token(Token = "0x6000787")]
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[Address(RVA = "0x194A4D0", Offset = "0x19496D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AB")]
	private static void Internal_FromEulerRad_Injected(in Vector3 euler, out Quaternion ret) { }

	[Address(RVA = "0x194A570", Offset = "0x1949770", Length = "0x82")]
	[CallerCount(Count = 51)]
	[Token(Token = "0x6000797")]
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	[Address(RVA = "0x194A660", Offset = "0x1949860", Length = "0x52")]
	[CalledBy(Type = "UnityEngine.UIElements.Rotate", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.QuaternionEx", Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = True)]
	[Token(Token = "0x6000789")]
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[Address(RVA = "0x194A600", Offset = "0x1949800", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AD")]
	private static void Internal_ToAxisAngleRad_Injected(in Quaternion q, out Vector3 axis, out float angle) { }

	[Address(RVA = "0x194A710", Offset = "0x1949910", Length = "0x4D")]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	[Token(Token = "0x6000788")]
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[Address(RVA = "0x194A6C0", Offset = "0x19498C0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AC")]
	private static void Internal_ToEulerRad_Injected(in Quaternion rotation, out Vector3 ret) { }

	[Address(RVA = "0x194A7B0", Offset = "0x19499B0", Length = "0x4B")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(IsThreadSafe = True)]
	[Token(Token = "0x6000782")]
	public static Quaternion Inverse(Quaternion rotation) { }

	[Address(RVA = "0x194A760", Offset = "0x1949960", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A6")]
	private static void Inverse_Injected(in Quaternion rotation, out Quaternion ret) { }

	[Address(RVA = "0x194A800", Offset = "0x1949A00", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000792")]
	private static bool IsEqualUsingDot(float dot) { }

	[Address(RVA = "0x194A960", Offset = "0x1949B60", Length = "0x6B")]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "MoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	[Token(Token = "0x6000785")]
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x194A8F0", Offset = "0x1949AF0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A9")]
	private static void Lerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x194A880", Offset = "0x1949A80", Length = "0x6B")]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "LerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = True)]
	[Token(Token = "0x6000786")]
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x194A810", Offset = "0x1949A10", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AA")]
	private static void LerpUnclamped_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x194AA30", Offset = "0x1949C30", Length = "0xB1")]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Text3D", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Transform), Member = "set_forward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x600078C")]
	public static Quaternion LookRotation(Vector3 forward) { }

	[Address(RVA = "0x194AAF0", Offset = "0x1949CF0", Length = "0x5B")]
	[CalledBy(Type = "RLD.QuadMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), "RLD.QuadEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.SceneGizmoAxisCap", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.SceneGizmoAxisCap", Member = "OnGizmoHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Gizmo", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoPlaneSlider3D", Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.GizmoTransform", "RLD.PlaneId", "RLD.PlaneQuadrantId", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GizmoPlaneSlider3D", Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.GizmoTransform", "RLD.PlaneId", "RLD.GizmoLineSlider3D", "RLD.GizmoLineSlider3D", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ArcMath", Member = "CalcSh3DArcOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), "RLD.ArcEpsilon"}, ReturnType = "RLD.OBB")]
	[CalledBy(Type = "RLD.ArcMath", Member = "CalcLg3DArcOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), "RLD.ArcEpsilon"}, ReturnType = "RLD.OBB")]
	[CalledBy(Type = "RLD.QuadMath", Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), "RLD.QuadEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.TriangleMath", Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), "RLD.TriangleEpsilon"}, ReturnType = "RLD.OBB")]
	[CalledBy(Type = "RLD.TorusShape3D", Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "MoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	[Token(Token = "0x600078B")]
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[Address(RVA = "0x194A9D0", Offset = "0x1949BD0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007AF")]
	private static void LookRotation_Injected(in Vector3 forward, in Vector3 upwards, out Quaternion ret) { }

	[Address(RVA = "0x194AB50", Offset = "0x1949D50", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600079D")]
	public static Quaternion Normalize(Quaternion q) { }

	[Address(RVA = "0x194B4C0", Offset = "0x194A6C0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000793")]
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	[Address(RVA = "0x1812620", Offset = "0x1811820", Length = "0x54")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000794")]
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	[Address(RVA = "0x194B630", Offset = "0x194A830", Length = "0x165")]
	[CallerCount(Count = 298)]
	[Token(Token = "0x6000791")]
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	[Address(RVA = "0x194B520", Offset = "0x194A720", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000790")]
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	[Address(RVA = "0x194AC60", Offset = "0x1949E60", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600079C")]
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	[Address(RVA = "0x194AEF0", Offset = "0x194A0F0", Length = "0x6B")]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoConstantRotationSwitch>d__132", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTFocusCamera+<DoSmoothRotationSwitch>d__133", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Polytoria.Datamodel.DynamicInstance", Member = "UpdateClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Prediction", Member = "CorrectHistory", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", "T", "T", typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "SmoothFollowPhysicsCopy", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.RigidbodyState", Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.RigidbodyState", "Mirror.RigidbodyState", typeof(float)}, ReturnType = "Mirror.RigidbodyState")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	[Token(Token = "0x6000783")]
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x194AE80", Offset = "0x194A080", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A7")]
	private static void Slerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x194AE10", Offset = "0x194A010", Length = "0x6B")]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "RotateTowards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Polytoria.Lua.LuaQuaternion", Member = "SlerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Mirror.TransformSnapshot", Member = "Interpolate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.TransformSnapshot", "Mirror.TransformSnapshot", typeof(double)}, ReturnType = "Mirror.TransformSnapshot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
	[Token(Token = "0x6000784")]
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[Address(RVA = "0x194ADA0", Offset = "0x1949FA0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A8")]
	private static void SlerpUnclamped_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret) { }

	[Address(RVA = "0x194AF60", Offset = "0x194A160", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600079B")]
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	[Address(RVA = "0x194B240", Offset = "0x194A440", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2A960")]
	[Token(Token = "0x60007A2")]
	public virtual string ToString() { }

	[Address(RVA = "0x194AFC0", Offset = "0x194A1C0", Length = "0x279")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A3")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


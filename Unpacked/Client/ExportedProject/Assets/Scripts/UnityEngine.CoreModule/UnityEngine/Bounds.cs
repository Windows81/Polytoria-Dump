namespace UnityEngine;

[NativeClass("AABB")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000092")]
public struct Bounds : IEquatable<Bounds>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001BC")]
	private Vector3 m_Center; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[NativeName("m_Extent")]
	[Token(Token = "0x40001BD")]
	private Vector3 m_Extents; //Field offset: 0xC

	[Token(Token = "0x17000066")]
	public Vector3 center
	{
		[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000289")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028A")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000068")]
	public Vector3 extents
	{
		[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028D")]
		 get { } //Length: 19
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600028E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700006A")]
	public Vector3 max
	{
		[Address(RVA = "0x191FAB0", Offset = "0x191ECB0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000291")]
		 get { } //Length: 63
		[Address(RVA = "0x191FCD0", Offset = "0x191EED0", Length = "0x9A")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000292")]
		 set { } //Length: 154
	}

	[Token(Token = "0x17000069")]
	public Vector3 min
	{
		[Address(RVA = "0x191FAF0", Offset = "0x191ECF0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600028F")]
		 get { } //Length: 63
		[Address(RVA = "0x191FD70", Offset = "0x191EF70", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000290")]
		 set { } //Length: 144
	}

	[Token(Token = "0x17000067")]
	public Vector3 size
	{
		[Address(RVA = "0x191FB30", Offset = "0x191ED30", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600028B")]
		 get { } //Length: 55
		[Address(RVA = "0x191FE00", Offset = "0x191F000", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600028C")]
		 set { } //Length: 56
	}

	[Address(RVA = "0x191FA60", Offset = "0x191EC60", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000285")]
	public Bounds(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x191F1B0", Offset = "0x191E3B0", Length = "0x5D")]
	[CalledBy(Type = "Polytoria.Lua.LuaBounds", Member = "ClosestPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "BoundsCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkConnectionToClient", typeof(Vector3), typeof(float), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("BoundsScripting::ClosestPoint", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x60002A2")]
	public Vector3 ClosestPoint(Vector3 point) { }

	[Address(RVA = "0x191F150", Offset = "0x191E350", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A6")]
	private static void ClosestPoint_Injected(ref Bounds _unity_self, in Vector3 point, out Vector3 ret) { }

	[Address(RVA = "0x191F260", Offset = "0x191E460", Length = "0x42")]
	[CalledBy(Type = "Polytoria.Lua.LuaBounds", Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("IsInside", IsThreadSafe = True)]
	[Token(Token = "0x600029F")]
	public bool Contains(Vector3 point) { }

	[Address(RVA = "0x191F210", Offset = "0x191E410", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A3")]
	private static bool Contains_Injected(ref Bounds _unity_self, in Vector3 point) { }

	[Address(RVA = "0x3FFF50", Offset = "0x3FF150", Length = "0x599")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "UpdateBounds3D", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "GetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.BoundsCalculationMethod"}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "GroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorThumbnailGenerator", Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = "GLTFast.GameObjectBoundsInstantiator", Member = "CalculateBounds", ReturnType = "System.Nullable`1<Bounds>")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 11)]
	[Calls(Type = "Mirror.NetworkBehaviour", Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = "Mirror.NetworkServer", Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = "Mirror.NetworkBehaviour", Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = "Mirror.NetworkBehaviour", Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", "System.Int32Enum&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028B010")]
	[Calls(Type = "Mirror.NetworkBehaviour", Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000297")]
	public void Encapsulate(Bounds bounds) { }

	[Address(RVA = "0x3FFE50", Offset = "0x3FF050", Length = "0xF3")]
	[CalledBy(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000296")]
	public void Encapsulate(Vector3 point) { }

	[Address(RVA = "0x191F340", Offset = "0x191E540", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000287")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x191F2B0", Offset = "0x191E4B0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000288")]
	public override bool Equals(Bounds other) { }

	[Address(RVA = "0x191F4C0", Offset = "0x191E6C0", Length = "0x40")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000298")]
	public void Expand(float amount) { }

	[Address(RVA = "0x191F460", Offset = "0x191E660", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000299")]
	public void Expand(Vector3 amount) { }

	[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
	[CallerCount(Count = 34)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000289")]
	public Vector3 get_center() { }

	[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028D")]
	public Vector3 get_extents() { }

	[Address(RVA = "0x191FAB0", Offset = "0x191ECB0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000291")]
	public Vector3 get_max() { }

	[Address(RVA = "0x191FAF0", Offset = "0x191ECF0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600028F")]
	public Vector3 get_min() { }

	[Address(RVA = "0x191FB30", Offset = "0x191ED30", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600028B")]
	public Vector3 get_size() { }

	[Address(RVA = "0x191F500", Offset = "0x191E700", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6000286")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x191F690", Offset = "0x191E890", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029B")]
	public bool IntersectRay(Ray ray) { }

	[Address(RVA = "0x191F700", Offset = "0x191E900", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029C")]
	public bool IntersectRay(Ray ray, out float distance) { }

	[Address(RVA = "0x191F630", Offset = "0x191E830", Length = "0x52")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "PerformPick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "RLD.BoxMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Quaternion), "RLD.BoxEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Lua.LuaBounds", Member = "IntersectRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(Vector3), typeof(Vector3)}, ReturnType = "System.Tuple`2<Boolean, Single>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("IntersectRayAABB", IsThreadSafe = True)]
	[Token(Token = "0x60002A1")]
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	[Address(RVA = "0x191F5D0", Offset = "0x191E7D0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A5")]
	private static bool IntersectRayAABB_Injected(in Ray ray, in Bounds bounds, out float dist) { }

	[Address(RVA = "0x191F770", Offset = "0x191E970", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600029A")]
	public bool Intersects(Bounds bounds) { }

	[Address(RVA = "0x191FB70", Offset = "0x191ED70", Length = "0x99")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000293")]
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	[Address(RVA = "0x191FC10", Offset = "0x191EE10", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000294")]
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028A")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600028E")]
	public void set_extents(Vector3 value) { }

	[Address(RVA = "0x191FCD0", Offset = "0x191EED0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000292")]
	public void set_max(Vector3 value) { }

	[Address(RVA = "0x191FD70", Offset = "0x191EF70", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000290")]
	public void set_min(Vector3 value) { }

	[Address(RVA = "0x191FE00", Offset = "0x191F000", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600028C")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x191F830", Offset = "0x191EA30", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000295")]
	public void SetMinMax(Vector3 min, Vector3 max) { }

	[Address(RVA = "0x191F900", Offset = "0x191EB00", Length = "0x42")]
	[CalledBy(Type = "Polytoria.Lua.LuaBounds", Member = "SqrDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x60002A0")]
	public float SqrDistance(Vector3 point) { }

	[Address(RVA = "0x191F8B0", Offset = "0x191EAB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002A4")]
	private static float SqrDistance_Injected(ref Bounds _unity_self, in Vector3 point) { }

	[Address(RVA = "0x191FA50", Offset = "0x191EC50", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E29B90")]
	[Token(Token = "0x600029D")]
	public virtual string ToString() { }

	[Address(RVA = "0x191F950", Offset = "0x191EB50", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D86A0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600029E")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}


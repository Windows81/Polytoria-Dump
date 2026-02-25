namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GeometryUtilityScripting", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000094")]
public sealed class GeometryUtility
{

	[Address(RVA = "0x192A270", Offset = "0x1929470", Length = "0x1DC")]
	[CalledBy(Type = "GLTFast.GameObjectBoundsInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectBoundsInstantiator", Member = "GetTransformedBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(Matrix4x4)}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B3")]
	public static Bounds CalculateBounds(Vector3[] positions, Matrix4x4 transform) { }

	[Address(RVA = "0x192A450", Offset = "0x1929650", Length = "0x130")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "UnityEngine.Plane[]")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GeometryUtility), Member = "Internal_ExtractPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B1")]
	public static Plane[] CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix) { }

	[Address(RVA = "0x192A590", Offset = "0x1929790", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GeometryUtility), Member = "Internal_ExtractPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane[]), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60002B2")]
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	[Address(RVA = "0x192A6F0", Offset = "0x19298F0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("CalculateBounds")]
	[Token(Token = "0x60002B6")]
	private static Bounds Internal_CalculateBounds(Vector3[] positions, Matrix4x4 transform) { }

	[Address(RVA = "0x192A690", Offset = "0x1929890", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B9")]
	private static void Internal_CalculateBounds_Injected(ref ManagedSpanWrapper positions, in Matrix4x4 transform, out Bounds ret) { }

	[Address(RVA = "0x192A830", Offset = "0x1929A30", Length = "0xDC")]
	[CalledBy(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Plane[]))]
	[CalledBy(Type = typeof(GeometryUtility), Member = "CalculateFrustumPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Plane[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191ACE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("ExtractPlanes")]
	[Token(Token = "0x60002B5")]
	private static void Internal_ExtractPlanes(out Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	[Address(RVA = "0x192A7E0", Offset = "0x19299E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B8")]
	private static void Internal_ExtractPlanes_Injected(out BlittableArrayWrapper planes, in Matrix4x4 worldToProjectionMatrix) { }

	[Address(RVA = "0x192A960", Offset = "0x1929B60", Length = "0xCB")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.AABB"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB", "UnityEngine.Plane[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.CameraEx", Member = "GetVisibleObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.CameraViewVolume", "System.Collections.Generic.List`1<GameObject>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B4")]
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	[Address(RVA = "0x192A910", Offset = "0x1929B10", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002B7")]
	private static bool TestPlanesAABB_Injected(ref ManagedSpanWrapper planes, in Bounds bounds) { }

}


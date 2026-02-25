namespace UnityEngine;

[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200002C")]
public class SphereCollider : Collider
{

	[Token(Token = "0x17000081")]
	public Vector3 center
	{
		[Address(RVA = "0x19F3DB0", Offset = "0x19F2FB0", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600020F")]
		 get { } //Length: 144
		[Address(RVA = "0x19F3F60", Offset = "0x19F3160", Length = "0x85")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000210")]
		 set { } //Length: 133
	}

	[Token(Token = "0x17000082")]
	public float radius
	{
		[Address(RVA = "0x19F3E90", Offset = "0x19F3090", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000211")]
		 get { } //Length: 118
		[Address(RVA = "0x19F4040", Offset = "0x19F3240", Length = "0x86")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000212")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x19F3DB0", Offset = "0x19F2FB0", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020F")]
	public Vector3 get_center() { }

	[Address(RVA = "0x19F3D60", Offset = "0x19F2F60", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000213")]
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19F3E90", Offset = "0x19F3090", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000211")]
	public float get_radius() { }

	[Address(RVA = "0x19F3E50", Offset = "0x19F3050", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000215")]
	private static float get_radius_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19F3F60", Offset = "0x19F3160", Length = "0x85")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000210")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x19F3F10", Offset = "0x19F3110", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000214")]
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19F4040", Offset = "0x19F3240", Length = "0x86")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveSphereColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveAllColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000212")]
	public void set_radius(float value) { }

	[Address(RVA = "0x19F3FF0", Offset = "0x19F31F0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000216")]
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}


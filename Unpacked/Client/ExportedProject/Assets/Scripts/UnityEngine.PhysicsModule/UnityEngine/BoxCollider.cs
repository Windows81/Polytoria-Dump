namespace UnityEngine;

[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200000D")]
public class BoxCollider : Collider
{

	[Token(Token = "0x17000009")]
	public Vector3 center
	{
		[Address(RVA = "0x19E3440", Offset = "0x19E2640", Length = "0x90")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000C")]
		 get { } //Length: 144
		[Address(RVA = "0x19E3620", Offset = "0x19E2820", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.HistoryCollider", Member = "ProjectBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfBoundsAsset", Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GameObjectBoundsInstantiator"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000D")]
		 set { } //Length: 133
	}

	[Token(Token = "0x1700000A")]
	public Vector3 size
	{
		[Address(RVA = "0x19E3530", Offset = "0x19E2730", Length = "0x90")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "IsGrounded", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoFootstep", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "IsGrounded", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000E")]
		 get { } //Length: 144
		[Address(RVA = "0x19E3700", Offset = "0x19E2900", Length = "0x85")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "UpdateColliders", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.HistoryCollider", Member = "ProjectBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.LagCompensator", Member = "RaycastCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkConnectionToClient", typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GltfBoundsAsset", Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GameObjectBoundsInstantiator"}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000F")]
		 set { } //Length: 133
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public BoxCollider() { }

	[Address(RVA = "0x19E3440", Offset = "0x19E2640", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public Vector3 get_center() { }

	[Address(RVA = "0x19E33F0", Offset = "0x19E25F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	private static void get_center_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E3530", Offset = "0x19E2730", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "DoFootstep", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "IsGrounded", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public Vector3 get_size() { }

	[Address(RVA = "0x19E34E0", Offset = "0x19E26E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	private static void get_size_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x19E3620", Offset = "0x19E2820", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "ProjectBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset", Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GameObjectBoundsInstantiator"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x19E35D0", Offset = "0x19E27D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000012")]
	private static void set_center_Injected(IntPtr _unity_self, in Vector3 value) { }

	[Address(RVA = "0x19E3700", Offset = "0x19E2900", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ColliderUpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "UpdateColliders", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Tool", Member = "RecalculateBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "ProjectBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "RaycastCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkConnectionToClient", typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveBoxColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfBoundsAsset", Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.GameObjectBoundsInstantiator"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x19E36B0", Offset = "0x19E28B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	private static void set_size_Injected(IntPtr _unity_self, in Vector3 value) { }

}


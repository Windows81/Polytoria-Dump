namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[NativeHeader("Modules/Physics/MeshCollider.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x200001D")]
public class MeshCollider : Collider
{

	[Token(Token = "0x17000057")]
	public bool convex
	{
		[Address(RVA = "0x19EBE70", Offset = "0x19EB070", Length = "0x76")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017F")]
		 get { } //Length: 118
		[Address(RVA = "0x19EC020", Offset = "0x19EB220", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "UpdateColliders", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000180")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000056")]
	public Mesh sharedMesh
	{
		[Address(RVA = "0x19EBF30", Offset = "0x19EB130", Length = "0x90")]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MeshUtilities", Member = "GetColliderMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collider)}, ReturnType = typeof(Mesh))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017D")]
		 get { } //Length: 144
		[Address(RVA = "0x19EC100", Offset = "0x19EB300", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600017E")]
		 set { } //Length: 186
	}

	[Address(RVA = "0x19EBE70", Offset = "0x19EB070", Length = "0x76")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017F")]
	public bool get_convex() { }

	[Address(RVA = "0x19EBE30", Offset = "0x19EB030", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000183")]
	private static bool get_convex_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19EBF30", Offset = "0x19EB130", Length = "0x90")]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MeshUtilities", Member = "GetColliderMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collider)}, ReturnType = typeof(Mesh))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017D")]
	public Mesh get_sharedMesh() { }

	[Address(RVA = "0x19EBEF0", Offset = "0x19EB0F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000181")]
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19EC020", Offset = "0x19EB220", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "UpdateColliders", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessVolume", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000180")]
	public void set_convex(bool value) { }

	[Address(RVA = "0x19EBFD0", Offset = "0x19EB1D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000184")]
	private static void set_convex_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x19EC100", Offset = "0x19EB300", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Datamodel.Part", Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.PartShape"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictionUtils", Member = "MoveMeshColliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600017E")]
	public void set_sharedMesh(Mesh value) { }

	[Address(RVA = "0x19EC0B0", Offset = "0x19EB2B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000182")]
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

}


namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Volume", 1001)]
[ExecuteAlways]
[Token(Token = "0x2000079")]
public sealed class PostProcessVolume : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000227")]
	public PostProcessProfile sharedProfile; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000228")]
	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	public bool isGlobal; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Min(0)]
	[Token(Token = "0x4000229")]
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	public float blendDistance; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Range(0, 1)]
	[Token(Token = "0x400022A")]
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	public float weight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400022B")]
	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	public float priority; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022C")]
	private int m_PreviousLayer; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400022D")]
	private float m_PreviousPriority; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400022E")]
	private List<Collider> m_TempColliders; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400022F")]
	private PostProcessProfile m_InternalProfile; //Field offset: 0x48

	[Token(Token = "0x17000026")]
	internal int previousLayer
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public PostProcessProfile profile
	{
		[Address(RVA = "0x184EA70", Offset = "0x184DC70", Length = "0x281")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(PostProcessEffectSettings[])}, ReturnType = typeof(PostProcessVolume))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60001B9")]
		 get { } //Length: 641
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000025")]
	internal PostProcessProfile profileRef
	{
		[Address(RVA = "0x184E9F0", Offset = "0x184DBF0", Length = "0x71")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessVolume>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60001BB")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x184E9E0", Offset = "0x184DBE0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001C2")]
	public PostProcessVolume() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	internal int get_previousLayer() { }

	[Address(RVA = "0x184EA70", Offset = "0x184DC70", Length = "0x281")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(PostProcessEffectSettings[])}, ReturnType = typeof(PostProcessVolume))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001B9")]
	public PostProcessProfile get_profile() { }

	[Address(RVA = "0x184E9F0", Offset = "0x184DBF0", Length = "0x71")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer), typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.PostProcessing.PostProcessVolume>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001BB")]
	internal PostProcessProfile get_profileRef() { }

	[Address(RVA = "0x184DF70", Offset = "0x184D170", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60001BC")]
	public bool HasInstantiatedProfile() { }

	[Address(RVA = "0x184DFC0", Offset = "0x184D1C0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance", ReturnType = typeof(PostProcessManager))]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001BF")]
	private void OnDisable() { }

	[Address(RVA = "0x184E030", Offset = "0x184D230", Length = "0x805")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshCollider), Member = "get_convex", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Gizmos), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawWireMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SphereCollider), Member = "get_center", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius", ReturnType = typeof(float))]
	[Calls(Type = typeof(Gizmos), Member = "DrawSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawWireSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxCollider), Member = "get_center", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxCollider), Member = "get_size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Gizmos), Member = "DrawCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Gizmos), Member = "DrawWireCube", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshCollider), Member = "set_convex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Collider), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Gizmos), Member = "set_matrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60001C1")]
	private void OnDrawGizmos() { }

	[Address(RVA = "0x184E840", Offset = "0x184DA40", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance", ReturnType = typeof(PostProcessManager))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BE")]
	private void OnEnable() { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BA")]
	public void set_profile(PostProcessProfile value) { }

	[Address(RVA = "0x184E920", Offset = "0x184DB20", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance", ReturnType = typeof(PostProcessManager))]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessManager), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessVolume), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001C0")]
	private void Update() { }

}


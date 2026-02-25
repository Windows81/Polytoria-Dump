namespace GLTFast;

[Token(Token = "0x200000B")]
public class GameObjectBoundsInstantiator : GameObjectInstantiator
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000020")]
	private Dictionary<UInt32, Bounds> m_NodeBounds; //Field offset: 0x60

	[Address(RVA = "0x105CF00", Offset = "0x105C100", Length = "0xBD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InstantiationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public GameObjectBoundsInstantiator(IGltfReadable gltf, Transform parent, ICodeLogger logger = null, InstantiationSettings settings = null) { }

	[Address(RVA = "0x105C490", Offset = "0x105B690", Length = "0x5D8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.Bounds>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Matrix4x4)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(GameObjectInstantiator), Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), typeof(MeshResult), typeof(UInt32[]), typeof(System.Nullable`1<System.UInt32>), typeof(Single[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000018")]
	public virtual void AddPrimitive(uint nodeIndex, string meshName, MeshResult meshResult, UInt32[] joints = null, Nullable<UInt32> rootJoint = null, Single[] morphTargetWeights = null, int primitiveNumeration = 0) { }

	[Address(RVA = "0x105CA70", Offset = "0x105BC70", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObjectInstantiator), Member = "BeginScene", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000017")]
	public virtual void BeginScene(string name, UInt32[] rootNodeIndices) { }

	[Address(RVA = "0x105CB00", Offset = "0x105BD00", Length = "0x266")]
	[CalledBy(Type = typeof(GltfBoundsAsset), Member = "SetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectBoundsInstantiator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000019")]
	public Nullable<Bounds> CalculateBounds() { }

	[Address(RVA = "0x105CD70", Offset = "0x105BF70", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(GeometryUtility), Member = "CalculateBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(Matrix4x4)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600001A")]
	private static Bounds GetTransformedBounds(Bounds b, Matrix4x4 transform) { }

}


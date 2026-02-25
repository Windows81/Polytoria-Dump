namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
[Token(Token = "0x20000DB")]
public class SkinnedMeshRenderer : Renderer
{

	[Token(Token = "0x170000DC")]
	public Transform[] bones
	{
		[Address(RVA = "0x193F080", Offset = "0x193E280", Length = "0x85")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004C2")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170000DB")]
	public Transform rootBone
	{
		[Address(RVA = "0x193F160", Offset = "0x193E360", Length = "0xBA")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004C1")]
		 set { } //Length: 186
	}

	[NativeProperty("Mesh")]
	[Token(Token = "0x170000DD")]
	public Mesh sharedMesh
	{
		[Address(RVA = "0x193EF90", Offset = "0x193E190", Length = "0x90")]
		[CalledBy(Type = "RLD.GameObjectEx", Member = "GetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Mesh))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004C3")]
		 get { } //Length: 144
		[Address(RVA = "0x193F270", Offset = "0x193E470", Length = "0xBA")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004C4")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170000DA")]
	public bool updateWhenOffscreen
	{
		[Address(RVA = "0x193F380", Offset = "0x193E580", Length = "0x86")]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004C0")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x193EF90", Offset = "0x193E190", Length = "0x90")]
	[CalledBy(Type = "RLD.GameObjectEx", Member = "GetMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(Mesh))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C3")]
	public Mesh get_sharedMesh() { }

	[Address(RVA = "0x193EF50", Offset = "0x193E150", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C9")]
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x193F080", Offset = "0x193E280", Length = "0x85")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C2")]
	public void set_bones(Transform[] value) { }

	[Address(RVA = "0x193F030", Offset = "0x193E230", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C8")]
	private static void set_bones_Injected(IntPtr _unity_self, Transform[] value) { }

	[Address(RVA = "0x193F160", Offset = "0x193E360", Length = "0xBA")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C1")]
	public void set_rootBone(Transform value) { }

	[Address(RVA = "0x193F110", Offset = "0x193E310", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C7")]
	private static void set_rootBone_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x193F270", Offset = "0x193E470", Length = "0xBA")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C4")]
	public void set_sharedMesh(Mesh value) { }

	[Address(RVA = "0x193F220", Offset = "0x193E420", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CA")]
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x193F380", Offset = "0x193E580", Length = "0x86")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C0")]
	public void set_updateWhenOffscreen(bool value) { }

	[Address(RVA = "0x193F330", Offset = "0x193E530", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C6")]
	private static void set_updateWhenOffscreen_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x193EEB0", Offset = "0x193E0B0", Length = "0x93")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C5")]
	public void SetBlendShapeWeight(int index, float value) { }

	[Address(RVA = "0x193EE60", Offset = "0x193E060", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004CB")]
	private static void SetBlendShapeWeight_Injected(IntPtr _unity_self, int index, float value) { }

}


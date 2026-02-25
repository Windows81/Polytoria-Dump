namespace UnityEngine;

[NativeHeader("Runtime/Interfaces/IRaycast.h")]
[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Physics/RaycastHit.h")]
[Token(Token = "0x2000028")]
[UsedByNativeCode]
public struct RaycastHit
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("point")]
	[Token(Token = "0x4000087")]
	internal Vector3 m_Point; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[NativeName("normal")]
	[Token(Token = "0x4000088")]
	internal Vector3 m_Normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[NativeName("faceID")]
	[Token(Token = "0x4000089")]
	internal uint m_FaceID; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("distance")]
	[Token(Token = "0x400008A")]
	internal float m_Distance; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("uv")]
	[Token(Token = "0x400008B")]
	internal Vector2 m_UV; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NativeName("collider")]
	[Token(Token = "0x400008C")]
	internal int m_Collider; //Field offset: 0x28

	[Token(Token = "0x1700006A")]
	public Collider collider
	{
		[Address(RVA = "0x19F1910", Offset = "0x19F0B10", Length = "0x9E")]
		[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = "UnityEngine.UIElements.WorldSpaceInput+PickResult")]
		[CalledBy(Type = "RLD.GameObjectRayHit", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
		[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "Polytoria.Datamodel.RayResult[]")]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RaycastHit), Member = "get_transform", ReturnType = typeof(Transform))]
		[CalledBy(Type = typeof(RaycastHit), Member = "get_rigidbody", ReturnType = typeof(Rigidbody))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[Token(Token = "0x60001BB")]
		 get { } //Length: 158
	}

	[Token(Token = "0x1700006D")]
	public float distance
	{
		[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
		[CallerCount(Count = 66)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BE")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006C")]
	public Vector3 normal
	{
		[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700006B")]
	public Vector3 point
	{
		[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700006F")]
	public Rigidbody rigidbody
	{
		[Address(RVA = "0x19F19B0", Offset = "0x19F0BB0", Length = "0x103")]
		[CalledBy(Type = typeof(RaycastHit), Member = "get_transform", ReturnType = typeof(Transform))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 259
	}

	[Token(Token = "0x1700006E")]
	public Transform transform
	{
		[Address(RVA = "0x19F1AC0", Offset = "0x19F0CC0", Length = "0xDF")]
		[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RaycastHit), Member = "get_rigidbody", ReturnType = typeof(Rigidbody))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 223
	}

	[Address(RVA = "0x19F1910", Offset = "0x19F0B10", Length = "0x9E")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = "UnityEngine.UIElements.WorldSpaceInput+PickResult")]
	[CalledBy(Type = "RLD.GameObjectRayHit", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "Polytoria.Datamodel.RayResult[]")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.InputService", Member = "ViewportPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "System.Collections.Generic.List`1<Instance>"}, ReturnType = "System.Nullable`1<RayResult>")]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RaycastHit), Member = "get_transform", ReturnType = typeof(Transform))]
	[CalledBy(Type = typeof(RaycastHit), Member = "get_rigidbody", ReturnType = typeof(Rigidbody))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "FindObjectFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[Token(Token = "0x60001BB")]
	public Collider get_collider() { }

	[Address(RVA = "0x2C0B00", Offset = "0x2BFD00", Length = "0x8")]
	[CallerCount(Count = 66)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BE")]
	public float get_distance() { }

	[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BD")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
	[CallerCount(Count = 34)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BC")]
	public Vector3 get_point() { }

	[Address(RVA = "0x19F19B0", Offset = "0x19F0BB0", Length = "0x103")]
	[CalledBy(Type = typeof(RaycastHit), Member = "get_transform", ReturnType = typeof(Transform))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C0")]
	public Rigidbody get_rigidbody() { }

	[Address(RVA = "0x19F1AC0", Offset = "0x19F0CC0", Length = "0xDF")]
	[CalledBy(Type = "namudev.PropertyGridSelector", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RaycastHit), Member = "get_rigidbody", ReturnType = typeof(Rigidbody))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001BF")]
	public Transform get_transform() { }

}


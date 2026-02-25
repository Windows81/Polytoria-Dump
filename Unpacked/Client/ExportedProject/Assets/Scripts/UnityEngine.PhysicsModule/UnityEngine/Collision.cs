namespace UnityEngine;

[Token(Token = "0x2000003")]
public class Collision
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000007")]
	private ContactPairHeader m_Header; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000008")]
	private ContactPair m_Pair; //Field offset: 0x38
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000009")]
	private bool m_Flipped; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400000A")]
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x68

	[Token(Token = "0x17000004")]
	public Component body
	{
		[Address(RVA = "0x19E5F30", Offset = "0x19E5130", Length = "0x7C")]
		[CalledBy(Type = typeof(Collision), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		 get { } //Length: 124
	}

	[Token(Token = "0x17000005")]
	public Collider collider
	{
		[Address(RVA = "0x19E5FB0", Offset = "0x19E51B0", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000005")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000008")]
	public ContactPoint[] contacts
	{
		[Address(RVA = "0x19E6040", Offset = "0x19E5240", Length = "0x6A")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContactPair), Member = "ExtractContactsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPoint[]), typeof(bool)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000008")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000007")]
	internal bool Flipped
	{
		[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000006")]
	public GameObject gameObject
	{
		[Address(RVA = "0x19E60B0", Offset = "0x19E52B0", Length = "0x10B")]
		[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Collision), Member = "get_body", ReturnType = typeof(Component))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000006")]
		 get { } //Length: 267
	}

	[Address(RVA = "0x19E5ED0", Offset = "0x19E50D0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public Collision() { }

	[Address(RVA = "0x19E5C60", Offset = "0x19E4E60", Length = "0x260")]
	[CalledBy(Type = typeof(Physics), Member = "GetCollisionToReport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(Collision))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ContactPair), Member = "GetContactPoint_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000A")]
	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[Address(RVA = "0x19E5F30", Offset = "0x19E5130", Length = "0x7C")]
	[CalledBy(Type = typeof(Collision), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public Component get_body() { }

	[Address(RVA = "0x19E5FB0", Offset = "0x19E51B0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public Collider get_collider() { }

	[Address(RVA = "0x19E6040", Offset = "0x19E5240", Length = "0x6A")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "OnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ContactPair), Member = "ExtractContactsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPoint[]), typeof(bool)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000008")]
	public ContactPoint[] get_contacts() { }

	[Address(RVA = "0x19E60B0", Offset = "0x19E52B0", Length = "0x10B")]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Instance", Member = "OnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionStay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Seat", Member = "OnCollisionEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Collision)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Collision), Member = "get_body", ReturnType = typeof(Component))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x19E5C00", Offset = "0x19E4E00", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600000B")]
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	internal void set_Flipped(bool value) { }

}


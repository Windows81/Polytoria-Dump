namespace UnityEngine;

[Token(Token = "0x2000002")]
public struct ContactPoint
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	internal Vector3 m_Point; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000002")]
	internal Vector3 m_Normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	internal Vector3 m_Impulse; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000004")]
	internal int m_ThisColliderInstanceID; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000005")]
	internal int m_OtherColliderInstanceID; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000006")]
	internal float m_Separation; //Field offset: 0x2C

	[Token(Token = "0x17000002")]
	public Vector3 normal
	{
		[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
		[CallerCount(Count = 19)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000002")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000003")]
	public Collider otherCollider
	{
		[Address(RVA = "0x19E9B90", Offset = "0x19E8D90", Length = "0x54")]
		[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "ResolveStepUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(ContactPoint), typeof(ContactPoint)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "ResolveStepUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(ContactPoint), typeof(ContactPoint)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000003")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000001")]
	public Vector3 point
	{
		[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
		[CallerCount(Count = 34)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000001")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x191F130", Offset = "0x191E330", Length = "0x13")]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x19E9B90", Offset = "0x19E8D90", Length = "0x54")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "ResolveStepUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(ContactPoint), typeof(ContactPoint)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "ResolveStepUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(ContactPoint), typeof(ContactPoint)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public Collider get_otherCollider() { }

	[Address(RVA = "0x191F110", Offset = "0x191E310", Length = "0x12")]
	[CallerCount(Count = 34)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	public Vector3 get_point() { }

}


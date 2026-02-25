namespace UnityEngine;

[IsReadOnly]
[Token(Token = "0x2000020")]
[UsedByNativeCode]
public struct ContactPair
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000056")]
	internal readonly int m_ColliderID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000057")]
	internal readonly int m_OtherColliderID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000058")]
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000059")]
	internal readonly uint m_NbPoints; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400005A")]
	internal readonly CollisionPairFlags m_Flags; //Field offset: 0x14
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x400005B")]
	internal readonly CollisionPairEventFlags m_Events; //Field offset: 0x16
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400005C")]
	internal readonly Vector3 m_ImpulseSum; //Field offset: 0x18

	[Token(Token = "0x1700005B")]
	public Collider collider
	{
		[Address(RVA = "0x19E9A80", Offset = "0x19E8C80", Length = "0x61")]
		[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600018A")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000060")]
	internal bool hasRemovedCollider
	{
		[Address(RVA = "0x19E9780", Offset = "0x19E8980", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600018F")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x1700005D")]
	public bool isCollisionEnter
	{
		[Address(RVA = "0x19E9AF0", Offset = "0x19E8CF0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700005E")]
	public bool isCollisionExit
	{
		[Address(RVA = "0x19E9B00", Offset = "0x19E8D00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700005F")]
	public bool isCollisionStay
	{
		[Address(RVA = "0x19E9B10", Offset = "0x19E8D10", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700005C")]
	public Collider otherCollider
	{
		[Address(RVA = "0x19E9B20", Offset = "0x19E8D20", Length = "0x63")]
		[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600018B")]
		 get { } //Length: 99
	}

	[Address(RVA = "0x19E9800", Offset = "0x19E8A00", Length = "0x1EB")]
	[CalledBy(Type = typeof(Collision), Member = "get_contacts", ReturnType = typeof(ContactPoint[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ContactPair), Member = "GetContactPoint_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000190")]
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	[Address(RVA = "0x19E9A80", Offset = "0x19E8C80", Length = "0x61")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600018A")]
	public Collider get_collider() { }

	[Address(RVA = "0x19E9780", Offset = "0x19E8980", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600018F")]
	internal bool get_hasRemovedCollider() { }

	[Address(RVA = "0x19E9AF0", Offset = "0x19E8CF0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018C")]
	public bool get_isCollisionEnter() { }

	[Address(RVA = "0x19E9B00", Offset = "0x19E8D00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018D")]
	public bool get_isCollisionExit() { }

	[Address(RVA = "0x19E9B10", Offset = "0x19E8D10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018E")]
	public bool get_isCollisionStay() { }

	[Address(RVA = "0x19E9B20", Offset = "0x19E8D20", Length = "0x63")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetColliderByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Collider))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600018B")]
	public Collider get_otherCollider() { }

	[Address(RVA = "0x19E9A70", Offset = "0x19E8C70", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactPair), Member = "GetContactPoint_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint*))]
	[Token(Token = "0x6000191")]
	public ContactPairPoint GetContactPoint(int index) { }

	[Address(RVA = "0x19E99F0", Offset = "0x19E8BF0", Length = "0x77")]
	[CalledBy(Type = typeof(Collision), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPairHeader&), typeof(ContactPair&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContactPair), Member = "ExtractContactsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContactPoint[]), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ContactPair), Member = "GetContactPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPairPoint&))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000192")]
	internal ContactPairPoint* GetContactPoint_Internal(int index) { }

}


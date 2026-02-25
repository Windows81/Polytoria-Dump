namespace UnityEngine;

[IsReadOnly]
[Token(Token = "0x200001F")]
[UsedByNativeCode]
public struct ContactPairHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000050")]
	internal readonly int m_BodyID; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000051")]
	internal readonly int m_OtherBodyID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000052")]
	internal readonly IntPtr m_StartPtr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000053")]
	internal readonly uint m_NbPairs; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000054")]
	internal readonly CollisionPairHeaderFlags m_Flags; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000055")]
	internal readonly Vector3 m_RelativeVelocity; //Field offset: 0x18

	[Token(Token = "0x17000058")]
	public Component body
	{
		[Address(RVA = "0x19E9720", Offset = "0x19E8920", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000185")]
		 get { } //Length: 83
	}

	[Token(Token = "0x1700005A")]
	internal bool hasRemovedBody
	{
		[Address(RVA = "0x19E9780", Offset = "0x19E8980", Length = "0x14")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000187")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x17000059")]
	public Component otherBody
	{
		[Address(RVA = "0x19E97A0", Offset = "0x19E89A0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000186")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x19E9720", Offset = "0x19E8920", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000185")]
	public Component get_body() { }

	[Address(RVA = "0x19E9780", Offset = "0x19E8980", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000187")]
	internal bool get_hasRemovedBody() { }

	[Address(RVA = "0x19E97A0", Offset = "0x19E89A0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Physics), Member = "GetBodyByInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityId)}, ReturnType = typeof(Component))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000186")]
	public Component get_otherBody() { }

	[Address(RVA = "0x19E9710", Offset = "0x19E8910", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContactPairHeader), Member = "GetContactPair_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPair*))]
	[Token(Token = "0x6000188")]
	public ContactPair GetContactPair(int index) { }

	[Address(RVA = "0x19E9690", Offset = "0x19E8890", Length = "0x77")]
	[CalledBy(Type = typeof(Physics), Member = "ReportContacts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1+ReadOnly<UnityEngine.ContactPairHeader>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContactPairHeader), Member = "GetContactPair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ContactPair&))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000189")]
	internal ContactPair* GetContactPair_Internal(int index) { }

}


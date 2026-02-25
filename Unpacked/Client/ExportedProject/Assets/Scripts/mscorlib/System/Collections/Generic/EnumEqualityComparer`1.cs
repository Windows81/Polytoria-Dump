namespace System.Collections.Generic;

[Token(Token = "0x2000603")]
internal class EnumEqualityComparer : EqualityComparer<T>, ISerializable
{

	[Address(RVA = "0x963BC0", Offset = "0x962DC0", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C2A")]
	public EnumEqualityComparer`1() { }

	[Address(RVA = "0xAE13D0", Offset = "0xAE05D0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C2B")]
	protected EnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xAE1130", Offset = "0xAE0330", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JitHelpers), Member = "UnsafeEnumCast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C28")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xAE0F40", Offset = "0xAE0140", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C2D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAE12D0", Offset = "0xAE04D0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JitHelpers), Member = "UnsafeEnumCast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C29")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C2E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xAE1300", Offset = "0xAE0500", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C2C")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


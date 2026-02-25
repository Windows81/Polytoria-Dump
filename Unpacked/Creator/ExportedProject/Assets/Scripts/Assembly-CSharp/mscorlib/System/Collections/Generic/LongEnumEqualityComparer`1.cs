namespace System.Collections.Generic;

[Token(Token = "0x2000606")]
internal sealed class LongEnumEqualityComparer : EqualityComparer<T>, ISerializable
{

	[Address(RVA = "0xAF8470", Offset = "0xAF7670", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C39")]
	public LongEnumEqualityComparer`1() { }

	[Address(RVA = "0xE03560", Offset = "0xE02760", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C3A")]
	public LongEnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	[Address(RVA = "0xE03340", Offset = "0xE02540", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C35")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xE032F0", Offset = "0xE024F0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C37")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE03450", Offset = "0xE02650", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C36")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C38")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xE03500", Offset = "0xE02700", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C3B")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


namespace System;

[Token(Token = "0x2000168")]
public class MissingMemberException : MemberAccessException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000570")]
	protected string ClassName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000571")]
	protected string MemberName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000572")]
	protected Byte[] Signature; //Field offset: 0xA0

	[Token(Token = "0x1700010B")]
	public virtual string Message
	{
		[Address(RVA = "0x14BAB00", Offset = "0x14B9D00", Length = "0xF0")]
		[CalledBy(Type = typeof(MissingMethodException), Member = "get_Message", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Token(Token = "0x6000C4A")]
		 get { } //Length: 240
	}

	[Address(RVA = "0x14BA8D0", Offset = "0x14B9AD0", Length = "0x44")]
	[CalledBy(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C46")]
	public MissingMemberException() { }

	[Address(RVA = "0x14BA920", Offset = "0x14B9B20", Length = "0x1E")]
	[CalledBy(Type = typeof(LazyHelper), Member = "CreateViaDefaultConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MissingMethodException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
	[CalledBy(Type = typeof(LazyInitializer), Member = "EnsureInitializedCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C47")]
	public MissingMemberException(string message) { }

	[Address(RVA = "0x14BA940", Offset = "0x14B9B40", Length = "0x1BC")]
	[CalledBy(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C48")]
	protected MissingMemberException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x145DB20", Offset = "0x145CD20", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C4B")]
	internal static string FormatSignature(Byte[] signature) { }

	[Address(RVA = "0x14BAB00", Offset = "0x14B9D00", Length = "0xF0")]
	[CalledBy(Type = typeof(MissingMethodException), Member = "get_Message", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Token(Token = "0x6000C4A")]
	public virtual string get_Message() { }

	[Address(RVA = "0x14BA720", Offset = "0x14B9920", Length = "0x1AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000C49")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}


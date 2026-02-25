namespace System;

[Token(Token = "0x2000167")]
public class MissingFieldException : MissingMemberException, ISerializable
{

	[Token(Token = "0x1700010A")]
	public virtual string Message
	{
		[Address(RVA = "0x14BA560", Offset = "0x14B9760", Length = "0x1B7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Token(Token = "0x6000C45")]
		 get { } //Length: 439
	}

	[Address(RVA = "0x14BA460", Offset = "0x14B9660", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C41")]
	public MissingFieldException() { }

	[Address(RVA = "0x14BA540", Offset = "0x14B9740", Length = "0x1E")]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C42")]
	public MissingFieldException(string message) { }

	[Address(RVA = "0x14BA4B0", Offset = "0x14B96B0", Length = "0x88")]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000C43")]
	public MissingFieldException(string className, string fieldName) { }

	[Address(RVA = "0x14A4380", Offset = "0x14A3580", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C44")]
	protected MissingFieldException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14BA560", Offset = "0x14B9760", Length = "0x1B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Token(Token = "0x6000C45")]
	public virtual string get_Message() { }

}


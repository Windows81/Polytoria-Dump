namespace System;

[Token(Token = "0x20000D7")]
public class FieldAccessException : MemberAccessException
{

	[Address(RVA = "0x149A0C0", Offset = "0x14992C0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A6")]
	public FieldAccessException() { }

	[Address(RVA = "0x149A0A0", Offset = "0x14992A0", Length = "0x1E")]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemberAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A7")]
	public FieldAccessException(string message) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A8")]
	protected FieldAccessException(SerializationInfo info, StreamingContext context) { }

}


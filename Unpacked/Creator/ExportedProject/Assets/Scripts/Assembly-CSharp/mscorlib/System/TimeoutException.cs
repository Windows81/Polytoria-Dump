namespace System;

[Token(Token = "0x200013F")]
public class TimeoutException : SystemException
{

	[Address(RVA = "0x14C57A0", Offset = "0x14C49A0", Length = "0x81")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A3A")]
	public TimeoutException() { }

	[Address(RVA = "0x14C5830", Offset = "0x14C4A30", Length = "0x61")]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TimeSpan)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A3B")]
	public TimeoutException(string message) { }

	[Address(RVA = "0x14B40D0", Offset = "0x14B32D0", Length = "0x74")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A3C")]
	protected TimeoutException(SerializationInfo info, StreamingContext context) { }

}


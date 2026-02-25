namespace System;

[Token(Token = "0x200013E")]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public class TimeZoneNotFoundException : Exception
{

	[Address(RVA = "0x14C5750", Offset = "0x14C4950", Length = "0x49")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "FindSystemTimeZoneByIdWinRTFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeZoneInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000A38")]
	public TimeZoneNotFoundException() { }

	[Address(RVA = "0x14C56D0", Offset = "0x14C48D0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A39")]
	protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context) { }

}


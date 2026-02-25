namespace System;

[Token(Token = "0x2000106")]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public class InvalidTimeZoneException : Exception
{

	[Address(RVA = "0x14A1AD0", Offset = "0x14A0CD0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000818")]
	public InvalidTimeZoneException() { }

	[Address(RVA = "0x14A1A70", Offset = "0x14A0C70", Length = "0x59")]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan), typeof(AdjustmentRule[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000819")]
	public InvalidTimeZoneException(string message) { }

	[Address(RVA = "0x14A1B20", Offset = "0x14A0D20", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x600081A")]
	protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context) { }

}


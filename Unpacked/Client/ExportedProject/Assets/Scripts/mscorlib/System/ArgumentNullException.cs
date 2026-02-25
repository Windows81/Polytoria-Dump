namespace System;

[Token(Token = "0x20000B5")]
public class ArgumentNullException : ArgumentException
{

	[Address(RVA = "0x140AA60", Offset = "0x1409C60", Length = "0x44")]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000402")]
	public ArgumentNullException() { }

	[Address(RVA = "0x140A9F0", Offset = "0x1409BF0", Length = "0x66")]
	[CallerCount(Count = 2081)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000403")]
	public ArgumentNullException(string paramName) { }

	[Address(RVA = "0x140AAB0", Offset = "0x1409CB0", Length = "0x46")]
	[CallerCount(Count = 172)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000404")]
	public ArgumentNullException(string paramName, string message) { }

	[Address(RVA = "0x140A890", Offset = "0x1409A90", Length = "0x90")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000405")]
	protected ArgumentNullException(SerializationInfo info, StreamingContext context) { }

}


namespace System;

[Token(Token = "0x200010D")]
public class MemberAccessException : SystemException
{

	[Address(RVA = "0x14A3520", Offset = "0x14A2720", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000869")]
	public MemberAccessException() { }

	[Address(RVA = "0x14A3570", Offset = "0x14A2770", Length = "0x1E")]
	[CalledBy(Type = typeof(FieldAccessException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingFieldException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingMemberException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600086A")]
	public MemberAccessException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600086B")]
	protected MemberAccessException(SerializationInfo info, StreamingContext context) { }

}


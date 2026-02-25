namespace System;

[Token(Token = "0x20000FF")]
public sealed class InsufficientExecutionStackException : SystemException
{

	[Address(RVA = "0x149EA30", Offset = "0x149DC30", Length = "0x44")]
	[CalledBy(Type = typeof(RuntimeHelpers), Member = "EnsureSufficientExecutionStack", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.StackGuard", Member = "TryEnterOnCurrentStack", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007AD")]
	public InsufficientExecutionStackException() { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AE")]
	internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) { }

}


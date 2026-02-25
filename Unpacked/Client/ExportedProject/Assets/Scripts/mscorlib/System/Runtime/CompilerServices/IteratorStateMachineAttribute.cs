namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000478")]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute
{

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002032")]
	public IteratorStateMachineAttribute(Type stateMachineType) { }

}


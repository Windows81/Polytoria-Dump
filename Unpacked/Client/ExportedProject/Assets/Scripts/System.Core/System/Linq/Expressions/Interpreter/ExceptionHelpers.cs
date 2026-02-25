namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000233")]
internal static class ExceptionHelpers
{

	[Address(RVA = "0x15D1D70", Offset = "0x15D0F70", Length = "0x1D")]
	[CalledBy(Type = typeof(MethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefMethodInfoCallInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PropertyByRefUpdater), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexMethodByRefUpdater), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MutableValue), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MutableBox), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NewInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ByRefNewInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A49")]
	public static void UnwrapAndRethrow(TargetInvocationException exception) { }

}


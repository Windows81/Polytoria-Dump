namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000188")]
internal sealed class LightDelegateCreator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030F")]
	private readonly LambdaExpression _lambda; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000310")]
	private readonly Interpreter <Interpreter>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001A1")]
	internal Interpreter Interpreter
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000807")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x378250", Offset = "0x377450", Length = "0x4E")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000806")]
	internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda) { }

	[Address(RVA = "0x15D4940", Offset = "0x15D3B40", Length = "0xA")]
	[CalledBy(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[CalledBy(Type = typeof(Expression`1), Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TDelegate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IStrongBox[])}, ReturnType = typeof(Delegate))]
	[Token(Token = "0x6000808")]
	public Delegate CreateDelegate() { }

	[Address(RVA = "0x15D4950", Offset = "0x15D3B50", Length = "0x11B")]
	[CalledBy(Type = typeof(LightDelegateCreator), Member = "CreateDelegate", ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(CreateDelegateInstruction), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InterpretedFrame)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LightLambda), Member = "GetRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(LightLambda), Member = "CreateCustomDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000809")]
	internal Delegate CreateDelegate(IStrongBox[] closure) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000807")]
	internal Interpreter get_Interpreter() { }

}


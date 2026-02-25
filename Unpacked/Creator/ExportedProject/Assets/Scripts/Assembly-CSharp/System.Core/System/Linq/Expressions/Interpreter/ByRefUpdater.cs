namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000182")]
internal abstract class ByRefUpdater
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000304")]
	public readonly int ArgumentIndex; //Field offset: 0x10

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007F5")]
	public ByRefUpdater(int argumentIndex) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007F7")]
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Token(Token = "0x60007F6")]
	public abstract void Update(InterpretedFrame frame, object value) { }

}


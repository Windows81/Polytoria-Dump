namespace MoonSharp.Interpreter.Tree.Statements;

[Token(Token = "0x200008E")]
internal class EmptyStatement : Statement
{

	[Address(RVA = "0x31C350", Offset = "0x31B550", Length = "0x3C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000723")]
	public EmptyStatement(ScriptLoadingContext lcontext) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000724")]
	public virtual void Compile(ByteCode bc) { }

}


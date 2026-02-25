namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000178")]
internal sealed class ExceptionHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DE")]
	private readonly Type _exceptionType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DF")]
	public readonly int LabelIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002E0")]
	public readonly int HandlerStartIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E1")]
	public readonly int HandlerEndIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E2")]
	public readonly ExceptionFilter Filter; //Field offset: 0x28

	[Address(RVA = "0x15AD820", Offset = "0x15ACA20", Length = "0x67")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileTryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000778")]
	internal ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	[Address(RVA = "0x15AD700", Offset = "0x15AC900", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000779")]
	public bool Matches(Type exceptionType) { }

	[Address(RVA = "0x15AD730", Offset = "0x15AC930", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600077A")]
	public virtual string ToString() { }

}


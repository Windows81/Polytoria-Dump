namespace MoonSharp.Interpreter;

[Extension]
[Token(Token = "0x2000048")]
public static class LuaTypeExtensions
{
	[Token(Token = "0x40001D2")]
	internal const DataType MaxMetaTypes = 6; //Field offset: 0x0
	[Token(Token = "0x40001D3")]
	internal const DataType MaxConvertibleTypes = 10; //Field offset: 0x0

	[Address(RVA = "0x303BE0", Offset = "0x302DE0", Length = "0x7")]
	[CalledBy(Type = typeof(Processor), Member = "GetMetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(Processor), Member = "ExecEq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DebugModule), Member = "getmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "setmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(MetaTableModule), Member = "getmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x60004D2")]
	public static bool CanHaveTypeMetatables(DataType type) { }

	[Address(RVA = "0x303BF0", Offset = "0x302DF0", Length = "0xB4")]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "BadArgumentNoValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(MetaTableModule), Member = "rawlen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "setmetatable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "BadArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(DataType), typeof(bool)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "BadArgumentNoValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "AttemptToCallNonFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType), typeof(string)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "BadArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(DataType), typeof(bool)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "AttemptToCallNonFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataType), typeof(string)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(PropertyTableAssigner), Member = "AssignObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DynValueMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Extension]
	[Token(Token = "0x60004D3")]
	public static string ToErrorTypeString(DataType type) { }

	[Address(RVA = "0x303DD0", Offset = "0x302FD0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x60004D4")]
	public static string ToLuaDebuggerString(DataType type) { }

	[Address(RVA = "0x303E40", Offset = "0x303040", Length = "0x88")]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "CompareInvalidType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(TableModule), Member = "concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BasicModule), Member = "type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DynValue), Member = "ToPrintString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DynValue), Member = "ToDebugPrintString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "ArithmeticOnNonNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "ConcatOnNonString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "LenOnInvalidType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(NetRuntimeException), Member = "IndexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(NetRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "ArithmeticOnNonNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "ConcatOnNonString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "LenOnInvalidType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "CompareInvalidType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(ScriptRuntimeException))]
	[CalledBy(Type = typeof(ScriptRuntimeException), Member = "IndexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(ScriptRuntimeException))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Extension]
	[Token(Token = "0x60004D5")]
	public static string ToLuaTypeString(DataType type) { }

}


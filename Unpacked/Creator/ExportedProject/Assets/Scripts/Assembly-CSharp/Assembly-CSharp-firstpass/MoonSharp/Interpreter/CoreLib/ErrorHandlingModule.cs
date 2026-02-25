namespace MoonSharp.Interpreter.CoreLib;

[MoonSharpModule]
[Token(Token = "0x2000178")]
public class ErrorHandlingModule
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD9")]
	public ErrorHandlingModule() { }

	[Address(RVA = "0x378BE0", Offset = "0x377DE0", Length = "0x10F")]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "pcall_continuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "pcall_onerror", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000DD5")]
	private static DynValue MakeReturnTuple(bool retstatus, CallbackArguments args) { }

	[Address(RVA = "0x3796B0", Offset = "0x3788B0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DD3")]
	public static DynValue pcall(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3796A0", Offset = "0x3788A0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ErrorHandlingModule), Member = "MakeReturnTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000DD6")]
	public static DynValue pcall_continuation(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x379710", Offset = "0x378910", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ErrorHandlingModule), Member = "MakeReturnTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000DD7")]
	public static DynValue pcall_onerror(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x378CF0", Offset = "0x377EF0", Length = "0x9A0")]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "pcall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "xpcall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynValue), Member = "get_Callback", ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5C00")]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(ScriptRuntimeException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180316730")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(DynValue), Member = "get_TailCallData", ReturnType = typeof(TailCallData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CallbackFunction), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewTupleNested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "NewTailCallReq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TailCallData)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CallbackFunction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000DD4")]
	private static DynValue SetErrorHandlerStrategy(string funcName, ScriptExecutionContext executionContext, CallbackArguments args, DynValue handlerBeforeUnwind) { }

	[Address(RVA = "0x379720", Offset = "0x378920", Length = "0x1C4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DD8")]
	public static DynValue xpcall(ScriptExecutionContext executionContext, CallbackArguments args) { }

}


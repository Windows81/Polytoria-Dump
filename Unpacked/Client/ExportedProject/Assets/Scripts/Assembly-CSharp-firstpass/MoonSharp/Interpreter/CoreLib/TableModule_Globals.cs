namespace MoonSharp.Interpreter.CoreLib;

[MoonSharpModule]
[Token(Token = "0x2000187")]
public class TableModule_Globals
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E88")]
	public TableModule_Globals() { }

	[Address(RVA = "0x38B870", Offset = "0x38AA70", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Table), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynValue), Member = "NewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E87")]
	public static DynValue pack(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x38B9B0", Offset = "0x38ABB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TableModule), Member = "unpack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E86")]
	public static DynValue unpack(ScriptExecutionContext executionContext, CallbackArguments args) { }

}


namespace MoonSharp.Interpreter.CoreLib;

[MoonSharpModule]
[Token(Token = "0x200017C")]
public class LoadModule
{
	[MoonSharpModuleMethod]
	[Token(Token = "0x40005E7")]
	public const string require = "
function(modulename)
	if (package == nil) then package = { }; end
	if (package.loaded == nil) then package.loaded = { }; end

	local m = package.loaded[modulename];

	if (m ~= nil) then
		return m;
	end

	local func = __require_clr_impl(modulename);

	local res = func(modulename);

	if (res == nil) then
		res = true;
	end

	package.loaded[modulename] = res;

	return res;
end"; //Field offset: 0x0

	[Address(RVA = "0x380850", Offset = "0x37FA50", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "RequireModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E02")]
	public static DynValue __require_clr_impl(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E03")]
	public LoadModule() { }

	[Address(RVA = "0x3808F0", Offset = "0x37FAF0", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewTailCallReq", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000E01")]
	public static DynValue dofile(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3805F0", Offset = "0x37F7F0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "get_CurrentGlobalEnv", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E00")]
	private static Table GetSafeDefaultEnv(ScriptExecutionContext executionContext) { }

	[Address(RVA = "0x380EC0", Offset = "0x3800C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadModule), Member = "load_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DFA")]
	public static DynValue load(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x380A60", Offset = "0x37FC60", Length = "0x458")]
	[CalledBy(Type = typeof(LoadModule), Member = "load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "loadsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5AC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Script), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DFC")]
	public static DynValue load_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv) { }

	[Address(RVA = "0x381100", Offset = "0x380300", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadModule), Member = "loadfile_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DFD")]
	public static DynValue loadfile(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x380ED0", Offset = "0x3800D0", Length = "0x221")]
	[CalledBy(Type = typeof(LoadModule), Member = "loadfile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LoadModule), Member = "loadfilesafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Script), Member = "LoadFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewTuple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5AC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000DFF")]
	private static DynValue loadfile_impl(ScriptExecutionContext executionContext, CallbackArguments args, Table defaultEnv) { }

	[Address(RVA = "0x381110", Offset = "0x380310", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "get_CurrentGlobalEnv", ReturnType = typeof(Table))]
	[Calls(Type = typeof(LoadModule), Member = "loadfile_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DFE")]
	public static DynValue loadfilesafe(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x3811A0", Offset = "0x3803A0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptExecutionContext), Member = "get_CurrentGlobalEnv", ReturnType = typeof(Table))]
	[Calls(Type = typeof(LoadModule), Member = "load_impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(Table)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DFB")]
	public static DynValue loadsafe(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x380670", Offset = "0x37F870", Length = "0x1D1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Table), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Table), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "IsNil", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(DynValue), Member = "NewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000DF9")]
	public static void MoonSharpInit(Table globalTable, Table ioTable) { }

}


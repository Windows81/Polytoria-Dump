namespace MoonSharp.Interpreter.Interop.LuaStateInterop;

[Token(Token = "0x2000125")]
public class LuaState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000486")]
	private List<DynValue> m_Stack; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000487")]
	private ScriptExecutionContext <ExecutionContext>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000488")]
	private string <FunctionName>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000179")]
	public int Count
	{
		[Address(RVA = "0x35A960", Offset = "0x359B60", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000B37")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000177")]
	public private ScriptExecutionContext ExecutionContext
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B30")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B31")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000178")]
	public private string FunctionName
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B32")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B33")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x35A7E0", Offset = "0x3599E0", Length = "0x174")]
	[CalledBy(Type = typeof(ScriptExecutionContext), Member = "EmulateClassicCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`2<MoonSharp.Interpreter.Interop.LuaStateInterop.LuaState, System.Int32>)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B34")]
	internal LuaState(ScriptExecutionContext executionContext, CallbackArguments args, string functionName) { }

	[Address(RVA = "0x35A280", Offset = "0x359480", Length = "0xF3")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckStringStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(CharPtr))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLOptInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaGetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaIsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaToLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(UInt32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLCheckLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(UInt32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(LuaBase), Member = "ArgAsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LuaBase), Member = "GetArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLOptInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B36")]
	public DynValue At(int pos) { }

	[Address(RVA = "0x35A380", Offset = "0x359580", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B3C")]
	public void Discard(int nargs) { }

	[Address(RVA = "0x35A960", Offset = "0x359B60", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B37")]
	public int get_Count() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B30")]
	public ScriptExecutionContext get_ExecutionContext() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B32")]
	public string get_FunctionName() { }

	[Address(RVA = "0x35A400", Offset = "0x359600", Length = "0xE1")]
	[CalledBy(Type = typeof(ScriptExecutionContext), Member = "EmulateClassicCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(string), typeof(System.Func`2<MoonSharp.Interpreter.Interop.LuaStateInterop.LuaState, System.Int32>)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LuaState), Member = "GetTopArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewTupleNested", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(LuaState), Member = "Top", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x6000B3B")]
	public DynValue GetReturnValue(int retvals) { }

	[Address(RVA = "0x35A4F0", Offset = "0x3596F0", Length = "0x10D")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaState), Member = "GetReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B3A")]
	public DynValue[] GetTopArray(int num) { }

	[Address(RVA = "0x35A600", Offset = "0x359800", Length = "0xB0")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLAddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaLBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaGetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B39")]
	public DynValue Pop() { }

	[Address(RVA = "0x35A6C0", Offset = "0x3598C0", Length = "0xA9")]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaLPushResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaLBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushLString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(CharPtr), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaPushNil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaGetTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LuaBase), Member = "LuaCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000B38")]
	public void Push(DynValue v) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B31")]
	private void set_ExecutionContext(ScriptExecutionContext value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B33")]
	private void set_FunctionName(string value) { }

	[Address(RVA = "0x35A770", Offset = "0x359970", Length = "0x66")]
	[CalledBy(Type = typeof(LuaState), Member = "GetReturnValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B35")]
	public DynValue Top(int pos = 0) { }

}


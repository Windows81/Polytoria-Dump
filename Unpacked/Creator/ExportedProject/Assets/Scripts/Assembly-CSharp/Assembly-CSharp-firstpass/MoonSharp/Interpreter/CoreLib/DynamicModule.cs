namespace MoonSharp.Interpreter.CoreLib;

[MoonSharpModule(Namespace = "dynamic")]
[Token(Token = "0x2000176")]
public class DynamicModule
{
	[Token(Token = "0x2000177")]
	private class DynamicExprWrapper
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005E4")]
		public DynamicExpression Expr; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DD2")]
		public DynamicExprWrapper() { }

	}


	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DD1")]
	public DynamicModule() { }

	[Address(RVA = "0x3787E0", Offset = "0x3779E0", Length = "0x276")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicExpression), Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynamicExpression))]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "BadArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DCF")]
	public static DynValue eval(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[Address(RVA = "0x378780", Offset = "0x377980", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UserData), Member = "RegisterType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[Token(Token = "0x6000DCE")]
	public static void MoonSharpInit(Table globalTable, Table stringTable) { }

	[Address(RVA = "0x378A60", Offset = "0x377C60", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "AsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(DataType), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "CreateDynamicExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynamicExpression))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UserData), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 3)]
	[MoonSharpModuleMethod]
	[Token(Token = "0x6000DD0")]
	public static DynValue prepare(ScriptExecutionContext executionContext, CallbackArguments args) { }

}


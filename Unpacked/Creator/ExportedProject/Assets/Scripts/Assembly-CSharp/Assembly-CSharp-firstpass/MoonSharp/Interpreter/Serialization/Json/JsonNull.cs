namespace MoonSharp.Interpreter.Serialization.Json;

[Token(Token = "0x20000AF")]
public sealed class JsonNull
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007BC")]
	public JsonNull() { }

	[Address(RVA = "0x322960", Offset = "0x321B60", Length = "0x51")]
	[CalledBy(Type = typeof(JsonTableConverter), Member = "ParseJsonValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lexer), typeof(Script)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(JsonModule), Member = "null", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UserData), Member = "CreateStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(DynValue))]
	[MoonSharpHidden]
	[Token(Token = "0x60007BB")]
	public static DynValue Create() { }

	[Address(RVA = "0x3229C0", Offset = "0x321BC0", Length = "0x14E")]
	[CalledBy(Type = typeof(JsonModule), Member = "isnull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[MoonSharpHidden]
	[Token(Token = "0x60007BA")]
	public static bool IsJsonNull(DynValue v) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007B9")]
	public static bool isNull() { }

}


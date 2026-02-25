namespace MoonSharp.Interpreter;

[Token(Token = "0x200003D")]
public sealed class CallbackFunction : RefIdObject
{
	[Token(Token = "0x4000196")]
	private static InteropAccessMode m_DefaultAccessMode; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000197")]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000198")]
	private Func<ScriptExecutionContext, CallbackArguments, DynValue> <ClrCallback>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000199")]
	private object <AdditionalData>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000083")]
	public object AdditionalData
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000484")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000485")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000081")]
	public private Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047C")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000082")]
	public static InteropAccessMode DefaultAccessMode
	{
		[Address(RVA = "0x2F72C0", Offset = "0x2F64C0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000480")]
		 get { } //Length: 77
		[Address(RVA = "0x2F7330", Offset = "0x2F6530", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000481")]
		 set { } //Length: 169
	}

	[Token(Token = "0x17000080")]
	public private string Name
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047A")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600047B")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2F71E0", Offset = "0x2F63E0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000487")]
	private static CallbackFunction() { }

	[Address(RVA = "0x2F7220", Offset = "0x2F6420", Length = "0x88")]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "GetCallbackFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(CallbackFunction))]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "GetCallbackAsDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "GetCallbackFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(CallbackFunction))]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BasicModule), Member = "tostring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KopiLua_StringLib), Member = "str_gmatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LuaState)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600047E")]
	public CallbackFunction(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name = null) { }

	[Address(RVA = "0x2F6CE0", Offset = "0x2F5EE0", Length = "0x1DA")]
	[CalledBy(Type = typeof(ModuleRegister), Member = "RegisterModuleType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table), typeof(Type)}, ReturnType = typeof(Table))]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToSimpleDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000486")]
	public static bool CheckCallbackSignature(MethodInfo mi, bool requirePublicVisibility) { }

	[Address(RVA = "0x2F6EC0", Offset = "0x2F60C0", Length = "0xE0")]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "GetCallbackFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000482")]
	public static CallbackFunction FromDelegate(Script script, Delegate del, InteropAccessMode accessMode = 7) { }

	[Address(RVA = "0x2F6FB0", Offset = "0x2F61B0", Length = "0xD0")]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MethodMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "GetCallbackFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(CallbackFunction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000483")]
	public static CallbackFunction FromMethodInfo(Script script, MethodInfo mi, object obj = null, InteropAccessMode accessMode = 7) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000484")]
	public object get_AdditionalData() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047C")]
	public Func<ScriptExecutionContext, CallbackArguments, DynValue> get_ClrCallback() { }

	[Address(RVA = "0x2F72C0", Offset = "0x2F64C0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000480")]
	public static InteropAccessMode get_DefaultAccessMode() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047A")]
	public string get_Name() { }

	[Address(RVA = "0x2F7090", Offset = "0x2F6290", Length = "0x142")]
	[CalledBy(Type = typeof(Processor), Member = "Processing_Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "PerformMessageDecorationBeforeUnwind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(SourceRef)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Processor), Member = "Internal_ExecCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CallbackFunction), typeof(CallbackFunction), typeof(bool), typeof(string), typeof(DynValue)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Processor), Member = "ExecRet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instruction)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "SetErrorHandlerStrategy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600047F")]
	public DynValue Invoke(ScriptExecutionContext executionContext, IList<DynValue> args, bool isMethodCall = false) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000485")]
	public void set_AdditionalData(object value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047D")]
	private void set_ClrCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> value) { }

	[Address(RVA = "0x2F7330", Offset = "0x2F6530", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000481")]
	public static void set_DefaultAccessMode(InteropAccessMode value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600047B")]
	private void set_Name(string value) { }

}


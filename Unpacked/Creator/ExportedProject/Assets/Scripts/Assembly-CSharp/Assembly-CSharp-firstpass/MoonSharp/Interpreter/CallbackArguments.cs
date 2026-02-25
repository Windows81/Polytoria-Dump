namespace MoonSharp.Interpreter;

[DefaultMember("Item")]
[Token(Token = "0x200003C")]
public class CallbackArguments
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000192")]
	private IList<DynValue> m_Args; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000193")]
	private int m_Count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000194")]
	private bool m_LastIsTuple; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000195")]
	private bool <IsMethodCall>k__BackingField; //Field offset: 0x1D

	[Token(Token = "0x1700007D")]
	public int Count
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600046E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700007E")]
	public private bool IsMethodCall
	{
		[Address(RVA = "0x2F6C10", Offset = "0x2F5E10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600046F")]
		 get { } //Length: 5
		[Address(RVA = "0x2F6CD0", Offset = "0x2F5ED0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000470")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700007F")]
	public DynValue Item
	{
		[Address(RVA = "0x2F6C20", Offset = "0x2F5E20", Length = "0xA2")]
		[CallerCount(Count = 116)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CallbackArguments), Member = "RawGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000471")]
		 get { } //Length: 162
	}

	[Address(RVA = "0x2F6A90", Offset = "0x2F5C90", Length = "0x162")]
	[CalledBy(Type = typeof(ErrorHandlingModule), Member = "xpcall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CallbackArguments), Member = "SkipMethodCall", ReturnType = typeof(CallbackArguments))]
	[CalledBy(Type = typeof(CallbackFunction), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ScriptExecutionContext), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "ExecuteIndexer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600046D")]
	public CallbackArguments(IList<DynValue> args, bool isMethodCall) { }

	[Address(RVA = "0x2F6090", Offset = "0x2F5290", Length = "0x5B")]
	[CalledBy(Type = typeof(ArrayMemberDescriptor), Member = "BuildArrayIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArguments), typeof(int)}, ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(DebugModule), Member = "upvaluejoin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000476")]
	public int AsInt(int argNum, string funcName) { }

	[Address(RVA = "0x2F60F0", Offset = "0x2F52F0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000477")]
	public long AsLong(int argNum, string funcName) { }

	[Address(RVA = "0x2F6150", Offset = "0x2F5350", Length = "0x480")]
	[CalledBy(Type = typeof(BasicModule), Member = "print", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Script), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynValue), Member = "get_UserData", ReturnType = typeof(UserData))]
	[Calls(Type = typeof(DynValue), Member = "ToPrintString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Table), Member = "RawGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "get_Table", ReturnType = typeof(Table))]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000478")]
	public string AsStringUsingMeta(ScriptExecutionContext executionContext, int argNum, string funcName) { }

	[Address(RVA = "0x2F65E0", Offset = "0x2F57E0", Length = "0x5E")]
	[CallerCount(Count = 145)]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DataType), typeof(int), typeof(TypeValidationFlags)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000474")]
	public DynValue AsType(int argNum, string funcName, DataType type, bool allowNil = false) { }

	[Address(RVA = "0x685620", Offset = "0x684820", Length = "0x88")]
	[CalledBy(Type = typeof(IoModule), Member = "close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "flush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(IoModule), Member = "HandleDefaultStreamSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(StandardFileType)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(DynValue), Member = "CheckUserDataType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(TypeValidationFlags)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000475")]
	public T AsUserData(int argNum, string funcName, bool allowNil = false) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600046E")]
	public int get_Count() { }

	[Address(RVA = "0x2F6C10", Offset = "0x2F5E10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600046F")]
	public bool get_IsMethodCall() { }

	[Address(RVA = "0x2F6C20", Offset = "0x2F5E20", Length = "0xA2")]
	[CallerCount(Count = 116)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CallbackArguments), Member = "RawGet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000471")]
	public DynValue get_Item(int index) { }

	[Address(RVA = "0x2F6640", Offset = "0x2F5840", Length = "0xE2")]
	[CalledBy(Type = typeof(BasicModule), Member = "assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "__wrap_wrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "yield", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableIteratorsModule), Member = "ipairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(TableIteratorsModule), Member = "pairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000473")]
	public DynValue[] GetArray(int skip = 0) { }

	[Address(RVA = "0x2F6730", Offset = "0x2F5930", Length = "0x263")]
	[CalledBy(Type = typeof(CallbackArguments), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "CalcScoreForOverload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(IOverloadableMemberDescriptor), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5AC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000472")]
	public DynValue RawGet(int index, bool translateVoids) { }

	[Address(RVA = "0x2F6CD0", Offset = "0x2F5ED0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000470")]
	private void set_IsMethodCall(bool value) { }

	[Address(RVA = "0x2F69A0", Offset = "0x2F5BA0", Length = "0xEB")]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Slice`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000479")]
	public CallbackArguments SkipMethodCall() { }

}


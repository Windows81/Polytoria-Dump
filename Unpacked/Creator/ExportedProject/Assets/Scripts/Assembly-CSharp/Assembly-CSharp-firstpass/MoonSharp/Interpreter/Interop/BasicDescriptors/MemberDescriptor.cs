namespace MoonSharp.Interpreter.Interop.BasicDescriptors;

[Extension]
[Token(Token = "0x2000134")]
public static class MemberDescriptor
{
	[CompilerGenerated]
	[Token(Token = "0x2000135")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004C0")]
		public IMemberDescriptor desc; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004C1")]
		public Script script; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004C2")]
		public object obj; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA7")]
		public <>c__DisplayClass4_0() { }

		[Address(RVA = "0x3716A0", Offset = "0x3708A0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000BA8")]
		internal DynValue <GetGetterCallbackAsDynValue>b__0(ScriptExecutionContext p1, CallbackArguments p2) { }

	}


	[Address(RVA = "0x35A9A0", Offset = "0x359BA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000BA3")]
	public static bool CanExecute(IMemberDescriptor desc) { }

	[Address(RVA = "0x35A9F0", Offset = "0x359BF0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000BA1")]
	public static bool CanRead(IMemberDescriptor desc) { }

	[Address(RVA = "0x35AA40", Offset = "0x359C40", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000BA2")]
	public static bool CanWrite(IMemberDescriptor desc) { }

	[Address(RVA = "0x35AA90", Offset = "0x359C90", Length = "0x35B")]
	[CalledBy(Type = typeof(ValueTypeDefaultCtorMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HardwiredMethodMemberDescriptor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(HardwiredMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HardwiredMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ValueTypeDefaultCtorMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(OverloadedMethodMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ValueTypeDefaultCtorMemberDescriptor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FieldMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(FunctionMemberDescriptorBase), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "AccessInstanceMemberOnStatics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Extension]
	[Token(Token = "0x6000BA6")]
	public static void CheckAccess(IMemberDescriptor desc, MemberDescriptorAccess access, object obj) { }

	[Address(RVA = "0x35ADF0", Offset = "0x359FF0", Length = "0x10E")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryDispatchLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x6000BA4")]
	public static DynValue GetGetterCallbackAsDynValue(IMemberDescriptor desc, Script script, object obj) { }

	[Address(RVA = "0x2F79D0", Offset = "0x2F6BD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000BA0")]
	public static bool HasAllFlags(MemberDescriptorAccess access, MemberDescriptorAccess flag) { }

	[Address(RVA = "0x35AF00", Offset = "0x35A100", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Extension]
	[Token(Token = "0x6000BA5")]
	public static IMemberDescriptor WithAccessOrNull(IMemberDescriptor desc, MemberDescriptorAccess access) { }

}


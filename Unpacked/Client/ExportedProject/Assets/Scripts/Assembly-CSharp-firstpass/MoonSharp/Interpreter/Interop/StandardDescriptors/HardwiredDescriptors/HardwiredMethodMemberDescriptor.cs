namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors;

[Token(Token = "0x200011C")]
public abstract class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000AAE")]
	protected HardwiredMethodMemberDescriptor() { }

	[Address(RVA = "0x356BC0", Offset = "0x355DC0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000AAC")]
	private int CalcArgsCount(Object[] pars) { }

	[Address(RVA = "0x356C80", Offset = "0x355E80", Length = "0x199")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMemberDescriptor), typeof(MemberDescriptorAccess), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "BuildArgumentList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments), typeof(List`1<Int32>&)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "FromObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AAB")]
	public virtual DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	[Token(Token = "0x6000AAD")]
	protected abstract object Invoke(Script script, object obj, Object[] pars, int argscount) { }

}


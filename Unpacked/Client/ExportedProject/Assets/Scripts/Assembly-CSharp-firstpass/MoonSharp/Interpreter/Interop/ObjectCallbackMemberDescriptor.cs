namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000E6")]
public class ObjectCallbackMemberDescriptor : FunctionMemberDescriptorBase
{
	[CompilerGenerated]
	[Token(Token = "0x20000E7")]
	private sealed class <>c
	{
		[Token(Token = "0x40003D6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003D7")]
		public static Func<Object, ScriptExecutionContext, CallbackArguments, Object> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x34E9B0", Offset = "0x34DBB0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000921")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000922")]
		public <>c() { }

		[Address(RVA = "0x34D640", Offset = "0x34C840", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000923")]
		internal object <.ctor>b__1_0(object o, ScriptExecutionContext c, CallbackArguments a) { }

	}

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003D5")]
	private Func<Object, ScriptExecutionContext, CallbackArguments, Object> m_CallbackFunc; //Field offset: 0x48

	[Address(RVA = "0x33E710", Offset = "0x33D910", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ParameterDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091D")]
	public ObjectCallbackMemberDescriptor(string funcName) { }

	[Address(RVA = "0x33E670", Offset = "0x33D870", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ParameterDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091E")]
	public ObjectCallbackMemberDescriptor(string funcName, Func<Object, ScriptExecutionContext, CallbackArguments, Object> callBack) { }

	[Address(RVA = "0x33E870", Offset = "0x33DA70", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FunctionMemberDescriptorBase), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(ParameterDescriptor[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600091F")]
	public ObjectCallbackMemberDescriptor(string funcName, Func<Object, ScriptExecutionContext, CallbackArguments, Object> callBack, ParameterDescriptor[] parameters) { }

	[Address(RVA = "0x33E580", Offset = "0x33D780", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000920")]
	public virtual DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

}


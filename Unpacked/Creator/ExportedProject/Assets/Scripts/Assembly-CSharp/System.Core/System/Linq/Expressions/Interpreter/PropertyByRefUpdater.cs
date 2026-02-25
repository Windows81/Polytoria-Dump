namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000186")]
internal sealed class PropertyByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400030A")]
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400030B")]
	private readonly PropertyInfo _property; //Field offset: 0x30

	[Address(RVA = "0x15D3E20", Offset = "0x15D3020", Length = "0x6A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000800")]
	public PropertyByRefUpdater(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	[Address(RVA = "0x15E08D0", Offset = "0x15DFAD0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000802")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x15E0970", Offset = "0x15DFB70", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(ExceptionHelpers), Member = "UnwrapAndRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TargetInvocationException)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000801")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}


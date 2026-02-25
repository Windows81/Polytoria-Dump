namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000184")]
internal sealed class ArrayByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000306")]
	private readonly LocalDefinition _array; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000307")]
	private readonly LocalDefinition _index; //Field offset: 0x28

	[Address(RVA = "0x15CDB70", Offset = "0x15CCD70", Length = "0x62")]
	[CalledBy(Type = typeof(LightCompiler), Member = "CompileArrayIndexAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(int)}, ReturnType = typeof(ByRefUpdater))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007FA")]
	public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	[Address(RVA = "0x15CD9C0", Offset = "0x15CCBC0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007FC")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x15CDA50", Offset = "0x15CCC50", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007FB")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}


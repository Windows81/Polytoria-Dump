namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000185")]
internal sealed class FieldByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000308")]
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000309")]
	private readonly FieldInfo _field; //Field offset: 0x30

	[Address(RVA = "0x15D3E20", Offset = "0x15D3020", Length = "0x6A")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007FD")]
	public FieldByRefUpdater(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	[Address(RVA = "0x15D3CE0", Offset = "0x15D2EE0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InstructionList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalVariables), Member = "UndefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDefinition), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007FF")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x15D3D80", Offset = "0x15D2F80", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007FE")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}


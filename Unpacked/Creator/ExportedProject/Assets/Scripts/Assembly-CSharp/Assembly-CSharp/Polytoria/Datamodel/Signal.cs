namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000359")]
public class Signal : Instance
{
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000E34")]
	public LuaEvent Invoked; //Field offset: 0xF8

	[Address(RVA = "0x46E550", Offset = "0x46D750", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60022C1")]
	public Signal() { }

	[Address(RVA = "0x46E530", Offset = "0x46D730", Length = "0x15")]
	[CalledBy(Type = typeof(SignalProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60022C0")]
	public void Invoke(Object[] par) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60022C2")]
	public virtual bool Weaved() { }

}


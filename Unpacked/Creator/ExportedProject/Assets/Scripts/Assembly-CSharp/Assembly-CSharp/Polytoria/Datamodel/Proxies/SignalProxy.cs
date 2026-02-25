namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003BE")]
public class SignalProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001008")]
	private readonly Signal signal; //Field offset: 0x18

	[Token(Token = "0x17000C3F")]
	public LuaEvent Invoked
	{
		[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60028C2")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028C1")]
	public SignalProxy(Signal target) { }

	[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60028C2")]
	public LuaEvent get_Invoked() { }

	[Address(RVA = "0x4AC860", Offset = "0x4ABA60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Signal), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028C3")]
	public void Invoke(Object[] par) { }

}


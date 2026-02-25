namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A8")]
public class InstanceValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF2")]
	private readonly InstanceValue instanceValue; //Field offset: 0x20

	[Token(Token = "0x17000BB0")]
	public Instance Value
	{
		[Address(RVA = "0x4A5840", Offset = "0x4A4A40", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002774")]
		 get { } //Length: 29
		[Address(RVA = "0x4A5860", Offset = "0x4A4A60", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InstanceValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002775")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002773")]
	public InstanceValueProxy(InstanceValue target) { }

	[Address(RVA = "0x4A5840", Offset = "0x4A4A40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002774")]
	public Instance get_Value() { }

	[Address(RVA = "0x4A5860", Offset = "0x4A4A60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002775")]
	public void set_Value(Instance value) { }

}


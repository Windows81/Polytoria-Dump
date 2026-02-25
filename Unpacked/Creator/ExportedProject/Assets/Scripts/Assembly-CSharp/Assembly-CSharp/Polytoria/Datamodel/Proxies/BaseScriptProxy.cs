namespace Polytoria.Datamodel.Proxies;

[DefaultMember("Item")]
[Token(Token = "0x2000398")]
public class BaseScriptProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FE2")]
	private readonly BaseScript baseScript; //Field offset: 0x18

	[Token(Token = "0x17000B55")]
	public object Item
	{
		[Address(RVA = "0x4A10C0", Offset = "0x4A02C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseScript), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026A2")]
		 get { } //Length: 30
		[Address(RVA = "0x4A10E0", Offset = "0x4A02E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseScript), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026A3")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026A1")]
	public BaseScriptProxy(BaseScript target) { }

	[Address(RVA = "0x4A10A0", Offset = "0x4A02A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseScript), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026A4")]
	public void Call(string function, Object[] args) { }

	[Address(RVA = "0x4A10C0", Offset = "0x4A02C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseScript), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026A2")]
	public object get_Item(string name) { }

	[Address(RVA = "0x4A10E0", Offset = "0x4A02E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseScript), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026A3")]
	public void set_Item(string name, object value) { }

}


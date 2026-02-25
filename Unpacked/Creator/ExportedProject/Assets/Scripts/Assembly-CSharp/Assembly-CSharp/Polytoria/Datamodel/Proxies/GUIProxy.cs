namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A4")]
public class GUIProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FEE")]
	private readonly GUI gui; //Field offset: 0x18

	[Token(Token = "0x17000B9B")]
	public bool Visible
	{
		[Address(RVA = "0x4A3FC0", Offset = "0x4A31C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002745")]
		 get { } //Length: 30
		[Address(RVA = "0x4A3FE0", Offset = "0x4A31E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GUI), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002746")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002744")]
	public GUIProxy(GUI target) { }

	[Address(RVA = "0x4A3FC0", Offset = "0x4A31C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002745")]
	public bool get_Visible() { }

	[Address(RVA = "0x4A3FE0", Offset = "0x4A31E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002746")]
	public void set_Visible(bool value) { }

}


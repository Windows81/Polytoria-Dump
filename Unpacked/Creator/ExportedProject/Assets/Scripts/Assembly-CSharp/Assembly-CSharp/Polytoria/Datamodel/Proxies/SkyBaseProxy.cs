namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003BF")]
public class SkyBaseProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001009")]
	private readonly SkyBase skyBase; //Field offset: 0x18

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028C4")]
	public SkyBaseProxy(SkyBase target) { }

}


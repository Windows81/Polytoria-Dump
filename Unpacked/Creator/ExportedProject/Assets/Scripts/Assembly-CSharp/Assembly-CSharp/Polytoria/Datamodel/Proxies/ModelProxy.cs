namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003AD")]
public class ModelProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF7")]
	private readonly Model model; //Field offset: 0x20

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002793")]
	public ModelProxy(Model target) { }

}


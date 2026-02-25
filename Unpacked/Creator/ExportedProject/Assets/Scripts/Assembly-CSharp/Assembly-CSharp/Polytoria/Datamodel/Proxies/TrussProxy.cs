namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C6")]
public class TrussProxy : ClimbableProxy
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001010")]
	private readonly Truss truss; //Field offset: 0x30

	[Address(RVA = "0x4AD140", Offset = "0x4AC340", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600290D")]
	public TrussProxy(Truss target) { }

}


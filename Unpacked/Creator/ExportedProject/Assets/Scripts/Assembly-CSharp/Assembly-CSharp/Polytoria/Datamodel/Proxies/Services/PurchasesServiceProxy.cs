namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003DB")]
public class PurchasesServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001026")]
	private readonly PurchasesService purchasesService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029D5")]
	public PurchasesServiceProxy(PurchasesService target) { }

	[Address(RVA = "0x4AC6C0", Offset = "0x4AB8C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PurchasesService), Member = "Prompt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player), typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60029D6")]
	public void Prompt(Player player, int assetID, DynValue callback) { }

}


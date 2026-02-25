namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003DA")]
public class InsertServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001025")]
	private readonly InsertService insertService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029D3")]
	public InsertServiceProxy(InsertService target) { }

	[Address(RVA = "0x4A5430", Offset = "0x4A4630", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InsertService), Member = "Model", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(Instance), "model", False)]
	[Token(Token = "0x60029D4")]
	public void Model(int id, DynValue callback = null) { }

}


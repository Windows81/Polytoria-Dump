namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D6")]
public class DataStoreServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001020")]
	private readonly DataStoreService dataStoreService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029A7")]
	public DataStoreServiceProxy(DataStoreService target) { }

	[Address(RVA = "0x4A2F20", Offset = "0x4A2120", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStoreService), Member = "GetDatastore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Datastore))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60029A8")]
	public Datastore GetDatastore(string key) { }

}


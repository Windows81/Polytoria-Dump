namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D7")]
public class FilterServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001021")]
	private readonly FilterService filterService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029A9")]
	public FilterServiceProxy(FilterService target) { }

	[Address(RVA = "0x4A3F70", Offset = "0x4A3170", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FilterService), Member = "Filter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x60029AA")]
	public static string Filter(string input) { }

}


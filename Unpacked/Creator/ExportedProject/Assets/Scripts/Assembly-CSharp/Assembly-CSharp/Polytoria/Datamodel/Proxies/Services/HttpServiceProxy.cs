namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D8")]
public class HttpServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001022")]
	private readonly HttpService httpService; //Field offset: 0x10

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029AB")]
	public HttpServiceProxy(HttpService target) { }

	[Address(RVA = "0x4A4410", Offset = "0x4A3610", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	[Token(Token = "0x60029AF")]
	public static void Delete(string url, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x4A4480", Offset = "0x4A3680", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	[Token(Token = "0x60029AC")]
	public static void Get(string url, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x4A44F0", Offset = "0x4A36F0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "Patch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	[Token(Token = "0x60029B0")]
	public static void Patch(string url, string body, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x4A4570", Offset = "0x4A3770", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	[Token(Token = "0x60029AD")]
	public static void Post(string url, string body, DynValue callback = null, Table headers = null) { }

	[Address(RVA = "0x4A45F0", Offset = "0x4A37F0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HttpService), Member = "Put", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DynValue), typeof(Table)}, ReturnType = typeof(void))]
	[LuaCallbackParameter("callback", typeof(string), "data", True)]
	[LuaCallbackParameter("callback", typeof(bool), "error", False)]
	[LuaCallbackParameter("callback", typeof(string), "message", True)]
	[Token(Token = "0x60029AE")]
	public static void Put(string url, string body, DynValue callback = null, Table headers = null) { }

}


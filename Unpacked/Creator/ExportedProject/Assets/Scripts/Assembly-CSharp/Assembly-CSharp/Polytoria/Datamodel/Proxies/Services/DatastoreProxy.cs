namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D5")]
public class DatastoreProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400101F")]
	private readonly Datastore datastore; //Field offset: 0x10

	[Token(Token = "0x17000CA6")]
	public string Key
	{
		[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60029A1")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000CA8")]
	public LuaEvent Loaded
	{
		[Address(RVA = "0x4A2FD0", Offset = "0x4A21D0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60029A3")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000CA7")]
	public bool Loading
	{
		[Address(RVA = "0x4A2FF0", Offset = "0x4A21F0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60029A2")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60029A0")]
	public DatastoreProxy(Datastore target) { }

	[Address(RVA = "0x4A2F40", Offset = "0x4A2140", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datastore), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(object), "value", True)]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	[Token(Token = "0x60029A4")]
	public void Get(string key, DynValue callback) { }

	[Address(RVA = "0x4A2FB0", Offset = "0x4A21B0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029A1")]
	public string get_Key() { }

	[Address(RVA = "0x4A2FD0", Offset = "0x4A21D0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60029A3")]
	public LuaEvent get_Loaded() { }

	[Address(RVA = "0x4A2FF0", Offset = "0x4A21F0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60029A2")]
	public bool get_Loading() { }

	[Address(RVA = "0x4A2F60", Offset = "0x4A2160", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datastore), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	[Token(Token = "0x60029A6")]
	public void Remove(string key, DynValue callback = null) { }

	[Address(RVA = "0x4A2F80", Offset = "0x4A2180", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Datastore), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(string), "error", True)]
	[Token(Token = "0x60029A5")]
	public void Set(string key, DynValue value, DynValue callback = null) { }

}


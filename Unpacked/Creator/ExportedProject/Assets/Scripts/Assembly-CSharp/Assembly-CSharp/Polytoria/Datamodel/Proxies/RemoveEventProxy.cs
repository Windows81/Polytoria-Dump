namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003BA")]
public class RemoveEventProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001004")]
	private readonly RemoteEvent remoteEvent; //Field offset: 0x18

	[LuaEventParameter(typeof(Player), "sender", False)]
	[LuaEventParameter(typeof(object), "value", False)]
	[Token(Token = "0x17000C3B")]
	public LuaEvent Invoked
	{
		[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60028B3")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028B2")]
	public RemoveEventProxy(RemoteEvent target) { }

	[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60028B3")]
	public LuaEvent get_Invoked() { }

	[Address(RVA = "0x4AC7E0", Offset = "0x4AB9E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B4")]
	public void Invoke(string val) { }

	[Address(RVA = "0x4AC730", Offset = "0x4AB930", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B5")]
	public void Invoke(bool val) { }

	[Address(RVA = "0x4AC750", Offset = "0x4AB950", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B6")]
	public void Invoke(float val) { }

	[Address(RVA = "0x4AC770", Offset = "0x4AB970", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B7")]
	public void Invoke(int val) { }

	[Address(RVA = "0x4AC6F0", Offset = "0x4AB8F0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B8")]
	public void Invoke(Vector3 val) { }

	[Address(RVA = "0x4AC790", Offset = "0x4AB990", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B9")]
	public void Invoke(Color val) { }

	[Address(RVA = "0x4AC7C0", Offset = "0x4AB9C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028BA")]
	public void Invoke(Instance val) { }

}


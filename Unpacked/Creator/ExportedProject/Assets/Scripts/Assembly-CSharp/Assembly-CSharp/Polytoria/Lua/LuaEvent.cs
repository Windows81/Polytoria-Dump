namespace Polytoria.Lua;

[Token(Token = "0x2000304")]
public class LuaEvent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BA9")]
	private List<DynValue> callbacks; //Field offset: 0x10

	[Address(RVA = "0x40E480", Offset = "0x40D680", Length = "0x77")]
	[CalledBy(Type = typeof(Sound), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputService), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Datastore), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vector3Value), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Tool), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Signal), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemoteEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Players), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkEvent), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Game), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Seat), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001BBD")]
	public LuaEvent() { }

	[Address(RVA = "0x40E110", Offset = "0x40D310", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001BBE")]
	public void Connect(DynValue func) { }

	[Address(RVA = "0x40E1F0", Offset = "0x40D3F0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001BBF")]
	public void Disconnect(DynValue func) { }

	[Address(RVA = "0x40E270", Offset = "0x40D470", Length = "0x205")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptService), Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[MoonSharpHidden]
	[Token(Token = "0x6001BC0")]
	public void Invoke(Object[] par) { }

}


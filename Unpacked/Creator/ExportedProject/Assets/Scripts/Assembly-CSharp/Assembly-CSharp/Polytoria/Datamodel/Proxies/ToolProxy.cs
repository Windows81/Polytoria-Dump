namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C5")]
public class ToolProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100F")]
	private readonly Tool tool; //Field offset: 0x20

	[Token(Token = "0x17000C5E")]
	public LuaEvent Activated
	{
		[Address(RVA = "0x4AD0A0", Offset = "0x4AC2A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002906")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C5F")]
	public LuaEvent Deactivated
	{
		[Address(RVA = "0x4AD0C0", Offset = "0x4AC2C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002907")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C62")]
	public bool Droppable
	{
		[Address(RVA = "0x4AD0E0", Offset = "0x4AC2E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600290B")]
		 get { } //Length: 30
		[Address(RVA = "0x4AD120", Offset = "0x4AC320", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600290C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C60")]
	public LuaEvent Equipped
	{
		[Address(RVA = "0x4AC920", Offset = "0x4ABB20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002908")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C61")]
	public LuaEvent Unequipped
	{
		[Address(RVA = "0x4AD100", Offset = "0x4AC300", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002909")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002905")]
	public ToolProxy(Tool target) { }

	[Address(RVA = "0x4AD0A0", Offset = "0x4AC2A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002906")]
	public LuaEvent get_Activated() { }

	[Address(RVA = "0x4AD0C0", Offset = "0x4AC2C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002907")]
	public LuaEvent get_Deactivated() { }

	[Address(RVA = "0x4AD0E0", Offset = "0x4AC2E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600290B")]
	public bool get_Droppable() { }

	[Address(RVA = "0x4AC920", Offset = "0x4ABB20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002908")]
	public LuaEvent get_Equipped() { }

	[Address(RVA = "0x4AD100", Offset = "0x4AC300", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002909")]
	public LuaEvent get_Unequipped() { }

	[Address(RVA = "0x4AD080", Offset = "0x4AC280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Tool), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600290A")]
	public void Play(string anim) { }

	[Address(RVA = "0x4AD120", Offset = "0x4AC320", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600290C")]
	public void set_Droppable(bool value) { }

}


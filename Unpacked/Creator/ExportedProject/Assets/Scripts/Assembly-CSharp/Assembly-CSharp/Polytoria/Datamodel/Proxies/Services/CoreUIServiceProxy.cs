namespace Polytoria.Datamodel.Proxies.Services;

[Token(Token = "0x20003D4")]
public class CoreUIServiceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400101E")]
	private readonly CoreUIService coreUI; //Field offset: 0x10

	[Token(Token = "0x17000CA5")]
	public bool CanRespawn
	{
		[Address(RVA = "0x4A1900", Offset = "0x4A0B00", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_CanRespawn", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600299E")]
		 get { } //Length: 29
		[Address(RVA = "0x4A19E0", Offset = "0x4A0BE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_CanRespawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600299F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000CA0")]
	public bool ChatEnabled
	{
		[Address(RVA = "0x4A1920", Offset = "0x4A0B20", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_ChatEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002994")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1A00", Offset = "0x4A0C00", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_ChatEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002995")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000CA1")]
	public bool HealthBarEnabled
	{
		[Address(RVA = "0x4A1940", Offset = "0x4A0B40", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_HealthBarEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002996")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1A20", Offset = "0x4A0C20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_HealthBarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002997")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000CA3")]
	public bool HotbarEnabled
	{
		[Address(RVA = "0x4A1960", Offset = "0x4A0B60", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_HotbarEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600299A")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1A40", Offset = "0x4A0C40", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_HotbarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600299B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000CA2")]
	public bool LeaderboardEnabled
	{
		[Address(RVA = "0x4A1980", Offset = "0x4A0B80", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_LeaderboardEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002998")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1A60", Offset = "0x4A0C60", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_LeaderboardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002999")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000CA4")]
	public bool MenuButtonEnabled
	{
		[Address(RVA = "0x4A19A0", Offset = "0x4A0BA0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_MenuButtonEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600299C")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1A80", Offset = "0x4A0C80", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_MenuButtonEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600299D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C9F")]
	public bool UserCardEnabled
	{
		[Address(RVA = "0x4A19C0", Offset = "0x4A0BC0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "get_UserCardEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002992")]
		 get { } //Length: 29
		[Address(RVA = "0x4A1AA0", Offset = "0x4A0CA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUIService), Member = "set_UserCardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002993")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002991")]
	public CoreUIServiceProxy(CoreUIService target) { }

	[Address(RVA = "0x4A1900", Offset = "0x4A0B00", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_CanRespawn", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600299E")]
	public bool get_CanRespawn() { }

	[Address(RVA = "0x4A1920", Offset = "0x4A0B20", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_ChatEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002994")]
	public bool get_ChatEnabled() { }

	[Address(RVA = "0x4A1940", Offset = "0x4A0B40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_HealthBarEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002996")]
	public bool get_HealthBarEnabled() { }

	[Address(RVA = "0x4A1960", Offset = "0x4A0B60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_HotbarEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600299A")]
	public bool get_HotbarEnabled() { }

	[Address(RVA = "0x4A1980", Offset = "0x4A0B80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_LeaderboardEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002998")]
	public bool get_LeaderboardEnabled() { }

	[Address(RVA = "0x4A19A0", Offset = "0x4A0BA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_MenuButtonEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600299C")]
	public bool get_MenuButtonEnabled() { }

	[Address(RVA = "0x4A19C0", Offset = "0x4A0BC0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "get_UserCardEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002992")]
	public bool get_UserCardEnabled() { }

	[Address(RVA = "0x4A19E0", Offset = "0x4A0BE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_CanRespawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600299F")]
	public void set_CanRespawn(bool value) { }

	[Address(RVA = "0x4A1A00", Offset = "0x4A0C00", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_ChatEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002995")]
	public void set_ChatEnabled(bool value) { }

	[Address(RVA = "0x4A1A20", Offset = "0x4A0C20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_HealthBarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002997")]
	public void set_HealthBarEnabled(bool value) { }

	[Address(RVA = "0x4A1A40", Offset = "0x4A0C40", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_HotbarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600299B")]
	public void set_HotbarEnabled(bool value) { }

	[Address(RVA = "0x4A1A60", Offset = "0x4A0C60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_LeaderboardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002999")]
	public void set_LeaderboardEnabled(bool value) { }

	[Address(RVA = "0x4A1A80", Offset = "0x4A0C80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_MenuButtonEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600299D")]
	public void set_MenuButtonEnabled(bool value) { }

	[Address(RVA = "0x4A1AA0", Offset = "0x4A0CA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUIService), Member = "set_UserCardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002993")]
	public void set_UserCardEnabled(bool value) { }

}

